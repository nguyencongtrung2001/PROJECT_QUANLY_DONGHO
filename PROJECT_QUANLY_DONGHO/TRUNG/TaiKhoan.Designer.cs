namespace PROJECT_QUANLY_DONGHO.TRUNG
{
    partial class TaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(263, 19);
            label1.Name = "label1";
            label1.Size = new Size(363, 46);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(53, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 239);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 34);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 34);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(37, 121);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 1;
            label3.Text = "Mật  khẩu : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(37, 66);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản :";
            // 
            // button1
            // 
            button1.Location = new Point(610, 119);
            button1.Name = "button1";
            button1.Size = new Size(125, 44);
            button1.TabIndex = 2;
            button1.Text = "Thêm ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(610, 177);
            button2.Name = "button2";
            button2.Size = new Size(125, 44);
            button2.TabIndex = 3;
            button2.Text = "Sửa ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(610, 232);
            button3.Name = "button3";
            button3.Size = new Size(125, 44);
            button3.TabIndex = 4;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(610, 291);
            button4.Name = "button4";
            button4.Size = new Size(125, 44);
            button4.TabIndex = 5;
            button4.Text = "Tìm kiếm";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(593, 358);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(169, 27);
            textBox3.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 447);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(682, 188);
            dataGridView1.TabIndex = 7;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.icons8_back_64;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(12, 32);
            button5.Name = "button5";
            button5.Size = new Size(41, 34);
            button5.TabIndex = 8;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 687);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "TaiKhoan";
            Text = "Form1";
            Load += TaiKhoan_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Button button5;
    }
}