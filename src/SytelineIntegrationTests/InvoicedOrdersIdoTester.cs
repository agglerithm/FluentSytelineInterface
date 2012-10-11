using System;
using System.Linq;
using Machine.Specifications;
using Mongoose.IDO.Protocol;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class InvoicedOrdersIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = InvoicedOrders.GetFullProjectionWithLineItems().Where.Amount.GreaterThan(0)
                .And.BillType.Contains("A")
                .And.InvDate.GreaterThan(DateTime.Parse("1/1/2009"))
                .And.InvDate.LessThan(DateTime.Today).And.InvNum.NotEq(string.Empty).And.InvSeq.Eq("0"); 
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(InvoicedOrders.Amount).ShouldBeTrue();
            resp.ContainsField(InvoicedOrders.BillType).ShouldBeTrue();
            resp.ContainsField(InvoicedOrders.CustomerID).ShouldBeTrue();
            resp.ContainsField(InvoicedOrders.CustomerPo).ShouldBeTrue();
            resp.ContainsField(InvoicedOrders.DeliveryNumber).ShouldBeTrue(); 
            resp.ContainsField(InvoicedOrders.Freight).ShouldBeTrue();
            resp.ContainsField(InvoicedOrders.InvDate).ShouldBeTrue();
            resp.ContainsField(InvoicedOrders.InvNum).ShouldBeTrue();
            resp.ContainsField(InvoicedOrders.InvSeq).ShouldBeTrue();
            resp.ContainsField(InvoicedOrders.OrderNumber).ShouldBeTrue();
            resp.ContainsField(InvoicedOrders.RecordDate).ShouldBeTrue();
            resp.ContainsField(InvoicedOrders.RowPointer).ShouldBeTrue(); 
            resp.ContainsField(InvoicedOrders.Slsman).ShouldBeTrue();
            resp.ContainsField(InvoicedOrders.TermsCode).ShouldBeTrue();
            resp.Records.Count().ShouldBeGreaterThan(0);
        }

 
        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
