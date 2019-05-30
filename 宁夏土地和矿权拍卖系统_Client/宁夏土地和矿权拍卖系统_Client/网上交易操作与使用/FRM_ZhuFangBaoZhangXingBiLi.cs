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
    public partial class FRM_ZhuFangBaoZhangXingBiLi : Form
    {
        FRM_JiaoYiDaTing myFRM_JIaoYiDaTing;
        public FRM_ZhuFangBaoZhangXingBiLi(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JIaoYiDaTing = FRM_JiaoYiDaTing;
        }
        BLLPaiMaiXiTong.FRM_ZhuFangBaoZhangXingBiLi.FRM_ZhuFangBaoZhangXingBiLiClient myBLL = 
            new BLLPaiMaiXiTong.FRM_ZhuFangBaoZhangXingBiLi.FRM_ZhuFangBaoZhangXingBiLiClient();

        private DateTime G_DateTime_Second;
        public decimal BaoZhangXingZhuFangBiLi = 0;
        public decimal DangQianZuiGaoBaoZhangXingBiLi = 0;
        public decimal MuJunJia = 0;        
        decimal DangQianZuiGaoJia;
        decimal TuDiMianJi;
        DataTable dtZiYuanZhaiYao;
        public static int DangQianGuaPaiID;
        int ZongTiaoShu;

        //Load事件
        private void FRM_ZhuFangBaoZhangXingBiLi_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1_Tick(null, null);
            this.TopMost = true;

            dtZiYuanZhaiYao = myBLL.FRM_ZhuFangBaoZhangXingBiLi_Load_ZiYuanZhaiYao(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
            lbGuaPaiBianHao.Text = dtZiYuanZhaiYao.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            lbDiKuaiMingCheng.Text = dtZiYuanZhaiYao.Rows[0]["DiKuaiMingCheng"].ToString().Trim();
            lbDiKuaiWeiZhi.Text = dtZiYuanZhaiYao.Rows[0]["TuDiWeiZhi"].ToString().Trim();
            lbQiShiJiaOnZengFu.Text = dtZiYuanZhaiYao.Rows[0]["QiShiJia"].ToString().Trim() + "万元" + "/" +
                dtZiYuanZhaiYao.Rows[0]["ZengFu"].ToString().Trim() + "万元";
            lbTuDiMianJi.Text = dtZiYuanZhaiYao.Rows[0]["ShiYongQuanMianJi"].ToString().Trim() + "平方米";
            lbDangQianZuiGaoJia.Text = dtZiYuanZhaiYao.Rows[0]["ChuJiaJinE"].ToString().Trim() + "万元";
            lbDangQianZuiGaoBaoZhangXingBiLi.Text= dtZiYuanZhaiYao.Rows[0]["BaoZhangXingZhuFangBiLi"].ToString().Trim();
            txtBaoZhangXingZhuFangBiLi.Text = dtZiYuanZhaiYao.Rows[0]["BaoZhangXingZhuFangBiLi"].ToString();
            txtWoDeChuJai.Text = dtZiYuanZhaiYao.Rows[0]["ChuJiaJinE"].ToString();
            txtBaoZhengXingZhuFangBiLiZengFu.Text = dtZiYuanZhaiYao.Rows[0]["BiLiZengFu"].ToString();
                
            //DataTable dtJingMaiXinXi = myBLL.FRM_ZhuFangBaoZhangXingBiLi_Load_JingMaiXinXi(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
            //txtJingMaiHao.Text = dtJingMaiXinXi.Rows[0]["JingMaiHao"].ToString().Trim();
            //txtShenQingYongHu.Text = dtJingMaiXinXi.Rows[0]["KeHuMingCheng"].ToString().Trim();

            if (lbDangQianZuiGaoJia.ToString() != null && lbTuDiMianJi.ToString() != null)
            {
                DangQianZuiGaoJia = Convert.ToDecimal(dtZiYuanZhaiYao.Rows[0]["ChuJiaJinE"].ToString().Trim());
                TuDiMianJi = Convert.ToDecimal(dtZiYuanZhaiYao.Rows[0]["ShiYongQuanMianJi"].ToString().Trim());               
                MuJunJia = DangQianZuiGaoJia / (TuDiMianJi / Convert.ToDecimal(666.66));
                lbMouJunJia.Text = MuJunJia.ToString("0.0000")+ "万元";             
            }

            DataTable dtZuiJinChuJaiJiLu = myBLL.FRM_ZhuFangBaoZhangXingBiLi_Load_ZuiJinChuJaiJiLu(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
            dgvChuJiaJiLu.DataSource = dtZuiJinChuJaiJiLu;

            DataTable dtZongShu = myBLL.FRM_ZhuFangBaoZhangXingBiLi_Load_ZuiJinChuJaiJiLu_ZongShu(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
            ZongTiaoShu = dtZuiJinChuJaiJiLu.Rows.Count;
            lbChuJiaJiLuTiaoShu.Text = ZongTiaoShu.ToString();
        }

        //倒计时
        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dtZiYuanZhaiYao = myBLL.FRM_ZhuFangBaoZhangXingBiLi_Load_ZiYuanZhaiYao(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
            G_DateTime_Second = Convert.ToDateTime(dtZiYuanZhaiYao.Rows[0]["GuaPaiJieZhiShiJian"].ToString().Trim());
            TimeSpan Span = (G_DateTime_Second - Convert.ToDateTime(DateTime.Now.ToString()));
            lbTian.Text = Span.Days.ToString("00");
            lbShi.Text = Span.Hours.ToString("00");
            lbFen.Text = Span.Minutes.ToString("00");
            lbMiao.Text = Span.Seconds.ToString("00");
        }

        //快速出价
        private void lbKuaiShuChuJai_Click(object sender, EventArgs e)
        {
            DangQianZuiGaoBaoZhangXingBiLi = Convert.ToDecimal(dtZiYuanZhaiYao.Rows[0]["BaoZhangXingZhuFangBiLi"].ToString().Trim())
             + Convert.ToDecimal(dtZiYuanZhaiYao.Rows[0]["BiLiZengFu"].ToString());
            lbDangQianZuiGaoBaoZhangXingBiLi.Text = DangQianZuiGaoBaoZhangXingBiLi.ToString();
            if (lbDangQianZuiGaoBaoZhangXingBiLi.Text != null)
            {
                if (MessageBox.Show("您出价  " + lbDangQianZuiGaoJia.Text + " ," + "\n" + "保障金住房比例为" + lbDangQianZuiGaoBaoZhangXingBiLi.Text + "%，一旦提交不能撤销！", "提示", MessageBoxButtons.YesNo)
                   == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("您出价成功！出价为：" + lbDangQianZuiGaoJia.Text + " ," + "\n" + "保障金住房比例为" + lbDangQianZuiGaoBaoZhangXingBiLi.Text + "%，该比例当前最高保障性住房比例！");
                }
                else
                {
                    MessageBox.Show("要取消报价吗？");
                    lbDangQianZuiGaoBaoZhangXingBiLi.Text = dtZiYuanZhaiYao.Rows[0]["BaoZhangXingZhuFangBiLi"].ToString().Trim();
                    lbDangQianZuiGaoBaoZhangXingBiLi.Text = dtZiYuanZhaiYao.Rows[0]["BaoZhangXingZhuFangBiLi"].ToString().Trim();
                    txtBaoZhengXingZhuFangBiLiZengFu.Text = dtZiYuanZhaiYao.Rows[0]["BiLiZengFu"].ToString();
                }
            }
        }

        //确认出价
        private void lbQueRenChuJai_Click(object sender, EventArgs e)
        {
            DangQianZuiGaoBaoZhangXingBiLi = Convert.ToDecimal(dtZiYuanZhaiYao.Rows[0]["BaoZhangXingZhuFangBiLi"].ToString().Trim())
               + Convert.ToDecimal(dtZiYuanZhaiYao.Rows[0]["BiLiZengFu"].ToString());
            lbDangQianZuiGaoBaoZhangXingBiLi.Text = DangQianZuiGaoBaoZhangXingBiLi.ToString();
            if (lbDangQianZuiGaoBaoZhangXingBiLi.Text != null)
            {
                if (MessageBox.Show("您出价  " + lbDangQianZuiGaoJia.Text + " ," + "\n" + "保障金住房比例为" + lbDangQianZuiGaoBaoZhangXingBiLi.Text + "%，一旦提交不能撤销！", "提示", MessageBoxButtons.YesNo)
                   == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("您出价成功！出价为：" + lbDangQianZuiGaoJia.Text + " ," + "\n" + "保障金住房比例为" + lbDangQianZuiGaoBaoZhangXingBiLi.Text + "%，该比例当前最高保障性住房比例！");
                }
                else
                {
                    MessageBox.Show("要取消报价吗？");
                    lbDangQianZuiGaoBaoZhangXingBiLi.Text = dtZiYuanZhaiYao.Rows[0]["BaoZhangXingZhuFangBiLi"].ToString().Trim();
                    lbDangQianZuiGaoBaoZhangXingBiLi.Text = dtZiYuanZhaiYao.Rows[0]["BaoZhangXingZhuFangBiLi"].ToString().Trim();
                    txtBaoZhengXingZhuFangBiLiZengFu.Text = dtZiYuanZhaiYao.Rows[0]["BiLiZengFu"].ToString();
                }
                //Label DangQianKongJian = sender as Label;
                //DangQianGuaPaiID = Convert.ToInt32(DangQianKongJian.Tag);
                FRM_XiTongXunWen myFRM_XiTongXunWen = new FRM_XiTongXunWen(this);
                myFRM_XiTongXunWen.Show();
            }          
        }

    }
}
