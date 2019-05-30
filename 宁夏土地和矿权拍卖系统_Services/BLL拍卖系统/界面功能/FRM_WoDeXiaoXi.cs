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
    class FRM_WoDeXiaoXi
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        //WoDeXiaoXi
        [OperationContract]
        public DataSet btnChaZao_Click_WoDeXiaoXi_FenYe(DateTime GuaPaiQiShiShiJian, DateTime GuaPaiJieZhiShiJian,
            int YeMa, int MeiYeShuLiang, int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter ("@GuaPaiQiShiShiJian",SqlDbType.DateTime),
            new SqlParameter ("@GuaPaiJieZhiShiJian",SqlDbType.DateTime),
            new SqlParameter("@YeMa",SqlDbType.Int),
            new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
            new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "btnChaZao_Click_WoDeXiaoXi_FenYe";
            mySqlParameter[1].Value = GuaPaiQiShiShiJian;
            mySqlParameter[2].Value = GuaPaiJieZhiShiJian;
            mySqlParameter[3].Value = YeMa;
            mySqlParameter[4].Value = MeiYeShuLiang;
            mySqlParameter[5].Value = KeHuID;
             DataTable dt = myDAL.QueryDataTable("FRM_WoDeXiaoXi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnChaZao_Click_WoDeXiaoXi_ZongShu(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "btnChaZao_Click_WoDeXiaoXi_ZongShu";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeXiaoXi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnChaKanQuanBu_Click_WoDeXiaoXi_FenYe(int YeMa, int MeiYeShuLiang,int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@YeMa",SqlDbType.Int),
            new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
            new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "btnChaKanQuanBu_Click_WoDeXiaoXi_FenYe";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            mySqlParameter[3].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeXiaoXi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShu(int KeHuID) 
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int)               
            };
            mySqlParameter[0].Value = "btnChaKanQuanBu_Click_WoDeXiaoXi_ZongShu";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeXiaoXi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //WoDeChuJiaJiLu       
        [OperationContract]
        public DataSet btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJian(string DongTaiTiaoJian)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@DongTaiTiaoJian",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "btnChaZao_Click_WoDeChuJaiJiLu_DongTaiTiaoJian";
            mySqlParameter[1].Value = DongTaiTiaoJian;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeXiaoXi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
     
        [OperationContract]
        public DataSet btnChaKanQuanBu2_Click_WoDeChuJaiJiLu(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "btnChaKanQuanBu2_Click_WoDeChuJaiJiLu";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeXiaoXi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //WoDeDengLuQingKuang
        [OperationContract]
        public DataSet btnChaZhaoQuanBu_Click_DengLuQingKuang(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@KeHuID",SqlDbType.Int)
               };
            mySqlParameter[0].Value = "btnChaZhaoQuanBu_Click_DengLuQingKuang";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeXiaoXi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnChazhao_Click_DengLuQingKuang(DateTime QiShiShiJian, DateTime JeiZhiShiJian,int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@QiShiShiJian",SqlDbType.DateTime),
            new SqlParameter("@JeiZhiShiJian",SqlDbType.DateTime),
            new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "btnChazhao_Click_DengLuQingKuang";
            mySqlParameter[1].Value = QiShiShiJian;
            mySqlParameter[2].Value = JeiZhiShiJian;
            mySqlParameter[3].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeXiaoXi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

    }
}
