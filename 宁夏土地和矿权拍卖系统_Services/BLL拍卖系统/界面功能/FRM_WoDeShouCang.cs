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
    class FRM_WoDeShouCang
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        //JiSuanQuanBuFeYe
        [OperationContract]
        public DataSet FRM_WoDeShouCang_FenYe(int YeMa, int MeiYeShuLiang, int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_WoDeShouCang_FenYe";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            mySqlParameter[3].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeShouCang", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
       
        [OperationContract]
        public DataSet FRM_WoDeShouCang_FenYeZongShu(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int),
            };
            mySqlParameter[0].Value = "FRM_WoDeShouCang_FenYeZongShu";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeShouCang", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //YiChuShouCang      
        [OperationContract]
        public int btnClickShouCang_YiChuShouCang(int GuaPaiID)
        {
            SqlParameter[] mySqlParameters =
            {
                new SqlParameter("@type",SqlDbType.NChar),               
                new SqlParameter("@GuaPaiID",SqlDbType.Int),
                //new SqlParameter("@KeHuID",SqlDbType.Int),
            };
            mySqlParameters[0].Value = "btnClickShouCang_YiChuShouCang";
            mySqlParameters[1].Value = GuaPaiID;
            //mySqlParameter[2].Value = KeHuID;
            int result = myDAL.UpdateData("FRM_WoDeShouCang", mySqlParameters);
            return result;
        }
    }
}

