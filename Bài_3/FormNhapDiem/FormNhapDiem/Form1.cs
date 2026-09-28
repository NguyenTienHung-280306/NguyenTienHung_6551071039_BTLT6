using System;
using System.Windows.Forms;

namespace FormNhapDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Yêu cầu 2: Gọi hàm đăng ký phím Enter chuyển field trong constructor
            DangKyEnterChuyenField();

            // Yêu cầu 3: Đăng ký sự kiện nhận Focus cho các ô điểm số
            txtToan.Enter += TxtDiem_Enter;
            txtVan.Enter += TxtDiem_Enter;
            txtAnh.Enter += TxtDiem_Enter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sự kiện Load form (nếu không dùng có thể để trống)
        }

        // ================= CÁC HÀM XỬ LÝ THEO YÊU CẦU ĐỀ BÀI =================

        // Yêu cầu 2: Hàm duyệt TextBox để cấu hình phím Enter
        private void DangKyEnterChuyenField()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    // Đăng ký sự kiện KeyPress cho tất cả TextBox trên form
                    ctrl.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu phím bấm là Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn tiếng "beep" mặc định của Windows

                TextBox txt = sender as TextBox;

                // Riêng txtAnh khi Enter thì gọi sự kiện Click của nút Lưu
                if (txt != null && txt.Name == "txtAnh")
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    // Chuyển focus sang control tiếp theo theo thứ tự TabIndex
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        // Yêu cầu 3: Bôi đen toàn bộ nội dung cũ khi nhận focus để gõ đè
        private void TxtDiem_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.SelectAll();
            }
        }

        // Yêu cầu 4: Xử lý sự kiện nhấn nút Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Giả định bạn đã kéo ErrorProvider có tên là errorProvider1 vào form
            errorProvider1.Clear(); // Xóa các lỗi cũ trước khi kiểm tra mới
            bool isValid = true;
            decimal diemToan = 0, diemVan = 0, diemAnh = 0;

            // Hàm cục bộ (Local function) để kiểm tra điểm hợp lệ (từ 0.0 đến 10.0)
            bool KiemTraDiem(TextBox txt, out decimal diem)
            {
                if (!decimal.TryParse(txt.Text, out diem) || diem < 0m || diem > 10m)
                {
                    errorProvider1.SetError(txt, "Điểm phải là số từ 0.0 đến 10.0");
                    return false; // Không hợp lệ
                }
                return true; // Hợp lệ
            }

            // Kiểm tra 3 điểm
            if (!KiemTraDiem(txtToan, out diemToan)) isValid = false;
            if (!KiemTraDiem(txtVan, out diemVan)) isValid = false;
            if (!KiemTraDiem(txtAnh, out diemAnh)) isValid = false;

            // Nếu tất cả hợp lệ, thêm vào ListBox và xóa trắng
            if (isValid)
            {
                // Giả định bạn đã kéo ListBox có tên là lstDanhSach vào form
                string thongTin = $"[{txtMaHS.Text}] | [{txtHoTen.Text}] | T:[{diemToan}] V:[{diemVan}] A:[{diemAnh}]";
                lstDanhSach.Items.Add(thongTin);

                // Xóa trắng Form và focus về txtMaHS
                btnXoaTrang.PerformClick();
            }
        }

        // Hàm hỗ trợ xóa trắng giao diện (nối vào sự kiện Click của nút Xóa Trắng)
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();

            errorProvider1.Clear();

            // Focus về ô đầu tiên
            txtMaHS.Focus();
        }
    }
}