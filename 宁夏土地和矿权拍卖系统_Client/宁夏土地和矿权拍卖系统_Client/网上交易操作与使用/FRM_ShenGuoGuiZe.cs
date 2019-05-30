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
    public partial class FRM_ShenGuoGuiZe : Form
    {
        FRM_JiaoYiDaTing myFRM_JiaoYiDaTing;
        public FRM_ShenGuoGuiZe(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }
        BLLPaiMaiXiTong.FRM_ShenGuoGuiZe.FRM_ShenGuoGuiZeClient myBLL = new BLLPaiMaiXiTong.FRM_ShenGuoGuiZe.FRM_ShenGuoGuiZeClient();
      
        //Load事件
        private void FRM_ShenGuoGuiZe_Load(object sender, EventArgs e)
        {
            DataTable dt = myBLL.FRM_ShenGuoGuiZe_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            lbGuaPaiBianHao.Text = "挂牌编号:" + dt.Rows[0]["GuaPaiBianHao"].ToString().Trim();
        }

        //同意
        private void btnTongYi_Click(object sender, EventArgs e)
        {
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_JingMaiFangShi myFRM_JingMaiFangShi = new FRM_JingMaiFangShi(myFRM_JiaoYiDaTing);
            myFRM_JingMaiFangShi.TopLevel = false;
            myFRM_JingMaiFangShi.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_JingMaiFangShi.Show();
        }
         
    }
}
