using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class CustomerPartNumberIdoTester
    {
        //
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = CustomerPartNumbers.GetFullProjection().Where.CustomerNumber.Eq("WWTI001").Or.CustomerNumber.Eq("WWTI002");
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(CustomerPartNumbers.CustomerNumber).ShouldBeTrue();
            resp.ContainsField(CustomerPartNumbers.CustomerPartNumber).ShouldBeTrue();
//            resp.ContainsField(CustomerPartNumbers.IDO_NAME).ShouldBeTrue();
            resp.ContainsField(CustomerPartNumbers.Item).ShouldBeTrue(); 
        }


        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}