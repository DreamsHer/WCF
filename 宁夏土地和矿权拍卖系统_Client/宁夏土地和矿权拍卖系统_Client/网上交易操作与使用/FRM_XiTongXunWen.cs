using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 宁夏土地和矿权拍卖系统_Client
{
    public partial class FRM_XiTongXunWen : Form
    {
        FRM_ZhuFangBaoZhangXingBiLi myFRM_ZhuFangBaoZhangXingBiLi;        
        public FRM_XiTongXunWen(FRM_ZhuFangBaoZhangXingBiLi FRM_ZhuFangBaoZhangXingBiLi)
        {
            InitializeComponent();
            myFRM_ZhuFangBaoZhangXingBiLi = FRM_ZhuFangBaoZhangXingBiLi;
        }
        FRM_PaiMaiDaTing myFRM_PaiMaiDaTing;
        public FRM_XiTongXunWen(FRM_PaiMaiDaTing FRM_PaiMaiDaTing)
        {
            InitializeComponent();
            myFRM_PaiMaiDaTing = FRM_PaiMaiDaTing;
        }       
        BLLPaiMaiXiTong.FRM_XiTongXunWen.FRM_XiTongXunWenClient myBLL = new BLLPaiMaiXiTong.FRM_XiTongXunWen.FRM_XiTongXunWenClient();

        int NowS = 1;
        int NowM = 4;
        int Now = 0;
        public static int DangQianGuaPaiID;
        public static Point CPoint;
        DataTable dtZiYuanZhaiYao;

        //Load事件
        private void FRM_XiTongXunWen_Load(object sender, EventArgs e)
        {         
            timer1.Start();
           
            dtZiYuanZhaiYao = myBLL.FRM_ZhuFangBaoZhangXingBiLi_Load_ZiYuanZhaiYao(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
            lbGuaPaiBianHao.Text = dtZiYuanZhaiYao.Rows[0]["GuaPaiBianHao"].ToString().Trim();
        }

        //倒计时
        private void timer1_Tick(object sender, EventArgs e)
        {                 
            int S = DateTime.Now.Second;
            int M = DateTime.Now.Minute;
            if (S == 00)
            {
                S = 1;
                Now = 0;
            }
            if (S > Now)
            {
                NowS--;
                if (NowS == -1)
                {
                    NowS = 59;
                }
                if (NowS < 10)
                {                  
                    lbMiao.Text = "0" + NowS.ToString();
                }
                else
                {                    
                    lbMiao.Text = NowS.ToString();
                }
            }
            S = Now;
            if (lbMiao.Text == "59")
            {
                NowM--;               
                lbFen.Text = "0" + NowM.ToString();
            }
            else
            {                
                lbFen.Text = "0" + NowM.ToString();
            }
            if (lbMiao.Text == "00" && lbFen.Text == "00")
            {
                timer1.Enabled = false;
            }
        }

        //确认
        private void btnQueDing_Click(object sender, EventArgs e)
        {
            if (rdbShi.Checked == true)
            {               
                this.Close();
                FRM_XianShiJingJaiTiShi myFRM_XianShiJingJaiTiShi = new FRM_XianShiJingJaiTiShi();
                myFRM_XianShiJingJaiTiShi.ShowDialog();
            }           
            else if (rdbFou.Checked == true)
            {
                this.Close();
            }
            //else
            //{
            //    MessageBox.Show("请选择是否竞价");
            //}        
        }

        //拖动窗体        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            CPoint = new Point(-e.X, -e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = Control.MousePosition;
                myPosittion.Offset(CPoint.X, CPoint.Y);
                this.DesktopLocation = myPosittion;
            }
        }
    }
}
