using Mongoose.IDO.Protocol;

namespace SytelineInterface.Dsl.MethodCalls
{
    public class COLineMethodFinder : IdoMethodCallBuilder<IIdoMethodParameterBuilder>
    {
        public COLineMethodFinder()
        {
            _collection = "SLCoitems";
        }

        public COLineDeleteMethodParameterBuilder Delete
        {
            get
            {
                var del = _ido = new COLineDeleteMethodParameterBuilder(this);
                return (COLineDeleteMethodParameterBuilder)del;
            }
        }
        public class COLineDeleteMethodParameterBuilder : IdoMethodParameterBuilder
        { 

            public COLineDeleteMethodParameterBuilder(IdoMethodCallBuilder<IIdoMethodParameterBuilder> parent):base(parent)
            { 
                _method_name = "DeleteCoitemSp";
                _params.Add("1", new InvokeParameter(IDONull.Value));
                _params.Add("2", new InvokeParameter(IDONull.Value));
                _params.Add("3", new InvokeParameter(IDONull.Value));
            }

 

            public COLineDeleteMethodParameterBuilder OrderNumber(string val)
            {
                AddParameter("1", val);
                return this;
            }

            public COLineDeleteMethodParameterBuilder LineNumber(string val)
            {
                AddParameter("2", val);
                return this;
            }

            public COLineDeleteMethodParameterBuilder ReleaseNumber(string val)
            {
                AddParameter("3", val);
                return this;
            }
        }


    }
}