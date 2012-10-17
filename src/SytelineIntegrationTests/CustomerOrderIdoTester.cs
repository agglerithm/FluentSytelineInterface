

namespace SytelineIntegrationTests
{
    using System.Linq;
    
    using Machine.Specifications;
    using NUnit.Framework;
    using SytelineInterface.Core;
    using SytelineInterface.Dsl;
    using SytelineInterface.Dsl.Commands;
    using SytelineInterface.Dsl.Queries;
    [TestFixture]
    public class CustomerOrderIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetLiveIdoClient();
            _builder = CustomerOrder.GetFullProjectionWithCustomer()
                .Where<CustomerOrderCriteria>(o => o. OrderNumber =="2343543");
        }

        [Test, NUnit.Framework.Ignore] //This test sucks
        public void can_get_order_with_aggregates()
        {
            var builder =
                CustomerOrder.GetFullProjectionWithCustomerAndLineItems().WithMaxResults(1);


            var resp = _client.GetData(TestHelper.GetDallasTestSyteline(), builder); 

             resp.Records.First().Records.Count().ShouldBeGreaterThan(0);
           
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetDallasTestSyteline(), _builder); 
            resp.ContainsField(CustomerOrder.BillToAddress1).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.BillToAddress2).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.BillToCity).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.BillToContact).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrder.BillToName).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrder.BillToState).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.BillToZip).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrder.CustomerNumber).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.CustSeq).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.Discount).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.DiscountAmount).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.EndUserType).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrder.OrderDate).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.OrderNumber).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.OrderType).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.PONumber).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrder.ShipToCity).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.ShipToAddr1).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.ShipToAddr2).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrder.ShipToCode).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.ShipToCountry).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrder.ShipToName).ShouldBeTrue(); 
            resp.ContainsField(CustomerOrder.ShipToState).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.ShipToZip).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.TaxCode).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.TermsCode).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.TermsCodeDesc).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.TermsCodeDiscDays).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.TermsCodeDiscPct).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.TermsCodeDueDays).ShouldBeTrue();
            resp.ContainsField(CustomerOrder.Warehouse).ShouldBeTrue(); 
        }

        [Test]
        public void can_get_invoiced_order()
        {
            var location = TestHelper.GetTestSyteline();
            var  CustomerName = "WWT";
            var builder =FromSyteline.CustomerOrderLineItems.OrderNumber.CoOrderDate.ShipDate.QtyInvoiced.QtyOrdered.QtyShipped.Item.Description.CustomerPartNumber.QtyOrdered
                .Bol.Address1.Address2.AddressCity.AddressState.AddressZip.AddressName.Warehouse.LineNumber.CustomerNumber.Price.ExtendedPrice.Origin.ExtendedPrice.DerNetPrice.DerProgBillTotalBilled
                .Disc.CoPrice.CoStat.CustPo.Where<CustomerOrderLineItemCriteria>(l => l.QtyInvoiced > 0 && l.CustomerNumber == CustomerName)
                .WithChildren( 
                FromSyteline.InvoicedOrders.InvNum.InvSeq.OrderNumber.CustPo.CustomerID.Slsman.Terms.ShipDate
                .InvDate
                .Where<InvoicedOrdersCriteria>(i => i.OrderNumber != "" && i.CustomerID == CustomerName)
                 
                .LinkBy(InvoicedOrders.OrderNumber, CustomerOrderLineItem.OrderNumber));

            var resp = _client.GetData(location, builder); 
        }
        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
