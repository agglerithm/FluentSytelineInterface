namespace SytelineIntegrationTests
{
    using Machine.Specifications;
    using NUnit.Framework;
    using SytelineInterface.Core;
    using SytelineInterface.Dsl;
    using SytelineInterface.Dsl.Commands;
    using SytelineInterface.Dsl.Queries;

    [TestFixture]
    public class JobsIdoTester
    {

        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = FromSyteline.Jobs.Job.JobDate;
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(Jobs.Job).ShouldBeTrue();
            resp.ContainsField(Jobs.JobDate).ShouldBeTrue();
        }

    }
}