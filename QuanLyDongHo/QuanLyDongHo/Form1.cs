using System.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuanLyDongHo
{
    public partial class Form1 : Form
    {
        private DataSet dsHoaDon;
        private DataSet dsChiTietHoaDon;

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dsHoaDon = new DataSet();
            dsHoaDon.ReadXml("HoaDon.xml");
            dsChiTietHoaDon = new DataSet();
            dsChiTietHoaDon.ReadXml("ChiTietHoaDon.xml");

            // Hiển thị dữ liệu bảng HoaDon trong dgvHoaDon
            dgvHoaDon.DataSource = dsHoaDon.Tables[0];
        }

        private void SearchHoaDon(string keyword)
        {
            var filteredData = dsHoaDon.Tables[0].AsEnumerable()
                .Where(row => row.Field<string>("MaHoaDon").Contains(keyword) ||
                row.Field<string>("NgayLap").Contains(keyword) ||
                row.Field<string>("MaNV").Contains(keyword) ||
                row.Field<string>("MaKhachHang").Contains(keyword));
            if (filteredData.Any())
            {
                dgvHoaDon.DataSource = filteredData.CopyToDataTable();

            }
            else
            {
                dgvHoaDon.DataSource = null;
                MessageBox.Show("Không thâý hóa đơn nào phù hợp!");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                SearchHoaDon(keyword);

            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
            }
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maHoaDon = dgvHoaDon.Rows[e.RowIndex].Cells["MaHoaDon"].Value.ToString();
                ShowChiTietHoaDon(maHoaDon);
            }
        }

        private void ShowChiTietHoaDon(string maHoaDon)
        {
            var chiTietDaTa = dsChiTietHoaDon.Tables[0].AsEnumerable()
                .Where(row => row.Field<string>("MaHoaDon") == maHoaDon);
            if (chiTietDaTa.Any())
            {
                dgvChiTietHoaDon.DataSource = chiTietDaTa.CopyToDataTable();// Hiển thị chi tiết hóa đơn
            }
            else
            {
                dgvChiTietHoaDon.DataSource = null; // Không có chi tiết cho hóa đơn này
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                // Lấy MaHoaDon từ dòng được chọn
                string maHoaDon = dgvHoaDon.CurrentRow.Cells["MaHoaDon"].Value.ToString();
                ShowChiTietHoaDon(maHoaDon);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết."!);
            }
        }

        private void btnExportToHtml_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow != null)
            {
                string maHoaDon = dgvHoaDon.CurrentRow.Cells["MaHoaDon"].Value?.ToString();
                if (!string.IsNullOrEmpty(maHoaDon))
                {
                    ExportHoaDonToHtml(maHoaDon);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn hợp lệ để xuất.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xuất ra HTML.", "Thông báo");
            }
        }

        private void ExportHoaDonToHtml(string maHoaDon)
        {
            // Lấy dữ liệu hóa đơn
            var hoaDon = dsHoaDon.Tables[0].AsEnumerable()
                .FirstOrDefault(row => row.Field<string>("MaHoaDon") == maHoaDon);

            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn để xuất.", "Thông báo");
                return;
            }

            // Lấy dữ liệu chi tiết hóa đơn
            var chiTietData = dsChiTietHoaDon.Tables[0].AsEnumerable()
                .Where(row => row.Field<string>("MaHoaDon") == maHoaDon);

            // Tạo file HTML
            string htmlFilePath = "HoaDon.html";
            try
            {
                using (StreamWriter writer = new StreamWriter(htmlFilePath))
                {
                    writer.WriteLine("<html>");
                    writer.WriteLine("<head><title>Hóa Đơn</title></head>");
                    writer.WriteLine("<body>");
                    writer.WriteLine("<h1>Thông Tin Hóa Đơn</h1>");
                    writer.WriteLine("<table border='1' cellspacing='0' cellpadding='5'>");

                    // In thông tin chung của hóa đơn
                    writer.WriteLine("<tr><td>Mã Hóa Đơn</td><td>" + hoaDon["MaHoaDon"] + "</td></tr>");
                    writer.WriteLine("<tr><td>Ngày Lập</td><td>" + hoaDon["NgayLap"] + "</td></tr>");
                    writer.WriteLine("<tr><td>Mã Nhân Viên</td><td>" + hoaDon["MaNV"] + "</td></tr>");
                    writer.WriteLine("<tr><td>Mã Khách Hàng</td><td>" + hoaDon["MaKhachHang"] + "</td></tr>");
                    writer.WriteLine("</table>");

                    // In chi tiết hóa đơn
                    writer.WriteLine("<h2>Chi Tiết Hóa Đơn</h2>");
                    writer.WriteLine("<table border='1' cellspacing='0' cellpadding='5'>");
                    writer.WriteLine("<tr><th>Mã Sản Phẩm</th><th>Số Lượng</th><th>Đơn Giá</th></tr>");

                    foreach (var row in chiTietData)
                    {
                        writer.WriteLine("<tr>");
                        writer.WriteLine("<td>" + row["MaSp"] + "</td>");
                        writer.WriteLine("<td>" + row["SoLuong"] + "</td>");
                        writer.WriteLine("<td>" + row["Dongia"] + "</td>");
                        writer.WriteLine("</tr>");
                    }

                    writer.WriteLine("</table>");
                    writer.WriteLine("</body>");
                    writer.WriteLine("</html>");
                }

                MessageBox.Show("Hóa đơn đã được xuất ra file HTML!", "Thông báo");

                // Mở file HTML trong trình duyệt mặc định
                OpenHtmlFile(htmlFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi xuất hóa đơn: " + ex.Message, "Lỗi");
            }
        }

        private void OpenHtmlFile(string filePath)
        {
            try
            {
                // Kiểm tra nếu file tồn tại
                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true // Để mở file bằng trình duyệt mặc định
                    });
                }
                else
                {
                    MessageBox.Show("File không tồn tại!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở file: " + ex.Message, "Lỗi");
            }
        }
    }
}
