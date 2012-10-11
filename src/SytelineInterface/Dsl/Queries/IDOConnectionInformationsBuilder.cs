using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                  public class ConnectionInformations : IdoConstants 
                { 
                           public const string IDO_NAME = "ConnectionInformations";
       public const string ConnectionID = "ConnectionID";
       public const string CreateDate = "CreateDate";
       public const string CreatedBy = "CreatedBy";
       public const string InWorkflow = "InWorkflow";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string RecordDate = "RecordDate";
       public const string RowPointer = "RowPointer";
       public const string UbSelected = "UbSelected";
       public const string UpdatedBy = "UpdatedBy";
       public const string UserName = "UserName";


                }

            public class ConnectionInformationsBuilder  
                :   IdoQueryBuilder<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder>
                {
                public ConnectionInformationsBuilder(IExpressionInterpreter ei) : base(ConnectionInformations.IDO_NAME, ei) { }

                      public ConnectionInformationsBuilder ConnectionID { get {  AddProperty(ConnectionInformations.ConnectionID); return this; }  } 
                          public ConnectionInformationsBuilder CreateDate { get {  AddProperty(ConnectionInformations.CreateDate); return this; }  } 
                          public ConnectionInformationsBuilder CreatedBy { get {  AddProperty(ConnectionInformations.CreatedBy); return this; }  } 
                          public ConnectionInformationsBuilder InWorkflow { get {  AddProperty(ConnectionInformations.InWorkflow); return this; }  } 
                          public ConnectionInformationsBuilder NoteExistsFlag { get {  AddProperty(ConnectionInformations.NoteExistsFlag); return this; }  } 
                          public ConnectionInformationsBuilder RecordDate { get {  AddProperty(ConnectionInformations.RecordDate); return this; }  } 
                          public ConnectionInformationsBuilder RowPointer { get {  AddProperty(ConnectionInformations.RowPointer); return this; }  } 
                          public ConnectionInformationsBuilder UbSelected { get {  AddProperty(ConnectionInformations.UbSelected); return this; }  } 
                          public ConnectionInformationsBuilder UpdatedBy { get {  AddProperty(ConnectionInformations.UpdatedBy); return this; }  } 
                          public ConnectionInformationsBuilder UserName { get {  AddProperty(ConnectionInformations.UserName); return this; }  } 
                    

                }

            public class ConnectionInformationsFilterExpressionBuilder  
                :   FilterExpressionBuilder<ConnectionInformationsBuilder>
                {
                        public FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder> ConnectionID
                    {
                        get { return new FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder>(_builder, ConnectionInformations.ConnectionID); }
                    }
                            public FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder> CreateDate
                    {
                        get { return new FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder>(_builder, ConnectionInformations.CreateDate); }
                    }
                            public FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder> CreatedBy
                    {
                        get { return new FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder>(_builder, ConnectionInformations.CreatedBy); }
                    }
                            public FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder>(_builder, ConnectionInformations.InWorkflow); }
                    }
                            public FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder>(_builder, ConnectionInformations.NoteExistsFlag); }
                    }
                            public FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder>(_builder, ConnectionInformations.RecordDate); }
                    }
                            public FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder>(_builder, ConnectionInformations.RowPointer); }
                    }
                            public FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder> UbSelected
                    {
                        get { return new FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder>(_builder, ConnectionInformations.UbSelected); }
                    }
                            public FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder> UpdatedBy
                    {
                        get { return new FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder>(_builder, ConnectionInformations.UpdatedBy); }
                    }
                            public FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder> UserName
                    {
                        get { return new FilterExpression<ConnectionInformationsBuilder, ConnectionInformationsFilterExpressionBuilder>(_builder, ConnectionInformations.UserName); }
                    }
                    

                }


            }