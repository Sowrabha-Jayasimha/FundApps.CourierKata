using FundApps.CourierKata.Models;
using System.Collections.Generic;
using System.Linq;

namespace FundApps.CourierKata.Services
{
    public class OrderService
    {
        public Order CreateOrder(List<Parcel> parcels)
        {
            var order = new Order
            {
                Parcels = parcels
            };

            order.StandardShippingCost = parcels.Sum(p => p.Cost);           

            return order;
        }
    }
}
