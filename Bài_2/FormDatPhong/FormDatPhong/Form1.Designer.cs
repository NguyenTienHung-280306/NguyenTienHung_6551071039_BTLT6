namespace FormDatPhong
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
            TxtHoTen = new TextBox();
            TxtCCCD = new TextBox();
            TxtNgayNhan = new TextBox();
            TxtNgayTra = new TextBox();
            TxtSoNguoiLon = new TextBox();
            TxtSoTreEm = new TextBox();
            btnDatPhong = new Button();
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
            // TxtHoTen
            // 
            TxtHoTen.Location = new Point(230, 35);
            TxtHoTen.Name = "TxtHoTen";
            TxtHoTen.Size = new Size(321, 27);
            TxtHoTen.TabIndex = 0;
            // 
            // TxtCCCD
            // 
            TxtCCCD.Location = new Point(230, 95);
            TxtCCCD.Name = "TxtCCCD";
            TxtCCCD.Size = new Size(321, 27);
            TxtCCCD.TabIndex = 1;
            // 
            // TxtNgayNhan
            // 
            TxtNgayNhan.Location = new Point(230, 161);
            TxtNgayNhan.Name = "TxtNgayNhan";
            TxtNgayNhan.Size = new Size(321, 27);
            TxtNgayNhan.TabIndex = 2;
            // 
            // TxtNgayTra
            // 
            TxtNgayTra.Location = new Point(230, 229);
            TxtNgayTra.Name = "TxtNgayTra";
            TxtNgayTra.Size = new Size(321, 27);
            TxtNgayTra.TabIndex = 3;
            // 
            // TxtSoNguoiLon
            // 
            TxtSoNguoiLon.Location = new Point(230, 300);
            TxtSoNguoiLon.Name = "TxtSoNguoiLon";
            TxtSoNguoiLon.Size = new Size(321, 27);
            TxtSoNguoiLon.TabIndex = 4;
            // 
            // TxtSoTreEm
            // 
            TxtSoTreEm.Location = new Point(230, 366);
            TxtSoTreEm.Name = "TxtSoTreEm";
            TxtSoTreEm.Size = new Size(321, 27);
            TxtSoTreEm.TabIndex = 5;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = SystemColors.Highlight;
            btnDatPhong.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDatPhong.ForeColor = Color.Crimson;
            btnDatPhong.Location = new Point(230, 409);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(321, 35);
            btnDatPhong.TabIndex = 6;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 7;
            label1.Text = "Họ tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(230, 69);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 8;
            label2.Text = "Số CCCD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(230, 135);
            label3.Name = "label3";
            label3.Size = new Size(153, 23);
            label3.TabIndex = 9;
            label3.Text = "Ngày nhận phòng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 203);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(230, 274);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 11;
            label5.Text = "Số người lớn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(230, 340);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 12;
            label6.Text = "Số trẻ em:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(230, 203);
            label7.Name = "label7";
            label7.Size = new Size(135, 23);
            label7.TabIndex = 13;
            label7.Text = "Ngày trả phòng:";
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
            Controls.Add(btnDatPhong);
            Controls.Add(TxtSoTreEm);
            Controls.Add(TxtSoNguoiLon);
            Controls.Add(TxtNgayTra);
            Controls.Add(TxtNgayNhan);
            Controls.Add(TxtCCCD);
            Controls.Add(TxtHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtHoTen;
        private TextBox TxtCCCD;
        private TextBox TxtNgayNhan;
        private TextBox TxtNgayTra;
        private TextBox TxtSoNguoiLon;
        private TextBox TxtSoTreEm;
        private Button btnDatPhong;
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
