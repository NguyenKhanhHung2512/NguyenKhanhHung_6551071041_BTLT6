namespace Bai3
{
    partial class FormNhapDiem
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
            components = new System.ComponentModel.Container();
            pnlNoiDung = new Panel();
            lblMaHS = new Label();
            lblHoTen = new Label();
            lblToan = new Label();
            lblVan = new Label();
            lblAnh = new Label();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            pnlNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlNoiDung
            // 
            pnlNoiDung.Controls.Add(lblMaHS);
            pnlNoiDung.Controls.Add(lblHoTen);
            pnlNoiDung.Controls.Add(lblToan);
            pnlNoiDung.Controls.Add(lblVan);
            pnlNoiDung.Controls.Add(lblAnh);
            pnlNoiDung.Controls.Add(txtMaHS);
            pnlNoiDung.Controls.Add(txtHoTen);
            pnlNoiDung.Controls.Add(txtToan);
            pnlNoiDung.Controls.Add(txtVan);
            pnlNoiDung.Controls.Add(txtAnh);
            pnlNoiDung.Controls.Add(btnLuu);
            pnlNoiDung.Controls.Add(btnXoaTrang);
            pnlNoiDung.Controls.Add(lstKetQua);
            pnlNoiDung.Location = new Point(50, 30);
            pnlNoiDung.Name = "pnlNoiDung";
            pnlNoiDung.Size = new Size(760, 470);
            pnlNoiDung.TabIndex = 13;
            // 
            // lblMaHS
            // 
            lblMaHS.AutoSize = true;
            lblMaHS.Location = new Point(15, 15);
            lblMaHS.Name = "lblMaHS";
            lblMaHS.Size = new Size(60, 25);
            lblMaHS.TabIndex = 7;
            lblMaHS.Text = "Mã HS";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(160, 15);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(66, 25);
            lblHoTen.TabIndex = 8;
            lblHoTen.Text = "Họ tên";
            // 
            // lblToan
            // 
            lblToan.AutoSize = true;
            lblToan.Location = new Point(385, 15);
            lblToan.Name = "lblToan";
            lblToan.Size = new Size(96, 25);
            lblToan.TabIndex = 9;
            lblToan.Text = "Điểm Toán";
            // 
            // lblVan
            // 
            lblVan.AutoSize = true;
            lblVan.Location = new Point(510, 15);
            lblVan.Name = "lblVan";
            lblVan.Size = new Size(90, 25);
            lblVan.TabIndex = 10;
            lblVan.Text = "Điểm Văn";
            // 
            // lblAnh
            // 
            lblAnh.AutoSize = true;
            lblAnh.Location = new Point(635, 15);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(90, 25);
            lblAnh.TabIndex = 11;
            lblAnh.Text = "Điểm Anh";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(15, 43);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(130, 31);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(160, 43);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(210, 31);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(385, 43);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(110, 31);
            txtToan.TabIndex = 2;
            txtToan.Enter += DiemTextBox_Enter;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(510, 43);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(110, 31);
            txtVan.TabIndex = 3;
            txtVan.Enter += DiemTextBox_Enter;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(635, 43);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(110, 31);
            txtAnh.TabIndex = 4;
            txtAnh.Enter += DiemTextBox_Enter;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.MediumSeaGreen;
            btnLuu.FlatAppearance.BorderColor = Color.MediumSeaGreen;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(15, 90);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 42);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(135, 90);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(130, 42);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.ItemHeight = 25;
            lstKetQua.Location = new Point(15, 145);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(730, 304);
            lstKetQua.TabIndex = 12;
            lstKetQua.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // FormNhapDiem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 530);
            Controls.Add(pnlNoiDung);
            Name = "FormNhapDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập điểm học sinh";
            Load += FormNhapDiem_Load;
            Resize += FormNhapDiem_Resize;
            pnlNoiDung.ResumeLayout(false);
            pnlNoiDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNoiDung;
        private Label lblMaHS;
        private Label lblHoTen;
        private Label lblToan;
        private Label lblVan;
        private Label lblAnh;
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
        private ErrorProvider errorProvider1;
    }
}
