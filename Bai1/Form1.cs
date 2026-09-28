using System.Text.RegularExpressions;

namespace Bai1
{
    public partial class Form1 : Form
    {
            public Form1()
        {
            InitializeComponent();
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink; // Không nhấp nháy icon lỗi
        }

        // Kiểm tra toàn bộ các field. Field nào sai -> SetError(control, "thông báo lỗi"),
        // field nào đúng -> SetError(control, "") để xóa icon lỗi.
        // Dùng toán tử &= (không short-circuit) để mọi field đều được kiểm tra,
        // nhờ đó tất cả icon lỗi hiện cùng lúc chứ không dừng ở lỗi đầu tiên.
        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            // (1) Họ tên: không trống, tối thiểu 3 ký tự
            string hoTen = txtHoTen.Text.Trim();
            string loiHoTen = hoTen.Length == 0 ? "Họ tên không được để trống"
                            : hoTen.Length < 3 ? "Họ tên phải có tối thiểu 3 ký tự"
                            : "";
            hopLe &= DatLoi(txtHoTen, loiHoTen);

            // (2) Số điện thoại: đúng 10 chữ số, bắt đầu bằng "0"
            string loiSDT = Regex.IsMatch(txtSDT.Text, @"^0[0-9]{9}$")
                            ? "" : "Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng 0";
            hopLe &= DatLoi(txtSDT, loiSDT);

            // (3) Email: có "@" và có "." phía sau "@"
            string email = txtEmail.Text.Trim();
            int viTriAt = email.IndexOf('@');
            bool emailDung = viTriAt > 0
                             && email.IndexOf('.', viTriAt + 1) > viTriAt + 1
                             && !email.EndsWith(".");
            hopLe &= DatLoi(txtEmail, emailDung ? "" : "Email không đúng định dạng");

            // (4) Mật khẩu: tối thiểu 6 ký tự
            string loiMatKhau = txtMatKhau.Text.Length < 6 ? "Mật khẩu phải có tối thiểu 6 ký tự" : "";
            hopLe &= DatLoi(txtMatKhau, loiMatKhau);

            // (5) Xác nhận mật khẩu: phải khớp với mật khẩu
            string loiXacNhan = txtXacNhanMK.Text.Length == 0 ? "Vui lòng nhập lại mật khẩu để xác nhận"
                              : txtXacNhanMK.Text != txtMatKhau.Text ? "Mật khẩu xác nhận không khớp"
                              : "";
            hopLe &= DatLoi(txtXacNhanMK, loiXacNhan);

            return hopLe;
        }

        // Gán (hoặc xóa) lỗi cho control. Trả về true nếu field hợp lệ.
        private bool DatLoi(Control control, string thongBaoLoi)
        {
            errorProvider1.SetError(control, thongBaoLoi);
            return thongBaoLoi == "";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show("Đăng ký thành công! Chào mừng " + txtHoTen.Text,
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();
        }
    }
}