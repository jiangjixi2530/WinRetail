using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Win.Soft.Retail.RetailModel;
using System.Collections.Generic;
namespace Win.Soft.Retail.RetailDal
{
    /// <summary>
    /// 数据访问类:PurchaseDetail
    /// </summary>
    public partial class PurchaseDetailDal
    {
        public PurchaseDetailDal()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "tb_PurchaseDetail");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_PurchaseDetail");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Win.Soft.Retail.RetailModel.PurchaseDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_PurchaseDetail(");
            strSql.Append("PurchaseID,ProductID,PurchaseCount,PurchaseUnitID,PurchasePrice,PurchaseAmount,Remark)");
            strSql.Append(" values (");
            strSql.Append("@PurchaseID,@ProductID,@PurchaseCount,@PurchaseUnitID,@PurchasePrice,@PurchaseAmount,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@PurchaseID", SqlDbType.Int,4),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@PurchaseCount", SqlDbType.Decimal,9),
					new SqlParameter("@PurchaseUnitID", SqlDbType.Int,4),
					new SqlParameter("@PurchasePrice", SqlDbType.Decimal,9),
					new SqlParameter("@PurchaseAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
            parameters[0].Value = model.PurchaseID;
            parameters[1].Value = model.ProductID;
            parameters[2].Value = model.PurchaseCount;
            parameters[3].Value = model.PurchaseUnitID;
            parameters[4].Value = model.PurchasePrice;
            parameters[5].Value = model.PurchaseAmount;
            parameters[6].Value = model.Remark;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Win.Soft.Retail.RetailModel.PurchaseDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_PurchaseDetail set ");
            strSql.Append("PurchaseID=@PurchaseID,");
            strSql.Append("ProductID=@ProductID,");
            strSql.Append("PurchaseCount=@PurchaseCount,");
            strSql.Append("PurchaseUnitID=@PurchaseUnitID,");
            strSql.Append("PurchasePrice=@PurchasePrice,");
            strSql.Append("PurchaseAmount=@PurchaseAmount,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@PurchaseID", SqlDbType.Int,4),
					new SqlParameter("@ProductID", SqlDbType.Int,4),
					new SqlParameter("@PurchaseCount", SqlDbType.Decimal,9),
					new SqlParameter("@PurchaseUnitID", SqlDbType.Int,4),
					new SqlParameter("@PurchasePrice", SqlDbType.Decimal,9),
					new SqlParameter("@PurchaseAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.PurchaseID;
            parameters[1].Value = model.ProductID;
            parameters[2].Value = model.PurchaseCount;
            parameters[3].Value = model.PurchaseUnitID;
            parameters[4].Value = model.PurchasePrice;
            parameters[5].Value = model.PurchaseAmount;
            parameters[6].Value = model.Remark;
            parameters[7].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_PurchaseDetail ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_PurchaseDetail ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteNotInIDs(int PurchaseID, string IDs)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_PurchaseDetail ");
            strSql.Append(" where ID not in (" + IDs + ") AND  PurchaseID=" + PurchaseID.ToString());
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Win.Soft.Retail.RetailModel.PurchaseDetail GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,PurchaseID,ProductID,PurchaseCount,PurchaseUnitID,PurchasePrice,PurchaseAmount,Remark from tb_PurchaseDetail ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Win.Soft.Retail.RetailModel.PurchaseDetail model = new Win.Soft.Retail.RetailModel.PurchaseDetail();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Win.Soft.Retail.RetailModel.PurchaseDetail DataRowToModel(DataRow row)
        {
            Win.Soft.Retail.RetailModel.PurchaseDetail model = new Win.Soft.Retail.RetailModel.PurchaseDetail();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["PurchaseID"] != null && row["PurchaseID"].ToString() != "")
                {
                    model.PurchaseID = int.Parse(row["PurchaseID"].ToString());
                }
                if (row["ProductID"] != null && row["ProductID"].ToString() != "")
                {
                    model.ProductID = int.Parse(row["ProductID"].ToString());
                }
                if (row["PurchaseCount"] != null && row["PurchaseCount"].ToString() != "")
                {
                    model.PurchaseCount = decimal.Parse(row["PurchaseCount"].ToString());
                }
                if (row["PurchaseUnitID"] != null && row["PurchaseUnitID"].ToString() != "")
                {
                    model.PurchaseUnitID = int.Parse(row["PurchaseUnitID"].ToString());
                }
                if (row["PurchasePrice"] != null && row["PurchasePrice"].ToString() != "")
                {
                    model.PurchasePrice = decimal.Parse(row["PurchasePrice"].ToString());
                }
                if (row["PurchaseAmount"] != null && row["PurchaseAmount"].ToString() != "")
                {
                    model.PurchaseAmount = decimal.Parse(row["PurchaseAmount"].ToString());
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row.Table.Columns.Contains("ProductName") && row["ProductName"] != null)
                    model.ProductName = row["ProductName"].ToString();
                if (row.Table.Columns.Contains("ProductCode") && row["ProductCode"] != null)
                    model.ProductCode = row["ProductCode"].ToString();
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,PurchaseID,ProductID,PurchaseCount,PurchaseUnitID,PurchasePrice,PurchaseAmount,Remark ");
            strSql.Append(" FROM tb_PurchaseDetail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,PurchaseID,ProductID,PurchaseCount,PurchaseUnitID,PurchasePrice,PurchaseAmount,Remark ");
            strSql.Append(" FROM tb_PurchaseDetail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM tb_PurchaseDetail ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from tb_PurchaseDetail T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "tb_PurchaseDetail";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        public List<PurchaseDetail> GetPurchaseDetail(int PurchaseID)
        {
            string sql = @"SELECT  d.ID ,
                            d.PurchaseID ,
                            d.ProductID ,
                            p.Code AS ProductCode,
                            p.Name AS ProductName,
                            d.PurchaseUnitID ,
                            d.PurchaseCount ,
                            d.PurchasePrice ,
                            d.PurchaseAmount ,
                            d.Remark FROM dbo.tb_PurchaseDetail d
                    LEFT JOIN dbo.tb_Product p ON p.ID=d.ProductID  WHERE PurchaseID=" + PurchaseID.ToString();
            DataTable dt = DbHelperSQL.Query(sql).Tables[0];
            return DataTableToList(dt);

        }
        /// <summary>
        /// DataTable转List
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public List<PurchaseDetail> DataTableToList(DataTable dt)
        {
            List<PurchaseDetail> list = new List<PurchaseDetail>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(DataRowToModel(dr));
            }
            return list;
        }
        #endregion  ExtensionMethod
    }
}

