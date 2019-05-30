namespace 宁夏土地和矿权拍卖系统_Client
{
    partial class FRM_DiTuLiuLan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDiTuLiulan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbDiTuLiulan);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 530);
            this.panel1.TabIndex = 2;
            // 
            // lbDiTuLiulan
            // 
            this.lbDiTuLiulan.AutoSize = true;
            this.lbDiTuLiulan.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDiTuLiulan.ForeColor = System.Drawing.Color.Blue;
            this.lbDiTuLiulan.Location = new System.Drawing.Point(29, 14);
            this.lbDiTuLiulan.Name = "lbDiTuLiulan";
            this.lbDiTuLiulan.Size = new System.Drawing.Size(89, 20);
            this.lbDiTuLiulan.TabIndex = 0;
            this.lbDiTuLiulan.Text = "地图浏览";
            // 
            // FRM_DiTuLiuLan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 532);
            this.Controls.Add(this.panel1);
            this.Name = "FRM_DiTuLiuLan";
            this.Text = "http://pt.nxgtt.gov.cn - 国土资源网上交易系统 - Microsoft Internet Explorer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_DiTuLiuLan_FormClosed);
            this.Load += new System.EventHandler(this.FRM_DiTuLiuLan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDiTuLiulan;
    }
}