namespace SytelineInterface.Dsl.Queries
{
    using Core;

    public class ArInvoices : IdoConstants
    {
        public const string IDO_NAME = "SLArinvs";
        public const string Acct = "Acct";
        public const string AcctUnit1 = "AcctUnit1";
        public const string AcctUnit2 = "AcctUnit2";
        public const string AcctUnit3 = "AcctUnit3";
        public const string AcctUnit4 = "AcctUnit4";
        public const string Amount = "Amount";
        public const string ApplyToNumber = "ApplyToInvNum";
        public const string ApprovalStatus = "ApprovalStatus";
        public const string CadbtCurrCode = "CadbtCurrCode";
        public const string CadbtName = "CadbtName";
        public const string ChartAccessUnit1 = "ChartAccessUnit1";
        public const string ChartAccessUnit2 = "ChartAccessUnit2";
        public const string ChartAccessUnit3 = "ChartAccessUnit3";
        public const string ChartAccessUnit4 = "ChartAccessUnit4";
        public const string ChartDescription = "ChartDescription";
        public const string OrderNumber = "CoNum";
        public const string CurrAmtFormat = "CurrAmtFormat";
        public const string CurrAmtTotFormat = "CurrAmtTotFormat";
        public const string CustID = "CustNum";
        public const string InvoiceTotal = "DerAmtTotInv";
        public const string CurrRateIsFixed = "DerCurrRateIsFixed";
        public const string LineExists = "DerLineExists";
        public const string Message = "DerMessage";
        public const string MultiRecExist = "DerMultiRecExist";
        public const string Description = "Description";
        public const string DoNum = "DoNum";
        public const string DraftPrintFlag = "DraftPrintFlag";
        public const string DueDate = "DueDate";
        public const string ExchRate = "ExchRate";
        public const string FixedRate = "FixedRate";
        public const string Freight = "Freight";
        public const string IncludeTaxInPrice = "IncludeTaxInPrice";
        public const string InvoiceDate = "InvDate";
        public const string InvoiceNumber = "InvNum";
        public const string InvSeq = "InvSeq";
        public const string InWorkflow = "InWorkflow";
        public const string MiscCharges = "MiscCharges";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string PayType = "PayType";
        public const string Places = "Places";
        public const string PostFromCustomerOrder = "PostFromCo";
        public const string RecordDate = "RecordDate";
        public const string Ref = "Ref";
        public const string Rma = "Rma";
        public const string RowPointer = "RowPointer";
        public const string SalesTax = "SalesTax";
        public const string SalesTax2 = "SalesTax2";
        public const string ShowInDropDownList = "ShowInDropDownList";
        public const string SLARTermsDues = "SLARTermsDues";
        public const string TaxCode1 = "TaxCode1";
        public const string TaxCode1Desc = "TaxCode1Desc";
        public const string TaxCode2 = "TaxCode2";
        public const string TaxCode2Desc = "TaxCode2Desc";
        public const string TermsCode = "TermsCode";
        public const string TermsDescription = "TermsCodeDesc";
        public const string Type = "Type";
        public const string UbEnable = "UbEnable";
        public const string UbMultiDueDateFlag = "UbMultiDueDateFlag";
        public const string UseExchRate = "UseExchRate";

    }

    public class ArInvoicesBuilder :
    IdoQueryBuilder<ArInvoicesBuilder, ArInvoicesFilterExpressionBuilder>
    {
        public ArInvoicesBuilder(IExpressionInterpreter ei)
            : base(ArInvoices.IDO_NAME, ei)
        {
        }

        public ArInvoicesBuilder OrderNumber { get { AddProperty(ArInvoices.OrderNumber); return this; } }
        public ArInvoicesBuilder InvoiceNumber { get { AddProperty(ArInvoices.InvoiceNumber); return this; } }
        public ArInvoicesBuilder InvoiceDate { get { AddProperty(ArInvoices.InvoiceDate); return this; } }
        public ArInvoicesBuilder DueDate { get { AddProperty(ArInvoices.DueDate); return this; } }
        public ArInvoicesBuilder InvoiceTotal { get { AddProperty(ArInvoices.InvoiceTotal); return this; } }
        public ArInvoicesBuilder SalesTax { get { AddProperty(ArInvoices.SalesTax); return this; } }
        public ArInvoicesBuilder Amount { get { AddProperty(ArInvoices.Amount); return this; } }
        public ArInvoicesBuilder ApplyToNumber { get { AddProperty(ArInvoices.ApplyToNumber); return this; } }
        public ArInvoicesBuilder MiscCharges { get { AddProperty(ArInvoices.MiscCharges); return this; } }
        public ArInvoicesBuilder Freight { get { AddProperty(ArInvoices.Freight); return this; } }
        public ArInvoicesBuilder TermsCode { get { AddProperty(ArInvoices.TermsCode); return this; } }
        public ArInvoicesBuilder TermsDescription { get { AddProperty(ArInvoices.TermsDescription); return this; } }
        public ArInvoicesBuilder CustID { get { AddProperty(ArInvoices.CustID); return this; } }
        public ArInvoicesBuilder Description { get { AddProperty(ArInvoices.Description); return this; } } 
    }

    public class ArInvoicesFilterExpressionBuilder : FilterExpressionBuilder<ArInvoicesBuilder>
    {
    }
}