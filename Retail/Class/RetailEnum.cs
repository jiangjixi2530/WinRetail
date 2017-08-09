using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retail.Class
{
    /// <summary>
    /// 订单类型
    /// </summary>
    public enum OrderType
    {
        /// <summary>
        /// 采购订单
        /// </summary>
        Purchase,
        /// <summary>
        /// 下单合同
        /// </summary>
        Order,
    }
    /// <summary>
    /// 分页类型
    /// </summary>
    public enum PageMethodEnum
    {
        /// <summary>
        /// 显示的每个控件大小统一，无异形
        /// 分页计算方法按照控件大小批量计算
        /// 优点：分页计算速度和加载速度快
        /// </summary>
        Normal,
        /// <summary>
        /// 显示的每个控件大小不确定（存在多列情况，高度只能相同，单列高度可不同）
        /// 根据每个控件所占面积进行分页
        /// 每次分页需要遍历，计算速度和加载速度有一定迟缓
        /// </summary>
        Single,
    }
}
