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
    public partial class FRM_JiaoYiZiYuanLieBiao : Form
    {
        FRM_ZhuChuangTi myFRM_ZhuChuangTi;
        bool ShiFouDengLu;
        public FRM_JiaoYiZiYuanLieBiao(FRM_ZhuChuangTi FRM_ZhuChuangTi, bool DengLuFou)
        {
            InitializeComponent();
            myFRM_ZhuChuangTi = FRM_ZhuChuangTi;
            ShiFouDengLu = DengLuFou;
        }                    
        BLLPaiMaiXiTong.FRM_JiaoYiZiYuanLieBiao.FRM_JiaoYiZiYuanLieBiaoClient myBLL= new BLLPaiMaiXiTong.FRM_JiaoYiZiYuanLieBiao.FRM_JiaoYiZiYuanLieBiaoClient();
        bool XunZeXingZhengQuFou;
        int YeMa = 1;
        int MeiYeShuLiang = 20;
        int ZongYeShu;

        //Load事件
        private void FRM_JiaoYiZiYuanLieBiao_Load(object sender, EventArgs e)
        {
            cboXingZhengQu.DataSource = myBLL.ChaXunShuJuXingZhengQu().Tables[0];
            cboXingZhengQu.DisplayMember = "XingZhengQuMingCheng";
            cboXingZhengQu.ValueMember = "XingZhengQuID";
            cboXingZhengQu.SelectedIndex = -1;
            cboXingZhengQu.SelectedText = "== XingZhengQuXuanZe ==";

            ChaXunGuaPaiXinXi();
        }

        //进入交易大厅
        private void dgvJiaoYiZiYuanLieBiao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    dgvJiaoYiZiYuanLieBiao_Show();
                }
            }
        }

        public void dgvJiaoYiZiYuanLieBiao_Show()
        {
            myFRM_ZhuChuangTi.panel1.Controls.Clear();
            FRM_JiaoYiDaTing myFRM_JiaoYiDaTing = new FRM_JiaoYiDaTing(ShiFouDengLu);
            myFRM_JiaoYiDaTing.TopLevel = false;
            myFRM_JiaoYiDaTing.Parent = myFRM_ZhuChuangTi.panel1;
            myFRM_JiaoYiDaTing.Show();
        }

        //交易类别查询 
        public void ChaXunGuaPaiXinXi()
        {
            string DongTaiTiaoJian = "";
            if (rBQuanBu.Checked)
            {
                XunZeXingZhengQuFou = false;
            }
            if (rBTuDiQuanJiaoYi.Checked == true)
            {
                DongTaiTiaoJian += " and GuaPaiBiao.JiaoYiLeiBieID = 1";
            }

            if (rBCaiKuangQuanJiaoYi.Checked == true)
            {
                DongTaiTiaoJian += " and GuaPaiBiao.JiaoYiLeiBieID = 2";
            }

            if (rBTanKuangQuanJiaoYi.Checked == true)
            {
                DongTaiTiaoJian += " and GuaPaiBiao.JiaoYiLeiBieID = 3";
            }

            if (XunZeXingZhengQuFou == true)
            {
                DongTaiTiaoJian += " and GuaPaiBiao.XingZhengQuID = " + cboXingZhengQu.SelectedValue;
            }

            DataTable dt = myBLL.ChaXunShuJuJiaoYiZiYuanLieBiao(DongTaiTiaoJian).Tables[0];
            int ZongTiaoShu = dt.Rows.Count;
            toolZongTiaoShu.Text = ZongTiaoShu.ToString();
            toolDiJiYe.Text = YeMa.ToString();
            ZongYeShu = ZongTiaoShu / MeiYeShuLiang;
            if (ZongTiaoShu % MeiYeShuLiang != 0)
            {
                ZongYeShu += 1;
            }
            toolZongYeShu.Text = ZongYeShu.ToString();
            dgvJiaoYiZiYuanLieBiao.Rows.Clear();
            int XieRuShuLiang = YeMa * MeiYeShuLiang;
            if (ZongTiaoShu < YeMa * XieRuShuLiang)
            {
                XieRuShuLiang = ZongTiaoShu;
            }
            for (int i = (YeMa - 1) * MeiYeShuLiang; i < XieRuShuLiang; i++)
            {
                dgvJiaoYiZiYuanLieBiao.Rows.Add();
                dgvJiaoYiZiYuanLieBiao.Rows[i].Cells["GuaPaiBianHao"].Value = dt.Rows[i]["GuaPaiBianHao"].ToString().Trim();
                dgvJiaoYiZiYuanLieBiao.Rows[i].Cells["JiaoYiFangShi"].Value = dt.Rows[i]["JiaoYiFangShi"].ToString().Trim();
                dgvJiaoYiZiYuanLieBiao.Rows[i].Cells["JiaoYiLeiBie"].Value = dt.Rows[i]["JiaoYiLeiBieMingCheng"].ToString().Trim();
                dgvJiaoYiZiYuanLieBiao.Rows[i].Cells["JiaoYiZhuangTai"].Value = dt.Rows[i]["JiaoYiZhuangTaiMingCheng"].ToString().Trim();
                dgvJiaoYiZiYuanLieBiao.Rows[i].Cells["XingZhengQu"].Value = dt.Rows[i]["XingZhengQuMingCheng"].ToString().Trim();
                dgvJiaoYiZiYuanLieBiao.Rows[i].Cells["GuaPaiShiJian"].Value = dt.Rows[i]["GuaPaiQiShiShiJian"].ToString().Trim()
                    + " 至 " + dt.Rows[i]["GuaPaiJieZhiShiJian"].ToString().Trim();
                dgvJiaoYiZiYuanLieBiao.Rows[i].Cells["CaoZuo"].Value = "进入交易大厅";
            }
        }

        //点击全部
        private void rBQuanBu_CheckedChanged(object sender, EventArgs e)
        {
            ChaXunGuaPaiXinXi();
        }

        //土地交易
        private void rBTuDiQuanJiaoYi_CheckedChanged(object sender, EventArgs e)
        {
            ChaXunGuaPaiXinXi();
        }

        //采矿权交易
        private void rBCaiKuangQuanJiaoYi_CheckedChanged(object sender, EventArgs e)
        {
            ChaXunGuaPaiXinXi();
        }

        //探矿权交易
        private void rBTanKuangQuanJiaoYi_CheckedChanged(object sender, EventArgs e)
        {
            ChaXunGuaPaiXinXi();
        }

        //行政区选择
        private void cboXingZhengQu_SelectedIndexChanged(object sender, EventArgs e)
        {
            XunZeXingZhengQuFou = true;
            ChaXunGuaPaiXinXi();
        }

        //分页
        private void toolStripButton29_Click(object sender, EventArgs e)
        {
            if (YeMa > 1)
            {
                YeMa -= 1;
                ChaXunGuaPaiXinXi();
            }
            else
            {
                MessageBox.Show("已到第一页");
            }
        }

        private void toolStripButton30_Click(object sender, EventArgs e)
        {
            if (YeMa < ZongYeShu)
            {
                YeMa += 1;
                ChaXunGuaPaiXinXi();
            }
            else
            {
                MessageBox.Show("已到最后一页");
            }
        }

        private void toolStripButton28_Click(object sender, EventArgs e)
        {          
            if (YeMa != 1)
            {
                YeMa = 1;
                ChaXunGuaPaiXinXi();
            }
            else
            {
                MessageBox.Show("已到首页");
            }
        }

        private void toolStripButton31_Click(object sender, EventArgs e)
        {           
            if (YeMa != ZongYeShu)
            {
                YeMa = ZongYeShu;
                ChaXunGuaPaiXinXi();
            }
            else
            {
                MessageBox.Show("已到尾页");
            }
        }

        private void toolStripButton32_Click(object sender, EventArgs e)
        {           
            if (tstDiJiYe.Text != "" && Convert.ToInt32(tstDiJiYe.Text) <= ZongYeShu)
            {
                YeMa = Convert.ToInt32(tstDiJiYe.Text);
                ChaXunGuaPaiXinXi();
                tstDiJiYe.Text = null;
            }
            else
            {
                MessageBox.Show("请输入(1 ~ " + ZongYeShu + ")" + "之间的数字");
            }
        }

    }
}