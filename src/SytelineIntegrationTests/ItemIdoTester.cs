using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class ItemIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = FromSyteline.Items.Item.OrderMultiple.UnitWeight.Description.UnitCost.UnitPrice.UoM.DaysSupply
                .Where.DaysSupply.GreaterThan(0)
                .And.Item.Contains("FIN").And.OrderMultiple.Eq("1").And.UnitCost.GreaterThan(0)
                .And.UnitWeight.GreaterThan(0).And.UoM.Eq("EA");
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(Items.DaysSupply).ShouldBeTrue();
            resp.ContainsField(Items.Description).ShouldBeTrue();
            resp.ContainsField(Items.Item).ShouldBeTrue();
            resp.ContainsField(Items.OrderMultiple).ShouldBeTrue();
            resp.ContainsField(Items.UnitCost).ShouldBeTrue();
            resp.ContainsField(Items.UnitPrice).ShouldBeTrue();
            resp.ContainsField(Items.UnitWeight).ShouldBeTrue();
            resp.ContainsField(Items.UoM).ShouldBeTrue(); 
        }
        

        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
