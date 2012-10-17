using System.Collections.Generic;
using System.Data;
using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class WarehouseIdoTester
    {
        private WarehouseBuilder _builder;
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder =
                FromSyteline.Warehouses.Address1.Address2.Address3.City.State.Zip.Name.Warehouse.Site.Where<WarehousesCriteria>(x => x.Site == 
                    "AUS");
        }

        [Test]
        public void can_get_records_from_warehouse_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(Warehouses.Addr1).ShouldBeTrue();
            resp.ContainsField(Warehouses.Addr2).ShouldBeTrue();
            resp.ContainsField(Warehouses.Addr3).ShouldBeTrue();
            resp.ContainsField(Warehouses.City).ShouldBeTrue(); 
            resp.ContainsField(Warehouses.Name).ShouldBeTrue(); 
            resp.ContainsField(Warehouses.Site).ShouldBeTrue();
            resp.ContainsField(Warehouses.State).ShouldBeTrue();
            resp.ContainsField(Warehouses.Warehouse).ShouldBeTrue();
            resp.ContainsField(Warehouses.Zip).ShouldBeTrue(); 
        }

        [TestFixtureTearDown]
        public void TearDown()
        { 
        }
    }
}
