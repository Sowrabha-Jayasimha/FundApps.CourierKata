using FundApps.CourierKata.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FundApps.CourierKata.Tests
{
    [TestClass]
    public class ParcelServiceTests
    {
        [TestMethod]
        public void CreateParcel_WhenDimentionIs1Cm_CreateSmallParcel()
        {
            //Arrange
            int length = 1;
            int width = 1;
            int height = 1;

            var service = new ParcelService();

            //Act
            var parcel = service.CreateParcel(length, width, height);

            //Assert
            Assert.AreEqual(ParcelType.Small, parcel.ParcelType);
            Assert.AreEqual(3, parcel.Cost);
        }        
    }
}
