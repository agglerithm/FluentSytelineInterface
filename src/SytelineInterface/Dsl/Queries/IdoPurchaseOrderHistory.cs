using SytelineInterface.Core;

namespace SytelineInterface.Dsl
{
    using Commands;

    public class IdoPurchaseOrderHistory : IdoConstants
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


    }

    public class IdoPurchaseOrderHistoryBuilder
        : IdoQueryBuilder<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>
    {
        public IdoPurchaseOrderHistoryBuilder(IExpressionInterpreter interpreter) : base(IdoPurchaseOrderHistory.IDO_NAME, interpreter) { }

        public IdoPurchaseOrderHistoryBuilder ActBrokerage { get { AddProperty(IdoPurchaseOrderHistory.ActBrokerage); return this; } }
        public IdoPurchaseOrderHistoryBuilder ActDuty { get { AddProperty(IdoPurchaseOrderHistory.ActDuty); return this; } }
        public IdoPurchaseOrderHistoryBuilder ActFreight { get { AddProperty(IdoPurchaseOrderHistory.ActFreight); return this; } }
        public IdoPurchaseOrderHistoryBuilder ActInsurance { get { AddProperty(IdoPurchaseOrderHistory.ActInsurance); return this; } }
        public IdoPurchaseOrderHistoryBuilder ActLocalFreight { get { AddProperty(IdoPurchaseOrderHistory.ActLocalFreight); return this; } }
        public IdoPurchaseOrderHistoryBuilder BrkAllocMeth { get { AddProperty(IdoPurchaseOrderHistory.BrkAllocMeth); return this; } }
        public IdoPurchaseOrderHistoryBuilder BrkAllocPercent { get { AddProperty(IdoPurchaseOrderHistory.BrkAllocPercent); return this; } }
        public IdoPurchaseOrderHistoryBuilder BrkAllocType { get { AddProperty(IdoPurchaseOrderHistory.BrkAllocType); return this; } }
        public IdoPurchaseOrderHistoryBuilder BrkVendCurrCode { get { AddProperty(IdoPurchaseOrderHistory.BrkVendCurrCode); return this; } }
        public IdoPurchaseOrderHistoryBuilder BrokerageAmt { get { AddProperty(IdoPurchaseOrderHistory.BrokerageAmt); return this; } }
        public IdoPurchaseOrderHistoryBuilder BrokerageAmtT { get { AddProperty(IdoPurchaseOrderHistory.BrokerageAmtT); return this; } }
        public IdoPurchaseOrderHistoryBuilder BrokerageVendName { get { AddProperty(IdoPurchaseOrderHistory.BrokerageVendName); return this; } }
        public IdoPurchaseOrderHistoryBuilder BrokerageVendNum { get { AddProperty(IdoPurchaseOrderHistory.BrokerageVendNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder BuilderPoNum { get { AddProperty(IdoPurchaseOrderHistory.BuilderPoNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder BuilderPoOrigSite { get { AddProperty(IdoPurchaseOrderHistory.BuilderPoOrigSite); return this; } }
        public IdoPurchaseOrderHistoryBuilder Buyer { get { AddProperty(IdoPurchaseOrderHistory.Buyer); return this; } }
        public IdoPurchaseOrderHistoryBuilder Charfld1 { get { AddProperty(IdoPurchaseOrderHistory.Charfld1); return this; } }
        public IdoPurchaseOrderHistoryBuilder Charfld2 { get { AddProperty(IdoPurchaseOrderHistory.Charfld2); return this; } }
        public IdoPurchaseOrderHistoryBuilder Charfld3 { get { AddProperty(IdoPurchaseOrderHistory.Charfld3); return this; } }
        public IdoPurchaseOrderHistoryBuilder ContainsTaxFreeMatls { get { AddProperty(IdoPurchaseOrderHistory.ContainsTaxFreeMatls); return this; } }
        public IdoPurchaseOrderHistoryBuilder CurrAmtFormat { get { AddProperty(IdoPurchaseOrderHistory.CurrAmtFormat); return this; } }
        public IdoPurchaseOrderHistoryBuilder CurrCode { get { AddProperty(IdoPurchaseOrderHistory.CurrCode); return this; } }
        public IdoPurchaseOrderHistoryBuilder Datefld { get { AddProperty(IdoPurchaseOrderHistory.Datefld); return this; } }
        public IdoPurchaseOrderHistoryBuilder Decifld1 { get { AddProperty(IdoPurchaseOrderHistory.Decifld1); return this; } }
        public IdoPurchaseOrderHistoryBuilder Decifld2 { get { AddProperty(IdoPurchaseOrderHistory.Decifld2); return this; } }
        public IdoPurchaseOrderHistoryBuilder Decifld3 { get { AddProperty(IdoPurchaseOrderHistory.Decifld3); return this; } }
        public IdoPurchaseOrderHistoryBuilder Delterm { get { AddProperty(IdoPurchaseOrderHistory.Delterm); return this; } }
        public IdoPurchaseOrderHistoryBuilder DelTermDesc { get { AddProperty(IdoPurchaseOrderHistory.DelTermDesc); return this; } }
        public IdoPurchaseOrderHistoryBuilder DerExistLine { get { AddProperty(IdoPurchaseOrderHistory.DerExistLine); return this; } }
        public IdoPurchaseOrderHistoryBuilder DerExistRelease { get { AddProperty(IdoPurchaseOrderHistory.DerExistRelease); return this; } }
        public IdoPurchaseOrderHistoryBuilder DerNULLValue { get { AddProperty(IdoPurchaseOrderHistory.DerNULLValue); return this; } }
        public IdoPurchaseOrderHistoryBuilder DerPchChgNum { get { AddProperty(IdoPurchaseOrderHistory.DerPchChgNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder DerPchStat { get { AddProperty(IdoPurchaseOrderHistory.DerPchStat); return this; } }
        public IdoPurchaseOrderHistoryBuilder DerPoChgNum { get { AddProperty(IdoPurchaseOrderHistory.DerPoChgNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder DerReadOnlyRecord { get { AddProperty(IdoPurchaseOrderHistory.DerReadOnlyRecord); return this; } }
        public IdoPurchaseOrderHistoryBuilder DistDate { get { AddProperty(IdoPurchaseOrderHistory.DistDate); return this; } }
        public IdoPurchaseOrderHistoryBuilder DropSeq { get { AddProperty(IdoPurchaseOrderHistory.DropSeq); return this; } }
        public IdoPurchaseOrderHistoryBuilder DropShipNo { get { AddProperty(IdoPurchaseOrderHistory.DropShipNo); return this; } }
        public IdoPurchaseOrderHistoryBuilder DutyAllocMeth { get { AddProperty(IdoPurchaseOrderHistory.DutyAllocMeth); return this; } }
        public IdoPurchaseOrderHistoryBuilder DutyAllocPercent { get { AddProperty(IdoPurchaseOrderHistory.DutyAllocPercent); return this; } }
        public IdoPurchaseOrderHistoryBuilder DutyAllocType { get { AddProperty(IdoPurchaseOrderHistory.DutyAllocType); return this; } }
        public IdoPurchaseOrderHistoryBuilder DutyAmt { get { AddProperty(IdoPurchaseOrderHistory.DutyAmt); return this; } }
        public IdoPurchaseOrderHistoryBuilder DutyAmtT { get { AddProperty(IdoPurchaseOrderHistory.DutyAmtT); return this; } }
        public IdoPurchaseOrderHistoryBuilder DutyVendCurrCode { get { AddProperty(IdoPurchaseOrderHistory.DutyVendCurrCode); return this; } }
        public IdoPurchaseOrderHistoryBuilder DutyVendName { get { AddProperty(IdoPurchaseOrderHistory.DutyVendName); return this; } }
        public IdoPurchaseOrderHistoryBuilder DutyVendNum { get { AddProperty(IdoPurchaseOrderHistory.DutyVendNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder EffDate { get { AddProperty(IdoPurchaseOrderHistory.EffDate); return this; } }
        public IdoPurchaseOrderHistoryBuilder EstBrokerage { get { AddProperty(IdoPurchaseOrderHistory.EstBrokerage); return this; } }
        public IdoPurchaseOrderHistoryBuilder EstDuty { get { AddProperty(IdoPurchaseOrderHistory.EstDuty); return this; } }
        public IdoPurchaseOrderHistoryBuilder EstFreight { get { AddProperty(IdoPurchaseOrderHistory.EstFreight); return this; } }
        public IdoPurchaseOrderHistoryBuilder EstInsurance { get { AddProperty(IdoPurchaseOrderHistory.EstInsurance); return this; } }
        public IdoPurchaseOrderHistoryBuilder EstLocalFreight { get { AddProperty(IdoPurchaseOrderHistory.EstLocalFreight); return this; } }
        public IdoPurchaseOrderHistoryBuilder ExchRate { get { AddProperty(IdoPurchaseOrderHistory.ExchRate); return this; } }
        public IdoPurchaseOrderHistoryBuilder ExpDate { get { AddProperty(IdoPurchaseOrderHistory.ExpDate); return this; } }
        public IdoPurchaseOrderHistoryBuilder FixedRate { get { AddProperty(IdoPurchaseOrderHistory.FixedRate); return this; } }
        public IdoPurchaseOrderHistoryBuilder Fob { get { AddProperty(IdoPurchaseOrderHistory.Fob); return this; } }
        public IdoPurchaseOrderHistoryBuilder FormatedShipToAddress { get { AddProperty(IdoPurchaseOrderHistory.FormatedShipToAddress); return this; } }
        public IdoPurchaseOrderHistoryBuilder FormatedVendAddress { get { AddProperty(IdoPurchaseOrderHistory.FormatedVendAddress); return this; } }
        public IdoPurchaseOrderHistoryBuilder Freight { get { AddProperty(IdoPurchaseOrderHistory.Freight); return this; } }
        public IdoPurchaseOrderHistoryBuilder FreightT { get { AddProperty(IdoPurchaseOrderHistory.FreightT); return this; } }
        public IdoPurchaseOrderHistoryBuilder FreightVendName { get { AddProperty(IdoPurchaseOrderHistory.FreightVendName); return this; } }
        public IdoPurchaseOrderHistoryBuilder FreightVendNum { get { AddProperty(IdoPurchaseOrderHistory.FreightVendNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder FrtAllocMeth { get { AddProperty(IdoPurchaseOrderHistory.FrtAllocMeth); return this; } }
        public IdoPurchaseOrderHistoryBuilder FrtAllocPercent { get { AddProperty(IdoPurchaseOrderHistory.FrtAllocPercent); return this; } }
        public IdoPurchaseOrderHistoryBuilder FrtAllocType { get { AddProperty(IdoPurchaseOrderHistory.FrtAllocType); return this; } }
        public IdoPurchaseOrderHistoryBuilder FrtTaxCode1 { get { AddProperty(IdoPurchaseOrderHistory.FrtTaxCode1); return this; } }
        public IdoPurchaseOrderHistoryBuilder FrtTaxCode2 { get { AddProperty(IdoPurchaseOrderHistory.FrtTaxCode2); return this; } }
        public IdoPurchaseOrderHistoryBuilder FrtVendCurrCode { get { AddProperty(IdoPurchaseOrderHistory.FrtVendCurrCode); return this; } }
        public IdoPurchaseOrderHistoryBuilder Ftx1Description { get { AddProperty(IdoPurchaseOrderHistory.Ftx1Description); return this; } }
        public IdoPurchaseOrderHistoryBuilder Ftx2Description { get { AddProperty(IdoPurchaseOrderHistory.Ftx2Description); return this; } }
        public IdoPurchaseOrderHistoryBuilder IncludeTaxInCost { get { AddProperty(IdoPurchaseOrderHistory.IncludeTaxInCost); return this; } }
        public IdoPurchaseOrderHistoryBuilder InsAllocMeth { get { AddProperty(IdoPurchaseOrderHistory.InsAllocMeth); return this; } }
        public IdoPurchaseOrderHistoryBuilder InsAllocPercent { get { AddProperty(IdoPurchaseOrderHistory.InsAllocPercent); return this; } }
        public IdoPurchaseOrderHistoryBuilder InsAllocType { get { AddProperty(IdoPurchaseOrderHistory.InsAllocType); return this; } }
        public IdoPurchaseOrderHistoryBuilder InsuranceAmt { get { AddProperty(IdoPurchaseOrderHistory.InsuranceAmt); return this; } }
        public IdoPurchaseOrderHistoryBuilder InsuranceAmtT { get { AddProperty(IdoPurchaseOrderHistory.InsuranceAmtT); return this; } }
        public IdoPurchaseOrderHistoryBuilder InsVendCurrCode { get { AddProperty(IdoPurchaseOrderHistory.InsVendCurrCode); return this; } }
        public IdoPurchaseOrderHistoryBuilder InsVendName { get { AddProperty(IdoPurchaseOrderHistory.InsVendName); return this; } }
        public IdoPurchaseOrderHistoryBuilder InsVendNum { get { AddProperty(IdoPurchaseOrderHistory.InsVendNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder InvDate { get { AddProperty(IdoPurchaseOrderHistory.InvDate); return this; } }
        public IdoPurchaseOrderHistoryBuilder InvNum { get { AddProperty(IdoPurchaseOrderHistory.InvNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder InWorkflow { get { AddProperty(IdoPurchaseOrderHistory.InWorkflow); return this; } }
        public IdoPurchaseOrderHistoryBuilder LocalFreightAmt { get { AddProperty(IdoPurchaseOrderHistory.LocalFreightAmt); return this; } }
        public IdoPurchaseOrderHistoryBuilder LocalFreightAmtT { get { AddProperty(IdoPurchaseOrderHistory.LocalFreightAmtT); return this; } }
        public IdoPurchaseOrderHistoryBuilder LocFrtAllocMeth { get { AddProperty(IdoPurchaseOrderHistory.LocFrtAllocMeth); return this; } }
        public IdoPurchaseOrderHistoryBuilder LocFrtAllocPercent { get { AddProperty(IdoPurchaseOrderHistory.LocFrtAllocPercent); return this; } }
        public IdoPurchaseOrderHistoryBuilder LocFrtAllocType { get { AddProperty(IdoPurchaseOrderHistory.LocFrtAllocType); return this; } }
        public IdoPurchaseOrderHistoryBuilder LocFrtVendCurrCode { get { AddProperty(IdoPurchaseOrderHistory.LocFrtVendCurrCode); return this; } }
        public IdoPurchaseOrderHistoryBuilder LocFrtVendName { get { AddProperty(IdoPurchaseOrderHistory.LocFrtVendName); return this; } }
        public IdoPurchaseOrderHistoryBuilder LocFrtVendNum { get { AddProperty(IdoPurchaseOrderHistory.LocFrtVendNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder Logifld { get { AddProperty(IdoPurchaseOrderHistory.Logifld); return this; } }
        public IdoPurchaseOrderHistoryBuilder MChargesT { get { AddProperty(IdoPurchaseOrderHistory.MChargesT); return this; } }
        public IdoPurchaseOrderHistoryBuilder MiscCharges { get { AddProperty(IdoPurchaseOrderHistory.MiscCharges); return this; } }
        public IdoPurchaseOrderHistoryBuilder Msc1Description { get { AddProperty(IdoPurchaseOrderHistory.Msc1Description); return this; } }
        public IdoPurchaseOrderHistoryBuilder Msc2Description { get { AddProperty(IdoPurchaseOrderHistory.Msc2Description); return this; } }
        public IdoPurchaseOrderHistoryBuilder MscTaxCode1 { get { AddProperty(IdoPurchaseOrderHistory.MscTaxCode1); return this; } }
        public IdoPurchaseOrderHistoryBuilder MscTaxCode2 { get { AddProperty(IdoPurchaseOrderHistory.MscTaxCode2); return this; } }
        public IdoPurchaseOrderHistoryBuilder NoteExistsFlag { get { AddProperty(IdoPurchaseOrderHistory.NoteExistsFlag); return this; } }
        public IdoPurchaseOrderHistoryBuilder OrderDate { get { AddProperty(IdoPurchaseOrderHistory.OrderDate); return this; } }
        public IdoPurchaseOrderHistoryBuilder PchChgNum { get { AddProperty(IdoPurchaseOrderHistory.PchChgNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder PchStat { get { AddProperty(IdoPurchaseOrderHistory.PchStat); return this; } }
        public IdoPurchaseOrderHistoryBuilder PoCost { get { AddProperty(IdoPurchaseOrderHistory.PoCost); return this; } }
        public IdoPurchaseOrderHistoryBuilder PoNum { get { AddProperty(IdoPurchaseOrderHistory.PoNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder PrepaidAmt { get { AddProperty(IdoPurchaseOrderHistory.PrepaidAmt); return this; } }
        public IdoPurchaseOrderHistoryBuilder PrepaidT { get { AddProperty(IdoPurchaseOrderHistory.PrepaidT); return this; } }
        public IdoPurchaseOrderHistoryBuilder PrintPrice { get { AddProperty(IdoPurchaseOrderHistory.PrintPrice); return this; } }
        public IdoPurchaseOrderHistoryBuilder ProcessInd { get { AddProperty(IdoPurchaseOrderHistory.ProcessInd); return this; } }
        public IdoPurchaseOrderHistoryBuilder RecordDate { get { AddProperty(IdoPurchaseOrderHistory.RecordDate); return this; } }
        public IdoPurchaseOrderHistoryBuilder ReqNum { get { AddProperty(IdoPurchaseOrderHistory.ReqNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder RowPointer { get { AddProperty(IdoPurchaseOrderHistory.RowPointer); return this; } }
        public IdoPurchaseOrderHistoryBuilder SalesTax { get { AddProperty(IdoPurchaseOrderHistory.SalesTax); return this; } }
        public IdoPurchaseOrderHistoryBuilder SalesTax2 { get { AddProperty(IdoPurchaseOrderHistory.SalesTax2); return this; } }
        public IdoPurchaseOrderHistoryBuilder SalesTaxT { get { AddProperty(IdoPurchaseOrderHistory.SalesTaxT); return this; } }
        public IdoPurchaseOrderHistoryBuilder SalesTaxT2 { get { AddProperty(IdoPurchaseOrderHistory.SalesTaxT2); return this; } }
        public IdoPurchaseOrderHistoryBuilder ShipAddr { get { AddProperty(IdoPurchaseOrderHistory.ShipAddr); return this; } }
        public IdoPurchaseOrderHistoryBuilder ShipCode { get { AddProperty(IdoPurchaseOrderHistory.ShipCode); return this; } }
        public IdoPurchaseOrderHistoryBuilder ShipCodeDesc { get { AddProperty(IdoPurchaseOrderHistory.ShipCodeDesc); return this; } }
        public IdoPurchaseOrderHistoryBuilder Stat { get { AddProperty(IdoPurchaseOrderHistory.Stat); return this; } }
        public IdoPurchaseOrderHistoryBuilder SupplyWebPoStat { get { AddProperty(IdoPurchaseOrderHistory.SupplyWebPoStat); return this; } }
        public IdoPurchaseOrderHistoryBuilder TaxCode1 { get { AddProperty(IdoPurchaseOrderHistory.TaxCode1); return this; } }
        public IdoPurchaseOrderHistoryBuilder TaxCode2 { get { AddProperty(IdoPurchaseOrderHistory.TaxCode2); return this; } }
        public IdoPurchaseOrderHistoryBuilder TermsCode { get { AddProperty(IdoPurchaseOrderHistory.TermsCode); return this; } }
        public IdoPurchaseOrderHistoryBuilder TermsCodeDesc { get { AddProperty(IdoPurchaseOrderHistory.TermsCodeDesc); return this; } }
        public IdoPurchaseOrderHistoryBuilder TransNat { get { AddProperty(IdoPurchaseOrderHistory.TransNat); return this; } }
        public IdoPurchaseOrderHistoryBuilder TransNat2 { get { AddProperty(IdoPurchaseOrderHistory.TransNat2); return this; } }
        public IdoPurchaseOrderHistoryBuilder TransNat2Desc { get { AddProperty(IdoPurchaseOrderHistory.TransNat2Desc); return this; } }
        public IdoPurchaseOrderHistoryBuilder TransNatDesc { get { AddProperty(IdoPurchaseOrderHistory.TransNatDesc); return this; } }
        public IdoPurchaseOrderHistoryBuilder Tx1Description { get { AddProperty(IdoPurchaseOrderHistory.Tx1Description); return this; } }
        public IdoPurchaseOrderHistoryBuilder Tx2Description { get { AddProperty(IdoPurchaseOrderHistory.Tx2Description); return this; } }
        public IdoPurchaseOrderHistoryBuilder Type { get { AddProperty(IdoPurchaseOrderHistory.Type); return this; } }
        public IdoPurchaseOrderHistoryBuilder VadName { get { AddProperty(IdoPurchaseOrderHistory.VadName); return this; } }
        public IdoPurchaseOrderHistoryBuilder VendCatDesc { get { AddProperty(IdoPurchaseOrderHistory.VendCatDesc); return this; } }
        public IdoPurchaseOrderHistoryBuilder VendCategory { get { AddProperty(IdoPurchaseOrderHistory.VendCategory); return this; } }
        public IdoPurchaseOrderHistoryBuilder VendContact { get { AddProperty(IdoPurchaseOrderHistory.VendContact); return this; } }
        public IdoPurchaseOrderHistoryBuilder VendCurrCode { get { AddProperty(IdoPurchaseOrderHistory.VendCurrCode); return this; } }
        public IdoPurchaseOrderHistoryBuilder VendFaxNum { get { AddProperty(IdoPurchaseOrderHistory.VendFaxNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder VendLcrNum { get { AddProperty(IdoPurchaseOrderHistory.VendLcrNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder VendNum { get { AddProperty(IdoPurchaseOrderHistory.VendNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder VendOrder { get { AddProperty(IdoPurchaseOrderHistory.VendOrder); return this; } }
        public IdoPurchaseOrderHistoryBuilder VendPhone { get { AddProperty(IdoPurchaseOrderHistory.VendPhone); return this; } }
        public IdoPurchaseOrderHistoryBuilder VendTelexNum { get { AddProperty(IdoPurchaseOrderHistory.VendTelexNum); return this; } }
        public IdoPurchaseOrderHistoryBuilder VendType { get { AddProperty(IdoPurchaseOrderHistory.VendType); return this; } }
        public IdoPurchaseOrderHistoryBuilder Whse { get { AddProperty(IdoPurchaseOrderHistory.Whse); return this; } }
        public IdoPurchaseOrderHistoryBuilder WhsName { get { AddProperty(IdoPurchaseOrderHistory.WhsName); return this; } }


    }

    public class IdoPurchaseOrderHistoryFilterExpressionBuilder
        : FilterExpressionBuilder<IdoPurchaseOrderHistoryBuilder>
    {
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ActBrokerage
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ActBrokerage); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ActDuty
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ActDuty); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ActFreight
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ActFreight); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ActInsurance
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ActInsurance); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ActLocalFreight
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ActLocalFreight); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> BrkAllocMeth
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.BrkAllocMeth); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> BrkAllocPercent
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.BrkAllocPercent); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> BrkAllocType
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.BrkAllocType); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> BrkVendCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.BrkVendCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> BrokerageAmt
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.BrokerageAmt); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> BrokerageAmtT
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.BrokerageAmtT); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> BrokerageVendName
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.BrokerageVendName); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> BrokerageVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.BrokerageVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> BuilderPoNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.BuilderPoNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> BuilderPoOrigSite
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.BuilderPoOrigSite); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Buyer
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Buyer); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Charfld1
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Charfld1); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Charfld2
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Charfld2); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Charfld3
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Charfld3); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ContainsTaxFreeMatls
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ContainsTaxFreeMatls); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> CurrAmtFormat
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.CurrAmtFormat); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> CurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.CurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Datefld
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Datefld); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Decifld1
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Decifld1); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Decifld2
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Decifld2); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Decifld3
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Decifld3); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Delterm
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Delterm); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DelTermDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DelTermDesc); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DerExistLine
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DerExistLine); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DerExistRelease
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DerExistRelease); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DerNULLValue
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DerNULLValue); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DerPchChgNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DerPchChgNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DerPchStat
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DerPchStat); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DerPoChgNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DerPoChgNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DerReadOnlyRecord
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DerReadOnlyRecord); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DistDate
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DistDate); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DropSeq
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DropSeq); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DropShipNo
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DropShipNo); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DutyAllocMeth
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DutyAllocMeth); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DutyAllocPercent
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DutyAllocPercent); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DutyAllocType
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DutyAllocType); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DutyAmt
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DutyAmt); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DutyAmtT
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DutyAmtT); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DutyVendCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DutyVendCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DutyVendName
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DutyVendName); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> DutyVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.DutyVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> EffDate
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.EffDate); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> EstBrokerage
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.EstBrokerage); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> EstDuty
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.EstDuty); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> EstFreight
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.EstFreight); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> EstInsurance
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.EstInsurance); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> EstLocalFreight
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.EstLocalFreight); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ExchRate
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ExchRate); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ExpDate
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ExpDate); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FixedRate
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FixedRate); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Fob
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Fob); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FormatedShipToAddress
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FormatedShipToAddress); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FormatedVendAddress
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FormatedVendAddress); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Freight
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Freight); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FreightT
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FreightT); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FreightVendName
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FreightVendName); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FreightVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FreightVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FrtAllocMeth
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FrtAllocMeth); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FrtAllocPercent
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FrtAllocPercent); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FrtAllocType
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FrtAllocType); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FrtTaxCode1
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FrtTaxCode1); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FrtTaxCode2
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FrtTaxCode2); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> FrtVendCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.FrtVendCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Ftx1Description
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Ftx1Description); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Ftx2Description
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Ftx2Description); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> IncludeTaxInCost
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.IncludeTaxInCost); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> InsAllocMeth
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.InsAllocMeth); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> InsAllocPercent
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.InsAllocPercent); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> InsAllocType
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.InsAllocType); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> InsuranceAmt
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.InsuranceAmt); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> InsuranceAmtT
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.InsuranceAmtT); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> InsVendCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.InsVendCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> InsVendName
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.InsVendName); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> InsVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.InsVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> InvDate
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.InvDate); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> InvNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.InvNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.InWorkflow); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> LocalFreightAmt
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.LocalFreightAmt); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> LocalFreightAmtT
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.LocalFreightAmtT); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> LocFrtAllocMeth
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.LocFrtAllocMeth); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> LocFrtAllocPercent
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.LocFrtAllocPercent); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> LocFrtAllocType
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.LocFrtAllocType); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> LocFrtVendCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.LocFrtVendCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> LocFrtVendName
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.LocFrtVendName); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> LocFrtVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.LocFrtVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Logifld
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Logifld); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> MChargesT
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.MChargesT); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> MiscCharges
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.MiscCharges); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Msc1Description
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Msc1Description); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Msc2Description
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Msc2Description); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> MscTaxCode1
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.MscTaxCode1); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> MscTaxCode2
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.MscTaxCode2); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.NoteExistsFlag); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> OrderDate
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.OrderDate); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> PchChgNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.PchChgNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> PchStat
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.PchStat); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> PoCost
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.PoCost); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> PoNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.PoNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> PrepaidAmt
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.PrepaidAmt); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> PrepaidT
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.PrepaidT); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> PrintPrice
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.PrintPrice); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ProcessInd
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ProcessInd); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.RecordDate); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ReqNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ReqNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.RowPointer); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> SalesTax
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.SalesTax); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> SalesTax2
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.SalesTax2); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> SalesTaxT
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.SalesTaxT); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> SalesTaxT2
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.SalesTaxT2); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ShipAddr
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ShipAddr); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ShipCode
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ShipCode); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> ShipCodeDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.ShipCodeDesc); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Stat
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Stat); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> SupplyWebPoStat
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.SupplyWebPoStat); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> TaxCode1
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.TaxCode1); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> TaxCode2
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.TaxCode2); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> TermsCode
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.TermsCode); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> TermsCodeDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.TermsCodeDesc); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> TransNat
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.TransNat); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> TransNat2
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.TransNat2); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> TransNat2Desc
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.TransNat2Desc); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> TransNatDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.TransNatDesc); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Tx1Description
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Tx1Description); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Tx2Description
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Tx2Description); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Type
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Type); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VadName
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VadName); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VendCatDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VendCatDesc); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VendCategory
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VendCategory); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VendContact
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VendContact); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VendCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VendCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VendFaxNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VendFaxNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VendLcrNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VendLcrNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VendNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VendOrder
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VendOrder); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VendPhone
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VendPhone); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VendTelexNum
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VendTelexNum); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> VendType
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.VendType); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> Whse
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.Whse); }
        }
        public FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder> WhsName
        {
            get { return new FilterExpression<IdoPurchaseOrderHistoryBuilder, IdoPurchaseOrderHistoryFilterExpressionBuilder>(_builder, IdoPurchaseOrderHistory.WhsName); }
        }


    }
}