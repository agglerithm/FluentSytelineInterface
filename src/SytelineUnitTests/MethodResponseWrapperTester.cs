using Machine.Specifications;
using Mongoose.IDO.Protocol;
using SytelineInterface.Core.impl;

namespace SytelineUnitTests
{

    [Subject(typeof(MethodCallResponseWrapper))]
    public class when_created_from_syteline_method_data
    {
        static MethodCallResponseWrapper _obj;
        static InvokeResponseData _data;
       
        Establish context = () =>
        {
            _data = get_data();
        };

        static InvokeResponseData get_data()
        {
            var data = new InvokeResponseData(){IDOName = "Chuck", MethodName = "GetHim" };
            data.Parameters.Add("Chevy");
            data.Parameters.Add(10);
            data.ReturnValue = "1"; 
            return data;
        }

        Because of = () =>
        {
            _obj = new MethodCallResponseWrapper(_data);
        };

 
        It should_allow_access_to_return_value = () =>
        {
            var num = _obj.GetScalar<int>();
            num.ShouldEqual(1);
            _obj.ReturnValue.ShouldEqual("1");

        };
    }
}