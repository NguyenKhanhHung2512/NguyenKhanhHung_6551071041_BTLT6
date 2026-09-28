using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện Validating cho từng ô
            txtHoTen.Validating += TxtHoTen_Validating;
            txtCCCD.Validating += TxtCCCD_Validating;
            txtNgayNhan.Validating += TxtNgayNhan_Validating;
            txtNgayTra.Validating += TxtNgayTra_Validating;
            txtSoNguoiLon.Validating += TxtSoNguoiLon_Validating;
            txtSoTreEm.Validating += TxtSoTreEm_Validating;

            // Gán sự kiện Validated (xác nhận field hợp lệ -> nền xanh nhạt Honeydew)
            txtHoTen.Validated += Field_Validated;
            txtCCCD.Validated += Field_Validated;
            txtNgayNhan.Validated += Field_Validated;
            txtNgayTra.Validated += Field_Validated;
            txtSoNguoiLon.Validated += Field_Validated;
            txtSoTreEm.Validated += Field_Validated;

            // Gán sự kiện Click nút Đặt phòng
            btnDatPhong.Click += BtnDatPhong_Click;
        }

        // Báo lỗi: giữ focus (e.Cancel = true), đặt icon lỗi và đổi nền thành MistyRose
        private void BaoLoi(TextBox txt, CancelEventArgs e, string thongBao)
        {
            e.Cancel = true;
            errorProvider1.SetError(txt, thongBao);
            txt.BackColor = Color.MistyRose;
        }

        // 1. Họ tên: không để trống
        private void TxtHoTen_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                BaoLoi(txtHoTen, e, "Họ tên không được để trống!");
            }
        }

        // 2. CCCD: đúng 12 chữ số
        private void TxtCCCD_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtCCCD.Text.Trim(), @"^\d{12}$"))
            {
                BaoLoi(txtCCCD, e, "Số CCCD phải đúng 12 chữ số!");
            }
        }

        // 3. Ngày nhận: parse được định dạng dd/MM/yyyy và >= ngày hôm nay
        private void TxtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            if (!DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan))
            {
                BaoLoi(txtNgayNhan, e, "Ngày nhận phòng phải đúng định dạng dd/MM/yyyy!");
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                BaoLoi(txtNgayNhan, e, "Ngày nhận phòng phải từ ngày hôm nay trở đi!");
            }
        }

        // 4. Ngày trả: parse được dd/MM/yyyy và phải lớn hơn ngày nhận
        private void TxtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            bool parseNhan = DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan);
            bool parseTra = DateTime.TryParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayTra);

            if (!parseTra)
            {
                BaoLoi(txtNgayTra, e, "Ngày trả phòng phải đúng định dạng dd/MM/yyyy!");
            }
            else if (parseNhan && ngayTra.Date <= ngayNhan.Date)
            {
                BaoLoi(txtNgayTra, e, "Ngày trả phòng phải sau ngày nhận phòng!");
            }
        }

        // 5. Số người lớn: nguyên từ 1 đến 4
        private void TxtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out int soNL) || soNL < 1 || soNL > 4)
            {
                BaoLoi(txtSoNguoiLon, e, "Số người lớn phải là số nguyên từ 1 đến 4!");
            }
        }

        // 6. Số trẻ em: nguyên từ 0 đến 3
        private void TxtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoTreEm.Text.Trim(), out int soTE) || soTE < 0 || soTE > 3)
            {
                BaoLoi(txtSoTreEm, e, "Số trẻ em phải là số nguyên từ 0 đến 3!");
            }
        }

        // Sự kiện Validated: khi ô hợp lệ, xóa lỗi và đổi màu nền thành Honeydew
        private void Field_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                errorProvider1.SetError(txt, "");
                txt.BackColor = Color.Honeydew;
            }
        }

        // Sự kiện Đặt phòng
        private void BtnDatPhong_Click(object sender, EventArgs e)
        {
            // Kích hoạt kiểm tra toàn bộ các field
            if (!this.ValidateChildren())
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            int soDem = (ngayTra.Date - ngayNhan.Date).Days;

            string thongBao = $"Đặt phòng thành công!\n\n" +
                              $"- Tên khách: {txtHoTen.Text.Trim()}\n" +
                              $"- Số CCCD: {txtCCCD.Text.Trim()}\n" +
                              $"- Số đêm: {soDem} đêm ({txtNgayNhan.Text.Trim()} đến {txtNgayTra.Text.Trim()})\n" +
                              $"- Số người lớn: {txtSoNguoiLon.Text.Trim()}\n" +
                              $"- Số trẻ em: {txtSoTreEm.Text.Trim()}";

            MessageBox.Show(thongBao, "Thông báo đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}