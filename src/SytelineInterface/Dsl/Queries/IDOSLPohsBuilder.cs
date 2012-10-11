using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                  public class SLPohs : IdoConstants 
                { 
                           public const string IDO_NAME = "SLPohs";
       public const string ActBrokerage = "ActBrokerage";
       public const string ActDuty = "ActDuty";
       public const string ActFreight = "ActFreight";
       public const string ActInsurance = "ActInsurance";
       public const string ActLocalFreight = "ActLocalFreight";
       public const string BrkAllocMeth = "BrkAllocMeth";
       public const string BrkAllocPercent = "BrkAllocPercent";
       public const string BrkAllocType = "BrkAllocType";
       public const string BrkVendCurrCode = "BrkVendCurrCode";
       public const string BrokerageAmt = "BrokerageAmt";
       public const string BrokerageAmtT = "BrokerageAmtT";
       public const string BrokerageVendName = "BrokerageVendName";
       public const string BrokerageVendNum = "BrokerageVendNum";
       public const string BuilderPoNum = "BuilderPoNum";
       public const string BuilderPoOrigSite = "BuilderPoOrigSite";
       public const string Buyer = "Buyer";
       public const string Charfld1 = "Charfld1";
       public const string Charfld2 = "Charfld2";
       public const string Charfld3 = "Charfld3";
       public const string ContainsTaxFreeMatls = "ContainsTaxFreeMatls";
       public const string CurrAmtFormat = "CurrAmtFormat";
       public const string CurrCode = "CurrCode";
       public const string Datefld = "Datefld";
       public const string Decifld1 = "Decifld1";
       public const string Decifld2 = "Decifld2";
       public const string Decifld3 = "Decifld3";
       public const string Delterm = "Delterm";
       public const string DelTermDesc = "DelTermDesc";
       public const string DerExistLine = "DerExistLine";
       public const string DerExistRelease = "DerExistRelease";
       public const string DerNULLValue = "DerNULLValue";
       public const string DerPchChgNum = "DerPchChgNum";
       public const string DerPchStat = "DerPchStat";
       public const string DerPoChgNum = "DerPoChgNum";
       public const string DerReadOnlyRecord = "DerReadOnlyRecord";
       public const string DistDate = "DistDate";
       public const string DropSeq = "DropSeq";
       public const string DropShipNo = "DropShipNo";
       public const string DutyAllocMeth = "DutyAllocMeth";
       public const string DutyAllocPercent = "DutyAllocPercent";
       public const string DutyAllocType = "DutyAllocType";
       public const string DutyAmt = "DutyAmt";
       public const string DutyAmtT = "DutyAmtT";
       public const string DutyVendCurrCode = "DutyVendCurrCode";
       public const string DutyVendName = "DutyVendName";
       public const string DutyVendNum = "DutyVendNum";
       public const string EffDate = "EffDate";
       public const string EstBrokerage = "EstBrokerage";
       public const string EstDuty = "EstDuty";
       public const string EstFreight = "EstFreight";
       public const string EstInsurance = "EstInsurance";
       public const string EstLocalFreight = "EstLocalFreight";
       public const string ExchRate = "ExchRate";
       public const string ExpDate = "ExpDate";
       public const string FixedRate = "FixedRate";
       public const string Fob = "Fob";
       public const string FormatedShipToAddress = "FormatedShipToAddress";
       public const string FormatedVendAddress = "FormatedVendAddress";
       public const string Freight = "Freight";
       public const string FreightT = "FreightT";
       public const string FreightVendName = "FreightVendName";
       public const string FreightVendNum = "FreightVendNum";
       public const string FrtAllocMeth = "FrtAllocMeth";
       public const string FrtAllocPercent = "FrtAllocPercent";
       public const string FrtAllocType = "FrtAllocType";
       public const string FrtTaxCode1 = "FrtTaxCode1";
       public const string FrtTaxCode2 = "FrtTaxCode2";
       public const string FrtVendCurrCode = "FrtVendCurrCode";
       public const string Ftx1Description = "Ftx1Description";
       public const string Ftx2Description = "Ftx2Description";
       public const string IncludeTaxInCost = "IncludeTaxInCost";
       public const string InsAllocMeth = "InsAllocMeth";
       public const string InsAllocPercent = "InsAllocPercent";
       public const string InsAllocType = "InsAllocType";
       public const string InsuranceAmt = "InsuranceAmt";
       public const string InsuranceAmtT = "InsuranceAmtT";
       public const string InsVendCurrCode = "InsVendCurrCode";
       public const string InsVendName = "InsVendName";
       public const string InsVendNum = "InsVendNum";
       public const string InvDate = "InvDate";
       public const string InvNum = "InvNum";
       public const string InWorkflow = "InWorkflow";
       public const string LocalFreightAmt = "LocalFreightAmt";
       public const string LocalFreightAmtT = "LocalFreightAmtT";
       public const string LocFrtAllocMeth = "LocFrtAllocMeth";
       public const string LocFrtAllocPercent = "LocFrtAllocPercent";
       public const string LocFrtAllocType = "LocFrtAllocType";
       public const string LocFrtVendCurrCode = "LocFrtVendCurrCode";
       public const string LocFrtVendName = "LocFrtVendName";
       public const string LocFrtVendNum = "LocFrtVendNum";
       public const string Logifld = "Logifld";
       public const string MChargesT = "MChargesT";
       public const string MiscCharges = "MiscCharges";
       public const string Msc1Description = "Msc1Description";
       public const string Msc2Description = "Msc2Description";
       public const string MscTaxCode1 = "MscTaxCode1";
       public const string MscTaxCode2 = "MscTaxCode2";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string OrderDate = "OrderDate";
       public const string PchChgNum = "PchChgNum";
       public const string PchStat = "PchStat";
       public const string PoCost = "PoCost";
       public const string PoNum = "PoNum";
       public const string PrepaidAmt = "PrepaidAmt";
       public const string PrepaidT = "PrepaidT";
       public const string PrintPrice = "PrintPrice";
       public const string ProcessInd = "ProcessInd";
       public const string RecordDate = "RecordDate";
       public const string ReqNum = "ReqNum";
       public const string RowPointer = "RowPointer";
       public const string SalesTax = "SalesTax";
       public const string SalesTax2 = "SalesTax2";
       public const string SalesTaxT = "SalesTaxT";
       public const string SalesTaxT2 = "SalesTaxT2";
       public const string ShipAddr = "ShipAddr";
       public const string ShipCode = "ShipCode";
       public const string ShipCodeDesc = "ShipCodeDesc";
       public const string Stat = "Stat";
       public const string SupplyWebPoStat = "SupplyWebPoStat";
       public const string TaxCode1 = "TaxCode1";
       public const string TaxCode2 = "TaxCode2";
       public const string TermsCode = "TermsCode";
       public const string TermsCodeDesc = "TermsCodeDesc";
       public const string TransNat = "TransNat";
       public const string TransNat2 = "TransNat2";
       public const string TransNat2Desc = "TransNat2Desc";
       public const string TransNatDesc = "TransNatDesc";
       public const string Tx1Description = "Tx1Description";
       public const string Tx2Description = "Tx2Description";
       public const string Type = "Type";
       public const string VadName = "VadName";
       public const string VendCatDesc = "VendCatDesc";
       public const string VendCategory = "VendCategory";
       public const string VendContact = "VendContact";
       public const string VendCurrCode = "VendCurrCode";
       public const string VendFaxNum = "VendFaxNum";
       public const string VendLcrNum = "VendLcrNum";
       public const string VendNum = "VendNum";
       public const string VendOrder = "VendOrder";
       public const string VendPhone = "VendPhone";
       public const string VendTelexNum = "VendTelexNum";
       public const string VendType = "VendType";
       public const string Whse = "Whse";
       public const string WhsName = "WhsName";


                }public class SLPohsBuilder  
                :   IdoBuilder<SLPohsBuilder, SLPohsFilterExpressionBuilder>
                {
                        public SLPohsBuilder() : base(SLPohs.IDO_NAME) { }

                      public SLPohsBuilder ActBrokerage { get {  AddProperty(SLPohs.ActBrokerage); return this; } }         public SLPohsBuilder ActDuty { get {  AddProperty(SLPohs.ActDuty); return this; } }         public SLPohsBuilder ActFreight { get {  AddProperty(SLPohs.ActFreight); return this; } }         public SLPohsBuilder ActInsurance { get {  AddProperty(SLPohs.ActInsurance); return this; } }         public SLPohsBuilder ActLocalFreight { get {  AddProperty(SLPohs.ActLocalFreight); return this; } }         public SLPohsBuilder BrkAllocMeth { get {  AddProperty(SLPohs.BrkAllocMeth); return this; } }         public SLPohsBuilder BrkAllocPercent { get {  AddProperty(SLPohs.BrkAllocPercent); return this; } }         public SLPohsBuilder BrkAllocType { get {  AddProperty(SLPohs.BrkAllocType); return this; } }         public SLPohsBuilder BrkVendCurrCode { get {  AddProperty(SLPohs.BrkVendCurrCode); return this; } }         public SLPohsBuilder BrokerageAmt { get {  AddProperty(SLPohs.BrokerageAmt); return this; } }         public SLPohsBuilder BrokerageAmtT { get {  AddProperty(SLPohs.BrokerageAmtT); return this; } }         public SLPohsBuilder BrokerageVendName { get {  AddProperty(SLPohs.BrokerageVendName); return this; } }         public SLPohsBuilder BrokerageVendNum { get {  AddProperty(SLPohs.BrokerageVendNum); return this; } }         public SLPohsBuilder BuilderPoNum { get {  AddProperty(SLPohs.BuilderPoNum); return this; } }         public SLPohsBuilder BuilderPoOrigSite { get {  AddProperty(SLPohs.BuilderPoOrigSite); return this; } }         public SLPohsBuilder Buyer { get {  AddProperty(SLPohs.Buyer); return this; } }         public SLPohsBuilder Charfld1 { get {  AddProperty(SLPohs.Charfld1); return this; } }         public SLPohsBuilder Charfld2 { get {  AddProperty(SLPohs.Charfld2); return this; } }         public SLPohsBuilder Charfld3 { get {  AddProperty(SLPohs.Charfld3); return this; } }         public SLPohsBuilder ContainsTaxFreeMatls { get {  AddProperty(SLPohs.ContainsTaxFreeMatls); return this; } }         public SLPohsBuilder CurrAmtFormat { get {  AddProperty(SLPohs.CurrAmtFormat); return this; } }         public SLPohsBuilder CurrCode { get {  AddProperty(SLPohs.CurrCode); return this; } }         public SLPohsBuilder Datefld { get {  AddProperty(SLPohs.Datefld); return this; } }         public SLPohsBuilder Decifld1 { get {  AddProperty(SLPohs.Decifld1); return this; } }         public SLPohsBuilder Decifld2 { get {  AddProperty(SLPohs.Decifld2); return this; } }         public SLPohsBuilder Decifld3 { get {  AddProperty(SLPohs.Decifld3); return this; } }         public SLPohsBuilder Delterm { get {  AddProperty(SLPohs.Delterm); return this; } }         public SLPohsBuilder DelTermDesc { get {  AddProperty(SLPohs.DelTermDesc); return this; } }         public SLPohsBuilder DerExistLine { get {  AddProperty(SLPohs.DerExistLine); return this; } }         public SLPohsBuilder DerExistRelease { get {  AddProperty(SLPohs.DerExistRelease); return this; } }         public SLPohsBuilder DerNULLValue { get {  AddProperty(SLPohs.DerNULLValue); return this; } }         public SLPohsBuilder DerPchChgNum { get {  AddProperty(SLPohs.DerPchChgNum); return this; } }         public SLPohsBuilder DerPchStat { get {  AddProperty(SLPohs.DerPchStat); return this; } }         public SLPohsBuilder DerPoChgNum { get {  AddProperty(SLPohs.DerPoChgNum); return this; } }         public SLPohsBuilder DerReadOnlyRecord { get {  AddProperty(SLPohs.DerReadOnlyRecord); return this; } }         public SLPohsBuilder DistDate { get {  AddProperty(SLPohs.DistDate); return this; } }         public SLPohsBuilder DropSeq { get {  AddProperty(SLPohs.DropSeq); return this; } }         public SLPohsBuilder DropShipNo { get {  AddProperty(SLPohs.DropShipNo); return this; } }         public SLPohsBuilder DutyAllocMeth { get {  AddProperty(SLPohs.DutyAllocMeth); return this; } }         public SLPohsBuilder DutyAllocPercent { get {  AddProperty(SLPohs.DutyAllocPercent); return this; } }         public SLPohsBuilder DutyAllocType { get {  AddProperty(SLPohs.DutyAllocType); return this; } }         public SLPohsBuilder DutyAmt { get {  AddProperty(SLPohs.DutyAmt); return this; } }         public SLPohsBuilder DutyAmtT { get {  AddProperty(SLPohs.DutyAmtT); return this; } }         public SLPohsBuilder DutyVendCurrCode { get {  AddProperty(SLPohs.DutyVendCurrCode); return this; } }         public SLPohsBuilder DutyVendName { get {  AddProperty(SLPohs.DutyVendName); return this; } }         public SLPohsBuilder DutyVendNum { get {  AddProperty(SLPohs.DutyVendNum); return this; } }         public SLPohsBuilder EffDate { get {  AddProperty(SLPohs.EffDate); return this; } }         public SLPohsBuilder EstBrokerage { get {  AddProperty(SLPohs.EstBrokerage); return this; } }         public SLPohsBuilder EstDuty { get {  AddProperty(SLPohs.EstDuty); return this; } }         public SLPohsBuilder EstFreight { get {  AddProperty(SLPohs.EstFreight); return this; } }         public SLPohsBuilder EstInsurance { get {  AddProperty(SLPohs.EstInsurance); return this; } }         public SLPohsBuilder EstLocalFreight { get {  AddProperty(SLPohs.EstLocalFreight); return this; } }         public SLPohsBuilder ExchRate { get {  AddProperty(SLPohs.ExchRate); return this; } }         public SLPohsBuilder ExpDate { get {  AddProperty(SLPohs.ExpDate); return this; } }         public SLPohsBuilder FixedRate { get {  AddProperty(SLPohs.FixedRate); return this; } }         public SLPohsBuilder Fob { get {  AddProperty(SLPohs.Fob); return this; } }         public SLPohsBuilder FormatedShipToAddress { get {  AddProperty(SLPohs.FormatedShipToAddress); return this; } }         public SLPohsBuilder FormatedVendAddress { get {  AddProperty(SLPohs.FormatedVendAddress); return this; } }         public SLPohsBuilder Freight { get {  AddProperty(SLPohs.Freight); return this; } }         public SLPohsBuilder FreightT { get {  AddProperty(SLPohs.FreightT); return this; } }         public SLPohsBuilder FreightVendName { get {  AddProperty(SLPohs.FreightVendName); return this; } }         public SLPohsBuilder FreightVendNum { get {  AddProperty(SLPohs.FreightVendNum); return this; } }         public SLPohsBuilder FrtAllocMeth { get {  AddProperty(SLPohs.FrtAllocMeth); return this; } }         public SLPohsBuilder FrtAllocPercent { get {  AddProperty(SLPohs.FrtAllocPercent); return this; } }         public SLPohsBuilder FrtAllocType { get {  AddProperty(SLPohs.FrtAllocType); return this; } }         public SLPohsBuilder FrtTaxCode1 { get {  AddProperty(SLPohs.FrtTaxCode1); return this; } }         public SLPohsBuilder FrtTaxCode2 { get {  AddProperty(SLPohs.FrtTaxCode2); return this; } }         public SLPohsBuilder FrtVendCurrCode { get {  AddProperty(SLPohs.FrtVendCurrCode); return this; } }         public SLPohsBuilder Ftx1Description { get {  AddProperty(SLPohs.Ftx1Description); return this; } }         public SLPohsBuilder Ftx2Description { get {  AddProperty(SLPohs.Ftx2Description); return this; } }         public SLPohsBuilder IncludeTaxInCost { get {  AddProperty(SLPohs.IncludeTaxInCost); return this; } }         public SLPohsBuilder InsAllocMeth { get {  AddProperty(SLPohs.InsAllocMeth); return this; } }         public SLPohsBuilder InsAllocPercent { get {  AddProperty(SLPohs.InsAllocPercent); return this; } }         public SLPohsBuilder InsAllocType { get {  AddProperty(SLPohs.InsAllocType); return this; } }         public SLPohsBuilder InsuranceAmt { get {  AddProperty(SLPohs.InsuranceAmt); return this; } }         public SLPohsBuilder InsuranceAmtT { get {  AddProperty(SLPohs.InsuranceAmtT); return this; } }         public SLPohsBuilder InsVendCurrCode { get {  AddProperty(SLPohs.InsVendCurrCode); return this; } }         public SLPohsBuilder InsVendName { get {  AddProperty(SLPohs.InsVendName); return this; } }         public SLPohsBuilder InsVendNum { get {  AddProperty(SLPohs.InsVendNum); return this; } }         public SLPohsBuilder InvDate { get {  AddProperty(SLPohs.InvDate); return this; } }         public SLPohsBuilder InvNum { get {  AddProperty(SLPohs.InvNum); return this; } }         public SLPohsBuilder InWorkflow { get {  AddProperty(SLPohs.InWorkflow); return this; } }         public SLPohsBuilder LocalFreightAmt { get {  AddProperty(SLPohs.LocalFreightAmt); return this; } }         public SLPohsBuilder LocalFreightAmtT { get {  AddProperty(SLPohs.LocalFreightAmtT); return this; } }         public SLPohsBuilder LocFrtAllocMeth { get {  AddProperty(SLPohs.LocFrtAllocMeth); return this; } }         public SLPohsBuilder LocFrtAllocPercent { get {  AddProperty(SLPohs.LocFrtAllocPercent); return this; } }         public SLPohsBuilder LocFrtAllocType { get {  AddProperty(SLPohs.LocFrtAllocType); return this; } }         public SLPohsBuilder LocFrtVendCurrCode { get {  AddProperty(SLPohs.LocFrtVendCurrCode); return this; } }         public SLPohsBuilder LocFrtVendName { get {  AddProperty(SLPohs.LocFrtVendName); return this; } }         public SLPohsBuilder LocFrtVendNum { get {  AddProperty(SLPohs.LocFrtVendNum); return this; } }         public SLPohsBuilder Logifld { get {  AddProperty(SLPohs.Logifld); return this; } }         public SLPohsBuilder MChargesT { get {  AddProperty(SLPohs.MChargesT); return this; } }         public SLPohsBuilder MiscCharges { get {  AddProperty(SLPohs.MiscCharges); return this; } }         public SLPohsBuilder Msc1Description { get {  AddProperty(SLPohs.Msc1Description); return this; } }         public SLPohsBuilder Msc2Description { get {  AddProperty(SLPohs.Msc2Description); return this; } }         public SLPohsBuilder MscTaxCode1 { get {  AddProperty(SLPohs.MscTaxCode1); return this; } }         public SLPohsBuilder MscTaxCode2 { get {  AddProperty(SLPohs.MscTaxCode2); return this; } }         public SLPohsBuilder NoteExistsFlag { get {  AddProperty(SLPohs.NoteExistsFlag); return this; } }         public SLPohsBuilder OrderDate { get {  AddProperty(SLPohs.OrderDate); return this; } }         public SLPohsBuilder PchChgNum { get {  AddProperty(SLPohs.PchChgNum); return this; } }         public SLPohsBuilder PchStat { get {  AddProperty(SLPohs.PchStat); return this; } }         public SLPohsBuilder PoCost { get {  AddProperty(SLPohs.PoCost); return this; } }         public SLPohsBuilder PoNum { get {  AddProperty(SLPohs.PoNum); return this; } }         public SLPohsBuilder PrepaidAmt { get {  AddProperty(SLPohs.PrepaidAmt); return this; } }         public SLPohsBuilder PrepaidT { get {  AddProperty(SLPohs.PrepaidT); return this; } }         public SLPohsBuilder PrintPrice { get {  AddProperty(SLPohs.PrintPrice); return this; } }         public SLPohsBuilder ProcessInd { get {  AddProperty(SLPohs.ProcessInd); return this; } }         public SLPohsBuilder RecordDate { get {  AddProperty(SLPohs.RecordDate); return this; } }         public SLPohsBuilder ReqNum { get {  AddProperty(SLPohs.ReqNum); return this; } }         public SLPohsBuilder RowPointer { get {  AddProperty(SLPohs.RowPointer); return this; } }         public SLPohsBuilder SalesTax { get {  AddProperty(SLPohs.SalesTax); return this; } }         public SLPohsBuilder SalesTax2 { get {  AddProperty(SLPohs.SalesTax2); return this; } }         public SLPohsBuilder SalesTaxT { get {  AddProperty(SLPohs.SalesTaxT); return this; } }         public SLPohsBuilder SalesTaxT2 { get {  AddProperty(SLPohs.SalesTaxT2); return this; } }         public SLPohsBuilder ShipAddr { get {  AddProperty(SLPohs.ShipAddr); return this; } }         public SLPohsBuilder ShipCode { get {  AddProperty(SLPohs.ShipCode); return this; } }         public SLPohsBuilder ShipCodeDesc { get {  AddProperty(SLPohs.ShipCodeDesc); return this; } }         public SLPohsBuilder Stat { get {  AddProperty(SLPohs.Stat); return this; } }         public SLPohsBuilder SupplyWebPoStat { get {  AddProperty(SLPohs.SupplyWebPoStat); return this; } }         public SLPohsBuilder TaxCode1 { get {  AddProperty(SLPohs.TaxCode1); return this; } }         public SLPohsBuilder TaxCode2 { get {  AddProperty(SLPohs.TaxCode2); return this; } }         public SLPohsBuilder TermsCode { get {  AddProperty(SLPohs.TermsCode); return this; } }         public SLPohsBuilder TermsCodeDesc { get {  AddProperty(SLPohs.TermsCodeDesc); return this; } }         public SLPohsBuilder TransNat { get {  AddProperty(SLPohs.TransNat); return this; } }         public SLPohsBuilder TransNat2 { get {  AddProperty(SLPohs.TransNat2); return this; } }         public SLPohsBuilder TransNat2Desc { get {  AddProperty(SLPohs.TransNat2Desc); return this; } }         public SLPohsBuilder TransNatDesc { get {  AddProperty(SLPohs.TransNatDesc); return this; } }         public SLPohsBuilder Tx1Description { get {  AddProperty(SLPohs.Tx1Description); return this; } }         public SLPohsBuilder Tx2Description { get {  AddProperty(SLPohs.Tx2Description); return this; } }         public SLPohsBuilder Type { get {  AddProperty(SLPohs.Type); return this; } }         public SLPohsBuilder VadName { get {  AddProperty(SLPohs.VadName); return this; } }         public SLPohsBuilder VendCatDesc { get {  AddProperty(SLPohs.VendCatDesc); return this; } }         public SLPohsBuilder VendCategory { get {  AddProperty(SLPohs.VendCategory); return this; } }         public SLPohsBuilder VendContact { get {  AddProperty(SLPohs.VendContact); return this; } }         public SLPohsBuilder VendCurrCode { get {  AddProperty(SLPohs.VendCurrCode); return this; } }         public SLPohsBuilder VendFaxNum { get {  AddProperty(SLPohs.VendFaxNum); return this; } }         public SLPohsBuilder VendLcrNum { get {  AddProperty(SLPohs.VendLcrNum); return this; } }         public SLPohsBuilder VendNum { get {  AddProperty(SLPohs.VendNum); return this; } }         public SLPohsBuilder VendOrder { get {  AddProperty(SLPohs.VendOrder); return this; } }         public SLPohsBuilder VendPhone { get {  AddProperty(SLPohs.VendPhone); return this; } }         public SLPohsBuilder VendTelexNum { get {  AddProperty(SLPohs.VendTelexNum); return this; } }         public SLPohsBuilder VendType { get {  AddProperty(SLPohs.VendType); return this; } }         public SLPohsBuilder Whse { get {  AddProperty(SLPohs.Whse); return this; } }         public SLPohsBuilder WhsName { get {  AddProperty(SLPohs.WhsName); return this; } }   

                }public class SLPohsFilterExpressionBuilder  
                :   FilterExpressionBuilder<SLPohsBuilder>
                [
                        public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ActBrokerage
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ActBrokerage); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ActDuty
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ActDuty); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ActFreight
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ActFreight); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ActInsurance
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ActInsurance); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ActLocalFreight
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ActLocalFreight); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> BrkAllocMeth
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.BrkAllocMeth); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> BrkAllocPercent
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.BrkAllocPercent); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> BrkAllocType
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.BrkAllocType); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> BrkVendCurrCode
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.BrkVendCurrCode); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> BrokerageAmt
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.BrokerageAmt); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> BrokerageAmtT
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.BrokerageAmtT); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> BrokerageVendName
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.BrokerageVendName); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> BrokerageVendNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.BrokerageVendNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> BuilderPoNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.BuilderPoNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> BuilderPoOrigSite
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.BuilderPoOrigSite); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Buyer
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Buyer); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Charfld1
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Charfld1); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Charfld2
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Charfld2); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Charfld3
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Charfld3); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ContainsTaxFreeMatls
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ContainsTaxFreeMatls); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> CurrAmtFormat
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.CurrAmtFormat); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> CurrCode
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.CurrCode); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Datefld
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Datefld); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Decifld1
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Decifld1); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Decifld2
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Decifld2); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Decifld3
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Decifld3); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Delterm
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Delterm); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DelTermDesc
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DelTermDesc); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DerExistLine
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DerExistLine); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DerExistRelease
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DerExistRelease); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DerNULLValue
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DerNULLValue); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DerPchChgNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DerPchChgNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DerPchStat
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DerPchStat); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DerPoChgNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DerPoChgNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DerReadOnlyRecord
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DerReadOnlyRecord); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DistDate
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DistDate); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DropSeq
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DropSeq); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DropShipNo
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DropShipNo); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DutyAllocMeth
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DutyAllocMeth); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DutyAllocPercent
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DutyAllocPercent); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DutyAllocType
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DutyAllocType); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DutyAmt
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DutyAmt); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DutyAmtT
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DutyAmtT); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DutyVendCurrCode
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DutyVendCurrCode); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DutyVendName
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DutyVendName); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> DutyVendNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.DutyVendNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> EffDate
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.EffDate); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> EstBrokerage
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.EstBrokerage); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> EstDuty
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.EstDuty); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> EstFreight
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.EstFreight); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> EstInsurance
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.EstInsurance); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> EstLocalFreight
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.EstLocalFreight); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ExchRate
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ExchRate); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ExpDate
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ExpDate); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FixedRate
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FixedRate); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Fob
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Fob); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FormatedShipToAddress
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FormatedShipToAddress); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FormatedVendAddress
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FormatedVendAddress); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Freight
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Freight); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FreightT
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FreightT); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FreightVendName
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FreightVendName); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FreightVendNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FreightVendNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FrtAllocMeth
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FrtAllocMeth); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FrtAllocPercent
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FrtAllocPercent); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FrtAllocType
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FrtAllocType); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FrtTaxCode1
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FrtTaxCode1); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FrtTaxCode2
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FrtTaxCode2); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> FrtVendCurrCode
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.FrtVendCurrCode); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Ftx1Description
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Ftx1Description); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Ftx2Description
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Ftx2Description); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> IncludeTaxInCost
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.IncludeTaxInCost); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> InsAllocMeth
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.InsAllocMeth); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> InsAllocPercent
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.InsAllocPercent); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> InsAllocType
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.InsAllocType); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> InsuranceAmt
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.InsuranceAmt); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> InsuranceAmtT
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.InsuranceAmtT); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> InsVendCurrCode
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.InsVendCurrCode); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> InsVendName
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.InsVendName); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> InsVendNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.InsVendNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> InvDate
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.InvDate); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> InvNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.InvNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.InWorkflow); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> LocalFreightAmt
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.LocalFreightAmt); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> LocalFreightAmtT
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.LocalFreightAmtT); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> LocFrtAllocMeth
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.LocFrtAllocMeth); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> LocFrtAllocPercent
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.LocFrtAllocPercent); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> LocFrtAllocType
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.LocFrtAllocType); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> LocFrtVendCurrCode
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.LocFrtVendCurrCode); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> LocFrtVendName
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.LocFrtVendName); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> LocFrtVendNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.LocFrtVendNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Logifld
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Logifld); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> MChargesT
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.MChargesT); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> MiscCharges
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.MiscCharges); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Msc1Description
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Msc1Description); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Msc2Description
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Msc2Description); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> MscTaxCode1
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.MscTaxCode1); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> MscTaxCode2
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.MscTaxCode2); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.NoteExistsFlag); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> OrderDate
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.OrderDate); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> PchChgNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.PchChgNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> PchStat
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.PchStat); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> PoCost
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.PoCost); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> PoNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.PoNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> PrepaidAmt
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.PrepaidAmt); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> PrepaidT
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.PrepaidT); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> PrintPrice
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.PrintPrice); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ProcessInd
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ProcessInd); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.RecordDate); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ReqNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ReqNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.RowPointer); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> SalesTax
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.SalesTax); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> SalesTax2
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.SalesTax2); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> SalesTaxT
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.SalesTaxT); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> SalesTaxT2
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.SalesTaxT2); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ShipAddr
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ShipAddr); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ShipCode
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ShipCode); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> ShipCodeDesc
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.ShipCodeDesc); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Stat
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Stat); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> SupplyWebPoStat
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.SupplyWebPoStat); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> TaxCode1
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.TaxCode1); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> TaxCode2
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.TaxCode2); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> TermsCode
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.TermsCode); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> TermsCodeDesc
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.TermsCodeDesc); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> TransNat
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.TransNat); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> TransNat2
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.TransNat2); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> TransNat2Desc
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.TransNat2Desc); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> TransNatDesc
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.TransNatDesc); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Tx1Description
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Tx1Description); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Tx2Description
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Tx2Description); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Type
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Type); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VadName
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VadName); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VendCatDesc
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VendCatDesc); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VendCategory
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VendCategory); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VendContact
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VendContact); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VendCurrCode
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VendCurrCode); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VendFaxNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VendFaxNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VendLcrNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VendLcrNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VendNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VendNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VendOrder
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VendOrder); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VendPhone
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VendPhone); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VendTelexNum
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VendTelexNum); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> VendType
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.VendType); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> Whse
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.Whse); }
                    }
                            public FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder> WhsName
                    {
                        get { return new FilterExpression<SLPohsBuilder, SLPohsFilterExpressionBuilder>(_builder, SLPohs.WhsName); }
                    }
                    

                }
            }