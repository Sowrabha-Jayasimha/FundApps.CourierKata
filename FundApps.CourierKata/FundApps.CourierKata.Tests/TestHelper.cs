using FundApps.CourierKata.Settings;

namespace FundApps.CourierKata.Tests
{
    public static class TestHelper
    {
        public static AppSettings GetAppSettings()
        {
            return new AppSettings
            {
                SmallParcelMaxDimension = 10,
                MediumParcelMaxDimension = 50,
                LargeParcelMaxDimension = 100,
                SmallParcelMaxWeight = 1,
                MediumParcelMaxWeight = 3,
                LargeParcelMaxWeight = 6,
                XlParcelMaxWeight = 10,
                SmallParcelCost = 3,
                MediumParcelCost = 8,
                LargeParcelCost = 15,
                XlParcelCost = 25,
                OverweightCostPerKg = 2,
                HeavyParcelCost = 50,
                HeavyParcelMinWeight = 30,
                HeavyParcelMaxWeight = 50,
                HeavyParcelOverweightCostPerKg = 1
            };
        }
    }
}
