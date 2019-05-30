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
    public partial class FRM_ZhuChuangTi : Form
    {       
        public FRM_ZhuChuangTi()
        {
            InitializeComponent();           
        }
        BLLPaiMaiXiTong.FRM_ZhuChuangTi.FRM_ZhuChuangTiClient myBLL = new BLLPaiMaiXiTong.FRM_ZhuChuangTi.FRM_ZhuChuangTiClient();
        public static Point CPoint;
        public static bool DengLuFou = false;
        public static int JiaoYiLeiBieID;

        //Load事件
        public void FRM_ZhuChuangTi_Load(object sender, EventArgs e)
        {
            if (DengLuFou == true)
            {
                btnWoDeWenDang.Visible = true;
                btnWoDeXiaoXi.Visible = true;
                btnZhiFuGuanLi.Visible = true;
                btnGeRenZiLiao.Visible = true;
                lbDengLuXiTong.Text = "     切换账号";

                this.panel1.Controls.Clear();
                FRM_JiaoYiDaTing myFRM_JiaoYiDaTing = new FRM_JiaoYiDaTing(DengLuFou);
                myFRM_JiaoYiDaTing.TopLevel = false;
                myFRM_JiaoYiDaTing.Parent = this.panel1;
                myFRM_JiaoYiDaTing.Show();

                int KeHuID = Login.KeHuID;
                DataTable dt = myBLL.ChaXunKeHuXinXi_KuHuID(KeHuID).Tables[0];
                label7.Text = dt.Rows[0]["KeHuMingCheng"].ToString().Trim() + ",你好！";
            }
        }

        //界面时间
        public string GetTime()
        {
            String TimeInString = "";
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;           
            TimeInString = "服务器时间:  ";
            TimeInString += year.ToString() + "年" + month.ToString() + "月" + day.ToString() + "日  ";
            TimeInString += (hour < 10) ? "0" + hour.ToString() + "时" : hour.ToString() + "时";
            TimeInString += (min < 10) ? "0" + min.ToString() + "分" : min.ToString() + "分";
            TimeInString += (sec < 10) ? "0" + sec.ToString() + "秒" : sec.ToString() + "秒";
            return TimeInString;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = GetTime();
        }

        private void FRM_ZhuChuangTi_Paint(object sender, PaintEventArgs e)
        {
            label2.Text = GetTime();
        }

        //土地交易
        private void btnTuDiJiaoYi_Click(object sender, EventArgs e)
        {          
            FRM_JIaoYiDaTingZhuYe.TiaoJianChaXun = 7;
            JiaoYiLeiBieID = 1;
            TuDiJiaoYiDaTing_show();
        }

        //采矿权交易
        private void btnCaiKuangQuanJiaoYi_Click(object sender, EventArgs e)
        {           
            FRM_JIaoYiDaTingZhuYe.TiaoJianChaXun = 7;
            JiaoYiLeiBieID = 2;
            TuDiJiaoYiDaTing_show();
        }

        //探矿权交易
        private void btnTanKuangQuanJiaoYi_Click(object sender, EventArgs e)
        {          
            FRM_JIaoYiDaTingZhuYe.TiaoJianChaXun = 7;
            JiaoYiLeiBieID = 3;
            TuDiJiaoYiDaTing_show();
        }

        //我的文档
        private void btnWoDeWenDang_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FRM_WoDeWenDang myFRM_WoDeWenDang = new FRM_WoDeWenDang();
            myFRM_WoDeWenDang.TopLevel = false;
            myFRM_WoDeWenDang.Parent = panel1;
            myFRM_WoDeWenDang.Show();
        }

        //我的消息
        private void btnWoDeXiaoXi_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FRM_WoDeXiaoXi myFRM_WoDeXiaoXi = new FRM_WoDeXiaoXi();
            myFRM_WoDeXiaoXi.TopLevel = false;
            myFRM_WoDeXiaoXi.Parent = panel1;
            myFRM_WoDeXiaoXi.Show();
        }

        //支付管理
        private void btnZhiFuGuanLi_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FRM_ZhiFuGuanLi myFRM_ZhiFuGuanLi = new FRM_ZhiFuGuanLi();
            myFRM_ZhiFuGuanLi.TopLevel = false;
            myFRM_ZhiFuGuanLi.Parent = panel1;
            myFRM_ZhiFuGuanLi.Show();
        }

        //个人资料
        private void btnGeRenZiLiao_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FRM_GeRenZiLiao myFRM_GeRenZiLiao = new FRM_GeRenZiLiao();
            myFRM_GeRenZiLiao.TopLevel = false;
            myFRM_GeRenZiLiao.Parent = panel1;
            myFRM_GeRenZiLiao.Show();
        }

        //资料下载
        private void btnZiLiaoXiaZai_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FRM_ZiLiaoXiaZai myFRM_ZiLiaoXiaZai = new FRM_ZiLiaoXiaZai();
            myFRM_ZiLiaoXiaZai.TopLevel = false;
            myFRM_ZiLiaoXiaZai.Parent = panel1;
            myFRM_ZiLiaoXiaZai.Show();
        }

        //show土地大厅界面
        public void TuDiJiaoYiDaTing_show()
        {
            panel1.Controls.Clear();
            FRM_JiaoYiDaTing myFRM_JiaoYiDaTing = new FRM_JiaoYiDaTing(DengLuFou);
            myFRM_JiaoYiDaTing.TopLevel = false;
            myFRM_JiaoYiDaTing.Parent = panel1;
            myFRM_JiaoYiDaTing.Show();
        }

        //Show交易资源类别界面
        private void FRM_ZhuChuangTi_Shown(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FRM_JiaoYiZiYuanLieBiao myFRM_JiaoYiZiYuanLieBiao = new FRM_JiaoYiZiYuanLieBiao(this, DengLuFou);
            myFRM_JiaoYiZiYuanLieBiao.TopLevel = false;
            myFRM_JiaoYiZiYuanLieBiao.Parent = panel1;
            myFRM_JiaoYiZiYuanLieBiao.Show();
        }
            
        //Show登录界面
        private void label7_Click(object sender, EventArgs e)
        {
            Login myLogin = new Login(this);
            myLogin.ShowDialog();
        }

        //首页按钮
        private void lbShouYe_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FRM_JiaoYiZiYuanLieBiao myFRM_JiaoYiZiYuanLieBiao = new FRM_JiaoYiZiYuanLieBiao(this, DengLuFou);
            myFRM_JiaoYiZiYuanLieBiao.TopLevel = false;
            myFRM_JiaoYiZiYuanLieBiao.Parent = panel1;
            myFRM_JiaoYiZiYuanLieBiao.Show();
        }

        //地图浏览按钮
        private void lbDiTuliuLan_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FRM_DiTuLiuLan myFRM_DiTuLiuLan = new FRM_DiTuLiuLan(this);
            myFRM_DiTuLiuLan.TopLevel = false;
            myFRM_DiTuLiuLan.Parent = panel1;
            myFRM_DiTuLiuLan.Show();
        }

        //使用帮助按钮
        private void lbShiYongBangZhu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FRM_ShiYongBangZhu myFRM_ShiYongBangZhu = new FRM_ShiYongBangZhu(this);
            myFRM_ShiYongBangZhu.TopLevel = false;
            myFRM_ShiYongBangZhu.Parent = panel1;
            myFRM_ShiYongBangZhu.Show();
        }

        //退出系统按钮
        private void lbAnQuanTuiChu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出该系统?", "提示", MessageBoxButtons.YesNo)
               == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        //主窗体拖动
        private void FRM_ZhuChuangTi_MouseDown(object sender, MouseEventArgs e)
        {
            CPoint = new Point(-e.X, -e.Y);
        }

        private void FRM_ZhuChuangTi_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = Control.MousePosition;
                myPosittion.Offset(CPoint.X, CPoint.Y);
                this.DesktopLocation = myPosittion;
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            CPoint = new Point(-e.X, -e.Y);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = Control.MousePosition;
                myPosittion.Offset(CPoint.X, CPoint.Y);
                this.DesktopLocation = myPosittion;
            }
        }

        //新增全部数据
        private void btnXinZengQuanBuShuJu_Click(object sender, EventArgs e)
        {
            FRM_XinZengJieMian myFRM_XinZengJieMian = new FRM_XinZengJieMian();
            myFRM_XinZengJieMian.ShowDialog();
        }

    }
}
