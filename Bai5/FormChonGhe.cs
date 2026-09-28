using System.ComponentModel;

namespace Bai5
{
    public partial class FormChonGhe : Form
    {
        // Form chính đọc kết quả qua thuộc tính này; chỉ form này được gán
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string GheChon { get; private set; } = "";

        // Constructor không tham số để Visual Studio Designer khởi tạo được form này
        public FormChonGhe() : this("")
        {
        }

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();

            GheChon = gheHienTai ?? "";

            // Chọn sẵn ghế cũ (nếu có)
            if (!string.IsNullOrEmpty(gheHienTai))
            {
                lstGhe.SelectedItem = gheHienTai;
            }
            CapNhatNhan();
        }

        private void CapNhatNhan()
        {
            lblGheDaChon.Text = lstGhe.SelectedItem == null
                ? "Chưa chọn ghế"
                : "Đang chọn: " + lstGhe.SelectedItem;
        }

        private void lstGhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatNhan();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn một ghế trước khi xác nhận",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // không gán DialogResult => dialog vẫn mở
            }

            GheChon = lstGhe.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
