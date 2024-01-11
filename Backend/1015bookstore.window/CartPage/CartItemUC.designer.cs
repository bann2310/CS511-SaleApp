namespace _1015bookstore.window.CartPage
{
    partial class CartItemUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItemUC));
            this.xoa = new System.Windows.Forms.PictureBox();
            this.avatarsanpham = new System.Windows.Forms.PictureBox();
            this.tensanpham = new System.Windows.Forms.Label();
            this.label3 = new CSharp.Winform.UI.Label();
            this.dongia = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.TextBox();
            this.cong = new CSharp.Winform.UI.Button();
            this.tru = new CSharp.Winform.UI.Button();
            this.sotien = new System.Windows.Forms.Label();
            this.uncheck = new System.Windows.Forms.PictureBox();
            this.check = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).BeginInit();
            this.SuspendLayout();
            // 
            // xoa
            // 
            this.xoa.Image = ((System.Drawing.Image)(resources.GetObject("xoa.Image")));
            this.xoa.Location = new System.Drawing.Point(866, 10);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(24, 24);
            this.xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xoa.TabIndex = 0;
            this.xoa.TabStop = false;
            // 
            // avatarsanpham
            // 
            this.avatarsanpham.Image = ((System.Drawing.Image)(resources.GetObject("avatarsanpham.Image")));
            this.avatarsanpham.Location = new System.Drawing.Point(80, 15);
            this.avatarsanpham.Name = "avatarsanpham";
            this.avatarsanpham.Size = new System.Drawing.Size(120, 120);
            this.avatarsanpham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarsanpham.TabIndex = 0;
            this.avatarsanpham.TabStop = false;
            // 
            // tensanpham
            // 
            this.tensanpham.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tensanpham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tensanpham.Location = new System.Drawing.Point(250, 15);
            this.tensanpham.Name = "tensanpham";
            this.tensanpham.Size = new System.Drawing.Size(327, 36);
            this.tensanpham.TabIndex = 1;
            this.tensanpham.Text = "Bài Tập Trắc Nghiệm Tiếng Anh 9 Theo Chương Trình Thí Điểm (Không Đáp Án)";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giảm giá 5%";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dongia
            // 
            this.dongia.AutoSize = true;
            this.dongia.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(78)))), ((int)(((byte)(52)))));
            this.dongia.Location = new System.Drawing.Point(250, 60);
            this.dongia.Name = "dongia";
            this.dongia.Size = new System.Drawing.Size(95, 24);
            this.dongia.TabIndex = 1;
            this.dongia.Text = "100.000đ";
            // 
            // soluong
            // 
            this.soluong.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.Location = new System.Drawing.Point(611, 16);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(59, 32);
            this.soluong.TabIndex = 17;
            this.soluong.Text = "1";
            this.soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.soluong.TextChanged += new System.EventHandler(this.soluong_TextChanged);
            // 
            // cong
            // 
            this.cong.BackColor = System.Drawing.Color.White;
            this.cong.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cong.ForeColor = System.Drawing.Color.Black;
            this.cong.Location = new System.Drawing.Point(672, 15);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(30, 29);
            this.cong.TabIndex = 15;
            this.cong.Text = "+";
            this.cong.UseVisualStyleBackColor = false;
            this.cong.Click += new System.EventHandler(this.cong_Click);
            // 
            // tru
            // 
            this.tru.BackColor = System.Drawing.Color.White;
            this.tru.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tru.ForeColor = System.Drawing.Color.Black;
            this.tru.Location = new System.Drawing.Point(579, 15);
            this.tru.Name = "tru";
            this.tru.Size = new System.Drawing.Size(30, 29);
            this.tru.TabIndex = 16;
            this.tru.Text = "-";
            this.tru.UseVisualStyleBackColor = false;
            this.tru.Click += new System.EventHandler(this.tru_Click);
            // 
            // sotien
            // 
            this.sotien.AutoSize = true;
            this.sotien.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(130)))));
            this.sotien.Location = new System.Drawing.Point(743, 20);
            this.sotien.Name = "sotien";
            this.sotien.Size = new System.Drawing.Size(95, 24);
            this.sotien.TabIndex = 1;
            this.sotien.Text = "100.000đ";
            // 
            // uncheck
            // 
            this.uncheck.Image = ((System.Drawing.Image)(resources.GetObject("uncheck.Image")));
            this.uncheck.Location = new System.Drawing.Point(20, 63);
            this.uncheck.Name = "uncheck";
            this.uncheck.Size = new System.Drawing.Size(24, 24);
            this.uncheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uncheck.TabIndex = 0;
            this.uncheck.TabStop = false;
            this.uncheck.Click += new System.EventHandler(this.uncheck_Click);
            // 
            // check
            // 
            this.check.Image = ((System.Drawing.Image)(resources.GetObject("check.Image")));
            this.check.Location = new System.Drawing.Point(20, 63);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(24, 24);
            this.check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check.TabIndex = 0;
            this.check.TabStop = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // CartItemUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.cong);
            this.Controls.Add(this.tru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sotien);
            this.Controls.Add(this.dongia);
            this.Controls.Add(this.tensanpham);
            this.Controls.Add(this.avatarsanpham);
            this.Controls.Add(this.check);
            this.Controls.Add(this.uncheck);
            this.Controls.Add(this.xoa);
            this.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.Name = "CartItemUC";
            this.Size = new System.Drawing.Size(900, 150);
            ((System.ComponentModel.ISupportInitialize)(this.xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uncheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox xoa;
        private System.Windows.Forms.PictureBox avatarsanpham;
        private System.Windows.Forms.Label tensanpham;
        private CSharp.Winform.UI.Label label3;
        private System.Windows.Forms.Label dongia;
        private System.Windows.Forms.TextBox soluong;
        private CSharp.Winform.UI.Button cong;
        private CSharp.Winform.UI.Button tru;
        private System.Windows.Forms.Label sotien;
        private System.Windows.Forms.PictureBox uncheck;
        private System.Windows.Forms.PictureBox check;
    }
}
