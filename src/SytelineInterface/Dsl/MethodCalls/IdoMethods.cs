using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using Mongoose.IDO.Protocol;

namespace SytelineInterface.Dsl.MethodCalls
{
    public interface IIdoMethodCallBuilder
    {
        IEnumerable<InvokeParameter> GetParameters();
        string GetIDOName();
        string GetMethodName();
    }

    public interface IIdoMethodParameterBuilder
    {
        IEnumerable<InvokeParameter> GetParameters();
        string GetMethodName(); 
        InvokeParameter AddParameter(string seqNum, object val);
        IdoMethodCallBuilder<IIdoMethodParameterBuilder> SetInvoke();
    }

    public class IdoMethodCallBuilder<METHODPARAMBUILDER> : IIdoMethodCallBuilder 
        where METHODPARAMBUILDER : IIdoMethodParameterBuilder
    {
        protected string _collection;
        protected METHODPARAMBUILDER _ido;

        public IEnumerable<InvokeParameter> GetParameters()
        {
            return _ido.GetParameters();
        }

        public string GetIDOName()
        {
            return _collection;
        }

        public string GetMethodName()
        {
            return _ido.GetMethodName();
        }

 
    }

    public class IdoMethodParameterBuilder : IIdoMethodParameterBuilder
    {
        protected IDictionary<string, InvokeParameter> _params;
        protected string _method_name;
        private readonly IdoMethodCallBuilder<IIdoMethodParameterBuilder> _parent;

        public IdoMethodParameterBuilder (IdoMethodCallBuilder<IIdoMethodParameterBuilder> parent)
        {
            _params = new Dictionary<string, InvokeParameter>();
            _parent = parent;
        }

        public IdoMethodCallBuilder<IIdoMethodParameterBuilder> Method
        {
            get{ return _parent;} 
        }

        public IEnumerable<InvokeParameter> GetParameters()
        {
            return _params.Values;
        }

        public string GetMethodName()
        {
            return _method_name;
        }

//        public IdoMethodCallBuilder<IIdoMethodParameterBuilder> WithParameters(params KeyValuePair<string,object> [] parameterList)
//        {
//            foreach (KeyValuePair<string, object> param in parameterList)
//                AddParameter(param.Key, param.Value);
//            return _parent;
//        }

        public IdoMethodCallBuilder<IIdoMethodParameterBuilder> SetInvoke()
        {
            return _parent;
        }
        public InvokeParameter AddParameter(string seqNum, object val)
        {
            if (!_params.ContainsKey(seqNum))
                throw new InvalidOperationException(string.Format("There was no method parameter with sequence number {0}", seqNum)); 
            _params[seqNum].SetValue(val);
            return _params[seqNum];
        }
    }
}