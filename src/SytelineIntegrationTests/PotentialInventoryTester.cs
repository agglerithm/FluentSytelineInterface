using System.Collections.Generic;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    using System.Linq;
    using SytelineInterface.Common.Extensions;
    using SytelineInterface.Dsl.Commands;

    [TestFixture]
    public class PotentialInventoryTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder =
                Items.GetFullProjection().WithChildren(FromSyteline.JobMaterials.Job.MatlQtyConv.Item.JobItem.Units.LinkBy(
                                                              Items.ItemSuffix, JobMaterials.Suffix).LinkBy(Items.Job, JobMaterials.Job)).Where<JobMaterialsCriteria>(x => x.Job != "");
        }
        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            var child  = get_first_child_with_children(resp);

        }

        private IdoItemWrapper get_first_child_with_children(LoadCollectionResponseWrapper resp)
        {
            var records = resp.Records;
            var num = 0;
            var found = false;
            IEnumerable<IdoItemWrapper>  children  = null;
            foreach (var record in records)
            {
                children = record.Records;
                return children.Find(wrapper => wrapper.Records.Count() > 0);
            }

            return null;
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
