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
    class FRM_LianHeShenQingShengMing
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();       
        //GuaPaiBianHao
        [OperationContract]
        public DataSet FRM_LianHeShenQingShengMing_Load(int GuaPaiID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@GuaPaiID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_LianHeShenQingShengMing_Load";
            mySqlParameter[1].Value = GuaPaiID;
            DataTable dt = myDAL.QueryDataTable("FRM_LianHeShenQingShengMing", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //BianJiTingZhiFaSongShiJian
        [OperationContract]
        public DataSet FRM_LianHeShenQingShengMing_KeHuXinXi(string KeHuMingCheng)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuMingCheng",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "FRM_LianHeShenQingShengMing_KeHuXinXi";
            mySqlParameter[1].Value = KeHuMingCheng;
            DataTable dt = myDAL.QueryDataTable("FRM_LianHeShenQingShengMing", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet FRM_LianHeShenQingShengMing_TianJaiKeHu(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_LianHeShenQingShengMing_TianJaiKeHu";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_LianHeShenQingShengMing", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
