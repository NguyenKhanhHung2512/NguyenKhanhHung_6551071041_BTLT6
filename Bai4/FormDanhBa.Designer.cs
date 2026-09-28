namespace Bai4
{
    partial class FormDanhBa
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
            lstLienHe = new ListBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            pnlNoiDung.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNoiDung
            // 
            pnlNoiDung.Controls.Add(lstLienHe);
            pnlNoiDung.Controls.Add(lblTen);
            pnlNoiDung.Controls.Add(txtTen);
            pnlNoiDung.Controls.Add(lblSDT);
            pnlNoiDung.Controls.Add(txtSDT);
            pnlNoiDung.Controls.Add(btnThem);
            pnlNoiDung.Controls.Add(btnSua);
            pnlNoiDung.Controls.Add(btnXoa);
            pnlNoiDung.Controls.Add(btnThoat);
            pnlNoiDung.Location = new Point(40, 30);
            pnlNoiDung.Name = "pnlNoiDung";
            pnlNoiDung.Size = new Size(680, 450);
            pnlNoiDung.TabIndex = 0;
            // 
            // lstLienHe
            // 
            lstLienHe.FormattingEnabled = true;
            lstLienHe.ItemHeight = 25;
            lstLienHe.Location = new Point(15, 15);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(370, 400);
            lstLienHe.TabIndex = 0;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new Point(405, 15);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(42, 25);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(405, 43);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(255, 31);
            txtTen.TabIndex = 2;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(405, 90);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(122, 25);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(405, 118);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(255, 31);
            txtSDT.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(405, 175);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(255, 45);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(405, 228);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(255, 45);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(405, 281);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(255, 45);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(405, 370);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(255, 45);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormDanhBa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 510);
            Controls.Add(pnlNoiDung);
            Name = "FormDanhBa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh bạ";
            FormClosing += FormDanhBa_FormClosing;
            Load += FormDanhBa_Load;
            Resize += FormDanhBa_Resize;
            pnlNoiDung.ResumeLayout(false);
            pnlNoiDung.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNoiDung;
        private ListBox lstLienHe;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}
