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
    class FRM_QiTaGongGao
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();

        [OperationContract]
        public DataSet FRM_QiTaGongGao_Load_QiTaGongGao()
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            //new SqlParameter("@GongGaoID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_QiTaGongGao_Load_QiTaGongGao";
            //mySqlParameter[1].Value = GongGaoID;
            DataTable dt = myDAL.QueryDataTable("FRM_QiTaGongGao", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
              
    }
}
