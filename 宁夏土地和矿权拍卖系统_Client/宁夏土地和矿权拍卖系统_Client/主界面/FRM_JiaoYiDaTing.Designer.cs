namespace 宁夏土地和矿权拍卖系统_Client
{
    partial class FRM_JiaoYiDaTing
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
            this.btnJiaoYiDaTing = new System.Windows.Forms.Button();
            this.btnWoDeJiaoYi = new System.Windows.Forms.Button();
            this.btnWoDeShouCang = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJiaoYiDaTing
            // 
            this.btnJiaoYiDaTing.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnJiaoYiDaTing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJiaoYiDaTing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJiaoYiDaTing.Location = new System.Drawing.Point(0, 0);
            this.btnJiaoYiDaTing.Margin = new System.Windows.Forms.Padding(0);
            this.btnJiaoYiDaTing.Name = "btnJiaoYiDaTing";
            this.btnJiaoYiDaTing.Size = new System.Drawing.Size(110, 24);
            this.btnJiaoYiDaTing.TabIndex = 4;
            this.btnJiaoYiDaTing.Text = " 土地交易大厅  ";
            this.btnJiaoYiDaTing.UseVisualStyleBackColor = false;
            this.btnJiaoYiDaTing.Click += new System.EventHandler(this.btnJiaoYiDaTing_Click);            
            // 
            // btnWoDeJiaoYi
            // 
            this.btnWoDeJiaoYi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWoDeJiaoYi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWoDeJiaoYi.Location = new System.Drawing.Point(110, 0);
            this.btnWoDeJiaoYi.Margin = new System.Windows.Forms.Padding(0);
            this.btnWoDeJiaoYi.Name = "btnWoDeJiaoYi";
            this.btnWoDeJiaoYi.Size = new System.Drawing.Size(110, 24);
            this.btnWoDeJiaoYi.TabIndex = 5;
            this.btnWoDeJiaoYi.Text = "我的交易";
            this.btnWoDeJiaoYi.UseVisualStyleBackColor = true;
            this.btnWoDeJiaoYi.Click += new System.EventHandler(this.btnWoDeJiaoYi_Click);
            // 
            // btnWoDeShouCang
            // 
            this.btnWoDeShouCang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWoDeShouCang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWoDeShouCang.Location = new System.Drawing.Point(220, 0);
            this.btnWoDeShouCang.Margin = new System.Windows.Forms.Padding(0);
            this.btnWoDeShouCang.Name = "btnWoDeShouCang";
            this.btnWoDeShouCang.Size = new System.Drawing.Size(110, 24);
            this.btnWoDeShouCang.TabIndex = 6;
            this.btnWoDeShouCang.Text = "我的收藏";
            this.btnWoDeShouCang.UseVisualStyleBackColor = true;
            this.btnWoDeShouCang.Click += new System.EventHandler(this.btnWoDeShouCang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 580);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;            
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 576);
            this.panel1.TabIndex = 8;
            // 
            // FRM_JiaoYiDaTing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnWoDeShouCang);
            this.Controls.Add(this.btnWoDeJiaoYi);
            this.Controls.Add(this.btnJiaoYiDaTing);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_JiaoYiDaTing";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRM_JiaoYiDaTing_Load);
            this.Shown += new System.EventHandler(this.FRM_JiaoYiDaTing_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJiaoYiDaTing;
        private System.Windows.Forms.Button btnWoDeJiaoYi;
        private System.Windows.Forms.Button btnWoDeShouCang;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel1;
    }
}