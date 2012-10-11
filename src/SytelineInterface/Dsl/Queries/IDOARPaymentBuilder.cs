using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    public class ARPayments : IdoConstants 
    { 
        public const string IDO_NAME = "SLArpmts";
        public const string BankCode = "BankCode";
        public const string CurrCode = "BnkCurrCode";
        public const string BalMethod = "CadBalMethod"; 
        public const string CustomerName = "CadName";
        public const string CheckNum = "CheckNum";
        public const string CreditMemoNum = "CreditMemoNum";  
        public const string DecimalPlaces = "CurPlaces"; 
        public const string PayTypeCode = "CusPayType";
        public const string CustNum = "CustNum";
        public const string DepositDate = "DepositDate";     
        public const string RemainingAmt = "DerDomRemaining";
        public const string EnablePrepaidAmt = "DerEnablePrepaidAmt";  
        public const string AppliedAmt = "ForApplied"; 
        public const string Message = "DerMessage";  
        public const string PayTypeDescription = "DerTypeFormatted"; 
        public const string Description = "Description";
        public const string DomesticCheckAmt = "DomCheckAmt";
        public const string DueDate = "DueDate";  
        public const string InWorkflow = "InWorkflow";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string RecordDate = "RecordDate";
        public const string RecptDate = "RecptDate";
        public const string Ref = "Ref";
        public const string RowPointer = "RowPointer"; 
        public const string TransferCash = "TransferCash";
        public const string ForCheckAmt = "ForCheckAmt";
        public const string Type = "Type";


        public static ARPaymentsBuilder GetFullProjection()
        {
            return FromSyteline.ARPayments.BankCode.CurrCode.BalMethod.CustomerName.CheckNum.CreditMemoNum
                    .DecimalPlaces.DepositDate.
                    PayTypeCode
                    .CustNum.AppliedAmt.RemainingAmt
                    .EnablePrepaidAmt.Description
                    .Message.PayTypeDescription.CheckAmount
                    .DomesticCheckAmt.DueDate.InWorkflow.NoteExistsFlag.RecordDate
                    .RecptDate.Ref.RowPointer.TransferCash;
        }

    }

    public class ARPaymentsBuilder  
        :   IdoQueryBuilder<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>
    {
        public ARPaymentsBuilder(IExpressionInterpreter ei) : base(ARPayments.IDO_NAME,ei) { }

        public ARPaymentsBuilder BankCode { get {  AddProperty(ARPayments.BankCode); return this; } }         
        public ARPaymentsBuilder CurrCode { get {  AddProperty(ARPayments.CurrCode); return this; } }         
        public ARPaymentsBuilder BalMethod { get {  AddProperty(ARPayments.BalMethod); return this; } }
        public ARPaymentsBuilder CustomerName { get { AddProperty(ARPayments.CustomerName); return this; } }         
        public ARPaymentsBuilder CheckNum { get {  AddProperty(ARPayments.CheckNum); return this; } }         
        public ARPaymentsBuilder CreditMemoNum { get {  AddProperty(ARPayments.CreditMemoNum); return this; } }             
        public ARPaymentsBuilder DecimalPlaces { get {  AddProperty(ARPayments.DecimalPlaces); return this; } }                 
        public ARPaymentsBuilder PayTypeCode { get {  AddProperty(ARPayments.PayTypeCode); return this; } }         
        public ARPaymentsBuilder CustNum { get {  AddProperty(ARPayments.CustNum); return this; } }         
        public ARPaymentsBuilder DepositDate { get {  AddProperty(ARPayments.DepositDate); return this; } }                
        public ARPaymentsBuilder RemainingAmt { get {  AddProperty(ARPayments.RemainingAmt); return this; } }         
        public ARPaymentsBuilder EnablePrepaidAmt { get {  AddProperty(ARPayments.EnablePrepaidAmt); return this; } }            
        public ARPaymentsBuilder AppliedAmt { get {  AddProperty(ARPayments.AppliedAmt); return this; } }                 
        public ARPaymentsBuilder Message { get {  AddProperty(ARPayments.Message); return this; } }                
        public ARPaymentsBuilder PayTypeDescription { get {  AddProperty(ARPayments.PayTypeDescription); return this; } }            
        public ARPaymentsBuilder Description { get {  AddProperty(ARPayments.Description); return this; } }         
        public ARPaymentsBuilder DomesticCheckAmt { get {  AddProperty(ARPayments.DomesticCheckAmt); return this; } }         
        public ARPaymentsBuilder DueDate { get {  AddProperty(ARPayments.DueDate); return this; } }                
        public ARPaymentsBuilder InWorkflow { get {  AddProperty(ARPayments.InWorkflow); return this; } }         
        public ARPaymentsBuilder NoteExistsFlag { get {  AddProperty(ARPayments.NoteExistsFlag); return this; } }         
        public ARPaymentsBuilder RecordDate { get {  AddProperty(ARPayments.RecordDate); return this; } }         
        public ARPaymentsBuilder RecptDate { get {  AddProperty(ARPayments.RecptDate); return this; } }         
        public ARPaymentsBuilder Ref { get {  AddProperty(ARPayments.Ref); return this; } }         
        public ARPaymentsBuilder RowPointer { get {  AddProperty(ARPayments.RowPointer); return this; } }                    
        public ARPaymentsBuilder TransferCash { get {  AddProperty(ARPayments.TransferCash); return this; } }       
        public ARPaymentsBuilder CheckAmount { get {  AddProperty(ARPayments.ForCheckAmt); return this; } }       
        public ARPaymentsBuilder Type { get {  AddProperty(ARPayments.Type); return this; } }       

    }

    public class ARPaymentsFilterExpressionBuilder  
        :   FilterExpressionBuilder<ARPaymentsBuilder>
    {
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> BankCode
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.BankCode); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> CurrCode
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.CurrCode); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> BalMethod
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.BalMethod); }
        }

        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> CustomerName
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.CustomerName); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> CheckNumber
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.CheckNum); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> CreditMemoNum
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.CreditMemoNum); }
        }

        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> DecimalPlaces
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.DecimalPlaces); }
        }

        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> PayTypeCode
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.PayTypeCode); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> CustomerNumber
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.CustNum); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> DepositDate
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.DepositDate); }
        }

        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> RemainingAmt
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.RemainingAmt); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> EnablePrepaidAmt
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.EnablePrepaidAmt); }
        }

        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> AppliedAmt
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.AppliedAmt); }
        }
 
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> Message
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.Message); }
        }
  
 

        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> PayTypeDescription
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.PayTypeDescription); }
        }
 
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> Description
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.Description); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> DomesticCheckAmt
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.DomesticCheckAmt); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> DueDate
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.DueDate); }
        }
 
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.InWorkflow); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.NoteExistsFlag); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.RecordDate); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> RecptDate
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.RecptDate); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> Ref
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.Ref); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.RowPointer); }
        } 
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> TransferCash
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.TransferCash); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> CheckAmount
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.ForCheckAmt); }
        }
        public FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder> Type
        {
            get { return new FilterExpression<ARPaymentsBuilder, ARPaymentsFilterExpressionBuilder>(_builder, ARPayments.Type); }
        }        

    }
}