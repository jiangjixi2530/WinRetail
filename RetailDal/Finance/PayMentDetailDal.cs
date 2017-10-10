using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Win.Soft.Retail.RetailModel;

namespace Win.Soft.Retail.RetailDal.Finance
{
    /// <summary>
    /// 数据访问类:PayMentDetail
    /// </summary>
    public partial class PayMentDetailDal
    {
        public PayMentDetailDal()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_PayMentDetail");
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
        public int Add(PayMentDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_PayMentDetail(");
            strSql.Append("PayMentID,PurchaseID,PaidAmount,PayableAmount,PayAmount,IsSettle,Remark)");
            strSql.Append(" values (");
            strSql.Append("@PayMentID,@PurchaseID,@PaidAmount,@PayableAmount,@PayAmount,@IsSettle,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@PayMentID", SqlDbType.Int,4),
					new SqlParameter("@PurchaseID", SqlDbType.Int,4),
					new SqlParameter("@PaidAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PayableAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsSettle", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
            parameters[0].Value = model.PayMentID;
            parameters[1].Value = model.PurchaseID;
            parameters[2].Value = model.PaidAmount;
            parameters[3].Value = model.PayableAmount;
            parameters[4].Value = model.PayAmount;
            parameters[5].Value = model.IsSettle;
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
        public bool Update(PayMentDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_PayMentDetail set ");
            strSql.Append("PayMentID=@PayMentID,");
            strSql.Append("PurchaseID=@PurchaseID,");
            strSql.Append("PaidAmount=@PaidAmount,");
            strSql.Append("PayableAmount=@PayableAmount,");
            strSql.Append("PayAmount=@PayAmount,");
            strSql.Append("IsSettle=@IsSettle,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@PayMentID", SqlDbType.Int,4),
					new SqlParameter("@PurchaseID", SqlDbType.Int,4),
					new SqlParameter("@PaidAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PayableAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsSettle", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.PayMentID;
            parameters[1].Value = model.PurchaseID;
            parameters[2].Value = model.PaidAmount;
            parameters[3].Value = model.PayableAmount;
            parameters[4].Value = model.PayAmount;
            parameters[5].Value = model.IsSettle;
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
            strSql.Append("delete from tb_PayMentDetail ");
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
            strSql.Append("delete from tb_PayMentDetail ");
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


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public PayMentDetail GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,PayMentID,PurchaseID,PaidAmount,PayableAmount,PayAmount,IsSettle,Remark from tb_PayMentDetail ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            PayMentDetail model = new PayMentDetail();
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
        public PayMentDetail DataRowToModel(DataRow row)
        {
            PayMentDetail model = new PayMentDetail();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["PayMentID"] != null && row["PayMentID"].ToString() != "")
                {
                    model.PayMentID = int.Parse(row["PayMentID"].ToString());
                }
                if (row["PurchaseID"] != null && row["PurchaseID"].ToString() != "")
                {
                    model.PurchaseID = int.Parse(row["PurchaseID"].ToString());
                }
                if (row["PaidAmount"] != null && row["PaidAmount"].ToString() != "")
                {
                    model.PaidAmount = decimal.Parse(row["PaidAmount"].ToString());
                }
                if (row["PayableAmount"] != null && row["PayableAmount"].ToString() != "")
                {
                    model.PayableAmount = decimal.Parse(row["PayableAmount"].ToString());
                }
                if (row["PayAmount"] != null && row["PayAmount"].ToString() != "")
                {
                    model.PayAmount = decimal.Parse(row["PayAmount"].ToString());
                }
                if (row["IsSettle"] != null && row["IsSettle"].ToString() != "")
                {
                    if ((row["IsSettle"].ToString() == "1") || (row["IsSettle"].ToString().ToLower() == "true"))
                    {
                        model.IsSettle = true;
                    }
                    else
                    {
                        model.IsSettle = false;
                    }
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,PayMentID,PurchaseID,PaidAmount,PayableAmount,PayAmount,IsSettle,Remark ");
            strSql.Append(" FROM tb_PayMentDetail ");
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
            strSql.Append(" ID,PayMentID,PurchaseID,PaidAmount,PayableAmount,PayAmount,IsSettle,Remark ");
            strSql.Append(" FROM tb_PayMentDetail ");
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
            strSql.Append("select count(1) FROM tb_PayMentDetail ");
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
            strSql.Append(")AS Row, T.*  from tb_PayMentDetail T ");
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
            parameters[0].Value = "tb_PayMentDetail";
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

        #endregion  ExtensionMethod
    }
}

