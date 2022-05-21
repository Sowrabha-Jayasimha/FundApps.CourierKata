using System.Collections.Generic;

namespace FundApps.CourierKata.Models
{
    public class Order
    {
        public List<Parcel> Parcels { get; set; }
        public decimal StandardShippingCost { get; set; }
        public decimal SpeedyShippingCost 
        { 
            get
            {
                return StandardShippingCost * 2;
            }
        }

    }
}
