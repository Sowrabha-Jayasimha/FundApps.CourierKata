using FundApps.CourierKata.Enums;
using FundApps.CourierKata.Models;
using FundApps.CourierKata.Settings;
using System.Collections.Generic;
using System.Linq;

namespace FundApps.CourierKata.Extensions
{
    public static class OrderExtensions
    {
        public static Order SetDiscountForOrder(this Order order, AppSettings appSettings)
        {
            var discounts = new List<Discount>();
            var smallOrders = order.Parcels.Where(p => p.ParcelType == ParcelType.Small)
                .OrderByDescending(p => p.TotalCost).ToList();

            if(smallOrders.Any() && smallOrders.Count() >= appSettings.SmallParcelManiaNumber)
            {
                for (var i = 1; i <= smallOrders.Count()/appSettings.SmallParcelManiaNumber; i++)
                {
                    var index = (i * appSettings.SmallParcelManiaNumber) - 1;
                    smallOrders[index].IsDiscountApplied = true;
                    discounts.Add(new Discount 
                    { 
                        DiscountType = DiscountType.SmallParcelMania, Amount = smallOrders[index].TotalCost 
                    });
                }
            }

            if(discounts.Any())
            {
                order.Discounts = discounts;
            }

            return order;
        }
    }
}
