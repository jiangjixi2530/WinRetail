using System;
namespace Win.Soft.Retail.Model.RetailModel
{
    /// <summary>
    /// tb_PayMent:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PayMent
    {
        public PayMent()
        { }
        #region Model
        private int _id;
        private string _code;
        private DateTime _paydate;
        private int _payerid;
        private int _manufacturerid;
        private decimal _payableamount;
        private decimal _payamount;
        private string _remark;
        private int _createuserid;
        private DateTime _createdate;
        private int _issubmit;
        private DateTime _submitdate;
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
        public string Code
        {
            set { _code = value; }
            get { return _code; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime PayDate
        {
            set { _paydate = value; }
            get { return _paydate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int PayerID
        {
            set { _payerid = value; }
            get { return _payerid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ManufacturerID
        {
            set { _manufacturerid = value; }
            get { return _manufacturerid; }
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
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CreateUserID
        {
            set { _createuserid = value; }
            get { return _createuserid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsSubmit
        {
            set { _issubmit = value; }
            get { return _issubmit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SubmitDate
        {
            set { _submitdate = value; }
            get { return _submitdate; }
        }
        #endregion Model

    }
}

