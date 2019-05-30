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
    public partial class FRM_XiaZaiChuRangWenJian : Form
    {
        FRM_JiaoYiDaTing myFRM_JiaoYiDaTing;
        public FRM_XiaZaiChuRangWenJian(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }

        //Load事件
        private void FRM_XiaZaiChuRangWenJian_Load(object sender, EventArgs e)
        {

        }

        //关闭
        private void FRM_XiaZaiChuRangWenJian_FormClosed(object sender, FormClosedEventArgs e)
        {
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_DiKuaiXiangQing myFRM_DiKuaiXiangQing = new FRM_DiKuaiXiangQing(myFRM_JiaoYiDaTing);
            myFRM_DiKuaiXiangQing.TopLevel = false;
            myFRM_DiKuaiXiangQing.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_DiKuaiXiangQing.Show();
        }
    }
}
