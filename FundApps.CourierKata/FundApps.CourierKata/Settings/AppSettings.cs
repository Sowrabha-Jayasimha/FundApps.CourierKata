namespace FundApps.CourierKata.Settings
{
    public class AppSettings
    {
        //Dimensions
        public int SmallParcelMaxDimension { get; set; }
        public int MediumParcelMaxDimension { get; set; }
        public int LargeParcelMaxDimension { get; set; }

        //Weights
        public int SmallParcelMaxWeight { get; set; }
        public int MediumParcelMaxWeight { get; set; }
        public int LargeParcelMaxWeight { get; set; }
        public int XlParcelMaxWeight { get; set; }
        public int HeavyParcelMinWeight { get; set; }
        public int HeavyParcelMaxWeight { get; set; }

        //Costs
        public decimal SmallParcelCost { get; set; }
        public decimal MediumParcelCost { get; set; }
        public decimal LargeParcelCost { get; set; }
        public decimal XlParcelCost { get; set; }
        public decimal OverweightCostPerKg { get; set; }
        public decimal HeavyParcelCost { get; set; }
        public decimal HeavyParcelOverweightCostPerKg { get; set; }
    }
}
