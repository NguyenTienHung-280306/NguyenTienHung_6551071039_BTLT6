namespace FormDangKy
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
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtEmail = new TextBox();
            txtXacNhanMK = new TextBox();
            txtMatKhau = new TextBox();
            txtSDT = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(282, 82);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(320, 27);
            txtHoTen.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(282, 203);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 27);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(282, 338);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(320, 27);
            txtXacNhanMK.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(282, 275);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(320, 27);
            txtMatKhau.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(282, 144);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(320, 27);
            txtSDT.TabIndex = 4;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.DarkTurquoise;
            btnDangKy.Location = new Point(282, 389);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(127, 35);
            btnDangKy.TabIndex = 5;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.CausesValidation = false;
            btnHuy.Location = new Point(471, 389);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(131, 35);
            btnHuy.TabIndex = 6;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 86);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 7;
            label1.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(161, 144);
            label2.Name = "label2";
            label2.Size = new Size(115, 23);
            label2.TabIndex = 8;
            label2.Text = "Số điện thoại:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(221, 204);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 9;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(190, 275);
            label4.Name = "label4";
            label4.Size = new Size(86, 23);
            label4.TabIndex = 10;
            label4.Text = "Mật khẩu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(114, 338);
            label5.Name = "label5";
            label5.Size = new Size(162, 23);
            label5.TabIndex = 11;
            label5.Text = "Xác nhận mật khẩu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 41);
            label6.Name = "label6";
            label6.Size = new Size(251, 23);
            label6.TabIndex = 12;
            label6.Text = "Vui lòng nhập đầy đủ thông tin";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, -1);
            label7.Name = "label7";
            label7.Size = new Size(337, 41);
            label7.TabIndex = 13;
            label7.Text = "Đăng ký tài khoản mới";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtSDT);
            Controls.Add(txtMatKhau);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtEmail);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtEmail;
        private TextBox txtXacNhanMK;
        private TextBox txtMatKhau;
        private TextBox txtSDT;
        private Button btnDangKy;
        private Button btnHuy;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ErrorProvider errorProvider1;
    }
}
