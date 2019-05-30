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
    class FRM_JIaoYiDaTingZhuYe
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        //QuanBuShuJu
        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Load_FenYe(int YeMa, int MeiYeShuLiang ,int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Load_FenYe";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            mySqlParameter[3].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    
        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Load_FenYeZongShu(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Load_FenYeZongShu";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //XingZhengQu
        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Load_XingZhengQu()
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Load_XingZhengQu";
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //GuaPaiGongGao
        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Select_GuaPaiGongGao(int YeMa, int MeiYeShuLiang, int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Select_GuaPaiGongGao";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            mySqlParameter[3].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Select_GuaPaiGongGao_FenYeZongShu(int JiaoYiZhuangTaiID,int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@JiaoYiZhuangTaiID",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Select_GuaPaiGongGao_FenYeZongShu";
            mySqlParameter[1].Value = JiaoYiZhuangTaiID;
            mySqlParameter[2].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;           
        }

        //ZhengZaiGuaPai
        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Select_ZhengZaiGuaPai(int YeMa, int MeiYeShuLiang ,int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Select_ZhengZaiGuaPai";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            mySqlParameter[3].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Select_ZhengZaiGuaPai_FenYeZongShu(int JiaoYiZhuangTaiID, int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@JiaoYiZhuangTaiID",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Select_ZhengZaiGuaPai_FenYeZongShu";
            mySqlParameter[1].Value = JiaoYiZhuangTaiID;
            mySqlParameter[2].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //JieGuoGongShi
        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Select_JieGuoGongShi(int YeMa, int MeiYeShuLiang, int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Select_JieGuoGongShi";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            mySqlParameter[3].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Select_JieGuoGongShi_FenYeZongShu(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int),

            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Select_JieGuoGongShi_FenYeZongShu";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //YuGongGao
        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Select_YuGongGao(int YeMa, int MeiYeShuLiang)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),                
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Select_YuGongGao";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;            
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Select_YuGongGao_FenYeZongShu(int GongGaoLeiXingID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@GongGaoLeiXingID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Select_YuGongGao_FenYeZongShu";
            mySqlParameter[1].Value = GongGaoLeiXingID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //QiTaGongGao
        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Select_QiTaGongGao(int YeMa, int MeiYeShuLiang)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Select_QiTaGongGao";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_Select_QiTaGongGao_FenYeZongShu(int GongGaoLeiXingID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@GongGaoLeiXingID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_Select_QiTaGongGao_FenYeZongShu";
            mySqlParameter[1].Value = GongGaoLeiXingID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //GaoJiSouSuo
        [OperationContract]
        public DataSet btnSouSuo_Click_SelectDongTaiTiaoJian(string GuaPaiBianHao ,DateTime GuaPaiQiShiShiJian,
           DateTime GuaPaiJieZhiShiJian, string TuDiWeiZhi, string KeHuMingCheng)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter ("@type",SqlDbType.NChar),
                new SqlParameter ("@HuoQuGuaPaiBianHao",SqlDbType.NChar),
                new SqlParameter ("@HuoQuGuaPaiQiShiShiJian",SqlDbType.DateTime),
                new SqlParameter ("@HuoQuGuaPaiJieZhiShiJian",SqlDbType.DateTime),
                new SqlParameter ("@HuoQuTuDiWeiZhi",SqlDbType.NChar),
                new SqlParameter ("@HuoQuKeHuMingCheng",SqlDbType.NChar),
                //new SqlParameter ("@HuoQuXingZhengQuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "btnSouSuo_Click_SelectDongTaiTiaoJian";
            mySqlParameter[1].Value = GuaPaiBianHao;
            mySqlParameter[2].Value = GuaPaiQiShiShiJian;
            mySqlParameter[3].Value = GuaPaiJieZhiShiJian;
            mySqlParameter[4].Value = TuDiWeiZhi;
            mySqlParameter[5].Value = KeHuMingCheng;
            //mySqlParameter[6].Value = XingZhengQuID;          
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnSouSuo_Click_SelectDongTaiTiaoJian_ZongShu()
        {
            SqlParameter[] mySqlParameter = {
                 new SqlParameter("@type",SqlDbType.NChar),
                // new SqlParameter("@DongTaiTiaoJian",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "btnSouSuo_Click_SelectDongTaiTiaoJian_ZongShu";
            //mySqlParameter[1].Value = DongTaiTiaoJian;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //AnJiaoYiLeiBieChaXun
        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_JiaoYiZhuangTaiChaXun(int YeMa, int MeiYeShuLiang, int JiaoYiLeiBieID,int KeHuID)
        {
            SqlParameter[] mySqlParameter =
            {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
                new SqlParameter("@JiaoYiLeiBieID",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_JiaoYiZhuangTaiChaXun";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            mySqlParameter[3].Value = JiaoYiLeiBieID;
            mySqlParameter[4].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_JIaoYiDaTingZhuYe_JiaoYiZhuangTaiChaXunZongShu(int JiaoYiLeiBieID,int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@JiaoYiLeiBieID",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_JiaoYiZhuangTaiChaXunZongShu";
            mySqlParameter[1].Value = JiaoYiLeiBieID;
            mySqlParameter[2].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //WoDeShouCang
        [OperationContract]
        public DataSet btnClickShouCang_ShiFouShouCang(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "btnClickShouCang_ShiFouShouCang";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public int FRM_JIaoYiDaTingZhuYe_InsertShouCangBiao(int GuaPaiID, int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@GuaPaiID",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_JIaoYiDaTingZhuYe_InsertShouCangBiao";
            mySqlParameter[1].Value = GuaPaiID;
            mySqlParameter[2].Value = KeHuID;
            int dt = myDAL.UpdateData("FRM_JIaoYiDaTingZhuYe", mySqlParameter);
            return dt;
        }
    }
}
