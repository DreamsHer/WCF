using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 宁夏土地和矿权拍卖系统_Client
{
    public partial class FRM_ChaKanXianChangTu : Form
    {
        FRM_JiaoYiDaTing myFRM_JiaoYiDaTing;      

        public FRM_ChaKanXianChangTu(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }

        //Load事件
        private void FRM_ChaKanXianChangTu_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }
        
        //事件间隔
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.panel1.Left = this.panel1.Left + 10;
            if (this.panel1.Left > this.Width + 10)
            {
                this.panel1.Left = -this.panel1.Width;
            }
        }

        //鼠标移到土地事件
        private void ptBXiaoTuPian1_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void ptBXiaoTuPian1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void ptBXiaoTuPian2_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void ptBXiaoTuPian2_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void ptBXiaoTuPian3_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void ptBXiaoTuPian3_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void ptBXiaoTuPian4_MouseEnter(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void ptBXiaoTuPian4_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        //图片点击事件
        private void ptBXiaoTuPian1_Click(object sender, EventArgs e)
        {
            ptBDaTuPian.Controls.Clear();
            //ptBXiaoTuPian1 myptBXiaoTuPian1 = new ptBXiaoTuPian1(this);
            //string myname;
            //openFileDialog1.Filter = "*.jpg,*.jpeg,*.bmp,*.gif,*.ico,*.png,*.tif,*.wmf|*.jpg;*.jpeg;*.bmp;*.gif;*.ico;*.png;*.tif;*.wmf";     //设置打开图像的类型               
            //openFileDialog1.ShowDialog();                        //打开对话框
            //myname = openFileDialog1.FileName;
            //ptBDaTuPian.Image = Image.FromFile(myname);            //显示打开图像
        }

        //关闭
        private void FRM_ChaKanXianChangTu_FormClosed(object sender, FormClosedEventArgs e)
        {
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_DiKuaiXiangQing myFRM_DiKuaiXiangQing = new FRM_DiKuaiXiangQing(myFRM_JiaoYiDaTing);
            myFRM_DiKuaiXiangQing.TopLevel = false;
            myFRM_DiKuaiXiangQing.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_DiKuaiXiangQing.Show();
        }

    }
}
