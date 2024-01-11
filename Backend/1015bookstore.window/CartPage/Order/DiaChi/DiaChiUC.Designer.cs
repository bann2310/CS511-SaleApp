namespace _1015bookstore.window.CartPage.Order
{
    partial class DiaChiUC
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
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.diachi = new System.Windows.Forms.FlowLayoutPanel();
            this.xacnhan = new CSharp.Winform.UI.Button();
            this.huybo = new CSharp.Winform.UI.Button();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label11.Location = new System.Drawing.Point(20, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "Địa chỉ của tôi";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 1);
            this.panel1.TabIndex = 4;
            // 
            // diachi
            // 
            this.diachi.BackColor = System.Drawing.Color.LightGray;
            this.diachi.Location = new System.Drawing.Point(0, 60);
            this.diachi.Margin = new System.Windows.Forms.Padding(0);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(500, 100);
            this.diachi.TabIndex = 5;
            // 
            // xacnhan
            // 
            this.xacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(130)))));
            this.xacnhan.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xacnhan.ForeColor = System.Drawing.Color.White;
            this.xacnhan.Location = new System.Drawing.Point(360, 165);
            this.xacnhan.Name = "xacnhan";
            this.xacnhan.Size = new System.Drawing.Size(140, 32);
            this.xacnhan.TabIndex = 8;
            this.xacnhan.Text = "Xác nhận";
            this.xacnhan.UseVisualStyleBackColor = false;
            // 
            // huybo
            // 
            this.huybo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(207)))), ((int)(((byte)(130)))));
            this.huybo.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huybo.ForeColor = System.Drawing.Color.White;
            this.huybo.Location = new System.Drawing.Point(210, 165);
            this.huybo.Name = "huybo";
            this.huybo.Size = new System.Drawing.Size(140, 32);
            this.huybo.TabIndex = 8;
            this.huybo.Text = "Hủy bỏ";
            this.huybo.UseVisualStyleBackColor = false;
            // 
            // DiaChiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.huybo);
            this.Controls.Add(this.xacnhan);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Name = "DiaChiUC";
            this.Size = new System.Drawing.Size(500, 199);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel diachi;
        private CSharp.Winform.UI.Button xacnhan;
        private CSharp.Winform.UI.Button huybo;
    }
}
