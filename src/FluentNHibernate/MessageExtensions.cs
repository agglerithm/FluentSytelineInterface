using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AFPST.Common.Extensions;

namespace ReportingMessages.Extensions
{
    public static class MessageExtensions
    {
        public static decimal GetQuantityOfType(this InventoryItem inv, QuantityType qType)
        {
            var qty = inv.Quantity.Find(q => q.Type == qType);
            return qty == null ? 0 : qty.Quantity;
        }
    }
}
