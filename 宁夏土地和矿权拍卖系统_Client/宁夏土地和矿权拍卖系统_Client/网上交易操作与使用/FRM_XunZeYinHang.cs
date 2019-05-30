using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 宁夏土地和矿权拍卖系统_Client
{
    public partial class FRM_XunZeYinHang : Form
    {
        FRM_JiaoYiDaTing myFRM_JiaoYiDaTing;
        public FRM_XunZeYinHang(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }        
        BLLPaiMaiXiTong.FRM_XunZeYinHang.FRM_XunZeYinHangClient myBLL = new BLLPaiMaiXiTong.FRM_XunZeYinHang.FRM_XunZeYinHangClient();

        //Load事件
        private void FRM_XunZeYinHang_Load(object sender, EventArgs e)
        {
            DataTable dt = myBLL.FRM_XunZeYinHang_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            lbGuaPaiBianHao.Text = dt.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            lbGuaPaiQiShiShiJian.Text = dt.Rows[0]["GuaPaiQiShiShiJian"].ToString().Trim();
            lbTuDiWeiZhi.Text = dt.Rows[0]["TuDiWeiZhi"].ToString().Trim();
            lbGuaPaiJueZhiShiJian.Text = dt.Rows[0]["GuaPaiJieZhiShiJian"].ToString().Trim();
            lbJingMaiBaoXanJin.Text = dt.Rows[0]["JingMaiBaoZhengJin"].ToString().Trim() + "万元";
            lbChuRangMianJi.Text = dt.Rows[0]["ChuRangMianJi"].ToString().Trim() + "平方米";
            lbBaoZhuangJinDaoZhangJueZhiZhi.Text = dt.Rows[0]["BaoZhengJinDaoZhangJieZhiRiQi"].ToString().Trim();
            lbQiShiJaiFuDu.Text = dt.Rows[0]["QiShiJia"].ToString().Trim() + "万元" +
                "/" + dt.Rows[0]["ZengJiaFuDu"].ToString().Trim() + "万元";

            rdbXunZeYinHang.Checked = false;
        }

        //确认
        private void ptbQueRen_Click(object sender, EventArgs e)
        {
            if(rdbXunZeYinHang.Checked == true)
            {
                myFRM_JiaoYiDaTing.panel1.Controls.Clear();
                FRM_HuoQuBaoZhangJinZhangHao myFRM_HuoQuBaoZhangJinZhangHao = new FRM_HuoQuBaoZhangJinZhangHao(this);
                myFRM_HuoQuBaoZhangJinZhangHao.TopLevel = false;
                myFRM_HuoQuBaoZhangJinZhangHao.Parent = myFRM_JiaoYiDaTing.panel1;
                myFRM_HuoQuBaoZhangJinZhangHao.Show();
            }
            else
            {
                MessageBox.Show("请选择银行!");
            }  
        }

        //重新绘制
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientMode myLGM = LinearGradientMode.Vertical;
            Rectangle myRA = new Rectangle(0, 0, 783, 34);
            LinearGradientBrush myLGB2 = new LinearGradientBrush(myRA, Color.LightGray, Color.White, myLGM);
            Graphics myJianBian = e.Graphics;
            myJianBian.FillRectangle(myLGB2, myRA);
        }

    }
}