using System;
using Mongoose.IDO.Protocol;

namespace SytelineInterface.Core.impl
{
    public class MethodCallResponseWrapper
    {
        private readonly InvokeResponseData _response;

        public MethodCallResponseWrapper(InvokeResponseData response)
        {
            if (response.IsReturnValueStdError())
                throw new InvalidOperationException(string.Format(@"Syteline method call {0} for IDO {1} 
                    returned the following error: {2}", 
                                                      response.MethodName, response.IDOName, response.ReturnValue));
            _response = response;
        }

        public T GetScalar<T>() where T : struct
        {
            return _response.GetReturnValue<T>();
        }

        public string ReturnValue
        {
            get { return _response.ReturnValue;  }
        }
    }
}