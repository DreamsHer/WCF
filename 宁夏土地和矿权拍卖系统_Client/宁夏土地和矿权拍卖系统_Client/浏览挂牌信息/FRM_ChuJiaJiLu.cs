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
    public partial class FRM_ChuJiaJiLu : Form
    {
        FRM_JiaoYiDaTing myFRM_JIaoYiDaTing;
        public FRM_ChuJiaJiLu(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JIaoYiDaTing = FRM_JiaoYiDaTing;
        }     
        BLLPaiMaiXiTong.FRM_ChuJiaJiLu.FRM_ChuJiaJiLuClient myBLL = new BLLPaiMaiXiTong.FRM_ChuJiaJiLu.FRM_ChuJiaJiLuClient();
        int ZongTiaoShu;

        //Load事件
        private void FRM_ChuJiaJiLu_Load(object sender, EventArgs e)
        {
            DataTable dtDiKuaiXiangQing = myBLL.FRM_DiKuaiXiangQing_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            lbChuJiaJiLuOnGuaPaiBianHao.Text = dtDiKuaiXiangQing.Rows[0]["GuaPaiBianHao"].ToString().Trim();

            DataTable dtZuiJinChuJaiJiLu = myBLL.FRM_PaiMaiDaTing_Load_ZuiJinChuJaiJiLu(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            dgvChuJiaJiLu.DataSource = dtZuiJinChuJaiJiLu;

            DataTable dtZongShu = myBLL.FRM_PaiMaiDaTing_Load_ZuiJinChuJaiJiLu_ZongShu(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            ZongTiaoShu = dtZuiJinChuJaiJiLu.Rows.Count;
            ZongJiLu.Text = ZongTiaoShu.ToString();
        }

        //关闭
        private void btnChuJiaJiLuGuanBi_Click(object sender, EventArgs e)
        {
            if (FRM_JIaoYiDaTingZhuYe.ChuJiaJiLuDeShangJi == 1)
            {
                myFRM_JIaoYiDaTing.panel1.Controls.Clear();
                FRM_JIaoYiDaTingZhuYe myFRM_JIaoYiDaTingZhuYe = new FRM_JIaoYiDaTingZhuYe(myFRM_JIaoYiDaTing);
                myFRM_JIaoYiDaTingZhuYe.TopLevel = false;
                myFRM_JIaoYiDaTingZhuYe.Parent = myFRM_JIaoYiDaTing.panel1;
                myFRM_JIaoYiDaTingZhuYe.Show();
            }
            else if (FRM_JIaoYiDaTingZhuYe.ChuJiaJiLuDeShangJi == 2)
            {
                myFRM_JIaoYiDaTing.panel1.Controls.Clear();
                FRM_DiKuaiXiangQing myFRM_DiKuaiXiangQing = new FRM_DiKuaiXiangQing(myFRM_JIaoYiDaTing);
                myFRM_DiKuaiXiangQing.TopLevel = false;
                myFRM_DiKuaiXiangQing.Parent = myFRM_JIaoYiDaTing.panel1;
                myFRM_DiKuaiXiangQing.Show();
            }

            else if (FRM_JIaoYiDaTingZhuYe.ChuJiaJiLuDeShangJi == 3)
            {
                myFRM_JIaoYiDaTing.panel1.Controls.Clear();
                FRM_WoDeShouCang myFRM_WoDeShouCang = new FRM_WoDeShouCang(myFRM_JIaoYiDaTing);
                myFRM_WoDeShouCang.TopLevel = false;
                myFRM_WoDeShouCang.Parent = myFRM_JIaoYiDaTing.panel1;
                myFRM_WoDeShouCang.Show();
            }
            else
            {
                //myFRM_JIaoYiDaTing.panel1.Controls.Clear();
                //FRM_WoDeShouCang myFRM_WoDeShouCang = new FRM_WoDeShouCang(myFRM_JIaoYiDaTing);
                //myFRM_WoDeShouCang.TopLevel = false;
                //myFRM_WoDeShouCang.Parent = myFRM_JIaoYiDaTing.panel1;
                //myFRM_WoDeShouCang.Show();
                myFRM_JIaoYiDaTing.panel1.Controls.Clear();
                FRM_DiKuaiXiangQing myFRM_DiKuaiXiangQing = new FRM_DiKuaiXiangQing(myFRM_JIaoYiDaTing);
                myFRM_DiKuaiXiangQing.TopLevel = false;
                myFRM_DiKuaiXiangQing.Parent = myFRM_JIaoYiDaTing.panel1;
                myFRM_DiKuaiXiangQing.Show();
            }
        }

    }
}
