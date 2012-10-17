using System;
using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    using SytelineInterface.Dsl.Commands;

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
                .UpdatedBy.Where<ItemForecastCriteria>(f => f.AvailQty > 0 && f.CreateDate < DateTime.Today 
                 && f.CreatedBy != null && f.ForecastDate < DateTime.Today  && f.InWorkflow == true 
                 && f.Item.StartsWith("FIN") && f.ItemDescription != null  && f.ItemUOM == "EA" &&
                f.NoteExists == true  && f.OrigQty > 0 && f.ProjectedDate < DateTime.Today 
                 && f.RecordDate < DateTime.Today && f.RowPointer != null  && f.Status
                 != null  && f.UpdatedBy != null) ;
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
