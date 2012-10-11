using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class ResponseWrapperValuesTester
    {
        private ISytelineIdoClient _client;
        private ItemsBuilder _builder;

        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = FromSyteline.Items.Item.OrderMultiple.UnitWeight.Description.UnitCost.UnitPrice.UoM.DaysSupply
                 ;
        }
        [SetUp]
        public void SetUpForEachTest()
        { 

        }

        [Test]
        public void can_add_values_to_table()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            var record = resp.Records.First();
            var tbl = record.AddRecordTo(null);
            Assert.That(tbl.Rows.Count == 1);
            Assert.That(resp.ContainsField(tbl.Columns[1].ColumnName));
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
