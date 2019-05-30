using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;

namespace BLL拍卖系统
{
    [ServiceContract]
    class FRM_XinZengShuJu
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        [OperationContract]
        public DataSet XinZengShuJuJiaoYiZhuangTai()
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "XinZengShuJuJiaoYiZhuangTai";
            DataTable dt = myDAL.QueryDataTable("FRM_XinZengShuJu", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet XinZengShuJuXingZhengQu()
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "XinZengShuJuXingZhengQu";
            DataTable dt = myDAL.QueryDataTable("FRM_XinZengShuJu", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet XinZengShuJuJiaoYiLeiBie()
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "XinZengShuJuJiaoYiLeiBie";
            DataTable dt = myDAL.QueryDataTable("FRM_XinZengShuJu", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet XinZengShuJuShenQingTiSi()
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "XinZengShuJuShenQingTiSi";
            DataTable dt = myDAL.QueryDataTable("FRM_XinZengShuJu", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet XinZengShuJuGongGaoLeiXing()
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "XinZengShuJuGongGaoLeiXing";
            DataTable dt = myDAL.QueryDataTable("FRM_XinZengShuJu", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet XinZengShuJuKeHuMingCheng()
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "XinZengShuJuKeHuMingCheng";
            DataTable dt = myDAL.QueryDataTable("FRM_XinZengShuJu", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public int XinZengGuaPaiShuJu(
         string GuaPaiBianHao, string JiaoYiFangShi, int JiaoYiLeiBieID, int JiaoYiZhuangTaiID, DateTime GuaPaiQiShiShiJian, DateTime GuaPaiJieZhiShiJian,
         DateTime BaoZhengJinDaoZhangJieZhiShiJian, string DiKuaiMingCheng, string TuDiWeiZhi, decimal QiShiJia, decimal ZengFu, string YuFuKuan,
         decimal BaoZhengJinJinE, string TuDiQuanShuDanWei, int XingZhengQuID, string ShiYongQuanMianJi, string JianZhuMianJi, string GuiHuaYongTu, string GuiHuaZhiBiao,
         string ChuRangNianXian, string DiKuaiBeiZhu, string RongJiLv, string JianZhuMiDu, string LvHuaLv, string JianZhuXianGao,
         string TouZiQiangDu, string XianZhuangTuDiTiaoJian, bool ShiFouYouBaoZhangXingZhuFang, decimal QiShiBaoZhangXingZhuFangBiLi, decimal ZuiGaoXianJia,
         decimal BiLiZengFu, bool ShiFouYouFuJiaZiGeShenHeTiaoJian, string GongGaoBeiZhu, int ShenQingTiShiID
          ,int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar),
                     new SqlParameter("@GuaPaiBianHao",SqlDbType.NChar),
                     new SqlParameter("@JiaoYiFangShi",SqlDbType.NChar),
                     new SqlParameter("@JiaoYiLeiBieID",SqlDbType.Int),
                     new SqlParameter("@JiaoYiZhuangTaiID",SqlDbType.Int),
                     new SqlParameter("@GuaPaiQiShiShiJian",SqlDbType.DateTime),
                     new SqlParameter("@GuaPaiJieZhiShiJian",SqlDbType.DateTime),
                     new SqlParameter("@BaoZhengJinDaoZhangJieZhiShiJian",SqlDbType.DateTime),
                     new SqlParameter("@DiKuaiMingCheng",SqlDbType.NChar),
                     new SqlParameter("@TuDiWeiZhi",SqlDbType.NChar),
                     new SqlParameter("@QiShiJia",SqlDbType.Decimal),
                     new SqlParameter("@ZengFu",SqlDbType.Decimal),
                     new SqlParameter("@YuFuKuan",SqlDbType.NChar),
                     new SqlParameter("@BaoZhengJinJinE",SqlDbType.Decimal),
                     new SqlParameter("@TuDiQuanShuDanWei",SqlDbType.NChar),
                     new SqlParameter("@XingZhengQuID",SqlDbType.Int),
                     new SqlParameter("@ShiYongQuanMianJi",SqlDbType.NChar),
                     new SqlParameter("@JianZhuMianJi",SqlDbType.NChar),
                     new SqlParameter("@GuiHuaYongTu",SqlDbType.NChar),
                     new SqlParameter("@GuiHuaZhiBiao",SqlDbType.NChar),
                     new SqlParameter("@ChuRangNianXian",SqlDbType.NChar),
                     new SqlParameter("@DiKuaiBeiZhu",SqlDbType.NChar),
                     new SqlParameter("@RongJiLv",SqlDbType.NChar),
                     new SqlParameter("@JianZhuMiDu",SqlDbType.NChar),
                     new SqlParameter("@LvHuaLv",SqlDbType.NChar),
                     new SqlParameter("@JianZhuXianGao",SqlDbType.NChar),
                     new SqlParameter("@TouZiQiangDu",SqlDbType.NChar),
                     new SqlParameter("@XianZhuangTuDiTiaoJian",SqlDbType.NChar),
                     new SqlParameter("@ShiFouYouBaoZhangXingZhuFang",SqlDbType.Bit),
                     new SqlParameter("@QiShiBaoZhangXingZhuFangBiLi",SqlDbType.Decimal),
                     new SqlParameter("@ZuiGaoXianJia",SqlDbType.Decimal),
                     new SqlParameter("@BiLiZengFu",SqlDbType.Decimal),
                     new SqlParameter("@ShiFouYouFuJiaZiGeShenHeTiaoJian",SqlDbType.Bit),
                     new SqlParameter("@GongGaoBeiZhu",SqlDbType.NChar),
                     new SqlParameter("@ShenQingTiShiID",SqlDbType.Int),
                     new SqlParameter("@KeHuID",SqlDbType.Int)
        };
            mySqlParameter[0].Value = "XinZengGuaPaiShuJu";
            mySqlParameter[1].Value = GuaPaiBianHao;
            mySqlParameter[2].Value = JiaoYiFangShi;
            mySqlParameter[3].Value = JiaoYiLeiBieID;
            mySqlParameter[4].Value = JiaoYiZhuangTaiID;
            mySqlParameter[5].Value = GuaPaiQiShiShiJian;
            mySqlParameter[6].Value = GuaPaiJieZhiShiJian;
            mySqlParameter[7].Value = BaoZhengJinDaoZhangJieZhiShiJian;
            mySqlParameter[8].Value = DiKuaiMingCheng;
            mySqlParameter[9].Value = TuDiWeiZhi;
            mySqlParameter[10].Value = QiShiJia;
            mySqlParameter[11].Value = ZengFu;
            mySqlParameter[12].Value = YuFuKuan;
            mySqlParameter[13].Value = BaoZhengJinJinE;
            mySqlParameter[14].Value = TuDiQuanShuDanWei;
            mySqlParameter[15].Value = XingZhengQuID;
            mySqlParameter[16].Value = ShiYongQuanMianJi;
            mySqlParameter[17].Value = JianZhuMianJi;
            mySqlParameter[18].Value = GuiHuaYongTu;
            mySqlParameter[19].Value = GuiHuaZhiBiao;
            mySqlParameter[20].Value = ChuRangNianXian;
            mySqlParameter[21].Value = DiKuaiBeiZhu;
            mySqlParameter[22].Value = RongJiLv;
            mySqlParameter[23].Value = JianZhuMiDu;
            mySqlParameter[24].Value = LvHuaLv;
            mySqlParameter[25].Value = JianZhuXianGao;
            mySqlParameter[26].Value = TouZiQiangDu;
            mySqlParameter[27].Value = XianZhuangTuDiTiaoJian;
            mySqlParameter[28].Value = ShiFouYouBaoZhangXingZhuFang;
            mySqlParameter[29].Value = QiShiBaoZhangXingZhuFangBiLi;
            mySqlParameter[30].Value = ZuiGaoXianJia;
            mySqlParameter[31].Value = BiLiZengFu;
            mySqlParameter[32].Value = ShiFouYouFuJiaZiGeShenHeTiaoJian;
            mySqlParameter[33].Value = GongGaoBeiZhu;
            mySqlParameter[34].Value = ShenQingTiShiID;
            mySqlParameter[35].Value = KeHuID;
            int dt = myDAL.UpdateData("FRM_XinZengShuJu", mySqlParameter);
            return dt;
        }

        [OperationContract]
        public int XinZengGongGaoBiao(
        string GongGaoBianHao, string BiaoTi, DateTime FaBuShiJian ,int GongGaoLeiXingID
            )
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar),
                     new SqlParameter("@GongGaoBianHao",SqlDbType.NChar),
                     new SqlParameter("@BiaoTi",SqlDbType.NChar),
                     new SqlParameter("@FaBuShiJian",SqlDbType.DateTime),
                     new SqlParameter("@GongGaoLeiXingID",SqlDbType.Int)
                                             };
            mySqlParameter[0].Value = "XinZengGongGaoBiao";
            mySqlParameter[1].Value = GongGaoBianHao;
            mySqlParameter[2].Value = BiaoTi;
            mySqlParameter[3].Value = FaBuShiJian;
            mySqlParameter[4].Value = GongGaoLeiXingID;
            int dt = myDAL.UpdateData("FRM_XinZengShuJu", mySqlParameter);
            return dt;
        }

        [OperationContract]
        public int XinZengKeHuBiao(
        int KeHuLeiXingID, string KeHuMingCheng, string ZhengJianHao, string LianXiDiZhi, string LianXiRen, string FaRenDaiBiao,
        string YouXiang, string YouZhengBianMa, string LianXiDianHua, string ShuZiZhengShuMiMa, bool ZhengShuShiFouYouXiao
            )
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar),
                     new SqlParameter("@KeHuLeiXingID",SqlDbType.Int),
                     new SqlParameter("@KeHuMingCheng",SqlDbType.NChar),
                     new SqlParameter("@ZhengJianHao",SqlDbType.NChar),
                     new SqlParameter("@LianXiDiZhi",SqlDbType.NChar),
                     new SqlParameter("@LianXiRen",SqlDbType.NChar),
                     new SqlParameter("@FaRenDaiBiao",SqlDbType.NChar),
                     new SqlParameter("@YouXiang",SqlDbType.NChar),
                     new SqlParameter("@YouZhengBianMa",SqlDbType.NChar),
                     new SqlParameter("@LianXiDianHua",SqlDbType.NChar),
                     new SqlParameter("@ShuZiZhengShuMiMa",SqlDbType.NChar),
                     new SqlParameter("@ZhengShuShiFouYouXiao",SqlDbType.Bit),
                                             };
            mySqlParameter[0].Value = "XinZengKeHuBiao";
            mySqlParameter[1].Value = KeHuLeiXingID;
            mySqlParameter[2].Value = KeHuMingCheng;
            mySqlParameter[3].Value = ZhengJianHao;
            mySqlParameter[4].Value = LianXiDiZhi;
            mySqlParameter[5].Value = LianXiRen;
            mySqlParameter[6].Value = FaRenDaiBiao;
            mySqlParameter[7].Value = YouXiang;
            mySqlParameter[8].Value = YouZhengBianMa;
            mySqlParameter[9].Value = LianXiDianHua;
            mySqlParameter[10].Value = ShuZiZhengShuMiMa;
            mySqlParameter[11].Value = ZhengShuShiFouYouXiao;
            int dt = myDAL.UpdateData("FRM_XinZengShuJu", mySqlParameter);
            return dt;
        }

        [OperationContract]
        public DataSet ChaXunZuiDaGuaPaiDanShu()
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "ChaXunZuiDaGuaPaiDanShu";
            DataTable dt = myDAL.QueryDataTable("FRM_XinZengShuJu", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet ChaXunZuiDaGongGaoDanShu()
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "ChaXunZuiDaGongGaoDanShu";
            DataTable dt = myDAL.QueryDataTable("FRM_XinZengShuJu", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet XinZengShuJuKeHuLeiXing()
        {
            SqlParameter[] mySqlParameter = {
                     new SqlParameter("@type",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "XinZengShuJuKeHuLeiXing";
            DataTable dt = myDAL.QueryDataTable("FRM_XinZengShuJu", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
