using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class ShipToAddressIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = ShipToAddress.GetFullProjection().Where.Address1.Contains("St").And.Address2.Eq("").And.Address2.IsNull()
                .And.Address4.IsNull().And.City.Eq("Austin").And.State.StartsWith("T")
                .And.Zip.NotEq("").And.CustID.Eq("WWTI001").And.CustSeq.NotEq("");
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(ShipToAddress.Address1).ShouldBeTrue();
            resp.ContainsField(ShipToAddress.Address2).ShouldBeTrue();
            resp.ContainsField(ShipToAddress.Address3).ShouldBeTrue();
            resp.ContainsField(ShipToAddress.Address4).ShouldBeTrue();
            resp.ContainsField(ShipToAddress.City).ShouldBeTrue();
            resp.ContainsField(ShipToAddress.Contact).ShouldBeTrue();
            resp.ContainsField(ShipToAddress.CustNum).ShouldBeTrue();
            resp.ContainsField(ShipToAddress.CustSeq).ShouldBeTrue(); 
            resp.ContainsField(ShipToAddress.State).ShouldBeTrue();
            resp.ContainsField(ShipToAddress.Zip).ShouldBeTrue(); 
        }


        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
