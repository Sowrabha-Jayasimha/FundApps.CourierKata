using FundApps.CourierKata.Enums;

namespace FundApps.CourierKata.Models
{
    public class Parcel
    {
        public int LengthInCentimeters { get; set; }
        public int WidthInCentimeters { get; set; }
        public int HeightInCentimeters { get; set; }
        public int WeightInKilograms { get; set; }
        public ParcelType ParcelType { get; set; }
        public decimal BaseParcelCost { get; set; }
        public decimal ExtraWeightCost { get; set; }
        public decimal TotalCost 
        { 
            get
            {
                return BaseParcelCost + ExtraWeightCost;
            }
        }
    }
}
