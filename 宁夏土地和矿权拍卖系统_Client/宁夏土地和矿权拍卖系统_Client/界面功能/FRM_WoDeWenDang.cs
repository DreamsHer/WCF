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
    public partial class FRM_WoDeWenDang : Form
    {        
        public FRM_WoDeWenDang()
        {
            InitializeComponent();                    
        }      
        BLLPaiMaiXiTong.FRM_WoDeWenDang.FRM_WoDeWenDangClient myBLL=new BLLPaiMaiXiTong.FRM_WoDeWenDang.FRM_WoDeWenDangClient();
        int YeMa = 1;
        int MeiYeShuLiang = 20;
        int ZongYeShu;       

        //Load事件
        private void FRM_WoDeWenDang_Load(object sender, EventArgs e)
        {
           
        }
      
        //条件查询
        private void btnChaZhao_Click(object sender, EventArgs e)
        {
            //dgvJIngMaiShenQingShu.Controls.Clear();
            string DongTaiTiaoJian = "";                      
            if (txtShenQingBianHao.Text.Trim() != "")
            {
                DongTaiTiaoJian += " and ShenQingShuBiao.ShenQingBianHao like '%' +" + txtShenQingBianHao.Text.ToString().Trim() + " +'%'";
            }
            if (txtGuaPaiBianHao.Text.Trim() != "")
            {
                DongTaiTiaoJian += " and GuaPaiBiao.GuaPaiBianHao like '%' +" + txtGuaPaiBianHao.Text.ToString().Trim() + " +'%'";
            }
            if (dtpShenQingQiShiShiJian.Value != dtpShenQingJieZhiShiJian.Value)
            {
                DongTaiTiaoJian += " and (ShenQingShuBiao.ShenQingShiJian between '" + dtpShenQingQiShiShiJian.Value.ToShortDateString() + " 00:00:00.000' and '"
                + dtpShenQingJieZhiShiJian.Value.ToShortDateString() + " 23:59:59.999')";
            }
            DataTable dtChaXun = myBLL.btnChaZhao_Click_DongTaiTiaoJian(DongTaiTiaoJian).Tables[0];
            dgvJIngMaiShenQingShu.DataSource = dtChaXun;

            int ZongTiaoShu = dtChaXun.Rows.Count;
            toolZongTiaoShu.Text = ZongTiaoShu.ToString();
            toolDiJiYe.Text = YeMa.ToString();
            ZongYeShu = ZongTiaoShu / MeiYeShuLiang;
            if (ZongTiaoShu % MeiYeShuLiang != 0)
            {
                ZongYeShu += 1;
            }
            toolZongYeShu.Text = ZongYeShu.ToString();                          
        }

        // 查看全部
        private void btnChaKanQuanBu_Click(object sender, EventArgs e)
        {
            int KeHuID = Login.KeHuID;
            DataTable dt = myBLL.btnChaKanQuanBu_Click_WoDeWenDang(KeHuID).Tables[0];
            dgvJIngMaiShenQingShu.DataSource = dt;
            int ZongTiaoShu = dt.Rows.Count;      
            toolZongTiaoShu.Text = ZongTiaoShu.ToString();
            toolDiJiYe.Text = YeMa.ToString();            
            ZongYeShu = ZongTiaoShu / MeiYeShuLiang;
            if (ZongTiaoShu % MeiYeShuLiang != 0)
            {
                ZongYeShu += 1;
            }
            toolZongYeShu.Text = ZongYeShu.ToString();                             
        }

        //点击dgv中的某一行
        private void dgvJIngMaiShenQingShu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 9)
                {
                    dgvJIngMaiShenQingShu.Controls.Clear();
                    FRM_JingMaiShenQingShu myFRM_JingMaiShenQingShu = new FRM_JingMaiShenQingShu(this);
                    //myFRM_JingMaiShenQingShu.TopLevel = false;
                    //myFRM_JingMaiShenQingShu.Parent = dgvJIngMaiShenQingShu;
                    myFRM_JingMaiShenQingShu.Show();              
                }
                if (e.ColumnIndex == 0)
                {
                    dgvJIngMaiShenQingShu.Controls.Clear();
                    FRM_HuoQuBaoZhangJinZhangHao myFRM_HuoQuBaoZhangJinZhangHao = new FRM_HuoQuBaoZhangJinZhangHao(this);
                    //myFRM_HuoQuBaoZhangJinZhangHao.TopLevel = false;
                    //myFRM_HuoQuBaoZhangJinZhangHao.Parent = dgvJIngMaiShenQingShu;
                    myFRM_HuoQuBaoZhangJinZhangHao.Show();
                }
            }
        }

        //数字证书里的数据
        private void tabWoDeZiGeQueRenShu_Click(object sender, EventArgs e)
        {
            //DataTable dt = myBLL.FRM_HuoQuBaoZhangJinZhangHao_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];           
            //lbKeHuMingCheng.Text = dt.Rows[0]["KeHuMingCheng"].ToString().Trim();
            //lbGuaPaiBianHao.Text = dt.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            //lbGuaPaiJieZhiShiJian.Text = dt.Rows[0]["BaoZhengJinDaoZhangJieZhiShiJian"].ToString().Trim();
            //lbShenQingShiJian.Text = dt.Rows[0]["ShenQingShiJian"].ToString().Trim();
            //lbKeHuMingCheng1.Text = dt.Rows[0]["KeHuMingCheng"].ToString().Trim();
            //lbGuaPaiQiShiShiJian.Text = dt.Rows[0]["ShenQingShiJian"].ToString().Trim();
            //lbGuaPaiJieZhiShiJian1.Text = dt.Rows[0]["BaoZhengJinDaoZhangJieZhiShiJian"].ToString().Trim();
            //lbGuaPaiBianHao1.Text = dt.Rows[0]["GuaPaiBianHao"].ToString().Trim();
            //lbBaoZhengJinJinE.Text = dt.Rows[0]["BaoZhengJinJinE"].ToString().Trim();
        }

        //分页部分        
        private void toolStripButton22_Click(object sender, EventArgs e)
        {
            if (YeMa != 1)
            {
                YeMa = 1;
                FRM_WoDeWenDang_Load(null, null);
            }
            else
            {
                MessageBox.Show("已到首页");
            }
        }
       
        private void toolStripButton25_Click(object sender, EventArgs e)
        {
            if (YeMa != ZongYeShu)
            {
                YeMa = ZongYeShu;
                FRM_WoDeWenDang_Load(null, null);
            }
            else
            {
                MessageBox.Show("已到尾页");
            }
        }
       
        private void toolStripButton24_Click(object sender, EventArgs e)
        {
            if (YeMa < ZongYeShu)
            {
                YeMa += 1;
                FRM_WoDeWenDang_Load(null, null);
            }
            else
            {
                MessageBox.Show("最后一页了");
            }
        }
        
        private void toolStripButton23_Click(object sender, EventArgs e)
        {

            if (YeMa > 1)
            {
                YeMa -= 1;
                FRM_WoDeWenDang_Load(null, null);
            }
            else
            {
                MessageBox.Show("已是第一页");
            }
        }
        
        private void toolStripButton26_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(toolTiaoDaoJiYe.Text) <= ZongYeShu)
            {
                YeMa = Convert.ToInt32(toolTiaoDaoJiYe.Text);                                
                toolTiaoDaoJiYe.Text = null;
            }
            else
            {
                MessageBox.Show("请输入(1 ~ " + ZongYeShu + ")" + "之间的数字");
            }
        }
            
    }
}
