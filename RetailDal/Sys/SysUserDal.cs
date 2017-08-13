using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BaseTool;
using System.Collections.Generic;
namespace Win.Soft.Retail.RetailDal
{
    /// <summary>
    /// 数据访问类:SysUser
    /// </summary>
    public partial class SysUserDal
    {
        public SysUserDal()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SysUser");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SysUser");
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
        public int Add(Win.Soft.Retail.RetailModel.SysUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SysUser(");
            strSql.Append("UserNo,UserName,TelePhone,CompanyID,LoginName,LoginPwd,IsValid,LastLoginDate)");
            strSql.Append(" values (");
            strSql.Append("@UserNo,@UserName,@TelePhone,@CompanyID,@LoginName,@LoginPwd,@IsValid,@LastLoginDate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@UserNo", SqlDbType.VarChar,100),
					new SqlParameter("@UserName", SqlDbType.VarChar,100),
					new SqlParameter("@TelePhone", SqlDbType.VarChar,50),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@LoginName", SqlDbType.VarChar,200),
					new SqlParameter("@LoginPwd", SqlDbType.VarChar,200),
					new SqlParameter("@IsValid", SqlDbType.Int,4),
					new SqlParameter("@LastLoginDate", SqlDbType.DateTime)};
            parameters[0].Value = model.UserNo;
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.TelePhone;
            parameters[3].Value = model.CompanyID;
            parameters[4].Value = model.LoginName;
            parameters[5].Value = model.LoginPwd;
            parameters[6].Value = model.IsValid;
            parameters[7].Value = model.LastLoginDate;

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
        public bool Update(Win.Soft.Retail.RetailModel.SysUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SysUser set ");
            strSql.Append("UserNo=@UserNo,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("TelePhone=@TelePhone,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("LoginName=@LoginName,");
            strSql.Append("LoginPwd=@LoginPwd,");
            strSql.Append("IsValid=@IsValid,");
            strSql.Append("LastLoginDate=@LastLoginDate");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@UserNo", SqlDbType.VarChar,100),
					new SqlParameter("@UserName", SqlDbType.VarChar,100),
					new SqlParameter("@TelePhone", SqlDbType.VarChar,50),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@LoginName", SqlDbType.VarChar,200),
					new SqlParameter("@LoginPwd", SqlDbType.VarChar,200),
					new SqlParameter("@IsValid", SqlDbType.Int,4),
					new SqlParameter("@LastLoginDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.UserNo;
            parameters[1].Value = model.UserName;
            parameters[2].Value = model.TelePhone;
            parameters[3].Value = model.CompanyID;
            parameters[4].Value = model.LoginName;
            parameters[5].Value = model.LoginPwd;
            parameters[6].Value = model.IsValid;
            parameters[7].Value = model.LastLoginDate;
            parameters[8].Value = model.ID;

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
            strSql.Append("delete from SysUser ");
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
            strSql.Append("delete from SysUser ");
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
        public Win.Soft.Retail.RetailModel.SysUser GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,UserNo,UserName,TelePhone,CompanyID,LoginName,LoginPwd,IsValid,LastLoginDate from SysUser ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Win.Soft.Retail.RetailModel.SysUser model = new Win.Soft.Retail.RetailModel.SysUser();
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
        public Win.Soft.Retail.RetailModel.SysUser DataRowToModel(DataRow row)
        {
            Win.Soft.Retail.RetailModel.SysUser model = new Win.Soft.Retail.RetailModel.SysUser();
            if (row != null)
            {
                if (row["ID"] != null && row["ID"].ToString() != "")
                {
                    model.ID = int.Parse(row["ID"].ToString());
                }
                if (row["UserNo"] != null)
                {
                    model.UserNo = row["UserNo"].ToString();
                }
                if (row["UserName"] != null)
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["TelePhone"] != null)
                {
                    model.TelePhone = row["TelePhone"].ToString();
                }
                if (row["CompanyID"] != null && row["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(row["CompanyID"].ToString());
                }
                if (row["LoginName"] != null)
                {
                    model.LoginName = row["LoginName"].ToString();
                }
                if (row["LoginPwd"] != null)
                {
                    model.LoginPwd = row["LoginPwd"].ToString();
                }
                if (row["IsValid"] != null && row["IsValid"].ToString() != "")
                {
                    model.IsValid = int.Parse(row["IsValid"].ToString());
                }
                if (row["LastLoginDate"] != null && row["LastLoginDate"].ToString() != "")
                {
                    model.LastLoginDate = DateTime.Parse(row["LastLoginDate"].ToString());
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
            strSql.Append("select ID,UserNo,UserName,TelePhone,CompanyID,LoginName,LoginPwd,IsValid,LastLoginDate ");
            strSql.Append(" FROM SysUser ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 下拉框数据源
        /// </summary>
        /// <returns></returns>
        public DataTable GetComboBoxDataSource()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,UserName AS Name");
            strSql.Append(" FROM SysUser WHERE IsValid=1");
            return DbHelperSQL.Query(strSql.ToString()).Tables[0];
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
            strSql.Append(" ID,UserNo,UserName,TelePhone,CompanyID,LoginName,LoginPwd,IsValid,LastLoginDate ");
            strSql.Append(" FROM SysUser ");
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
            strSql.Append("select count(1) FROM SysUser ");
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
            strSql.Append(")AS Row, T.*  from SysUser T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns></returns>
        public bool Login(string UserName, string UserPwd)
        {
            string pwd = DataEncrypt.EncryptString(UserPwd);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,UserNo,UserName,TelePhone,CompanyID,LoginName,LoginPwd,IsValid,LastLoginDate from SysUser ");
            strSql.Append(" where LoginName=@LoginName AND LoginPwd=@LoginPwd");
            SqlParameter[] parameters = {
					new SqlParameter("@LoginName", SqlDbType.VarChar,200),
					new SqlParameter("@LoginPwd", SqlDbType.VarChar,200)
			};
            parameters[0].Value = UserName;
            parameters[1].Value = pwd;

            Win.Soft.Retail.RetailModel.SysUser model = new Win.Soft.Retail.RetailModel.SysUser();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model = DataRowToModel(ds.Tables[0].Rows[0]);
                Global.UserID = model.ID;
                Global.UserName = model.UserName;
                Global.UserCode = model.UserNo;
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// DataTable转List
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public List<Win.Soft.Retail.RetailModel.SysUser> DataTableToList(DataTable dt)
        {
            List<Win.Soft.Retail.RetailModel.SysUser> list = new List<RetailModel.SysUser>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(DataRowToModel(dr));
            }
            return list;
        }
        #endregion  ExtensionMethod
    }
}

