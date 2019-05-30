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
    public partial class FRM_QiTaGongGao : Form
    {
        FRM_JiaoYiDaTing myFRM_JiaoYiDaTing;
        FRM_JiaoYiDaTing myOneFRM_JiaoYiDaTing;
        public FRM_QiTaGongGao(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
            myOneFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }
        BLLPaiMaiXiTong.FRM_QiTaGongGao.FRM_QiTaGongGaoClient myBLL = new BLLPaiMaiXiTong.FRM_QiTaGongGao.FRM_QiTaGongGaoClient();        
        private DateTime  G_DateTime_Second;       

        //Load事件
        private void FRM_QiTaGongGao_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1_Tick(null, null);
            this.TopMost = true;

            this.progressBar1.Value = 32;
            this.lbFaBuGongGao.Enabled = true;
            this.lbGuaPaiShiJian.Enabled = false;
            this.lbGuaPaiJueZhi.Enabled = false;
            this.lbJingJaiKaiShi.Enabled = false;
            this.lbJingJaiJueShu.Enabled = false;
           
            DataTable dtQiTaGongGao = myBLL.FRM_QiTaGongGao_Load_QiTaGongGao().Tables[0];
            txtJingMaiBaoZhengJin.Text = dtQiTaGongGao.Rows[0]["JingMaiBaoZhengJin"].ToString().Trim() + "万元";
            lbGuaPaiBianHao.Text = dtQiTaGongGao.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            lbGuaPaiBianHao2.Text = dtQiTaGongGao.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            lbFaBuGongGaoShiJian.Text = dtQiTaGongGao.Rows[0]["FaBuShiJian"].ToString().Trim();
            lbGuaPaiQiShiShiJian.Text = dtQiTaGongGao.Rows[0]["GuaPaiQiShiShiJian"].ToString().Trim();
            lbGuaPaiQiShiShiJian1.Text = dtQiTaGongGao.Rows[0]["GuaPaiQiShiShiJian"].ToString().Trim();
            lbGuaPaiJieZhiShiJian.Text = dtQiTaGongGao.Rows[0]["GuaPaiJieZhiShiJian"].ToString().Trim();
            lbGuaPaiJieZhiShiJian1.Text = dtQiTaGongGao.Rows[0]["GuaPaiJieZhiShiJian"].ToString().Trim();
            lbDiKuaiMingCheng.Text = dtQiTaGongGao.Rows[0]["DiKuaiMingCheng"].ToString().Trim();
            lbTuDiQuanGuiShu.Text = dtQiTaGongGao.Rows[0]["TuDiQuanShuDanWei"].ToString().Trim();
            lbTuDiWeiZhi.Text = dtQiTaGongGao.Rows[0]["TuDiWeiZhi"].ToString().Trim();
            lbSuoShuXingZhengQu.Text = dtQiTaGongGao.Rows[0]["SuoShuXingZhengQu"].ToString().Trim();
            lbShiYongQuanMianJi.Text = dtQiTaGongGao.Rows[0]["ShiYongQuanMianJi"].ToString().Trim() + "平方米";
            lbJianZhuMianJi.Text = dtQiTaGongGao.Rows[0]["JianZhuMianJi"].ToString().Trim() + "平方米";
            lbGuiHuaYongTu.Text = dtQiTaGongGao.Rows[0]["GuiHuaYongTu"].ToString().Trim();
            lbGuiHuaZhiBiao.Text = dtQiTaGongGao.Rows[0]["GuiHuaZhiBiao"].ToString().Trim();
            lbChuRangNianXian.Text = dtQiTaGongGao.Rows[0]["ChuRangNianXian"].ToString().Trim() + "年";
            lbJingMaiBaoZhengJin.Text = dtQiTaGongGao.Rows[0]["JingMaiBaoZhengJin"].ToString().Trim() + "万元";
            lbDaoZhangJieZhiShiJian.Text = dtQiTaGongGao.Rows[0]["BaoZhengJinDaoZhangJieZhiShiJian"].ToString().Trim();
            lbQiShiJia_JIngJiaZengJiaFuDu.Text = dtQiTaGongGao.Rows[0]["QiShiJia"].ToString().Trim() + "万元" + "/"
                + dtQiTaGongGao.Rows[0]["ZengFu"].ToString().Trim() + "万元";
            lbBeiZhu.Text = dtQiTaGongGao.Rows[0]["DiKuaiBeiZhu"].ToString().Trim();         
        }

        //倒计时
        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dtDiKuaiXiangQing = myBLL.FRM_QiTaGongGao_Load_QiTaGongGao().Tables[0];
            G_DateTime_Second = Convert.ToDateTime(dtDiKuaiXiangQing.Rows[0]["GuaPaiJieZhiShiJian"].ToString().Trim());
            TimeSpan Span = (G_DateTime_Second - Convert.ToDateTime(DateTime.Now.ToString()));
            lbTian.Text = Span.Days.ToString("00");
            lbShi.Text = Span.Hours.ToString("00");
            lbFen.Text = Span.Minutes.ToString("00");
            lbMiao.Text = Span.Seconds.ToString("00");
        }

        //返回
        private void btnFanHui_Click_1(object sender, EventArgs e)
        {
            myOneFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_DiKuaiXiangQing myFRM_DiKuaiXiangQing = new FRM_DiKuaiXiangQing(myOneFRM_JiaoYiDaTing);
            myFRM_DiKuaiXiangQing.TopLevel = false;
            myFRM_DiKuaiXiangQing.Parent = myOneFRM_JiaoYiDaTing.panel1;
            myFRM_DiKuaiXiangQing.Show();         
        }
    }
}
