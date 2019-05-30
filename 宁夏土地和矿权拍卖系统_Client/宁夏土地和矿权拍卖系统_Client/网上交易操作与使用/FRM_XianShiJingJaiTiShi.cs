using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 宁夏土地和矿权拍卖系统_Client
{
    public partial class FRM_XianShiJingJaiTiShi : Form
    {
        public FRM_XianShiJingJaiTiShi()
        {
            InitializeComponent();
        }

        private void FRM_XianShiJingJaiTiShi_Load(object sender, EventArgs e)
        {
            label1.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void button1()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                pgbJinDuTiao.Value += 10;
                this.Close();
            }
            //if (pgbJinDuTiao.Value == 60)
            //{
            //    label1.Visible = true;                                                   
            //    for (int i = 0; i < 6; i++)
            //        {
            //           label1.Text = 212 + "万元第二次！！请各位慎重决断，抓紧最后的机会出价！";
            //           Thread.Sleep(1000);
            //           pgbJinDuTiao.Value += 10;
            //        }                          
            //}
            //if (pgbJinDuTiao.Value == 80)
            //{
            //    label1.Visible = true;
            //    for (int i = 0; i < 2; i++)
            //    {
            //        label1.Text = 212 + "万元第三次！！请各位慎重决断，抓紧最后的机会出价！";
            //        Thread.Sleep(1000);
            //        pgbJinDuTiao.Value += 10;
            //    }               
            //}
            this.Close();
            FRM_GuaPaiChengJiao myFRM_GuaPaiChengJiao = new FRM_GuaPaiChengJiao(this);
            myFRM_GuaPaiChengJiao.ShowDialog();
        }

        private void FRM_XianShiJingJaiTiShi_MouseLeave(object sender, EventArgs e)
        {
            button1();
        }
    }
}
