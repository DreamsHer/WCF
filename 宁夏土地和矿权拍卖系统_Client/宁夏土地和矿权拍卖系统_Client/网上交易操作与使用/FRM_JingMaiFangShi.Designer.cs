namespace 宁夏土地和矿权拍卖系统_Client
{
    partial class FRM_JingMaiFangShi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_JingMaiFangShi));
            this.btnDanDuShenQing = new System.Windows.Forms.Button();
            this.btnLianHeShenQing = new System.Windows.Forms.Button();
            this.lbGuaPaiBianHao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDanDuShenQing
            // 
            this.btnDanDuShenQing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDanDuShenQing.Location = new System.Drawing.Point(312, 325);
            this.btnDanDuShenQing.Name = "btnDanDuShenQing";
            this.btnDanDuShenQing.Size = new System.Drawing.Size(93, 33);
            this.btnDanDuShenQing.TabIndex = 5;
            this.btnDanDuShenQing.Text = "单独申请";
            this.btnDanDuShenQing.UseVisualStyleBackColor = true;
            this.btnDanDuShenQing.Click += new System.EventHandler(this.btnDanDuShenQing_Click);
            // 
            // btnLianHeShenQing
            // 
            this.btnLianHeShenQing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLianHeShenQing.Location = new System.Drawing.Point(432, 325);
            this.btnLianHeShenQing.Name = "btnLianHeShenQing";
            this.btnLianHeShenQing.Size = new System.Drawing.Size(93, 33);
            this.btnLianHeShenQing.TabIndex = 6;
            this.btnLianHeShenQing.Text = "联合申请";
            this.btnLianHeShenQing.UseVisualStyleBackColor = true;
            this.btnLianHeShenQing.Click += new System.EventHandler(this.btnLianHeShenQing_Click);
            // 
            // lbGuaPaiBianHao
            // 
            this.lbGuaPaiBianHao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbGuaPaiBianHao.Location = new System.Drawing.Point(10, 47);
            this.lbGuaPaiBianHao.Margin = new System.Windows.Forms.Padding(0);
            this.lbGuaPaiBianHao.Name = "lbGuaPaiBianHao";
            this.lbGuaPaiBianHao.Padding = new System.Windows.Forms.Padding(4, 5, 0, 4);
            this.lbGuaPaiBianHao.Size = new System.Drawing.Size(187, 23);
            this.lbGuaPaiBianHao.TabIndex = 8;
            this.lbGuaPaiBianHao.Text = "挂牌编号：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tomato;
            this.pictureBox1.Location = new System.Drawing.Point(10, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 3);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(63, 243);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(708, 225);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 81);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(842, 95);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(73, 42);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // FRM_JingMaiFangShi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 571);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbGuaPaiBianHao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLianHeShenQing);
            this.Controls.Add(this.btnDanDuShenQing);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_JingMaiFangShi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRM_JingMaiFangShi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDanDuShenQing;
        private System.Windows.Forms.Button btnLianHeShenQing;
        private System.Windows.Forms.Label lbGuaPaiBianHao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}