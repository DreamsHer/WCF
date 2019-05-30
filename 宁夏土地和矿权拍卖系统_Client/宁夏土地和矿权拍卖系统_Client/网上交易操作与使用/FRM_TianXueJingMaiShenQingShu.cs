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
    public partial class FRM_TianXueJingMaiShenQingShu : Form
    {
        FRM_JiaoYiDaTing myFRM_JiaoYiDaTing;
        public FRM_TianXueJingMaiShenQingShu(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }
        BLLPaiMaiXiTong.FRM_TianXueJingMaiShenQingShu.FRM_TianXueJingMaiShenQingShuClient myBLL =
            new BLLPaiMaiXiTong.FRM_TianXueJingMaiShenQingShu.FRM_TianXueJingMaiShenQingShuClient();
       
        //Load事件
        private void FRM_TianXueJingMaiShenQingShu_Load(object sender, EventArgs e)
        {
            DataTable dt = myBLL.FRM_TianXueJingMaiShenQingShu_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            lbGuaPaiBianHao.Text = "挂牌编号:" + dt.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            lbGuaPaiBianHao1.Text = dt.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            lbGuaPaiQiShiShiJian.Text = dt.Rows[0]["GuaPaiQiShiShiJian"].ToString().Trim();
            lbBaoZhengJinJinE.Text = dt.Rows[0]["BaoZhengJinJinE"].ToString().Trim();
        }
                 
        //同意       
        private void btnTongYi_Click_1(object sender, EventArgs e)
        {
            string KeHuMingCheng = txtShenQingRen.Text.ToString().Trim();
            string FaRenDaiBiao = txtFaRenDaiBiao.Text.ToString().Trim();
            string LianXiRen = txtLianXiRen.Text.ToString().Trim();
            string LianXiDiZhi = txtDiZhi.Text.ToString().Trim();
            string YouZhengBianMa = txtYouZhengBianMa.Text.ToString().Trim();
            string LianXiDianHua = txtDianHua.Text.ToString().Trim();
            DateTime ShenQingShiJian = dtpShenQingShiJian.Value;

            if (KeHuMingCheng != "" && FaRenDaiBiao != "" && LianXiRen != "" && LianXiDiZhi != "" && YouZhengBianMa != "" && LianXiDianHua != "" && ShenQingShiJian != null)
            {
                int dtXinXi = myBLL.btnTongYi_Click_BaoCun1(KeHuMingCheng, FaRenDaiBiao, LianXiRen, LianXiDiZhi, YouZhengBianMa, LianXiDianHua);
                int dtXinXi2 = myBLL.btnTongYi_Click_BaoCun2(ShenQingShiJian);
                if (dtXinXi > 0 && dtXinXi2 > 0)
                {
                    MessageBox.Show("添加成功，确定下一步");
                    myFRM_JiaoYiDaTing.panel1.Controls.Clear();
                    FRM_XunZeYinHang myFRM_XunZeYinHang = new FRM_XunZeYinHang(myFRM_JiaoYiDaTing);
                    myFRM_XunZeYinHang.TopLevel = false;
                    myFRM_XunZeYinHang.Parent = myFRM_JiaoYiDaTing.panel1;
                    myFRM_XunZeYinHang.Show();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                MessageBox.Show("未填完信息");
            }

            //myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            //FRM_XunZeYinHang myFRM_XunZeYinHang = new FRM_XunZeYinHang(myFRM_JiaoYiDaTing);
            //myFRM_XunZeYinHang.TopLevel = false;
            //myFRM_XunZeYinHang.Parent = myFRM_JiaoYiDaTing.panel1;
            //myFRM_XunZeYinHang.Show();
        }       
    }
}
