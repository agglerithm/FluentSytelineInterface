using System;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Mongoose.IDO.Protocol;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories;
using SytelineInterface.Factories.impl;

namespace SytelineUnitTests
{
    using SytelineInterface.Core;

    [Subject(typeof(CustomerOrderBuilder))]
    public class when_multiple_links_are_specified
    { 
        private static CustomerOrderBuilder _builder;
        private static ILoadCollectionRequestFactory _factory;
        private static LoadCollectionRequestData _data;
        Establish context = () =>
        {
            _builder = FromSyteline.CustomerOrder.OrderNumber.WithChildren(
                FromSyteline.CustomerOrderLineItems.LineNumber.QtyOrdered.LinkBy(CustomerOrder.OrderNumber,
                                                                                 CustomerOrderLineItem.OrderNumber)
                    .LinkBy(CustomerOrder.Warehouse, CustomerOrderLineItem.Warehouse)
                    .LinkBy(CustomerOrder.Site, CustomerOrderLineItem.ShipSite));
            _factory = new LoadCollectionRequestFactory();
        };
        Because of = () =>
        {
            _data = _factory.GetLoadCollectionRequest(_builder);
        };




        It should_result_in_error_being_thrown = () =>
        {
            foreach (LoadCollectionRequestData request in _data.NestedRequests)
                request.LinkBy.Length.ShouldEqual(3);
        };


    }

    [Subject(typeof(CustomerOrderBuilder))]
    public class when_links_are_poorly_formed
    {
        private static CustomerOrderBuilder _builder;
        private static ILoadCollectionRequestFactory _factory;
        private static Exception ex;
        Establish context = () =>
        {
            _builder = FromSyteline.CustomerOrder.OrderNumber.WithChildren(
                FromSyteline.CustomerOrderLineItems.LineNumber.QtyOrdered
                    .LinkBy(CustomerOrder.Warehouse, CustomerOrderLineItem.Warehouse)
                    .LinkBy(CustomerOrder.Site, CustomerOrderLineItem.ShipSite)).LinkBy(CustomerOrder.OrderNumber,
                                                                                 CustomerOrderLineItem.OrderNumber);
            _factory = new LoadCollectionRequestFactory();
        };

        Because of = () =>
        {
            ex = Catch.Exception(() => _factory.GetLoadCollectionRequest(_builder));

        };




        It should_fail = () => ex.ShouldBeOfType<SytelineInterfaceQueryException>();

    }
}