using System.Linq; 
using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    using SytelineInterface.Common;

    [TestFixture]
    public class CustomerOrderLineItemTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        private const string OrderNumber = "A000123828";

        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            
            _builder = CustomerOrderLineItem.GetFullProjection().Where.LineNumber.Eq("1").And.OrderNumber.Eq(OrderNumber);
            
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder); 
            resp.ContainsField(CustomerOrderLineItem.CustomerNumber).ShouldBeTrue();
            resp.ContainsField(CustomerOrderLineItem.CustomerPartNumber).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrderLineItem.Description).ShouldBeTrue();  
            resp.ContainsField(CustomerOrderLineItem.InventoryFrequency).ShouldBeTrue();
            resp.ContainsField(CustomerOrderLineItem.Item).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrderLineItem.CustomerNumber).ShouldBeTrue();
            resp.ContainsField(CustomerOrderLineItem.CustomerPartNumber).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrderLineItem.Description).ShouldBeTrue();   
            resp.ContainsField(CustomerOrderLineItem.InventoryFrequency).ShouldBeTrue();
            resp.ContainsField(CustomerOrderLineItem.Item).ShouldBeTrue();
            resp.ContainsField(CustomerOrderLineItem.LineNumber).ShouldBeTrue();
            resp.ContainsField(CustomerOrderLineItem.OrderNumber).ShouldBeTrue();
            resp.ContainsField(CustomerOrderLineItem.Price).ShouldBeTrue();
            resp.ContainsField(CustomerOrderLineItem.QtyOrdered).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrderLineItem.ReleaseNumber).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrderLineItem.ShipSite).ShouldBeTrue();
            resp.ContainsField(CustomerOrderLineItem.Status).ShouldBeTrue();
            resp.ContainsField(CustomerOrderLineItem.UnitOfMeasure).ShouldBeTrue();
            resp.ContainsField(CustomerOrderLineItem.Warehouse).ShouldBeTrue(); 
 
        }


        [Test, Explicit]
        public void can_update_records_through_ido()
        {
            var testDescription = "test description:" + SystemTime.Now().Ticks;

            _client.UpdateCollection(TestHelper.GetTestSyteline(),
                                     ToSyteline.CustomerOrderLineItems.OrderNumber(OrderNumber).LineNumber("1").
                                         Description(testDescription),
                                     FromSyteline.CustomerOrderLineItems.Where.OrderNumber.Eq(OrderNumber).And.
                                         LineNumber.Eq("1"));


            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);

            resp.Records.First().GetValue(CustomerOrderLineItem.Description).ShouldEqual(testDescription);

        }


        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
