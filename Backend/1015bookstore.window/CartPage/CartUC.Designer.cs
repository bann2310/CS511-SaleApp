namespace _1015bookstore.window.CartPage
{
    partial class CartUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chontatca = new System.Windows.Forms.CheckBox();
            this.giohang = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.hethang = new System.Windows.Forms.FlowLayoutPanel();
            this.totalUC1 = new _1015bookstore.window.CartPage.TotalUC();
            this.cartItemUC1 = new _1015bookstore.window.CartPage.CartItemUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.hethang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chontatca);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 50);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(756, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(589, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(250, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên sản phẩm";
            // 
            // chontatca
            // 
            this.chontatca.AutoSize = true;
            this.chontatca.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chontatca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.chontatca.Location = new System.Drawing.Point(20, 13);
            this.chontatca.Name = "chontatca";
            this.chontatca.Size = new System.Drawing.Size(213, 22);
            this.chontatca.TabIndex = 1;
            this.chontatca.Text = "Chọn tất cả (xxx sản phẩm)";
            this.chontatca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chontatca.UseVisualStyleBackColor = true;
            // 
            // giohang
            // 
            this.giohang.Location = new System.Drawing.Point(0, 50);
            this.giohang.Margin = new System.Windows.Forms.Padding(0);
            this.giohang.Name = "giohang";
            this.giohang.Size = new System.Drawing.Size(900, 20);
            this.giohang.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 50);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(30, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Danh sách sản phẩm hết hàng";
            // 
            // hethang
            // 
            this.hethang.Controls.Add(this.cartItemUC1);
            this.hethang.Location = new System.Drawing.Point(0, 320);
            this.hethang.Margin = new System.Windows.Forms.Padding(0);
            this.hethang.Name = "hethang";
            this.hethang.Size = new System.Drawing.Size(900, 189);
            this.hethang.TabIndex = 1;
            // 
            // totalUC1
            // 
            this.totalUC1.Location = new System.Drawing.Point(925, 16);
            this.totalUC1.Name = "totalUC1";
            this.totalUC1.Size = new System.Drawing.Size(410, 106);
            this.totalUC1.TabIndex = 2;
            // 
            // cartItemUC1
            // 
            this.cartItemUC1.BackColor = System.Drawing.Color.White;
            this.cartItemUC1.Location = new System.Drawing.Point(0, 10);
            this.cartItemUC1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.cartItemUC1.Name = "cartItemUC1";
            this.cartItemUC1.Size = new System.Drawing.Size(900, 150);
            this.cartItemUC1.TabIndex = 0;
            // 
            // CartUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.totalUC1);
            this.Controls.Add(this.hethang);
            this.Controls.Add(this.giohang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CartUC";
            this.Size = new System.Drawing.Size(1350, 614);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.hethang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chontatca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel giohang;
        private TotalUC totalUC1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel hethang;
        private CartItemUC cartItemUC1;
    }
}
