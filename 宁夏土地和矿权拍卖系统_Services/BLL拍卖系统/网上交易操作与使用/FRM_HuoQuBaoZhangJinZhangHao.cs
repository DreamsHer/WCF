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
    class FRM_HuoQuBaoZhangJinZhangHao
    {
        DALPublic.DALMethod myDAL = new DALPublic.DALMethod();

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

        //XinZeng
        [OperationContract]
        public int btnDaYin_Click_InsertShenQingBiao(string ShenQingBianHao, string ShenQingShiJian)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@ShenQingBianHao",SqlDbType.NChar),
            new SqlParameter("@ShenQingShiJian",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "btnDaYin_Click_InsertShenQingBiao";
            mySqlParameter[1].Value = ShenQingBianHao;
            mySqlParameter[2].Value = ShenQingShiJian;
            int dt = myDAL.UpdateData("FRM_HuoQuBaoZhangJinZhangHao", mySqlParameter);          
            return dt;
        }

        [OperationContract]
        public int btnDaYin_Click_InsertBaoZhengJinBiao(string YinXingZhangHao, string YinXingMingCheng, string ZhangHuMing)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@YinXingZhangHao",SqlDbType.NChar),
            new SqlParameter("YinXingMingCheng",SqlDbType.NChar),
            new SqlParameter("ZhangHuMing",SqlDbType.NChar)
            };
            mySqlParameter[0].Value = "btnDaYin_Click_InsertBaoZhengJinBiao";
            mySqlParameter[1].Value = YinXingZhangHao;
            mySqlParameter[2].Value = YinXingMingCheng;
            mySqlParameter[3].Value = ZhangHuMing;
            int dt = myDAL.UpdateData("FRM_HuoQuBaoZhangJinZhangHao", mySqlParameter);          
            return dt;
        }

        //ZiDingYiShengChengBaoZhengJinZhangHao
        [OperationContract]
        public DataSet Select_ShengChengBaoZhengJinZhangHao()
        {
            SqlParameter[] mySqlParameter = {
                new SqlParameter("@type",SqlDbType.NChar)
              };
            mySqlParameter[0].Value = "Select_ShengChengBaoZhengJinZhangHao";
            DataTable dt = myDAL.QueryDataTable("FRM_HuoQuBaoZhangJinZhangHao", mySqlParameter);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        //XinZeng
        [OperationContract]
        public int Select_ShengChengBaoZhengJinZhangHao_XinZeng(string BaoZhengJinZhangHao,string KaiHuYinXing)
        {
            SqlParameter[] mySqlParameter = {
            new SqlParameter("@type",SqlDbType.NChar),
            new SqlParameter("@BaoZhengJinZhangHao",SqlDbType.NChar),
            new SqlParameter("@KaiHuYinXing",SqlDbType.NChar),    
            };
            mySqlParameter[0].Value = "Select_ShengChengBaoZhengJinZhangHao_XinZeng";
            mySqlParameter[1].Value = BaoZhengJinZhangHao;
            mySqlParameter[2].Value = KaiHuYinXing;
            int dt = myDAL.UpdateData("FRM_HuoQuBaoZhangJinZhangHao", mySqlParameter);
            return dt;
        }
    }
}
