namespace SytelineInterface.Dsl.MethodCalls
            {
            public static partial class SytelineMethod
            {

                        public static ClearSessionSpMethodCallBuilder ClearSessionSp
        {
            get { return new ClearSessionSpMethodCallBuilder(); }
        }
    }

        public class ClearSessionSpMethodCallBuilder  
                :   IdoMethodCallBuilder<IIdoMethodParameterBuilder>
                {
                    public string IDOName
                    {
                         get { return "ConnectionInformations"; }
                    }


                     

        public ClearSessionSpMethodParameterBuilder ClearSessionSp
        {
            get
            {
                var del = _ido = new ClearSessionSpMethodParameterBuilder(this);
                return (ClearSessionSpMethodParameterBuilder)del;
            }
        }

        }

        public class ClearSessionSpMethodParameterBuilder : IdoMethodParameterBuilder
        {

        
                
            public ClearSessionSpMethodParameterBuilder(IdoMethodCallBuilder<IIdoMethodParameterBuilder> parent):base(parent)
            { 
                _method_name = "ClearSessionSp";
             
                }
            }
            
            }