namespace SytelineIntegrationTests
{

    using System;
    using System.Linq;
    using NUnit.Framework;
    using SytelineInterface.Core;
    using SytelineInterface.Core.impl;
    using SytelineInterface.Dsl;
    using SytelineInterface.Dsl.Queries;

    [TestFixture]
    public class InvoiceIdoLinkTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetLiveIdoClient();
            _builder = FromSyteline.InvoicedOrders.OrderNumber.InvNum.InvDate.ShipDate.WhereExp<InvoicedOrdersCriteria>(
                    i => i.CustomerID == "FEDE002" && i.OrderNumber != "")
                    .WithChildren(FromSyteline.ArTransactions.SalesTax.Amount.InvNum.Type
                    .WhereExp<IdoArTransactionCriteria>(i => i.Type == "I").LinkBy(InvoicedOrders.InvNum, IdoArTransaction.InvNum)
                    )
                    .WithChildren(FromSyteline.ArInvoices.SalesTax.Amount.LinkBy(InvoicedOrders.InvNum, ArInvoices.InvoiceNumber));
        }

 

        [Test]
        public void can_get_linked_records()
        { 
            var resp = _client.GetList(TestHelper.GetLiveSyteline(), _builder, map).ToList();
            resp.ForEach(Console.WriteLine);
        }

        private string map(IdoItemWrapper arg)
        {
            var tax = "";
            var taxInv = "";
            if (arg.Records.Where(r=> r.IdoName == ArInvoices.IDO_NAME).Count() > 0)
            {
                var rex = arg.Records.First();
                tax = rex[ArInvoices.SalesTax].ToString();
                taxInv = rex[ArInvoices.InvoiceNumber].ToString();
            }
            if (arg.Records.Where(r=> r.IdoName == IdoArTransaction.IDO_NAME).Count() > 0) 
            {
                var rex = arg.Records.First();
                tax = rex[IdoArTransaction.SalesTax].ToString();
                taxInv = rex[IdoArTransaction.InvNum].ToString();
            }
            return arg[InvoicedOrders.InvNum] + ":" + taxInv + ", " + tax;
        }
    }
}