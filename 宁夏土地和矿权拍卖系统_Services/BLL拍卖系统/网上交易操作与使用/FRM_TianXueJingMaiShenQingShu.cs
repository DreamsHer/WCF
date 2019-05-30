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
    class FRM_TianXueJingMaiShenQingShu
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        [OperationContract]
        public DataSet FRM_TianXueJingMaiShenQingShu_Load(int GuaPaiID)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@GuaPaiID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_TianXueJingMaiShenQingShu_Load";
            mySqlParameter[1].Value = GuaPaiID;
            DataTable dt = myDAL.QueryDataTable("FRM_TianXueJingMaiShenQingShu", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public int btnTongYi_Click_BaoCun1(string KeHuMingCheng, string FaRenDaiBiao, string LianXiRen,
            string LianXiDiZhi, string YouZhengBianMa, string LianXiDianHua)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@KeHuMingCheng",SqlDbType.NChar),
            new SqlParameter("@FaRenDaiBiao",SqlDbType.NChar),
            new SqlParameter("@LianXiRen",SqlDbType.NChar),
            new SqlParameter("@LianXiDiZhi",SqlDbType.NChar),
            new SqlParameter("@YouZhengBianMa",SqlDbType.NChar),
            new SqlParameter("@LianXiDianHua",SqlDbType.NChar),
            };
            mySqlParameter[0].Value = "btnTongYi_Click_BaoCun1";
            mySqlParameter[1].Value = KeHuMingCheng;
            mySqlParameter[2].Value = FaRenDaiBiao;
            mySqlParameter[3].Value = LianXiRen;
            mySqlParameter[4].Value = LianXiDiZhi;
            mySqlParameter[5].Value = YouZhengBianMa;
            mySqlParameter[6].Value = LianXiDianHua;
            int dt = myDAL.UpdateData("FRM_TianXueJingMaiShenQingShu", mySqlParameter);         
            return dt;
        }

        [OperationContract]
        public int btnTongYi_Click_BaoCun2(DateTime ShenQingShiJian)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@ShenQingShiJian",SqlDbType.DateTime)
            };
            mySqlParameter[0].Value = "btnTongYi_Click_BaoCun2";
            mySqlParameter[1].Value = ShenQingShiJian;
            int dt = myDAL.UpdateData("FRM_TianXueJingMaiShenQingShu", mySqlParameter);   
            return dt;
        }
   
    }
}
