namespace MainProg
{
    partial class RandomName
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.lstDSTen = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCapnhatTen = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnRandomDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHeader.Location = new System.Drawing.Point(80, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(508, 58);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Chọn tên ngẫu nhiên";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhapTen.Location = new System.Drawing.Point(19, 3);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(386, 29);
            this.lblNhapTen.TabIndex = 0;
            this.lblNhapTen.Text = "Nhập tên để thêm vào danh sách";
            this.lblNhapTen.Click += new System.EventHandler(this.lblNhapTen_Click);
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Location = new System.Drawing.Point(76, 35);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(267, 22);
            this.txtNhapTen.TabIndex = 1;
            // 
            // lstDSTen
            // 
            this.lstDSTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lstDSTen.FormattingEnabled = true;
            this.lstDSTen.ItemHeight = 29;
            this.lstDSTen.Location = new System.Drawing.Point(0, 98);
            this.lstDSTen.Name = "lstDSTen";
            this.lstDSTen.Size = new System.Drawing.Size(426, 294);
            this.lstDSTen.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCapnhatTen);
            this.panel1.Controls.Add(this.lblNhapTen);
            this.panel1.Controls.Add(this.lstDSTen);
            this.panel1.Controls.Add(this.txtNhapTen);
            this.panel1.Location = new System.Drawing.Point(121, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 386);
            this.panel1.TabIndex = 1;
            // 
            // btnCapnhatTen
            // 
            this.btnCapnhatTen.Location = new System.Drawing.Point(76, 62);
            this.btnCapnhatTen.Name = "btnCapnhatTen";
            this.btnCapnhatTen.Size = new System.Drawing.Size(264, 30);
            this.btnCapnhatTen.TabIndex = 2;
            this.btnCapnhatTen.Text = "Cập nhật tên vào danh sách";
            this.btnCapnhatTen.UseVisualStyleBackColor = true;
            this.btnCapnhatTen.Click += new System.EventHandler(this.btnCapnhatTen_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRandom.Location = new System.Drawing.Point(331, 466);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(216, 53);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Chọn ngẫu nhiên và xóa";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnRandomDelete
            // 
            this.btnRandomDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRandomDelete.Location = new System.Drawing.Point(121, 466);
            this.btnRandomDelete.Name = "btnRandomDelete";
            this.btnRandomDelete.Size = new System.Drawing.Size(213, 53);
            this.btnRandomDelete.TabIndex = 2;
            this.btnRandomDelete.Text = "Chọn ngẫu nhiên";
            this.btnRandomDelete.UseVisualStyleBackColor = true;
            this.btnRandomDelete.Click += new System.EventHandler(this.btnRandomDelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RandomName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(702, 531);
            this.Controls.Add(this.btnRandomDelete);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader);
            this.Name = "RandomName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random tên";
            this.Load += new System.EventHandler(this.RandomName_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.ListBox lstDSTen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCapnhatTen;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnRandomDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}