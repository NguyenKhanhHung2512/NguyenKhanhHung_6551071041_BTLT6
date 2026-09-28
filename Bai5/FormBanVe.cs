namespace Bai5
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
        }

        // ---------- Căn giữa nội dung + con trỏ sẵn ở ô Tên khách ----------
        private void FormBanVe_Load(object sender, EventArgs e)
        {
            CanGiuaNoiDung();
            this.ActiveControl = txtTenKhach;
        }

        private void FormBanVe_Resize(object sender, EventArgs e)
        {
            CanGiuaNoiDung();
        }

        private void CanGiuaNoiDung()
        {
            if (pnlNoiDung == null) return;
            pnlNoiDung.Left = Math.Max(0, (this.ClientSize.Width - pnlNoiDung.Width) / 2);
            pnlNoiDung.Top = Math.Max(0, (this.ClientSize.Height - pnlNoiDung.Height) / 2);
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            // using => dialog được Dispose ngay khi đóng. ShowDialog chặn form chính (modal)
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text)
                || cboPhim.SelectedIndex < 0
                || cboSuatChieu.SelectedIndex < 0
                || string.IsNullOrEmpty(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ: Tên khách, Phim, Suất chiếu và Ghế.",
                                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "Đặt vé thành công!\n\n" +
                "Khách hàng: " + txtTenKhach.Text.Trim() + "\n" +
                "Phim: " + cboPhim.SelectedItem + "\n" +
                "Suất chiếu: " + cboSuatChieu.SelectedItem + "\n" +
                "Ghế: " + txtGheDaChon.Text + "\n" +
                "Giá: 75.000đ/vé",
                "Xác nhận đặt vé",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
