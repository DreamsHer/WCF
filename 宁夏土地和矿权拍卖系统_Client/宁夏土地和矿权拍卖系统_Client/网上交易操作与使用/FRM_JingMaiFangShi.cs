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
    public partial class FRM_JingMaiFangShi : Form
    {
        FRM_JiaoYiDaTing myFRM_JiaoYiDaTing;
        public FRM_JingMaiFangShi(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }
        BLLPaiMaiXiTong.FRM_JingMaiFangShi.FRM_JingMaiFangShiClient myBLL = new BLLPaiMaiXiTong.FRM_JingMaiFangShi.FRM_JingMaiFangShiClient();        

        //Load事件
        private void FRM_JingMaiFangShi_Load(object sender, EventArgs e)
        {
            DataTable dt = myBLL.FRM_JingMaiFangShi_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            lbGuaPaiBianHao.Text = "挂牌编号:" + dt.Rows[0]["GuaPaiBianHao"].ToString().Trim();
        }

        //联合申请
        private void btnLianHeShenQing_Click(object sender, EventArgs e)
        {
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_LianHeShenQingShengMing myFRM_LianHeShenQingShengMing = new FRM_LianHeShenQingShengMing(myFRM_JiaoYiDaTing);
            myFRM_LianHeShenQingShengMing.TopLevel = false;
            myFRM_LianHeShenQingShengMing.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_LianHeShenQingShengMing.Show();
        }

        //单独申请
        private void btnDanDuShenQing_Click(object sender, EventArgs e)
        {
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_TianXueJingMaiShenQingShu myFRM_TianXueJingMaiShenQingShu = new FRM_TianXueJingMaiShenQingShu(myFRM_JiaoYiDaTing);
            myFRM_TianXueJingMaiShenQingShu.TopLevel = false;
            myFRM_TianXueJingMaiShenQingShu.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_TianXueJingMaiShenQingShu.Show();
        }

    }
}
