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
    public partial class FRM_ZhiFuGuanLi : Form
    {
        public FRM_ZhiFuGuanLi()
        {
            InitializeComponent();
        }
        BLLPaiMaiXiTong.FRM_ZhiFuGuanLi.FRM_ZhiFuGuanLiClient myBLL=new BLLPaiMaiXiTong.FRM_ZhiFuGuanLi.FRM_ZhiFuGuanLiClient();
        int YeMa = 1;
        int MeiYeShuLiang = 5;
        int ZongYeShu;
        int ZongTiaoShu;
        DataTable dtZongShu;

        //Load事件
        private void FRM_ZhiFuGuanLi_Load(object sender, EventArgs e)
        {
            DataTable dtXingZhengQuMingCheng = myBLL.FRM_ZhiFuGuanLi_Load_XingZhengQuMingCheng().Tables[0];
            cboXingZhengQu.DataSource = dtXingZhengQuMingCheng;
            cboXingZhengQu.ValueMember = "XingZhengQuID";
            cboXingZhengQu.DisplayMember = "XingZhengQuMingCheng";
            cboXingZhengQu.SelectedIndex = -1;
            cboXingZhengQu.SelectedText = " ==XingZhengQuXuanZe== ";

            cboXingZhengQu1.DataSource = dtXingZhengQuMingCheng;
            cboXingZhengQu1.ValueMember = "XingZhengQuID";
            cboXingZhengQu1.DisplayMember = "XingZhengQuMingCheng";
            cboXingZhengQu1.SelectedIndex = -1;
            cboXingZhengQu1.SelectedText = " =XingZhengQuXuanZe= ";        
        }

        //保证金交纳情况--查找
        private void btnChaZhao_Click(object sender, EventArgs e)
        {           
            string DongTaiTiaoJian = "";
            if (txtJingMaiHao.Text !="")
            {
                DongTaiTiaoJian += " and JingPaiBiao.JingMaiHao = " + txtJingMaiHao.Text;                
            }
            if (txtGuaPaiBianHao.Text !="")
            {
                DongTaiTiaoJian += " and GuaPaiBiao.GuaPaiBianHao = " + txtGuaPaiBianHao.Text;
            }
            if (dtpShenQingQiShiShiJian.Value != dtpShenQingJieZhiShiJian.Value)
            {
                DongTaiTiaoJian += " and (ShenQingShuBiao.ShenQingShiJian between '"
                   + dtpShenQingQiShiShiJian.Value.ToShortDateString() + " 00:00:00.000' and '"
                   + dtpShenQingJieZhiShiJian.Value.ToShortDateString() + " 23:59:59.999' )";
            }
            if (Convert.ToInt32(cboXingZhengQu.SelectedIndex) !=-1 )
            {
                DongTaiTiaoJian += " and XingZhengQuBiao.XingZhengQuID = " + cboXingZhengQu.SelectedValue.ToString();
            }
            DataTable dtChaZha = myBLL.btnChaZhao_Click_DongTaiTiaoJianChaZhao(DongTaiTiaoJian).Tables[0];
            dgvBaoZhengJinJiaoNaQingKuang.DataSource = dtChaZha;
        }

        //保证金交纳情况--查找全部
        private void btnChaKanQuanBu_Click(object sender, EventArgs e)
        {
            int KeHuID = Login.KeHuID;
            DataTable dt1 = myBLL.btnChaKanQuanBu_Click_QuanBuChaZhao_FenYe(YeMa, MeiYeShuLiang,KeHuID).Tables[0];
            dgvBaoZhengJinJiaoNaQingKuang.DataSource = dt1;
            dtZongShu = myBLL.btnChaKanQuanBu_Click_QuanBuChaZhao_FenYeZongShu(KeHuID).Tables[0];
            ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);           
            ZongYeShu = ZongTiaoShu / MeiYeShuLiang;
            if (ZongTiaoShu % MeiYeShuLiang != 0)
            {
                ZongYeShu += 1;
            }
            tSLZongYeShu.Text = ZongYeShu.ToString();
            tSLZongTiaoShu.Text = ZongTiaoShu.ToString();
            tSLDangQianYeShu.Text = YeMa.ToString();
        }
     
        //到账查询--查找
        private void btnChaZhao1_Click(object sender, EventArgs e)
        {

        }

        //到账查询--查找全部
        private void btnChaKanQuanBu1_Click(object sender, EventArgs e)
        {
            DataTable dtChaKanQuanBu1 = myBLL.btnChaKanQuanBu1_Click_ChaZhaoQuanBu(YeMa, MeiYeShuLiang).Tables[0];
            dgvDaoZhangChaXun.DataSource = dtChaKanQuanBu1;
            dtZongShu = myBLL.btnChaKanQuanBu_Click_QuanBuChaZhao_ZongShu().Tables[0];
            ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);           
            ZongYeShu = ZongTiaoShu / MeiYeShuLiang;
            if (ZongTiaoShu % MeiYeShuLiang != 0)
            {
                ZongYeShu += 1;
            }
            tSLZongYeShu.Text = ZongYeShu.ToString();
            tSLZongTiaoShu.Text = ZongTiaoShu.ToString();
            tSLDangQianYeShu.Text = YeMa.ToString();          
        }

        //分页部分          
        private void tsbShouYe_Click_1(object sender, EventArgs e)
        {
            if (YeMa != 1)
            {
                int KeHuID = Login.KeHuID;
                YeMa = 1;
                dgvBaoZhengJinJiaoNaQingKuang.DataSource = myBLL.btnChaKanQuanBu_Click_QuanBuChaZhao_FenYe(YeMa, MeiYeShuLiang, KeHuID).Tables[0];
            }
            else
            {
                MessageBox.Show("已到首页");
            }
        }

        private void tsbWeiYe_Click_1(object sender, EventArgs e)
        {
            if (YeMa != ZongYeShu)
            {
                int KeHuID = Login.KeHuID;
                YeMa = ZongYeShu;
                dgvBaoZhengJinJiaoNaQingKuang.DataSource = myBLL.btnChaKanQuanBu_Click_QuanBuChaZhao_FenYe(YeMa, MeiYeShuLiang, KeHuID).Tables[0];
            }
            else
            {
                MessageBox.Show("已到尾页");
            }
        }

        private void tsbShangYiYe_Click_1(object sender, EventArgs e)
        {
            if (YeMa > 1)
            {
                int KeHuID = Login.KeHuID;
                YeMa -= 1;
                dgvBaoZhengJinJiaoNaQingKuang.DataSource = myBLL.btnChaKanQuanBu_Click_QuanBuChaZhao_FenYe(YeMa, MeiYeShuLiang, KeHuID).Tables[0];
            }
            else
            {
                MessageBox.Show("已到第一页");
            }
        }

        private void tsbXaiYiYe_Click_1(object sender, EventArgs e)
        {
            if (YeMa < ZongYeShu)
            {
                int KeHuID = Login.KeHuID;
                YeMa += 1;
                dgvBaoZhengJinJiaoNaQingKuang.DataSource = myBLL.btnChaKanQuanBu_Click_QuanBuChaZhao_FenYe(YeMa, MeiYeShuLiang, KeHuID).Tables[0];
            }
            else
            {
                MessageBox.Show("已到最后一页");
            }
        }

        private void tsbZhuanDao_Click_1(object sender, EventArgs e)
        {
            if (tstDiJiYe.Text != "" && Convert.ToInt32(tstDiJiYe.Text) <= ZongYeShu)
            {
                int KeHuID = Login.KeHuID;
                YeMa = Convert.ToInt32(tstDiJiYe.Text);
                dgvBaoZhengJinJiaoNaQingKuang.DataSource = myBLL.btnChaKanQuanBu_Click_QuanBuChaZhao_FenYe(YeMa, MeiYeShuLiang, KeHuID).Tables[0];
                tstDiJiYe.Text = null;
            }
            else
            {
                MessageBox.Show("请输入(1 ~ " + ZongYeShu + ")" + "之间的数字");
            }
        }
    }
}
