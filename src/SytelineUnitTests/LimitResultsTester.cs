using System;
using System.Text;
using Machine.Specifications;
using Mongoose.IDO.Protocol;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories;
using SytelineInterface.Factories.impl;

namespace SytelineUnitTests
{
    [Subject(typeof(CustomersBuilder))]
    public class when_limit_is_specified_on_ido_builder
    {
        private static CustomersBuilder _builder;
        private static ILoadCollectionRequestFactory _factory;
        private static LoadCollectionRequestData _data;
        Establish context = () =>
        {
            _factory = new LoadCollectionRequestFactory();
            _builder = FromSyteline.Customers.Where.CustomerNumber.Eq("WWTI001").WithMaxResults(2);
        };

        Because of = () =>
        {
            _data = _factory.GetLoadCollectionRequest(_builder);
        };




        It should_set_max_records_value = () =>
        {
            _data.RecordCap.ShouldEqual(2);

        };
    }
}