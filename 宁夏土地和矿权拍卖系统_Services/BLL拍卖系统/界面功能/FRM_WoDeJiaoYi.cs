using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ServiceModel;
using System.Data.SqlClient;

namespace BLL拍卖系统
{
    [ServiceContract]
    class FRM_WoDeJiaoYi
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
         //JiSuanQuanBuFeYe
        [OperationContract]
        public DataSet FRM_WoDeJiaoYi_Load_FenYe(int YeMa, int MeiYeShuLiang, int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_WoDeJiaoYi_Load_FenYe";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            mySqlParameter[3].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeJiaoYi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
       
        [OperationContract]
        public DataSet FRM_WoDeJiaoYi_Load_FenYeZongShu(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int),
            };
            mySqlParameter[0].Value = "FRM_WoDeJiaoYi_Load_FenYeZongShu";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeJiaoYi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //ZhengZaiGuaPai
        [OperationContract]
        public DataSet FRM_WoDeJiaoYi_Load_FenYeZhengZaiGuaPai(int YeMa, int MeiYeShuLiang, int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_WoDeJiaoYi_Load_FenYeZhengZaiGuaPai";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            mySqlParameter[3].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeJiaoYi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        
        [OperationContract]
        public DataSet FRM_WoDeJiaoYi_Load_FenYeZongShuZhengZaiGuaPai(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int),
            };
            mySqlParameter[0].Value = "FRM_WoDeJiaoYi_Load_FenYeZongShuZhengZaiGuaPai";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeJiaoYi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //GuaPaiGongShi
        [OperationContract]
        public DataSet FRM_WoDeJiaoYi_Load_FenYeGuaPaiGongShi(int YeMa, int MeiYeShuLiang, int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_WoDeJiaoYi_Load_FenYeGuaPaiGongShi";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            mySqlParameter[3].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeJiaoYi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_WoDeJiaoYi_Load_FenYeZongShuGuaPaiGongShi(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int),
            };
            mySqlParameter[0].Value = "FRM_WoDeJiaoYi_Load_FenYeZongShuGuaPaiGongShi";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeJiaoYi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //GaoJiSouSuo
        [OperationContract]
        public DataSet FRM_WoDeJiaoYi_Load_XingZhengQu()
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),               
            };
            mySqlParameter[0].Value = "FRM_WoDeJiaoYi_Load_XingZhengQu";            
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeJiaoYi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnSouSuo_Click_WoDeJiaoYi_DongTaiTiaoJian(string GuaPaiBianHao, DateTime GuaPaiQiShiShiJian,
            DateTime GuaPaiJieZhiShiJian, string TuDiWeiZhi, string KeHuMingCheng)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter ("@type",SqlDbType.NChar),
                new SqlParameter ("@HuoQuGuaPaiBianHao",SqlDbType.NChar),
                new SqlParameter ("@HuoQuGuaPaiQiShiShiJian",SqlDbType.DateTime),
                new SqlParameter ("@HuoQuGuaPaiJieZhiShiJian",SqlDbType.DateTime),
                new SqlParameter ("@HuoQuTuDiWeiZhi",SqlDbType.NChar),
                new SqlParameter ("@HuoQuKeHuMingCheng",SqlDbType.NChar),
                //new SqlParameter ("@HuoQuXingZhengQuID",SqlDbType.Int),
            };
            mySqlParameter[0].Value = "btnSouSuo_Click_WoDeJiaoYi_DongTaiTiaoJian";
            mySqlParameter[1].Value = GuaPaiBianHao;
            mySqlParameter[2].Value = GuaPaiQiShiShiJian;
            mySqlParameter[3].Value = GuaPaiJieZhiShiJian;
            mySqlParameter[4].Value = TuDiWeiZhi;
            mySqlParameter[5].Value = KeHuMingCheng;
            //mySqlParameter[6].Value = XingZhengQuID;          
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeJiaoYi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnSouSuo_Click_WoDeJiaoYi_DongTaiTiaoJian_ZongShu()
        {
            SqlParameter[] mySqlParameter = {
                 new SqlParameter("@type",SqlDbType.NChar),
                 //new SqlParameter("@DongTaiTiaoJian",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "btnSouSuo_Click_WoDeJiaoYi_DongTaiTiaoJian_ZongShu";
            //mySqlParameter[1].Value = DongTaiTiaoJian;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeJiaoYi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnClickChuJai_ShiFouYouBaoZhangXingZhuFang(int GuaPaiID)
        {
            SqlParameter[] mySqlParameter = {
                 new SqlParameter("@type",SqlDbType.NChar), 
                 new SqlParameter("@GuaPaiID",SqlDbType.Int)           
            };
            mySqlParameter[0].Value = "btnClickChuJai_ShiFouYouBaoZhangXingZhuFang";
            mySqlParameter[1].Value = GuaPaiID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeJiaoYi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

    }
}
