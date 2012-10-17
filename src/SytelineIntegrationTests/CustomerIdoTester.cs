using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    using SytelineInterface.Dsl.Commands;

    [TestFixture]
    public class CustomerIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = FromSyteline.Customers.Address1.Address2.BalMethod.BankCode.BranchId.City.Zip
                .Contact.Contact2.Country.County.Currency.CustomerNumber
                .CustomerSequence.CustType.Delterm.DoInvoice.EndUserType
            .InvCategory.InvFreq.Name 
            .RowPointer.ShipCode.Slsman.State
            .TaxCode.TaxRegNum.TermsCode.TerritoryCode.Whse.Where<CustomersCriteria>(c => c .CustomerNumber.StartsWith("WWT"));
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(Customers.Address1).ShouldBeTrue();
            resp.ContainsField(Customers.Address2).ShouldBeTrue(); 
            resp.ContainsField(Customers.BalMethod).ShouldBeTrue();
            resp.ContainsField(Customers.BankCode).ShouldBeTrue();
            resp.ContainsField(Customers.BranchId).ShouldBeTrue();
            resp.ContainsField(Customers.City).ShouldBeTrue();
            resp.ContainsField(Customers.Contact).ShouldBeTrue();
            resp.ContainsField(Customers.Contact2).ShouldBeTrue();
            resp.ContainsField(Customers.Country).ShouldBeTrue();
            resp.ContainsField(Customers.County).ShouldBeTrue();
            resp.ContainsField(Customers.Currency).ShouldBeTrue();
            resp.ContainsField(Customers.CustomerNumber).ShouldBeTrue();
            resp.ContainsField(Customers.CustomerSequence).ShouldBeTrue();
            resp.ContainsField(Customers.CustType).ShouldBeTrue();
            resp.ContainsField(Customers.Delterm).ShouldBeTrue();
            resp.ContainsField(Customers.DoInvoice).ShouldBeTrue();
            resp.ContainsField(Customers.EndUserType).ShouldBeTrue();
            resp.ContainsField(Customers.InvCategory).ShouldBeTrue();
            resp.ContainsField(Customers.InvFreq).ShouldBeTrue();
            resp.ContainsField(Customers.Name).ShouldBeTrue();
            resp.ContainsField(Customers.ShipCode).ShouldBeTrue();
            resp.ContainsField(Customers.Slsman).ShouldBeTrue();
            resp.ContainsField(Customers.State).ShouldBeTrue();
            resp.ContainsField(Customers.TaxCode).ShouldBeTrue();
            resp.ContainsField(Customers.TaxRegNum).ShouldBeTrue();
            resp.ContainsField(Customers.TermsCode).ShouldBeTrue();
            resp.ContainsField(Customers.TerritoryCode).ShouldBeTrue();
            resp.ContainsField(Customers.Whse).ShouldBeTrue();
            resp.ContainsField(Customers.Zip).ShouldBeTrue(); 

        }


        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
