using System;
namespace Win.Soft.Retail.RetailModel
{
    /// <summary>
    /// PurchaseDetail:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PurchaseDetail
    {
        public PurchaseDetail()
        { }
        #region Model
        private int _id;
        private int _purchaseid;
        private int _productid;
        private decimal _purchasecount;
        private int _purchaseunitid;
        private decimal _purchaseprice;
        private decimal _purchaseamount;
        private string _remark;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int PurchaseID
        {
            set { _purchaseid = value; }
            get { return _purchaseid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ProductID
        {
            set { _productid = value; }
            get { return _productid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal PurchaseCount
        {
            set { _purchasecount = value; }
            get { return _purchasecount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int PurchaseUnitID
        {
            set { _purchaseunitid = value; }
            get { return _purchaseunitid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal PurchasePrice
        {
            set { _purchaseprice = value; }
            get { return _purchaseprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal PurchaseAmount
        {
            set { _purchaseamount = value; }
            get { return _purchaseamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 产品编号
        /// </summary>
        public string ProductCode
        {
            get;
            set;
        }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName
        {
            get;
            set;
        }
        #endregion Model

    }
}

