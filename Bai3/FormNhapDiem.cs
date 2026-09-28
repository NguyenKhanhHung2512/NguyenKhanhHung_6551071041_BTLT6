using System.Globalization;

namespace Bai3
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
            DangKyEnterChuyenField();
        }

        // ---------- Căn giữa nội dung + con trỏ sẵn ở ô Mã HS ----------
        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            CanGiuaNoiDung();
            this.ActiveControl = txtMaHS;
        }

        private void FormNhapDiem_Resize(object sender, EventArgs e)
        {
            CanGiuaNoiDung();
        }

        private void CanGiuaNoiDung()
        {
            if (pnlNoiDung == null) return;
            pnlNoiDung.Left = Math.Max(0, (this.ClientSize.Width - pnlNoiDung.Width) / 2);
            pnlNoiDung.Top = Math.Max(0, (this.ClientSize.Height - pnlNoiDung.Height) / 2);
        }

        // Duyệt tất cả TextBox trên form, đăng ký KeyPress để Enter = chuyển field
        private void DangKyEnterChuyenField()
        {
            foreach (Control c in pnlNoiDung.Controls)
            {
                if (c is TextBox)
                {
                    c.KeyPress += TextBox_KeyPress_Enter;
                }
            }
        }

        private void TextBox_KeyPress_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                return;
            }

            e.Handled = true; // chặn tiếng "bíp" của Windows

            if (sender == txtAnh)
            {
                btnLuu.PerformClick(); // ô cuối cùng -> tự động Lưu
            }
            else
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        // Nhận focus -> bôi xanh toàn bộ nội dung cũ để gõ đè
        private void DiemTextBox_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            // BeginInvoke để SelectAll chạy sau khi focus/click hoàn tất (nếu không click chuột sẽ bỏ bôi xanh)
            tb.BeginInvoke((Action)(() => tb.SelectAll()));
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool hopLe = true;
            hopLe &= KiemTraKhongRong(txtMaHS, "Vui lòng nhập mã học sinh");
            hopLe &= KiemTraKhongRong(txtHoTen, "Vui lòng nhập họ tên");

            decimal toan, van, anh;
            hopLe &= KiemTraDiem(txtToan, out toan);
            hopLe &= KiemTraDiem(txtVan, out van);
            hopLe &= KiemTraDiem(txtAnh, out anh);

            if (!hopLe)
            {
                // Đưa focus về field lỗi đầu tiên
                foreach (TextBox tb in new[] { txtMaHS, txtHoTen, txtToan, txtVan, txtAnh })
                {
                    if (errorProvider1.GetError(tb) != "")
                    {
                        tb.Focus();
                        break;
                    }
                }
                return;
            }

            string dong = txtMaHS.Text.Trim() + " | " + txtHoTen.Text.Trim() +
                          " | T:" + DinhDangDiem(toan) +
                          " V:" + DinhDangDiem(van) +
                          " A:" + DinhDangDiem(anh);
            lstKetQua.Items.Add(dong);

            XoaTrangForm();
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
        }

        private void XoaTrangForm()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();
            txtMaHS.Focus();
        }

        private bool KiemTraKhongRong(TextBox tb, string thongBao)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                errorProvider1.SetError(tb, thongBao);
                return false;
            }
            errorProvider1.SetError(tb, "");
            return true;
        }

        // Điểm hợp lệ: số thực từ 0.0 đến 10.0 (chấp nhận cả dấu '.' lẫn ',')
        private bool KiemTraDiem(TextBox tb, out decimal diem)
        {
            string s = tb.Text.Trim().Replace(',', '.');
            if (decimal.TryParse(s, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out diem)
                && diem >= 0m && diem <= 10m)
            {
                errorProvider1.SetError(tb, "");
                return true;
            }
            errorProvider1.SetError(tb, "Điểm phải là số từ 0.0 đến 10.0");
            return false;
        }

        private string DinhDangDiem(decimal diem)
        {
            return diem.ToString("0.0", CultureInfo.InvariantCulture);
        }
    }
}
