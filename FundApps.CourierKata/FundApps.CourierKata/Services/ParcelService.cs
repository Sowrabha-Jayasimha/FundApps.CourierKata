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
            else if (length < 50 && width < 50 && height < 50)
            {
                parcel.Cost = 8;
                parcel.ParcelType = ParcelType.Medium;
            }
            else if (length < 100 && width < 100 && height < 100)
            {
                parcel.Cost = 15;
                parcel.ParcelType = ParcelType.Large;
            }
            else
            {
                parcel.Cost = 25;
                parcel.ParcelType = ParcelType.XL;
            }           

            return parcel;
        }
    }
}
