namespace SytelineIntegrationTests
{
    using Machine.Specifications;
    using NUnit.Framework;
    using SytelineInterface.Core;
    using SytelineInterface.Dsl;
    using SytelineInterface.Dsl.Queries;

    [TestFixture]
    public class ArInvoicesIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [SetUp]
        public void setup()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder =
                FromSyteline.ArInvoices.InvoiceNumber.InvoiceDate.InvoiceTotal.SalesTax.WhereExp<ArInvoicesCriteria>(
                    i => i.OrderNumber != "");
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(ArInvoices.InvoiceNumber).ShouldBeTrue();
            resp.ContainsField(ArInvoices.InvoiceDate).ShouldBeTrue();
            resp.ContainsField(ArInvoices.SalesTax).ShouldBeTrue();
        }
    }
}