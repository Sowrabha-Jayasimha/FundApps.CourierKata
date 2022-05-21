using FundApps.CourierKata.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        [DataRow(5, 5, 5, 3, ParcelType.Small)]
        [DataRow(30, 30, 30, 8, ParcelType.Medium)]
        [DataRow(50, 50, 50, 15, ParcelType.Large)]
        [DataRow(75, 75, 75, 15, ParcelType.Large)]
        [DataRow(175, 175, 175, 25, ParcelType.XL)]
        [DataRow(100, 100, 100, 25, ParcelType.XL)]
        public void CreateParcel_WhenDimentionsAreEntered_CreatesRightParcel(int length, int width, int height, 
            int expectedCost, ParcelType parcelType)
        {

            //Act 
            var parcel = _service.CreateParcel(length, width, height);

            //Assert
            Assert.AreEqual(parcelType, parcel.ParcelType);

            //Explicitly casting it here as DataRow cannot accept decimal type. 
            //Will have to look for another solution in real world situation
            Assert.AreEqual(Convert.ToDecimal(expectedCost), parcel.Cost);
        }
    }
}
