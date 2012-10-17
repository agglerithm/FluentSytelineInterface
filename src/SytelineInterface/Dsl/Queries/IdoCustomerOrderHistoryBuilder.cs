using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                    using Commands;

                    public class IdoCustomerOrderHistory : IdoConstants 
                { 
                           public const string IDO_NAME = "SLCohs";
       public const string ApsPullUp = "ApsPullUp";
       public const string Cad01Name = "Cad01Name";
       public const string Cad0CorpAddress = "Cad0CorpAddress";
       public const string Cad0CorpCust = "Cad0CorpCust";
       public const string Cad0CurrCode = "Cad0CurrCode";
       public const string CadCurrCode = "CadCurrCode";
       public const string CadName = "CadName";
       public const string Charfld1 = "Charfld1";
       public const string Charfld2 = "Charfld2";
       public const string Charfld3 = "Charfld3";
       public const string CloseDate = "CloseDate";
       public const string ConfigId = "ConfigId";
       public const string Contact = "Contact";
       public const string CoNum = "CoNum";
       public const string ConvertType = "ConvertType";
       public const string Cost = "Cost";
       public const string CurrAmtFormat = "CurrAmtFormat";
       public const string Cus01Contact3 = "Cus01Contact3";
       public const string Cus01Phone3 = "Cus01Phone3";
       public const string Cus0Contact3 = "Cus0Contact3";
       public const string Cus0Phone3 = "Cus0Phone3";
       public const string CusContact2 = "CusContact2";
       public const string CusPhone2 = "CusPhone2";
       public const string CustNum = "CustNum";
       public const string CustPo = "CustPo";
       public const string CustSeq = "CustSeq";
       public const string CustType = "CustType";
       public const string Datefld = "Datefld";
       public const string Decifld1 = "Decifld1";
       public const string Decifld2 = "Decifld2";
       public const string Decifld3 = "Decifld3";
       public const string Delterm = "Delterm";
       public const string Disc = "Disc";
       public const string DltDescription = "DltDescription";
       public const string EdiOrder = "EdiOrder";
       public const string EffDate = "EffDate";
       public const string EndUserType = "EndUserType";
       public const string EntDescription = "EntDescription";
       public const string EstNum = "EstNum";
       public const string ExchRate = "ExchRate";
       public const string ExpDate = "ExpDate";
       public const string ExportType = "ExportType";
       public const string ExternalConfirmationRef = "ExternalConfirmationRef";
       public const string FixedRate = "FixedRate";
       public const string FormatBillToAddress = "FormatBillToAddress";
       public const string FormatShipToAddress = "FormatShipToAddress";
       public const string FovhdCostT = "FovhdCostT";
       public const string Freight = "Freight";
       public const string FrtTaxCode1 = "FrtTaxCode1";
       public const string FrtTaxCode1Desc = "FrtTaxCode1Desc";
       public const string FrtTaxCode2 = "FrtTaxCode2";
       public const string FrtTaxCode2Desc = "FrtTaxCode2Desc";
       public const string IncludeTaxInPrice = "IncludeTaxInPrice";
       public const string InWorkflow = "InWorkflow";
       public const string IsExternal = "IsExternal";
       public const string LbrCostT = "LbrCostT";
       public const string LcrNum = "LcrNum";
       public const string Logifld = "Logifld";
       public const string MatlCostT = "MatlCostT";
       public const string MiscCharges = "MiscCharges";
       public const string MscTaxCode1 = "MscTaxCode1";
       public const string MscTaxCode1Desc = "MscTaxCode1Desc";
       public const string MscTaxCode2 = "MscTaxCode2";
       public const string MscTaxCode2Desc = "MscTaxCode2Desc";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string OrderDate = "OrderDate";
       public const string OrderSource = "OrderSource";
       public const string OrigSite = "OrigSite";
       public const string OutCostT = "OutCostT";
       public const string Phone = "Phone";
       public const string PrcDescription = "PrcDescription";
       public const string PrepaidAmt = "PrepaidAmt";
       public const string Price = "Price";
       public const string Pricecode = "Pricecode";
       public const string ProcessInd = "ProcessInd";
       public const string ProjectedDate = "ProjectedDate";
       public const string QtyPackages = "QtyPackages";
       public const string RecordDate = "RecordDate";
       public const string RowPointer = "RowPointer";
       public const string SalesTax = "SalesTax";
       public const string SalesTax2 = "SalesTax2";
       public const string ShcDescription = "ShcDescription";
       public const string ShipCode = "ShipCode";
       public const string ShipEarly = "ShipEarly";
       public const string ShipPartial = "ShipPartial";
       public const string SLCoSlsComms = "SLCoSlsComms";
       public const string Slsman = "Slsman";
       public const string Stat = "Stat";
       public const string TakenBy = "TakenBy";
       public const string TaxCode1 = "TaxCode1";
       public const string TaxCode1Desc = "TaxCode1Desc";
       public const string TaxCode2 = "TaxCode2";
       public const string TaxCode2Desc = "TaxCode2Desc";
       public const string TermsCode = "TermsCode";
       public const string TransNat = "TransNat";
       public const string TransNat2 = "TransNat2";
       public const string TransNat2Description = "TransNat2Description";
       public const string TrmDescription = "TrmDescription";
       public const string TrnDescription = "TrnDescription";
       public const string Type = "Type";
       public const string UseExchRate = "UseExchRate";
       public const string VovhdCostT = "VovhdCostT";
       public const string Weight = "Weight";
       public const string Whse = "Whse";


                }
                    
                    
                    
                public class IdoCustomerOrderHistoryBuilder  
                :   IdoQueryBuilder<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>
                {
                        public IdoCustomerOrderHistoryBuilder(IExpressionInterpreter interpreter) : base(IdoCustomerOrderHistory.IDO_NAME,interpreter) { }

                      public IdoCustomerOrderHistoryBuilder ApsPullUp { get {  AddProperty(IdoCustomerOrderHistory.ApsPullUp); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Cad01Name { get {  AddProperty(IdoCustomerOrderHistory.Cad01Name); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Cad0CorpAddress { get {  AddProperty(IdoCustomerOrderHistory.Cad0CorpAddress); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Cad0CorpCust { get {  AddProperty(IdoCustomerOrderHistory.Cad0CorpCust); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Cad0CurrCode { get {  AddProperty(IdoCustomerOrderHistory.Cad0CurrCode); return this; } }         
                    public IdoCustomerOrderHistoryBuilder CadCurrCode { get {  AddProperty(IdoCustomerOrderHistory.CadCurrCode); return this; } }         
                    public IdoCustomerOrderHistoryBuilder CadName { get {  AddProperty(IdoCustomerOrderHistory.CadName); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Charfld1 { get {  AddProperty(IdoCustomerOrderHistory.Charfld1); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Charfld2 { get {  AddProperty(IdoCustomerOrderHistory.Charfld2); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Charfld3 { get {  AddProperty(IdoCustomerOrderHistory.Charfld3); return this; } }         
                    public IdoCustomerOrderHistoryBuilder CloseDate { get {  AddProperty(IdoCustomerOrderHistory.CloseDate); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ConfigId { get {  AddProperty(IdoCustomerOrderHistory.ConfigId); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Contact { get {  AddProperty(IdoCustomerOrderHistory.Contact); return this; } }         
                    public IdoCustomerOrderHistoryBuilder CoNum { get {  AddProperty(IdoCustomerOrderHistory.CoNum); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ConvertType { get {  AddProperty(IdoCustomerOrderHistory.ConvertType); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Cost { get {  AddProperty(IdoCustomerOrderHistory.Cost); return this; } }         
                    public IdoCustomerOrderHistoryBuilder CurrAmtFormat { get {  AddProperty(IdoCustomerOrderHistory.CurrAmtFormat); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Cus01Contact3 { get {  AddProperty(IdoCustomerOrderHistory.Cus01Contact3); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Cus01Phone3 { get {  AddProperty(IdoCustomerOrderHistory.Cus01Phone3); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Cus0Contact3 { get {  AddProperty(IdoCustomerOrderHistory.Cus0Contact3); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Cus0Phone3 { get {  AddProperty(IdoCustomerOrderHistory.Cus0Phone3); return this; } }         
                    public IdoCustomerOrderHistoryBuilder CusContact2 { get {  AddProperty(IdoCustomerOrderHistory.CusContact2); return this; } }         
                    public IdoCustomerOrderHistoryBuilder CusPhone2 { get {  AddProperty(IdoCustomerOrderHistory.CusPhone2); return this; } }         
                    public IdoCustomerOrderHistoryBuilder CustNum { get {  AddProperty(IdoCustomerOrderHistory.CustNum); return this; } }         
                    public IdoCustomerOrderHistoryBuilder CustPo { get {  AddProperty(IdoCustomerOrderHistory.CustPo); return this; } }         
                    public IdoCustomerOrderHistoryBuilder CustSeq { get {  AddProperty(IdoCustomerOrderHistory.CustSeq); return this; } }         
                    public IdoCustomerOrderHistoryBuilder CustType { get {  AddProperty(IdoCustomerOrderHistory.CustType); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Datefld { get {  AddProperty(IdoCustomerOrderHistory.Datefld); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Decifld1 { get {  AddProperty(IdoCustomerOrderHistory.Decifld1); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Decifld2 { get {  AddProperty(IdoCustomerOrderHistory.Decifld2); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Decifld3 { get {  AddProperty(IdoCustomerOrderHistory.Decifld3); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Delterm { get {  AddProperty(IdoCustomerOrderHistory.Delterm); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Disc { get {  AddProperty(IdoCustomerOrderHistory.Disc); return this; } }         
                    public IdoCustomerOrderHistoryBuilder DltDescription { get {  AddProperty(IdoCustomerOrderHistory.DltDescription); return this; } }         
                    public IdoCustomerOrderHistoryBuilder EdiOrder { get {  AddProperty(IdoCustomerOrderHistory.EdiOrder); return this; } }         
                    public IdoCustomerOrderHistoryBuilder EffDate { get {  AddProperty(IdoCustomerOrderHistory.EffDate); return this; } }         
                    public IdoCustomerOrderHistoryBuilder EndUserType { get {  AddProperty(IdoCustomerOrderHistory.EndUserType); return this; } }         
                    public IdoCustomerOrderHistoryBuilder EntDescription { get {  AddProperty(IdoCustomerOrderHistory.EntDescription); return this; } }         
                    public IdoCustomerOrderHistoryBuilder EstNum { get {  AddProperty(IdoCustomerOrderHistory.EstNum); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ExchRate { get {  AddProperty(IdoCustomerOrderHistory.ExchRate); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ExpDate { get {  AddProperty(IdoCustomerOrderHistory.ExpDate); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ExportType { get {  AddProperty(IdoCustomerOrderHistory.ExportType); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ExternalConfirmationRef { get {  AddProperty(IdoCustomerOrderHistory.ExternalConfirmationRef); return this; } }         
                    public IdoCustomerOrderHistoryBuilder FixedRate { get {  AddProperty(IdoCustomerOrderHistory.FixedRate); return this; } }         
                    public IdoCustomerOrderHistoryBuilder FormatBillToAddress { get {  AddProperty(IdoCustomerOrderHistory.FormatBillToAddress); return this; } }         
                    public IdoCustomerOrderHistoryBuilder FormatShipToAddress { get {  AddProperty(IdoCustomerOrderHistory.FormatShipToAddress); return this; } }         
                    public IdoCustomerOrderHistoryBuilder FovhdCostT { get {  AddProperty(IdoCustomerOrderHistory.FovhdCostT); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Freight { get {  AddProperty(IdoCustomerOrderHistory.Freight); return this; } }         
                    public IdoCustomerOrderHistoryBuilder FrtTaxCode1 { get {  AddProperty(IdoCustomerOrderHistory.FrtTaxCode1); return this; } }         
                    public IdoCustomerOrderHistoryBuilder FrtTaxCode1Desc { get {  AddProperty(IdoCustomerOrderHistory.FrtTaxCode1Desc); return this; } }         
                    public IdoCustomerOrderHistoryBuilder FrtTaxCode2 { get {  AddProperty(IdoCustomerOrderHistory.FrtTaxCode2); return this; } }         
                    public IdoCustomerOrderHistoryBuilder FrtTaxCode2Desc { get {  AddProperty(IdoCustomerOrderHistory.FrtTaxCode2Desc); return this; } }         
                    public IdoCustomerOrderHistoryBuilder IncludeTaxInPrice { get {  AddProperty(IdoCustomerOrderHistory.IncludeTaxInPrice); return this; } }         
                    public IdoCustomerOrderHistoryBuilder InWorkflow { get {  AddProperty(IdoCustomerOrderHistory.InWorkflow); return this; } }         
                    public IdoCustomerOrderHistoryBuilder IsExternal { get {  AddProperty(IdoCustomerOrderHistory.IsExternal); return this; } }         
                    public IdoCustomerOrderHistoryBuilder LbrCostT { get {  AddProperty(IdoCustomerOrderHistory.LbrCostT); return this; } }         
                    public IdoCustomerOrderHistoryBuilder LcrNum { get {  AddProperty(IdoCustomerOrderHistory.LcrNum); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Logifld { get {  AddProperty(IdoCustomerOrderHistory.Logifld); return this; } }         
                    public IdoCustomerOrderHistoryBuilder MatlCostT { get {  AddProperty(IdoCustomerOrderHistory.MatlCostT); return this; } }         
                    public IdoCustomerOrderHistoryBuilder MiscCharges { get {  AddProperty(IdoCustomerOrderHistory.MiscCharges); return this; } }         
                    public IdoCustomerOrderHistoryBuilder MscTaxCode1 { get {  AddProperty(IdoCustomerOrderHistory.MscTaxCode1); return this; } }         
                    public IdoCustomerOrderHistoryBuilder MscTaxCode1Desc { get {  AddProperty(IdoCustomerOrderHistory.MscTaxCode1Desc); return this; } }         
                    public IdoCustomerOrderHistoryBuilder MscTaxCode2 { get {  AddProperty(IdoCustomerOrderHistory.MscTaxCode2); return this; } }         
                    public IdoCustomerOrderHistoryBuilder MscTaxCode2Desc { get {  AddProperty(IdoCustomerOrderHistory.MscTaxCode2Desc); return this; } }         
                    public IdoCustomerOrderHistoryBuilder NoteExistsFlag { get {  AddProperty(IdoCustomerOrderHistory.NoteExistsFlag); return this; } }         
                    public IdoCustomerOrderHistoryBuilder OrderDate { get {  AddProperty(IdoCustomerOrderHistory.OrderDate); return this; } }         
                    public IdoCustomerOrderHistoryBuilder OrderSource { get {  AddProperty(IdoCustomerOrderHistory.OrderSource); return this; } }         
                    public IdoCustomerOrderHistoryBuilder OrigSite { get {  AddProperty(IdoCustomerOrderHistory.OrigSite); return this; } }         
                    public IdoCustomerOrderHistoryBuilder OutCostT { get {  AddProperty(IdoCustomerOrderHistory.OutCostT); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Phone { get {  AddProperty(IdoCustomerOrderHistory.Phone); return this; } }         
                    public IdoCustomerOrderHistoryBuilder PrcDescription { get {  AddProperty(IdoCustomerOrderHistory.PrcDescription); return this; } }         
                    public IdoCustomerOrderHistoryBuilder PrepaidAmt { get {  AddProperty(IdoCustomerOrderHistory.PrepaidAmt); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Price { get {  AddProperty(IdoCustomerOrderHistory.Price); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Pricecode { get {  AddProperty(IdoCustomerOrderHistory.Pricecode); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ProcessInd { get {  AddProperty(IdoCustomerOrderHistory.ProcessInd); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ProjectedDate { get {  AddProperty(IdoCustomerOrderHistory.ProjectedDate); return this; } }         
                    public IdoCustomerOrderHistoryBuilder QtyPackages { get {  AddProperty(IdoCustomerOrderHistory.QtyPackages); return this; } }         
                    public IdoCustomerOrderHistoryBuilder RecordDate { get {  AddProperty(IdoCustomerOrderHistory.RecordDate); return this; } }         
                    public IdoCustomerOrderHistoryBuilder RowPointer { get {  AddProperty(IdoCustomerOrderHistory.RowPointer); return this; } }         
                    public IdoCustomerOrderHistoryBuilder SalesTax { get {  AddProperty(IdoCustomerOrderHistory.SalesTax); return this; } }         
                    public IdoCustomerOrderHistoryBuilder SalesTax2 { get {  AddProperty(IdoCustomerOrderHistory.SalesTax2); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ShcDescription { get {  AddProperty(IdoCustomerOrderHistory.ShcDescription); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ShipCode { get {  AddProperty(IdoCustomerOrderHistory.ShipCode); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ShipEarly { get {  AddProperty(IdoCustomerOrderHistory.ShipEarly); return this; } }         
                    public IdoCustomerOrderHistoryBuilder ShipPartial { get {  AddProperty(IdoCustomerOrderHistory.ShipPartial); return this; } }         
                    public IdoCustomerOrderHistoryBuilder SLCoSlsComms { get {  AddProperty(IdoCustomerOrderHistory.SLCoSlsComms); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Slsman { get {  AddProperty(IdoCustomerOrderHistory.Slsman); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Stat { get {  AddProperty(IdoCustomerOrderHistory.Stat); return this; } }         
                    public IdoCustomerOrderHistoryBuilder TakenBy { get {  AddProperty(IdoCustomerOrderHistory.TakenBy); return this; } }         
                    public IdoCustomerOrderHistoryBuilder TaxCode1 { get {  AddProperty(IdoCustomerOrderHistory.TaxCode1); return this; } }         
                    public IdoCustomerOrderHistoryBuilder TaxCode1Desc { get {  AddProperty(IdoCustomerOrderHistory.TaxCode1Desc); return this; } }         
                    public IdoCustomerOrderHistoryBuilder TaxCode2 { get {  AddProperty(IdoCustomerOrderHistory.TaxCode2); return this; } }         
                    public IdoCustomerOrderHistoryBuilder TaxCode2Desc { get {  AddProperty(IdoCustomerOrderHistory.TaxCode2Desc); return this; } }         
                    public IdoCustomerOrderHistoryBuilder TermsCode { get {  AddProperty(IdoCustomerOrderHistory.TermsCode); return this; } }         
                    public IdoCustomerOrderHistoryBuilder TransNat { get {  AddProperty(IdoCustomerOrderHistory.TransNat); return this; } }         
                    public IdoCustomerOrderHistoryBuilder TransNat2 { get {  AddProperty(IdoCustomerOrderHistory.TransNat2); return this; } }         
                    public IdoCustomerOrderHistoryBuilder TransNat2Description { get {  AddProperty(IdoCustomerOrderHistory.TransNat2Description); return this; } }         
                    public IdoCustomerOrderHistoryBuilder TrmDescription { get {  AddProperty(IdoCustomerOrderHistory.TrmDescription); return this; } }         
                    public IdoCustomerOrderHistoryBuilder TrnDescription { get {  AddProperty(IdoCustomerOrderHistory.TrnDescription); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Type { get {  AddProperty(IdoCustomerOrderHistory.Type); return this; } }         
                    public IdoCustomerOrderHistoryBuilder UseExchRate { get {  AddProperty(IdoCustomerOrderHistory.UseExchRate); return this; } }         
                    public IdoCustomerOrderHistoryBuilder VovhdCostT { get {  AddProperty(IdoCustomerOrderHistory.VovhdCostT); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Weight { get {  AddProperty(IdoCustomerOrderHistory.Weight); return this; } }         
                    public IdoCustomerOrderHistoryBuilder Whse { get {  AddProperty(IdoCustomerOrderHistory.Whse); return this; } }   

                }public class SLCohsFilterExpressionBuilder  
                :   FilterExpressionBuilder<IdoCustomerOrderHistoryBuilder>
                {
                        public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ApsPullUp
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ApsPullUp); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Cad01Name
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Cad01Name); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Cad0CorpAddress
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Cad0CorpAddress); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Cad0CorpCust
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Cad0CorpCust); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Cad0CurrCode
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Cad0CurrCode); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> CadCurrCode
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.CadCurrCode); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> CadName
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.CadName); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Charfld1
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Charfld1); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Charfld2
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Charfld2); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Charfld3
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Charfld3); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> CloseDate
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.CloseDate); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ConfigId
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ConfigId); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Contact
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Contact); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> CoNum
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.CoNum); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ConvertType
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ConvertType); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Cost
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Cost); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> CurrAmtFormat
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.CurrAmtFormat); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Cus01Contact3
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Cus01Contact3); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Cus01Phone3
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Cus01Phone3); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Cus0Contact3
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Cus0Contact3); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Cus0Phone3
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Cus0Phone3); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> CusContact2
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.CusContact2); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> CusPhone2
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.CusPhone2); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> CustNum
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.CustNum); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> CustPo
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.CustPo); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> CustSeq
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.CustSeq); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> CustType
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.CustType); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Datefld
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Datefld); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Decifld1
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Decifld1); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Decifld2
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Decifld2); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Decifld3
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Decifld3); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Delterm
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Delterm); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Disc
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Disc); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> DltDescription
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.DltDescription); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> EdiOrder
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.EdiOrder); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> EffDate
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.EffDate); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> EndUserType
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.EndUserType); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> EntDescription
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.EntDescription); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> EstNum
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.EstNum); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ExchRate
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ExchRate); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ExpDate
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ExpDate); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ExportType
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ExportType); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ExternalConfirmationRef
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ExternalConfirmationRef); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> FixedRate
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.FixedRate); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> FormatBillToAddress
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.FormatBillToAddress); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> FormatShipToAddress
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.FormatShipToAddress); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> FovhdCostT
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.FovhdCostT); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Freight
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Freight); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> FrtTaxCode1
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.FrtTaxCode1); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> FrtTaxCode1Desc
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.FrtTaxCode1Desc); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> FrtTaxCode2
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.FrtTaxCode2); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> FrtTaxCode2Desc
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.FrtTaxCode2Desc); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> IncludeTaxInPrice
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.IncludeTaxInPrice); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.InWorkflow); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> IsExternal
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.IsExternal); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> LbrCostT
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.LbrCostT); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> LcrNum
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.LcrNum); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Logifld
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Logifld); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> MatlCostT
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.MatlCostT); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> MiscCharges
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.MiscCharges); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> MscTaxCode1
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.MscTaxCode1); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> MscTaxCode1Desc
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.MscTaxCode1Desc); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> MscTaxCode2
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.MscTaxCode2); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> MscTaxCode2Desc
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.MscTaxCode2Desc); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.NoteExistsFlag); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> OrderDate
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.OrderDate); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> OrderSource
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.OrderSource); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> OrigSite
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.OrigSite); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> OutCostT
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.OutCostT); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Phone
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Phone); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> PrcDescription
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.PrcDescription); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> PrepaidAmt
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.PrepaidAmt); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Price
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Price); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Pricecode
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Pricecode); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ProcessInd
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ProcessInd); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ProjectedDate
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ProjectedDate); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> QtyPackages
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.QtyPackages); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.RecordDate); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.RowPointer); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> SalesTax
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.SalesTax); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> SalesTax2
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.SalesTax2); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ShcDescription
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ShcDescription); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ShipCode
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ShipCode); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ShipEarly
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ShipEarly); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> ShipPartial
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.ShipPartial); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> SLCoSlsComms
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.SLCoSlsComms); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Slsman
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Slsman); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Stat
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Stat); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> TakenBy
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.TakenBy); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> TaxCode1
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.TaxCode1); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> TaxCode1Desc
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.TaxCode1Desc); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> TaxCode2
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.TaxCode2); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> TaxCode2Desc
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.TaxCode2Desc); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> TermsCode
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.TermsCode); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> TransNat
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.TransNat); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> TransNat2
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.TransNat2); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> TransNat2Description
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.TransNat2Description); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> TrmDescription
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.TrmDescription); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> TrnDescription
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.TrnDescription); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Type
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Type); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> UseExchRate
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.UseExchRate); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> VovhdCostT
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.VovhdCostT); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Weight
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Weight); }
                    }
                            public FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder> Whse
                    {
                        get { return new FilterExpression<IdoCustomerOrderHistoryBuilder, SLCohsFilterExpressionBuilder>(_builder, IdoCustomerOrderHistory.Whse); }
                    }
                    

                }
            }