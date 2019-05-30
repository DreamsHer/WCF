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
    public partial class FRM_ChuRangGongGao : Form
    {
        FRM_JiaoYiDaTing myFRM_JiaoYiDaTing;
        public FRM_ChuRangGongGao(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }      
        BLLPaiMaiXiTong.FRM_ChuRangGongGao.FRM_ChuRangGongGaoClient myBLL = new BLLPaiMaiXiTong.FRM_ChuRangGongGao.FRM_ChuRangGongGaoClient();

        //Load事件
        private void FRM_ChuRangGongGao_Load(object sender, EventArgs e)
        {
            DataTable dtChuRangGongGao = myBLL.FRM_ChuRangGongGao_Load(FRM_JIaoYiDaTingZhuYe.DangQianGuaPaiID).Tables[0];
            lbZongDiBianHao.Text = dtChuRangGongGao.Rows[0]["ZongDiBianHao"].ToString().Trim();
            lbZongDiMianJi.Text = dtChuRangGongGao.Rows[0]["ZongDiMianJi"].ToString().Trim();
            lbZongDiZuoLuo.Text = dtChuRangGongGao.Rows[0]["ZongDiZuoLuo"].ToString().Trim();
            lbChuRangNianXian.Text = dtChuRangGongGao.Rows[0]["ChuRangNianXian"].ToString().Trim() + "年";
            lbRongJiLv.Text = dtChuRangGongGao.Rows[0]["RongJiLv"].ToString().Trim();
            lbJianZhuMiDu.Text = dtChuRangGongGao.Rows[0]["JianZhuMiDu"].ToString().Trim();
            lbLvHuaLu.Text = dtChuRangGongGao.Rows[0]["LvHuaLv"].ToString().Trim();
            lbJianZhuXianGao.Text = dtChuRangGongGao.Rows[0]["JianZhuXianGao"].ToString().Trim();
            lbTuDiYongTu.Text = dtChuRangGongGao.Rows[0]["TuDiYongTu"].ToString().Trim();
            lbTouZiQiangDu.Text = dtChuRangGongGao.Rows[0]["TouZiQiangDu"].ToString().Trim();
            lbBaoZhengJin.Text = dtChuRangGongGao.Rows[0]["BaoZhengJin"].ToString().Trim() + "万元";
            lbXianZhuangTiaoJian.Text = dtChuRangGongGao.Rows[0]["XianZhuangTuDiTiaoJian"].ToString().Trim();
            lbQiShiJai.Text = dtChuRangGongGao.Rows[0]["QiShiJia"].ToString().Trim() + "万元";
            lbJaiJeiFuDu.Text = dtChuRangGongGao.Rows[0]["JiaJiaFuDu"].ToString() + "万元";
            lbGuaPaiKaiShiShiJian.Text = dtChuRangGongGao.Rows[0]["GuaPaiQiShiShiJian"].ToString();
            lbGuaPaiJueZhiShiJian.Text = dtChuRangGongGao.Rows[0]["GuaPaiJieZhiShiJian"].ToString().Trim();
            lbBeiZhu.Text = dtChuRangGongGao.Rows[0]["BeiZhu"].ToString().Trim();
        }

        //关闭
        private void btnChuRangGongGaoOnGuanBi_Click(object sender, EventArgs e)
        {
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_DiKuaiXiangQing myFRM_DiKuaiXiangQing = new FRM_DiKuaiXiangQing(myFRM_JiaoYiDaTing);
            myFRM_DiKuaiXiangQing.TopLevel = false;
            myFRM_DiKuaiXiangQing.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_DiKuaiXiangQing.Show();
        }
    }
}
