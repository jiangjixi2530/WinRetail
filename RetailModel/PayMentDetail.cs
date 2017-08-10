using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public int PayMentID
        {
            set { _paymentid = value; }
            get { return _paymentid; }
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
        public decimal PaidAmount
        {
            set { _paidamount = value; }
            get { return _paidamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal PayableAmount
        {
            set { _payableamount = value; }
            get { return _payableamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal PayAmount
        {
            set { _payamount = value; }
            get { return _payamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsSettle
        {
            set { _issettle = value; }
            get { return _issettle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model

    }
}

