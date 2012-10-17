using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    using SytelineInterface.Dsl.Commands;

    [TestFixture]
    public class SitesIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = FromSyteline.Sites.Description.Site.SiteName.Where<SitesCriteria>(x => x.Site != null
                 && x.SiteName == "AUS"  && x.Description.Contains("Austin"));
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(Sites.Description).ShouldBeTrue(); 
            resp.ContainsField(Sites.Site).ShouldBeTrue();
            resp.ContainsField(Sites.SiteName).ShouldBeTrue();
        }


        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
