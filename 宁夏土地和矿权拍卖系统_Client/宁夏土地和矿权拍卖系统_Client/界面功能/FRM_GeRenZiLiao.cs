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
    public partial class FRM_GeRenZiLiao : Form
    {
        public FRM_GeRenZiLiao()
        {
            InitializeComponent();
        }
        BLLPaiMaiXiTong.FRM_GeRenZiLiao.FRM_GeRenZiLiaoClient myBLL = new BLLPaiMaiXiTong.FRM_GeRenZiLiao.FRM_GeRenZiLiaoClient();
        DataTable dtGeRenXinXi;
        DataTable dtQiYeYongHu;

        //Load事件
        private void FRM_GeRenZiLiao_Load(object sender, EventArgs e)
        {
                      
        }

        //个人资料
        private void btnChaKanGeRenZiLiao_Click(object sender, EventArgs e)
        {
            int KeHuID = Login.KeHuID;
            dtGeRenXinXi = myBLL.FRM_GeRenZiLiao_Load_GeRenXinXi(KeHuID).Tables[0];
            if (dtGeRenXinXi.Rows.Count != 0)
            {                
                dgvGeRenXinXi.DataSource = dtGeRenXinXi;
            }
            else
            {
                MessageBox.Show("这是个人资料的信息！");
            }
        }

        //企业用户            
        private void btnChaKanQiYeYongHu_Click(object sender, EventArgs e)
        {
            int KeHuID = Login.KeHuID;
            dtQiYeYongHu = myBLL.FRM_GeRenZiLiao_Load_QiYeXinXi(KeHuID).Tables[0];
            if (dtQiYeYongHu.Rows.Count != 0)
            {
                dgvQiYeYongHu.DataSource = dtQiYeYongHu;
            }
            else
            {               
                MessageBox.Show("这是企业用户的信息！");
            }
        }
    }
}
