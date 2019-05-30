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
    class FRM_ChuJiaJiLu
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        [OperationContract]
        public DataSet FRM_DiKuaiXiangQing_Load(int GuaPaiID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("GuaPaiID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_DiKuaiXiangQing_Load";
            mySqlParameter[1].Value = GuaPaiID;
            DataTable dt = myDAL.QueryDataTable("FRM_DiKuaiXiangQing", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_PaiMaiDaTing_Load_ZuiJinChuJaiJiLu(int GuaPaiID)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@GuaPaiID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_PaiMaiDaTing_Load_ZuiJinChuJaiJiLu";
            mySqlParameter[1].Value = GuaPaiID;
            DataTable dt = myDAL.QueryDataTable("FRM_PaiMaiDaTing", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_PaiMaiDaTing_Load_ZuiJinChuJaiJiLu_ZongShu(int GuaPaiID)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@GuaPaiID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_PaiMaiDaTing_Load_ZuiJinChuJaiJiLu_ZongShu";
            mySqlParameter[1].Value = GuaPaiID;
            DataTable dt = myDAL.QueryDataTable("FRM_PaiMaiDaTing", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
