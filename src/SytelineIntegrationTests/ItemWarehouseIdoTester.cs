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
    public class ItemWarehouseIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder = ItemWarehouse.GetFullProjection()
                .Where<ItemWarehouseCriteria>(x => x.Item.Contains("FIN") && x.ItemDescription != null  && x.QtyMrb > 0 
                 && x.QtyOrdered > 0  && x.QtyOnHand > 0 && x.QtyReorder > 0 
                 && x.QtySoldYtd > 0  && x.QtyWip > 0  && x.RecordDate < DateTime.Today 
                 && x.SalesPtd > 0  && x.SalesYtd > 0  && x.TotalQtyOnHand > 0 
                 && x.TotalQtyReserved > 0);
        }

        [Test, Explicit]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder); 
            resp.ContainsField(ItemWarehouse.Item).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.ItemDescription).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.QtyMrb).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.QtyOnHand).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.QtyOrdered).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.QtyPurchasedYtd).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.QtyReorder).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.QtySoldYtd).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.QtyWip).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.RecordDate).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.RowPointer).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.SalesPtd).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.SalesYtd).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.TotalQtyOnHand).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.TotalQtyReserved).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.UM).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.Whse).ShouldBeTrue();
            resp.ContainsField(ItemWarehouse.WhseName).ShouldBeTrue();
        }


        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }
}
