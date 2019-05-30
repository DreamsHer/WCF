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
    public partial class FRM_JiaoYiDaTing : Form
    {
        public FRM_JiaoYiDaTing(bool DengLuFou)
        {
            InitializeComponent();
            ShiFouDengLu = DengLuFou;
        }
        bool ShiFouDengLu;
        public static int XianZaiDeAnNiuXuHao = 1;

        //Load事件
        private void FRM_JiaoYiDaTing_Load(object sender, EventArgs e)
        {
            if (ShiFouDengLu == true)
            {
                btnWoDeJiaoYi.Visible = true;
                btnWoDeShouCang.Visible = true;
            }
        }

        //show交易大厅主页
        private void FRM_JiaoYiDaTing_Shown(object sender, EventArgs e)
        {
            FRM_JIaoYiDaTingZhuYe_show();
        }
       
        //显示交易大厅主页
        public void FRM_JIaoYiDaTingZhuYe_show()
        {
            panel1.Controls.Clear();
            FRM_JIaoYiDaTingZhuYe myFRM_JIaoYiDaTingZhuYe = new FRM_JIaoYiDaTingZhuYe(this);
            myFRM_JIaoYiDaTingZhuYe.TopLevel = false;
            myFRM_JIaoYiDaTingZhuYe.Parent = panel1;
            myFRM_JIaoYiDaTingZhuYe.Show();
        }

        //点击交易大厅
        private void btnJiaoYiDaTing_Click(object sender, EventArgs e)
        {
            FRM_JIaoYiDaTingZhuYe.YeMa = 1;
            XianZaiDeAnNiuXuHao = 1;
            FRM_JIaoYiDaTingZhuYe.TiaoJianChaXun = 0;
            FRM_JIaoYiDaTingZhuYe_show();
            btnJiaoYiDaTing.BackColor = Color.DodgerBlue;
            btnWoDeJiaoYi.BackColor = Color.Transparent;
            btnWoDeShouCang.BackColor = Color.Transparent;
        }

        //显示我的交易
        public void FRM_WoDeJiaoYi_show()
        {
            panel1.Controls.Clear();
            FRM_WoDeJiaoYi myFRM_WoDeJiaoYi = new FRM_WoDeJiaoYi(this);
            myFRM_WoDeJiaoYi.TopLevel = false;
            myFRM_WoDeJiaoYi.Parent = panel1;
            myFRM_WoDeJiaoYi.Show();
        }

        //点击我的交易
        private void btnWoDeJiaoYi_Click(object sender, EventArgs e)
        {
            if (FRM_ZhuChuangTi.DengLuFou == true)
            {
                panel1.Controls.Clear();
                FRM_WoDeJiaoYi_show();
                btnWoDeJiaoYi.BackColor = Color.DodgerBlue;
                btnJiaoYiDaTing.BackColor = Color.Transparent;
                btnWoDeShouCang.BackColor = Color.Transparent;
            }
            else
            {
                MessageBox.Show("你登录了吗？");
            }
        }

        //显示我的收藏
        public void FRM_WoDeShouCang_show()
        {
            panel1.Controls.Clear();
            FRM_WoDeShouCang myFRM_WoDeShouCang = new FRM_WoDeShouCang(this);
            myFRM_WoDeShouCang.TopLevel = false;
            myFRM_WoDeShouCang.Parent = panel1;
            myFRM_WoDeShouCang.Show();
        }
   
        //点击我的收藏
        private void btnWoDeShouCang_Click(object sender, EventArgs e)
        {
            if (FRM_ZhuChuangTi.DengLuFou == true)
            {
                panel1.Controls.Clear();
                FRM_WoDeShouCang_show();
                btnWoDeShouCang.BackColor = Color.DodgerBlue;
                btnWoDeJiaoYi.BackColor = Color.Transparent;
                btnJiaoYiDaTing.BackColor = Color.Transparent;
            }
            else
            {
                MessageBox.Show("你还没登录呢？");
            }       
        }

    }
}
