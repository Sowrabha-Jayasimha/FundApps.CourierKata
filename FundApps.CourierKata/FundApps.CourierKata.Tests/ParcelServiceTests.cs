using FundApps.CourierKata.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FundApps.CourierKata.Tests
{
    [TestClass]
    public class ParcelServiceTests
    {
        private ParcelService _service;

        [TestInitialize]
        public void TestInitialize()
        {
            _service = new ParcelService();
        }

        [TestMethod]
        public void CreateParcel_WhenDimentionIs1Cm_CreateSmallParcel()
        {
            //Arrange
            int length = 1;
            int width = 1;
            int height = 1;            

            //Act
            var parcel = _service.CreateParcel(length, width, height);

            //Assert
            Assert.AreEqual(ParcelType.Small, parcel.ParcelType);
            Assert.AreEqual(3, parcel.Cost);
        }

        [TestMethod]
        public void CreateParcel_WhenDimentionIs20Cm_CreatesMediumParcel()
        {
            //Arrange
            int length = 20;
            int width = 20;
            int height = 20;

            //Act 
            var parcel = _service.CreateParcel(length, width, height);

            //Assert
            Assert.AreEqual(ParcelType.Medium, parcel.ParcelType);
            Assert.AreEqual(8, parcel.Cost);
        }
    }
}
