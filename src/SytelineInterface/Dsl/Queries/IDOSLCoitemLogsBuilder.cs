using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                  public class SLCoitemLogs : IdoConstants 
                { 
                           public const string IDO_NAME = "SLCoitemLogs";
       public const string ActivityDate = "ActivityDate";
       public const string ActivitySeq = "ActivitySeq";
       public const string CoDiscChg = "CoDiscChg";
       public const string CoLine = "CoLine";
       public const string CoNum = "CoNum";
       public const string CoRelease = "CoRelease";
       public const string DerCoDiscChg = "DerCoDiscChg";
       public const string DerDiscChg = "DerDiscChg";
       public const string DerNetValue = "DerNetValue";
       public const string DerPriceAdj = "DerPriceAdj";
       public const string DerPriceChg = "DerPriceChg";
       public const string DerPriceChgConv = "DerPriceChgConv";
       public const string DerQtyChg = "DerQtyChg";
       public const string DerQtyChgConv = "DerQtyChgConv";
       public const string DiscChg = "DiscChg";
       public const string DueDate = "DueDate";
       public const string InWorkflow = "InWorkflow";
       public const string Item = "Item";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string PriceChg = "PriceChg";
       public const string PriceChgConv = "PriceChgConv";
       public const string ProjectedDate = "ProjectedDate";
       public const string QtyChg = "QtyChg";
       public const string QtyChgConv = "QtyChgConv";
       public const string RecordDate = "RecordDate";
       public const string RowPointer = "RowPointer";
       public const string TransAmt = "TransAmt";
       public const string TransDisc = "TransDisc";
       public const string UM = "UM";


                }public class SLCoitemLogsBuilder  
                :   IdoBuilder<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>
                {
                        public SLCoitemLogsBuilder() : base(SLCoitemLogs.IDO_NAME) { }

                      public SLCoitemLogsBuilder ActivityDate { get {  AddProperty(SLCoitemLogs.ActivityDate); return this; } }         public SLCoitemLogsBuilder ActivitySeq { get {  AddProperty(SLCoitemLogs.ActivitySeq); return this; } }         public SLCoitemLogsBuilder CoDiscChg { get {  AddProperty(SLCoitemLogs.CoDiscChg); return this; } }         public SLCoitemLogsBuilder CoLine { get {  AddProperty(SLCoitemLogs.CoLine); return this; } }         public SLCoitemLogsBuilder CoNum { get {  AddProperty(SLCoitemLogs.CoNum); return this; } }         public SLCoitemLogsBuilder CoRelease { get {  AddProperty(SLCoitemLogs.CoRelease); return this; } }         public SLCoitemLogsBuilder DerCoDiscChg { get {  AddProperty(SLCoitemLogs.DerCoDiscChg); return this; } }         public SLCoitemLogsBuilder DerDiscChg { get {  AddProperty(SLCoitemLogs.DerDiscChg); return this; } }         public SLCoitemLogsBuilder DerNetValue { get {  AddProperty(SLCoitemLogs.DerNetValue); return this; } }         public SLCoitemLogsBuilder DerPriceAdj { get {  AddProperty(SLCoitemLogs.DerPriceAdj); return this; } }         public SLCoitemLogsBuilder DerPriceChg { get {  AddProperty(SLCoitemLogs.DerPriceChg); return this; } }         public SLCoitemLogsBuilder DerPriceChgConv { get {  AddProperty(SLCoitemLogs.DerPriceChgConv); return this; } }         public SLCoitemLogsBuilder DerQtyChg { get {  AddProperty(SLCoitemLogs.DerQtyChg); return this; } }         public SLCoitemLogsBuilder DerQtyChgConv { get {  AddProperty(SLCoitemLogs.DerQtyChgConv); return this; } }         public SLCoitemLogsBuilder DiscChg { get {  AddProperty(SLCoitemLogs.DiscChg); return this; } }         public SLCoitemLogsBuilder DueDate { get {  AddProperty(SLCoitemLogs.DueDate); return this; } }         public SLCoitemLogsBuilder InWorkflow { get {  AddProperty(SLCoitemLogs.InWorkflow); return this; } }         public SLCoitemLogsBuilder Item { get {  AddProperty(SLCoitemLogs.Item); return this; } }         public SLCoitemLogsBuilder NoteExistsFlag { get {  AddProperty(SLCoitemLogs.NoteExistsFlag); return this; } }         public SLCoitemLogsBuilder PriceChg { get {  AddProperty(SLCoitemLogs.PriceChg); return this; } }         public SLCoitemLogsBuilder PriceChgConv { get {  AddProperty(SLCoitemLogs.PriceChgConv); return this; } }         public SLCoitemLogsBuilder ProjectedDate { get {  AddProperty(SLCoitemLogs.ProjectedDate); return this; } }         public SLCoitemLogsBuilder QtyChg { get {  AddProperty(SLCoitemLogs.QtyChg); return this; } }         public SLCoitemLogsBuilder QtyChgConv { get {  AddProperty(SLCoitemLogs.QtyChgConv); return this; } }         public SLCoitemLogsBuilder RecordDate { get {  AddProperty(SLCoitemLogs.RecordDate); return this; } }         public SLCoitemLogsBuilder RowPointer { get {  AddProperty(SLCoitemLogs.RowPointer); return this; } }         public SLCoitemLogsBuilder TransAmt { get {  AddProperty(SLCoitemLogs.TransAmt); return this; } }         public SLCoitemLogsBuilder TransDisc { get {  AddProperty(SLCoitemLogs.TransDisc); return this; } }         public SLCoitemLogsBuilder UM { get {  AddProperty(SLCoitemLogs.UM); return this; } }   

                }public class SLCoitemLogsFilterExpressionBuilder  
                :   FilterExpressionBuilder<SLCoitemLogsBuilder>
                [
                        public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> ActivityDate
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.ActivityDate); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> ActivitySeq
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.ActivitySeq); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> CoDiscChg
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.CoDiscChg); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> CoLine
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.CoLine); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> CoNum
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.CoNum); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> CoRelease
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.CoRelease); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerCoDiscChg
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.DerCoDiscChg); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerDiscChg
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.DerDiscChg); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerNetValue
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.DerNetValue); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerPriceAdj
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.DerPriceAdj); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerPriceChg
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.DerPriceChg); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerPriceChgConv
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.DerPriceChgConv); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerQtyChg
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.DerQtyChg); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DerQtyChgConv
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.DerQtyChgConv); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DiscChg
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.DiscChg); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> DueDate
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.DueDate); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.InWorkflow); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> Item
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.Item); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.NoteExistsFlag); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> PriceChg
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.PriceChg); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> PriceChgConv
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.PriceChgConv); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> ProjectedDate
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.ProjectedDate); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> QtyChg
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.QtyChg); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> QtyChgConv
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.QtyChgConv); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.RecordDate); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.RowPointer); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> TransAmt
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.TransAmt); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> TransDisc
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.TransDisc); }
                    }
                            public FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder> UM
                    {
                        get { return new FilterExpression<SLCoitemLogsBuilder, SLCoitemLogsFilterExpressionBuilder>(_builder, SLCoitemLogs.UM); }
                    }
                    

                }
            }