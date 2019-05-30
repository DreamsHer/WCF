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
    public partial class FRM_XinZengJieMian : Form
    {
        public FRM_XinZengJieMian()
        {
            InitializeComponent();
        }
        BLLPaiMaiXiTong.FRM_XinZengShuJu.FRM_XinZengShuJuClient myBLL = new BLLPaiMaiXiTong.FRM_XinZengShuJu.FRM_XinZengShuJuClient();

        //Load事件
        private void FRM_XinZengJieMian_Load(object sender, EventArgs e)
        {
            cboJiaoYiZhuangTai.DataSource = myBLL.XinZengShuJuJiaoYiZhuangTai().Tables[0];
            cboJiaoYiZhuangTai.DisplayMember = "JiaoYiZhuangTaiMingCheng";
            cboJiaoYiZhuangTai.ValueMember = "JiaoYiZhuangTaiID";

            cboJiaoYiLeiBie.DataSource = myBLL.XinZengShuJuJiaoYiLeiBie().Tables[0];
            cboJiaoYiLeiBie.DisplayMember = "JiaoYiLeiBieMingCheng";
            cboJiaoYiLeiBie.ValueMember = "JiaoYiLeiBieID";

            cboXingZhengQu.DataSource = myBLL.XinZengShuJuXingZhengQu().Tables[0];
            cboXingZhengQu.DisplayMember = "XingZhengQuMingCheng";
            cboXingZhengQu.ValueMember = "XingZhengQuID";

            cboKeHuLeiXing.DataSource = myBLL.XinZengShuJuKeHuLeiXing().Tables[0];
            cboKeHuLeiXing.DisplayMember = "KeHuLeiXingMingCheng";
            cboKeHuLeiXing.ValueMember = "KeHuLeiXingID";

            cboShenQingTiSi.DataSource = myBLL.XinZengShuJuShenQingTiSi().Tables[0];
            cboShenQingTiSi.DisplayMember = "ShenQingTiShiXinXi";
            cboShenQingTiSi.ValueMember = "ShenQingTiShiID";

            cboGongGaoLeiXing.DataSource = myBLL.XinZengShuJuGongGaoLeiXing().Tables[0];
            cboGongGaoLeiXing.DisplayMember = "GongGaoLeiXingMingCheng";
            cboGongGaoLeiXing.ValueMember = "GongGaoLeiXingID";

            cboKeHuMingCheng.DataSource = myBLL.XinZengShuJuKeHuMingCheng().Tables[0];
            cboKeHuMingCheng.DisplayMember = "KeHuMingCheng";
            cboKeHuMingCheng.ValueMember = "KeHuID";
        }

        //挂牌表新增
        private void btnGuaPaiBiao_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }
      
        private void btnGuaPaiBiaoXinZeng_Click(object sender, EventArgs e)
        {
            string GuaPaiBianHao = txtGuaPaiBianHao.Text;
            string JiaoYiFangShi = txtJiaoYiFangShi.Text;
            int JiaoYiLeiBieID = Convert.ToInt32(cboJiaoYiLeiBie.SelectedValue);
            int JiaoYiZhuangTaiID = Convert.ToInt32(cboJiaoYiZhuangTai.SelectedValue);
            DateTime GuaPaiQiShiShiJian = dtpGuaPaiQiShi.Value;
            DateTime GuaPaiJieZhiShiJian = dtpGuaPaiJieZhi.Value;
            DateTime BaoZhengJinDaoZhangJieZhiShiJian = dtpDaoZhangJieZhi.Value;
            string DiKuaiMingCheng = txtDiKuaiMingCheng.Text;
            string TuDiWeiZhi = txtTuDiWeiZhi.Text;
            decimal QiShiJia = Convert.ToDecimal(txtQiShiJia.Text);
            decimal ZengFu = Convert.ToDecimal(txtZengFu.Text);
            string YuFuKuan = txtYuFuKuai.Text;
            decimal BaoZhengJin = Convert.ToDecimal(txtBaoZhengJinJinE.Text);
            string TuDiQuanShuDanWei = txtTuDiQuangShuDanWei.Text;
            int XingZhengQuID = Convert.ToInt32(cboXingZhengQu.SelectedValue);
            string ShiYongQuanMianJi = txtShiYongQuanMianJi.Text;
            string JianZhuMianJi = txtJianZhuMianji.Text;
            string GuiHuaYongTu = txtGuiHuaYongTu.Text;
            string GuiHuaZhiBiao = txtGuiHuaZhiBiao.Text;
            string ChuRangNianXian = txtChuRangNianXian.Text;
            string DiKuaiBeiZhu = txtDiKuaiBeiZhi.Text;
            string RongJiLv = txtYongJiLu.Text;
            string JianZhuMiDu = txtJianZhuMiDu.Text;
            string LvHuaLv = txtLuHuaLu.Text;
            string JianZhuXianGao = txtJianZhuXianGao.Text;
            string TouZiQiangDu = txtTouZiQiangDu.Text;
            string XianZhuangTuDiTiaoJian = txtTuDiXianZhuang.Text;
            bool ShiFouYouBaoZhangXingZhuFang = cBYouBaoZhangXingZhuFangFou.Checked;
            bool ShiFouYouFuJiaZiGeShenHeTiaoJian = cBShiFouFuJiaShenHeTiaoJian.Checked;
            string GongGaoBeiZhu = txtGongGaoBeiZhu.Text;
            int ShenQingTiShiID = Convert.ToInt32(cboShenQingTiSi.SelectedValue);
            int KeHuID = Convert.ToInt32(cboKeHuMingCheng.SelectedValue);
            if (cBYouBaoZhangXingZhuFangFou.Checked == true)
            {
                decimal QiShiBaoZhangXingZhuFangBiLi = Convert.ToDecimal(txtBaoZhangBiLi.Text.ToString().Trim());
                decimal ZuiGaoXianJia = Convert.ToDecimal(txtZuiGaoXianJia.Text.ToString().Trim());
                decimal BiLiZengFu = Convert.ToDecimal(txtBiLiZengFu.Text.ToString().Trim());

                int i = myBLL.XinZengGuaPaiShuJu(
                GuaPaiBianHao, JiaoYiFangShi, JiaoYiLeiBieID, JiaoYiZhuangTaiID, GuaPaiQiShiShiJian, GuaPaiJieZhiShiJian,
                BaoZhengJinDaoZhangJieZhiShiJian, DiKuaiMingCheng, TuDiWeiZhi, QiShiJia, ZengFu, YuFuKuan, BaoZhengJin, TuDiQuanShuDanWei,
                XingZhengQuID, ShiYongQuanMianJi, JianZhuMianJi, GuiHuaYongTu, GuiHuaZhiBiao, ChuRangNianXian, DiKuaiBeiZhu, RongJiLv,
                JianZhuMiDu, LvHuaLv, JianZhuXianGao, TouZiQiangDu, XianZhuangTuDiTiaoJian, ShiFouYouBaoZhangXingZhuFang, QiShiBaoZhangXingZhuFangBiLi,
                ZuiGaoXianJia, BiLiZengFu, ShiFouYouFuJiaZiGeShenHeTiaoJian, GongGaoBeiZhu, ShenQingTiShiID, KeHuID);
                if (i > 0)
                {
                    MessageBox.Show("新增成功！");
                }
                else
                {
                    MessageBox.Show("新增失败！");
                }
            }
            else
            {
                decimal QiShiBaoZhangXingZhuFangBiLi = Convert.ToDecimal("0.00");
                decimal ZuiGaoXianJia = Convert.ToDecimal("0.00");
                decimal BiLiZengFu = Convert.ToDecimal("0.00");

                int i = myBLL.XinZengGuaPaiShuJu(
                GuaPaiBianHao, JiaoYiFangShi, JiaoYiLeiBieID, JiaoYiZhuangTaiID, GuaPaiQiShiShiJian, GuaPaiJieZhiShiJian,
                BaoZhengJinDaoZhangJieZhiShiJian, DiKuaiMingCheng, TuDiWeiZhi, QiShiJia, ZengFu, YuFuKuan, BaoZhengJin,
                TuDiQuanShuDanWei, XingZhengQuID, ShiYongQuanMianJi, JianZhuMianJi, GuiHuaYongTu, GuiHuaZhiBiao, ChuRangNianXian,
                DiKuaiBeiZhu, RongJiLv, JianZhuMiDu, LvHuaLv, JianZhuXianGao, TouZiQiangDu, XianZhuangTuDiTiaoJian,
                ShiFouYouBaoZhangXingZhuFang, QiShiBaoZhangXingZhuFangBiLi, ZuiGaoXianJia, BiLiZengFu, ShiFouYouFuJiaZiGeShenHeTiaoJian,
                GongGaoBeiZhu, ShenQingTiShiID, KeHuID
                );
                if (i > 0)
                {
                    MessageBox.Show("新增成功！");
                }
                else
                {
                    MessageBox.Show("新增失败！");
                }
            }
        }

        //公告表新增
        private void btnGongGaoBiao_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;            
        }

        private void btnGongGaoBiaoXinZeng_Click(object sender, EventArgs e)
        {
            string GongGaoBianHao = txtGongGaoBiaoHao.Text;
            string BiaoTi = txtBiaoTi.Text;
            DateTime FaBuShiJian = dtpFaBuRiQi.Value;
            int GongGaoLeiXingID = Convert.ToInt32(cboGongGaoLeiXing.SelectedValue);
            int i = myBLL.XinZengGongGaoBiao(GongGaoBianHao, BiaoTi, FaBuShiJian, GongGaoLeiXingID);
            if (i > 0)
            {
                MessageBox.Show("新增成功！");
            }
            else
            {
                MessageBox.Show("新增失败！");
            }
        }

        private void btnGuanBi_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        //客户表新增
        private void btnKuHuBiao_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void btnKuHuBiaoXinZeng_Click(object sender, EventArgs e)
        {
            int KeHuLeiXingID = Convert.ToInt32(cboKeHuLeiXing.SelectedValue);
            string KeHuMingCheng = txtKeHuMingCheng.Text;
            string ZhengJianHao = txtZhengJianHao.Text;
            string LianXiDiZhi = txtLianXiDiZhi.Text;
            string LianXiRen = txtLianXiRen.Text;
            string FaRenDaiBiao = txtFaRenDaiBiao.Text;
            string YouXiang = txtYouXiang.Text;
            string YouZhengBianMa = txtYouZhengBianMa.Text;
            string LianXiDianHua = txtLianXiDianHua.Text;
            string ShuZiZhengShuMiMa = txtShuZiZhengShuMiMa.Text;
            bool ZhengShuShiFouYouXiao = rbShuZiZhengShuYouXiaoFou.Checked;
            int i = myBLL.XinZengKeHuBiao(
                KeHuLeiXingID, KeHuMingCheng, ZhengJianHao, LianXiDiZhi, LianXiRen, FaRenDaiBiao,
                YouXiang, YouZhengBianMa, LianXiDianHua, ShuZiZhengShuMiMa, ZhengShuShiFouYouXiao
            );
            if (i > 0)
            {
                MessageBox.Show("新增成功！");
            }
            else
            {
                MessageBox.Show("新增失败！");
            }
        }

        private void btnKuHuGuanBi_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }
        
    }
}
