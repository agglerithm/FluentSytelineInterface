using System.Collections.Generic;
using System.Xml.Linq;

namespace SytelineInterface.Dsl.MethodCalls
{
    public static partial class SytelineMethod
    {

//        public static KeyValuePair<string, object> SetParameter(string name, object value)
//        {
//            return new KeyValuePair<string, object>(name, value);
//        }
        public static COLineMethodFinder CustomerOrderLineItem
        {
            get { return new COLineMethodFinder(); }
        }
    }
}