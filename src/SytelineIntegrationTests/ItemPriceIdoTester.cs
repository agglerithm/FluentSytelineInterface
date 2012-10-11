using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class ItemPriceIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = FromSyteline.ItemPrice.Item.UnitPrice.BreakPrice1.BreakQty1.Where.Item.Contains("FIN").And.UnitPrice.GreaterThan(0);
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder); 
            resp.ContainsField(ItemPrice.Item).ShouldBeTrue();
            resp.ContainsField(ItemPrice.UnitPrice).ShouldBeTrue();
            resp.ContainsField(ItemPrice.BreakPrice1).ShouldBeTrue();
            resp.ContainsField(ItemPrice.BreakQty1).ShouldBeTrue();
        }


        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
