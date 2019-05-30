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
    public partial class FRM_WoDeShouCang : Form
    {
        FRM_JiaoYiDaTing myFRM_JiaoYiDaTing;
        public FRM_WoDeShouCang(FRM_JiaoYiDaTing FRM_JiaoYiDaTing)
        {
            InitializeComponent();
            myFRM_JiaoYiDaTing = FRM_JiaoYiDaTing;
        }
        BLLPaiMaiXiTong.FRM_WoDeShouCang.FRM_WoDeShouCangClient myBLL = new BLLPaiMaiXiTong.FRM_WoDeShouCang.FRM_WoDeShouCangClient();

        int YeMa = 1;
        int MeiYeShuLiang = 6;
        int ZongTiaoShu;
        int ZongYeShu;
        DataTable dtShouCangXinXi;
        public static int DangQianGuaPaiID;

        //Load事件
        private void FRM_WoDeShouCang_Load(object sender, EventArgs e)
        {
            int KeHuID = Login.KeHuID;
            dtShouCangXinXi = myBLL.FRM_WoDeShouCang_FenYe(YeMa, MeiYeShuLiang, KeHuID).Tables[0];
            DataTable dtZongShu = myBLL.FRM_WoDeShouCang_FenYeZongShu(KeHuID).Tables[0];
            ZongTiaoShu = Convert.ToInt32(dtZongShu.Rows[0]["ZongShu"]);
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

        //创建控件
        private void ChuangJianKongJian()
        {
            flpGuaPaiXinXi.Controls.Clear();
            foreach (DataRow dr in dtShouCangXinXi.Rows)
            {
                PictureBox ChuangJianTouMingKongJian = new PictureBox();
                ChuangJianTouMingKongJian.Tag = dr["GuaPaiID"].ToString();
                ChuangJianTouMingKongJian.Size = new Size(271, 259);
                ChuangJianTouMingKongJian.BackColor = Color.Transparent;
                ChuangJianTouMingKongJian.Paint += new PaintEventHandler(pb_Paint);
                flpGuaPaiXinXi.Controls.Add(ChuangJianTouMingKongJian);

                int X = 54;
                int Y = 198;
                int geshu = 0;

                geshu += 1;
                Label myLabel_1 = new Label();
                myLabel_1.Name = "myLabel1";
                myLabel_1.Tag = dr["GuaPaiID"].ToString();
                myLabel_1.Size = new Size(88, 23);
                myLabel_1.ForeColor = Color.White;
                myLabel_1.Padding = new Padding(25, 4, 3, 3);
                myLabel_1.Text = "移除收藏";
                myLabel_1.Cursor = Cursors.Hand;
                myLabel_1.BackgroundImage = Properties.Resources._6_03;
                myLabel_1.Location = new Point(X, Y);
                ChuangJianTouMingKongJian.Controls.Add(myLabel_1);
                X += 100;

                geshu += 1;
                Label myLabel_2 = new Label();
                myLabel_2.Name = "myLabel2";
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
                    myLabel_3.Name = "myLabel3";
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
                    myLabel_4.Name = "myLabel4";
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
                        case "myLabel1":
                            control.Click += new EventHandler(btnClickShouCang);
                            break;
                        case "myLabel2":
                            control.Click += new EventHandler(btnClickXingQing);
                            break;
                        case "myLabel3":
                            control.Click += new EventHandler(btnClickChuJai);
                            break;
                        case "myLabel4":
                            control.Click += new EventHandler(btnClickShenGou);
                            break;
                    }
                }
            }
        }

        //画出字体
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
            int GuaPaiID = Convert.ToInt32(HuoQuDeTouMingKongJian.Tag);
            DataTable dtHuiZhiTouMingKongJianXinXi = dtShouCangXinXi;
            foreach (DataRow dr in dtHuiZhiTouMingKongJianXinXi.Rows)
            {
                if (Convert.ToInt32(dr["GuaPaiID"]) == GuaPaiID)
                {
                    g.DrawString(dr["JiaoYiZhuangTaiMingCheng"].ToString().Trim(), myFont4, myBrush2, myRectangle, myStringFormat);
                    g.DrawString("挂牌编号 " + dr["GuaPaiBianHao"].ToString().Trim(), myFont5, myBrush3, 24, 39);
                    g.DrawString("地块详情:", myFont6, myBrush1, 24, 60);
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
     
        //点击地块详情
        public void btnClickXingQing(object sender, EventArgs e)
        {
            Label DangQianKongJian = sender as Label;
            string DangQianGuaPaiID = DangQianKongJian.Tag.ToString();
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_DiKuaiXiangQing myFRM_DiKuaiXiangQing = new FRM_DiKuaiXiangQing(myFRM_JiaoYiDaTing);
            myFRM_DiKuaiXiangQing.TopLevel = false;
            myFRM_DiKuaiXiangQing.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_DiKuaiXiangQing.Show();
        }
        
        //点击我要申购
        public void btnClickShenGou(object sender, EventArgs e)
        {
            Label DangQianKongJian = sender as Label;
            DangQianGuaPaiID = Convert.ToInt32(DangQianKongJian.Tag);
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_ShenGuoGuiZe myFRM_ShenGuoGuiZe = new FRM_ShenGuoGuiZe(myFRM_JiaoYiDaTing);
            myFRM_ShenGuoGuiZe.TopLevel = false;
            myFRM_ShenGuoGuiZe.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_ShenGuoGuiZe.Show();
        }
       
        //点击出价记录
        public void btnClickChuJai(object sender, EventArgs e)
        {
            FRM_JIaoYiDaTingZhuYe.ChuJiaJiLuDeShangJi = 3;
            Label DangQianKongJian = sender as Label;
            string DangQianGuaPaiID = DangQianKongJian.Tag.ToString();
            myFRM_JiaoYiDaTing.panel1.Controls.Clear();
            FRM_ChuJiaJiLu myFRM_ChuJiaJiLu = new FRM_ChuJiaJiLu(myFRM_JiaoYiDaTing);
            myFRM_ChuJiaJiLu.TopLevel = false;
            myFRM_ChuJiaJiLu.Parent = myFRM_JiaoYiDaTing.panel1;
            myFRM_ChuJiaJiLu.Show();
        }

        //移除收藏
        public void btnClickShouCang(object sender, EventArgs e)
        {
            //if (MessageBox.Show("是否移除本收藏?", "提示", MessageBoxButtons.YesNo)
            //   == System.Windows.Forms.DialogResult.Yes)
            //{
            //    int KeHuID = Login.KeHuID;
            //    Label DangQianKongJian = sender as Label;
            //    int DangQianGuaPaiID = Convert.ToInt32(DangQianKongJian.Tag);
            //    int i = myBLL.btnClickShouCang_YiChuShouCang(DangQianGuaPaiID, KeHuID);
            //    if (i > 0)
            //    {
            //        FRM_WoDeShouCang_Load(null, null);
            //    }
            //    else
            //    {
            //        MessageBox.Show("移除收藏失败");
            //    }
            //}

            if (MessageBox.Show("是否移除本收藏?", "提示", MessageBoxButtons.YesNo)
              == System.Windows.Forms.DialogResult.Yes)
            {
                Label DangQianKongJian = sender as Label;
                int DangQianGuaPaiID = Convert.ToInt32(DangQianKongJian.Tag);
                int i = myBLL.btnClickShouCang_YiChuShouCang(DangQianGuaPaiID);
                if (i > 0)
                {
                    MessageBox.Show("成功");
                    FRM_WoDeShouCang_Load(null, null);
                }
                else
                {
                    MessageBox.Show("移除收藏失败");
                }
            }
        }

        //分页部分
        private void tsbShouYe_Click(object sender, EventArgs e)
        {           
            if (YeMa != ZongYeShu)
            {
                YeMa = 1;
                FRM_WoDeShouCang_Load(null, null);
            }
            else
            {
                MessageBox.Show("已到尾页");
            }
        }

        private void tsbWeiYe_Click(object sender, EventArgs e)
        {           
            if (YeMa != ZongYeShu)
            {
                YeMa = ZongYeShu;
                FRM_WoDeShouCang_Load(null, null);
            }
            else
            {
                MessageBox.Show("已到尾页");
            }
        }

        private void tsbShangYiYe_Click(object sender, EventArgs e)
        {
            if (YeMa > 1)
            {
                YeMa -= 1;
                FRM_WoDeShouCang_Load(null, null);
            }
            else
            {
                MessageBox.Show("第一页了");
            }
        }

        private void tsbXiaYiYe_Click(object sender, EventArgs e)
        {
            if (YeMa < ZongYeShu)
            {
                YeMa += 1;
                FRM_WoDeShouCang_Load(null, null);
            }
            else
            {
                MessageBox.Show("最后一页了");
            }
        }

        private void tsbZhuanDao_Click(object sender, EventArgs e)
        {
            if (tstDiJiYe.Text != "" && Convert.ToInt32(tstDiJiYe.Text) <= ZongYeShu)
            {
                YeMa = Convert.ToInt32(tstDiJiYe.Text);
                FRM_WoDeShouCang_Load(null, null);
                tstDiJiYe.Text = null;
            }
            else
            {
                MessageBox.Show("轻输入(1 ~ " + ZongYeShu + ")" + "之间的数字");
            }
        }
    }
}