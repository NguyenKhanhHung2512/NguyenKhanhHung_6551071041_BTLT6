using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bai6
{
    [System.ComponentModel.DesignerCategory("Code")]
    public class FormGhiChu : Form
    {
        private const int GioiHanKyTu = 500;

        private Label lblTieuDeForm, lblTieuDe, lblNoiDung, lblDemKyTu, lblUuTien;
        private TextBox txtTieuDe, txtNoiDung;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private ErrorProvider errorProvider1;

        private bool _daThayDoi = false;
        private readonly Color _mauNutGoc = Color.SteelBlue;
        private readonly Color _mauNutHover = Color.DodgerBlue;

        public FormGhiChu()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.ClientSize = new Size(400, 350);
            this.MinimumSize = new Size(340, 340);
            this.KeyPreview = true; // để Form bắt được Ctrl+S / Escape dù đang gõ trong TextBox

            // Cho phép rời ô lỗi (vẫn báo lỗi) để không bị kẹt khi muốn đóng cửa sổ/con
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;

            errorProvider1 = new ErrorProvider();
            errorProvider1.ContainerControl = this;

            // Thanh tiêu đề tự vẽ: double-click để phóng to/thu nhỏ
            lblTieuDeForm = new Label()
            {
                Text = "Ghi chú công việc",
                Dock = DockStyle.Top,
                Height = 30,
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };

            lblTieuDe = new Label() { Text = "Tiêu đề", Left = 15, Top = 45, Width = 200 };
            txtTieuDe = new TextBox() { Left = 15, Top = 68, Width = 350, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right };

            lblNoiDung = new Label() { Text = "Nội dung", Left = 15, Top = 105, Width = 150 };
            lblDemKyTu = new Label()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Text = "0/" + GioiHanKyTu,
                Left = 265,
                Top = 105,
                Width = 120,
                TextAlign = ContentAlignment.TopRight
            };
            txtNoiDung = new TextBox()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Left = 15,
                Top = 128,
                Width = 370,
                Height = 130,
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };

            lblUuTien = new Label() { Text = "Priority:", Left = 15, Top = 272, Width = 150, Anchor = AnchorStyles.Bottom | AnchorStyles.Left };
            cboMucDoUuTien = new ComboBox()
            {
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                Left = 15,
                Top = 295,
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
            cboMucDoUuTien.SelectedIndex = 1;

            btnLuuGhiChu = new Button()
            {
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Text = "Lưu",
                Left = 285,
                Top = 291,
                Width = 100,
                Height = 32,
                FlatStyle = FlatStyle.Flat,
                BackColor = _mauNutGoc,
                ForeColor = Color.White,
                UseVisualStyleBackColor = false
            };
            btnLuuGhiChu.FlatAppearance.BorderColor = _mauNutGoc;

            this.Controls.AddRange(new Control[]
            {
                lblTieuDeForm, lblTieuDe, txtTieuDe, lblNoiDung, lblDemKyTu, txtNoiDung,
                lblUuTien, cboMucDoUuTien, btnLuuGhiChu
            });

            this.ActiveControl = txtTieuDe; // con trỏ nằm sẵn ở ô Tiêu đề

            // ---------- Sự kiện ----------
            this.KeyDown += FormGhiChu_KeyDown;
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;

            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;

            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;

            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;

            // Theo dõi thay đổi để Escape biết có cần hỏi xác nhận không
            txtTieuDe.TextChanged += (s, e) => _daThayDoi = true;
            txtNoiDung.TextChanged += (s, e) => _daThayDoi = true;
            cboMucDoUuTien.SelectedIndexChanged += (s, e) => _daThayDoi = true;
        }

        // ---------- ③ Bàn phím & chuột ----------
        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                btnLuuGhiChu.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                if (!_daThayDoi)
                {
                    this.Close();
                    return;
                }

                DialogResult kq = MessageBox.Show(
                    "Ghi chú đã thay đổi. Bạn có chắc muốn đóng ghi chú này?",
                    "Xác nhận đóng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (kq == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        // Giới hạn tối đa 500 ký tự: chặn ký tự thêm khi đã đầy
        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool laKyTuDieuKhien = char.IsControl(e.KeyChar); // Backspace, Enter... vẫn cho phép
            int conLai = GioiHanKyTu - (txtNoiDung.TextLength - txtNoiDung.SelectionLength);

            if (!laKyTuDieuKhien && conLai <= 0)
            {
                e.Handled = true;
            }
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            // Phòng trường hợp dán (Ctrl+V) làm vượt giới hạn
            if (txtNoiDung.TextLength > GioiHanKyTu)
            {
                txtNoiDung.Text = txtNoiDung.Text.Substring(0, GioiHanKyTu);
                txtNoiDung.SelectionStart = txtNoiDung.TextLength;
            }
            lblDemKyTu.Text = txtNoiDung.TextLength + "/" + GioiHanKyTu;
        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = (this.WindowState == FormWindowState.Maximized)
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = _mauNutHover;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = _mauNutGoc;
        }

        // ---------- ④ Validating / Validated ----------
        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            string tieuDe = txtTieuDe.Text.Trim();
            string loi = "";

            if (tieuDe.Length == 0)
                loi = "Tiêu đề không được để trống";
            else if (tieuDe.Length > 50)
                loi = "Tiêu đề tối đa 50 ký tự";

            if (loi != "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, loi);
                txtTieuDe.BackColor = Color.MistyRose;
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            txtTieuDe.BackColor = Color.White;
            errorProvider1.SetError(txtTieuDe, "");
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            // Kích hoạt Validating của toàn bộ control trên form; false => còn lỗi
            if (!this.ValidateChildren())
            {
                return;
            }

            this.Text = txtTieuDe.Text.Trim();
            _daThayDoi = false;

            MessageBox.Show("Đã lưu ghi chú", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
