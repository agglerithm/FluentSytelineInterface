using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                  public class SLItemLocs : IdoConstants 
                { 
                           public const string IDO_NAME = "SLItemLocs";
       public const string DerASPSearch = "DerASPSearch";
       public const string DerIWhseQtyOnHand = "DerIWhseQtyOnHand";
       public const string DerIWhseTotalNonNetStock = "DerIWhseTotalNonNetStock";
       public const string DerIWhseTotalRsvdCO = "DerIWhseTotalRsvdCO";
       public const string DerTotalCost = "DerTotalCost";
       public const string DerUM = "DerUM";
       public const string FovaccAccessUnit1 = "FovaccAccessUnit1";
       public const string FovaccAccessUnit2 = "FovaccAccessUnit2";
       public const string FovaccAccessUnit3 = "FovaccAccessUnit3";
       public const string FovaccAccessUnit4 = "FovaccAccessUnit4";
       public const string FovaccDescription = "FovaccDescription";
       public const string FovhdAcct = "FovhdAcct";
       public const string FovhdAcctUnit1 = "FovhdAcctUnit1";
       public const string FovhdAcctUnit2 = "FovhdAcctUnit2";
       public const string FovhdAcctUnit3 = "FovhdAcctUnit3";
       public const string FovhdAcctUnit4 = "FovhdAcctUnit4";
       public const string FovhdCost = "FovhdCost";
       public const string InvaccAccessUnit1 = "InvaccAccessUnit1";
       public const string InvaccAccessUnit2 = "InvaccAccessUnit2";
       public const string InvaccAccessUnit3 = "InvaccAccessUnit3";
       public const string InvaccAccessUnit4 = "InvaccAccessUnit4";
       public const string InvaccDescription = "InvaccDescription";
       public const string InvAcct = "InvAcct";
       public const string InvAcctUnit1 = "InvAcctUnit1";
       public const string InvAcctUnit2 = "InvAcctUnit2";
       public const string InvAcctUnit3 = "InvAcctUnit3";
       public const string InvAcctUnit4 = "InvAcctUnit4";
       public const string InvpBflushLoc = "InvpBflushLoc";
       public const string InWorkflow = "InWorkflow";
       public const string Item = "Item";
       public const string ItmBflushLoc = "ItmBflushLoc";
       public const string ItmCostMethod = "ItmCostMethod";
       public const string ItmCostType = "ItmCostType";
       public const string ItmDescription = "ItmDescription";
       public const string ItmIssueBy = "ItmIssueBy";
       public const string ItmItem = "ItmItem";
       public const string ItmLotTracked = "ItmLotTracked";
       public const string ItmSerialTracked = "ItmSerialTracked";
       public const string ItmUM = "ItmUM";
       public const string ItmwhseQtyOnHand = "ItmwhseQtyOnHand";
       public const string JmatlJob = "JmatlJob";
       public const string LbraccAccessUnit1 = "LbraccAccessUnit1";
       public const string LbraccAccessUnit2 = "LbraccAccessUnit2";
       public const string LbraccAccessUnit3 = "LbraccAccessUnit3";
       public const string LbraccAccessUnit4 = "LbraccAccessUnit4";
       public const string LbraccDescription = "LbraccDescription";
       public const string LbrAcct = "LbrAcct";
       public const string LbrAcctUnit1 = "LbrAcctUnit1";
       public const string LbrAcctUnit2 = "LbrAcctUnit2";
       public const string LbrAcctUnit3 = "LbrAcctUnit3";
       public const string LbrAcctUnit4 = "LbrAcctUnit4";
       public const string LbrCost = "LbrCost";
       public const string Loc = "Loc";
       public const string LocDescription = "LocDescription";
       public const string LocLoc = "LocLoc";
       public const string LocType = "LocType";
       public const string LocWc = "LocWc";
       public const string MatlCost = "MatlCost";
       public const string MrbFlag = "MrbFlag";
       public const string NewRank = "NewRank";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string OutaccAccessUnit1 = "OutaccAccessUnit1";
       public const string OutaccAccessUnit2 = "OutaccAccessUnit2";
       public const string OutaccAccessUnit3 = "OutaccAccessUnit3";
       public const string OutaccAccessUnit4 = "OutaccAccessUnit4";
       public const string OutaccDescription = "OutaccDescription";
       public const string OutAcct = "OutAcct";
       public const string OutAcctUnit1 = "OutAcctUnit1";
       public const string OutAcctUnit2 = "OutAcctUnit2";
       public const string OutAcctUnit3 = "OutAcctUnit3";
       public const string OutAcctUnit4 = "OutAcctUnit4";
       public const string OutCost = "OutCost";
       public const string PermFlag = "PermFlag";
       public const string QtyOnHand = "QtyOnHand";
       public const string QtyRsvd = "QtyRsvd";
       public const string Rank = "Rank";
       public const string RecordDate = "RecordDate";
       public const string RecordState = "RecordState";
       public const string RowPointer = "RowPointer";
       public const string SLSerials = "SLSerials";
       public const string UbToLoc = "UbToLoc";
       public const string UBTrnDate = "UBTrnDate";
       public const string UBTrnDesc = "UBTrnDesc";
       public const string UBTrnReasonCode = "UBTrnReasonCode";
       public const string UBTrnType = "UBTrnType";
       public const string UnitCost = "UnitCost";
       public const string VovacctAccessUnit1 = "VovacctAccessUnit1";
       public const string VovacctAccessUnit2 = "VovacctAccessUnit2";
       public const string VovacctAccessUnit3 = "VovacctAccessUnit3";
       public const string VovacctAccessUnit4 = "VovacctAccessUnit4";
       public const string VovacctDescription = "VovacctDescription";
       public const string VovhdAcct = "VovhdAcct";
       public const string VovhdAcctUnit1 = "VovhdAcctUnit1";
       public const string VovhdAcctUnit2 = "VovhdAcctUnit2";
       public const string VovhdAcctUnit3 = "VovhdAcctUnit3";
       public const string VovhdAcctUnit4 = "VovhdAcctUnit4";
       public const string VovhdCost = "VovhdCost";
       public const string Wc = "Wc";
       public const string Whse = "Whse";
       public const string WhsName = "WhsName";
       public const string WhsWhse = "WhsWhse";


                }public class SLItemLocsBuilder  
                :   IdoBuilder<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>
                {
                        public SLItemLocsBuilder() : base(SLItemLocs.IDO_NAME) { }

                      public SLItemLocsBuilder DerASPSearch { get {  AddProperty(SLItemLocs.DerASPSearch); return this; } }         public SLItemLocsBuilder DerIWhseQtyOnHand { get {  AddProperty(SLItemLocs.DerIWhseQtyOnHand); return this; } }         public SLItemLocsBuilder DerIWhseTotalNonNetStock { get {  AddProperty(SLItemLocs.DerIWhseTotalNonNetStock); return this; } }         public SLItemLocsBuilder DerIWhseTotalRsvdCO { get {  AddProperty(SLItemLocs.DerIWhseTotalRsvdCO); return this; } }         public SLItemLocsBuilder DerTotalCost { get {  AddProperty(SLItemLocs.DerTotalCost); return this; } }         public SLItemLocsBuilder DerUM { get {  AddProperty(SLItemLocs.DerUM); return this; } }         public SLItemLocsBuilder FovaccAccessUnit1 { get {  AddProperty(SLItemLocs.FovaccAccessUnit1); return this; } }         public SLItemLocsBuilder FovaccAccessUnit2 { get {  AddProperty(SLItemLocs.FovaccAccessUnit2); return this; } }         public SLItemLocsBuilder FovaccAccessUnit3 { get {  AddProperty(SLItemLocs.FovaccAccessUnit3); return this; } }         public SLItemLocsBuilder FovaccAccessUnit4 { get {  AddProperty(SLItemLocs.FovaccAccessUnit4); return this; } }         public SLItemLocsBuilder FovaccDescription { get {  AddProperty(SLItemLocs.FovaccDescription); return this; } }         public SLItemLocsBuilder FovhdAcct { get {  AddProperty(SLItemLocs.FovhdAcct); return this; } }         public SLItemLocsBuilder FovhdAcctUnit1 { get {  AddProperty(SLItemLocs.FovhdAcctUnit1); return this; } }         public SLItemLocsBuilder FovhdAcctUnit2 { get {  AddProperty(SLItemLocs.FovhdAcctUnit2); return this; } }         public SLItemLocsBuilder FovhdAcctUnit3 { get {  AddProperty(SLItemLocs.FovhdAcctUnit3); return this; } }         public SLItemLocsBuilder FovhdAcctUnit4 { get {  AddProperty(SLItemLocs.FovhdAcctUnit4); return this; } }         public SLItemLocsBuilder FovhdCost { get {  AddProperty(SLItemLocs.FovhdCost); return this; } }         public SLItemLocsBuilder InvaccAccessUnit1 { get {  AddProperty(SLItemLocs.InvaccAccessUnit1); return this; } }         public SLItemLocsBuilder InvaccAccessUnit2 { get {  AddProperty(SLItemLocs.InvaccAccessUnit2); return this; } }         public SLItemLocsBuilder InvaccAccessUnit3 { get {  AddProperty(SLItemLocs.InvaccAccessUnit3); return this; } }         public SLItemLocsBuilder InvaccAccessUnit4 { get {  AddProperty(SLItemLocs.InvaccAccessUnit4); return this; } }         public SLItemLocsBuilder InvaccDescription { get {  AddProperty(SLItemLocs.InvaccDescription); return this; } }         public SLItemLocsBuilder InvAcct { get {  AddProperty(SLItemLocs.InvAcct); return this; } }         public SLItemLocsBuilder InvAcctUnit1 { get {  AddProperty(SLItemLocs.InvAcctUnit1); return this; } }         public SLItemLocsBuilder InvAcctUnit2 { get {  AddProperty(SLItemLocs.InvAcctUnit2); return this; } }         public SLItemLocsBuilder InvAcctUnit3 { get {  AddProperty(SLItemLocs.InvAcctUnit3); return this; } }         public SLItemLocsBuilder InvAcctUnit4 { get {  AddProperty(SLItemLocs.InvAcctUnit4); return this; } }         public SLItemLocsBuilder InvpBflushLoc { get {  AddProperty(SLItemLocs.InvpBflushLoc); return this; } }         public SLItemLocsBuilder InWorkflow { get {  AddProperty(SLItemLocs.InWorkflow); return this; } }         public SLItemLocsBuilder Item { get {  AddProperty(SLItemLocs.Item); return this; } }         public SLItemLocsBuilder ItmBflushLoc { get {  AddProperty(SLItemLocs.ItmBflushLoc); return this; } }         public SLItemLocsBuilder ItmCostMethod { get {  AddProperty(SLItemLocs.ItmCostMethod); return this; } }         public SLItemLocsBuilder ItmCostType { get {  AddProperty(SLItemLocs.ItmCostType); return this; } }         public SLItemLocsBuilder ItmDescription { get {  AddProperty(SLItemLocs.ItmDescription); return this; } }         public SLItemLocsBuilder ItmIssueBy { get {  AddProperty(SLItemLocs.ItmIssueBy); return this; } }         public SLItemLocsBuilder ItmItem { get {  AddProperty(SLItemLocs.ItmItem); return this; } }         public SLItemLocsBuilder ItmLotTracked { get {  AddProperty(SLItemLocs.ItmLotTracked); return this; } }         public SLItemLocsBuilder ItmSerialTracked { get {  AddProperty(SLItemLocs.ItmSerialTracked); return this; } }         public SLItemLocsBuilder ItmUM { get {  AddProperty(SLItemLocs.ItmUM); return this; } }         public SLItemLocsBuilder ItmwhseQtyOnHand { get {  AddProperty(SLItemLocs.ItmwhseQtyOnHand); return this; } }         public SLItemLocsBuilder JmatlJob { get {  AddProperty(SLItemLocs.JmatlJob); return this; } }         public SLItemLocsBuilder LbraccAccessUnit1 { get {  AddProperty(SLItemLocs.LbraccAccessUnit1); return this; } }         public SLItemLocsBuilder LbraccAccessUnit2 { get {  AddProperty(SLItemLocs.LbraccAccessUnit2); return this; } }         public SLItemLocsBuilder LbraccAccessUnit3 { get {  AddProperty(SLItemLocs.LbraccAccessUnit3); return this; } }         public SLItemLocsBuilder LbraccAccessUnit4 { get {  AddProperty(SLItemLocs.LbraccAccessUnit4); return this; } }         public SLItemLocsBuilder LbraccDescription { get {  AddProperty(SLItemLocs.LbraccDescription); return this; } }         public SLItemLocsBuilder LbrAcct { get {  AddProperty(SLItemLocs.LbrAcct); return this; } }         public SLItemLocsBuilder LbrAcctUnit1 { get {  AddProperty(SLItemLocs.LbrAcctUnit1); return this; } }         public SLItemLocsBuilder LbrAcctUnit2 { get {  AddProperty(SLItemLocs.LbrAcctUnit2); return this; } }         public SLItemLocsBuilder LbrAcctUnit3 { get {  AddProperty(SLItemLocs.LbrAcctUnit3); return this; } }         public SLItemLocsBuilder LbrAcctUnit4 { get {  AddProperty(SLItemLocs.LbrAcctUnit4); return this; } }         public SLItemLocsBuilder LbrCost { get {  AddProperty(SLItemLocs.LbrCost); return this; } }         public SLItemLocsBuilder Loc { get {  AddProperty(SLItemLocs.Loc); return this; } }         public SLItemLocsBuilder LocDescription { get {  AddProperty(SLItemLocs.LocDescription); return this; } }         public SLItemLocsBuilder LocLoc { get {  AddProperty(SLItemLocs.LocLoc); return this; } }         public SLItemLocsBuilder LocType { get {  AddProperty(SLItemLocs.LocType); return this; } }         public SLItemLocsBuilder LocWc { get {  AddProperty(SLItemLocs.LocWc); return this; } }         public SLItemLocsBuilder MatlCost { get {  AddProperty(SLItemLocs.MatlCost); return this; } }         public SLItemLocsBuilder MrbFlag { get {  AddProperty(SLItemLocs.MrbFlag); return this; } }         public SLItemLocsBuilder NewRank { get {  AddProperty(SLItemLocs.NewRank); return this; } }         public SLItemLocsBuilder NoteExistsFlag { get {  AddProperty(SLItemLocs.NoteExistsFlag); return this; } }         public SLItemLocsBuilder OutaccAccessUnit1 { get {  AddProperty(SLItemLocs.OutaccAccessUnit1); return this; } }         public SLItemLocsBuilder OutaccAccessUnit2 { get {  AddProperty(SLItemLocs.OutaccAccessUnit2); return this; } }         public SLItemLocsBuilder OutaccAccessUnit3 { get {  AddProperty(SLItemLocs.OutaccAccessUnit3); return this; } }         public SLItemLocsBuilder OutaccAccessUnit4 { get {  AddProperty(SLItemLocs.OutaccAccessUnit4); return this; } }         public SLItemLocsBuilder OutaccDescription { get {  AddProperty(SLItemLocs.OutaccDescription); return this; } }         public SLItemLocsBuilder OutAcct { get {  AddProperty(SLItemLocs.OutAcct); return this; } }         public SLItemLocsBuilder OutAcctUnit1 { get {  AddProperty(SLItemLocs.OutAcctUnit1); return this; } }         public SLItemLocsBuilder OutAcctUnit2 { get {  AddProperty(SLItemLocs.OutAcctUnit2); return this; } }         public SLItemLocsBuilder OutAcctUnit3 { get {  AddProperty(SLItemLocs.OutAcctUnit3); return this; } }         public SLItemLocsBuilder OutAcctUnit4 { get {  AddProperty(SLItemLocs.OutAcctUnit4); return this; } }         public SLItemLocsBuilder OutCost { get {  AddProperty(SLItemLocs.OutCost); return this; } }         public SLItemLocsBuilder PermFlag { get {  AddProperty(SLItemLocs.PermFlag); return this; } }         public SLItemLocsBuilder QtyOnHand { get {  AddProperty(SLItemLocs.QtyOnHand); return this; } }         public SLItemLocsBuilder QtyRsvd { get {  AddProperty(SLItemLocs.QtyRsvd); return this; } }         public SLItemLocsBuilder Rank { get {  AddProperty(SLItemLocs.Rank); return this; } }         public SLItemLocsBuilder RecordDate { get {  AddProperty(SLItemLocs.RecordDate); return this; } }         public SLItemLocsBuilder RecordState { get {  AddProperty(SLItemLocs.RecordState); return this; } }         public SLItemLocsBuilder RowPointer { get {  AddProperty(SLItemLocs.RowPointer); return this; } }         public SLItemLocsBuilder SLSerials { get {  AddProperty(SLItemLocs.SLSerials); return this; } }         public SLItemLocsBuilder UbToLoc { get {  AddProperty(SLItemLocs.UbToLoc); return this; } }         public SLItemLocsBuilder UBTrnDate { get {  AddProperty(SLItemLocs.UBTrnDate); return this; } }         public SLItemLocsBuilder UBTrnDesc { get {  AddProperty(SLItemLocs.UBTrnDesc); return this; } }         public SLItemLocsBuilder UBTrnReasonCode { get {  AddProperty(SLItemLocs.UBTrnReasonCode); return this; } }         public SLItemLocsBuilder UBTrnType { get {  AddProperty(SLItemLocs.UBTrnType); return this; } }         public SLItemLocsBuilder UnitCost { get {  AddProperty(SLItemLocs.UnitCost); return this; } }         public SLItemLocsBuilder VovacctAccessUnit1 { get {  AddProperty(SLItemLocs.VovacctAccessUnit1); return this; } }         public SLItemLocsBuilder VovacctAccessUnit2 { get {  AddProperty(SLItemLocs.VovacctAccessUnit2); return this; } }         public SLItemLocsBuilder VovacctAccessUnit3 { get {  AddProperty(SLItemLocs.VovacctAccessUnit3); return this; } }         public SLItemLocsBuilder VovacctAccessUnit4 { get {  AddProperty(SLItemLocs.VovacctAccessUnit4); return this; } }         public SLItemLocsBuilder VovacctDescription { get {  AddProperty(SLItemLocs.VovacctDescription); return this; } }         public SLItemLocsBuilder VovhdAcct { get {  AddProperty(SLItemLocs.VovhdAcct); return this; } }         public SLItemLocsBuilder VovhdAcctUnit1 { get {  AddProperty(SLItemLocs.VovhdAcctUnit1); return this; } }         public SLItemLocsBuilder VovhdAcctUnit2 { get {  AddProperty(SLItemLocs.VovhdAcctUnit2); return this; } }         public SLItemLocsBuilder VovhdAcctUnit3 { get {  AddProperty(SLItemLocs.VovhdAcctUnit3); return this; } }         public SLItemLocsBuilder VovhdAcctUnit4 { get {  AddProperty(SLItemLocs.VovhdAcctUnit4); return this; } }         public SLItemLocsBuilder VovhdCost { get {  AddProperty(SLItemLocs.VovhdCost); return this; } }         public SLItemLocsBuilder Wc { get {  AddProperty(SLItemLocs.Wc); return this; } }         public SLItemLocsBuilder Whse { get {  AddProperty(SLItemLocs.Whse); return this; } }         public SLItemLocsBuilder WhsName { get {  AddProperty(SLItemLocs.WhsName); return this; } }         public SLItemLocsBuilder WhsWhse { get {  AddProperty(SLItemLocs.WhsWhse); return this; } }   

                }public class SLItemLocsFilterExpressionBuilder  
                :   FilterExpressionBuilder<SLItemLocsBuilder>
                [
                        public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerASPSearch
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.DerASPSearch); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerIWhseQtyOnHand
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.DerIWhseQtyOnHand); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerIWhseTotalNonNetStock
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.DerIWhseTotalNonNetStock); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerIWhseTotalRsvdCO
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.DerIWhseTotalRsvdCO); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerTotalCost
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.DerTotalCost); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> DerUM
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.DerUM); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovaccAccessUnit1
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.FovaccAccessUnit1); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovaccAccessUnit2
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.FovaccAccessUnit2); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovaccAccessUnit3
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.FovaccAccessUnit3); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovaccAccessUnit4
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.FovaccAccessUnit4); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovaccDescription
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.FovaccDescription); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdAcct
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.FovhdAcct); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdAcctUnit1
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.FovhdAcctUnit1); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdAcctUnit2
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.FovhdAcctUnit2); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdAcctUnit3
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.FovhdAcctUnit3); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdAcctUnit4
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.FovhdAcctUnit4); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> FovhdCost
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.FovhdCost); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvaccAccessUnit1
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InvaccAccessUnit1); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvaccAccessUnit2
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InvaccAccessUnit2); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvaccAccessUnit3
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InvaccAccessUnit3); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvaccAccessUnit4
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InvaccAccessUnit4); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvaccDescription
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InvaccDescription); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvAcct
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InvAcct); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvAcctUnit1
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InvAcctUnit1); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvAcctUnit2
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InvAcctUnit2); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvAcctUnit3
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InvAcctUnit3); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvAcctUnit4
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InvAcctUnit4); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InvpBflushLoc
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InvpBflushLoc); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.InWorkflow); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> Item
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.Item); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmBflushLoc
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.ItmBflushLoc); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmCostMethod
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.ItmCostMethod); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmCostType
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.ItmCostType); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmDescription
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.ItmDescription); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmIssueBy
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.ItmIssueBy); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmItem
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.ItmItem); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmLotTracked
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.ItmLotTracked); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmSerialTracked
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.ItmSerialTracked); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmUM
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.ItmUM); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> ItmwhseQtyOnHand
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.ItmwhseQtyOnHand); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> JmatlJob
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.JmatlJob); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbraccAccessUnit1
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LbraccAccessUnit1); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbraccAccessUnit2
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LbraccAccessUnit2); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbraccAccessUnit3
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LbraccAccessUnit3); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbraccAccessUnit4
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LbraccAccessUnit4); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbraccDescription
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LbraccDescription); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrAcct
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LbrAcct); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrAcctUnit1
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LbrAcctUnit1); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrAcctUnit2
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LbrAcctUnit2); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrAcctUnit3
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LbrAcctUnit3); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrAcctUnit4
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LbrAcctUnit4); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LbrCost
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LbrCost); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> Loc
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.Loc); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LocDescription
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LocDescription); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LocLoc
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LocLoc); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LocType
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LocType); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> LocWc
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.LocWc); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> MatlCost
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.MatlCost); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> MrbFlag
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.MrbFlag); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> NewRank
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.NewRank); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.NoteExistsFlag); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutaccAccessUnit1
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.OutaccAccessUnit1); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutaccAccessUnit2
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.OutaccAccessUnit2); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutaccAccessUnit3
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.OutaccAccessUnit3); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutaccAccessUnit4
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.OutaccAccessUnit4); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutaccDescription
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.OutaccDescription); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutAcct
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.OutAcct); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutAcctUnit1
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.OutAcctUnit1); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutAcctUnit2
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.OutAcctUnit2); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutAcctUnit3
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.OutAcctUnit3); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutAcctUnit4
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.OutAcctUnit4); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> OutCost
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.OutCost); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> PermFlag
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.PermFlag); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> QtyOnHand
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.QtyOnHand); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> QtyRsvd
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.QtyRsvd); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> Rank
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.Rank); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.RecordDate); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> RecordState
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.RecordState); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.RowPointer); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> SLSerials
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.SLSerials); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UbToLoc
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.UbToLoc); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UBTrnDate
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.UBTrnDate); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UBTrnDesc
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.UBTrnDesc); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UBTrnReasonCode
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.UBTrnReasonCode); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UBTrnType
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.UBTrnType); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> UnitCost
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.UnitCost); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovacctAccessUnit1
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.VovacctAccessUnit1); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovacctAccessUnit2
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.VovacctAccessUnit2); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovacctAccessUnit3
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.VovacctAccessUnit3); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovacctAccessUnit4
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.VovacctAccessUnit4); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovacctDescription
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.VovacctDescription); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdAcct
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.VovhdAcct); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdAcctUnit1
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.VovhdAcctUnit1); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdAcctUnit2
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.VovhdAcctUnit2); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdAcctUnit3
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.VovhdAcctUnit3); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdAcctUnit4
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.VovhdAcctUnit4); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> VovhdCost
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.VovhdCost); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> Wc
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.Wc); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> Whse
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.Whse); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> WhsName
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.WhsName); }
                    }
                            public FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder> WhsWhse
                    {
                        get { return new FilterExpression<SLItemLocsBuilder, SLItemLocsFilterExpressionBuilder>(_builder, SLItemLocs.WhsWhse); }
                    }
                    

                }
            }