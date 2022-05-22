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
            var smallParcels = order.Parcels.Where(p => p.ParcelType == ParcelType.Small)
                .OrderByDescending(p => p.TotalCost).ToList();            

            if (smallParcels.Any() && smallParcels.Count() >= appSettings.SmallParcelManiaNumber)
            {
                for (var i = 1; i <= smallParcels.Count()/appSettings.SmallParcelManiaNumber; i++)
                {
                    var index = (i * appSettings.SmallParcelManiaNumber) - 1;
                    smallParcels[index].IsDiscountApplied = true;
                    discounts.Add(new Discount 
                    { 
                        DiscountType = DiscountType.SmallParcelMania, Amount = smallParcels[index].TotalCost 
                    });
                }
            }

            var mediumParcels = order.Parcels.Where(p => p.ParcelType == ParcelType.Medium)
                .OrderByDescending(p => p.TotalCost).ToList();

            if (mediumParcels.Any() && mediumParcels.Count() >= appSettings.MediumParcelManiaNumber)
            {
                for (var i = 1; i <= mediumParcels.Count() / appSettings.MediumParcelManiaNumber; i++)
                {
                    var index = (i * appSettings.MediumParcelManiaNumber) - 1;
                    mediumParcels[index].IsDiscountApplied = true;
                    discounts.Add(new Discount
                    {
                        DiscountType = DiscountType.MediumParcelMania,
                        Amount = mediumParcels[index].TotalCost
                    });
                }
            }

            var remainingParcels = order.Parcels.Where(p => !p.IsDiscountApplied).OrderByDescending(p => p.TotalCost).ToList();

            if (remainingParcels.Any() && remainingParcels.Count() >= appSettings.MixedParcelManiaNumber)
            {
                for (var i = 1; i <= remainingParcels.Count() / appSettings.MixedParcelManiaNumber; i++)
                {
                    var index = (i * appSettings.MixedParcelManiaNumber) - 1;
                    remainingParcels[index].IsDiscountApplied = true;
                    discounts.Add(new Discount
                    {
                        DiscountType = DiscountType.MixedParcelMania,
                        Amount = remainingParcels[index].TotalCost
                    });
                }
            }

            if (discounts.Any())
            {
                order.Discounts = discounts;
            }

            return order;
        }
    }
}
