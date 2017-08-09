using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Win.Soft.Retail.Model.RetailModel;

namespace Win.Soft.Retail.RetailDal
{  /// <summary>
    /// 数据访问类:tb_PayMent
    /// </summary>
    public partial class tb_PayMent
    {
        public tb_PayMent()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_PayMent");
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
        public int Add(PayMent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_PayMent(");
            strSql.Append("Code,PayDate,PayerID,ManufacturerID,PayableAmount,PayAmount,Remark,CreateUserID,CreateDate,IsSubmit,SubmitDate)");
            strSql.Append(" values (");
            strSql.Append("@Code,@PayDate,@PayerID,@ManufacturerID,@PayableAmount,@PayAmount,@Remark,@CreateUserID,@CreateDate,@IsSubmit,@SubmitDate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Code", SqlDbType.VarChar,50),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayerID", SqlDbType.Int,4),
					new SqlParameter("@ManufacturerID", SqlDbType.Int,4),
					new SqlParameter("@PayableAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@CreateUserID", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@IsSubmit", SqlDbType.Int,4),
					new SqlParameter("@SubmitDate", SqlDbType.DateTime)};
            parameters[0].Value = model.Code;
            parameters[1].Value = model.PayDate;
            parameters[2].Value = model.PayerID;
            parameters[3].Value = model.ManufacturerID;
            parameters[4].Value = model.PayableAmount;
            parameters[5].Value = model.PayAmount;
            parameters[6].Value = model.Remark;
            parameters[7].Value = model.CreateUserID;
            parameters[8].Value = model.CreateDate;
            parameters[9].Value = model.IsSubmit;
            parameters[10].Value = model.SubmitDate;

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
        public bool Update(PayMent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_PayMent set ");
            strSql.Append("Code=@Code,");
            strSql.Append("PayDate=@PayDate,");
            strSql.Append("PayerID=@PayerID,");
            strSql.Append("ManufacturerID=@ManufacturerID,");
            strSql.Append("PayableAmount=@PayableAmount,");
            strSql.Append("PayAmount=@PayAmount,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("CreateUserID=@CreateUserID,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("IsSubmit=@IsSubmit,");
            strSql.Append("SubmitDate=@SubmitDate");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Code", SqlDbType.VarChar,50),
					new SqlParameter("@PayDate", SqlDbType.DateTime),
					new SqlParameter("@PayerID", SqlDbType.Int,4),
					new SqlParameter("@ManufacturerID", SqlDbType.Int,4),
					new SqlParameter("@PayableAmount", SqlDbType.Decimal,9),
					new SqlParameter("@PayAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@CreateUserID", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@IsSubmit", SqlDbType.Int,4),
					new SqlParameter("@SubmitDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Code;
            parameters[1].Value = model.PayDate;
            parameters[2].Value = model.PayerID;
            parameters[3].Value = model.ManufacturerID;
            parameters[4].Value = model.PayableAmount;
            parameters[5].Value = model.PayAmount;
            parameters[6].Value = model.Remark;
            parameters[7].Value = model.CreateUserID;
            parameters[8].Value = model.CreateDate;
            parameters[9].Value = model.IsSubmit;
            parameters[10].Value = model.SubmitDate;
            parameters[11].Value = model.ID;

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
            strSql.Append("delete from tb_PayMent ");
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
            strSql.Append("delete from tb_PayMent ");
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
        public PayMent GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Code,PayDate,PayerID,ManufacturerID,PayableAmount,PayAmount,Remark,CreateUserID,CreateDate,IsSubmit,SubmitDate from tb_PayMent ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            PayMent model = new PayMent();
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
        public PayMent DataRowToModel(DataRow row)
        {
            PayMent model = new PayMent();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Code"] != null)
                {
                    model.Code = row["Code"].ToString();
                }
                if (row["PayDate"] != null && row["PayDate"].ToString() != "")
                {
                    model.PayDate = DateTime.Parse(row["PayDate"].ToString());
                }
                if (row["PayerID"] != null && row["PayerID"].ToString() != "")
                {
                    model.PayerID = int.Parse(row["PayerID"].ToString());
                }
                if (row["ManufacturerID"] != null && row["ManufacturerID"].ToString() != "")
                {
                    model.ManufacturerID = int.Parse(row["ManufacturerID"].ToString());
                }
                if (row["PayableAmount"] != null && row["PayableAmount"].ToString() != "")
                {
                    model.PayableAmount = decimal.Parse(row["PayableAmount"].ToString());
                }
                if (row["PayAmount"] != null && row["PayAmount"].ToString() != "")
                {
                    model.PayAmount = decimal.Parse(row["PayAmount"].ToString());
                }
                if (row["Remark"] != null)
                {
                    model.Remark = row["Remark"].ToString();
                }
                if (row["CreateUserID"] != null && row["CreateUserID"].ToString() != "")
                {
                    model.CreateUserID = int.Parse(row["CreateUserID"].ToString());
                }
                if (row["CreateDate"] != null && row["CreateDate"].ToString() != "")
                {
                    model.CreateDate = DateTime.Parse(row["CreateDate"].ToString());
                }
                if (row["IsSubmit"] != null && row["IsSubmit"].ToString() != "")
                {
                    model.IsSubmit = int.Parse(row["IsSubmit"].ToString());
                }
                if (row["SubmitDate"] != null && row["SubmitDate"].ToString() != "")
                {
                    model.SubmitDate = DateTime.Parse(row["SubmitDate"].ToString());
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
            strSql.Append("select ID,Code,PayDate,PayerID,ManufacturerID,PayableAmount,PayAmount,Remark,CreateUserID,CreateDate,IsSubmit,SubmitDate ");
            strSql.Append(" FROM tb_PayMent ");
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
            strSql.Append(" ID,Code,PayDate,PayerID,ManufacturerID,PayableAmount,PayAmount,Remark,CreateUserID,CreateDate,IsSubmit,SubmitDate ");
            strSql.Append(" FROM tb_PayMent ");
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
            strSql.Append("select count(1) FROM tb_PayMent ");
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
            strSql.Append(")AS Row, T.*  from tb_PayMent T ");
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
            parameters[0].Value = "tb_PayMent";
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

