using System.Linq;
using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories;
using SytelineInterface.Factories.impl;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class LoadCollectionTester
    {
        private ISytelineIdoClient _client;

        [TestFixtureSetUp]
        public void SetUp()
        {
            var loadFactory = new LoadCollectionRequestFactory();
            _client = new SytelineIdoClient(TestHelper.GetTestClientWrapper(), 
                loadFactory ,
                new UpdateCollectionRequestFactory(),
                new MethodRequestFactory(),
                new UserSessionService()); 
        }

        [Test]
        public void can_get_results()
        {
            var results =
                _client.GetData(TestHelper.GetTestSyteline(),FromSyteline.CustomerOrder.OrderNumber.PONumber.Where.CustomerNumber.Eq("WWTI001").WithChildren(
                                    FromSyteline.CustomerOrderLineItems.Item.LineNumber.QtyOrdered.
                                    LinkBy( CustomerOrder.OrderNumber, CustomerOrderLineItem.OrderNumber)));
            results.ShouldNotBeNull();
            results.Records.Count().ShouldBeGreaterThan(0);
            var children = results.Records.First();
            children.ShouldNotBeNull(); 
        }
 
    }
}
