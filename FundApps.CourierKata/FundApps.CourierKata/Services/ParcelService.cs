using FundApps.CourierKata.Extensions;
using FundApps.CourierKata.Models;
using FundApps.CourierKata.Settings;

namespace FundApps.CourierKata.Services
{
    public class ParcelService : IParcelService
    {
        private readonly AppSettings _appSettings;
        public ParcelService(AppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        public Parcel CreateParcel(int length, int width, int height, int weight)
        {
            var parcel = new Parcel
            {
                LengthInCentimeters = length,
                WidthInCentimeters = width,
                HeightInCentimeters = height,
                WeightInKilograms = weight
            };

            parcel.SetParcelType(_appSettings);
            parcel.SetParcelCost(_appSettings);

            return parcel;
        }
    }
}
