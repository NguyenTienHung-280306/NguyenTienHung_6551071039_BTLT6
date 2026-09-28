using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormDatPhong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện Validating cho các TextBox (sử dụng tên mới viết hoa chữ T)
            TxtHoTen.Validating += TxtHoTen_Validating;
            TxtCCCD.Validating += TxtCCCD_Validating;
            TxtNgayNhan.Validating += TxtNgayNhan_Validating;
            TxtNgayTra.Validating += TxtNgayTra_Validating;
            TxtSoNguoiLon.Validating += TxtSoNguoiLon_Validating;
            TxtSoTreEm.Validating += TxtSoTreEm_Validating;

            // Gán chung sự kiện Validated cho tất cả TextBox để đổi màu xanh khi hợp lệ
            TxtHoTen.Validated += Control_Validated;
            TxtCCCD.Validated += Control_Validated;
            TxtNgayNhan.Validated += Control_Validated;
            TxtNgayTra.Validated += Control_Validated;
            TxtSoNguoiLon.Validated += Control_Validated;
            TxtSoTreEm.Validated += Control_Validated;
        }

        // Các hàm xử lý
        private void SetError(Control ctrl, CancelEventArgs e, string message)
        {
            e.Cancel = true;
            errorProvider1.SetError(ctrl, message);
            ctrl.BackColor = Color.MistyRose;
        }

        private void ClearError(Control ctrl)
        {
            errorProvider1.SetError(ctrl, "");
            ctrl.BackColor = Color.Honeydew;
        }

        private void TxtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtHoTen.Text))
                SetError(TxtHoTen, e, "Họ tên không được để trống!");
            else
                ClearError(TxtHoTen);
        }

        private void TxtCCCD_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(TxtCCCD.Text, @"^\d{12}$"))
                SetError(TxtCCCD, e, "CCCD phải bao gồm đúng 12 chữ số!");
            else
                ClearError(TxtCCCD);
        }

        private void TxtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.TryParseExact(TxtNgayNhan.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime ngayNhan))
            {
                if (ngayNhan.Date >= DateTime.Today)
                    ClearError(TxtNgayNhan);
                else
                    SetError(TxtNgayNhan, e, "Ngày nhận phòng phải lớn hơn hoặc bằng hôm nay!");
            }
            else
            {
                SetError(TxtNgayNhan, e, "Định dạng ngày không hợp lệ. (dd/MM/yyyy)!");
            }
        }

        private void TxtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            if (DateTime.TryParseExact(TxtNgayTra.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime ngayTra))
            {
                if (DateTime.TryParseExact(TxtNgayNhan.Text, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime ngayNhan))
                {
                    if (ngayTra.Date > ngayNhan.Date)
                        ClearError(TxtNgayTra);
                    else
                        SetError(TxtNgayTra, e, "Ngày trả phòng phải lớn hơn ngày nhận phòng!");
                }
                else
                {
                    SetError(TxtNgayTra, e, "Hãy nhập Ngày nhận hợp lệ trước!");
                }
            }
            else
            {
                SetError(TxtNgayTra, e, "Định dạng ngày không hợp lệ. (dd/MM/yyyy)!");
            }
        }

        private void TxtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(TxtSoNguoiLon.Text, out int soNguoi) && soNguoi >= 1 && soNguoi <= 4)
                ClearError(TxtSoNguoiLon);
            else
                SetError(TxtSoNguoiLon, e, "Số người lớn phải là số nguyên từ 1 đến 4!");
        }

        private void TxtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(TxtSoTreEm.Text, out int soTre) && soTre >= 0 && soTre <= 3)
                ClearError(TxtSoTreEm);
            else
                SetError(TxtSoTreEm, e, "Số trẻ em phải là số nguyên từ 0 đến 3!");
        }

        private void Control_Validated(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.Honeydew;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DateTime ngayNhan = DateTime.ParseExact(TxtNgayNhan.Text, "dd/MM/yyyy", null);
                DateTime ngayTra = DateTime.ParseExact(TxtNgayTra.Text, "dd/MM/yyyy", null);

                int soDem = (ngayTra - ngayNhan).Days;

                string thongBao = $"Đặt phòng thành công!\n" +
                                  $"Khách hàng: {TxtHoTen.Text}\n" +
                                  $"Số đêm: {soDem}\n" +
                                  $"Số người lớn: {TxtSoNguoiLon.Text}, Số trẻ em: {TxtSoTreEm.Text}";

                MessageBox.Show(thongBao, "Thông tin đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}