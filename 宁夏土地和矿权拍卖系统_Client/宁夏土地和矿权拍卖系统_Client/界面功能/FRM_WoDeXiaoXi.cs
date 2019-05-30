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
    public partial class FRM_WoDeXiaoXi : Form
    {
        public FRM_WoDeXiaoXi()
        {
            InitializeComponent();
        }      
        BLLPaiMaiXiTong.FRM_WoDeXiaoXi.FRM_WoDeXiaoXiClient myBLL=new BLLPaiMaiXiTong.FRM_WoDeXiaoXi.FRM_WoDeXiaoXiClient();
        int YeMa = 1;
        int MeiYeShuLiang = 8;
        int ZongYeShu;
        int ZongTiaoShu;
        DataTable dtZongShu;      

        //Load事件
        private void FRM_WoDeXiaoXi_Load(object sender, EventArgs e)
        {
           
        }

        //我的消息--查找
        private void btnChaZao_Click(object sender, EventArgs e)
        {
            int KeHuID = Login.KeHuID;
            DateTime GuaPaiQiShiShiJian = dtpXiaoXiQiShiShiJian.Value;
            DateTime GuaPaiJieZhiShiJian = dtpXiaoXiJieZhiShiJian.Value;
            DataTable dtXiaoXiShiJian = myBLL.btnChaZao_Click_WoDeXiaoXi_FenYe(GuaPaiQiShiShiJian, GuaPaiJieZhiShiJian, YeMa, MeiYeShuLiang, KeHuID).Tables[0];         
            dtZongShu = myBLL.btnChaZao_Click_WoDeXiaoXi_ZongShu(KeHuID).Tables[0];
            ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);
            dgvXiaoXi.DataSource = dtXiaoXiShiJian;

            ZongYeShu = ZongTiaoShu / MeiYeShuLiang;
            if (ZongTiaoShu % MeiYeShuLiang != 0)
            {
                ZongYeShu += 1;
            }
            toolStripLabel42.Text = ZongYeShu.ToString();
            toolStripLabel38.Text = ZongTiaoShu.ToString();
            toolStripLabel40.Text = YeMa.ToString();
        }

        //我的消息--全部
        private void btnChaKanQuanBu_Click(object sender, EventArgs e)
        {
            int KeHuID = Login.KeHuID;
            DataTable dtQuanBu = myBLL.btnChaKanQuanBu_Click_WoDeXiaoXi_FenYe(YeMa, MeiYeShuLiang, KeHuID).Tables[0];
            dtZongShu = myBLL.btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShu(KeHuID).Tables[0];
            ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);
            dgvXiaoXi.DataSource = dtQuanBu;

            ZongYeShu = ZongTiaoShu / MeiYeShuLiang;
            if (ZongTiaoShu % MeiYeShuLiang != 0)
            {
                ZongYeShu += 1;
            }
            toolStripLabel42.Text = ZongYeShu.ToString();
            toolStripLabel38.Text = ZongTiaoShu.ToString();
            toolStripLabel40.Text = YeMa.ToString();
        }

        //我的消息分页
        private void toolStripButton27_Click(object sender, EventArgs e)
        {
            if (YeMa != 1)
            {
                YeMa = 1;
                FRM_WoDeXiaoXi_Load(null, null);
            }
            else
            {
                MessageBox.Show("已到首页");
            }
        }

        private void toolStripButton35_Click(object sender, EventArgs e)
        {
            if (YeMa != ZongYeShu)
            {
                YeMa = ZongYeShu;
                FRM_WoDeXiaoXi_Load(null, null);
            }
            else
            {
                MessageBox.Show("已到尾页");
            }
        }

        private void toolStripButton33_Click(object sender, EventArgs e)
        {
            if (YeMa > 1)
            {
                YeMa -= 1;
                FRM_WoDeXiaoXi_Load(null, null);
            }
            else
            {
                MessageBox.Show("已到第一页");
            }
        }

        private void toolStripButton34_Click(object sender, EventArgs e)
        {
            if (YeMa < ZongYeShu)
            {
                YeMa += 1;
                FRM_WoDeXiaoXi_Load(null, null);
            }
            else
            {
                MessageBox.Show("已到最后一页");
            }
        }

        private void toolStripButton36_Click(object sender, EventArgs e)
        {
            if (tstDiJiYe.Text != "" && Convert.ToInt32(tstDiJiYe.Text) <= ZongYeShu)
            {
                YeMa = Convert.ToInt32(tstDiJiYe.Text);
                FRM_WoDeXiaoXi_Load(null, null);
                tstDiJiYe.Text = null;
            }
            else
            {
                MessageBox.Show("请输入(1 ~ " + ZongYeShu + ")" + "之间的数字");
            }
        }

        //我的出价记录--查找
        private void btnChaZhao2_Click(object sender, EventArgs e)
        {
            int KeHuID = Login.KeHuID;
            string DongTaiTiaoJian = "";
            if (tbJingMaiHao.Text.Trim() != "")
            {
                DongTaiTiaoJian += " and JingPaiBiao.JingMaiHao = " + tbJingMaiHao.Text;            
            }
            if (tbGaiPaiBianHao.Text.Trim() != "")
            {
                DongTaiTiaoJian += " and GuaPaiBiao.GuaPaiBianHao = " + tbGaiPaiBianHao.Text;
            }
            if (dtpChuJaiQiShiShiJian.Value != dtpChuJaiQiShiShiJian.Value)
            {
                DongTaiTiaoJian += " and (ChuJiaJiLuBiao.ChuJiaShiJian between '" + dtpChuJaiQiShiShiJian.Value.ToShortDateString() + " 00:00:00.000' and '"
                + dtpChuJaiQiShiShiJian.Value.ToShortDateString() + " 23:59:59.999')";
            }
            DataTable dtChaZhao = myBLL.btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJian(DongTaiTiaoJian).Tables[0];
            dgvWoDeChuJaiJiLu.DataSource = dtChaZhao;          
        }

        //我的出价记录--全部
        private void btnChaKanQuanBu2_Click(object sender, EventArgs e)
        {
            int KeHuID = Login.KeHuID;
            DataTable dtChaKanQuanBu = myBLL.btnChaKanQuanBu2_Click_WoDeChuJaiJiLu(KeHuID).Tables[0];
            if (dtChaKanQuanBu.Rows.Count !=0)
            {
                dgvWoDeChuJaiJiLu.DataSource = dtChaKanQuanBu;
            }
            else
            {
                MessageBox.Show("你的出价记录为空！");
            }
            
        }

        //我的登录情况--查找     
        private void btnChazhao_Click(object sender, EventArgs e)
        {
            int KeHuID = Login.KeHuID;
            DateTime QiShiShiJian = dtpQiShiShiJian3.Value;
            DateTime JeiZhiShiJian = dtpJeiZhiShiJian3.Value;
            DataTable dtShiJian = myBLL.btnChazhao_Click_DengLuQingKuang(QiShiShiJian, JeiZhiShiJian, KeHuID).Tables[0];                   
            if (dtShiJian.Rows.Count != 0)
            {
                dataGridView2.DataSource = dtShiJian;
            }
            else
            {
                MessageBox.Show("你的登录情况为空！");
            }
        }

        //我的登录情况--查看全部
        private void btnChaZhaoQuanBu_Click(object sender, EventArgs e)
        {
            int KeHuID = Login.KeHuID;
            DataTable dtDengLuQingKuang = myBLL.btnChaZhaoQuanBu_Click_DengLuQingKuang(KeHuID).Tables[0];
            if (dtDengLuQingKuang.Rows.Count !=0)
            {
                dataGridView2.DataSource = dtDengLuQingKuang;
            }
            else
            {
                MessageBox.Show("你的登录情况为空！");
            }
        }    

    }
}
