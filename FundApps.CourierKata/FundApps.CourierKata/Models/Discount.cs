
using FundApps.CourierKata.Enums;
using System.Collections.Generic;

namespace FundApps.CourierKata.Models
{
    public class Discount
    {
        public DiscountType DiscountType { get; set; }
        public decimal Amount { get; set; }
    }
}
