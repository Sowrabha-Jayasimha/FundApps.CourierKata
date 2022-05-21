using FundApps.CourierKata.Models;
using FundApps.CourierKata.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FundApps.CourierKata.Tests
{
    [TestClass]
    public class OrderServiceTests
    {
        private IParcelService _parcelService;
        private OrderService _orderService;

        [TestInitialize]
        public void TestInitialize()
        {
            _parcelService = new ParcelService(TestHelper.GetAppSettings());
            _orderService = new OrderService();
        }

        [TestMethod]
        public void CreateOrder_WhenListOfParcelsAreGiven_ReturnsOrderWithCost()
        {
            //Arrange
            var parcels = new List<Parcel>
            {
                _parcelService.CreateParcel(3, 3, 3, 1),
                _parcelService.CreateParcel(14, 14, 14, 1)
            };

            //Act
            var order = _orderService.CreateOrder(parcels);

            //Assert
            Assert.IsNotNull(order);
            Assert.AreEqual(2, order.Parcels.Count);
            Assert.AreEqual(11, order.StandardShippingCost);
        }

        [TestMethod]
        public void CreateOrder_WhenSpeedyShipping_DoublesOrderCost()
        {
            //Arrange
            var parcels = new List<Parcel>
            {
                _parcelService.CreateParcel(3, 3, 3, 1),
                _parcelService.CreateParcel(14, 14, 14, 1),
                _parcelService.CreateParcel(60, 60, 60, 1)
            };

            //Act
            var order = _orderService.CreateOrder(parcels);

            //Assert
            Assert.IsNotNull(order);
            Assert.AreEqual(26, order.StandardShippingCost);
            Assert.AreEqual(52, order.SpeedyShippingCost);
        }
    }
}
