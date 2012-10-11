using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class InventoryIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = FromSyteline.Inventory.Item.TotalQtyOnHand.Warehouse.Where.Item.StartsWith("FIN").And
                .TotalQtyOnHand.GreaterThan(0).And.Warehouse.Eq("MAIN");
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(Inventory.Item).ShouldBeTrue();
            resp.ContainsField(Inventory.TotalQtyOnHand);
            resp.ContainsField(Inventory.Warehouse);
        }
 
        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
