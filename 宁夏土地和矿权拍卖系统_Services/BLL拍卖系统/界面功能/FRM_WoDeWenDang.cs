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
    class FRM_WoDeWenDang
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        //查找
        [OperationContract]
        public DataSet btnChaZhao_Click_DongTaiTiaoJian(string DongTaiTiaoJian)
        {
            SqlParameter[] mySqlParameter = {
               new SqlParameter("@type",SqlDbType.NChar),
               new SqlParameter("@DongTaiTiaoJian",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "btnChaZhao_Click_DongTaiTiaoJian";
            mySqlParameter[1].Value = DongTaiTiaoJian;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeWenDang", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnChaZhao_Click_DongTaiTiaoJian_ZongShu(string DongTaiTiaoJian)
        {
            SqlParameter[] mySqlParameter = {
               new SqlParameter("@type",SqlDbType.NChar),
               new SqlParameter("@DongTaiTiaoJian",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "btnChaZhao_Click_DongTaiTiaoJian_ZongShu";
            mySqlParameter[1].Value = DongTaiTiaoJian;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeWenDang", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //查看全部
        [OperationContract]
        public DataSet btnChaKanQuanBu_Click_WoDeWenDang(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int)               
            };
            mySqlParameter[0].Value = "btnChaKanQuanBu_Click_WoDeWenDang";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_WoDeWenDang", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //数字证书里的数据
        [OperationContract]
        public DataSet FRM_HuoQuBaoZhangJinZhangHao_Load(int GuaPaiID)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@GuaPaiID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "FRM_HuoQuBaoZhangJinZhangHao_Load";
            mySqlParameter[1].Value = GuaPaiID;
            DataTable dt = myDAL.QueryDataTable("FRM_HuoQuBaoZhangJinZhangHao", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
    }
}
