namespace Bai4
{
    public partial class FormDanhBa : Form
    {
        // Index của liên hệ đang sửa (-1 = đang ở chế độ thêm mới)
        private int _indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();
        }

        // ---------- Căn giữa nội dung + con trỏ sẵn ở ô Tên ----------
        private void FormDanhBa_Load(object sender, EventArgs e)
        {
            CanGiuaNoiDung();
            this.ActiveControl = txtTen;
        }

        private void FormDanhBa_Resize(object sender, EventArgs e)
        {
            CanGiuaNoiDung();
        }

        private void CanGiuaNoiDung()
        {
            if (pnlNoiDung == null) return;
            pnlNoiDung.Left = Math.Max(0, (this.ClientSize.Width - pnlNoiDung.Width) / 2);
            pnlNoiDung.Top = Math.Max(0, (this.ClientSize.Height - pnlNoiDung.Height) / 2);
        }

        // Tách "Tên - SĐT" theo dấu " - " cuối cùng
        private void TachLienHe(string item, out string ten, out string sdt)
        {
            int idx = item.LastIndexOf(" - ", StringComparison.Ordinal);
            if (idx < 0)
            {
                ten = item;
                sdt = "";
            }
            else
            {
                ten = item.Substring(0, idx);
                sdt = item.Substring(idx + 3);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (ten == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên và Số điện thoại",
                                "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string item = ten + " - " + sdt;

            if (_indexDangSua >= 0 && _indexDangSua < lstLienHe.Items.Count)
            {
                // Chế độ sửa: cập nhật lại đúng dòng đang sửa
                lstLienHe.Items[_indexDangSua] = item;
                _indexDangSua = -1;
                MessageBox.Show("Cập nhật thành công.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lstLienHe.Items.Add(item);
                MessageBox.Show("Thêm thành công", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtTen.Clear();
            txtSDT.Clear();
            txtTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ten, sdt;
            TachLienHe(lstLienHe.SelectedItem.ToString(), out ten, out sdt);
            txtTen.Text = ten;
            txtSDT.Text = sdt;
            _indexDangSua = lstLienHe.SelectedIndex; // nhớ vị trí, chờ bấm Thêm để cập nhật
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idx = lstLienHe.SelectedIndex;
            string ten, sdt;
            TachLienHe(lstLienHe.SelectedItem.ToString(), out ten, out sdt);

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa liên hệ " + ten + "?\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq != DialogResult.Yes)
            {
                return;
            }

            lstLienHe.Items.RemoveAt(idx);

            // Giữ _indexDangSua luôn trỏ đúng dòng sau khi xóa
            if (idx == _indexDangSua)
            {
                _indexDangSua = -1;
                txtTen.Clear();
                txtSDT.Clear();
            }
            else if (idx < _indexDangSua)
            {
                _indexDangSua--;
            }

            MessageBox.Show("Xóa liên hệ thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close(); // FormClosing sẽ tự hỏi xác nhận nếu còn dữ liệu chưa lưu
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTen.Text.Length > 0 || txtSDT.Text.Length > 0)
            {
                DialogResult kq = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Xác nhận thoát",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (kq == DialogResult.Cancel)
                {
                    e.Cancel = true;          // ở lại form
                }
                else if (kq == DialogResult.No)
                {
                    txtTen.Clear();           // xóa dữ liệu dở rồi thoát
                    txtSDT.Clear();
                }
                // Yes: thoát luôn
            }
        }
    }
}
