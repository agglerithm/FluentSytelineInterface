using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    public class ARPaymentDetail : IdoConstants 
    {
        public const string IDO_NAME = "SLArpmtds";
        public const string AlChtAccessUnit1 = "AlChtAccessUnit1";
        public const string AlChtAccessUnit2 = "AlChtAccessUnit2";
        public const string AlChtAccessUnit3 = "AlChtAccessUnit3";
        public const string AlChtAccessUnit4 = "AlChtAccessUnit4";
        public const string AlChtDescription = "AlChtDescription";
        public const string AllowAcct = "AllowAcct";
        public const string AllowAcctUnit1 = "AllowAcctUnit1";
        public const string AllowAcctUnit2 = "AllowAcctUnit2";
        public const string AllowAcctUnit3 = "AllowAcctUnit3";
        public const string AllowAcctUnit4 = "AllowAcctUnit4"; 
        public const string CheckAmt = "ArpmtDomCheckAmt";
        public const string DueDate = "ArpmtDueDate";  
        public const string RecptDate = "ArpmtRecptDate";
        public const string ParentRowPointer = "ArpmtRowPointer";
        public const string BankCode = "BankCode";
        public const string CheckNum = "CheckNum";
        public const string OrderNumber = "CoNum";
        public const string CreditMemoNum = "CreditMemoNum"; 
        public const string DecimalPlaces = "CurrPlaces";
        public const string CustomerName = "CustApplName";
        public const string CustNum = "CustNum";
        public const string BalMethod = "CustPmtBalMethod";
        public const string CurrCode = "CustPmtCurrCode"; 
        public const string DeChtAccessUnit1 = "DeChtAccessUnit1";
        public const string DeChtAccessUnit2 = "DeChtAccessUnit2";
        public const string DeChtAccessUnit3 = "DeChtAccessUnit3";
        public const string DeChtAccessUnit4 = "DeChtAccessUnit4";
        public const string DeChtDescription = "DeChtDescription";
        public const string DepositAcct = "DepositAcct";
        public const string DepositAcctUnit1 = "DepositAcctUnit1";
        public const string DepositAcctUnit2 = "DepositAcctUnit2";
        public const string DepositAcctUnit3 = "DepositAcctUnit3";
        public const string DepositAcctUnit4 = "DepositAcctUnit4";
        public const string PayTypeCode = "DerArpmtdType";
        public const string DerAvailCustDrft = "DerAvailCustDrft";
        public const string DerCorpCust = "DerCorpCust"; 
        public const string DerDefaultType = "DerDefaultType";
        public const string AmtBalance = "DerDomAmtBal";
        public const string AmtRemaining = "DerDomAmtRem";   
        public const string AllowAmt = "DerOrigDomAllowAmt";
        public const string AmtApplied = "DomAmtApplied"; 
        public const string DerOrigForAllowAmt = "DerOrigForAllowAmt"; 
        public const string DerUpdateRate = "DerUpdateRate";
        public const string DiChtAccessUnit1 = "DiChtAccessUnit1";
        public const string DiChtAccessUnit2 = "DiChtAccessUnit2";
        public const string DiChtAccessUnit3 = "DiChtAccessUnit3";
        public const string DiChtAccessUnit4 = "DiChtAccessUnit4";
        public const string DiChtDescription = "DiChtDescription";
        public const string DiscAcct = "DiscAcct";
        public const string DiscAcctUnit1 = "DiscAcctUnit1";
        public const string DiscAcctUnit2 = "DiscAcctUnit2";
        public const string DiscAcctUnit3 = "DiscAcctUnit3";
        public const string DiscAcctUnit4 = "DiscAcctUnit4"; 
        public const string DiscountAmount = "DomDiscAmt";
        public const string Tax1 = "DomTax_1";
        public const string Tax2 = "DomTax_2";
        public const string DoNum = "DoNum";    
        public const string InvNum = "InvNum";
        public const string InWorkflow = "InWorkflow";
        public const string NoteExistsFlag = "NoteExistsFlag"; 
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string Site = "Site";
        public const string Type = "Type";
        public const string ApplyCustNum = "ApplyCustNum";
        public const string ForAmtApplied = "ForAmtApplied";
        public const string ForDiscountAmount = "ForDiscAmt";
    }

    public class ARPaymentDetailBuilder  
        :   IdoQueryBuilder<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>
    {
        public ARPaymentDetailBuilder(IExpressionInterpreter ei) : base(ARPaymentDetail.IDO_NAME,ei) { }

        public ARPaymentDetailBuilder AlChtAccessUnit1 { get {  AddProperty(ARPaymentDetail.AlChtAccessUnit1); return this; } }         
        public ARPaymentDetailBuilder AlChtAccessUnit2 { get {  AddProperty(ARPaymentDetail.AlChtAccessUnit2); return this; } }         
        public ARPaymentDetailBuilder AlChtAccessUnit3 { get {  AddProperty(ARPaymentDetail.AlChtAccessUnit3); return this; } }         
        public ARPaymentDetailBuilder AlChtAccessUnit4 { get {  AddProperty(ARPaymentDetail.AlChtAccessUnit4); return this; } }         
        public ARPaymentDetailBuilder AlChtDescription { get {  AddProperty(ARPaymentDetail.AlChtDescription); return this; } }         
        public ARPaymentDetailBuilder AllowAcct { get {  AddProperty(ARPaymentDetail.AllowAcct); return this; } }         
        public ARPaymentDetailBuilder AllowAcctUnit1 { get {  AddProperty(ARPaymentDetail.AllowAcctUnit1); return this; } }         
        public ARPaymentDetailBuilder AllowAcctUnit2 { get {  AddProperty(ARPaymentDetail.AllowAcctUnit2); return this; } }         
        public ARPaymentDetailBuilder AllowAcctUnit3 { get {  AddProperty(ARPaymentDetail.AllowAcctUnit3); return this; } }         
        public ARPaymentDetailBuilder AllowAcctUnit4 { get {  AddProperty(ARPaymentDetail.AllowAcctUnit4); return this; } }
        public ARPaymentDetailBuilder CheckAmt { get { AddProperty(ARPaymentDetail.CheckAmt); return this; } }         
        public ARPaymentDetailBuilder DueDate { get {  AddProperty(ARPaymentDetail.DueDate); return this; } }                
        public ARPaymentDetailBuilder RecptDate { get {  AddProperty(ARPaymentDetail.RecptDate); return this; } }         
        public ARPaymentDetailBuilder ParentRowPointer { get {  AddProperty(ARPaymentDetail.ParentRowPointer); return this; } }         
        public ARPaymentDetailBuilder BankCode { get {  AddProperty(ARPaymentDetail.BankCode); return this; } }         
        public ARPaymentDetailBuilder CheckNum { get {  AddProperty(ARPaymentDetail.CheckNum); return this; } }         
        public ARPaymentDetailBuilder CoNum { get {  AddProperty(ARPaymentDetail.OrderNumber); return this; } }         
        public ARPaymentDetailBuilder CreditMemoNum { get {  AddProperty(ARPaymentDetail.CreditMemoNum); return this; } }           
        public ARPaymentDetailBuilder DecimalPlaces { get {  AddProperty(ARPaymentDetail.DecimalPlaces); return this; } }         
        public ARPaymentDetailBuilder CustomerName { get {  AddProperty(ARPaymentDetail.CustomerName); return this; } }         
        public ARPaymentDetailBuilder CustNum { get {  AddProperty(ARPaymentDetail.CustNum); return this; } }         
        public ARPaymentDetailBuilder BalMethod { get {  AddProperty(ARPaymentDetail.BalMethod); return this; } }         
        public ARPaymentDetailBuilder CurrCode { get {  AddProperty(ARPaymentDetail.CurrCode); return this; } }          
        public ARPaymentDetailBuilder DeChtAccessUnit1 { get {  AddProperty(ARPaymentDetail.DeChtAccessUnit1); return this; } }         
        public ARPaymentDetailBuilder DeChtAccessUnit2 { get {  AddProperty(ARPaymentDetail.DeChtAccessUnit2); return this; } }         
        public ARPaymentDetailBuilder DeChtAccessUnit3 { get {  AddProperty(ARPaymentDetail.DeChtAccessUnit3); return this; } }         
        public ARPaymentDetailBuilder DeChtAccessUnit4 { get {  AddProperty(ARPaymentDetail.DeChtAccessUnit4); return this; } }         
        public ARPaymentDetailBuilder DeChtDescription { get {  AddProperty(ARPaymentDetail.DeChtDescription); return this; } }         
        public ARPaymentDetailBuilder DepositAcct { get {  AddProperty(ARPaymentDetail.DepositAcct); return this; } }         
        public ARPaymentDetailBuilder DepositAcctUnit1 { get {  AddProperty(ARPaymentDetail.DepositAcctUnit1); return this; } }         
        public ARPaymentDetailBuilder DepositAcctUnit2 { get {  AddProperty(ARPaymentDetail.DepositAcctUnit2); return this; } }         
        public ARPaymentDetailBuilder DepositAcctUnit3 { get {  AddProperty(ARPaymentDetail.DepositAcctUnit3); return this; } }         
        public ARPaymentDetailBuilder DepositAcctUnit4 { get {  AddProperty(ARPaymentDetail.DepositAcctUnit4); return this; } }         
        public ARPaymentDetailBuilder PayTypeCode { get {  AddProperty(ARPaymentDetail.PayTypeCode); return this; } }         
        public ARPaymentDetailBuilder DerAvailCustDrft { get {  AddProperty(ARPaymentDetail.DerAvailCustDrft); return this; } }         
        public ARPaymentDetailBuilder DerCorpCust { get {  AddProperty(ARPaymentDetail.DerCorpCust); return this; } }                
        public ARPaymentDetailBuilder DerDefaultType { get {  AddProperty(ARPaymentDetail.DerDefaultType); return this; } }         
        public ARPaymentDetailBuilder AmtBalance { get {  AddProperty(ARPaymentDetail.AmtBalance); return this; } }         
        public ARPaymentDetailBuilder AmtRemaining { get {  AddProperty(ARPaymentDetail.AmtRemaining); return this; } }                   
        public ARPaymentDetailBuilder AllowAmt { get {  AddProperty(ARPaymentDetail.AllowAmt); return this; } }         
        public ARPaymentDetailBuilder AmtApplied { get {  AddProperty(ARPaymentDetail.AmtApplied); return this; } }          
        public ARPaymentDetailBuilder DerOrigForAllowAmt { get {  AddProperty(ARPaymentDetail.DerOrigForAllowAmt); return this; } }       
        public ARPaymentDetailBuilder DerUpdateRate { get {  AddProperty(ARPaymentDetail.DerUpdateRate); return this; } }         
        public ARPaymentDetailBuilder DiChtAccessUnit1 { get {  AddProperty(ARPaymentDetail.DiChtAccessUnit1); return this; } }         
        public ARPaymentDetailBuilder DiChtAccessUnit2 { get {  AddProperty(ARPaymentDetail.DiChtAccessUnit2); return this; } }         
        public ARPaymentDetailBuilder DiChtAccessUnit3 { get {  AddProperty(ARPaymentDetail.DiChtAccessUnit3); return this; } }         
        public ARPaymentDetailBuilder DiChtAccessUnit4 { get {  AddProperty(ARPaymentDetail.DiChtAccessUnit4); return this; } }         
        public ARPaymentDetailBuilder DiChtDescription { get {  AddProperty(ARPaymentDetail.DiChtDescription); return this; } }         
        public ARPaymentDetailBuilder DiscAcct { get {  AddProperty(ARPaymentDetail.DiscAcct); return this; } }         
        public ARPaymentDetailBuilder DiscAcctUnit1 { get {  AddProperty(ARPaymentDetail.DiscAcctUnit1); return this; } }         
        public ARPaymentDetailBuilder DiscAcctUnit2 { get {  AddProperty(ARPaymentDetail.DiscAcctUnit2); return this; } }         
        public ARPaymentDetailBuilder DiscAcctUnit3 { get {  AddProperty(ARPaymentDetail.DiscAcctUnit3); return this; } }         
        public ARPaymentDetailBuilder DiscAcctUnit4 { get {  AddProperty(ARPaymentDetail.DiscAcctUnit4); return this; } }              
        public ARPaymentDetailBuilder DiscountAmount { get {  AddProperty(ARPaymentDetail.DiscountAmount); return this; } }         
        public ARPaymentDetailBuilder Tax1 { get {  AddProperty(ARPaymentDetail.Tax1); return this; } }         
        public ARPaymentDetailBuilder Tax2 { get {  AddProperty(ARPaymentDetail.Tax2); return this; } }         
        public ARPaymentDetailBuilder DoNum { get {  AddProperty(ARPaymentDetail.DoNum); return this; } }                
        public ARPaymentDetailBuilder InvNum { get {  AddProperty(ARPaymentDetail.InvNum); return this; } }         
        public ARPaymentDetailBuilder InWorkflow { get {  AddProperty(ARPaymentDetail.InWorkflow); return this; } }         
        public ARPaymentDetailBuilder NoteExistsFlag { get {  AddProperty(ARPaymentDetail.NoteExistsFlag); return this; } }                
        public ARPaymentDetailBuilder RecordDate { get {  AddProperty(ARPaymentDetail.RecordDate); return this; } }         
        public ARPaymentDetailBuilder RowPointer { get {  AddProperty(ARPaymentDetail.RowPointer); return this; } }         
        public ARPaymentDetailBuilder Site { get {  AddProperty(ARPaymentDetail.Site); return this; } }     
        public ARPaymentDetailBuilder Type { get {  AddProperty(ARPaymentDetail.Type); return this; } }
        public ARPaymentDetailBuilder ApplyCustNum { get { AddProperty(ARPaymentDetail.ApplyCustNum); return this; } }
        public ARPaymentDetailBuilder ForAmtApplied { get { AddProperty(ARPaymentDetail.ForAmtApplied); return this; } }
        public ARPaymentDetailBuilder ForDiscountAmount { get { AddProperty(ARPaymentDetail.ForDiscountAmount); return this; } }     

    }

    public class ARPaymentDetailFilterExpressionBuilder  
        :   FilterExpressionBuilder<ARPaymentDetailBuilder>
    {
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AlChtAccessUnit1
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AlChtAccessUnit1); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AlChtAccessUnit2
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AlChtAccessUnit2); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AlChtAccessUnit3
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AlChtAccessUnit3); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AlChtAccessUnit4
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AlChtAccessUnit4); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AlChtDescription
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AlChtDescription); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AllowAcct
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AllowAcct); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AllowAcctUnit1
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AllowAcctUnit1); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AllowAcctUnit2
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AllowAcctUnit2); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AllowAcctUnit3
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AllowAcctUnit3); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AllowAcctUnit4
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AllowAcctUnit4); }
        }
 
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> CheckAmt
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.CheckAmt); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DueDate
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DueDate); }
        }
 
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> RecptDate
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.RecptDate); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> ParentRowPointer
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.ParentRowPointer); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> BankCode
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.BankCode); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> CheckNum
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.CheckNum); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> CoNum
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.OrderNumber); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> CreditMemoNum
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.CreditMemoNum); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DecimalPlaces
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DecimalPlaces); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> CustomerName
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.CustomerName); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> CustNum
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.CustNum); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> BalMethod
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.BalMethod); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> CustPmtCurrCode
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.CurrCode); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DeChtAccessUnit1
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DeChtAccessUnit1); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DeChtAccessUnit2
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DeChtAccessUnit2); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DeChtAccessUnit3
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DeChtAccessUnit3); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DeChtAccessUnit4
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DeChtAccessUnit4); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DeChtDescription
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DeChtDescription); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DepositAcct
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DepositAcct); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DepositAcctUnit1
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DepositAcctUnit1); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DepositAcctUnit2
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DepositAcctUnit2); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DepositAcctUnit3
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DepositAcctUnit3); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DepositAcctUnit4
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DepositAcctUnit4); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> PayTypeCode
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.PayTypeCode); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DerAvailCustDrft
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DerAvailCustDrft); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DerCorpCust
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DerCorpCust); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DerDefaultType
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DerDefaultType); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AmtBal
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AmtBalance); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DerDomAmtRem
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AmtRemaining); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AllowAmt
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AllowAmt); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> AmtApplied
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.AmtApplied); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DerOrigForAllowAmt
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DerOrigForAllowAmt); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DerUpdateRate
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DerUpdateRate); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DiChtAccessUnit1
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DiChtAccessUnit1); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DiChtAccessUnit2
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DiChtAccessUnit2); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DiChtAccessUnit3
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DiChtAccessUnit3); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DiChtAccessUnit4
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DiChtAccessUnit4); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DiChtDescription
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DiChtDescription); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DiscAcct
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DiscAcct); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DiscAcctUnit1
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DiscAcctUnit1); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DiscAcctUnit2
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DiscAcctUnit2); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DiscAcctUnit3
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DiscAcctUnit3); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DiscAcctUnit4
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DiscAcctUnit4); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DiscAmt
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DiscountAmount); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> Tax1
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.Tax1); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> Tax2
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.Tax2); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> DoNum
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.DoNum); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> InvNum
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.InvNum); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.InWorkflow); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.NoteExistsFlag); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.RecordDate); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.RowPointer); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> Site
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.Site); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> Type
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.Type); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> ApplyCustNum
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.ApplyCustNum); }
        }
        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> ForAmtApplied
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.ForAmtApplied); }
        }

        public FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder> ForDiscountAmount
        {
            get { return new FilterExpression<ARPaymentDetailBuilder, ARPaymentDetailFilterExpressionBuilder>(_builder, ARPaymentDetail.ForDiscountAmount); }
        }
    }
}