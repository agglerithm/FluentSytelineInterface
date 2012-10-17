namespace SytelineIntegrationTests
{
    using System;
    using System.Linq;
    using NUnit.Framework;
    using SytelineInterface.Core;
    using SytelineInterface.Core.impl;
    using SytelineInterface.Dsl;
    using SytelineInterface.Dsl.Commands;
    using SytelineInterface.Dsl.Queries;

    [TestFixture]
    public class CustItemTester
    {        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetLiveIdoClient();
            _builder =
                FromSyteline.CustomerPartNumbers.CustomerNumber.CustomerPartNumber 
                    .Item.Where<CustomerPartNumbersCriteria>(c => c .CustomerNumber =="WWTI001");
        }

        [Test]
        public void can_get_cust_item_records()
        {
            var resp = _client.GetList(TestHelper.GetLiveSyteline(), _builder, map).ToList();
            resp.ForEach(Console.WriteLine);
        }

        private string map(IdoItemWrapper arg)
        {
            return arg[CustomerPartNumbers.CustomerPartNumber].ToString();
        }
    }
}