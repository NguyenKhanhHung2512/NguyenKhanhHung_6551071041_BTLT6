namespace Bai5
{
    partial class FormBanVe
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlNoiDung = new Panel();
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblPhim = new Label();
            cboPhim = new ComboBox();
            lblSuatChieu = new Label();
            cboSuatChieu = new ComboBox();
            lblGheDaChon = new Label();
            txtGheDaChon = new TextBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            pnlNoiDung.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNoiDung
            // 
            pnlNoiDung.Controls.Add(lblTenKhach);
            pnlNoiDung.Controls.Add(txtTenKhach);
            pnlNoiDung.Controls.Add(lblPhim);
            pnlNoiDung.Controls.Add(cboPhim);
            pnlNoiDung.Controls.Add(lblSuatChieu);
            pnlNoiDung.Controls.Add(cboSuatChieu);
            pnlNoiDung.Controls.Add(lblGheDaChon);
            pnlNoiDung.Controls.Add(txtGheDaChon);
            pnlNoiDung.Controls.Add(btnChonGhe);
            pnlNoiDung.Controls.Add(btnDatVe);
            pnlNoiDung.Controls.Add(btnHuy);
            pnlNoiDung.Location = new Point(60, 30);
            pnlNoiDung.Name = "pnlNoiDung";
            pnlNoiDung.Size = new Size(440, 410);
            pnlNoiDung.TabIndex = 0;
            // 
            // lblTenKhach
            // 
            lblTenKhach.AutoSize = true;
            lblTenKhach.Location = new Point(20, 10);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(96, 25);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(20, 38);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(400, 31);
            txtTenKhach.TabIndex = 1;
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Location = new Point(20, 90);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(56, 25);
            lblPhim.TabIndex = 2;
            lblPhim.Text = "Phim:";
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.FormattingEnabled = true;
            cboPhim.Items.AddRange(new object[] { "Chiến binh cuối cùng", "Đường về nhà", "Biệt đội săn ma", "Mùa hè năm ấy" });
            cboPhim.Location = new Point(20, 118);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(400, 33);
            cboPhim.TabIndex = 3;
            // 
            // lblSuatChieu
            // 
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Location = new Point(20, 170);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(99, 25);
            lblSuatChieu.TabIndex = 4;
            lblSuatChieu.Text = "Suất chiếu:";
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Items.AddRange(new object[] { "09:00", "12:30", "15:00", "19:00", "21:30" });
            cboSuatChieu.Location = new Point(20, 198);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(400, 33);
            cboSuatChieu.TabIndex = 5;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Location = new Point(20, 250);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(112, 25);
            lblGheDaChon.TabIndex = 6;
            lblGheDaChon.Text = "Ghế đã chọn:";
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Location = new Point(20, 278);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(400, 31);
            txtGheDaChon.TabIndex = 7;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(20, 345);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(125, 48);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(157, 345);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(125, 48);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(295, 345);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(125, 48);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 470);
            Controls.Add(pnlNoiDung);
            Name = "FormBanVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán vé xem phim";
            Load += FormBanVe_Load;
            Resize += FormBanVe_Resize;
            pnlNoiDung.ResumeLayout(false);
            pnlNoiDung.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNoiDung;
        private Label lblTenKhach;
        private TextBox txtTenKhach;
        private Label lblPhim;
        private ComboBox cboPhim;
        private Label lblSuatChieu;
        private ComboBox cboSuatChieu;
        private Label lblGheDaChon;
        private TextBox txtGheDaChon;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}
