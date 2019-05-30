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
    public partial class FRM_LianHeShenQingShengMing : Form
    {
        FRM_JiaoYiDaTing myFRM_JiaoYiDaTing;
        public FRM_LianHeShenQingShengMing(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }
        BLLPaiMaiXiTong.FRM_LianHeShenQingShengMing.FRM_LianHeShenQingShengMingClient myBLL = 
            new BLLPaiMaiXiTong.FRM_LianHeShenQingShengMing.FRM_LianHeShenQingShengMingClient();
        
        //Load事件
        private void FRM_LianHeShenQingShengMing_Load(object sender, EventArgs e)
        {          
            DataTable dt = myBLL.FRM_LianHeShenQingShengMing_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            lbGuaPaiBianHao.Text = "挂牌编号:" + dt.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            lbGuaPaiBianHao2.Text = dt.Rows[0]["GuaPaiBianHao"].ToString().Trim();
        }

        //添加
        private void btnTianJia_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvLianHeShengMing.Rows)
            {
                if (Convert.ToBoolean(dgvr.Cells["XuanZe"].FormattedValue) == true)
                {
                    dgvLianHeShengMing.Rows.Add();
                }
            }
            dgvLianHeShengMing.Visible = false;
        }

        //删除
        private void btnShanChu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvLianHeShengMing.Rows)
            {
                if (Convert.ToBoolean(dgvr.Cells["XuanZe"].Value) == true)
                {
                    int E = dgvr.Index;
                    dgvLianHeShengMing.Rows.RemoveAt(E);
                }
            }
        }
         
        //编辑停止发送事件    
        private void dgvLianHeShengMing_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string KeHuMingCheng = dgvLianHeShengMing.CurrentRow.Cells["KeHuMingCheng"].Value.ToString().Trim();
            DataTable dtLianHeShengMing = myBLL.FRM_LianHeShenQingShengMing_KeHuXinXi(KeHuMingCheng).Tables[0];         
            dgvLianHeShengMing.CurrentRow.Cells["ZhengJianHao"].Value = dtLianHeShengMing.Rows[0]["ZhengJianHao"].ToString().Trim();
            dgvLianHeShengMing.CurrentRow.Cells["KeHuLeiXingMingCheng"].Value = dtLianHeShengMing.Rows[0]["KeHuLeiXingMingCheng"].ToString().Trim();
            dgvLianHeShengMing.CurrentRow.Cells["DianHua"].Value = dtLianHeShengMing.Rows[0]["DianHua"].ToString().Trim();
            dgvLianHeShengMing.CurrentRow.Cells["DiZhi"].Value = dtLianHeShengMing.Rows[0]["DiZhi"].ToString().Trim();
            dgvLianHeShengMing.CurrentRow.Cells["LianXiRen"].Value = dtLianHeShengMing.Rows[0]["LianXiRen"].ToString().Trim();
            dgvLianHeShengMing.CurrentRow.Cells["FaRenDaiBiao"].Value = dtLianHeShengMing.Rows[0]["FaRenDaiBiao"].ToString().Trim();
            dgvLianHeShengMing.CurrentRow.Cells["ChuZiBiLi"].Value = dtLianHeShengMing.Rows[0]["ChuZiBiLi"].ToString().Trim();
            dgvLianHeShengMing.Rows[0].Cells["DanWei"].Value = "%";
        }

        //确定
        private void btnQueDing_Click(object sender, EventArgs e)
        {
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_TianXueJingMaiShenQingShu myFRM_TianXueJingMaiShenQingShu = new FRM_TianXueJingMaiShenQingShu(myFRM_JiaoYiDaTing);
            myFRM_TianXueJingMaiShenQingShu.TopLevel = false;
            myFRM_TianXueJingMaiShenQingShu.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_TianXueJingMaiShenQingShu.Show();
        }

        //全部重置
        private void btnQuanBuChongZhi_Click(object sender, EventArgs e)
        {
            dgvLianHeShengMing.Rows.Clear();
        }
    }
}