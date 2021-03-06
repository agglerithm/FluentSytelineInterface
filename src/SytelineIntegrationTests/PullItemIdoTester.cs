using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;
using Machine.Specifications;

namespace SytelineIntegrationTests
{
    using SytelineInterface.Dsl.Commands;

    [TestFixture]
    public class PullItemIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = FromSyteline.PullItem.Item.TriggerPoint.Warehouse.Where<PullItemCriteria>(x => x.Item.StartsWith("FIN")
                 &&  x.TriggerPoint != null  && x.Warehouse != null) ;
        }

        [Test, Explicit]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(PullItem.IDO_NAME).ShouldBeTrue();
            resp.ContainsField(PullItem.Item).ShouldBeTrue();
            resp.ContainsField(PullItem.TriggerPoint).ShouldBeTrue();
            resp.ContainsField(PullItem.Warehouse).ShouldBeTrue(); 
        }


        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
