﻿namespace PROJECT_QUANLY_DONGHO
{
    partial class Home
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(277, 22);
            label1.Name = "label1";
            label1.Size = new Size(220, 46);
            label1.TabIndex = 0;
            label1.Text = "SOUL STORE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(54, 66);
            label2.Name = "label2";
            label2.Size = new Size(182, 35);
            label2.TabIndex = 1;
            label2.Text = "Họ tên : Admin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(54, 115);
            label3.Name = "label3";
            label3.Size = new Size(279, 35);
            label3.TabIndex = 2;
            label3.Text = "Chức vụ : Quản Trị Viên ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(133, 382);
            label4.Name = "label4";
            label4.Size = new Size(170, 28);
            label4.TabIndex = 3;
            label4.Text = "Quản lý tài khoản ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(525, 382);
            label5.Name = "label5";
            label5.Size = new Size(173, 28);
            label5.TabIndex = 4;
            label5.Text = "Quản lý nhân viên ";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.dongho;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(107, 195);
            button1.Name = "button1";
            button1.Size = new Size(208, 169);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.nhanvien;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(507, 195);
            button2.Name = "button2";
            button2.Size = new Size(208, 169);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.dongho1;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(107, 476);
            button3.Name = "button3";
            button3.Size = new Size(208, 169);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(507, 476);
            button4.Name = "button4";
            button4.Size = new Size(208, 169);
            button4.TabIndex = 8;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(130, 667);
            label6.Name = "label6";
            label6.Size = new Size(173, 28);
            label6.TabIndex = 9;
            label6.Text = "Quản lý sản phẩm ";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 872);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Home";
            Text = "Form2";
            Load += Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label6;
    }
}