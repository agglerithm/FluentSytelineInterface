using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                  public class InvoiceLineItemAlls : IdoConstants 
                { 
                           public const string IDO_NAME = "SLInvItemAlls";
                           public const string OrderLine = "CoLine";
                           public const string OrderNumber = "CoNum";
                           public const string OrderRelease = "CoRelease";
                           public const string CurrAmtFormat = "CurrAmtFormat";
                           public const string CurrCstPrcFormat = "CurrCstPrcFormat";
                           public const string CustaddrCurrCode = "CustaddrCurrCode";
                           public const string CustaddrCustNum = "CustaddrCustNum";
                           public const string CustomerPo = "CustPo";
                           public const string DerCoNum = "DerCoNum";
                           public const string Description = "DerDescription";
                           public const string ExtendedPrice = "DerExtendedPrice";
                           public const string InvoiceDate = "DerInvDate";
                           public const string DerInvNum = "DerInvNum";
                           public const string InvhdrBillType = "InvhdrBillType";
                           public const string InvhdrCoNum = "InvhdrCoNum";
                           public const string CustNum = "InvhdrCustNum"; 
                           public const string InvhdrExchRate = "InvhdrExchRate"; 
                           public const string TotalPrice = "InvhdrPrice";
                           public const string InvhdrSiteRef = "InvhdrSiteRef";
                           public const string Slsman = "InvhdrSlsman";
                           public const string InvoiceLine = "InvLine";
                           public const string InvoiceNumber = "InvNum";
                           public const string InvSeq = "InvSeq";
                           public const string Item = "Item";
                           public const string NoteExistsFlag = "NoteExistsFlag";
                           public const string Price = "Price";
                           public const string ProcessInd = "ProcessInd";
                           public const string QtyInvoiced = "QtyInvoiced";
                           public const string RecordDate = "RecordDate";
                           public const string RowPointer = "RowPointer";
                           public const string SiteRef = "SiteRef";

                      public static InvoiceLineItemAllsBuilder GetFullProjection()
                      {
                          return
                              FromSyteline.InvoiceLineItems.OrderRelease.CurrAmtFormat.CurrCstPrcFormat.CustaddrCurrCode.
                                  CustaddrCustNum.CustomerPo.DerCoNum.Description.ExtendedPrice
                                  .DerInvDate.DerInvNum.InvhdrBillType.InvhdrCoNum.InvhdrCustNum.CustomerPo
                                  .TotalPrice.InvhdrSiteRef.Slsman
                                  .InvoiceLine.InvoiceNumber.OrderLine.OrderNumber.InvSeq.Item.Price.QtyInvoiced.
                                  RecordDate;
                      }

                }
                    
                    public class InvoiceLineItemAllsBuilder  
                :   IdoQueryBuilder<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>
                {
                        public InvoiceLineItemAllsBuilder(IExpressionInterpreter ei) : base(InvoiceLineItemAlls.IDO_NAME, ei) { }

                        public InvoiceLineItemAllsBuilder OrderLine { get { AddProperty(InvoiceLineItemAlls.OrderLine); return this; } }
                        public InvoiceLineItemAllsBuilder OrderNumber { get { AddProperty(InvoiceLineItemAlls.OrderNumber); return this; } }
                        public InvoiceLineItemAllsBuilder OrderRelease { get { AddProperty(InvoiceLineItemAlls.OrderRelease); return this; } }         
                    public InvoiceLineItemAllsBuilder CurrAmtFormat { get {  AddProperty(InvoiceLineItemAlls.CurrAmtFormat); return this; } }         
                    public InvoiceLineItemAllsBuilder CurrCstPrcFormat { get {  AddProperty(InvoiceLineItemAlls.CurrCstPrcFormat); return this; } }         
                    public InvoiceLineItemAllsBuilder CustaddrCurrCode { get {  AddProperty(InvoiceLineItemAlls.CustaddrCurrCode); return this; } }         
                    public InvoiceLineItemAllsBuilder CustaddrCustNum { get {  AddProperty(InvoiceLineItemAlls.CustaddrCustNum); return this; } }         
                    public InvoiceLineItemAllsBuilder CustomerPo { get {  AddProperty(InvoiceLineItemAlls.CustomerPo); return this; } }         
                        public InvoiceLineItemAllsBuilder DerCoNum { get {  AddProperty(InvoiceLineItemAlls.DerCoNum); return this; } }         
                    public InvoiceLineItemAllsBuilder Description { get {  AddProperty(InvoiceLineItemAlls.Description); return this; } }         
                    public InvoiceLineItemAllsBuilder ExtendedPrice { get {  AddProperty(InvoiceLineItemAlls.ExtendedPrice); return this; } }         
                    public InvoiceLineItemAllsBuilder DerInvDate { get {  AddProperty(InvoiceLineItemAlls.InvoiceDate); return this; } }         
                    public InvoiceLineItemAllsBuilder DerInvNum { get {  AddProperty(InvoiceLineItemAlls.DerInvNum); return this; } }         
                    public InvoiceLineItemAllsBuilder InvhdrBillType { get {  AddProperty(InvoiceLineItemAlls.InvhdrBillType); return this; } }         
                    public InvoiceLineItemAllsBuilder InvhdrCoNum { get {  AddProperty(InvoiceLineItemAlls.InvhdrCoNum); return this; } }         
                    public InvoiceLineItemAllsBuilder InvhdrCustNum { get {  AddProperty(InvoiceLineItemAlls.CustNum); return this; } }          
                    public InvoiceLineItemAllsBuilder InvhdrExchRate { get {  AddProperty(InvoiceLineItemAlls.InvhdrExchRate); return this; } }              
                    public InvoiceLineItemAllsBuilder TotalPrice { get {  AddProperty(InvoiceLineItemAlls.TotalPrice); return this; } }         
                    public InvoiceLineItemAllsBuilder InvhdrSiteRef { get {  AddProperty(InvoiceLineItemAlls.InvhdrSiteRef); return this; } }         
                    public InvoiceLineItemAllsBuilder Slsman { get {  AddProperty(InvoiceLineItemAlls.Slsman); return this; } }
                    public InvoiceLineItemAllsBuilder InvoiceLine { get { AddProperty(InvoiceLineItemAlls.InvoiceLine); return this; } }
                    public InvoiceLineItemAllsBuilder InvoiceNumber { get { AddProperty(InvoiceLineItemAlls.InvoiceNumber); return this; } }         
                    public InvoiceLineItemAllsBuilder InvSeq { get {  AddProperty(InvoiceLineItemAlls.InvSeq); return this; } }         
                    public InvoiceLineItemAllsBuilder Item { get {  AddProperty(InvoiceLineItemAlls.Item); return this; } }         
                    public InvoiceLineItemAllsBuilder NoteExistsFlag { get {  AddProperty(InvoiceLineItemAlls.NoteExistsFlag); return this; } }         
                    public InvoiceLineItemAllsBuilder Price { get {  AddProperty(InvoiceLineItemAlls.Price); return this; } }         
                    public InvoiceLineItemAllsBuilder ProcessInd { get {  AddProperty(InvoiceLineItemAlls.ProcessInd); return this; } }         
                    public InvoiceLineItemAllsBuilder QtyInvoiced { get {  AddProperty(InvoiceLineItemAlls.QtyInvoiced); return this; } }         
                    public InvoiceLineItemAllsBuilder RecordDate { get {  AddProperty(InvoiceLineItemAlls.RecordDate); return this; } }           
                    public InvoiceLineItemAllsBuilder SiteRef { get {  AddProperty(InvoiceLineItemAlls.SiteRef); return this; } }   

                }
                    
                    
                    public class InvoiceLineItemAllsFilterExpressionBuilder  
                :   FilterExpressionBuilder<InvoiceLineItemAllsBuilder>
                {
                        public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> OrderLine
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.OrderLine); }
                    }
                        public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> OrderNumber
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.OrderNumber); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> CoRelease
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.OrderRelease); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> CurrAmtFormat
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.CurrAmtFormat); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> CurrCstPrcFormat
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.CurrCstPrcFormat); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> CustaddrCurrCode
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.CustaddrCurrCode); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> CustaddrCustNum
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.CustaddrCustNum); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> CustomerPo
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.CustomerPo); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> DerCoNum
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.DerCoNum); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> Description
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.Description); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> ExtendedPrice
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.ExtendedPrice); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> DerInvDate
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.InvoiceDate); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> DerInvNum
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.DerInvNum); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> InvhdrBillType
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.InvhdrBillType); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> InvhdrCoNum
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.InvhdrCoNum); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> InvhdrCustNum
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.CustNum); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> InvhdrCustPo
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.CustomerPo); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> InvhdrExchRate
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.InvhdrExchRate); }
                    }
                        
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> InvhdrPrice
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.TotalPrice); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> InvhdrSiteRef
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.InvhdrSiteRef); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> InvhdrSlsman
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.Slsman); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> InvoiceLine
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.InvoiceLine); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> InvoiceNumber
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.InvoiceNumber); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> InvSeq
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.InvSeq); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> Item
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.Item); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.NoteExistsFlag); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> Price
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.Price); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> ProcessInd
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.ProcessInd); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> QtyInvoiced
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.QtyInvoiced); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.RecordDate); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.RowPointer); }
                    }
                            public FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder> SiteRef
                    {
                        get { return new FilterExpression<InvoiceLineItemAllsBuilder, InvoiceLineItemAllsFilterExpressionBuilder>(_builder, InvoiceLineItemAlls.SiteRef); }
                    }
                    

                }
            }