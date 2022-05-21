﻿
using FundApps.CourierKata.Enums;
using FundApps.CourierKata.Models;
using FundApps.CourierKata.Settings;

namespace FundApps.CourierKata.Extensions
{
    public static class ParcelExtensions
    {
        public static Parcel SetParcelType(this Parcel parcel, AppSettings appSettings)
        {
            if (parcel.LengthInCentimeters < appSettings.SmallParcelMaxDimension && 
                parcel.WidthInCentimeters < appSettings.SmallParcelMaxDimension && 
                parcel.HeightInCentimeters < appSettings.SmallParcelMaxDimension)
            {                
                parcel.ParcelType = ParcelType.Small;                
            }
            else if (parcel.LengthInCentimeters < appSettings.MediumParcelMaxDimension &&
                parcel.WidthInCentimeters < appSettings.MediumParcelMaxDimension &&
                parcel.HeightInCentimeters < appSettings.MediumParcelMaxDimension)
            {                
                parcel.ParcelType = ParcelType.Medium;
            }
            else if (parcel.LengthInCentimeters < appSettings.LargeParcelMaxDimension &&
                parcel.WidthInCentimeters < appSettings.LargeParcelMaxDimension &&
                parcel.HeightInCentimeters < appSettings.LargeParcelMaxDimension)
            {                
                parcel.ParcelType = ParcelType.Large;
            }
            else
            {                
                parcel.ParcelType = ParcelType.XL;
            }

            return parcel;
        }

        public static Parcel SetParcelCost(this Parcel parcel, AppSettings appSettings)
        {
            switch(parcel.ParcelType)
            {
                case ParcelType.Small:
                    parcel.BaseParcelCost = appSettings.SmallParcelCost;
                    parcel.ExtraWeightCost = (parcel.WeightInKilograms > appSettings.SmallParcelMaxWeight) ? 
                        (parcel.WeightInKilograms - appSettings.SmallParcelMaxWeight) * 2 : 0;
                    break;
                case ParcelType.Medium:
                    parcel.BaseParcelCost = appSettings.MediumParcelCost;
                    parcel.ExtraWeightCost = (parcel.WeightInKilograms > appSettings.MediumParcelMaxWeight) ?
                        (parcel.WeightInKilograms - appSettings.MediumParcelMaxWeight) * 2 : 0;
                    break;
                case ParcelType.Large:
                    parcel.BaseParcelCost = appSettings.LargeParcelCost;
                    parcel.ExtraWeightCost = (parcel.WeightInKilograms > appSettings.LargeParcelMaxWeight) ?
                        (parcel.WeightInKilograms - appSettings.LargeParcelMaxWeight) * 2 : 0;
                    break;
                case ParcelType.XL:
                    parcel.BaseParcelCost = appSettings.XlParcelCost;
                    parcel.ExtraWeightCost = (parcel.WeightInKilograms > appSettings.XlParcelMaxWeight) ?
                        (parcel.WeightInKilograms - appSettings.XlParcelMaxWeight) * 2 : 0;
                    break;
            }

            return parcel;
        }
    }
}
