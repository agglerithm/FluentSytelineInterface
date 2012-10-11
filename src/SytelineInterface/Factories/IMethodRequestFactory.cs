using System;
using Mongoose.IDO.Protocol;
using SytelineInterface.Dsl.MethodCalls;

namespace SytelineInterface.Factories
{
    public interface IMethodRequestFactory
    {
        InvokeRequestData GetMethodRequest(IIdoMethodCallBuilder builder);
    }

    public class MethodRequestFactory : IMethodRequestFactory
    {
        public InvokeRequestData GetMethodRequest(IIdoMethodCallBuilder builder)
        {
            var data = new InvokeRequestData() {IDOName = builder.GetIDOName(), MethodName = builder.GetMethodName()};
            foreach (InvokeParameter param in builder.GetParameters())
            {
                data.Parameters.Add(param); 
            }
            return data;
        }
    }
}