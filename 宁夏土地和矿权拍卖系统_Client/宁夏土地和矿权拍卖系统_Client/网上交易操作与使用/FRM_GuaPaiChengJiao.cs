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
    public partial class FRM_GuaPaiChengJiao : Form
    {
        FRM_XianShiJingJaiTiShi myFRM_XianShiJingJaiTiShi;
        public FRM_GuaPaiChengJiao(FRM_XianShiJingJaiTiShi FRM_XianShiJingJaiTiShi)
        {
            InitializeComponent();
            myFRM_XianShiJingJaiTiShi = FRM_XianShiJingJaiTiShi;
        }

        BLLPaiMaiXiTong.FRM_GuaPaiChengJiao.FRM_GuaPaiChengJiaoClient myBLL = new BLLPaiMaiXiTong.FRM_GuaPaiChengJiao.FRM_GuaPaiChengJiaoClient();
        public static Point CPoint;
        public static int DangQianGuaPaiID;       

        //Load事件
        private void FRM_GuaPaiChengJiao_Load(object sender, EventArgs e)
        {
            DataTable dtZiYuanZhaiYao = myBLL.FRM_ZhuFangBaoZhangXingBiLi_Load_ZiYuanZhaiYao(FRM_WoDeJiaoYi.DangQianGuaPaiID).Tables[0];
            lbGuaPaiBianHao.Text = dtZiYuanZhaiYao.Rows[0]["GuaPaiBianHao"].ToString().Trim();
        }

        //退出
        private void lbTuiChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_GuaPaiChengJiao_MouseDown(object sender, MouseEventArgs e)
        {
            CPoint = new Point(-e.X, -e.Y);
        }

        private void FRM_GuaPaiChengJiao_MouseMove(object sender, MouseEventArgs e)
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
