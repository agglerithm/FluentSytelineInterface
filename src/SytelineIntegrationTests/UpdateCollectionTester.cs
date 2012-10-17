using System;
using System.Collections.Generic;
using System.Data;

using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Core.Enums;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories;
using SytelineInterface.Factories.impl;

namespace SytelineIntegrationTests
{
    using SytelineInterface;

    [TestFixture]
    public class UpdateCollectionTester
    {
        private ISytelineIdoClient _client;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = new SytelineIdoClient(TestHelper.GetTestClientWrapper(),
                new LoadCollectionRequestFactory(),
                new UpdateCollectionRequestFactory(),
                new MethodRequestFactory(),
                new UserSessionService()); 
        }

        //[Test]
        //public void testing_blah_blah_blah()
        //{
        //    var pn = "01063-A0023";
        //    var query = FromSyteline.CustomerPartNumbers
        //                                .CustomerPartNumber
        //                                .CustomerNumber
        //                                .Where
        //                                    .CustomerPartNumber.Eq(pn);

        //    var query1 = FromSyteline.CustomerPartNumbers.Where.CustomerPartNumber.Eq(pn).WithMaxResults(1);


        //    var loc = TestHelper.GetPilotSyteline();
        //    var TEST = _client.GetObject(loc, query1, mapPart);
        //    Assert.That(TEST, Is.Not.Null);
        //    Assert.That(TEST.ItemDescription, Is.EqualTo(pn));
        //}

        [Test, Explicit]
        public void can_insert_new_record()
        {
             var response = _client.Insert(TestHelper.GetTestSyteline(),
                           ToSyteline.CustomerOrder.CustomerNumber("WWTI001")  
                               .Discount("0").OrderDate(DateTime.Now).OrderType("R").OrderNumber("TBD").
                               PONumber("998342")
                               .ShipToAddr1("1111 Elm St").ShipToAddr2("Suite 12").ShipToCity("Florence").ShipToState(
                               "OH")
                               .ShipToCode("00001").ShipToName("Fred").ShipToZip("18736") 
                               .LinkProperty(CustomerOrder.OrderNumber).WithChildren(
                               ()=> ToSyteline.CustomerOrderLineItems.CustomerNumber("WWTI001").CustomerPartNumber
                                        ("23432").
                                        Description("12 IBEAM")
                                        .Item("FIN23432343").LineNumber("1").Price("1.234").QtyOrdered("23").
                                        ShipSite("AUS").
                                        OrderNumber("TBD").
                                        UnitOfMeasure("EA").
                                        Warehouse("MAIN").LinkProperty(CustomerOrderLineItem.OrderNumber)));
            response.ShouldNotBeNull();
            
        }

        [Test, Explicit]
        public void can_get_item_id_from_new_record()
        {
            var response = _client.Insert(TestHelper.GetTestSyteline(),
                          ToSyteline.CustomerOrder.CustomerNumber("WWTI001")  
                              .Discount("0").OrderDate(DateTime.Now).OrderType("R").OrderNumber("TBD").
                              PONumber("998342")
                              .ShipToAddr1("1111 Elm St").ShipToAddr2("Suite 12").ShipToCity("Florence").ShipToState(
                              "OH")
                              .ShipToCode("00001").ShipToName("Fred").ShipToZip("18736") 
                              .LinkProperty(CustomerOrder.OrderNumber).WithChildren(
                              () => ToSyteline.CustomerOrderLineItems.CustomerNumber("WWTI001").CustomerPartNumber
                                       ("23432").
                                       Description("12 IBEAM")
                                       .Item("FIN23432343").LineNumber("1").Price("1.234").QtyOrdered("23").
                                       ShipSite("AUS").
                                       OrderNumber("TBD").
                                       UnitOfMeasure("EA").
                                       Warehouse("MAIN").LinkProperty(CustomerOrderLineItem.OrderNumber)));
            response.ShouldNotBeNull();

            var itemId = response.GetItemId(0);
            Assert.That(itemId, Is.TypeOf(typeof(Guid)));
            Assert.That(itemId, Is.Not.EqualTo(Guid.Empty));
        }

        [Test]
        public void can_update_existing_record()
        {
            var loc = TestHelper.GetTestSyteline();
            var result = _client.GetObject<CustomerEntity>(loc,
                                                           FromSyteline.Customers.CustomerNumber.CustomerSequence.
                                                               WithMaxResults(1), Map);
            _client.UpdateCollection(loc, ToSyteline.Customers.CustomerNumber(result.CustomerID),
                                     FromSyteline.Customers.Where.CustomerNumber.Eq(result.CustomerID));
        }

        [Test]
        public void can_update_existing_customerOrder_record()
        {
            var loc = TestHelper.GetTestSyteline();
            var queryBuilder = FromSyteline
                                    .CustomerOrder
                                    .OrderNumber
                                    .PONumber 
                                    .Where
                                        .CustomerNumber.Eq("WWTI001")
                                    .WithMaxResults(1);

            //var result = _client.GetObject<CustomerOrderEntity>(loc, FromSyteline.CustomerOrder.ShippingInstructions.WithMaxResults(1), mapCustomerOrder);
            var result = _client.GetObject<CustomerOrderEntity>(TestHelper.GetTestSyteline(), 
                                queryBuilder, MapCustomerOrder);

            var testNote = "TestNote: " + DateTime.Now.Ticks;
              
            _client.UpdateCollection(loc, ToSyteline.CustomerOrder.CustomerNumber(testNote),
                                     FromSyteline.CustomerOrder.Where.OrderNumber.Eq(result.OrderNumber));


            var result2 = _client.GetObject<CustomerOrderEntity>(TestHelper.GetTestSyteline(), queryBuilder, MapCustomerOrder);
            Assert.That(result2.Notes, Is.EqualTo(testNote));

        }

        private static CustomerOrderEntity MapCustomerOrder(IdoItemWrapper idoItemWrapper)
        {
            var loc = TestHelper.GetTestSyteline();
            return new CustomerOrderEntity(loc)
                       { 
                           OrderNumber = idoItemWrapper.GetValue(CustomerOrder.OrderNumber).ToString(),
                           CustomerPO = idoItemWrapper.GetValue(CustomerOrder.PONumber).ToString()
            };
        }

        private static CustomerEntity Map(IdoItemWrapper idoItemWrapper)
        {
            return new CustomerEntity() { CustomerID = idoItemWrapper.GetValue(Customers.CustomerNumber).ToString() };
        }

        private static PartEntity mapPart(DataRow row, IEnumerable<LoadCollectionResponseWrapper> children)
        {
            var loc = TestHelper.GetTestSyteline();
            return new PartEntity(loc)
            {
                ItemDescription = row[CustomerPartNumbers.CustomerPartNumber].ToString(),
            };
        }

        [TestFixtureTearDown]
        public void TearDown()
        { 
        }
    }

    public class CustomerOrderEntity
    {
        private readonly SLConfiguration _loc;

        public CustomerOrderEntity(SLConfiguration loc)
        {
            _loc = loc; 
        }

        public string OrderNumber
        {
            get;
            set;
        }

        public string Notes
        {
            get; set;
        }

        public string CustomerPO
        {
            get;
            set;
        }
    }

    internal class PartEntity
    {
        private readonly SLConfiguration _loc;

        public PartEntity(SLConfiguration loc)
        {
            _loc = loc;
            throw new NotImplementedException();
        }

        public string ItemDescription
        {
            get; set;
        }
    }

    public class CustomerEntity
    {
        public string CustomerID
        {
            get; set;
        }

        public string CustomerName
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
