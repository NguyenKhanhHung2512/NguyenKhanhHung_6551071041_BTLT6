namespace Bai2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblNgayNhan = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblSoNguoiLon = new System.Windows.Forms.Label();
            this.lblSoTreEm = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtNgayNhan = new System.Windows.Forms.TextBox();
            this.txtNgayTra = new System.Windows.Forms.TextBox();
            this.txtSoNguoiLon = new System.Windows.Forms.TextBox();
            this.txtSoTreEm = new System.Windows.Forms.TextBox();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // lblHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 25);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(54, 17);
            this.lblHoTen.TabIndex = 100;
            this.lblHoTen.TabStop = false;
            this.lblHoTen.Text = "Họ tên:";

            // lblCCCD
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(30, 65);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(69, 17);
            this.lblCCCD.TabIndex = 101;
            this.lblCCCD.TabStop = false;
            this.lblCCCD.Text = "Số CCCD:";

            // lblNgayNhan
            this.lblNgayNhan.AutoSize = true;
            this.lblNgayNhan.Location = new System.Drawing.Point(30, 105);
            this.lblNgayNhan.Name = "lblNgayNhan";
            this.lblNgayNhan.Size = new System.Drawing.Size(125, 17);
            this.lblNgayNhan.TabIndex = 102;
            this.lblNgayNhan.TabStop = false;
            this.lblNgayNhan.Text = "Ngày nhận phòng:";

            // lblNgayTra
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(30, 145);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(110, 17);
            this.lblNgayTra.TabIndex = 103;
            this.lblNgayTra.TabStop = false;
            this.lblNgayTra.Text = "Ngày trả phòng:";

            // lblSoNguoiLon
            this.lblSoNguoiLon.AutoSize = true;
            this.lblSoNguoiLon.Location = new System.Drawing.Point(30, 185);
            this.lblSoNguoiLon.Name = "lblSoNguoiLon";
            this.lblSoNguoiLon.Size = new System.Drawing.Size(130, 17);
            this.lblSoNguoiLon.TabIndex = 104;
            this.lblSoNguoiLon.TabStop = false;
            this.lblSoNguoiLon.Text = "Số người lớn (1-4):";

            // lblSoTreEm
            this.lblSoTreEm.AutoSize = true;
            this.lblSoTreEm.Location = new System.Drawing.Point(30, 225);
            this.lblSoTreEm.Name = "lblSoTreEm";
            this.lblSoTreEm.Size = new System.Drawing.Size(110, 17);
            this.lblSoTreEm.TabIndex = 105;
            this.lblSoTreEm.TabStop = false;
            this.lblSoTreEm.Text = "Số trẻ em (0-3):";

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(175, 22);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 22);
            this.txtHoTen.TabIndex = 0;

            // txtCCCD
            this.txtCCCD.Location = new System.Drawing.Point(175, 62);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(200, 22);
            this.txtCCCD.TabIndex = 1;

            // txtNgayNhan
            this.txtNgayNhan.Location = new System.Drawing.Point(175, 102);
            this.txtNgayNhan.Name = "txtNgayNhan";
            this.txtNgayNhan.Size = new System.Drawing.Size(200, 22);
            this.txtNgayNhan.TabIndex = 2;

            // txtNgayTra
            this.txtNgayTra.Location = new System.Drawing.Point(175, 142);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Size = new System.Drawing.Size(200, 22);
            this.txtNgayTra.TabIndex = 3;

            // txtSoNguoiLon
            this.txtSoNguoiLon.Location = new System.Drawing.Point(175, 182);
            this.txtSoNguoiLon.Name = "txtSoNguoiLon";
            this.txtSoNguoiLon.Size = new System.Drawing.Size(200, 22);
            this.txtSoNguoiLon.TabIndex = 4;

            // txtSoTreEm
            this.txtSoTreEm.Location = new System.Drawing.Point(175, 222);
            this.txtSoTreEm.Name = "txtSoTreEm";
            this.txtSoTreEm.Size = new System.Drawing.Size(200, 22);
            this.txtSoTreEm.TabIndex = 5;

            // btnDatPhong
            this.btnDatPhong.Location = new System.Drawing.Point(175, 265);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(120, 35);
            this.btnDatPhong.TabIndex = 6;
            this.btnDatPhong.Text = "Đặt Phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;

            // errorProvider1
            this.errorProvider1.ContainerControl = this;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 325);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.txtSoTreEm);
            this.Controls.Add(this.txtSoNguoiLon);
            this.Controls.Add(this.txtNgayTra);
            this.Controls.Add(this.txtNgayNhan);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lblSoTreEm);
            this.Controls.Add(this.lblSoNguoiLon);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.lblNgayNhan);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.lblHoTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblSoNguoiLon;
        private System.Windows.Forms.Label lblSoTreEm;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.TextBox txtSoNguoiLon;
        private System.Windows.Forms.TextBox txtSoTreEm;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}