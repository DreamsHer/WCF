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
    public partial class Login : Form
    {
        FRM_ZhuChuangTi myFRM_ZhuChuangTi;       
        public Login(FRM_ZhuChuangTi FRM_ZhuChuangTi)
        {
            InitializeComponent();
            myFRM_ZhuChuangTi = FRM_ZhuChuangTi;
        }               
        BLLPaiMaiXiTong.Login.LoginClient myBLL = new BLLPaiMaiXiTong.Login.LoginClient();
        public static Point CPoint;
        public static int KeHuID = 0;

        //登录
        private void btnDengLu_Click(object sender, EventArgs e)
        {
            string KeHuMingCheng = txtYongHuMing.Text;
            string ShuZiZhengShuMiMa = txtMiMa.Text;
            if (KeHuMingCheng != "" && ShuZiZhengShuMiMa != "")
            {
                DataTable dt = myBLL.ChaXunKeHuXinXi_DengLu(KeHuMingCheng, ShuZiZhengShuMiMa).Tables[0];
                if (dt.Rows.Count != 0)
                {
                    KeHuID = Convert.ToInt32(dt.Rows[0]["KeHuID"].ToString().Trim());
                    FRM_ZhuChuangTi.DengLuFou = true;
                    myFRM_ZhuChuangTi.FRM_ZhuChuangTi_Load(null, null);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("没有该用户！");
                }
            }
            if (KeHuMingCheng == "")
            {
                MessageBox.Show("请输入用户名");
            }
            if (ShuZiZhengShuMiMa == "")
            {
                MessageBox.Show("请输入密码");
            }
        }

        //窗体扫地事件     
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            CPoint = new Point(-e.X, -e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = Control.MousePosition;
                myPosittion.Offset(CPoint.X, CPoint.Y);
                this.DesktopLocation = myPosittion;
            }
        }

        //关闭
        private void lbGuanBi_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

    }
}
