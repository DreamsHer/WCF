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
    public partial class FRM_DiTuLiuLan : Form
    {
        FRM_ZhuChuangTi myFRM_ZhuChuangTi;      
        public FRM_DiTuLiuLan(FRM_ZhuChuangTi FRM_ZhuChuangTi)
        {
            InitializeComponent();
            myFRM_ZhuChuangTi = FRM_ZhuChuangTi;
        }

        //Load事件
        private void FRM_DiTuLiuLan_Load(object sender, EventArgs e)
        {

        }

        //关闭
        private void FRM_DiTuLiuLan_FormClosed(object sender, FormClosedEventArgs e)
        {
            //panel1.Controls.Clear();
            //FRM_JiaoYiDaTing myFRM_JiaoYiDaTing = new FRM_JiaoYiDaTing();
            //myFRM_JiaoYiDaTing.TopLevel = false;
            //myFRM_JiaoYiDaTing.Parent = panel1;
            //myFRM_JiaoYiDaTing.Show();         
        }
    }
}
