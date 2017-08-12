using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Win.Soft.Retail.RetailModel;

namespace Win.Soft.Retail.RetailDal
{
    public class SysAutoCodeDal
    {
        public SysAutoCodeDal()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SysAutoCode");
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
        public int Add(SysAutoCode model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SysAutoCode(");
            strSql.Append("Prefix,SeriationLen,AutoCodeType,RecentCode,Remark)");
            strSql.Append(" values (");
            strSql.Append("@Prefix,@SeriationLen,@AutoCodeType,@RecentCode,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Prefix", SqlDbType.VarChar,20),
					new SqlParameter("@SeriationLen", SqlDbType.Int,4),
					new SqlParameter("@AutoCodeType", SqlDbType.VarChar,100),
					new SqlParameter("@RecentCode", SqlDbType.VarChar,200),
					new SqlParameter("@Remark", SqlDbType.VarChar,200)};
            parameters[0].Value = model.Prefix;
            parameters[1].Value = model.SeriationLen;
            parameters[2].Value = model.AutoCodeType;
            parameters[3].Value = model.RecentCode;
            parameters[4].Value = model.Remark;

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
        public bool Update(SysAutoCode model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SysAutoCode set ");
            strSql.Append("Prefix=@Prefix,");
            strSql.Append("SeriationLen=@SeriationLen,");
            strSql.Append("AutoCodeType=@AutoCodeType,");
            strSql.Append("RecentCode=@RecentCode,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Prefix", SqlDbType.VarChar,20),
					new SqlParameter("@SeriationLen", SqlDbType.Int,4),
					new SqlParameter("@AutoCodeType", SqlDbType.VarChar,100),
					new SqlParameter("@RecentCode", SqlDbType.VarChar,200),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Prefix;
            parameters[1].Value = model.SeriationLen;
            parameters[2].Value = model.AutoCodeType;
            parameters[3].Value = model.RecentCode;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.ID;

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
            strSql.Append("delete from SysAutoCode ");
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
            strSql.Append("delete from SysAutoCode ");
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
        public SysAutoCode GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Prefix,SeriationLen,AutoCodeType,RecentCode,Remark from SysAutoCode ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            SysAutoCode model = new SysAutoCode();
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
        /// 根据单据类型获取配置
        /// </summary>
        /// <param name="AutoCodeType"></param>
        /// <returns></returns>
        public SysAutoCode GetModel(string AutoCodeType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Prefix,SeriationLen,AutoCodeType,RecentCode,Remark from SysAutoCode ");
            strSql.Append(" where AutoCodeType=@AutoCodeType");
            SqlParameter[] parameters = {
					new SqlParameter("@AutoCodeType", SqlDbType.VarChar,100)
			};
            parameters[0].Value = AutoCodeType;

            SysAutoCode model = new SysAutoCode();
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
        public SysAutoCode DataRowToModel(DataRow row)
        {
            SysAutoCode model = new SysAutoCode();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["Prefix"] != null)
                {
                    model.Prefix = row["Prefix"].ToString();
                }
                if (row["SeriationLen"] != null && row["SeriationLen"].ToString() != "")
                {
                    model.SeriationLen = int.Parse(row["SeriationLen"].ToString());
                }
                if (row["AutoCodeType"] != null)
                {
                    model.AutoCodeType = row["AutoCodeType"].ToString();
                }
                if (row["RecentCode"] != null)
                {
                    model.RecentCode = row["RecentCode"].ToString();
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
            strSql.Append("select ID,Prefix,SeriationLen,AutoCodeType,RecentCode,Remark ");
            strSql.Append(" FROM SysAutoCode ");
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
            strSql.Append(" ID,Prefix,SeriationLen,AutoCodeType,RecentCode,Remark ");
            strSql.Append(" FROM SysAutoCode ");
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
            strSql.Append("select count(1) FROM SysAutoCode ");
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
            strSql.Append(")AS Row, T.*  from SysAutoCode T ");
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
            parameters[0].Value = "SysAutoCode";
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


