using System.Collections.Generic;
using System.Linq;

namespace FundApps.CourierKata.Models
{
    public class Order
    {
        public List<Parcel> Parcels { get; set; }
        public decimal BaseParcelCost
        {
            get
            {
                return Parcels == null ? 0 : Parcels.Sum(p => p.TotalCost);
            }
        }
        public List<Discount> Discounts { get; set; }
        public decimal DiscountApplied 
        {
            get
            {
                return Discounts == null ? 0 : Discounts.Sum(d => d.Amount);
            }
        }        
        public decimal StandardShippingCost 
        { 
            get
            {
                return BaseParcelCost - DiscountApplied;
            }
        }
        public decimal SpeedyShippingCost 
        { 
            get
            {
                return StandardShippingCost * 2;
            }
        }

    }
}
