using Retail.FinanceControls;

namespace Retail
{
    /// <summary>
    /// 产品点击事件委托
    /// </summary>
    /// <param name="sender"></param>
    public delegate void ProductItemClickEvent(ProductControls.ProductItem sender);
    /// <summary>
    /// 未结清账款单笔付款
    /// </summary>
    /// <param name="sender"></param>
    public delegate void SinglePayMentEvent(UnPayOrder sender);
    /// <summary>
    /// 未结清款项选择变化事件
    /// </summary>
    /// <param name="sender"></param>
    public delegate void UnPayOrderSelectChange(UnPayOrder sender);
    /// <summary>
    /// 加载框手动关闭
    /// </summary>
    public delegate void LoadingManualClosed(object sender);
}
