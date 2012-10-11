using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class ShippedOrderIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = ShippedCustomerOrder.GetFullProjection() .WhereExp<ShippedCustomerOrderCriteria>(s => s.CustomerNumber != "" && s.OrderNumber != null)   ;
        }

        [Test, Explicit]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder); 
            resp.ContainsField(ShippedCustomerOrder.DateSeq).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrder.BOL).ShouldBeTrue();
            resp.ContainsField(ShippedCustomerOrder.CustomerNumber).ShouldBeTrue();  
            resp.ContainsField(ShippedCustomerOrder.Status).ShouldBeTrue(); 
        }


        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
