using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class IdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetIdoClient();
            _builder = null;
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetAustinSyteline(), _builder);
        }
  

        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
