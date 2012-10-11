using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                  public class Warehouses : IdoConstants 
                { 
                           public const string IDO_NAME = "SLWhses";
       public const string Addr_1 = "Addr_1";
       public const string Addr_2 = "Addr_2";
       public const string Addr_3 = "Addr_3";
       public const string Addr_4 = "Addr_4";
       public const string Charfld1 = "Charfld1";
       public const string Charfld2 = "Charfld2";
       public const string Charfld3 = "Charfld3";
       public const string City = "City";
       public const string Contact = "Contact";
       public const string Country = "Country";
       public const string CountryECCode = "CountryECCode";
       public const string CycleFreq = "CycleFreq";
       public const string CycleType = "CycleType";
       public const string Datefld = "Datefld";
       public const string Decifld1 = "Decifld1";
       public const string Decifld2 = "Decifld2";
       public const string Decifld3 = "Decifld3";
       public const string DedicatedInventory = "DedicatedInventory";
       public const string Delterm = "Delterm";
       public const string DelTermDescription = "DelTermDescription";
       public const string DerCycleTypeD = "DerCycleTypeD";
       public const string DerCycleTypeI = "DerCycleTypeI";
       public const string DerCycleTypeR = "DerCycleTypeR";
       public const string DerCycleTypeZ = "DerCycleTypeZ";
       public const string DerInvAcct = "DerInvAcct";
       public const string DerItem = "DerItem";
       public const string DerLoc = "DerLoc";
       public const string DerLot = "DerLot";
       public const string DerTcAmtExtCost = "DerTcAmtExtCost";
       public const string DerTcCprUnitCost = "DerTcCprUnitCost";
       public const string DerTcQtuQtyOnHand = "DerTcQtuQtyOnHand";
       public const string DerTotCost = "DerTotCost";
       public const string DerTotLocCost = "DerTotLocCost";
       public const string DerTotTrans = "DerTotTrans";
       public const string DerTotWhseCost = "DerTotWhseCost";
       public const string DerTransportDescription = "DerTransportDescription";
       public const string DerWhse = "DerWhse";
       public const string FaxNum = "FaxNum";
       public const string InWorkflow = "InWorkflow";
       public const string Logifld = "Logifld";
       public const string Name = "Name";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string Phone = "Phone";
       public const string PhyInvFlg = "PhyInvFlg";
       public const string ProcessInd = "ProcessInd";
       public const string RecordDate = "RecordDate";
       public const string RowPointer = "RowPointer";
       public const string SiteRef = "SiteRef";
       public const string SLItemwhses = "SLItemwhses";
       public const string State = "State";
       public const string TaxRegNum1 = "TaxRegNum1";
       public const string TransNat = "TransNat";
       public const string TransNat2 = "TransNat2";
       public const string TransNat2Description = "TransNat2Description";
       public const string TransNatDescription = "TransNatDescription";
       public const string Transport = "Transport";
       public const string UbSelected = "UbSelected";
       public const string Whse = "Whse";
       public const string Zip = "Zip";


                }
                    
                    public class SLWhsesBuilder  
                :   IdoBuilder<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>
                {
                        public SLWhsesBuilder() : base(Warehouses.IDO_NAME) { }

                      public SLWhsesBuilder Addr_1 { get {  AddProperty(Warehouses.Addr_1); return this; } }         public SLWhsesBuilder Addr_2 { get {  AddProperty(Warehouses.Addr_2); return this; } }         public SLWhsesBuilder Addr_3 { get {  AddProperty(Warehouses.Addr_3); return this; } }         public SLWhsesBuilder Addr_4 { get {  AddProperty(Warehouses.Addr_4); return this; } }         public SLWhsesBuilder Charfld1 { get {  AddProperty(Warehouses.Charfld1); return this; } }         public SLWhsesBuilder Charfld2 { get {  AddProperty(Warehouses.Charfld2); return this; } }         public SLWhsesBuilder Charfld3 { get {  AddProperty(Warehouses.Charfld3); return this; } }         public SLWhsesBuilder City { get {  AddProperty(Warehouses.City); return this; } }         public SLWhsesBuilder Contact { get {  AddProperty(Warehouses.Contact); return this; } }         public SLWhsesBuilder Country { get {  AddProperty(Warehouses.Country); return this; } }         public SLWhsesBuilder CountryECCode { get {  AddProperty(Warehouses.CountryECCode); return this; } }         public SLWhsesBuilder CycleFreq { get {  AddProperty(Warehouses.CycleFreq); return this; } }         public SLWhsesBuilder CycleType { get {  AddProperty(Warehouses.CycleType); return this; } }         public SLWhsesBuilder Datefld { get {  AddProperty(Warehouses.Datefld); return this; } }         public SLWhsesBuilder Decifld1 { get {  AddProperty(Warehouses.Decifld1); return this; } }         public SLWhsesBuilder Decifld2 { get {  AddProperty(Warehouses.Decifld2); return this; } }         public SLWhsesBuilder Decifld3 { get {  AddProperty(Warehouses.Decifld3); return this; } }         public SLWhsesBuilder DedicatedInventory { get {  AddProperty(Warehouses.DedicatedInventory); return this; } }         public SLWhsesBuilder Delterm { get {  AddProperty(Warehouses.Delterm); return this; } }         public SLWhsesBuilder DelTermDescription { get {  AddProperty(Warehouses.DelTermDescription); return this; } }         public SLWhsesBuilder DerCycleTypeD { get {  AddProperty(Warehouses.DerCycleTypeD); return this; } }         public SLWhsesBuilder DerCycleTypeI { get {  AddProperty(Warehouses.DerCycleTypeI); return this; } }         public SLWhsesBuilder DerCycleTypeR { get {  AddProperty(Warehouses.DerCycleTypeR); return this; } }         public SLWhsesBuilder DerCycleTypeZ { get {  AddProperty(Warehouses.DerCycleTypeZ); return this; } }         public SLWhsesBuilder DerInvAcct { get {  AddProperty(Warehouses.DerInvAcct); return this; } }         public SLWhsesBuilder DerItem { get {  AddProperty(Warehouses.DerItem); return this; } }         public SLWhsesBuilder DerLoc { get {  AddProperty(Warehouses.DerLoc); return this; } }         public SLWhsesBuilder DerLot { get {  AddProperty(Warehouses.DerLot); return this; } }         public SLWhsesBuilder DerTcAmtExtCost { get {  AddProperty(Warehouses.DerTcAmtExtCost); return this; } }         public SLWhsesBuilder DerTcCprUnitCost { get {  AddProperty(Warehouses.DerTcCprUnitCost); return this; } }         public SLWhsesBuilder DerTcQtuQtyOnHand { get {  AddProperty(Warehouses.DerTcQtuQtyOnHand); return this; } }         public SLWhsesBuilder DerTotCost { get {  AddProperty(Warehouses.DerTotCost); return this; } }         public SLWhsesBuilder DerTotLocCost { get {  AddProperty(Warehouses.DerTotLocCost); return this; } }         public SLWhsesBuilder DerTotTrans { get {  AddProperty(Warehouses.DerTotTrans); return this; } }         public SLWhsesBuilder DerTotWhseCost { get {  AddProperty(Warehouses.DerTotWhseCost); return this; } }         public SLWhsesBuilder DerTransportDescription { get {  AddProperty(Warehouses.DerTransportDescription); return this; } }         public SLWhsesBuilder DerWhse { get {  AddProperty(Warehouses.DerWhse); return this; } }         public SLWhsesBuilder FaxNum { get {  AddProperty(Warehouses.FaxNum); return this; } }         public SLWhsesBuilder InWorkflow { get {  AddProperty(Warehouses.InWorkflow); return this; } }         public SLWhsesBuilder Logifld { get {  AddProperty(Warehouses.Logifld); return this; } }         public SLWhsesBuilder Name { get {  AddProperty(Warehouses.Name); return this; } }         public SLWhsesBuilder NoteExistsFlag { get {  AddProperty(Warehouses.NoteExistsFlag); return this; } }         public SLWhsesBuilder Phone { get {  AddProperty(Warehouses.Phone); return this; } }         public SLWhsesBuilder PhyInvFlg { get {  AddProperty(Warehouses.PhyInvFlg); return this; } }         public SLWhsesBuilder ProcessInd { get {  AddProperty(Warehouses.ProcessInd); return this; } }         public SLWhsesBuilder RecordDate { get {  AddProperty(Warehouses.RecordDate); return this; } }         public SLWhsesBuilder RowPointer { get {  AddProperty(Warehouses.RowPointer); return this; } }         public SLWhsesBuilder SiteRef { get {  AddProperty(Warehouses.SiteRef); return this; } }         public SLWhsesBuilder SLItemwhses { get {  AddProperty(Warehouses.SLItemwhses); return this; } }         public SLWhsesBuilder State { get {  AddProperty(Warehouses.State); return this; } }         public SLWhsesBuilder TaxRegNum1 { get {  AddProperty(Warehouses.TaxRegNum1); return this; } }         public SLWhsesBuilder TransNat { get {  AddProperty(Warehouses.TransNat); return this; } }         public SLWhsesBuilder TransNat2 { get {  AddProperty(Warehouses.TransNat2); return this; } }         public SLWhsesBuilder TransNat2Description { get {  AddProperty(Warehouses.TransNat2Description); return this; } }         public SLWhsesBuilder TransNatDescription { get {  AddProperty(Warehouses.TransNatDescription); return this; } }         public SLWhsesBuilder Transport { get {  AddProperty(Warehouses.Transport); return this; } }         public SLWhsesBuilder UbSelected { get {  AddProperty(Warehouses.UbSelected); return this; } }         public SLWhsesBuilder Whse { get {  AddProperty(Warehouses.Whse); return this; } }         public SLWhsesBuilder Zip { get {  AddProperty(Warehouses.Zip); return this; } }   

                }public class SLWhsesFilterExpressionBuilder  
                :   FilterExpressionBuilder<SLWhsesBuilder>
                [
                        public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Addr_1
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Addr_1); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Addr_2
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Addr_2); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Addr_3
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Addr_3); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Addr_4
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Addr_4); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Charfld1
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Charfld1); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Charfld2
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Charfld2); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Charfld3
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Charfld3); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> City
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.City); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Contact
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Contact); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Country
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Country); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> CountryECCode
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.CountryECCode); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> CycleFreq
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.CycleFreq); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> CycleType
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.CycleType); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Datefld
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Datefld); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Decifld1
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Decifld1); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Decifld2
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Decifld2); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Decifld3
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Decifld3); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DedicatedInventory
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DedicatedInventory); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Delterm
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Delterm); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DelTermDescription
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DelTermDescription); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerCycleTypeD
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerCycleTypeD); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerCycleTypeI
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerCycleTypeI); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerCycleTypeR
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerCycleTypeR); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerCycleTypeZ
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerCycleTypeZ); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerInvAcct
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerInvAcct); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerItem
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerItem); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerLoc
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerLoc); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerLot
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerLot); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerTcAmtExtCost
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerTcAmtExtCost); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerTcCprUnitCost
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerTcCprUnitCost); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerTcQtuQtyOnHand
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerTcQtuQtyOnHand); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerTotCost
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerTotCost); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerTotLocCost
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerTotLocCost); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerTotTrans
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerTotTrans); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerTotWhseCost
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerTotWhseCost); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerTransportDescription
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerTransportDescription); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> DerWhse
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.DerWhse); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> FaxNum
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.FaxNum); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.InWorkflow); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Logifld
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Logifld); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Name
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Name); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.NoteExistsFlag); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Phone
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Phone); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> PhyInvFlg
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.PhyInvFlg); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> ProcessInd
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.ProcessInd); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.RecordDate); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.RowPointer); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> SiteRef
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.SiteRef); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> SLItemwhses
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.SLItemwhses); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> State
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.State); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> TaxRegNum1
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.TaxRegNum1); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> TransNat
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.TransNat); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> TransNat2
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.TransNat2); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> TransNat2Description
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.TransNat2Description); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> TransNatDescription
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.TransNatDescription); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Transport
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Transport); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> UbSelected
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.UbSelected); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Whse
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Whse); }
                    }
                            public FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder> Zip
                    {
                        get { return new FilterExpression<SLWhsesBuilder, SLWhsesFilterExpressionBuilder>(_builder, Warehouses.Zip); }
                    }
                    

                }
            }