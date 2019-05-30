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
    public partial class FRM_DiKuaiXiangQing : Form
    {
        FRM_JiaoYiDaTing myOneFRM_JiaoYiDaTing;
        public FRM_DiKuaiXiangQing(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myOneFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }   
        BLLPaiMaiXiTong.FRM_DiKuaiXiangQing.FRM_DiKuaiXiangQingClient myBLL=new BLLPaiMaiXiTong.FRM_DiKuaiXiangQing.FRM_DiKuaiXiangQingClient();
        private DateTime  G_DateTime_Second;
        public static int DangQianGuaPaiID;
        public static int ChuJiaJiLuDeShangJi;
        
        //Load事件
        private void FRM_DiKuaiXiangQing_Load(object sender, EventArgs e)
        {                  
            timer1.Enabled = true;
            timer1_Tick(null, null);
            this.TopMost = true;

            this.progressBar1.Value = 40;
            this.lbFaBuGongGao.Enabled = true;
            this.lbGuaPaiShiJian.Enabled = false;
            this.lbGuaPaiJueZhi.Enabled = false;
            this.lbJingJaiKaiShi.Enabled = false;
            this.lbJingJaiJueShu.Enabled = false;

            DataTable dtDiKuaiXiangQing = myBLL.FRM_DiKuaiXiangQing_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            txtJingMaiBaoZhengJin.Text = dtDiKuaiXiangQing.Rows[0]["JingMaiBaoZhengJin"].ToString().Trim() + "万元";
            lbGuaPaiBianHao.Text = dtDiKuaiXiangQing.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            lbGuaPaiBianHao2.Text = dtDiKuaiXiangQing.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            lbFaBuGongGaoShiJian.Text = dtDiKuaiXiangQing.Rows[0]["FaBuShiJian"].ToString().Trim();
            lbGuaPaiQiShiShiJian.Text = dtDiKuaiXiangQing.Rows[0]["GuaPaiQiShiShiJian"].ToString().Trim();
            lbGuaPaiQiShiShiJian1.Text = dtDiKuaiXiangQing.Rows[0]["GuaPaiQiShiShiJian"].ToString().Trim();
            lbGuaPaiJieZhiShiJian.Text = dtDiKuaiXiangQing.Rows[0]["GuaPaiJieZhiShiJian"].ToString().Trim();
            lbGuaPaiJieZhiShiJian1.Text = dtDiKuaiXiangQing.Rows[0]["GuaPaiJieZhiShiJian"].ToString().Trim();
            lbDiKuaiMingCheng.Text = dtDiKuaiXiangQing.Rows[0]["DiKuaiMingCheng"].ToString().Trim();
            lbTuDiQuanGuiShu.Text = dtDiKuaiXiangQing.Rows[0]["TuDiQuanShuDanWei"].ToString().Trim();
            lbTuDiWeiZhi.Text = dtDiKuaiXiangQing.Rows[0]["TuDiWeiZhi"].ToString().Trim();
            lbSuoShuXingZhengQu.Text = dtDiKuaiXiangQing.Rows[0]["SuoShuXingZhengQu"].ToString().Trim();
            lbShiYongQuanMianJi.Text = dtDiKuaiXiangQing.Rows[0]["ShiYongQuanMianJi"].ToString().Trim() + "平方米";
            lbJianZhuMianJi.Text = dtDiKuaiXiangQing.Rows[0]["JianZhuMianJi"].ToString().Trim() + "平方米";
            lbGuiHuaYongTu.Text = dtDiKuaiXiangQing.Rows[0]["GuiHuaYongTu"].ToString().Trim();
            lbGuiHuaZhiBiao.Text = dtDiKuaiXiangQing.Rows[0]["GuiHuaZhiBiao"].ToString().Trim();
            lbChuRangNianXian.Text = dtDiKuaiXiangQing.Rows[0]["ChuRangNianXian"].ToString().Trim() + "年";
            lbJingMaiBaoZhengJin.Text = dtDiKuaiXiangQing.Rows[0]["JingMaiBaoZhengJin"].ToString().Trim() + "万元";
            lbDaoZhangJieZhiShiJian.Text = dtDiKuaiXiangQing.Rows[0]["BaoZhengJinDaoZhangJieZhiShiJian"].ToString().Trim();
            lbQiShiJia_JIngJiaZengJiaFuDu.Text = dtDiKuaiXiangQing.Rows[0]["QiShiJia"].ToString().Trim() + "万元" + "/"
                + dtDiKuaiXiangQing.Rows[0]["ZengFu"].ToString().Trim() + "万元";
            lbBeiZhu.Text = dtDiKuaiXiangQing.Rows[0]["DiKuaiBeiZhu"].ToString().Trim();           
        }

        //倒计时
        private void timer1_Tick(object sender, EventArgs e)
        {          
            DataTable dtDiKuaiXiangQing = myBLL.FRM_DiKuaiXiangQing_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];          
            G_DateTime_Second = Convert.ToDateTime(dtDiKuaiXiangQing.Rows[0]["GuaPaiJieZhiShiJian"].ToString().Trim());
            TimeSpan Span = (G_DateTime_Second - Convert.ToDateTime(DateTime.Now.ToString()));
            lbTian.Text = Span.Days.ToString("00");
            lbShi.Text = Span.Hours.ToString("00");
            lbFen.Text = Span.Minutes.ToString("00");
            lbMiao.Text = Span.Seconds.ToString("00");         
          }

        //出价记录
        private void btnChuJiaJiLu_Click(object sender, EventArgs e)
        {
            ChuJiaJiLuDeShangJi = 2;
            //Label DangQianKongJian = sender as Label;
            //DangQianGuaPaiID = Convert.ToInt32(DangQianKongJian.Tag);
            myOneFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_ChuJiaJiLu myFRM_ChuJiaJiLu = new FRM_ChuJiaJiLu(myOneFRM_JiaoYiDaTing);
            myFRM_ChuJiaJiLu.TopLevel = false;
            myFRM_ChuJiaJiLu.Parent = myOneFRM_JiaoYiDaTing.panel1;
            myFRM_ChuJiaJiLu.Show();
        }

        //出让公告
        private void btnChuRangGongGao_Click(object sender, EventArgs e)
        {
            FRM_JIaoYiDaTingZhuYe.ChuJiaJiLuDeShangJi = 2;
            myOneFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_ChuRangGongGao myFRM_ChuRangGongGao = new FRM_ChuRangGongGao(myOneFRM_JiaoYiDaTing);
            myFRM_ChuRangGongGao.TopLevel = false;
            myFRM_ChuRangGongGao.Parent = myOneFRM_JiaoYiDaTing.panel1;
            myFRM_ChuRangGongGao.Show();
        }

        //出让须知
        private void btnChuRangXuZhi_Click(object sender, EventArgs e)
        {
            myOneFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_ChuRangXuZhi myFRM_ChuRangXuZhi = new FRM_ChuRangXuZhi(myOneFRM_JiaoYiDaTing);
            myFRM_ChuRangXuZhi.TopLevel = false;
            myFRM_ChuRangXuZhi.Parent = myOneFRM_JiaoYiDaTing.panel1;
            myFRM_ChuRangXuZhi.Show();
        }

        //查看现场地图
        private void btnChaKanXianChangTu_Click(object sender, EventArgs e)
        {
            myOneFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_ChaKanXianChangTu myFRM_ChaKanXianChangTu = new FRM_ChaKanXianChangTu(myOneFRM_JiaoYiDaTing);
            myFRM_ChaKanXianChangTu.TopLevel = false;
            myFRM_ChaKanXianChangTu.Parent = myOneFRM_JiaoYiDaTing.panel1;
            myFRM_ChaKanXianChangTu.Show();
        }

        //地图
        private void btnDiTu_Click(object sender, EventArgs e)
        {
            myOneFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_DiTu myFRM_DiTu = new FRM_DiTu(myOneFRM_JiaoYiDaTing);
            myFRM_DiTu.TopLevel = false;
            myFRM_DiTu.Parent = myOneFRM_JiaoYiDaTing.panel1;
            myFRM_DiTu.Show();
        }

        //下载出让文件
        private void btnChuRangXiaZaiWenJian_Click(object sender, EventArgs e)
        {
            myOneFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_XiaZaiChuRangWenJian myFRM_XiaZaiChuRangWenJian = new FRM_XiaZaiChuRangWenJian(myOneFRM_JiaoYiDaTing);
            myFRM_XiaZaiChuRangWenJian.TopLevel = false;
            myFRM_XiaZaiChuRangWenJian.Parent = myOneFRM_JiaoYiDaTing.panel1;
            myFRM_XiaZaiChuRangWenJian.Show();
        }

        //其他公告
        private void btnQiTaGongGao_Click(object sender, EventArgs e)
        {
            myOneFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_QiTaGongGao myFRM_QiTaGongGao = new FRM_QiTaGongGao(myOneFRM_JiaoYiDaTing);
            myFRM_QiTaGongGao.TopLevel = false;
            myFRM_QiTaGongGao.Parent = myOneFRM_JiaoYiDaTing.panel1;
            myFRM_QiTaGongGao.Show();
        }

        //返回
        private void btnFanHui_Click(object sender, EventArgs e)
        {
             //if (FRM_JIaoYiDaTingZhuYe.DiKuaiXiangQingFanHui == 1)
             //{
                myOneFRM_JiaoYiDaTing.panel1.Controls.Clear();
                FRM_JIaoYiDaTingZhuYe myFRM_JIaoYiDaTingZhuYe = new FRM_JIaoYiDaTingZhuYe(myOneFRM_JiaoYiDaTing);
                myFRM_JIaoYiDaTingZhuYe.TopLevel = false;
                myFRM_JIaoYiDaTingZhuYe.Parent = myOneFRM_JiaoYiDaTing.panel1;
                myFRM_JIaoYiDaTingZhuYe.Show();
             //}
             //else if (FRM_JIaoYiDaTingZhuYe.DiKuaiXiangQingFanHui == 2)
             //{
                //myOneFRM_JiaoYiDaTing.panel1.Controls.Clear();
                //FRM_WoDeJiaoYi myFRM_WoDeJiaoYi = new FRM_WoDeJiaoYi(myOneFRM_JiaoYiDaTing);
                //myFRM_WoDeJiaoYi.TopLevel = false;
                //myFRM_WoDeJiaoYi.Parent = myOneFRM_JiaoYiDaTing.panel1;
                //myFRM_WoDeJiaoYi.Show();
            //}
            //else
            //{
                //myOneFRM_JiaoYiDaTing.panel1.Controls.Clear();
                //FRM_WoDeShouCang myFRM_WoDeShouCang = new FRM_WoDeShouCang(myOneFRM_JiaoYiDaTing);
                //myFRM_WoDeShouCang.TopLevel = false;
                //myFRM_WoDeShouCang.Parent = myOneFRM_JiaoYiDaTing.panel1;
                //myFRM_WoDeShouCang.Show();
            //}          
        }
       
    }
}