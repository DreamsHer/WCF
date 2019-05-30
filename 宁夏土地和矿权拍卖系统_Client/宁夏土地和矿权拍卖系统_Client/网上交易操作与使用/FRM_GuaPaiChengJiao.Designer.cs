namespace 宁夏土地和矿权拍卖系统_Client
{
    partial class FRM_GuaPaiChengJiao
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
            this.lbTuiChu = new System.Windows.Forms.Label();
            this.lbGuaPaiBianHao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTuiChu
            // 
            this.lbTuiChu.BackColor = System.Drawing.Color.Transparent;
            this.lbTuiChu.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTuiChu.ForeColor = System.Drawing.Color.Black;
            this.lbTuiChu.Location = new System.Drawing.Point(586, 0);
            this.lbTuiChu.Margin = new System.Windows.Forms.Padding(0);
            this.lbTuiChu.Name = "lbTuiChu";
            this.lbTuiChu.Size = new System.Drawing.Size(47, 19);
            this.lbTuiChu.TabIndex = 12;
            this.lbTuiChu.Text = "关闭";
            this.lbTuiChu.Click += new System.EventHandler(this.lbTuiChu_Click);
            // 
            // lbGuaPaiBianHao
            // 
            this.lbGuaPaiBianHao.BackColor = System.Drawing.Color.Transparent;
            this.lbGuaPaiBianHao.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGuaPaiBianHao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbGuaPaiBianHao.Location = new System.Drawing.Point(243, 77);
            this.lbGuaPaiBianHao.Margin = new System.Windows.Forms.Padding(0);
            this.lbGuaPaiBianHao.Name = "lbGuaPaiBianHao";
            this.lbGuaPaiBianHao.Size = new System.Drawing.Size(179, 23);
            this.lbGuaPaiBianHao.TabIndex = 16;
            this.lbGuaPaiBianHao.Text = "银地挂[2017]1-1号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(278, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "成交";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 57);
            this.label2.TabIndex = 18;
            this.label2.Text = "恭喜您成功竞得挂牌编号为                  的国有建设用地使用权，\r\n\r\n请查看成交确认书，并按相关文件的规定和要求办理相关手续。";
            // 
            // FRM_GuaPaiChengJiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 220);
            this.Controls.Add(this.lbGuaPaiBianHao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTuiChu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(380, 400);
            this.Name = "FRM_GuaPaiChengJiao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_GuaPaiChengJiao";
            this.Load += new System.EventHandler(this.FRM_GuaPaiChengJiao_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FRM_GuaPaiChengJiao_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FRM_GuaPaiChengJiao_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTuiChu;
        private System.Windows.Forms.Label lbGuaPaiBianHao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}