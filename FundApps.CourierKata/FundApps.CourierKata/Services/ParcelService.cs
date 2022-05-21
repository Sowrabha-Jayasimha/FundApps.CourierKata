using FundApps.CourierKata.Enums;
using FundApps.CourierKata.Models;
using System;

namespace FundApps.CourierKata
{
    public class ParcelService
    {
        public Parcel CreateParcel(int length, int width, int height)
        {
            var parcel = new Parcel
            {
                LengthInCentimeters = length,
                WidthInCentimeters = width,
                HeightInCentimeters = height
            };

            if (length < 10 && width < 10 && height < 10)
            {                
                parcel.Cost = 3;
                parcel.ParcelType = ParcelType.Small;
            }

            return parcel;
        }
    }
}
