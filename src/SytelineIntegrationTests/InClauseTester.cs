using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    using SytelineInterface.Dsl.Commands;

    [TestFixture]
    public class InClauseTester
    {
 
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
        }

        private IEnumerable<string> get_orders()
        {
            return new List<string>
                       {
                           "003534",
                           "0035342",
                           "2545434"
                       };
        }

        [Test]
        public void can_send_string_request()
        {
            _builder = CustomerOrder.GetFullProjectionWithCustomer().Where<CustomerOrderCriteria>( o => this.get_orders().Contains(o.OrderNumber));
            _client.GetList<CustomerOrder>(TestHelper.GetTestSyteline(), _builder, map);
        }

        [Test]
        public void can_send_date_request()
        {
            _builder = CustomerOrder.GetFullProjectionWithCustomer().Where<CustomerOrderCriteria>(o =>  get_dates().Contains(o.OrderDate));
            _client.GetList<CustomerOrder>(TestHelper.GetTestSyteline(), _builder, map);
        }

        private IEnumerable<DateTime>  get_dates()
        {
            return new List<DateTime>
                       {
                           DateTime.Today,
                           DateTime.Today.AddDays(1),
                           DateTime.Today.AddDays(-1)
                       };
        }

        private CustomerOrder map(IdoItemWrapper arg)
        {
            return new CustomerOrder();
        }

        [TearDown]
        public void TearDownForEachTest()
        {

        }

        [TestFixtureTearDown]
        public void TearDownAfterAllTests()
        {

        }
    }
}
