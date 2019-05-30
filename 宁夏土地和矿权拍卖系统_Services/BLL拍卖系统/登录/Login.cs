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
    class Login
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();

        [OperationContract]
        public DataSet ChaXunKeHuXinXi_DengLu(string KeHuMingCheng, string ShuZiZhengShuMiMa)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuMingCheng",SqlDbType.NChar),
                new SqlParameter("@ShuZiZhengShuMiMa",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "ChaXunKeHuXinXi_DengLu";
            mySqlParameter[1].Value = KeHuMingCheng;
            mySqlParameter[2].Value = ShuZiZhengShuMiMa;
            DataTable dt = myDAL.QueryDataTable("Login", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
