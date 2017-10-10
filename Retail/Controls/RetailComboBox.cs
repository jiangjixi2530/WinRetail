using System.ComponentModel;
using Win.Soft.Retail.RetailDal;

namespace Retail.Controls
{
    public class RetailComboBox : System.Windows.Forms.ComboBox
    {
        private DataSouceTypeEnum dataSouceType = DataSouceTypeEnum.User;
        public RetailComboBox()
        {
            this.DisplayMember = "Name";
            this.ValueMember = "ID";
        }
        protected override void CreateHandle()
        {
            base.CreateHandle();
        }
        /// <summary>
        /// 设置数据源
        /// </summary>
        [Description("数据源类型"), Category("自定义属性")]
        public DataSouceTypeEnum DataSouceType
        {
            get { return dataSouceType; }
            set
            {
                dataSouceType = value;
                if (this.IsHandleCreated)
                    SetDatasouce();
            }
        }
        /// <summary>
        /// 设置数据源
        /// </summary>
        private void SetDatasouce()
        {
            switch (DataSouceType)
            {
                case DataSouceTypeEnum.User:
                    SysUserDal dal = new SysUserDal();
                    this.DataSource = dal.GetComboBoxDataSource();
                    break;
                case DataSouceTypeEnum.Manufacturer:
                    ManufacturerDal manufacturerDal = new ManufacturerDal();
                    this.DataSource = manufacturerDal.GetList(" IsValid=1").Tables[0];
                    break;
                default:
                    break;
            }
        }
    }
    /// <summary>
    /// 数据源类型
    /// </summary>
    public enum DataSouceTypeEnum
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        User,
        /// <summary>
        /// 供应商
        /// </summary>
        Manufacturer,
    }
}
