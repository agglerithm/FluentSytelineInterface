using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                  public class SLArtrans : IdoConstants 
                { 
                           public const string IDO_NAME = "SLArtrans";
       public const string Acct = "Acct";
       public const string AcctUnit1 = "AcctUnit1";
       public const string AcctUnit2 = "AcctUnit2";
       public const string AcctUnit3 = "AcctUnit3";
       public const string AcctUnit4 = "AcctUnit4";
       public const string Active = "Active";
       public const string Amount = "Amount";
       public const string ApplyToInvNum = "ApplyToInvNum";
       public const string BankCode = "BankCode";
       public const string CadCurrCode = "CadCurrCode";
       public const string CadName = "CadName";
       public const string CheckSeq = "CheckSeq";
       public const string CoNum = "CoNum";
       public const string CorpCust = "CorpCust";
       public const string CustNum = "CustNum";
       public const string DerCustName = "DerCustName";
       public const string DerInvNum = "DerInvNum";
       public const string DerLangCode = "DerLangCode";
       public const string DerNdAmount = "DerNdAmount";
       public const string DerNewAmount = "DerNewAmount";
       public const string DerOdAmount = "DerOdAmount";
       public const string DerOldAmount = "DerOldAmount";
       public const string DerTotalDifference = "DerTotalDifference";
       public const string DerTypeDescription = "DerTypeDescription";
       public const string Description = "Description";
       public const string DiscAmt = "DiscAmt";
       public const string DiscDate = "DiscDate";
       public const string DoNum = "DoNum";
       public const string DueDate = "DueDate";
       public const string ExchRate = "ExchRate";
       public const string FixedRate = "FixedRate";
       public const string Freight = "Freight";
       public const string InvDate = "InvDate";
       public const string InvNum = "InvNum";
       public const string InvSeq = "InvSeq";
       public const string InWorkflow = "InWorkflow";
       public const string IssueDate = "IssueDate";
       public const string MiscCharges = "MiscCharges";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string PayType = "PayType";
       public const string PostFromCo = "PostFromCo";
       public const string RecordDate = "RecordDate";
       public const string Ref = "Ref";
       public const string Rma = "Rma";
       public const string RowPointer = "RowPointer";
       public const string SalesTax = "SalesTax";
       public const string SalesTax2 = "SalesTax2";
       public const string TaxCode1 = "TaxCode1";
       public const string TaxCode2 = "TaxCode2";
       public const string Type = "Type";


                }public class SLArtransBuilder  
                :   IdoBuilder<SLArtransBuilder, SLArtransFilterExpressionBuilder>
                {
                        public SLArtransBuilder() : base(SLArtrans.IDO_NAME) { }

                      public SLArtransBuilder Acct { get {  AddProperty(SLArtrans.Acct); return this; } }         public SLArtransBuilder AcctUnit1 { get {  AddProperty(SLArtrans.AcctUnit1); return this; } }         public SLArtransBuilder AcctUnit2 { get {  AddProperty(SLArtrans.AcctUnit2); return this; } }         public SLArtransBuilder AcctUnit3 { get {  AddProperty(SLArtrans.AcctUnit3); return this; } }         public SLArtransBuilder AcctUnit4 { get {  AddProperty(SLArtrans.AcctUnit4); return this; } }         public SLArtransBuilder Active { get {  AddProperty(SLArtrans.Active); return this; } }         public SLArtransBuilder Amount { get {  AddProperty(SLArtrans.Amount); return this; } }         public SLArtransBuilder ApplyToInvNum { get {  AddProperty(SLArtrans.ApplyToInvNum); return this; } }         public SLArtransBuilder BankCode { get {  AddProperty(SLArtrans.BankCode); return this; } }         public SLArtransBuilder CadCurrCode { get {  AddProperty(SLArtrans.CadCurrCode); return this; } }         public SLArtransBuilder CadName { get {  AddProperty(SLArtrans.CadName); return this; } }         public SLArtransBuilder CheckSeq { get {  AddProperty(SLArtrans.CheckSeq); return this; } }         public SLArtransBuilder CoNum { get {  AddProperty(SLArtrans.CoNum); return this; } }         public SLArtransBuilder CorpCust { get {  AddProperty(SLArtrans.CorpCust); return this; } }         public SLArtransBuilder CustNum { get {  AddProperty(SLArtrans.CustNum); return this; } }         public SLArtransBuilder DerCustName { get {  AddProperty(SLArtrans.DerCustName); return this; } }         public SLArtransBuilder DerInvNum { get {  AddProperty(SLArtrans.DerInvNum); return this; } }         public SLArtransBuilder DerLangCode { get {  AddProperty(SLArtrans.DerLangCode); return this; } }         public SLArtransBuilder DerNdAmount { get {  AddProperty(SLArtrans.DerNdAmount); return this; } }         public SLArtransBuilder DerNewAmount { get {  AddProperty(SLArtrans.DerNewAmount); return this; } }         public SLArtransBuilder DerOdAmount { get {  AddProperty(SLArtrans.DerOdAmount); return this; } }         public SLArtransBuilder DerOldAmount { get {  AddProperty(SLArtrans.DerOldAmount); return this; } }         public SLArtransBuilder DerTotalDifference { get {  AddProperty(SLArtrans.DerTotalDifference); return this; } }         public SLArtransBuilder DerTypeDescription { get {  AddProperty(SLArtrans.DerTypeDescription); return this; } }         public SLArtransBuilder Description { get {  AddProperty(SLArtrans.Description); return this; } }         public SLArtransBuilder DiscAmt { get {  AddProperty(SLArtrans.DiscAmt); return this; } }         public SLArtransBuilder DiscDate { get {  AddProperty(SLArtrans.DiscDate); return this; } }         public SLArtransBuilder DoNum { get {  AddProperty(SLArtrans.DoNum); return this; } }         public SLArtransBuilder DueDate { get {  AddProperty(SLArtrans.DueDate); return this; } }         public SLArtransBuilder ExchRate { get {  AddProperty(SLArtrans.ExchRate); return this; } }         public SLArtransBuilder FixedRate { get {  AddProperty(SLArtrans.FixedRate); return this; } }         public SLArtransBuilder Freight { get {  AddProperty(SLArtrans.Freight); return this; } }         public SLArtransBuilder InvDate { get {  AddProperty(SLArtrans.InvDate); return this; } }         public SLArtransBuilder InvNum { get {  AddProperty(SLArtrans.InvNum); return this; } }         public SLArtransBuilder InvSeq { get {  AddProperty(SLArtrans.InvSeq); return this; } }         public SLArtransBuilder InWorkflow { get {  AddProperty(SLArtrans.InWorkflow); return this; } }         public SLArtransBuilder IssueDate { get {  AddProperty(SLArtrans.IssueDate); return this; } }         public SLArtransBuilder MiscCharges { get {  AddProperty(SLArtrans.MiscCharges); return this; } }         public SLArtransBuilder NoteExistsFlag { get {  AddProperty(SLArtrans.NoteExistsFlag); return this; } }         public SLArtransBuilder PayType { get {  AddProperty(SLArtrans.PayType); return this; } }         public SLArtransBuilder PostFromCo { get {  AddProperty(SLArtrans.PostFromCo); return this; } }         public SLArtransBuilder RecordDate { get {  AddProperty(SLArtrans.RecordDate); return this; } }         public SLArtransBuilder Ref { get {  AddProperty(SLArtrans.Ref); return this; } }         public SLArtransBuilder Rma { get {  AddProperty(SLArtrans.Rma); return this; } }         public SLArtransBuilder RowPointer { get {  AddProperty(SLArtrans.RowPointer); return this; } }         public SLArtransBuilder SalesTax { get {  AddProperty(SLArtrans.SalesTax); return this; } }         public SLArtransBuilder SalesTax2 { get {  AddProperty(SLArtrans.SalesTax2); return this; } }         public SLArtransBuilder TaxCode1 { get {  AddProperty(SLArtrans.TaxCode1); return this; } }         public SLArtransBuilder TaxCode2 { get {  AddProperty(SLArtrans.TaxCode2); return this; } }         public SLArtransBuilder Type { get {  AddProperty(SLArtrans.Type); return this; } }   

                }public class SLArtransFilterExpressionBuilder  
                :   FilterExpressionBuilder<SLArtransBuilder>
                [
                        public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> Acct
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.Acct); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> AcctUnit1
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.AcctUnit1); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> AcctUnit2
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.AcctUnit2); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> AcctUnit3
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.AcctUnit3); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> AcctUnit4
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.AcctUnit4); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> Active
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.Active); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> Amount
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.Amount); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> ApplyToInvNum
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.ApplyToInvNum); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> BankCode
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.BankCode); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> CadCurrCode
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.CadCurrCode); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> CadName
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.CadName); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> CheckSeq
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.CheckSeq); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> CoNum
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.CoNum); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> CorpCust
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.CorpCust); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> CustNum
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.CustNum); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DerCustName
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DerCustName); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DerInvNum
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DerInvNum); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DerLangCode
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DerLangCode); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DerNdAmount
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DerNdAmount); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DerNewAmount
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DerNewAmount); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DerOdAmount
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DerOdAmount); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DerOldAmount
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DerOldAmount); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DerTotalDifference
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DerTotalDifference); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DerTypeDescription
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DerTypeDescription); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> Description
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.Description); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DiscAmt
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DiscAmt); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DiscDate
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DiscDate); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DoNum
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DoNum); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> DueDate
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.DueDate); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> ExchRate
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.ExchRate); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> FixedRate
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.FixedRate); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> Freight
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.Freight); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> InvDate
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.InvDate); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> InvNum
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.InvNum); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> InvSeq
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.InvSeq); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.InWorkflow); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> IssueDate
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.IssueDate); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> MiscCharges
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.MiscCharges); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.NoteExistsFlag); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> PayType
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.PayType); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> PostFromCo
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.PostFromCo); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.RecordDate); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> Ref
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.Ref); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> Rma
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.Rma); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.RowPointer); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> SalesTax
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.SalesTax); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> SalesTax2
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.SalesTax2); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> TaxCode1
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.TaxCode1); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> TaxCode2
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.TaxCode2); }
                    }
                            public FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder> Type
                    {
                        get { return new FilterExpression<SLArtransBuilder, SLArtransFilterExpressionBuilder>(_builder, SLArtrans.Type); }
                    }
                    

                }
            }