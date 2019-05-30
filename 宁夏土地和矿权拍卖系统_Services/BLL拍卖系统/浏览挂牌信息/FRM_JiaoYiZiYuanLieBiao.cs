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
    class FRM_JiaoYiZiYuanLieBiao
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        [OperationContract]
        public DataSet ChaXunShuJuXingZhengQu()
        {
            SqlParameter[] mySqlParameter = {
               new SqlParameter("@type",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "ChaXunShuJuXingZhengQu";
            DataTable dt = myDAL.QueryDataTable("FRM_JiaoYiZiYuanLieBiao", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet ChaXunShuJuJiaoYiZiYuanLieBiao(string DongTaiTiaoJian)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@DongTaiTiaoJian",SqlDbType.NChar),
            };
            mySqlParameter[0].Value = "ChaXunShuJuJiaoYiZiYuanLieBiao";
            mySqlParameter[1].Value = DongTaiTiaoJian;
            DataTable dt = myDAL.QueryDataTable("FRM_JiaoYiZiYuanLieBiao", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongShu(string DongTaiTiaoJian)
        {
            SqlParameter[] mySqlParameter = {
               new SqlParameter("@type",SqlDbType.NChar),
               new SqlParameter("@DongTaiTiaoJian",SqlDbType.NChar),
            };
            mySqlParameter[0].Value = "ChaXunShuJuJiaoYiZiYuanLieBiaoDanZongShu";
            mySqlParameter[1].Value = DongTaiTiaoJian;
            DataTable dt = myDAL.QueryDataTable("FRM_JiaoYiZiYuanLieBiao", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
