namespace FormDangKy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            // 1. Kiểm tra txtHoTen: không để trống và tối thiểu 3 ký tự[cite: 1]
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || txtHoTen.Text.Trim().Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống và phải có ít nhất 3 ký tự.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // 2. Kiểm tra txtSDT: đúng 10 chữ số, bắt đầu bằng "0"[cite: 1]
            string sdt = txtSDT.Text.Trim();
            if (sdt.Length != 10 || !sdt.StartsWith("0") || !sdt.All(char.IsDigit))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải có đúng 10 chữ số và bắt đầu bằng số 0.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // 3. Kiểm tra txtEmail: chứa "@" và "." phía sau "@"[cite: 1]
            string email = txtEmail.Text.Trim();
            int indexAt = email.IndexOf('@');
            int indexDot = email.LastIndexOf('.');

            if (indexAt == -1 || indexDot == -1 || indexDot < indexAt)
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ (phải chứa '@' và dấu '.' nằm sau '@').");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            // 4. Kiểm tra txtMatKhau: tối thiểu 6 ký tự[cite: 1]
            if (txtMatKhau.Text.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // 5. Kiểm tra txtXacNhanMK: phải khớp với txtMatKhau[cite: 1]
            if (string.IsNullOrEmpty(txtXacNhanMK.Text) || txtXacNhanMK.Text != txtMatKhau.Text)
            {
                errorProvider1.SetError(txtXacNhanMK, "Xác nhận mật khẩu không khớp.");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            // Nếu true thì hiện thông báo chào mừng[cite: 1]
            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false; // Ngăn chặn validate
            errorProvider1.Clear();          // Xóa toàn bộ lỗi
            this.Close();                    // Đóng form
        }
    }
    }
