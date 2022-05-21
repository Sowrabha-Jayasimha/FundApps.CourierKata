
using FundApps.CourierKata.Enums;
using FundApps.CourierKata.Models;

namespace FundApps.CourierKata.Extensions
{
    public static class ParcelExtensions
    {
        public static Parcel SetParcelType(this Parcel parcel)
        {
            if (parcel.LengthInCentimeters < 10 && parcel.WidthInCentimeters < 10 && parcel.HeightInCentimeters < 10)
            {                
                parcel.ParcelType = ParcelType.Small;                
            }
            else if (parcel.LengthInCentimeters < 50 && parcel.WidthInCentimeters < 50 && parcel.HeightInCentimeters < 50)
            {                
                parcel.ParcelType = ParcelType.Medium;
            }
            else if (parcel.LengthInCentimeters < 100 && parcel.WidthInCentimeters < 100 && parcel.HeightInCentimeters < 100)
            {                
                parcel.ParcelType = ParcelType.Large;
            }
            else
            {                
                parcel.ParcelType = ParcelType.XL;
            }

            return parcel;
        }

        public static Parcel SetParcelCost(this Parcel parcel)
        {
            switch(parcel.ParcelType)
            {
                case ParcelType.Small:
                    parcel.BaseParcelCost = 3;
                    parcel.ExtraWeightCost = (parcel.WeightInKilograms > 1) ? 
                        (parcel.WeightInKilograms - 1) * 2 : 0;
                    break;
                case ParcelType.Medium:
                    parcel.BaseParcelCost = 8;
                    parcel.ExtraWeightCost = (parcel.WeightInKilograms > 3) ?
                        (parcel.WeightInKilograms - 3) * 2 : 0;
                    break;
                case ParcelType.Large:
                    parcel.BaseParcelCost = 15;
                    parcel.ExtraWeightCost = (parcel.WeightInKilograms > 6) ?
                        (parcel.WeightInKilograms - 6) * 2 : 0;
                    break;
                case ParcelType.XL:
                    parcel.BaseParcelCost = 25;
                    parcel.ExtraWeightCost = (parcel.WeightInKilograms > 10) ?
                        (parcel.WeightInKilograms - 10) * 2 : 0;
                    break;
            }

            return parcel;
        }
    }
}
