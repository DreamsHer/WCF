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
    class FRM_ZhiFuGuanLi
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();
        //XingZhengQu
        [OperationContract]
        public DataSet FRM_ZhiFuGuanLi_Load_XingZhengQuMingCheng()
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
            };
            mySqlParameter[0].Value = "FRM_ZhiFuGuanLi_Load_XingZhengQuMingCheng";
            DataTable dt = myDAL.QueryDataTable("FRM_ZhiFuGuanLi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //BaoZhengJinJiaoNaQingKuang
        [OperationContract]
        public DataSet btnChaZhao_Click_DongTaiTiaoJianChaZhao(string DongTaiTiaoJian)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@DongTaiTiaoJian",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "btnChaZhao_Click_DongTaiTiaoJianChaZhao";
            mySqlParameter[1].Value = DongTaiTiaoJian;
            DataTable dt = myDAL.QueryDataTable("FRM_ZhiFuGuanLi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnChaKanQuanBu_Click_QuanBuChaZhao_FenYe(int YeMa, int MeiYeShuLiang,int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "btnChaKanQuanBu_Click_QuanBuChaZhao_FenYe";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            mySqlParameter[3].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_ZhiFuGuanLi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnChaKanQuanBu_Click_QuanBuChaZhao_FenYeZongShu(int KeHuID)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@KeHuID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "btnChaKanQuanBu_Click_QuanBuChaZhao_FenYeZongShu";
            mySqlParameter[1].Value = KeHuID;
            DataTable dt = myDAL.QueryDataTable("FRM_ZhiFuGuanLi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //DaoZhangChaXun
        [OperationContract]
        public DataSet btnChaZhao1_Click_TiaoJianChaZhao()
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
            };
            mySqlParameter[0].Value = "btnChaZhao1_Click_TiaoJianChaZhao";
            DataTable dt = myDAL.QueryDataTable("FRM_ZhiFuGuanLi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnChaKanQuanBu1_Click_ChaZhaoQuanBu(int YeMa, int MeiYeShuLiang)
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                new SqlParameter("@YeMa",SqlDbType.Int),
                new SqlParameter("@MeiYeShuLiang",SqlDbType.Int),
            };
            mySqlParameter[0].Value = "btnChaKanQuanBu1_Click_ChaZhaoQuanBu";
            mySqlParameter[1].Value = YeMa;
            mySqlParameter[2].Value = MeiYeShuLiang;
            DataTable dt = myDAL.QueryDataTable("FRM_ZhiFuGuanLi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        [OperationContract]
        public DataSet btnChaKanQuanBu_Click_QuanBuChaZhao_ZongShu() //int JingPaiID
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar),
                //new SqlParameter("@JingPaiID",SqlDbType.Int)
            };
            mySqlParameter[0].Value = "btnChaKanQuanBu_Click_QuanBuChaZhao_ZongShu";
            //mySqlParameter[1].Value = JingPaiID;
            DataTable dt = myDAL.QueryDataTable("FRM_ZhiFuGuanLi", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

    }
}
