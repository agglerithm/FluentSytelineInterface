using SytelineInterface.Core;

namespace SytelineInterface.Dsl
{
    using Commands;

    public class IdoArTransaction : IdoConstants 
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


                }

            public class IdoArTransactionBuilder  
                :   IdoQueryBuilder<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>
                {
                        public IdoArTransactionBuilder(IExpressionInterpreter interpreter) : base(IdoArTransaction.IDO_NAME, interpreter) { }

                      public IdoArTransactionBuilder Acct { get {  AddProperty(IdoArTransaction.Acct); return this; }  } 
                          public IdoArTransactionBuilder AcctUnit1 { get {  AddProperty(IdoArTransaction.AcctUnit1); return this; }  } 
                          public IdoArTransactionBuilder AcctUnit2 { get {  AddProperty(IdoArTransaction.AcctUnit2); return this; }  } 
                          public IdoArTransactionBuilder AcctUnit3 { get {  AddProperty(IdoArTransaction.AcctUnit3); return this; }  } 
                          public IdoArTransactionBuilder AcctUnit4 { get {  AddProperty(IdoArTransaction.AcctUnit4); return this; }  } 
                          public IdoArTransactionBuilder Active { get {  AddProperty(IdoArTransaction.Active); return this; }  } 
                          public IdoArTransactionBuilder Amount { get {  AddProperty(IdoArTransaction.Amount); return this; }  } 
                          public IdoArTransactionBuilder ApplyToInvNum { get {  AddProperty(IdoArTransaction.ApplyToInvNum); return this; }  } 
                          public IdoArTransactionBuilder BankCode { get {  AddProperty(IdoArTransaction.BankCode); return this; }  } 
                          public IdoArTransactionBuilder CadCurrCode { get {  AddProperty(IdoArTransaction.CadCurrCode); return this; }  } 
                          public IdoArTransactionBuilder CadName { get {  AddProperty(IdoArTransaction.CadName); return this; }  } 
                          public IdoArTransactionBuilder CheckSeq { get {  AddProperty(IdoArTransaction.CheckSeq); return this; }  } 
                          public IdoArTransactionBuilder CoNum { get {  AddProperty(IdoArTransaction.CoNum); return this; }  } 
                          public IdoArTransactionBuilder CorpCust { get {  AddProperty(IdoArTransaction.CorpCust); return this; }  } 
                          public IdoArTransactionBuilder CustNum { get {  AddProperty(IdoArTransaction.CustNum); return this; }  } 
                          public IdoArTransactionBuilder DerCustName { get {  AddProperty(IdoArTransaction.DerCustName); return this; }  } 
                          public IdoArTransactionBuilder DerInvNum { get {  AddProperty(IdoArTransaction.DerInvNum); return this; }  } 
                          public IdoArTransactionBuilder DerLangCode { get {  AddProperty(IdoArTransaction.DerLangCode); return this; }  } 
                          public IdoArTransactionBuilder DerNdAmount { get {  AddProperty(IdoArTransaction.DerNdAmount); return this; }  } 
                          public IdoArTransactionBuilder DerNewAmount { get {  AddProperty(IdoArTransaction.DerNewAmount); return this; }  } 
                          public IdoArTransactionBuilder DerOdAmount { get {  AddProperty(IdoArTransaction.DerOdAmount); return this; }  } 
                          public IdoArTransactionBuilder DerOldAmount { get {  AddProperty(IdoArTransaction.DerOldAmount); return this; }  } 
                          public IdoArTransactionBuilder DerTotalDifference { get {  AddProperty(IdoArTransaction.DerTotalDifference); return this; }  } 
                          public IdoArTransactionBuilder DerTypeDescription { get {  AddProperty(IdoArTransaction.DerTypeDescription); return this; }  } 
                          public IdoArTransactionBuilder Description { get {  AddProperty(IdoArTransaction.Description); return this; }  } 
                          public IdoArTransactionBuilder DiscAmt { get {  AddProperty(IdoArTransaction.DiscAmt); return this; }  } 
                          public IdoArTransactionBuilder DiscDate { get {  AddProperty(IdoArTransaction.DiscDate); return this; }  } 
                          public IdoArTransactionBuilder DoNum { get {  AddProperty(IdoArTransaction.DoNum); return this; }  } 
                          public IdoArTransactionBuilder DueDate { get {  AddProperty(IdoArTransaction.DueDate); return this; }  } 
                          public IdoArTransactionBuilder ExchRate { get {  AddProperty(IdoArTransaction.ExchRate); return this; }  } 
                          public IdoArTransactionBuilder FixedRate { get {  AddProperty(IdoArTransaction.FixedRate); return this; }  } 
                          public IdoArTransactionBuilder Freight { get {  AddProperty(IdoArTransaction.Freight); return this; }  } 
                          public IdoArTransactionBuilder InvDate { get {  AddProperty(IdoArTransaction.InvDate); return this; }  } 
                          public IdoArTransactionBuilder InvNum { get {  AddProperty(IdoArTransaction.InvNum); return this; }  } 
                          public IdoArTransactionBuilder InvSeq { get {  AddProperty(IdoArTransaction.InvSeq); return this; }  } 
                          public IdoArTransactionBuilder InWorkflow { get {  AddProperty(IdoArTransaction.InWorkflow); return this; }  } 
                          public IdoArTransactionBuilder IssueDate { get {  AddProperty(IdoArTransaction.IssueDate); return this; }  } 
                          public IdoArTransactionBuilder MiscCharges { get {  AddProperty(IdoArTransaction.MiscCharges); return this; }  } 
                          public IdoArTransactionBuilder NoteExistsFlag { get {  AddProperty(IdoArTransaction.NoteExistsFlag); return this; }  } 
                          public IdoArTransactionBuilder PayType { get {  AddProperty(IdoArTransaction.PayType); return this; }  } 
                          public IdoArTransactionBuilder PostFromCo { get {  AddProperty(IdoArTransaction.PostFromCo); return this; }  } 
                          public IdoArTransactionBuilder RecordDate { get {  AddProperty(IdoArTransaction.RecordDate); return this; }  } 
                          public IdoArTransactionBuilder Ref { get {  AddProperty(IdoArTransaction.Ref); return this; }  } 
                          public IdoArTransactionBuilder Rma { get {  AddProperty(IdoArTransaction.Rma); return this; }  } 
                          public IdoArTransactionBuilder RowPointer { get {  AddProperty(IdoArTransaction.RowPointer); return this; }  } 
                          public IdoArTransactionBuilder SalesTax { get {  AddProperty(IdoArTransaction.SalesTax); return this; }  } 
                          public IdoArTransactionBuilder SalesTax2 { get {  AddProperty(IdoArTransaction.SalesTax2); return this; }  } 
                          public IdoArTransactionBuilder TaxCode1 { get {  AddProperty(IdoArTransaction.TaxCode1); return this; }  } 
                          public IdoArTransactionBuilder TaxCode2 { get {  AddProperty(IdoArTransaction.TaxCode2); return this; }  } 
                          public IdoArTransactionBuilder Type { get {  AddProperty(IdoArTransaction.Type); return this; }  } 
                    

                }

            public class SLArtransFilterExpressionBuilder  
                :   FilterExpressionBuilder<IdoArTransactionBuilder>
                {
                        public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> Acct
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.Acct); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> AcctUnit1
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.AcctUnit1); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> AcctUnit2
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.AcctUnit2); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> AcctUnit3
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.AcctUnit3); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> AcctUnit4
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.AcctUnit4); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> Active
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.Active); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> Amount
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.Amount); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> ApplyToInvNum
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.ApplyToInvNum); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> BankCode
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.BankCode); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> CadCurrCode
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.CadCurrCode); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> CadName
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.CadName); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> CheckSeq
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.CheckSeq); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> CoNum
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.CoNum); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> CorpCust
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.CorpCust); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> CustNum
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.CustNum); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DerCustName
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DerCustName); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DerInvNum
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DerInvNum); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DerLangCode
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DerLangCode); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DerNdAmount
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DerNdAmount); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DerNewAmount
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DerNewAmount); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DerOdAmount
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DerOdAmount); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DerOldAmount
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DerOldAmount); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DerTotalDifference
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DerTotalDifference); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DerTypeDescription
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DerTypeDescription); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> Description
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.Description); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DiscAmt
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DiscAmt); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DiscDate
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DiscDate); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DoNum
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DoNum); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> DueDate
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.DueDate); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> ExchRate
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.ExchRate); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> FixedRate
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.FixedRate); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> Freight
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.Freight); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> InvDate
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.InvDate); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> InvNum
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.InvNum); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> InvSeq
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.InvSeq); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.InWorkflow); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> IssueDate
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.IssueDate); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> MiscCharges
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.MiscCharges); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.NoteExistsFlag); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> PayType
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.PayType); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> PostFromCo
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.PostFromCo); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.RecordDate); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> Ref
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.Ref); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> Rma
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.Rma); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.RowPointer); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> SalesTax
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.SalesTax); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> SalesTax2
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.SalesTax2); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> TaxCode1
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.TaxCode1); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> TaxCode2
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.TaxCode2); }
                    }
                            public FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder> Type
                    {
                        get { return new FilterExpression<IdoArTransactionBuilder, SLArtransFilterExpressionBuilder>(_builder, IdoArTransaction.Type); }
                    }
                    

                }

    }
