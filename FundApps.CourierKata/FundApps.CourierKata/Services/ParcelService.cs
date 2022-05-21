using FundApps.CourierKata.Extensions;
using FundApps.CourierKata.Models;

namespace FundApps.CourierKata.Services
{
    public class ParcelService : IParcelService
    {
        public Parcel CreateParcel(int length, int width, int height, int weight)
        {
            var parcel = new Parcel
            {
                LengthInCentimeters = length,
                WidthInCentimeters = width,
                HeightInCentimeters = height,
                WeightInKilograms = weight
            };

            parcel.SetParcelType();
            parcel.SetParcelCost();

            return parcel;
        }
    }
}
