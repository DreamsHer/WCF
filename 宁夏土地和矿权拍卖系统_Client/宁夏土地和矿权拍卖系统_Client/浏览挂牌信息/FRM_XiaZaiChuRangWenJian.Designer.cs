namespace 宁夏土地和矿权拍卖系统_Client
{
    partial class FRM_XiaZaiChuRangWenJian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvChuRangWenJian = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.XuHao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WenJianMing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XiaZhai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuRangWenJian)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Azure;
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Location = new System.Drawing.Point(-1, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox4.Size = new System.Drawing.Size(851, 577);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dgvChuRangWenJian);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 577);
            this.panel1.TabIndex = 20;
            // 
            // dgvChuRangWenJian
            // 
            this.dgvChuRangWenJian.BackgroundColor = System.Drawing.Color.White;
            this.dgvChuRangWenJian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChuRangWenJian.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChuRangWenJian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChuRangWenJian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuRangWenJian.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XuHao,
            this.WenJianMing,
            this.XiaZhai});
            this.dgvChuRangWenJian.Location = new System.Drawing.Point(0, 31);
            this.dgvChuRangWenJian.Margin = new System.Windows.Forms.Padding(0);
            this.dgvChuRangWenJian.Name = "dgvChuRangWenJian";
            this.dgvChuRangWenJian.RowHeadersVisible = false;
            this.dgvChuRangWenJian.RowTemplate.Height = 23;
            this.dgvChuRangWenJian.Size = new System.Drawing.Size(849, 512);
            this.dgvChuRangWenJian.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "出让文件列表";
            // 
            // XuHao
            // 
            this.XuHao.HeaderText = "序号";
            this.XuHao.Name = "XuHao";
            this.XuHao.Width = 54;
            // 
            // WenJianMing
            // 
            this.WenJianMing.HeaderText = "文件名";
            this.WenJianMing.Name = "WenJianMing";
            this.WenJianMing.Width = 686;
            // 
            // XiaZhai
            // 
            this.XiaZhai.HeaderText = "下载";
            this.XiaZhai.Name = "XiaZhai";
            this.XiaZhai.Width = 106;
            // 
            // FRM_XiaZaiChuRangWenJian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 571);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FRM_XiaZaiChuRangWenJian";
            this.Text = "http://pt.nxgt jy-nxgtt_gov.cn — 国土资源网上交易系统 — Explorer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_XiaZaiChuRangWenJian_FormClosed);
            this.Load += new System.EventHandler(this.FRM_XiaZaiChuRangWenJian_Load);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuRangWenJian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChuRangWenJian;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuHao;
        private System.Windows.Forms.DataGridViewTextBoxColumn WenJianMing;
        private System.Windows.Forms.DataGridViewTextBoxColumn XiaZhai;
    }
}