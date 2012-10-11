using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                  public class SLAptrxds : IdoConstants 
                { 
                           public const string IDO_NAME = "SLAptrxds";
       public const string Acct = "Acct";
       public const string AcctUnit1 = "AcctUnit1";
       public const string AcctUnit2 = "AcctUnit2";
       public const string AcctUnit3 = "AcctUnit3";
       public const string AcctUnit4 = "AcctUnit4";
       public const string Amount = "Amount";
       public const string AptrxBrokerageAmt = "AptrxBrokerageAmt";
       public const string AptrxDistDate = "AptrxDistDate";
       public const string AptrxDutyAmt = "AptrxDutyAmt";
       public const string AptrxExchRate = "AptrxExchRate";
       public const string AptrxFreight = "AptrxFreight";
       public const string AptrxGrnNum = "AptrxGrnNum";
       public const string AptrxInsuranceAmt = "AptrxInsuranceAmt";
       public const string AptrxInvAmt = "AptrxInvAmt";
       public const string AptrxInvDate = "AptrxInvDate";
       public const string AptrxInvNum = "AptrxInvNum";
       public const string AptrxLocFrtAmt = "AptrxLocFrtAmt";
       public const string AptrxMiscCharges = "AptrxMiscCharges";
       public const string AptrxPoNum = "AptrxPoNum";
       public const string AptrxPostFromPo = "AptrxPostFromPo";
       public const string AptrxPreRegister = "AptrxPreRegister";
       public const string AptrxPurchAmt = "AptrxPurchAmt";
       public const string AptrxRowPointer = "AptrxRowPointer";
       public const string AptrxSalesTax = "AptrxSalesTax";
       public const string AptrxSalesTax_2 = "AptrxSalesTax_2";
       public const string AptrxTaxCode1 = "AptrxTaxCode1";
       public const string AptrxTaxCode2 = "AptrxTaxCode2";
       public const string AptrxType = "AptrxType";
       public const string ChartAccessUnit1 = "ChartAccessUnit1";
       public const string ChartAccessUnit2 = "ChartAccessUnit2";
       public const string ChartAccessUnit3 = "ChartAccessUnit3";
       public const string ChartAccessUnit4 = "ChartAccessUnit4";
       public const string ChartDescription = "ChartDescription";
       public const string CostCode = "CostCode";
       public const string CurrAmtFormat = "CurrAmtFormat";
       public const string DerDistributionTotal = "DerDistributionTotal";
       public const string DistSeq = "DistSeq";
       public const string InvNum = "InvNum";
       public const string InWorkflow = "InWorkflow";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string ProjNum = "ProjNum";
       public const string RecordDate = "RecordDate";
       public const string RowPointer = "RowPointer";
       public const string TaskNum = "TaskNum";
       public const string TaxBasis = "TaxBasis";
       public const string TaxCode = "TaxCode";
       public const string TaxCodeE = "TaxCodeE";
       public const string TaxSystem = "TaxSystem";
       public const string Tc1Description = "Tc1Description";
       public const string Tc2Description = "Tc2Description";
       public const string Tc3Description = "Tc3Description";
       public const string Tc3TaxRate = "Tc3TaxRate";
       public const string Tc4Description = "Tc4Description";
       public const string VenaddName = "VenaddName";
       public const string VenaddVendNum = "VenaddVendNum";
       public const string VenCurrCode = "VenCurrCode";
       public const string VendNum = "VendNum";
       public const string Voucher = "Voucher";


                }public class SLAptrxdsBuilder  
                :   IdoBuilder<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>
                {
                        public SLAptrxdsBuilder() : base(SLAptrxds.IDO_NAME) { }

                      public SLAptrxdsBuilder Acct { get {  AddProperty(SLAptrxds.Acct); return this; } }         public SLAptrxdsBuilder AcctUnit1 { get {  AddProperty(SLAptrxds.AcctUnit1); return this; } }         public SLAptrxdsBuilder AcctUnit2 { get {  AddProperty(SLAptrxds.AcctUnit2); return this; } }         public SLAptrxdsBuilder AcctUnit3 { get {  AddProperty(SLAptrxds.AcctUnit3); return this; } }         public SLAptrxdsBuilder AcctUnit4 { get {  AddProperty(SLAptrxds.AcctUnit4); return this; } }         public SLAptrxdsBuilder Amount { get {  AddProperty(SLAptrxds.Amount); return this; } }         public SLAptrxdsBuilder AptrxBrokerageAmt { get {  AddProperty(SLAptrxds.AptrxBrokerageAmt); return this; } }         public SLAptrxdsBuilder AptrxDistDate { get {  AddProperty(SLAptrxds.AptrxDistDate); return this; } }         public SLAptrxdsBuilder AptrxDutyAmt { get {  AddProperty(SLAptrxds.AptrxDutyAmt); return this; } }         public SLAptrxdsBuilder AptrxExchRate { get {  AddProperty(SLAptrxds.AptrxExchRate); return this; } }         public SLAptrxdsBuilder AptrxFreight { get {  AddProperty(SLAptrxds.AptrxFreight); return this; } }         public SLAptrxdsBuilder AptrxGrnNum { get {  AddProperty(SLAptrxds.AptrxGrnNum); return this; } }         public SLAptrxdsBuilder AptrxInsuranceAmt { get {  AddProperty(SLAptrxds.AptrxInsuranceAmt); return this; } }         public SLAptrxdsBuilder AptrxInvAmt { get {  AddProperty(SLAptrxds.AptrxInvAmt); return this; } }         public SLAptrxdsBuilder AptrxInvDate { get {  AddProperty(SLAptrxds.AptrxInvDate); return this; } }         public SLAptrxdsBuilder AptrxInvNum { get {  AddProperty(SLAptrxds.AptrxInvNum); return this; } }         public SLAptrxdsBuilder AptrxLocFrtAmt { get {  AddProperty(SLAptrxds.AptrxLocFrtAmt); return this; } }         public SLAptrxdsBuilder AptrxMiscCharges { get {  AddProperty(SLAptrxds.AptrxMiscCharges); return this; } }         public SLAptrxdsBuilder AptrxPoNum { get {  AddProperty(SLAptrxds.AptrxPoNum); return this; } }         public SLAptrxdsBuilder AptrxPostFromPo { get {  AddProperty(SLAptrxds.AptrxPostFromPo); return this; } }         public SLAptrxdsBuilder AptrxPreRegister { get {  AddProperty(SLAptrxds.AptrxPreRegister); return this; } }         public SLAptrxdsBuilder AptrxPurchAmt { get {  AddProperty(SLAptrxds.AptrxPurchAmt); return this; } }         public SLAptrxdsBuilder AptrxRowPointer { get {  AddProperty(SLAptrxds.AptrxRowPointer); return this; } }         public SLAptrxdsBuilder AptrxSalesTax { get {  AddProperty(SLAptrxds.AptrxSalesTax); return this; } }         public SLAptrxdsBuilder AptrxSalesTax_2 { get {  AddProperty(SLAptrxds.AptrxSalesTax_2); return this; } }         public SLAptrxdsBuilder AptrxTaxCode1 { get {  AddProperty(SLAptrxds.AptrxTaxCode1); return this; } }         public SLAptrxdsBuilder AptrxTaxCode2 { get {  AddProperty(SLAptrxds.AptrxTaxCode2); return this; } }         public SLAptrxdsBuilder AptrxType { get {  AddProperty(SLAptrxds.AptrxType); return this; } }         public SLAptrxdsBuilder ChartAccessUnit1 { get {  AddProperty(SLAptrxds.ChartAccessUnit1); return this; } }         public SLAptrxdsBuilder ChartAccessUnit2 { get {  AddProperty(SLAptrxds.ChartAccessUnit2); return this; } }         public SLAptrxdsBuilder ChartAccessUnit3 { get {  AddProperty(SLAptrxds.ChartAccessUnit3); return this; } }         public SLAptrxdsBuilder ChartAccessUnit4 { get {  AddProperty(SLAptrxds.ChartAccessUnit4); return this; } }         public SLAptrxdsBuilder ChartDescription { get {  AddProperty(SLAptrxds.ChartDescription); return this; } }         public SLAptrxdsBuilder CostCode { get {  AddProperty(SLAptrxds.CostCode); return this; } }         public SLAptrxdsBuilder CurrAmtFormat { get {  AddProperty(SLAptrxds.CurrAmtFormat); return this; } }         public SLAptrxdsBuilder DerDistributionTotal { get {  AddProperty(SLAptrxds.DerDistributionTotal); return this; } }         public SLAptrxdsBuilder DistSeq { get {  AddProperty(SLAptrxds.DistSeq); return this; } }         public SLAptrxdsBuilder InvNum { get {  AddProperty(SLAptrxds.InvNum); return this; } }         public SLAptrxdsBuilder InWorkflow { get {  AddProperty(SLAptrxds.InWorkflow); return this; } }         public SLAptrxdsBuilder NoteExistsFlag { get {  AddProperty(SLAptrxds.NoteExistsFlag); return this; } }         public SLAptrxdsBuilder ProjNum { get {  AddProperty(SLAptrxds.ProjNum); return this; } }         public SLAptrxdsBuilder RecordDate { get {  AddProperty(SLAptrxds.RecordDate); return this; } }         public SLAptrxdsBuilder RowPointer { get {  AddProperty(SLAptrxds.RowPointer); return this; } }         public SLAptrxdsBuilder TaskNum { get {  AddProperty(SLAptrxds.TaskNum); return this; } }         public SLAptrxdsBuilder TaxBasis { get {  AddProperty(SLAptrxds.TaxBasis); return this; } }         public SLAptrxdsBuilder TaxCode { get {  AddProperty(SLAptrxds.TaxCode); return this; } }         public SLAptrxdsBuilder TaxCodeE { get {  AddProperty(SLAptrxds.TaxCodeE); return this; } }         public SLAptrxdsBuilder TaxSystem { get {  AddProperty(SLAptrxds.TaxSystem); return this; } }         public SLAptrxdsBuilder Tc1Description { get {  AddProperty(SLAptrxds.Tc1Description); return this; } }         public SLAptrxdsBuilder Tc2Description { get {  AddProperty(SLAptrxds.Tc2Description); return this; } }         public SLAptrxdsBuilder Tc3Description { get {  AddProperty(SLAptrxds.Tc3Description); return this; } }         public SLAptrxdsBuilder Tc3TaxRate { get {  AddProperty(SLAptrxds.Tc3TaxRate); return this; } }         public SLAptrxdsBuilder Tc4Description { get {  AddProperty(SLAptrxds.Tc4Description); return this; } }         public SLAptrxdsBuilder VenaddName { get {  AddProperty(SLAptrxds.VenaddName); return this; } }         public SLAptrxdsBuilder VenaddVendNum { get {  AddProperty(SLAptrxds.VenaddVendNum); return this; } }         public SLAptrxdsBuilder VenCurrCode { get {  AddProperty(SLAptrxds.VenCurrCode); return this; } }         public SLAptrxdsBuilder VendNum { get {  AddProperty(SLAptrxds.VendNum); return this; } }         public SLAptrxdsBuilder Voucher { get {  AddProperty(SLAptrxds.Voucher); return this; } }   

                }public class SLAptrxdsFilterExpressionBuilder  
                :   FilterExpressionBuilder<SLAptrxdsBuilder>
                [
                        public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> Acct
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.Acct); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AcctUnit1
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AcctUnit1); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AcctUnit2
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AcctUnit2); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AcctUnit3
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AcctUnit3); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AcctUnit4
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AcctUnit4); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> Amount
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.Amount); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxBrokerageAmt
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxBrokerageAmt); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxDistDate
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxDistDate); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxDutyAmt
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxDutyAmt); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxExchRate
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxExchRate); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxFreight
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxFreight); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxGrnNum
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxGrnNum); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxInsuranceAmt
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxInsuranceAmt); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxInvAmt
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxInvAmt); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxInvDate
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxInvDate); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxInvNum
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxInvNum); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxLocFrtAmt
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxLocFrtAmt); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxMiscCharges
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxMiscCharges); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxPoNum
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxPoNum); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxPostFromPo
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxPostFromPo); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxPreRegister
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxPreRegister); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxPurchAmt
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxPurchAmt); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxRowPointer
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxRowPointer); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxSalesTax
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxSalesTax); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxSalesTax_2
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxSalesTax_2); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxTaxCode1
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxTaxCode1); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxTaxCode2
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxTaxCode2); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> AptrxType
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.AptrxType); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> ChartAccessUnit1
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.ChartAccessUnit1); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> ChartAccessUnit2
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.ChartAccessUnit2); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> ChartAccessUnit3
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.ChartAccessUnit3); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> ChartAccessUnit4
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.ChartAccessUnit4); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> ChartDescription
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.ChartDescription); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> CostCode
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.CostCode); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> CurrAmtFormat
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.CurrAmtFormat); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> DerDistributionTotal
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.DerDistributionTotal); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> DistSeq
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.DistSeq); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> InvNum
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.InvNum); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.InWorkflow); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.NoteExistsFlag); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> ProjNum
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.ProjNum); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.RecordDate); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.RowPointer); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> TaskNum
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.TaskNum); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> TaxBasis
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.TaxBasis); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> TaxCode
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.TaxCode); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> TaxCodeE
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.TaxCodeE); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> TaxSystem
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.TaxSystem); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> Tc1Description
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.Tc1Description); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> Tc2Description
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.Tc2Description); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> Tc3Description
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.Tc3Description); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> Tc3TaxRate
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.Tc3TaxRate); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> Tc4Description
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.Tc4Description); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> VenaddName
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.VenaddName); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> VenaddVendNum
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.VenaddVendNum); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> VenCurrCode
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.VenCurrCode); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> VendNum
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.VendNum); }
                    }
                            public FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder> Voucher
                    {
                        get { return new FilterExpression<SLAptrxdsBuilder, SLAptrxdsFilterExpressionBuilder>(_builder, SLAptrxds.Voucher); }
                    }
                    

                }
            }