namespace QuanLyDongHo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel1 = new Panel();
            dgvHoaDon = new DataGridView();
            panel2 = new Panel();
            btnShowDetails = new Button();
            dgvChiTietHoaDon = new DataGridView();
            btnExportToHtml = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(480, 26);
            label1.Name = "label1";
            label1.Size = new Size(161, 46);
            label1.TabIndex = 0;
            label1.Text = "Hóa Đơn";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(367, 75);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(340, 34);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Properties.Resources.free_search_icon_2911_thumb;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(732, 72);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 46);
            btnSearch.TabIndex = 2;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(dgvHoaDon);
            panel1.Location = new Point(49, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 168);
            panel1.TabIndex = 3;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDon.Location = new Point(147, 21);
            dgvHoaDon.Name = "dgvHoaDon";
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.Size = new Size(705, 119);
            dgvHoaDon.TabIndex = 0;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 255);
            panel2.Controls.Add(btnShowDetails);
            panel2.Controls.Add(dgvChiTietHoaDon);
            panel2.Location = new Point(49, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(1030, 152);
            panel2.TabIndex = 4;
            // 
            // btnShowDetails
            // 
            btnShowDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowDetails.ForeColor = Color.Blue;
            btnShowDetails.Location = new Point(872, 63);
            btnShowDetails.Name = "btnShowDetails";
            btnShowDetails.Size = new Size(129, 41);
            btnShowDetails.TabIndex = 5;
            btnShowDetails.Text = "Hiển thị chi tiết";
            btnShowDetails.UseVisualStyleBackColor = true;
            btnShowDetails.Click += btnShowDetails_Click;
            // 
            // dgvChiTietHoaDon
            // 
            dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHoaDon.Location = new Point(147, 24);
            dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            dgvChiTietHoaDon.RowHeadersWidth = 51;
            dgvChiTietHoaDon.Size = new Size(705, 109);
            dgvChiTietHoaDon.TabIndex = 0;
            // 
            // btnExportToHtml
            // 
            btnExportToHtml.BackColor = Color.Blue;
            btnExportToHtml.BackgroundImageLayout = ImageLayout.None;
            btnExportToHtml.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportToHtml.ForeColor = Color.White;
            btnExportToHtml.Location = new Point(881, 300);
            btnExportToHtml.Name = "btnExportToHtml";
            btnExportToHtml.Size = new Size(112, 31);
            btnExportToHtml.TabIndex = 5;
            btnExportToHtml.Text = "In Hóa Đơn";
            btnExportToHtml.UseVisualStyleBackColor = false;
            btnExportToHtml.Click += btnExportToHtml_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 541);
            Controls.Add(btnExportToHtml);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHoaDon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panel1;
        private DataGridView dgvHoaDon;
        private Panel panel2;
        private DataGridView dgvChiTietHoaDon;
        private Button btnShowDetails;
        private Button btnExportToHtml;
    }
}
