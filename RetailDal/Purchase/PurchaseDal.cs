using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using Win.Soft.Retail.RetailModel;
namespace Win.Soft.Retail.RetailDal
{
    /// <summary>
    /// 数据访问类:Purchase
    /// </summary>
    public partial class PurchaseDal
    {
        public PurchaseDal()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "tb_Purchase");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_Purchase");
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
        public int Add(Win.Soft.Retail.RetailModel.Purchase model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_Purchase(");
            strSql.Append("Code,PurchaseDate,ManufacturerID,Relation,Telephone,ReceiveAddress,Receiver,ReceiverPhone,EstimateDate,PurchaseCount,PurchaseAmount,Remark,CreateUserID,CreateDate,IsSubmit,SubmitDate)");
            strSql.Append(" values (");
            strSql.Append("@Code,@PurchaseDate,@ManufacturerID,@Relation,@Telephone,@ReceiveAddress,@Receiver,@ReceiverPhone,@EstimateDate,@PurchaseCount,@PurchaseAmount,@Remark,@CreateUserID,@CreateDate,@IsSubmit,@SubmitDate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Code", SqlDbType.VarChar,100),
					new SqlParameter("@PurchaseDate", SqlDbType.DateTime),
					new SqlParameter("@ManufacturerID", SqlDbType.Int,4),
					new SqlParameter("@Relation", SqlDbType.VarChar,20),
					new SqlParameter("@Telephone", SqlDbType.VarChar,50),
					new SqlParameter("@ReceiveAddress", SqlDbType.VarChar,200),
					new SqlParameter("@Receiver", SqlDbType.VarChar,20),
					new SqlParameter("@ReceiverPhone", SqlDbType.VarChar,20),
					new SqlParameter("@EstimateDate", SqlDbType.DateTime),
					new SqlParameter("@PurchaseCount", SqlDbType.Decimal,9),
					new SqlParameter("@PurchaseAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@CreateUserID", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@IsSubmit", SqlDbType.Int,4),
					new SqlParameter("@SubmitDate", SqlDbType.DateTime)};
            parameters[0].Value = model.Code;
            parameters[1].Value = model.PurchaseDate;
            parameters[2].Value = model.ManufacturerID;
            parameters[3].Value = model.Relation;
            parameters[4].Value = model.Telephone;
            parameters[5].Value = model.ReceiveAddress;
            parameters[6].Value = model.Receiver;
            parameters[7].Value = model.ReceiverPhone;
            parameters[8].Value = DateTime.Now;
            parameters[9].Value = model.PurchaseCount;
            parameters[10].Value = model.PurchaseAmount;
            parameters[11].Value = model.Remark;
            parameters[12].Value = model.CreateUserID;
            parameters[13].Value = DateTime.Now;
            parameters[14].Value = model.IsSubmit;
            parameters[15].Value = DateTime.Now;

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
        public bool Update(Win.Soft.Retail.RetailModel.Purchase model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_Purchase set ");
            strSql.Append("Code=@Code,");
            strSql.Append("PurchaseDate=@PurchaseDate,");
            strSql.Append("ManufacturerID=@ManufacturerID,");
            strSql.Append("Relation=@Relation,");
            strSql.Append("Telephone=@Telephone,");
            strSql.Append("ReceiveAddress=@ReceiveAddress,");
            strSql.Append("Receiver=@Receiver,");
            strSql.Append("ReceiverPhone=@ReceiverPhone,");
            strSql.Append("EstimateDate=@EstimateDate,");
            strSql.Append("PurchaseCount=@PurchaseCount,");
            strSql.Append("PurchaseAmount=@PurchaseAmount,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("CreateUserID=@CreateUserID,");
            strSql.Append("CreateDate=@CreateDate,");
            strSql.Append("IsSubmit=@IsSubmit,");
            strSql.Append("SubmitDate=@SubmitDate");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Code", SqlDbType.VarChar,100),
					new SqlParameter("@PurchaseDate", SqlDbType.DateTime),
					new SqlParameter("@ManufacturerID", SqlDbType.Int,4),
					new SqlParameter("@Relation", SqlDbType.VarChar,20),
					new SqlParameter("@Telephone", SqlDbType.VarChar,50),
					new SqlParameter("@ReceiveAddress", SqlDbType.VarChar,200),
					new SqlParameter("@Receiver", SqlDbType.VarChar,20),
					new SqlParameter("@ReceiverPhone", SqlDbType.VarChar,20),
					new SqlParameter("@EstimateDate", SqlDbType.DateTime),
					new SqlParameter("@PurchaseCount", SqlDbType.Decimal,9),
					new SqlParameter("@PurchaseAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.VarChar,200),
					new SqlParameter("@CreateUserID", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@IsSubmit", SqlDbType.Int,4),
					new SqlParameter("@SubmitDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Code;
            parameters[1].Value = model.PurchaseDate;
            parameters[2].Value = model.ManufacturerID;
            parameters[3].Value = model.Relation;
            parameters[4].Value = model.Telephone;
            parameters[5].Value = model.ReceiveAddress;
            parameters[6].Value = model.Receiver;
            parameters[7].Value = model.ReceiverPhone;
            parameters[8].Value = model.EstimateDate;
            parameters[9].Value = model.PurchaseCount;
            parameters[10].Value = model.PurchaseAmount;
            parameters[11].Value = model.Remark;
            parameters[12].Value = model.CreateUserID;
            parameters[13].Value = model.CreateDate;
            parameters[14].Value = model.IsSubmit;
            parameters[15].Value = model.SubmitDate;
            parameters[16].Value = model.ID;

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
            strSql.Append("delete from tb_Purchase ");
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
            strSql.Append("delete from tb_Purchase ");
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
        public Win.Soft.Retail.RetailModel.Purchase GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Code,PurchaseDate,ManufacturerID,Relation,Telephone,ReceiveAddress,Receiver,ReceiverPhone,EstimateDate,PurchaseCount,PurchaseAmount,Remark,CreateUserID,CreateDate,IsSubmit,SubmitDate from tb_Purchase ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Win.Soft.Retail.RetailModel.Purchase model = new Win.Soft.Retail.RetailModel.Purchase();
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
        public Win.Soft.Retail.RetailModel.Purchase DataRowToModel(DataRow row)
        {
            Win.Soft.Retail.RetailModel.Purchase model = new Win.Soft.Retail.RetailModel.Purchase();
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
                if (row["PurchaseDate"] != null && row["PurchaseDate"].ToString() != "")
                {
                    model.PurchaseDate = DateTime.Parse(row["PurchaseDate"].ToString());
                }
                if (row["ManufacturerID"] != null && row["ManufacturerID"].ToString() != "")
                {
                    model.ManufacturerID = int.Parse(row["ManufacturerID"].ToString());
                }
                if (row["Relation"] != null)
                {
                    model.Relation = row["Relation"].ToString();
                }
                if (row["Telephone"] != null)
                {
                    model.Telephone = row["Telephone"].ToString();
                }
                if (row["ReceiveAddress"] != null)
                {
                    model.ReceiveAddress = row["ReceiveAddress"].ToString();
                }
                if (row["Receiver"] != null)
                {
                    model.Receiver = row["Receiver"].ToString();
                }
                if (row["ReceiverPhone"] != null)
                {
                    model.ReceiverPhone = row["ReceiverPhone"].ToString();
                }
                if (row["EstimateDate"] != null && row["EstimateDate"].ToString() != "")
                {
                    model.EstimateDate = DateTime.Parse(row["EstimateDate"].ToString());
                }
                if (row["PurchaseCount"] != null && row["PurchaseCount"].ToString() != "")
                {
                    model.PurchaseCount = decimal.Parse(row["PurchaseCount"].ToString());
                }
                if (row["PurchaseAmount"] != null && row["PurchaseAmount"].ToString() != "")
                {
                    model.PurchaseAmount = decimal.Parse(row["PurchaseAmount"].ToString());
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
                if (row.Table.Columns.Contains("ManufacturerName") && row["ManufacturerName"] != null)
                    model.ManufacturerName = row["ManufacturerName"].ToString();
                if (row.Table.Columns.Contains("UnPayAmount") && row["UnPayAmount"] != null)
                    model.UnPayAmount = decimal.Parse(row["UnPayAmount"].ToString());
            }
            return model;
        }
        /// <summary>
        /// 将DataTable转Lists
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public List<Win.Soft.Retail.RetailModel.Purchase> DataTableToList(DataTable dt)
        {
            List<Win.Soft.Retail.RetailModel.Purchase> list = new List<RetailModel.Purchase>();
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(DataRowToModel(dr));
                }
            }
            catch
            {

            }
            return list;
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Code,PurchaseDate,ManufacturerID,Relation,Telephone,ReceiveAddress,Receiver,ReceiverPhone,EstimateDate,PurchaseCount,PurchaseAmount,Remark,CreateUserID,CreateDate,IsSubmit,SubmitDate ");
            strSql.Append(" FROM tb_Purchase ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM tb_Purchase ");
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
            strSql.Append(")AS Row, T.*  from tb_Purchase T ");
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
        /// 根据日期获取采购单列表
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public List<Win.Soft.Retail.RetailModel.Purchase> GetDataList(string StartDate, string EndDate)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(@"SELECT p.*,m.Name AS ManufacturerName FROM dbo.tb_Purchase p
                            INNER JOIN dbo.tb_Manufacturer m ON m.ID=p.ManufacturerID                      
                            LEFT JOIN dbo.tb_PayMentDetail pd ON pd.PurchaseID=p.ID AND pd.IsSettle=1
                            LEFT JOIN(SELECT SUM(PayAmount) AS PaiedAmount,PurchaseID FROM dbo.tb_PayMentDetail Group BY PurchaseID) hp ON hp.PurchaseID=p.ID");
                strSql.Append(" WHERE PurchaseDate BETWEEN '{0}' AND '{1}' ");
                strSql.Append(" ORDER BY PurchaseDate ASC ");
                DataTable dt = DbHelperSQL.Query(string.Format(strSql.ToString(), StartDate, EndDate)).Tables[0];
                return DataTableToList(dt);
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// 删除采购单
        /// </summary>
        /// <param name="Order"></param>
        /// <returns></returns>
        public bool DeletePurchaseOrder(Purchase Order)
        {
            List<string> list = new List<string>();
            list.Add("DELETE FROM dbo.tb_Purchase WHERE ID=" + Order.ID.ToString());
            list.Add("DELETE FROM dbo.tb_PurchaseDetail WHERE PurchaseID=" + Order.ID.ToString());
            try
            {
                if (DbHelperSQL.ExecuteSqlTran(list) > 0)
                    return true;
            }
            catch
            {
            }
            return false;
        }
        /// <summary>
        /// 保存采购数据
        /// </summary>
        /// <param name="Order"></param>
        /// <param name="OrderDetail"></param>
        /// <returns></returns>
        public bool SaveObject(Purchase Order, List<PurchaseDetail> OrderDetail)
        {
            try
            {
                if (Order.ID > 0)
                    Update(Order);
                else
                    Order.ID = Add(Order);
                PurchaseDetailDal DetailDal = new PurchaseDetailDal();
                string Ids = string.Empty;
                foreach (PurchaseDetail item in OrderDetail)
                {
                    if (item.ID > 0)
                        DetailDal.Update(item);
                    else
                    {
                        item.PurchaseID = Order.ID;
                        item.ID = DetailDal.Add(item);
                    }
                    Ids += item.ID.ToString() + ",";
                }
                if(!string.IsNullOrEmpty(Ids))
                {
                    DetailDal.DeleteNotInIDs(Order.ID, Ids.Substring(0, Ids.Length - 1));
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 获取未结清款项的采购单
        /// </summary>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public List<Purchase> GetUnPayPurchase(DateTime StartDate, DateTime EndDate)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT p.*,m.Name AS ManufacturerName,p.PurchaseAmount-ISNULL(hp.PaiedAmount,0) AS UnPayAmount FROM dbo.tb_Purchase p
                            INNER JOIN dbo.tb_Manufacturer m ON m.ID=p.ManufacturerID                      
                            LEFT JOIN dbo.tb_PayMentDetail pd ON pd.PurchaseID=p.ID AND pd.IsSettle=1
                            LEFT JOIN(SELECT SUM(PayAmount) AS PaiedAmount,PurchaseID FROM dbo.tb_PayMentDetail  Group BY PurchaseID) hp ON hp.PurchaseID=p.ID");
            strSql.Append(" WHERE pd.ID IS NULL AND PurchaseDate BETWEEN '{0}' AND '{1}' ");
            strSql.Append(" ORDER BY PurchaseDate ASC ");
            DataTable dt = DbHelperSQL.Query(string.Format(strSql.ToString(), StartDate, EndDate)).Tables[0];
            return DataTableToList(dt);
        }
        #endregion  ExtensionMethod
    }
}

