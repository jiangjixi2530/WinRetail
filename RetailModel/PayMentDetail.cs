using System;

namespace Win.Soft.Retail.RetailModel
{
    /// <summary>
    /// PayMentDetail:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PayMentDetail
    {
        public PayMentDetail()
        { }
        #region Model
        private int _id;
        private int _paymentid;
        private int _purchaseid;
        private decimal _paidamount;
        private decimal _payableamount;
        private decimal _payamount;
        private bool _issettle;
        private string _remark;
        /// <summary>
        /// 主键
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 付款ID
        /// </summary>
        public int PayMentID
        {
            set { _paymentid = value; }
            get { return _paymentid; }
        }
        /// <summary>
        /// 采购ID
        /// </summary>
        public int PurchaseID
        {
            set { _purchaseid = value; }
            get { return _purchaseid; }
        }
        /// <summary>
        /// 已付金额
        /// </summary>
        public decimal PaidAmount
        {
            set { _paidamount = value; }
            get { return _paidamount; }
        }
        /// <summary>
        /// 应付金额
        /// </summary>
        public decimal PayableAmount
        {
            set { _payableamount = value; }
            get { return _payableamount; }
        }
        /// <summary>
        /// 实付金额
        /// </summary>
        public decimal PayAmount
        {
            set { _payamount = value; }
            get { return _payamount; }
        }
        /// <summary>
        /// 是否结清
        /// </summary>
        public bool IsSettle
        {
            set { _issettle = value; }
            get { return _issettle; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 采购单号
        /// </summary>
        public string PurchaseCode
        {
            get;
            set;
        }
        /// <summary>
        /// 采购日期
        /// </summary>
        public DateTime PurchaseDate
        {
            get;
            set;
        }
        /// <summary>
        /// 采购金额
        /// </summary>
        public decimal PurchaseAmount
        {
            set;
            get;
        }
        #endregion Model

    }
}

