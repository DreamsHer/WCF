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
    public partial class FRM_JingMaiShenQingShu : Form
    {
        FRM_WoDeWenDang myFRM_WoDeWenDang;
        public FRM_JingMaiShenQingShu(FRM_WoDeWenDang FRM_WoDeWenDang)
        {
            InitializeComponent();
            myFRM_WoDeWenDang = FRM_WoDeWenDang;
        }
        BLLPaiMaiXiTong.FRM_JingMaiShenQingShu.FRM_JingMaiShenQingShuClient myBLL=new BLLPaiMaiXiTong.FRM_JingMaiShenQingShu.FRM_JingMaiShenQingShuClient();
        public static Point CPoint;

        //Load事件
        private void FRM_JingMaiShenQingShu_Load(object sender, EventArgs e)
        {
            DataTable dtDiKuaiXiangQing = myBLL.FRM_HuoQuBaoZhangJinZhangHao_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            lbGuaPaiBianHao.Text = dtDiKuaiXiangQing.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            lbGuaPaiQiShiShiJian.Text = dtDiKuaiXiangQing.Rows[0]["ShenQingShiJian"].ToString().Trim();
            lbBaoZhengJinJinE.Text = dtDiKuaiXiangQing.Rows[0]["BaoZhengJinJinE"].ToString().Trim();
        }

        //拖动窗体
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            CPoint = new Point(-e.X,- e.Y);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
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
