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
            _parcelService = new ParcelService();
            _orderService = new OrderService();
        }

        [TestMethod]
        public void CreateOrder_WhenListOfParcelsAreGiven_ReturnsOrderWithCost()
        {
            //Arrange
            var parcels = new List<Parcel>
            {
                _parcelService.CreateParcel(3, 3, 3),
                _parcelService.CreateParcel(14, 14, 14)
            };

            //Act
            var order = _orderService.CreateOrder(parcels);

            //Assert
            Assert.IsNotNull(order);
            Assert.AreEqual(2, order.Parcels.Count);
            Assert.AreEqual(11, order.TotalCost);
        }
    }
}
