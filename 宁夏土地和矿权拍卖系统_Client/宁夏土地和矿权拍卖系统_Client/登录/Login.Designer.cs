namespace 宁夏土地和矿权拍卖系统_Client
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtMiMa = new System.Windows.Forms.TextBox();
            this.lbGuanBi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYongHuMing = new System.Windows.Forms.TextBox();
            this.btnDengLu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMiMa
            // 
            this.txtMiMa.BackColor = System.Drawing.Color.White;
            this.txtMiMa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMiMa.Font = new System.Drawing.Font("新宋体", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMiMa.Location = new System.Drawing.Point(161, 83);
            this.txtMiMa.Margin = new System.Windows.Forms.Padding(0);
            this.txtMiMa.Name = "txtMiMa";
            this.txtMiMa.Size = new System.Drawing.Size(128, 13);
            this.txtMiMa.TabIndex = 13;
            this.txtMiMa.UseSystemPasswordChar = true;
            // 
            // lbGuanBi
            // 
            this.lbGuanBi.AutoSize = true;
            this.lbGuanBi.BackColor = System.Drawing.Color.Transparent;
            this.lbGuanBi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGuanBi.Location = new System.Drawing.Point(296, 4);
            this.lbGuanBi.Margin = new System.Windows.Forms.Padding(0);
            this.lbGuanBi.Name = "lbGuanBi";
            this.lbGuanBi.Size = new System.Drawing.Size(11, 12);
            this.lbGuanBi.TabIndex = 15;
            this.lbGuanBi.Text = " ";
            this.lbGuanBi.Click += new System.EventHandler(this.lbGuanBi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("华文细黑", 11.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(89)))), ((int)(((byte)(110)))));
            this.label4.Location = new System.Drawing.Point(102, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "用户名";
            // 
            // txtYongHuMing
            // 
            this.txtYongHuMing.BackColor = System.Drawing.Color.White;
            this.txtYongHuMing.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtYongHuMing.Location = new System.Drawing.Point(156, 51);
            this.txtYongHuMing.Margin = new System.Windows.Forms.Padding(0);
            this.txtYongHuMing.Name = "txtYongHuMing";
            this.txtYongHuMing.Size = new System.Drawing.Size(133, 22);
            this.txtYongHuMing.TabIndex = 19;
            // 
            // btnDengLu
            // 
            this.btnDengLu.BackColor = System.Drawing.Color.Transparent;
            this.btnDengLu.Location = new System.Drawing.Point(222, 101);
            this.btnDengLu.Name = "btnDengLu";
            this.btnDengLu.Size = new System.Drawing.Size(66, 23);
            this.btnDengLu.TabIndex = 20;
            this.btnDengLu.Text = "登录";
            this.btnDengLu.UseVisualStyleBackColor = false;
            this.btnDengLu.Click += new System.EventHandler(this.btnDengLu_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnDengLu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(312, 138);
            this.Controls.Add(this.btnDengLu);
            this.Controls.Add(this.txtYongHuMing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbGuanBi);
            this.Controls.Add(this.txtMiMa);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMiMa;
        private System.Windows.Forms.Label lbGuanBi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYongHuMing;
        private System.Windows.Forms.Button btnDengLu;
    }
}