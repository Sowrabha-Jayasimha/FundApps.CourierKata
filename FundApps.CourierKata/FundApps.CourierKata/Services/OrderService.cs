using FundApps.CourierKata.Extensions;
using FundApps.CourierKata.Models;
using FundApps.CourierKata.Settings;
using System.Collections.Generic;

namespace FundApps.CourierKata.Services
{
    public class OrderService
    {
        private readonly AppSettings _appSettings;
        public OrderService(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }
        public Order CreateOrder(List<Parcel> parcels)
        {
            var order = new Order
            {
                Parcels = parcels
            };

            order.SetDiscountForOrder(_appSettings);

            return order;
        }
    }
}
