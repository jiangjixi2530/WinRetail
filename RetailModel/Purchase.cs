using System;
namespace Win.Soft.Retail.RetailModel
{
    /// <summary>
    /// Purchase:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Purchase
    {
        public Purchase()
        {
            _purchasedate = DateTime.Now;
        }
        #region Model
        private int _id;
        private string _code;
        private DateTime _purchasedate;
        private int _manufacturerid;
        private string _relation;
        private string _telephone;
        private string _receiveaddress;
        private string _receiver;
        private string _receiverphone;
        private DateTime _estimatedate;
        private decimal _purchasecount;
        private decimal _purchaseamount;
        private string _remark;
        private int _createuserid;
        private DateTime _createdate;
        private int _issubmit;
        private DateTime _submitdate;
        /// <summary>
        /// 主键
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 采购合同号
        /// </summary>
        public string Code
        {
            set { _code = value; }
            get { return _code; }
        }
        /// <summary>
        /// 采购日期
        /// </summary>
        public DateTime PurchaseDate
        {
            set { _purchasedate = value; }
            get { return _purchasedate; }
        }
        /// <summary>
        /// 供应商ID
        /// </summary>
        public int ManufacturerID
        {
            set { _manufacturerid = value; }
            get { return _manufacturerid; }
        }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string ManufacturerName
        {
            get;
            set;
        }
        /// <summary>
        /// 联系人
        /// </summary>
        public string Relation
        {
            set { _relation = value; }
            get { return _relation; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Telephone
        {
            set { _telephone = value; }
            get { return _telephone; }
        }
        /// <summary>
        /// 收货地址
        /// </summary>
        public string ReceiveAddress
        {
            set { _receiveaddress = value; }
            get { return _receiveaddress; }
        }
        /// <summary>
        /// 收货人
        /// </summary>
        public string Receiver
        {
            set { _receiver = value; }
            get { return _receiver; }
        }
        /// <summary>
        /// 收货人电话
        /// </summary>
        public string ReceiverPhone
        {
            set { _receiverphone = value; }
            get { return _receiverphone; }
        }
        /// <summary>
        /// 预计交货日期
        /// </summary>
        public DateTime EstimateDate
        {
            set { _estimatedate = value; }
            get { return _estimatedate; }
        }
        /// <summary>
        /// 采购数量
        /// </summary>
        public decimal PurchaseCount
        {
            set { _purchasecount = value; }
            get { return _purchasecount; }
        }
        /// <summary>
        /// 采购金额
        /// </summary>
        public decimal PurchaseAmount
        {
            set { _purchaseamount = value; }
            get { return _purchaseamount; }
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
        /// 建单人
        /// </summary>
        public int CreateUserID
        {
            set { _createuserid = value; }
            get { return _createuserid; }
        }
        /// <summary>
        /// 建单时间
        /// </summary>
        public DateTime CreateDate
        {
            set { _createdate = value; }
            get { return _createdate; }
        }
        /// <summary>
        /// 是否提交
        /// </summary>
        public int IsSubmit
        {
            set { _issubmit = value; }
            get { return _issubmit; }
        }
        /// <summary>
        /// 提交日期
        /// </summary>
        public DateTime SubmitDate
        {
            set { _submitdate = value; }
            get { return _submitdate; }
        }
        /// <summary>
        /// 建单人
        /// </summary>
        public string CreateUser
        {
            set;
            get;
        }
        /// <summary>
        /// 是否付款
        /// </summary>
        public bool IsPay
        {
            get;
            set;
        }
        /// <summary>
        /// 是否入库
        /// </summary>
        public bool IsStockIn
        {
            get;
            set;
        }
        /// <summary>
        /// 未付金额
        /// </summary>
        public decimal UnPayAmount
        {
            get;
            set;
        }
        #endregion Model

    }
}

