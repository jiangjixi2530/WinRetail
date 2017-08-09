using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using Win.Soft.Retail.RetailModel;
namespace Win.Soft.Retail.RetailDal
{
	/// <summary>
	/// 数据访问类:Product
	/// </summary>
	public partial class ProductDal
	{
        public ProductDal()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "tb_Product"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tb_Product");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Win.Soft.Retail.RetailModel.Product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tb_Product(");
			strSql.Append("Code,Name,ProductSpec,TypeID,Manufacturer,UnitID,SalePrice,CostPrice,IsValid,CreateUserID,CreateDate)");
			strSql.Append(" values (");
			strSql.Append("@Code,@Name,@ProductSpec,@TypeID,@Manufacturer,@UnitID,@SalePrice,@CostPrice,@IsValid,@CreateUserID,@CreateDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Code", SqlDbType.VarChar,100),
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@ProductSpec", SqlDbType.VarChar,500),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@Manufacturer", SqlDbType.VarChar,100),
					new SqlParameter("@UnitID", SqlDbType.Int,4),
					new SqlParameter("@SalePrice", SqlDbType.Decimal,9),
					new SqlParameter("@CostPrice", SqlDbType.Decimal,9),
					new SqlParameter("@IsValid", SqlDbType.Int,4),
					new SqlParameter("@CreateUserID", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime)};
			parameters[0].Value = model.Code;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.ProductSpec;
			parameters[3].Value = model.TypeID;
			parameters[4].Value = model.Manufacturer;
			parameters[5].Value = model.UnitID;
			parameters[6].Value = model.SalePrice;
			parameters[7].Value = model.CostPrice;
			parameters[8].Value = model.IsValid;
			parameters[9].Value = model.CreateUserID;
			parameters[10].Value = model.CreateDate;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(Win.Soft.Retail.RetailModel.Product model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tb_Product set ");
			strSql.Append("Code=@Code,");
			strSql.Append("Name=@Name,");
			strSql.Append("ProductSpec=@ProductSpec,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("Manufacturer=@Manufacturer,");
			strSql.Append("UnitID=@UnitID,");
			strSql.Append("SalePrice=@SalePrice,");
			strSql.Append("CostPrice=@CostPrice,");
			strSql.Append("IsValid=@IsValid,");
			strSql.Append("CreateUserID=@CreateUserID,");
			strSql.Append("CreateDate=@CreateDate");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Code", SqlDbType.VarChar,100),
					new SqlParameter("@Name", SqlDbType.VarChar,200),
					new SqlParameter("@ProductSpec", SqlDbType.VarChar,500),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@Manufacturer", SqlDbType.VarChar,100),
					new SqlParameter("@UnitID", SqlDbType.Int,4),
					new SqlParameter("@SalePrice", SqlDbType.Decimal,9),
					new SqlParameter("@CostPrice", SqlDbType.Decimal,9),
					new SqlParameter("@IsValid", SqlDbType.Int,4),
					new SqlParameter("@CreateUserID", SqlDbType.Int,4),
					new SqlParameter("@CreateDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Code;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.ProductSpec;
			parameters[3].Value = model.TypeID;
			parameters[4].Value = model.Manufacturer;
			parameters[5].Value = model.UnitID;
			parameters[6].Value = model.SalePrice;
			parameters[7].Value = model.CostPrice;
			parameters[8].Value = model.IsValid;
			parameters[9].Value = model.CreateUserID;
			parameters[10].Value = model.CreateDate;
			parameters[11].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_Product ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tb_Product ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Win.Soft.Retail.RetailModel.Product GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Code,Name,ProductSpec,TypeID,Manufacturer,UnitID,SalePrice,CostPrice,IsValid,CreateUserID,CreateDate from tb_Product ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Win.Soft.Retail.RetailModel.Product model=new Win.Soft.Retail.RetailModel.Product();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Win.Soft.Retail.RetailModel.Product DataRowToModel(DataRow row)
		{
			Win.Soft.Retail.RetailModel.Product model=new Win.Soft.Retail.RetailModel.Product();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Code"]!=null)
				{
					model.Code=row["Code"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["ProductSpec"]!=null)
				{
					model.ProductSpec=row["ProductSpec"].ToString();
				}
				if(row["TypeID"]!=null && row["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(row["TypeID"].ToString());
				}
				if(row["Manufacturer"]!=null)
				{
					model.Manufacturer=row["Manufacturer"].ToString();
				}
				if(row["UnitID"]!=null && row["UnitID"].ToString()!="")
				{
					model.UnitID=int.Parse(row["UnitID"].ToString());
				}
				if(row["SalePrice"]!=null && row["SalePrice"].ToString()!="")
				{
					model.SalePrice=decimal.Parse(row["SalePrice"].ToString());
				}
				if(row["CostPrice"]!=null && row["CostPrice"].ToString()!="")
				{
					model.CostPrice=decimal.Parse(row["CostPrice"].ToString());
				}
				if(row["IsValid"]!=null && row["IsValid"].ToString()!="")
				{
					model.IsValid=int.Parse(row["IsValid"].ToString());
				}
				if(row["CreateUserID"]!=null && row["CreateUserID"].ToString()!="")
				{
					model.CreateUserID=int.Parse(row["CreateUserID"].ToString());
				}
				if(row["CreateDate"]!=null && row["CreateDate"].ToString()!="")
				{
					model.CreateDate=DateTime.Parse(row["CreateDate"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Code,Name,ProductSpec,TypeID,Manufacturer,UnitID,SalePrice,CostPrice,IsValid,CreateUserID,CreateDate ");
			strSql.Append(" FROM tb_Product ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,Code,Name,ProductSpec,TypeID,Manufacturer,UnitID,SalePrice,CostPrice,IsValid,CreateUserID,CreateDate ");
			strSql.Append(" FROM tb_Product ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM tb_Product ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from tb_Product T ");
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
			parameters[0].Value = "tb_Product";
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
        /// <summary>
        /// DataTable转List
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public List<Product> DataTableToList(DataTable dt)
        {
            List<Product> list = new List<Product>();
            foreach (DataRow dr in dt.Rows)
                list.Add(DataRowToModel(dr));
            return list;
        }
		#endregion  ExtensionMethod
	}
}

