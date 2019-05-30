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
    public partial class FRM_HuoQuBaoZhangJinZhangHao : Form
    {        
        FRM_XunZeYinHang myFRM_XunZeYinHang;
        FRM_WoDeWenDang myFRM_WoDeWenDang;       
        public FRM_HuoQuBaoZhangJinZhangHao(FRM_XunZeYinHang FRM_XunZeYinHang)
        {
            InitializeComponent();
            myFRM_XunZeYinHang = FRM_XunZeYinHang;
        }
       
        public FRM_HuoQuBaoZhangJinZhangHao(FRM_WoDeWenDang FRM_WoDeWenDang)
        {
            InitializeComponent();
            myFRM_WoDeWenDang = FRM_WoDeWenDang;
        }               
        BLLPaiMaiXiTong.FRM_HuoQuBaoZhangJinZhangHao.FRM_HuoQuBaoZhangJinZhangHaoClient myBLL =
            new BLLPaiMaiXiTong.FRM_HuoQuBaoZhangJinZhangHao.FRM_HuoQuBaoZhangJinZhangHaoClient();
        public static Point CPoint;

        //Load事件
        private void FRM_HuoQuBaoZhangJinZhangHao_Load(object sender, EventArgs e)
        {
            DataTable dt = myBLL.FRM_HuoQuBaoZhangJinZhangHao_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            lbGuaPaiBianHao.Text = "挂牌编号:" + dt.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            txtShenQingBianHao.Text = dt.Rows[0]["ShenQingBianHao"].ToString().Trim();
            txtGuaPaiBianHao2.Text = dt.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            txtShenGouRiQi.Text = dt.Rows[0]["ShenQingShiJian"].ToString().Trim();
            txtKaiHuMingCheng.Text = dt.Rows[0]["KeHuMingCheng"].ToString().Trim();
            txtBaoZhengJinJinE.Text = dt.Rows[0]["BaoZhengJinJinE"].ToString().Trim() + "万元";
            txtBaoZhengJinJiaoNaJueZhiShiJian.Text = dt.Rows[0]["BaoZhengJinDaoZhangJieZhiShiJian"].ToString().Trim();
            lbShenChaFou.Text = dt.Rows[0]["ShenQingTiShiXinXi"].ToString().Trim();
         
            DataTable dtBaoZhengJinZhangHao = myBLL.Select_ShengChengBaoZhengJinZhangHao().Tables[0];
            string BaoZhengJinZhangHao = ShengChengBaoZhengJinZhangHao(dtBaoZhengJinZhangHao.Rows[0][0].ToString().Trim());
            txtBaoZhengJinZhangHao.Text = BaoZhengJinZhangHao;
        }

        //打印
        private void btnDaYin_Click(object sender, EventArgs e)
        {
            string BaoZhengJinZhangHao = txtBaoZhengJinZhangHao.Text.ToString().Trim();
            string KaiHuYinXing = txtKaiHuYinHang.Text.ToString().Trim();
            if (BaoZhengJinZhangHao != "")
            {
                int dtBaoZhengJinBiao = myBLL.Select_ShengChengBaoZhengJinZhangHao_XinZeng(BaoZhengJinZhangHao, KaiHuYinXing);

                if (dtBaoZhengJinBiao > 0)
                {
                    MessageBox.Show("确认下一步，打印！");
                }
                else
                {
                    MessageBox.Show("失败！");
                }
            }

            //string ShenQingBianHao = txtShenQingBianHao.Text.ToString().Trim();
            //string ShenQingShiJian = txtShenGouRiQi.Text.ToString().Trim();

            //string YinXingZhangHao = txtBaoZhengJinZhangHao.Text.ToString().Trim();
            //string YinXingMingCheng = txtKaiHuYinHang.Text.ToString().Trim();
            //string ZhangHuMing = txtKaiHuMingCheng.Text.ToString().Trim();

            //if (ShenQingBianHao != "" && ShenQingShiJian != "" && YinXingZhangHao != "" && YinXingMingCheng != "" && ZhangHuMing != "")   
            //{
            //    int dtShenQingBiao = myBLL.btnDaYin_Click_InsertShenQingBiao(ShenQingBianHao, ShenQingShiJian);
            //    int dtBaoZhengJinBiao = myBLL.btnDaYin_Click_InsertBaoZhengJinBiao(YinXingZhangHao, YinXingMingCheng, ZhangHuMing);                  
            //    if (dtShenQingBiao >0 && dtBaoZhengJinBiao >0)
            //    {
            //        MessageBox.Show("确认下一步，打印！");
            //    }
            //    else
            //    {
            //        MessageBox.Show("失败！");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("未填完信息");
            //}
        }

        //自定义生成保证金账号
        public string ShengChengBaoZhengJinZhangHao(string ZuiDaDanJuShu)
        {
            string BaoZhengJinZhangHao = "10068";
            string YueFen = (DateTime.Now.Month.ToString().Length == 1
                            ?
                            "0" + DateTime.Now.Month.ToString() : DateTime.Now.Month.ToString());
            string RiQi = (DateTime.Now.Day.ToString().Length == 1
                            ?
                            "0" + DateTime.Now.Day.ToString() : DateTime.Now.Day.ToString());
            string Shi = (DateTime.Now.Hour.ToString().Length == 1
                            ?
                            "0" + DateTime.Now.Hour.ToString() : DateTime.Now.Hour.ToString());
            string Fen = (DateTime.Now.Minute.ToString().Length == 1
                            ?
                            "0" + DateTime.Now.Minute.ToString() : DateTime.Now.Minute.ToString());
            string Miao = (DateTime.Now.Second.ToString().Length == 1
                            ?
                            "0" + DateTime.Now.Second.ToString() : DateTime.Now.Second.ToString());

            BaoZhengJinZhangHao += (DateTime.Now.Year.ToString() + YueFen + RiQi+ Shi+ Fen+ Miao);          
            return BaoZhengJinZhangHao;
        }

       //拖动窗体
        private void FRM_HuoQuBaoZhangJinZhangHao_MouseDown(object sender, MouseEventArgs e)
        {
            CPoint = new Point(-e.X, -e.Y);
        }

        private void FRM_HuoQuBaoZhangJinZhangHao_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {                
                Point myPosittion = Control.MousePosition;
                myPosittion.Offset(CPoint.X, CPoint.Y);
                this.DesktopLocation = myPosittion;
            }
        }
    }
}
