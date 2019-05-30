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
    class FRM_GeRenZiLiao
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        //GeRenXinXi
        [OperationContract]
        public DataSet FRM_GeRenZiLiao_Load_GeRenXinXi(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar), 
                new SqlParameter("KeHuID",SqlDbType.Int)              
            };
            mySqlParameter[0].Value = "FRM_GeRenZiLiao_Load_GeRenXinXi";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_GeRenZiLiao", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //QiYeXinXi
        [OperationContract]
        public DataSet FRM_GeRenZiLiao_Load_QiYeXinXi(int KeHuID)
        {
            SqlParameter[] mySqlParameter =
            {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_GeRenZiLiao_Load_QiYeXinXi";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_GeRenZiLiao", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
