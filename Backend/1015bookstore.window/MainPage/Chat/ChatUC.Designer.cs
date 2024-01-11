namespace _1015bookstore.window.MainPage.Chat
{
    partial class ChatUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatUC));
            this.chatpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.content = new CSharp.Winform.UI.TextBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.send)).BeginInit();
            this.SuspendLayout();
            // 
            // chatpanel
            // 
            this.chatpanel.AutoScroll = true;
            this.chatpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
            this.chatpanel.Location = new System.Drawing.Point(0, 60);
            this.chatpanel.Name = "chatpanel";
            this.chatpanel.Size = new System.Drawing.Size(400, 345);
            this.chatpanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(207)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 60);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.content);
            this.panel2.Controls.Add(this.send);
            this.panel2.Location = new System.Drawing.Point(0, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 27);
            this.panel2.TabIndex = 9;
            // 
            // content
            // 
            this.content.AllowDrop = true;
            this.content.BackColor = System.Drawing.Color.White;
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.ForeColor = System.Drawing.Color.Black;
            this.content.Location = new System.Drawing.Point(0, 3);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(341, 27);
            this.content.TabIndex = 8;
            this.content.TextChanged += new System.EventHandler(this.content_TextChanged);
            this.content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.content_KeyDown);
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(368, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 32);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(117, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact Admin";
            // 
            // send
            // 
            this.send.Image = ((System.Drawing.Image)(resources.GetObject("send.Image")));
            this.send.Location = new System.Drawing.Point(368, 3);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(26, 26);
            this.send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.send.TabIndex = 0;
            this.send.TabStop = false;
            // 
            // ChatUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chatpanel);
            this.Name = "ChatUC";
            this.Size = new System.Drawing.Size(400, 436);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.send)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel chatpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox close;
        private CSharp.Winform.UI.TextBox content;
        private System.Windows.Forms.PictureBox send;
    }
}
