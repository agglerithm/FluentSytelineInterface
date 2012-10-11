using System;
using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class ItemForecastIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = FromSyteline.ItemForecast.AvailQty.CreateDate.CreatedBy.ForecastDate.InWorkflow
                .Item.ItemDescription.ItemUOM.NoteExists.OrigQty.ProjectedDate.RecordDate.RowPointer.Status
                .UpdatedBy.Where.AvailQty.GreaterThan(0).And.CreateDate.LessThan(DateTime.Today)
                .And.CreatedBy.IsNotNull().And.ForecastDate.LessThan(DateTime.Today).And.InWorkflow.Eq(true)
                .And.Item.StartsWith("FIN").And.ItemDescription.IsNotNull().And.ItemUOM.Eq("EA").And
                .NoteExists.Eq(true).And.OrigQty.GreaterThan(0).And.ProjectedDate.LessThan(DateTime.Today)
                .And.RecordDate.LessThan(DateTime.Today).And.RowPointer.IsNotNull().And.Status
                .IsNotNull().And.UpdatedBy.IsNotNull();
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(ItemForecast.AvailQty).ShouldBeTrue();
            resp.ContainsField(ItemForecast.CreateDate).ShouldBeTrue();
            resp.ContainsField(ItemForecast.CreatedBy).ShouldBeTrue();
            resp.ContainsField(ItemForecast.ForecastDate).ShouldBeTrue();
            resp.ContainsField(ItemForecast.InWorkflow).ShouldBeTrue();
            resp.ContainsField(ItemForecast.Item).ShouldBeTrue();
            resp.ContainsField(ItemForecast.ItemDescription).ShouldBeTrue();
            resp.ContainsField(ItemForecast.ItemUOM).ShouldBeTrue();
            resp.ContainsField(ItemForecast.NoteExists).ShouldBeTrue();
            resp.ContainsField(ItemForecast.OrigQty).ShouldBeTrue();
            resp.ContainsField(ItemForecast.ProjectedDate).ShouldBeTrue();
            resp.ContainsField(ItemForecast.RecordDate).ShouldBeTrue();
            resp.ContainsField(ItemForecast.RowPointer).ShouldBeTrue();
            resp.ContainsField(ItemForecast.Status).ShouldBeTrue();
            resp.ContainsField(ItemForecast.UpdatedBy).ShouldBeTrue(); 

        }


        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
