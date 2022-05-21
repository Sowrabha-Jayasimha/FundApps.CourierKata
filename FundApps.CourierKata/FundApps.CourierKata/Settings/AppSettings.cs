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

        //Costs
        public decimal SmallParcelCost { get; set; }
        public decimal MediumParcelCost { get; set; }
        public decimal LargeParcelCost { get; set; }
        public decimal XlParcelCost { get; set; }
    }
}
