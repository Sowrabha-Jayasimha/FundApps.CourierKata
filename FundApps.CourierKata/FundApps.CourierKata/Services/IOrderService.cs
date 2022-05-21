using FundApps.CourierKata.Models;
using System.Collections.Generic;

namespace FundApps.CourierKata.Services
{
    public interface IOrderService
    {
        Order CreateOrder(List<Parcel> parcels);
    }
}
