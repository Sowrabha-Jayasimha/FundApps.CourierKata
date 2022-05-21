using FundApps.CourierKata.Enums;
using FundApps.CourierKata.Services;
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
            _service = new ParcelService(TestHelper.GetAppSettings());
        }

        [TestMethod]
        public void CreateParcel_WhenDimentionIs1Cm_CreateSmallParcel()
        {
            //Arrange
            int length = 1;
            int width = 1;
            int height = 1;            

            //Act
            var parcel = _service.CreateParcel(length, width, height, 1);

            //Assert
            Assert.AreEqual(ParcelType.Small, parcel.ParcelType);
            Assert.AreEqual(3, parcel.TotalCost);
        }

        [TestMethod]
        [DataRow(5, 5, 5, 1, 3, 0, 3, ParcelType.Small)]
        [DataRow(7, 7, 7, 3, 3, 4, 7, ParcelType.Small)]
        [DataRow(30, 30, 30, 3, 8, 0, 8, ParcelType.Medium)]
        [DataRow(30, 30, 30, 6, 8, 6, 14, ParcelType.Medium)]
        [DataRow(50, 50, 50, 5, 15, 0, 15, ParcelType.Large)]
        [DataRow(75, 75, 75, 7, 15, 2, 17, ParcelType.Large)]
        [DataRow(175, 175, 175, 10, 25, 0, 25, ParcelType.XL)]
        [DataRow(100, 100, 100, 15, 25, 10, 35, ParcelType.XL)]
        public void CreateParcel_WhenDimentionsAreEntered_CreatesRightParcel(int length, int width, int height, int weight,
            int expectedBaseCost, int expectedExtraCost, int expectedTotalCost, ParcelType parcelType)
        {

            //Act 
            var parcel = _service.CreateParcel(length, width, height, weight);

            //Assert
            Assert.AreEqual(parcelType, parcel.ParcelType);

            //Explicitly casting it here as DataRow cannot accept decimal type. 
            //Will have to look for another solution in real world situation
            Assert.AreEqual(Convert.ToDecimal(expectedBaseCost), parcel.BaseParcelCost);
            Assert.AreEqual(Convert.ToDecimal(expectedExtraCost), parcel.ExtraWeightCost);
            Assert.AreEqual(Convert.ToDecimal(expectedTotalCost), parcel.TotalCost);
        }

        [TestMethod]
        public void CreateParcel_WhenSmallParcelIsMoreThan1Kg_AddAdditionalCharges()
        {
            //Arrange
            int length = 1; 
            int width = 1;
            int height = 1;
            int weight = 2;

            //Act           
            var parcel = _service.CreateParcel(length, width, height, weight);

            //Assert
            Assert.AreEqual(ParcelType.Small, parcel.ParcelType);
            Assert.AreEqual(5, parcel.TotalCost);

        }
    }
}
