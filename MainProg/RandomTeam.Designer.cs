namespace MainProg
{
    partial class RandomTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lstDanhSachTen = new System.Windows.Forms.ListBox();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtSoLuongThanhVien = new System.Windows.Forms.TextBox();
            this.btnTaoNgauNhien = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstKetQua = new System.Windows.Forms.ListBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkTruongNhom = new System.Windows.Forms.CheckBox();
            this.radTVMoiNhom = new System.Windows.Forms.RadioButton();
            this.radSoLuongNhom = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.Location = new System.Drawing.Point(63, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(553, 59);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Chia nhóm ngẫu nhiên";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTieuDe.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstDanhSachTen
            // 
            this.lstDanhSachTen.FormattingEnabled = true;
            this.lstDanhSachTen.ItemHeight = 16;
            this.lstDanhSachTen.Location = new System.Drawing.Point(0, 24);
            this.lstDanhSachTen.Name = "lstDanhSachTen";
            this.lstDanhSachTen.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDanhSachTen.Size = new System.Drawing.Size(262, 212);
            this.lstDanhSachTen.TabIndex = 1;
            this.lstDanhSachTen.Tag = "";
            this.lstDanhSachTen.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDanhSach.Location = new System.Drawing.Point(3, 0);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(233, 25);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách tên thành viên";
            this.lblDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.lstDanhSachTen);
            this.panel1.Controls.Add(this.lblDanhSach);
            this.panel1.Location = new System.Drawing.Point(21, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 268);
            this.panel1.TabIndex = 5;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(-1, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(263, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa khỏi danh sách";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(21, 136);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(263, 28);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "&Cập nhật vào danh sách";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhapTen.Location = new System.Drawing.Point(25, 78);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(102, 25);
            this.lblNhapTen.TabIndex = 1;
            this.lblNhapTen.Text = "Nhập tên: ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(21, 106);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(262, 22);
            this.txtTen.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(3, 36);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(262, 22);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtSoLuongThanhVien
            // 
            this.txtSoLuongThanhVien.Location = new System.Drawing.Point(3, 89);
            this.txtSoLuongThanhVien.Name = "txtSoLuongThanhVien";
            this.txtSoLuongThanhVien.ReadOnly = true;
            this.txtSoLuongThanhVien.Size = new System.Drawing.Size(262, 22);
            this.txtSoLuongThanhVien.TabIndex = 3;
            this.txtSoLuongThanhVien.TextChanged += new System.EventHandler(this.txtSoLuongThanhVien_TextChanged);
            // 
            // btnTaoNgauNhien
            // 
            this.btnTaoNgauNhien.Location = new System.Drawing.Point(21, 444);
            this.btnTaoNgauNhien.Name = "btnTaoNgauNhien";
            this.btnTaoNgauNhien.Size = new System.Drawing.Size(624, 38);
            this.btnTaoNgauNhien.TabIndex = 6;
            this.btnTaoNgauNhien.Text = "Tạo ngẫu nhiên";
            this.btnTaoNgauNhien.UseVisualStyleBackColor = true;
            this.btnTaoNgauNhien.Click += new System.EventHandler(this.btnTaoNgauNhien_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lstKetQua);
            this.panel2.Controls.Add(this.lblKetQua);
            this.panel2.Location = new System.Drawing.Point(289, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 207);
            this.panel2.TabIndex = 10;
            // 
            // lstKetQua
            // 
            this.lstKetQua.FormattingEnabled = true;
            this.lstKetQua.ItemHeight = 16;
            this.lstKetQua.Location = new System.Drawing.Point(-1, 27);
            this.lstKetQua.Name = "lstKetQua";
            this.lstKetQua.Size = new System.Drawing.Size(375, 180);
            this.lstKetQua.TabIndex = 1;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblKetQua.Location = new System.Drawing.Point(1, -1);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(80, 25);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.Text = "Kết quả";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.chkTruongNhom);
            this.panel3.Controls.Add(this.radTVMoiNhom);
            this.panel3.Controls.Add(this.radSoLuongNhom);
            this.panel3.Controls.Add(this.txtSoLuongThanhVien);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Location = new System.Drawing.Point(289, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 153);
            this.panel3.TabIndex = 4;
            // 
            // chkTruongNhom
            // 
            this.chkTruongNhom.AutoSize = true;
            this.chkTruongNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkTruongNhom.Location = new System.Drawing.Point(3, 117);
            this.chkTruongNhom.Name = "chkTruongNhom";
            this.chkTruongNhom.Size = new System.Drawing.Size(324, 29);
            this.chkTruongNhom.TabIndex = 4;
            this.chkTruongNhom.Text = "Có chọn ngẫu nhiên trưởng nhóm";
            this.chkTruongNhom.UseVisualStyleBackColor = true;
            // 
            // radTVMoiNhom
            // 
            this.radTVMoiNhom.AutoSize = true;
            this.radTVMoiNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radTVMoiNhom.Location = new System.Drawing.Point(6, 61);
            this.radTVMoiNhom.Name = "radTVMoiNhom";
            this.radTVMoiNhom.Size = new System.Drawing.Size(350, 29);
            this.radTVMoiNhom.TabIndex = 2;
            this.radTVMoiNhom.TabStop = true;
            this.radTVMoiNhom.Text = "Nhập số lượng thành viên mỗi nhóm:";
            this.radTVMoiNhom.UseVisualStyleBackColor = true;
            this.radTVMoiNhom.CheckedChanged += new System.EventHandler(this.radTVMoiNhom_CheckedChanged);
            // 
            // radSoLuongNhom
            // 
            this.radSoLuongNhom.AutoSize = true;
            this.radSoLuongNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radSoLuongNhom.Location = new System.Drawing.Point(6, 3);
            this.radSoLuongNhom.Name = "radSoLuongNhom";
            this.radSoLuongNhom.Size = new System.Drawing.Size(213, 29);
            this.radSoLuongNhom.TabIndex = 0;
            this.radSoLuongNhom.TabStop = true;
            this.radSoLuongNhom.Text = "Nhập số lượng nhóm";
            this.radSoLuongNhom.UseVisualStyleBackColor = true;
            this.radSoLuongNhom.CheckedChanged += new System.EventHandler(this.radSoLuongNhom_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RandomTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(726, 542);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTaoNgauNhien);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblNhapTen);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "RandomTeam";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random nhóm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.ListBox lstDanhSachTen;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtSoLuongThanhVien;
        private System.Windows.Forms.Button btnTaoNgauNhien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lstKetQua;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkTruongNhom;
        private System.Windows.Forms.RadioButton radTVMoiNhom;
        private System.Windows.Forms.RadioButton radSoLuongNhom;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

