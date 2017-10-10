using System;

namespace Win.Soft.Retail.RetailModel
{
    /// <summary>
    /// SysAutoCode:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class SysAutoCode
    {
        public SysAutoCode()
        { }
        #region Model
        private int _id;
        private string _prefix;
        private int _seriationlen;
        private string _autocodetype;
        private string _recentcode;
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
        public string Prefix
        {
            set { _prefix = value; }
            get { return _prefix; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SeriationLen
        {
            set { _seriationlen = value; }
            get { return _seriationlen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string AutoCodeType
        {
            set { _autocodetype = value; }
            get { return _autocodetype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RecentCode
        {
            set { _recentcode = value; }
            get { return _recentcode; }
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

