using System;
using System.Windows.Forms;

namespace Bai6
{
    [System.ComponentModel.DesignerCategory("Code")]
    public class FormChinh : Form
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuTep, mnuMoGhiChu, mnuSapXep, mnuThoat;
        private ToolStripMenuItem mnuCuaSo, mnuXepTang, mnuXepNgang, mnuXepDoc;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSoGhiChu;

        private int _soThuTu = 0; // đánh số thứ tự cho tiêu đề mặc định của ghi chú

        public FormChinh()
        {
            InitializeComponent();
            CapNhatTrangThai();
        }

        private void InitializeComponent()
        {
            this.Text = "Note Manager - Quản lý ghi chú công việc";
            this.Width = 900;
            this.Height = 650;
            this.IsMdiContainer = true;
            this.StartPosition = FormStartPosition.CenterScreen;

            // ---------- MenuStrip ----------
            menuStrip1 = new MenuStrip();

            mnuTep = new ToolStripMenuItem("Tệp");
            mnuMoGhiChu = new ToolStripMenuItem("Mở ghi chú mới");
            mnuMoGhiChu.ShortcutKeys = Keys.Control | Keys.N;
            mnuSapXep = new ToolStripMenuItem("Sắp xếp cửa sổ");
            mnuThoat = new ToolStripMenuItem("Thoát");
            mnuTep.DropDownItems.AddRange(new ToolStripItem[]
            {
                mnuMoGhiChu, mnuSapXep, new ToolStripSeparator(), mnuThoat
            });

            mnuCuaSo = new ToolStripMenuItem("Cửa sổ");
            mnuXepTang = new ToolStripMenuItem("Xếp tầng");
            mnuXepNgang = new ToolStripMenuItem("Xếp ngang");
            mnuXepDoc = new ToolStripMenuItem("Xếp dọc");
            mnuCuaSo.DropDownItems.AddRange(new ToolStripItem[] { mnuXepTang, mnuXepNgang, mnuXepDoc });

            menuStrip1.Items.Add(mnuTep);
            menuStrip1.Items.Add(mnuCuaSo);

            mnuMoGhiChu.Click += mnuMoGhiChu_Click;
            mnuSapXep.Click += mnuSapXep_Click;
            mnuThoat.Click += mnuThoat_Click;
            mnuXepTang.Click += mnuXepTang_Click;
            mnuXepNgang.Click += mnuXepNgang_Click;
            mnuXepDoc.Click += mnuXepDoc_Click;

            // ---------- StatusStrip ----------
            statusStrip1 = new StatusStrip();
            lblSoGhiChu = new ToolStripStatusLabel();
            statusStrip1.Items.Add(lblSoGhiChu);

            this.Controls.Add(menuStrip1);
            this.Controls.Add(statusStrip1);
            this.MainMenuStrip = menuStrip1;

            // Mỗi khi có form con được kích hoạt/đóng lại -> cập nhật số lượng
            this.MdiChildActivate += (s, e) => CapNhatTrangThai();
        }

        private void CapNhatTrangThai()
        {
            lblSoGhiChu.Text = "Số ghi chú đang mở: " + this.MdiChildren.Length;
        }

        private void mnuMoGhiChu_Click(object sender, EventArgs e)
        {
            FormGhiChu f = new FormGhiChu();
            f.MdiParent = this;                 // MDI Child => dùng Show(), không dùng ShowDialog()
            f.Text = "Ghi chú " + (++_soThuTu);

            // Khi form con đóng: cập nhật lại sau khi nó đã được gỡ khỏi MdiChildren
            f.FormClosed += (s, args) =>
            {
                if (IsHandleCreated && !IsDisposed)
                {
                    BeginInvoke((Action)CapNhatTrangThai);
                }
            };

            f.Show();
            CapNhatTrangThai();
        }

        // "Sắp xếp cửa sổ" ở menu Tệp: xếp tầng các cửa sổ con cho gọn
        private void mnuSapXep_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
