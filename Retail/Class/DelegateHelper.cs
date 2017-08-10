﻿using Retail.FinanceControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
}
