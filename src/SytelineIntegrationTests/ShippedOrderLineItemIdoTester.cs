using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    using SytelineInterface.Dsl.Commands;

    [TestFixture]
    public class ShippedOrderLineItemIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = ShippedCustomerOrderLineItem.GetFullProjection()
                .Where.LineNumber.Eq("1").And.OrderNumber.NotEq("").And.QtyShipped.GreaterThan(0);
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder); 
            resp.ContainsField(ShippedCustomerOrderLineItem.Cost).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.CoType).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.CustomerID).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.CustomerPartNumber).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.CustomerPo).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.Description).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.DoLine).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.DoNum).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.DoSeq).ShouldBeTrue(); 
            resp.ContainsField(ShippedCustomerOrderLineItem.ItemID).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.LineNumber).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.OrderNumber).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.Price).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.QtyShipped).ShouldBeTrue(); 
            resp.ContainsField(ShippedCustomerOrderLineItem.ShipDate).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrderLineItem.ShipperNum).ShouldBeTrue(); 
        }


        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }

 
}
