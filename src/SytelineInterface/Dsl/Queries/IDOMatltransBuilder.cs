using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
                {
                  public class InventoryTransactions : IdoConstants 
                { 
                           public const string IDO_NAME = "SLMatltrans";
                           public const string AwaitingEop = "AwaitingEop";
                           public const string Backflush = "Backflush";
                           public const string Cost = "Cost";
                           public const string CostCode = "CostCode";
                           public const string DerAcct = "DerAcct";
                           public const string DerAmt = "DerAmt";
                           public const string DerFovhdAcct = "DerFovhdAcct";
                           public const string DerFovhdAmt = "DerFovhdAmt";
                           public const string DerFrom = "DerFrom";
                           public const string DerLbrAcct = "DerLbrAcct";
                           public const string DerLbrAmt = "DerLbrAmt";
                           public const string DerMatlAcct = "DerMatlAcct";
                           public const string DerMatlAmt = "DerMatlAmt";
                           public const string DerMatltranCost = "DerMatltranCost";
                           public const string DerMatlTranViewTotalPosted = "DerMatlTranViewTotalPosted";
                           public const string DerOutAcct = "DerOutAcct";
                           public const string DerOutAmt = "DerOutAmt";
                           public const string DerTo = "DerTo";
                           public const string DerTotalPosted = "DerTotalPosted";
                           public const string DerTransSeq = "DerTransSeq";
                           public const string DerType = "DerType";
                           public const string DerVovhdAcct = "DerVovhdAcct";
                           public const string DerVovhdAmt = "DerVovhdAmt";
                           public const string DocumentNum = "DocumentNum";
                           public const string FovhdCost = "FovhdCost";
                           public const string InWorkflow = "InWorkflow";
                           public const string Item = "Item";
                           public const string ItmItemDesc = "ItmItemDesc";
                           public const string ItmUM = "ItmUM";
                           public const string LbrCost = "LbrCost";
                           public const string Loc = "Loc";
                           public const string Lot = "Lot";
                           public const string MatlCost = "MatlCost";
                           public const string MatlTranViewReasonDesc = "MatlTranViewReasonDesc";
                           public const string MatlTranViewTotalCost = "MatlTranViewTotalCost";
                           public const string MatlTranViewTotalPost = "MatlTranViewTotalPost";
                           public const string MatlTranViewTypeDesc = "MatlTranViewTypeDesc";
                           public const string NoteExistsFlag = "NoteExistsFlag";
                           public const string OutCost = "OutCost";
                           public const string Qty = "Qty";
                           public const string ReasonCode = "ReasonCode";
                           public const string RecordDate = "RecordDate";
                           public const string RefLineSuf = "RefLineSuf";
                           public const string RefNum = "RefNum";
                           public const string RefRelease = "RefRelease";
                           public const string RefType = "RefType";
                           public const string RowPointer = "RowPointer";
                           public const string SLMatltranAmts = "SLMatltranAmts";
                           public const string TransDate = "TransDate";
                           public const string TransNum = "TransNum";
                           public const string TransType = "TransType";
                           public const string TrnFromSite = "TrnFromSite";
                           public const string UserCode = "UserCode";
                           public const string VovhdCost = "VovhdCost";
                           public const string Wc = "Wc";
                           public const string Whse = "Whse";


                }
    
    
    public class InventoryTransactionsBuilder  
                :   IdoQueryBuilder<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>
                {
        public InventoryTransactionsBuilder(IExpressionInterpreter ei) : base(InventoryTransactions.IDO_NAME, ei) { }

                      public InventoryTransactionsBuilder AwaitingEop { get {  AddProperty(InventoryTransactions.AwaitingEop); return this; } }         
                    public InventoryTransactionsBuilder Backflush { get {  AddProperty(InventoryTransactions.Backflush); return this; } }         
                    public InventoryTransactionsBuilder Cost { get {  AddProperty(InventoryTransactions.Cost); return this; } }         
                    public InventoryTransactionsBuilder CostCode { get {  AddProperty(InventoryTransactions.CostCode); return this; } }         
                    public InventoryTransactionsBuilder DerAcct { get {  AddProperty(InventoryTransactions.DerAcct); return this; } }         
                    public InventoryTransactionsBuilder DerAmt { get {  AddProperty(InventoryTransactions.DerAmt); return this; } }         
                    public InventoryTransactionsBuilder DerFovhdAcct { get {  AddProperty(InventoryTransactions.DerFovhdAcct); return this; } }         
                    public InventoryTransactionsBuilder DerFovhdAmt { get {  AddProperty(InventoryTransactions.DerFovhdAmt); return this; } }         
                    public InventoryTransactionsBuilder DerFrom { get {  AddProperty(InventoryTransactions.DerFrom); return this; } }         
                    public InventoryTransactionsBuilder DerLbrAcct { get {  AddProperty(InventoryTransactions.DerLbrAcct); return this; } }         
                    public InventoryTransactionsBuilder DerLbrAmt { get {  AddProperty(InventoryTransactions.DerLbrAmt); return this; } }         
                    public InventoryTransactionsBuilder DerMatlAcct { get {  AddProperty(InventoryTransactions.DerMatlAcct); return this; } }         
                    public InventoryTransactionsBuilder DerMatlAmt { get {  AddProperty(InventoryTransactions.DerMatlAmt); return this; } }         
                    public InventoryTransactionsBuilder DerMatltranCost { get {  AddProperty(InventoryTransactions.DerMatltranCost); return this; } }         
                    public InventoryTransactionsBuilder DerMatlTranViewTotalPosted { get {  AddProperty(InventoryTransactions.DerMatlTranViewTotalPosted); return this; } }         
                    public InventoryTransactionsBuilder DerOutAcct { get {  AddProperty(InventoryTransactions.DerOutAcct); return this; } }         
                    public InventoryTransactionsBuilder DerOutAmt { get {  AddProperty(InventoryTransactions.DerOutAmt); return this; } }         
                    public InventoryTransactionsBuilder DerTo { get {  AddProperty(InventoryTransactions.DerTo); return this; } }         
                    public InventoryTransactionsBuilder DerTotalPosted { get {  AddProperty(InventoryTransactions.DerTotalPosted); return this; } }         
                    public InventoryTransactionsBuilder DerTransSeq { get {  AddProperty(InventoryTransactions.DerTransSeq); return this; } }         
                    public InventoryTransactionsBuilder DerType { get {  AddProperty(InventoryTransactions.DerType); return this; } }         
                    public InventoryTransactionsBuilder DerVovhdAcct { get {  AddProperty(InventoryTransactions.DerVovhdAcct); return this; } }         
                    public InventoryTransactionsBuilder DerVovhdAmt { get {  AddProperty(InventoryTransactions.DerVovhdAmt); return this; } }         
                    public InventoryTransactionsBuilder DocumentNum { get {  AddProperty(InventoryTransactions.DocumentNum); return this; } }         
                    public InventoryTransactionsBuilder FovhdCost { get {  AddProperty(InventoryTransactions.FovhdCost); return this; } }         
                    public InventoryTransactionsBuilder InWorkflow { get {  AddProperty(InventoryTransactions.InWorkflow); return this; } }         
                    public InventoryTransactionsBuilder Item { get {  AddProperty(InventoryTransactions.Item); return this; } }         
                    public InventoryTransactionsBuilder ItmItemDesc { get {  AddProperty(InventoryTransactions.ItmItemDesc); return this; } }         
                    public InventoryTransactionsBuilder ItmUM { get {  AddProperty(InventoryTransactions.ItmUM); return this; } }         
                    public InventoryTransactionsBuilder LbrCost { get {  AddProperty(InventoryTransactions.LbrCost); return this; } }         
                    public InventoryTransactionsBuilder Loc { get {  AddProperty(InventoryTransactions.Loc); return this; } }         
                    public InventoryTransactionsBuilder Lot { get {  AddProperty(InventoryTransactions.Lot); return this; } }         
                    public InventoryTransactionsBuilder MatlCost { get {  AddProperty(InventoryTransactions.MatlCost); return this; } }         
                    public InventoryTransactionsBuilder MatlTranViewReasonDesc { get {  AddProperty(InventoryTransactions.MatlTranViewReasonDesc); return this; } }         
                    public InventoryTransactionsBuilder MatlTranViewTotalCost { get {  AddProperty(InventoryTransactions.MatlTranViewTotalCost); return this; } }         
                    public InventoryTransactionsBuilder MatlTranViewTotalPost { get {  AddProperty(InventoryTransactions.MatlTranViewTotalPost); return this; } }         
                    public InventoryTransactionsBuilder MatlTranViewTypeDesc { get {  AddProperty(InventoryTransactions.MatlTranViewTypeDesc); return this; } }         
                    public InventoryTransactionsBuilder NoteExistsFlag { get {  AddProperty(InventoryTransactions.NoteExistsFlag); return this; } }         
                    public InventoryTransactionsBuilder OutCost { get {  AddProperty(InventoryTransactions.OutCost); return this; } }         
                    public InventoryTransactionsBuilder Qty { get {  AddProperty(InventoryTransactions.Qty); return this; } }         
                    public InventoryTransactionsBuilder ReasonCode { get {  AddProperty(InventoryTransactions.ReasonCode); return this; } }         
                    public InventoryTransactionsBuilder RecordDate { get {  AddProperty(InventoryTransactions.RecordDate); return this; } }         
                    public InventoryTransactionsBuilder RefLineSuf { get {  AddProperty(InventoryTransactions.RefLineSuf); return this; } }         
                    public InventoryTransactionsBuilder RefNum { get {  AddProperty(InventoryTransactions.RefNum); return this; } }         
                    public InventoryTransactionsBuilder RefRelease { get {  AddProperty(InventoryTransactions.RefRelease); return this; } }         
                    public InventoryTransactionsBuilder RefType { get {  AddProperty(InventoryTransactions.RefType); return this; } }         
                    public InventoryTransactionsBuilder RowPointer { get {  AddProperty(InventoryTransactions.RowPointer); return this; } }         
                    public InventoryTransactionsBuilder MatltranAmts { get {  AddProperty(InventoryTransactions.SLMatltranAmts); return this; } }         
                    public InventoryTransactionsBuilder TransDate { get {  AddProperty(InventoryTransactions.TransDate); return this; } }         
                    public InventoryTransactionsBuilder TransNum { get {  AddProperty(InventoryTransactions.TransNum); return this; } }         
                    public InventoryTransactionsBuilder TransType { get {  AddProperty(InventoryTransactions.TransType); return this; } }         
                    public InventoryTransactionsBuilder TrnFromSite { get {  AddProperty(InventoryTransactions.TrnFromSite); return this; } }         
                    public InventoryTransactionsBuilder UserCode { get {  AddProperty(InventoryTransactions.UserCode); return this; } }         
                    public InventoryTransactionsBuilder VovhdCost { get {  AddProperty(InventoryTransactions.VovhdCost); return this; } }         
                    public InventoryTransactionsBuilder Wc { get {  AddProperty(InventoryTransactions.Wc); return this; } }         
                    public InventoryTransactionsBuilder Whse { get {  AddProperty(InventoryTransactions.Whse); return this; } }   

                }public class InventoryTransactionsFilterExpressionBuilder  
                :   FilterExpressionBuilder<InventoryTransactionsBuilder>
                {
                        public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> AwaitingEop
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.AwaitingEop); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> Backflush
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.Backflush); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> Cost
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.Cost); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> CostCode
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.CostCode); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerAcct
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerAcct); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerAmt
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerAmt); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerFovhdAcct
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerFovhdAcct); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerFovhdAmt
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerFovhdAmt); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerFrom
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerFrom); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerLbrAcct
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerLbrAcct); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerLbrAmt
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerLbrAmt); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerMatlAcct
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerMatlAcct); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerMatlAmt
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerMatlAmt); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerMatltranCost
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerMatltranCost); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerMatlTranViewTotalPosted
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerMatlTranViewTotalPosted); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerOutAcct
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerOutAcct); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerOutAmt
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerOutAmt); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerTo
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerTo); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerTotalPosted
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerTotalPosted); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerTransSeq
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerTransSeq); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerType
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerType); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerVovhdAcct
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerVovhdAcct); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DerVovhdAmt
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DerVovhdAmt); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> DocumentNum
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.DocumentNum); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> FovhdCost
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.FovhdCost); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.InWorkflow); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> Item
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.Item); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> ItmItemDesc
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.ItmItemDesc); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> ItmUM
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.ItmUM); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> LbrCost
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.LbrCost); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> Loc
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.Loc); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> Lot
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.Lot); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> MatlCost
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.MatlCost); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> MatlTranViewReasonDesc
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.MatlTranViewReasonDesc); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> MatlTranViewTotalCost
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.MatlTranViewTotalCost); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> MatlTranViewTotalPost
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.MatlTranViewTotalPost); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> MatlTranViewTypeDesc
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.MatlTranViewTypeDesc); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.NoteExistsFlag); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> OutCost
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.OutCost); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> Qty
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.Qty); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> ReasonCode
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.ReasonCode); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.RecordDate); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> RefLineSuf
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.RefLineSuf); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> RefNum
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.RefNum); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> RefRelease
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.RefRelease); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> RefType
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.RefType); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.RowPointer); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> SLMatltranAmts
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.SLMatltranAmts); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> TransDate
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.TransDate); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> TransNum
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.TransNum); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> TransType
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.TransType); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> TrnFromSite
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.TrnFromSite); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> UserCode
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.UserCode); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> VovhdCost
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.VovhdCost); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> Wc
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.Wc); }
                    }
                            public FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder> Whse
                    {
                        get { return new FilterExpression<InventoryTransactionsBuilder, InventoryTransactionsFilterExpressionBuilder>(_builder, InventoryTransactions.Whse); }
                    }
                    

                }
            }