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
    public partial class FRM_PaiMaiDaTing : Form
    {
        FRM_JiaoYiDaTing myFRM_JIaoYiDaTing;        
        public FRM_PaiMaiDaTing(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JIaoYiDaTing = FRM_JiaoYiDaTing;
        }
        BLLPaiMaiXiTong.FRM_PaiMaiDaTing.FRM_PaiMaiDaTingClient myBLL = new BLLPaiMaiXiTong.FRM_PaiMaiDaTing.FRM_PaiMaiDaTingClient();
        private DateTime G_DateTime_Second;
        public decimal MuJunJia = 0;
        DataTable dtChuJiaFuDuMingCheng;
        decimal DangQianZuiGaoJia;
        decimal TuDiMianJi;                                                                                                                 
        DataTable dtZiYuanZhaiYao;
        int ZongTiaoShu;

        //Load事件
        private void FRM_PaiMaiDaTing_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1_Tick(null, null);
            this.TopMost = true;

            dtChuJiaFuDuMingCheng = myBLL.FRM_PaiMaiDaTing_Load_ChuJiaFuDu().Tables[0];
            cboChuJaiFuDu.DataSource = dtChuJiaFuDuMingCheng;
            cboChuJaiFuDu.ValueMember = "ChuJiaFuDuID";
            cboChuJaiFuDu.DisplayMember = "ChuJiaFuDuMingCheng";
            cboChuJaiFuDu.SelectedIndex = -1;
            cboChuJaiFuDu.SelectedText = " 请选择或输入幅度 ";

            dtZiYuanZhaiYao = myBLL.FRM_PaiMaiDaTing_Load_ZiYuanZhaiYao(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
            lbGuaPaiBianHao.Text = dtZiYuanZhaiYao.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            lbDiKuaiMingCheng.Text = dtZiYuanZhaiYao.Rows[0]["DiKuaiMingCheng"].ToString().Trim();
            lbDiKuaiWeiZhi.Text = dtZiYuanZhaiYao.Rows[0]["TuDiWeiZhi"].ToString().Trim();
            lbQiShiJiaOnZengFu.Text = dtZiYuanZhaiYao.Rows[0]["QiShiJia"].ToString().Trim() + "万元"+ "/" +
                dtZiYuanZhaiYao.Rows[0]["ZengFu"].ToString().Trim() + "万元";
            lbTuDiMianJi.Text = dtZiYuanZhaiYao.Rows[0]["ShiYongQuanMianJi"].ToString().Trim() + "平方米";
            lbDangQianZuiGaoJia.Text = dtZiYuanZhaiYao.Rows[0]["ChuJiaJinE"].ToString().Trim();
            
            DataTable dtJingMaiXinXi = myBLL.FRM_PaiMaiDaTing_Load_JingMaiXinXi(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
            txtJingMaiHao.Text = dtJingMaiXinXi.Rows[0]["JingMaiHao"].ToString().Trim();
            txtShenQingYongHu.Text = dtJingMaiXinXi.Rows[0]["KeHuMingCheng"].ToString().Trim();

            if (lbDangQianZuiGaoJia.ToString() !=null && lbTuDiMianJi.ToString() !=null)
            {
                 DangQianZuiGaoJia =Convert.ToDecimal(dtZiYuanZhaiYao.Rows[0]["ChuJiaJinE"].ToString().Trim());
                 TuDiMianJi = Convert.ToDecimal(dtZiYuanZhaiYao.Rows[0]["ShiYongQuanMianJi"].ToString().Trim());
                //亩均价=当前最高价 / (土地面积 / 666.666);
                MuJunJia = DangQianZuiGaoJia / (TuDiMianJi /Convert.ToDecimal( 666.66));
                lbMouJunJia.Text = MuJunJia.ToString("0.0000");
                txtMuJun.Text = MuJunJia.ToString("0.0000");              
            }

            DataTable dtZuiJinChuJaiJiLu = myBLL.FRM_PaiMaiDaTing_Load_ZuiJinChuJaiJiLu(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
            dgvChuJiaJiLu.DataSource = dtZuiJinChuJaiJiLu;

            DataTable dtZongShu = myBLL.FRM_PaiMaiDaTing_Load_ZuiJinChuJaiJiLu_ZongShu(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
            ZongTiaoShu = dtZuiJinChuJaiJiLu.Rows.Count;
            lbChuJiaJiLuTiaoShu.Text = ZongTiaoShu.ToString();
        }

        //倒计时
        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dtZiYuanZhaiYao = myBLL.FRM_PaiMaiDaTing_Load_ZiYuanZhaiYao(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
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
            if (dtChuJiaFuDuMingCheng.Rows.Count != 0)
            {
                MuJunJia = Convert.ToDecimal(lbDangQianZuiGaoJia.Text) + Convert.ToDecimal(txtChuJaiXiaoXe.Text);
                lbDangQianZuiGaoJia.Text = MuJunJia.ToString();
                if (Convert.ToDecimal(lbDangQianZuiGaoJia.Text) >= 1000)
                {
                    MessageBox.Show("您报价成功，出价为：" + lbDangQianZuiGaoJia.Text + "万" + "\n" + "该报价为当前最高价！");
                }
            }
            else
            {
                MessageBox.Show("请填写出价金额！");
            }
        }

        //确认出价
        private void lbQueRenChuJai_Click(object sender, EventArgs e)
        {
            if (dtChuJiaFuDuMingCheng.Rows.Count !=0)
            {
                MuJunJia =Convert.ToDecimal(lbDangQianZuiGaoJia.Text) + Convert.ToDecimal(cboChuJaiFuDu.Text)* 2 ;
                lbDangQianZuiGaoJia.Text = MuJunJia.ToString();
                if (Convert.ToDecimal(lbDangQianZuiGaoJia.Text) >=800)
                {                  
                    MessageBox.Show("您报价成功，出价为："+ lbDangQianZuiGaoJia.Text +"万"+"\n"+"该报价为当前最高价！");                  
                }                                   
            }
            else
            {
                MessageBox.Show("请选择或填写出价金额！");
            }
            //Label DangQianKongJian = sender as Label;
            //DangQianGuaPaiID = Convert.ToInt32(DangQianKongJian.Tag);
            FRM_XiTongXunWen myFRM_XiTongXunWen = new FRM_XiTongXunWen(this);
            myFRM_XiTongXunWen.Show();
        }

    }
}
