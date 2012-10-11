using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                  public class SLAptrxs : IdoConstants 
                { 
                           public const string IDO_NAME = "SLAptrxs";
       public const string ApAcct = "ApAcct";
       public const string ApAcctUnit1 = "ApAcctUnit1";
       public const string ApAcctUnit2 = "ApAcctUnit2";
       public const string ApAcctUnit3 = "ApAcctUnit3";
       public const string ApAcctUnit4 = "ApAcctUnit4";
       public const string Authorizer = "Authorizer";
       public const string AuthStatus = "AuthStatus";
       public const string BrokerageAmt = "BrokerageAmt";
       public const string BuilderPoNum = "BuilderPoNum";
       public const string BuilderPoOrigSite = "BuilderPoOrigSite";
       public const string BuilderVoucher = "BuilderVoucher";
       public const string BuilderVoucherOrigSite = "BuilderVoucherOrigSite";
       public const string ChaAccessUnit1 = "ChaAccessUnit1";
       public const string ChaAccessUnit2 = "ChaAccessUnit2";
       public const string ChaAccessUnit3 = "ChaAccessUnit3";
       public const string ChaAccessUnit4 = "ChaAccessUnit4";
       public const string ChaDescription = "ChaDescription";
       public const string CurrAmtFormat = "CurrAmtFormat";
       public const string CurrPlaces = "CurrPlaces";
       public const string DerDistExists = "DerDistExists";
       public const string DiscAmt = "DiscAmt";
       public const string DiscDate = "DiscDate";
       public const string DiscDays = "DiscDays";
       public const string DiscPct = "DiscPct";
       public const string DistDate = "DistDate";
       public const string DueDate = "DueDate";
       public const string DueDays = "DueDays";
       public const string DutyAmt = "DutyAmt";
       public const string ExchRate = "ExchRate";
       public const string FixedRate = "FixedRate";
       public const string Freight = "Freight";
       public const string GrnNum = "GrnNum";
       public const string IncludesTax = "IncludesTax";
       public const string IncludeTaxInCost = "IncludeTaxInCost";
       public const string InsuranceAmt = "InsuranceAmt";
       public const string InvAmt = "InvAmt";
       public const string InvDate = "InvDate";
       public const string InvNum = "InvNum";
       public const string InWorkflow = "InWorkflow";
       public const string LocFrtAmt = "LocFrtAmt";
       public const string MiscCharges = "MiscCharges";
       public const string NonDiscAmt = "NonDiscAmt";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string PoNum = "PoNum";
       public const string PostFromPo = "PostFromPo";
       public const string PreRegister = "PreRegister";
       public const string ProxCode = "ProxCode";
       public const string ProxDay = "ProxDay";
       public const string PurchAmt = "PurchAmt";
       public const string RecordDate = "RecordDate";
       public const string Ref = "Ref";
       public const string RowPointer = "RowPointer";
       public const string SalesTax = "SalesTax";
       public const string SalesTax_2 = "SalesTax_2";
       public const string ShowInDropDownList = "ShowInDropDownList";
       public const string TaxCode1 = "TaxCode1";
       public const string TaxCode2 = "TaxCode2";
       public const string Tc1Description = "Tc1Description";
       public const string Tc2Description = "Tc2Description";
       public const string Txt = "Txt";
       public const string Type = "Type";
       public const string UbEnable = "UbEnable";
       public const string UbEnableSalesTax = "UbEnableSalesTax";
       public const string UbEnableSalesTax2 = "UbEnableSalesTax2";
       public const string UbGenerateDistributions = "UbGenerateDistributions";
       public const string UbToSite = "UbToSite";
       public const string UbVendNum = "UbVendNum";
       public const string VenCurrCode = "VenCurrCode";
       public const string VendaddrName = "VendaddrName";
       public const string VendNum = "VendNum";
       public const string Voucher = "Voucher";


                }public class SLAptrxsBuilder  
                :   IdoBuilder<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>
                {
                        public SLAptrxsBuilder() : base(SLAptrxs.IDO_NAME) { }

                      public SLAptrxsBuilder ApAcct { get {  AddProperty(SLAptrxs.ApAcct); return this; } }         public SLAptrxsBuilder ApAcctUnit1 { get {  AddProperty(SLAptrxs.ApAcctUnit1); return this; } }         public SLAptrxsBuilder ApAcctUnit2 { get {  AddProperty(SLAptrxs.ApAcctUnit2); return this; } }         public SLAptrxsBuilder ApAcctUnit3 { get {  AddProperty(SLAptrxs.ApAcctUnit3); return this; } }         public SLAptrxsBuilder ApAcctUnit4 { get {  AddProperty(SLAptrxs.ApAcctUnit4); return this; } }         public SLAptrxsBuilder Authorizer { get {  AddProperty(SLAptrxs.Authorizer); return this; } }         public SLAptrxsBuilder AuthStatus { get {  AddProperty(SLAptrxs.AuthStatus); return this; } }         public SLAptrxsBuilder BrokerageAmt { get {  AddProperty(SLAptrxs.BrokerageAmt); return this; } }         public SLAptrxsBuilder BuilderPoNum { get {  AddProperty(SLAptrxs.BuilderPoNum); return this; } }         public SLAptrxsBuilder BuilderPoOrigSite { get {  AddProperty(SLAptrxs.BuilderPoOrigSite); return this; } }         public SLAptrxsBuilder BuilderVoucher { get {  AddProperty(SLAptrxs.BuilderVoucher); return this; } }         public SLAptrxsBuilder BuilderVoucherOrigSite { get {  AddProperty(SLAptrxs.BuilderVoucherOrigSite); return this; } }         public SLAptrxsBuilder ChaAccessUnit1 { get {  AddProperty(SLAptrxs.ChaAccessUnit1); return this; } }         public SLAptrxsBuilder ChaAccessUnit2 { get {  AddProperty(SLAptrxs.ChaAccessUnit2); return this; } }         public SLAptrxsBuilder ChaAccessUnit3 { get {  AddProperty(SLAptrxs.ChaAccessUnit3); return this; } }         public SLAptrxsBuilder ChaAccessUnit4 { get {  AddProperty(SLAptrxs.ChaAccessUnit4); return this; } }         public SLAptrxsBuilder ChaDescription { get {  AddProperty(SLAptrxs.ChaDescription); return this; } }         public SLAptrxsBuilder CurrAmtFormat { get {  AddProperty(SLAptrxs.CurrAmtFormat); return this; } }         public SLAptrxsBuilder CurrPlaces { get {  AddProperty(SLAptrxs.CurrPlaces); return this; } }         public SLAptrxsBuilder DerDistExists { get {  AddProperty(SLAptrxs.DerDistExists); return this; } }         public SLAptrxsBuilder DiscAmt { get {  AddProperty(SLAptrxs.DiscAmt); return this; } }         public SLAptrxsBuilder DiscDate { get {  AddProperty(SLAptrxs.DiscDate); return this; } }         public SLAptrxsBuilder DiscDays { get {  AddProperty(SLAptrxs.DiscDays); return this; } }         public SLAptrxsBuilder DiscPct { get {  AddProperty(SLAptrxs.DiscPct); return this; } }         public SLAptrxsBuilder DistDate { get {  AddProperty(SLAptrxs.DistDate); return this; } }         public SLAptrxsBuilder DueDate { get {  AddProperty(SLAptrxs.DueDate); return this; } }         public SLAptrxsBuilder DueDays { get {  AddProperty(SLAptrxs.DueDays); return this; } }         public SLAptrxsBuilder DutyAmt { get {  AddProperty(SLAptrxs.DutyAmt); return this; } }         public SLAptrxsBuilder ExchRate { get {  AddProperty(SLAptrxs.ExchRate); return this; } }         public SLAptrxsBuilder FixedRate { get {  AddProperty(SLAptrxs.FixedRate); return this; } }         public SLAptrxsBuilder Freight { get {  AddProperty(SLAptrxs.Freight); return this; } }         public SLAptrxsBuilder GrnNum { get {  AddProperty(SLAptrxs.GrnNum); return this; } }         public SLAptrxsBuilder IncludesTax { get {  AddProperty(SLAptrxs.IncludesTax); return this; } }         public SLAptrxsBuilder IncludeTaxInCost { get {  AddProperty(SLAptrxs.IncludeTaxInCost); return this; } }         public SLAptrxsBuilder InsuranceAmt { get {  AddProperty(SLAptrxs.InsuranceAmt); return this; } }         public SLAptrxsBuilder InvAmt { get {  AddProperty(SLAptrxs.InvAmt); return this; } }         public SLAptrxsBuilder InvDate { get {  AddProperty(SLAptrxs.InvDate); return this; } }         public SLAptrxsBuilder InvNum { get {  AddProperty(SLAptrxs.InvNum); return this; } }         public SLAptrxsBuilder InWorkflow { get {  AddProperty(SLAptrxs.InWorkflow); return this; } }         public SLAptrxsBuilder LocFrtAmt { get {  AddProperty(SLAptrxs.LocFrtAmt); return this; } }         public SLAptrxsBuilder MiscCharges { get {  AddProperty(SLAptrxs.MiscCharges); return this; } }         public SLAptrxsBuilder NonDiscAmt { get {  AddProperty(SLAptrxs.NonDiscAmt); return this; } }         public SLAptrxsBuilder NoteExistsFlag { get {  AddProperty(SLAptrxs.NoteExistsFlag); return this; } }         public SLAptrxsBuilder PoNum { get {  AddProperty(SLAptrxs.PoNum); return this; } }         public SLAptrxsBuilder PostFromPo { get {  AddProperty(SLAptrxs.PostFromPo); return this; } }         public SLAptrxsBuilder PreRegister { get {  AddProperty(SLAptrxs.PreRegister); return this; } }         public SLAptrxsBuilder ProxCode { get {  AddProperty(SLAptrxs.ProxCode); return this; } }         public SLAptrxsBuilder ProxDay { get {  AddProperty(SLAptrxs.ProxDay); return this; } }         public SLAptrxsBuilder PurchAmt { get {  AddProperty(SLAptrxs.PurchAmt); return this; } }         public SLAptrxsBuilder RecordDate { get {  AddProperty(SLAptrxs.RecordDate); return this; } }         public SLAptrxsBuilder Ref { get {  AddProperty(SLAptrxs.Ref); return this; } }         public SLAptrxsBuilder RowPointer { get {  AddProperty(SLAptrxs.RowPointer); return this; } }         public SLAptrxsBuilder SalesTax { get {  AddProperty(SLAptrxs.SalesTax); return this; } }         public SLAptrxsBuilder SalesTax_2 { get {  AddProperty(SLAptrxs.SalesTax_2); return this; } }         public SLAptrxsBuilder ShowInDropDownList { get {  AddProperty(SLAptrxs.ShowInDropDownList); return this; } }         public SLAptrxsBuilder TaxCode1 { get {  AddProperty(SLAptrxs.TaxCode1); return this; } }         public SLAptrxsBuilder TaxCode2 { get {  AddProperty(SLAptrxs.TaxCode2); return this; } }         public SLAptrxsBuilder Tc1Description { get {  AddProperty(SLAptrxs.Tc1Description); return this; } }         public SLAptrxsBuilder Tc2Description { get {  AddProperty(SLAptrxs.Tc2Description); return this; } }         public SLAptrxsBuilder Txt { get {  AddProperty(SLAptrxs.Txt); return this; } }         public SLAptrxsBuilder Type { get {  AddProperty(SLAptrxs.Type); return this; } }         public SLAptrxsBuilder UbEnable { get {  AddProperty(SLAptrxs.UbEnable); return this; } }         public SLAptrxsBuilder UbEnableSalesTax { get {  AddProperty(SLAptrxs.UbEnableSalesTax); return this; } }         public SLAptrxsBuilder UbEnableSalesTax2 { get {  AddProperty(SLAptrxs.UbEnableSalesTax2); return this; } }         public SLAptrxsBuilder UbGenerateDistributions { get {  AddProperty(SLAptrxs.UbGenerateDistributions); return this; } }         public SLAptrxsBuilder UbToSite { get {  AddProperty(SLAptrxs.UbToSite); return this; } }         public SLAptrxsBuilder UbVendNum { get {  AddProperty(SLAptrxs.UbVendNum); return this; } }         public SLAptrxsBuilder VenCurrCode { get {  AddProperty(SLAptrxs.VenCurrCode); return this; } }         public SLAptrxsBuilder VendaddrName { get {  AddProperty(SLAptrxs.VendaddrName); return this; } }         public SLAptrxsBuilder VendNum { get {  AddProperty(SLAptrxs.VendNum); return this; } }         public SLAptrxsBuilder Voucher { get {  AddProperty(SLAptrxs.Voucher); return this; } }   

                }public class SLAptrxsFilterExpressionBuilder  
                :   FilterExpressionBuilder<SLAptrxsBuilder>
                [
                        public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ApAcct
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ApAcct); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ApAcctUnit1
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ApAcctUnit1); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ApAcctUnit2
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ApAcctUnit2); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ApAcctUnit3
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ApAcctUnit3); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ApAcctUnit4
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ApAcctUnit4); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> Authorizer
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.Authorizer); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> AuthStatus
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.AuthStatus); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> BrokerageAmt
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.BrokerageAmt); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> BuilderPoNum
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.BuilderPoNum); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> BuilderPoOrigSite
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.BuilderPoOrigSite); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> BuilderVoucher
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.BuilderVoucher); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> BuilderVoucherOrigSite
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.BuilderVoucherOrigSite); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ChaAccessUnit1
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ChaAccessUnit1); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ChaAccessUnit2
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ChaAccessUnit2); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ChaAccessUnit3
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ChaAccessUnit3); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ChaAccessUnit4
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ChaAccessUnit4); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ChaDescription
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ChaDescription); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> CurrAmtFormat
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.CurrAmtFormat); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> CurrPlaces
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.CurrPlaces); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> DerDistExists
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.DerDistExists); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> DiscAmt
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.DiscAmt); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> DiscDate
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.DiscDate); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> DiscDays
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.DiscDays); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> DiscPct
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.DiscPct); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> DistDate
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.DistDate); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> DueDate
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.DueDate); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> DueDays
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.DueDays); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> DutyAmt
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.DutyAmt); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ExchRate
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ExchRate); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> FixedRate
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.FixedRate); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> Freight
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.Freight); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> GrnNum
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.GrnNum); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> IncludesTax
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.IncludesTax); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> IncludeTaxInCost
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.IncludeTaxInCost); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> InsuranceAmt
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.InsuranceAmt); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> InvAmt
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.InvAmt); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> InvDate
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.InvDate); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> InvNum
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.InvNum); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.InWorkflow); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> LocFrtAmt
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.LocFrtAmt); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> MiscCharges
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.MiscCharges); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> NonDiscAmt
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.NonDiscAmt); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.NoteExistsFlag); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> PoNum
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.PoNum); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> PostFromPo
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.PostFromPo); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> PreRegister
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.PreRegister); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ProxCode
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ProxCode); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ProxDay
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ProxDay); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> PurchAmt
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.PurchAmt); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.RecordDate); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> Ref
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.Ref); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.RowPointer); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> SalesTax
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.SalesTax); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> SalesTax_2
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.SalesTax_2); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> ShowInDropDownList
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.ShowInDropDownList); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> TaxCode1
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.TaxCode1); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> TaxCode2
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.TaxCode2); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> Tc1Description
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.Tc1Description); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> Tc2Description
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.Tc2Description); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> Txt
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.Txt); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> Type
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.Type); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> UbEnable
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.UbEnable); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> UbEnableSalesTax
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.UbEnableSalesTax); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> UbEnableSalesTax2
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.UbEnableSalesTax2); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> UbGenerateDistributions
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.UbGenerateDistributions); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> UbToSite
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.UbToSite); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> UbVendNum
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.UbVendNum); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> VenCurrCode
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.VenCurrCode); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> VendaddrName
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.VendaddrName); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> VendNum
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.VendNum); }
                    }
                            public FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder> Voucher
                    {
                        get { return new FilterExpression<SLAptrxsBuilder, SLAptrxsFilterExpressionBuilder>(_builder, SLAptrxs.Voucher); }
                    }
                    

                }
            }