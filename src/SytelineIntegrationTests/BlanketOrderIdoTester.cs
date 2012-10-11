namespace SytelineIntegrationTests
{
    using Machine.Specifications;
    using NUnit.Framework;
    using SytelineInterface.Core;
    using SytelineInterface.Dsl;
    using SytelineInterface.Dsl.Queries;

    [TestFixture]
    public class BlanketOrderIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = FromSyteline.BlanketOrderLine.OrderNumber.BlanketQty.Item.CustItem;

        }
        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(BlanketOrderLine.OrderNumber).ShouldBeTrue();
            resp.ContainsField(BlanketOrderLine.BlanketQty).ShouldBeTrue();
            resp.ContainsField(BlanketOrderLine.Item).ShouldBeTrue();
            resp.ContainsField(BlanketOrderLine.CustItem).ShouldBeTrue();
        }
    }
}