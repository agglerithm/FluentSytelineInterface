using System;
using System.Text;
using Machine.Specifications;
using Mongoose.IDO.Protocol;
using SytelineInterface.Dsl.MethodCalls;
using SytelineInterface.Factories;

namespace SytelineUnitTests
{
    [Subject(typeof(MethodRequestFactory))]
    public class when_method_request_is_requested
    {
        private static MethodRequestFactory _factory;
        private static COLineMethodFinder _methodCallBuilder;
        private static InvokeRequestData _data;
        Establish context = () =>
        {
            _methodCallBuilder =
                (COLineMethodFinder)
                SytelineMethod.CustomerOrderLineItem.Delete.OrderNumber("332532").LineNumber("1").ReleaseNumber("2").
                    SetInvoke();
            _factory = new MethodRequestFactory();
        };

        Because of = () =>
        {
            _data = _factory.GetMethodRequest(_methodCallBuilder);
        };

 
        It should_provide_correct_request_data = () =>
        {
            _data.MethodName.ShouldEqual(_methodCallBuilder.GetMethodName());
            _data.Parameters.Count.ShouldEqual(3);
            _data.Parameters[0].GetValue<string>().ShouldEqual("332532");
            _data.Parameters[1].GetValue<string>().ShouldEqual("1");
            _data.Parameters[2].GetValue<string>().ShouldEqual("2");

        };
    }
}