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
    public partial class FRM_JIaoYiDaTingZhuYe : Form
    {
        FRM_JiaoYiDaTing myFRM_JiaoYiDaTing;
        public FRM_JIaoYiDaTingZhuYe(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }          
        BLLPaiMaiXiTong.FRM_JIaoYiDaTingZhuYe.FRM_JIaoYiDaTingZhuYeClient myBLL = new BLLPaiMaiXiTong.FRM_JIaoYiDaTingZhuYe.FRM_JIaoYiDaTingZhuYeClient();
        public static int YeMa = 1;
        int MeiYeShuLiang = 6;
        int ZongTiaoShu;
        int ZongYeShu;
        public static int TiaoJianChaXun = 0;
        DataTable dtZongShu;
        public static string DongTaiTiaoJian = "";
        public static int DangQianGuaPaiID;
        DataTable dtGuaPaiXinXi;
        public static int ChuJiaJiLuDeShangJi;
        public static int DiKuaiXiangQingFanHui;
         
        //Load事件
        private void FRM_JIaoYiDaTingZhuYe_Load(object sender, EventArgs e)
        {
            cbBSuoShuXingZhengQu.DataSource = myBLL.FRM_JIaoYiDaTingZhuYe_Load_XingZhengQu().Tables[0];
            cbBSuoShuXingZhengQu.DisplayMember = "XingZhengQuMingCheng";
            cbBSuoShuXingZhengQu.ValueMember = "XingZhengQuID";
            cbBSuoShuXingZhengQu.SelectedIndex = -1;
            cbBSuoShuXingZhengQu.SelectedText = "== XingZhengQuXuanZe ==";
            
            //主界面分页
            if (TiaoJianChaXun == 0)
            {
                int KeHuID = Login.KeHuID;
                dtGuaPaiXinXi = myBLL.FRM_JIaoYiDaTingZhuYe_Load_FenYe(YeMa, MeiYeShuLiang, KeHuID).Tables[0];
                dtZongShu = myBLL.FRM_JIaoYiDaTingZhuYe_Load_FenYeZongShu(KeHuID).Tables[0];
                ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);
            }
            //查询挂牌公告
            if (TiaoJianChaXun == 1)
            {
                int KeHuID = Login.KeHuID;
                int JiaoYiZhuangTaiID = 1;
                dtZongShu = myBLL.FRM_JIaoYiDaTingZhuYe_Select_GuaPaiGongGao_FenYeZongShu(JiaoYiZhuangTaiID, KeHuID).Tables[0];
                dtGuaPaiXinXi = myBLL.FRM_JIaoYiDaTingZhuYe_Select_GuaPaiGongGao(YeMa, MeiYeShuLiang, KeHuID).Tables[0];
                ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);               
            }
            //查询正在挂牌
            if (TiaoJianChaXun == 2)
            {
                int KeHuID = Login.KeHuID;
                int JiaoYiZhuangTaiID = 2;
                dtZongShu = myBLL.FRM_JIaoYiDaTingZhuYe_Select_ZhengZaiGuaPai_FenYeZongShu(JiaoYiZhuangTaiID, KeHuID).Tables[0];
                dtGuaPaiXinXi = myBLL.FRM_JIaoYiDaTingZhuYe_Select_ZhengZaiGuaPai(YeMa, MeiYeShuLiang, KeHuID).Tables[0];
                ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);
            }
            //查询结果公示
            if (TiaoJianChaXun == 3)
            {
                int KeHuID = Login.KeHuID;
                dtZongShu = myBLL.FRM_JIaoYiDaTingZhuYe_Select_JieGuoGongShi_FenYeZongShu(KeHuID).Tables[0];
                dtGuaPaiXinXi = myBLL.FRM_JIaoYiDaTingZhuYe_Select_JieGuoGongShi(YeMa, MeiYeShuLiang, KeHuID).Tables[0];
                ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);              
            }
          
            //查询预公告
            if (TiaoJianChaXun == 4)
            {
                int GongGaoLeiXingID = 1;
                dtZongShu = myBLL.FRM_JIaoYiDaTingZhuYe_Select_YuGongGao_FenYeZongShu(GongGaoLeiXingID).Tables[0];
                dtGuaPaiXinXi = myBLL.FRM_JIaoYiDaTingZhuYe_Select_YuGongGao(YeMa, MeiYeShuLiang).Tables[0];
                ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);
            }
            //查询其他公告
            if (TiaoJianChaXun == 5)
            {
                int GongGaoLeiXingID = 2;
                dtZongShu = myBLL.FRM_JIaoYiDaTingZhuYe_Select_QiTaGongGao_FenYeZongShu(GongGaoLeiXingID).Tables[0];
                dtGuaPaiXinXi = myBLL.FRM_JIaoYiDaTingZhuYe_Select_QiTaGongGao(YeMa, MeiYeShuLiang).Tables[0];
                ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);
            }
            //高级搜索
            if (TiaoJianChaXun == 6)
            {
                string GuaPaiBianHao = txtGuaPaiBianHao.Text.ToString().Trim();
                DateTime GuaPaiQiShiShiJian = dtpGuaPaiQiShiShiJian.Value;
                DateTime GuaPaiJieZhiShiJian = dtpGuaPaiJieZhiShiJian.Value;
                string TuDiWeiZhi = txtZiYuanWeiZhi.Text.ToString().Trim();
                string KeHuMingCheng = txtJingDeDanWei.Text.ToString().Trim();
                //int XingZhengQuID = Convert.ToInt32(cbBSuoShuXingZhengQu.SelectedValue.ToString());

                if (txtGuaPaiBianHao.Text.Trim() == "")
                {
                    GuaPaiBianHao = "";                   
                }
                if (dtpGuaPaiQiShiShiJian.Value == dtpGuaPaiJieZhiShiJian.Value)
                {
                    GuaPaiQiShiShiJian = Convert.ToDateTime("1900-01-01");
                    GuaPaiJieZhiShiJian = Convert.ToDateTime("1900-01-01");                   
                }
                if (txtZiYuanWeiZhi.Text.Trim() == "")
                {
                    TuDiWeiZhi = "";                  
                }
                if (txtJingDeDanWei.Text.Trim() == "")
                {
                    KeHuMingCheng = "";                  
                }
                if (Convert.ToInt32(cbBSuoShuXingZhengQu.SelectedIndex) == -1)
                {
                    //XingZhengQuID = Convert.ToInt32("0");
                }
                DataTable dtGuaPaiXinXi = myBLL.btnSouSuo_Click_SelectDongTaiTiaoJian(GuaPaiBianHao, GuaPaiQiShiShiJian,
                GuaPaiJieZhiShiJian, TuDiWeiZhi, KeHuMingCheng).Tables[0];
                dtZongShu = myBLL.btnSouSuo_Click_SelectDongTaiTiaoJian_ZongShu().Tables[0];
                ZongTiaoShu = dtGuaPaiXinXi.Rows.Count;
            }
            //按交易类别查询
            if (TiaoJianChaXun == 7)
            {
                int KeHuID = Login.KeHuID;               
                dtGuaPaiXinXi = myBLL.FRM_JIaoYiDaTingZhuYe_JiaoYiZhuangTaiChaXun(YeMa, MeiYeShuLiang, FRM_ZhuChuangTi.JiaoYiLeiBieID, KeHuID).Tables[0];
                dtZongShu = myBLL.FRM_JIaoYiDaTingZhuYe_JiaoYiZhuangTaiChaXunZongShu(FRM_ZhuChuangTi.JiaoYiLeiBieID, KeHuID).Tables[0];
                ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);
            }

            //分页
            ZongYeShu = ZongTiaoShu / MeiYeShuLiang;
            if (ZongTiaoShu % MeiYeShuLiang != 0)
            {
                ZongYeShu += 1;
            }
            tSLZongYeShu.Text = ZongYeShu.ToString();
            tSLZongTiaoShu.Text = ZongTiaoShu.ToString();
            tSLDangQianYeShu.Text = YeMa.ToString();

            ChuangJianKongJian();
        }
      
        //挂牌公告
        private void tSBGuaPaiGongGao_Click(object sender, EventArgs e)
        {           
            YeMa = 1;
            TiaoJianChaXun = 1;
            FRM_JIaoYiDaTingZhuYe_Load(null, null);
        }

        //正在挂牌
        private void tSBZhengZaiGuaPai_Click(object sender, EventArgs e)
        {
            YeMa = 1;
            TiaoJianChaXun = 2;
            FRM_JIaoYiDaTingZhuYe_Load(null, null);
        }

        //结果公示
        private void tSBJieGuoGongShi_Click(object sender, EventArgs e)
        {
            YeMa = 1;
            TiaoJianChaXun = 3;
            FRM_JIaoYiDaTingZhuYe_Load(null, null);
        }

        //预公告
        private void tSBYuGongGao_Click(object sender, EventArgs e)
        {
            YeMa = 1;
            TiaoJianChaXun = 4;
            FRM_JIaoYiDaTingZhuYe_Load(null, null);
        }

        //其他公告
        private void tSBQiTaGongGao_Click(object sender, EventArgs e)
        {
            YeMa = 1;
            TiaoJianChaXun = 5;
            FRM_JIaoYiDaTingZhuYe_Load(null, null);
        }

        //高级搜索
        private void tSBGaoJiSouSuo_Click(object sender, EventArgs e)
        {
            grBGaoJiSuoSou.Visible = true;
        }

        private void btnSouSuo_Click(object sender, EventArgs e)
        {           
            YeMa = 1;
            TiaoJianChaXun = 6;
            FRM_JIaoYiDaTingZhuYe_Load(null, null);
            grBGaoJiSuoSou.Visible = false;

            string GuaPaiBianHao = txtGuaPaiBianHao.Text.ToString().Trim();
            DateTime GuaPaiQiShiShiJian = dtpGuaPaiQiShiShiJian.Value;
            DateTime GuaPaiJieZhiShiJian = dtpGuaPaiJieZhiShiJian.Value;
            string TuDiWeiZhi = txtZiYuanWeiZhi.Text.ToString().Trim();
            string KeHuMingCheng = txtJingDeDanWei.Text.ToString().Trim();
            //int XingZhengQuID = Convert.ToInt32(cbBSuoShuXingZhengQu.SelectedValue.ToString());
            if (txtGuaPaiBianHao.Text.Trim() == "")
            {
                GuaPaiBianHao = "";
                FRM_JIaoYiDaTingZhuYe_Load(null, null);
            }
            if (dtpGuaPaiQiShiShiJian.Value == dtpGuaPaiJieZhiShiJian.Value)
            {
                GuaPaiQiShiShiJian = Convert.ToDateTime("1900-01-01");
                GuaPaiJieZhiShiJian = Convert.ToDateTime("1900-01-01");
                FRM_JIaoYiDaTingZhuYe_Load(null, null);                
            }
            if (txtZiYuanWeiZhi.Text.Trim() == "")
            {
                TuDiWeiZhi = "";
                FRM_JIaoYiDaTingZhuYe_Load(null, null);
            }
            if (txtJingDeDanWei.Text.Trim() == "")
            {
                KeHuMingCheng = "";
                FRM_JIaoYiDaTingZhuYe_Load(null, null);
            }
            //if (Convert.ToInt32(cbBSuoShuXingZhengQu.SelectedIndex) == -1)
            //{
            //     XingZhengQuID = Convert.ToInt32("0");
            //}
            DataTable dtGuaPaiXinXi = myBLL.btnSouSuo_Click_SelectDongTaiTiaoJian(GuaPaiBianHao, GuaPaiQiShiShiJian, GuaPaiJieZhiShiJian, TuDiWeiZhi, KeHuMingCheng).Tables[0];
            dtZongShu = myBLL.btnSouSuo_Click_SelectDongTaiTiaoJian_ZongShu().Tables[0];
            ZongTiaoShu = dtGuaPaiXinXi.Rows.Count;                      
        }

        private void btnChongZhi_Click(object sender, EventArgs e)
        {
            txtGuaPaiBianHao.Text = "";
            txtJingDeDanWei.Text = "";
            txtZiYuanWeiZhi.Text = "";
            cbBSuoShuXingZhengQu.SelectedIndex = -1;          
            cbBSuoShuXingZhengQu.Text = "==XingZhengQuXuanZe==";
            dtpChengJiaoJieZhiShiJian.Value = Convert.ToDateTime(DateTime.Now.Year.ToString()
                + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString());
            dtpChengJiaoQiShiShiJian.Value = Convert.ToDateTime(DateTime.Now.Year.ToString()
                + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString());
            dtpGuaPaiJieZhiShiJian.Value = Convert.ToDateTime(DateTime.Now.Year.ToString()
                + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString());
            dtpGuaPaiQiShiShiJian.Value = Convert.ToDateTime(DateTime.Now.Year.ToString()
                + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString());
        }

        private void btnGuanBi_Click(object sender, EventArgs e)
        {
            grBGaoJiSuoSou.Visible = false;
        }
  
        //创建控件
        private void ChuangJianKongJian()
        {
            flpGuaPaiXinXi.Controls.Clear();
            if (TiaoJianChaXun != 6)
            {
                foreach (DataRow dr in dtGuaPaiXinXi.Rows)
                {
                    PictureBox ChuangJianTouMingKongJian = new PictureBox();
                    if (TiaoJianChaXun != 4 && TiaoJianChaXun != 5)
                    {
                        ChuangJianTouMingKongJian.Tag = dr["GuaPaiID"].ToString();
                        ChuangJianTouMingKongJian.Size = new Size(271, 259);
                        ChuangJianTouMingKongJian.BackColor = Color.Transparent;
                        ChuangJianTouMingKongJian.Paint += new PaintEventHandler(pb_Paint);
                        flpGuaPaiXinXi.Controls.Add(ChuangJianTouMingKongJian);
                        int X = 54;
                        int Y = 198;
                        int geshu = 0;
                        if (Convert.ToInt32(dr["JiaoYiZhuangTaiID"]) == 1 || Convert.ToInt32(dr["JiaoYiZhuangTaiID"]) == 2)
                        {
                            geshu += 1;
                            Label myLabel_1 = new Label();
                            myLabel_1.Name = "ShouCang";
                            myLabel_1.Tag = dr["GuaPaiID"].ToString();
                            myLabel_1.Size = new Size(88, 23);
                            myLabel_1.ForeColor = Color.White;
                            myLabel_1.Padding = new Padding(25, 4, 3, 3);
                            myLabel_1.Text = "加入收藏";
                            myLabel_1.Cursor = Cursors.Hand;
                            myLabel_1.BackgroundImage = Properties.Resources._6_03;
                            myLabel_1.Location = new Point(X, Y);
                            ChuangJianTouMingKongJian.Controls.Add(myLabel_1);
                            X += 100;
                        }
                        geshu += 1;
                        Label myLabel_2 = new Label();
                        myLabel_2.Name = "XingQing";
                        myLabel_2.Tag = dr["GuaPaiID"].ToString();
                        myLabel_2.Size = new Size(88, 23);
                        myLabel_2.ForeColor = Color.White;
                        myLabel_2.Padding = new Padding(25, 4, 3, 3);
                        myLabel_2.Text = "地块详情";
                        myLabel_2.Cursor = Cursors.Hand;
                        myLabel_2.BackgroundImage = Properties.Resources._6_03;
                        myLabel_2.Location = new Point(X, Y);
                        ChuangJianTouMingKongJian.Controls.Add(myLabel_2);
                        if (geshu == 2)
                        {
                            X = 54;
                            Y += 25;
                        }
                        else
                        {
                            X += 100;
                        }
                        if (Convert.ToInt32(dr["JiaoYiZhuangTaiID"]) != 1)
                        {
                            Label myLabel_3 = new Label();
                            myLabel_3.Name = "ChuJai";
                            myLabel_3.Tag = dr["GuaPaiID"].ToString();
                            myLabel_3.Size = new Size(88, 23);
                            myLabel_3.ForeColor = Color.White;
                            myLabel_3.Padding = new Padding(25, 4, 3, 3);
                            myLabel_3.Text = "出价记录";
                            myLabel_3.Cursor = Cursors.Hand;
                            myLabel_3.BackgroundImage = Properties.Resources._6_03;
                            myLabel_3.Location = new Point(X, Y);
                            ChuangJianTouMingKongJian.Controls.Add(myLabel_3);
                            if (geshu == 3)
                            {
                                X = 54;
                                Y += 25;
                            }
                            else
                            {
                                X += 100;
                            }
                        }
                        if (Convert.ToInt32(dr["JiaoYiZhuangTaiID"]) == 2)
                        {
                            Label myLabel_4 = new Label();
                            myLabel_4.Name = "ShenGou";
                            myLabel_4.Tag = dr["GuaPaiID"].ToString();
                            myLabel_4.Size = new Size(88, 23);
                            myLabel_4.ForeColor = Color.White;
                            myLabel_4.Padding = new Padding(25, 4, 3, 3);
                            myLabel_4.Text = "我要申购";
                            myLabel_4.Cursor = Cursors.Hand;
                            myLabel_4.BackgroundImage = Properties.Resources._6_03;
                            myLabel_4.Location = new Point(X, Y);
                            ChuangJianTouMingKongJian.Controls.Add(myLabel_4);
                        }

                        foreach (Control control in ChuangJianTouMingKongJian.Controls)
                        {
                            switch (control.Name)
                            {
                                case "ShouCang":
                                    control.Click += new EventHandler(btnClickShouCang);
                                    break;
                                case "XingQing":
                                    control.Click += new EventHandler(btnClickXingQing);
                                    break;
                                case "ChuJai":
                                    control.Click += new EventHandler(btnClickChuJai);
                                    break;
                                case "ShenGou":
                                    control.Click += new EventHandler(btnClickShenGou);
                                    break;
                            }
                        }
                    }
                    else
                    {
                        ChuangJianTouMingKongJian.Tag = dr["GongGaoLeiXingID"].ToString();
                        ChuangJianTouMingKongJian.Size = new Size(271, 259);
                        ChuangJianTouMingKongJian.BackColor = Color.Transparent;
                        ChuangJianTouMingKongJian.Paint += new PaintEventHandler(pb_Paint);
                        flpGuaPaiXinXi.Controls.Add(ChuangJianTouMingKongJian);

                        Label myLabel_5 = new Label();
                        myLabel_5.Name = "GongGao";
                        myLabel_5.Tag = dr["GongGaoLeiXingID"].ToString();
                        myLabel_5.Size = new Size(88, 23);
                        myLabel_5.ForeColor = Color.White;
                        myLabel_5.Padding = new Padding(25, 4, 3, 3);
                        myLabel_5.Text = "公告详情";
                        myLabel_5.Cursor = Cursors.Hand;
                        myLabel_5.BackgroundImage = Properties.Resources._6_03;
                        myLabel_5.Location = new Point(104, 198);
                        ChuangJianTouMingKongJian.Controls.Add(myLabel_5);
                        myLabel_5.Click += new EventHandler(btnClickGongGaoXiangQing);
                    }
                }
            }
            
            else
            {
                for (int i = (YeMa - 1) * MeiYeShuLiang; i < YeMa * MeiYeShuLiang && i < ZongTiaoShu; i++)
                {
                    PictureBox ChuangJianTouMingKongJian = new PictureBox();
                    ChuangJianTouMingKongJian.Tag = dtGuaPaiXinXi.Rows[i]["GuaPaiID"].ToString();
                    ChuangJianTouMingKongJian.Size = new Size(271, 259);
                    ChuangJianTouMingKongJian.BackColor = Color.Transparent;
                    ChuangJianTouMingKongJian.Paint += new PaintEventHandler(pb_Paint);
                    flpGuaPaiXinXi.Controls.Add(ChuangJianTouMingKongJian);
                    int X = 54;
                    int Y = 198;
                    int geshu = 0;
                    if (Convert.ToInt32(dtGuaPaiXinXi.Rows[i]["JiaoYiZhuangTaiID"]) == 1 
                        || Convert.ToInt32(dtGuaPaiXinXi.Rows[i]["JiaoYiZhuangTaiID"]) == 2)
                    {
                        geshu += 1;
                        Label myLabel_1 = new Label();
                        myLabel_1.Name = "ShouCang";
                        myLabel_1.Tag = dtGuaPaiXinXi.Rows[i]["GuaPaiID"].ToString();
                        myLabel_1.Size = new Size(88, 23);
                        myLabel_1.ForeColor = Color.White;
                        myLabel_1.Padding = new Padding(25, 4, 3, 3);
                        myLabel_1.Text = "加入收藏";
                        myLabel_1.Cursor = Cursors.Hand;
                        myLabel_1.BackgroundImage = Properties.Resources._6_03;
                        myLabel_1.Location = new Point(X, Y);
                        ChuangJianTouMingKongJian.Controls.Add(myLabel_1);
                        X += 100;
                    }
                    geshu += 1;
                    Label myLabel_2 = new Label();
                    myLabel_2.Name = "XingQing";
                    myLabel_2.Tag = dtGuaPaiXinXi.Rows[i]["GuaPaiID"].ToString();
                    myLabel_2.Size = new Size(88, 23);
                    myLabel_2.ForeColor = Color.White;
                    myLabel_2.Padding = new Padding(25, 4, 3, 3);
                    myLabel_2.Text = "地块详情";
                    myLabel_2.Cursor = Cursors.Hand;
                    myLabel_2.BackgroundImage = Properties.Resources._6_03;
                    myLabel_2.Location = new Point(X, Y);
                    ChuangJianTouMingKongJian.Controls.Add(myLabel_2);
                    if (geshu == 2)
                    {
                        X = 54;
                        Y += 25;
                    }
                    else
                    {
                        X += 100;
                    }
                    if (Convert.ToInt32(dtGuaPaiXinXi.Rows[i]["JiaoYiZhuangTaiID"]) != 1)
                    {
                        Label myLabel_3 = new Label();
                        myLabel_3.Name = "ChuJai";
                        myLabel_3.Tag = dtGuaPaiXinXi.Rows[i]["GuaPaiID"].ToString();
                        myLabel_3.Size = new Size(88, 23);
                        myLabel_3.ForeColor = Color.White;
                        myLabel_3.Padding = new Padding(25, 4, 3, 3);
                        myLabel_3.Text = "出价记录";
                        myLabel_3.Cursor = Cursors.Hand;
                        myLabel_3.BackgroundImage = Properties.Resources._6_03;
                        myLabel_3.Location = new Point(X, Y);
                        ChuangJianTouMingKongJian.Controls.Add(myLabel_3);
                        if (geshu == 3)
                        {
                            X = 54;
                            Y += 25;
                        }
                        else
                        {
                            X += 100;
                        }
                    }

                    if (Convert.ToInt32(dtGuaPaiXinXi.Rows[i]["JiaoYiZhuangTaiID"]) == 2)
                    {
                        Label myLabel_4 = new Label();
                        myLabel_4.Name = "ShenGou";
                        myLabel_4.Tag = dtGuaPaiXinXi.Rows[i]["GuaPaiID"].ToString();
                        myLabel_4.Size = new Size(88, 23);
                        myLabel_4.ForeColor = Color.White;
                        myLabel_4.Padding = new Padding(25, 4, 3, 3);
                        myLabel_4.Text = "我要申购";
                        myLabel_4.Cursor = Cursors.Hand;
                        myLabel_4.BackgroundImage = Properties.Resources._6_03;
                        myLabel_4.Location = new Point(X, Y);
                        ChuangJianTouMingKongJian.Controls.Add(myLabel_4);
                    }
                    foreach (Control control in ChuangJianTouMingKongJian.Controls)
                    {
                        switch (control.Name)
                        {
                            case "ShouCang":
                                control.Click += new EventHandler(btnClickShouCang);
                                break;
                            case "XingQing":
                                control.Click += new EventHandler(btnClickXingQing);
                                break;
                            case "ChuJai":
                                control.Click += new EventHandler(btnClickChuJai);
                                break;
                            case "ShenGou":
                                control.Click += new EventHandler(btnClickShenGou);
                                break;
                        }
                    }
                }
            }
        }

        //生成字体
        void pb_Paint(object sender, PaintEventArgs e)
        {
            Font myFont1 = new Font("KaiTi", 14);
            Font myFont2 = new Font("KaiTi", 10);
            Font myFont3 = new Font("KaiTi", 9);
            FontStyle myFontStyle = new FontStyle();
            myFontStyle |= FontStyle.Bold;
            Font myFont4 = new Font(myFont1, myFontStyle);
            Font myFont5 = new Font(myFont2, myFontStyle);
            Font myFont6 = new Font(myFont3, myFontStyle);
            Brush myBrush1 = new SolidBrush(Color.Black);
            Brush myBrush2 = new SolidBrush(Color.Brown);
            Brush myBrush3 = new SolidBrush(Color.White);
            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Center;
            Rectangle myRectangle = new Rectangle(22, 11, 249, 18);

            PictureBox HuoQuDeTouMingKongJian = sender as PictureBox;
            Graphics g = e.Graphics;


            if (TiaoJianChaXun != 4 && TiaoJianChaXun != 5 && TiaoJianChaXun != 6)
            {
                int GuaPaiID = Convert.ToInt32(HuoQuDeTouMingKongJian.Tag);
                DataTable dtHuiZhiTouMingKongJianXinXi = dtGuaPaiXinXi;
                foreach (DataRow dr in dtHuiZhiTouMingKongJianXinXi.Rows)
                {
                    if (Convert.ToInt32(dr["GuaPaiID"]) == GuaPaiID)
                    {
                        if (Convert.ToInt32(dr["JiaoYiZhuangTaiID"]) == 3)
                        {
                            g.DrawImage(Properties.Resources._116, 179, 112);
                        }
                        g.DrawString(dr["JiaoYiZhuangTaiMingCheng"].ToString().Trim(), myFont4, myBrush2, myRectangle, myStringFormat);
                        g.DrawString("挂牌编号 " + dr["GuaPaiBianHao"].ToString().Trim(), myFont5, myBrush3, 24, 39);
                        g.DrawString("地块名称:", myFont6, myBrush1, 24, 60);
                        g.DrawString(dr["DiKuaiMingCheng"].ToString().Trim(), myFont6, myBrush2, 86, 60);
                        g.DrawString("土地位置:", myFont6, myBrush1, 24, 80);
                        if (dr["TuDiWeiZhi"].ToString().Trim().Length < 14)
                        {
                            g.DrawString(dr["TuDiWeiZhi"].ToString().Trim(), myFont6, myBrush2, 86, 80);
                        }
                        else
                        {
                            g.DrawString(dr["TuDiWeiZhi"].ToString().Trim().Substring(0, 12) + " …", myFont6, myBrush2, 86, 80);
                        }
                        g.DrawString("起始价(增幅):", myFont6, myBrush1, 24, 100);
                        g.DrawString(dr["QiShiJia"].ToString().Trim() + "(" + dr["ZengFu"].ToString().Trim() + ")" + "万元", myFont6, myBrush2, 112, 100);
                        g.DrawString("挂牌起始时间:", myFont6, myBrush1, 24, 120);
                        g.DrawString(dr["GuaPaiQiShiShiJian"].ToString().Trim(), myFont6, myBrush2, 112, 120);
                        g.DrawString("挂牌截止时间:", myFont6, myBrush1, 24, 140);
                        g.DrawString(dr["GuaPaiJieZhiShiJian"].ToString().Trim(), myFont6, myBrush2, 112, 140);
                        g.DrawString("保证金截止时间:", myFont6, myBrush1, 24, 160);
                        g.DrawString(dr["BaoZhengJinDaoZhangJieZhiShiJian"].ToString().Trim(), myFont6, myBrush2, 124, 160);
                        if (Convert.ToInt32(dr["JiaoYiZhuangTaiID"]) == 2)
                        {
                            g.DrawString("保证金:", myFont6, myBrush1, 24, 180);
                            g.DrawString(dr["BaoZhengJinJinE"].ToString().Trim() + "万元", myFont6, myBrush2, 76, 180);
                        }
                        else
                        {
                            g.DrawString("预付款/保证金:", myFont6, myBrush1, 24, 180);
                            g.DrawString(dr["YuFuKuan"].ToString().Trim() + "万元" + "/" + dr["BaoZhengJinJinE"].ToString().Trim() + "万元", myFont6, myBrush2, 116, 180);
                        }
                    }
                }
            }
            else if (TiaoJianChaXun !=6)
            {
                int GongGaoLeiXingID = Convert.ToInt32(HuoQuDeTouMingKongJian.Tag);
                DataTable dtHuiZhiTouMingKongJianXinXi = dtGuaPaiXinXi;
                foreach (DataRow  dr in dtHuiZhiTouMingKongJianXinXi.Rows)
                {
                    if (Convert.ToInt32(dr["GongGaoLeiXingID"]) == 1)
                    {                       
                        g.DrawString("预公告", myFont4, myBrush2, 110, 10);
                        g.DrawString("公告编号 " + dr["GongGaoBianHao"].ToString().Trim(), myFont5, myBrush3, 24, 39);
                        g.DrawString("标题:", myFont5, myBrush1, 24, 60);
                        int ChangDu = dr["BiaoTi"].ToString().Trim().Length;
                        int ZiShu = 16;
                        int ShangCiZiShu = 0;
                        int X = 62;
                        int Y = 60;
                        while (ZiShu < ChangDu)
                        {
                            string BiaoTi = dr["BiaoTi"].ToString().Substring(ShangCiZiShu, ZiShu);
                            g.DrawString(BiaoTi, myFont5, myBrush2, X, Y);
                            if (X == 62)
                            {
                                ShangCiZiShu = 16;
                            }
                            else
                            {
                                ShangCiZiShu += 22;
                            }
                            ZiShu += 22;
                            X = 24;
                            Y += 20;
                        }
                        string BiaoTi1 = dr["BiaoTi"].ToString().Substring(ShangCiZiShu, ChangDu);
                        g.DrawString(BiaoTi1, myFont5, myBrush2, X, Y);
                        Y += 30;
                        g.DrawString("发布时间:", myFont5, myBrush1, 24, Y);
                        g.DrawString(dr["FaBuShiJian"].ToString().Trim(), myFont5, myBrush2, 116, Y);
                    }

                    if (Convert.ToInt32(dr["GongGaoLeiXingID"]) == 2)
                    {                       
                        g.DrawString("其他公告", myFont4, myBrush2, 110, 10);
                        g.DrawString("公告编号 " + dr["GongGaoBianHao"].ToString().Trim(), myFont5, myBrush3, 24, 39);
                        g.DrawString("标题:", myFont5, myBrush1, 24, 60);
                        int ChangDu = dr["BiaoTi"].ToString().Trim().Length;
                        int ZiShu = 16;
                        int ShangCiZiShu = 0;
                        int X = 62;
                        int Y = 60;
                        while (ZiShu < ChangDu)
                        {
                            string BiaoTi = dr["BiaoTi"].ToString().Substring(ShangCiZiShu, ZiShu);
                            g.DrawString(BiaoTi, myFont5, myBrush2, X, Y);
                            if (X == 62)
                            {
                                ShangCiZiShu = 16;
                            }
                            else
                            {
                                ShangCiZiShu += 22;
                            }
                            ZiShu += 22;
                            X = 24;
                            Y += 20;
                        }
                        string BiaoTi1 = dr["BiaoTi"].ToString().Substring(ShangCiZiShu, ChangDu);
                        g.DrawString(BiaoTi1, myFont5, myBrush2, X, Y);
                        Y += 30;
                        g.DrawString("发布时间:", myFont5, myBrush1, 24, Y);
                        g.DrawString(dr["FaBuShiJian"].ToString().Trim(), myFont5, myBrush2, 116, Y);
                    }
                }
            }
            else
            {
                int GuaPaiID = Convert.ToInt32(HuoQuDeTouMingKongJian.Tag);
                DataTable dtHuiZhiTouMingKongJianXinXi = dtGuaPaiXinXi;
                for (int i = (YeMa - 1) * MeiYeShuLiang; i < YeMa * MeiYeShuLiang && i < ZongTiaoShu; i++)
                {                   
                    if (Convert.ToInt32(dtGuaPaiXinXi.Rows[i]["GuaPaiID"]) == GuaPaiID)
                    {                      
                        g.DrawImage(Properties.Resources._116, 179, 112);
                        g.DrawString(dtGuaPaiXinXi.Rows[i]["JiaoYiZhuangTaiMingCheng"].ToString().Trim(), myFont4, myBrush2, myRectangle, myStringFormat);
                        g.DrawString("挂牌编号 " + dtGuaPaiXinXi.Rows[i]["GuaPaiBianHao"].ToString().Trim(), myFont5, myBrush3, 24, 39);
                        g.DrawString("地块名称:", myFont6, myBrush1, 24, 60);
                        g.DrawString(dtGuaPaiXinXi.Rows[i]["DiKuaiMingCheng"].ToString().Trim(), myFont6, myBrush2, 86, 60);
                        g.DrawString("土地位置:", myFont6, myBrush1, 24, 80);
                        if (dtGuaPaiXinXi.Rows[i]["TuDiWeiZhi"].ToString().Trim().Length < 14)
                        {
                            g.DrawString(dtGuaPaiXinXi.Rows[i]["TuDiWeiZhi"].ToString().Trim(), myFont6, myBrush2, 86, 80);
                        }
                        else
                        {
                            g.DrawString(dtGuaPaiXinXi.Rows[i]["TuDiWeiZhi"].ToString().Trim().Substring(0, 12) + " …", myFont6, myBrush2, 86, 80);
                        }
                        g.DrawString("起始价(增幅):", myFont6, myBrush1, 24, 100);
                        g.DrawString(dtGuaPaiXinXi.Rows[i]["QiShiJia"].ToString().Trim() + "(" + dtGuaPaiXinXi.Rows[i]["ZengFu"].ToString().Trim() + ")" + "万元", myFont6, myBrush2, 112, 100);
                        g.DrawString("挂牌起始时间:", myFont6, myBrush1, 24, 120);
                        g.DrawString(dtGuaPaiXinXi.Rows[i]["GuaPaiQiShiShiJian"].ToString().Trim(), myFont6, myBrush2, 112, 120);
                        g.DrawString("挂牌截止时间:", myFont6, myBrush1, 24, 140);
                        g.DrawString(dtGuaPaiXinXi.Rows[i]["GuaPaiJieZhiShiJian"].ToString().Trim(), myFont6, myBrush2, 112, 140);
                        g.DrawString("保证金截止时间:", myFont6, myBrush1, 24, 160);
                        g.DrawString(dtGuaPaiXinXi.Rows[i]["BaoZhengJinDaoZhangJieZhiShiJian"].ToString().Trim(), myFont6, myBrush2, 124, 160);
                        if (Convert.ToInt32(dtGuaPaiXinXi.Rows[i]["JiaoYiZhuangTaiID"]) == 2)
                        {
                            g.DrawString("保证金:", myFont6, myBrush1, 24, 180);
                            g.DrawString(dtGuaPaiXinXi.Rows[i]["BaoZhengJinJinE"].ToString().Trim() + "万元", myFont6, myBrush2, 76, 180);
                        }
                        else
                        {
                            g.DrawString("预付款/保证金:", myFont6, myBrush1, 24, 180);
                            g.DrawString(dtGuaPaiXinXi.Rows[i]["YuFuKuan"].ToString().Trim() + "万元" + "/" + dtGuaPaiXinXi.Rows[i]["BaoZhengJinJinE"].ToString().Trim() + "万元", myFont6, myBrush2, 116, 180);
                        }
                    }
                }
            }
        }

        //点击地块详情
        public void btnClickXingQing(object sender, EventArgs e)
        {
            Label DangQianKongJian = sender as Label;
            DangQianGuaPaiID = Convert.ToInt32(DangQianKongJian.Tag);
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_DiKuaiXiangQing myFRM_DiKuaiXiangQing = new FRM_DiKuaiXiangQing(myFRM_JiaoYiDaTing);
            myFRM_DiKuaiXiangQing.TopLevel = false;
            myFRM_DiKuaiXiangQing.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_DiKuaiXiangQing.Show();
        }

        //点击我要申购
        public void btnClickShenGou(object sender, EventArgs e)
        {
            if (FRM_ZhuChuangTi.DengLuFou == true)
            {
                Label DangQianKongJian = sender as Label;
                DangQianGuaPaiID = Convert.ToInt32(DangQianKongJian.Tag);
                myFRM_JiaoYiDaTing.panel1.Controls.Clear();
                FRM_ShenGuoGuiZe myFRM_ShenGuoGuiZe = new FRM_ShenGuoGuiZe(myFRM_JiaoYiDaTing);
                myFRM_ShenGuoGuiZe.TopLevel = false;
                myFRM_ShenGuoGuiZe.Parent = myFRM_JiaoYiDaTing.panel1;
                myFRM_ShenGuoGuiZe.Show();
            }
            else
            {
                MessageBox.Show("先登录方可申购");
            }
        }

        //点击出价记录
        public void btnClickChuJai(object sender, EventArgs e)
        {           
                ChuJiaJiLuDeShangJi = 1;
                Label DangQianKongJian = sender as Label;
                DangQianGuaPaiID = Convert.ToInt32(DangQianKongJian.Tag);
                myFRM_JiaoYiDaTing.panel1.Controls.Clear();
                FRM_ChuJiaJiLu myFRM_ChuJiaJiLu = new FRM_ChuJiaJiLu(myFRM_JiaoYiDaTing);
                myFRM_ChuJiaJiLu.TopLevel = false;
                myFRM_ChuJiaJiLu.Parent = myFRM_JiaoYiDaTing.panel1;
                myFRM_ChuJiaJiLu.Show();          
        }

        //点击进入收藏
        public void btnClickShouCang(object sender, EventArgs e)
        {
            bool ShouCangShiFou = false;
            int KeHuID = Login.KeHuID;
            Label DangQianKongJian = sender as Label;
            DangQianGuaPaiID = Convert.ToInt32(DangQianKongJian.Tag);
            DataTable dt = myBLL.btnClickShouCang_ShiFouShouCang(KeHuID).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i]["GuaPaiID"]) == DangQianGuaPaiID)
                {
                    ShouCangShiFou = true;
                }
            }

            if (DangQianGuaPaiID != 0 && KeHuID != 0)
            {
                if (ShouCangShiFou == false)
                {
                    myBLL.FRM_JIaoYiDaTingZhuYe_InsertShouCangBiao(DangQianGuaPaiID, KeHuID);
                    MessageBox.Show("收藏成功");
                }
                else
                {
                    MessageBox.Show("已经收藏");
                }
            }
            else
            {
                if (KeHuID == 0)
                {
                    MessageBox.Show("请先登录");
                }
                else
                {
                    MessageBox.Show("收藏失败");
                }
            }
        }

        //点击公告详情
        public void btnClickGongGaoXiangQing(object sender, EventArgs e)
        {
            Label DangQianKongJian = sender as Label;
            DangQianGuaPaiID = Convert.ToInt32(DangQianKongJian.Tag);
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_DiKuaiXiangQing myFRM_DiKuaiXiangQing = new FRM_DiKuaiXiangQing(myFRM_JiaoYiDaTing);
            myFRM_DiKuaiXiangQing.TopLevel = false;
            myFRM_DiKuaiXiangQing.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_DiKuaiXiangQing.Show();
        }

        //分页部分
        private void tsbShangYiYe_Click(object sender, EventArgs e)
        {
            if (YeMa > 1)
            {
                YeMa -= 1;
                FRM_JIaoYiDaTingZhuYe_Load(null, null);                
            }
            else
            {
                MessageBox.Show("已到第一页");
            }
        }

        private void tsbXiaYiYe_Click(object sender, EventArgs e)
        {
            if (YeMa < ZongYeShu)
            {
                YeMa += 1;
                FRM_JIaoYiDaTingZhuYe_Load(null, null);                
            }
            else
            {
                MessageBox.Show("已到最后一页");
            }
        }

        private void tsbShouYe_Click(object sender, EventArgs e)
        {
            if (YeMa != 1)
            {
                YeMa = 1;
                FRM_JIaoYiDaTingZhuYe_Load(null, null);               
            }
            else
            {
                MessageBox.Show("已到首页");
            }
        }

        private void tsbWeiYe_Click(object sender, EventArgs e)
        {
            if (YeMa != ZongYeShu)
            {
                YeMa = ZongYeShu;
                FRM_JIaoYiDaTingZhuYe_Load(null, null);                
            }
            else
            {
                MessageBox.Show("已到尾页");
            }
        }

        private void tsbZhuanDao_Click(object sender, EventArgs e)
        {
            if (tstDiJiYe.Text != "" && Convert.ToInt32(tstDiJiYe.Text) <= ZongYeShu)
            {
                YeMa = Convert.ToInt32(tstDiJiYe.Text);
                FRM_JIaoYiDaTingZhuYe_Load(null, null);               
                tstDiJiYe.Text = null;
            }
            else
            {
                MessageBox.Show("请输入(1 ~ " + ZongYeShu + ")" + "之间的数字");
            }
        }         
    }
}
