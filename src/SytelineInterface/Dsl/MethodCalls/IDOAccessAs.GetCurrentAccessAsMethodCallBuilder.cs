namespace SytelineInterface.Dsl.MethodCalls
            {
            public static partial class SytelineMethod
            {

                        public static GetCurrentAccessAsMethodCallBuilder GetCurrentAccessAs
        {
            get { return new GetCurrentAccessAsMethodCallBuilder(); }
        }
    }

public class GetCurrentAccessAsMethodCallBuilder  
                :   IdoMethodCallBuilder<IIdoMethodParameterBuilder>
                {
                    public string IDOName
                    {
                         get { return "AccessAs"; }
                    }


                     

        public GetCurrentAccessAsMethodParameterBuilder GetCurrentAccessAs
        {
            get
            {
                var del = _ido = new GetCurrentAccessAsMethodParameterBuilder(this);
                return (GetCurrentAccessAsMethodParameterBuilder)del;
            }
        }

        }

        public class GetCurrentAccessAsMethodParameterBuilder : IdoMethodParameterBuilder
        {

        
                
            public GetCurrentAccessAsMethodParameterBuilder(IdoMethodCallBuilder<IIdoMethodParameterBuilder> parent):base(parent)
            { 
                _method_name = "GetCurrentAccessAs";
             
                }
            }
            
            }