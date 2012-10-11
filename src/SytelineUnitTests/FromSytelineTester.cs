using System;
using System.Text;
using Machine.Specifications;
using Mongoose.IDO.Protocol;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories;
using SytelineInterface.Factories.impl;

namespace SytelineUnitTests
{
    [Subject(typeof(CustomerOrderBuilder))]
    public class when_ido_builder_has_no_properties
    {
        private static CustomerOrderBuilder _builder;
        private static ILoadCollectionRequestFactory _factory;
        private static LoadCollectionRequestData _data;
        Establish context = () =>
        {
            _factory = new LoadCollectionRequestFactory();
            _builder = FromSyteline.CustomerOrder.Where.CustomerNumber.Eq("AAAA");
        };

        Because of = () =>
        {
            _data = _factory.GetLoadCollectionRequest(_builder);
        };


        It should_have_item_id_property = () =>
        {
            _builder.PropertyCount.ShouldEqual(1);
            _data.PropertyList.Count.ShouldEqual(1);
            _data.PropertyList[0].ShouldEqual(IdoConstants.KEY);

        };
    }
}