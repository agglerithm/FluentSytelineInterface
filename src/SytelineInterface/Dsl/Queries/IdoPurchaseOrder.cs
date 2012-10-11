using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    public class IdoPurchaseOrder : IdoConstants
    {
        public const string IDO_NAME = "SLPos";
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
        public const string BuilderPoPrinted = "BuilderPoPrinted";
        public const string Buyer = "Buyer";
        public const string Charfld1 = "Charfld1";
        public const string Charfld2 = "Charfld2";
        public const string Charfld3 = "Charfld3";
        public const string ContainsOnlyTaxFreeMatls = "ContainsOnlyTaxFreeMatls";
        public const string CurrAmtFormat = "CurrAmtFormat";
        public const string CurrAmtTotFormat = "CurrAmtTotFormat";
        public const string CurrCstPrcFormat = "CurrCstPrcFormat";
        public const string Datefld = "Datefld";
        public const string Decifld1 = "Decifld1";
        public const string Decifld2 = "Decifld2";
        public const string Decifld3 = "Decifld3";
        public const string Delterm = "Delterm";
        public const string DelTermDescription = "DelTermDescription";
        public const string DerASPSearch = "DerASPSearch";
        public const string DerExistsLine = "DerExistsLine";
        public const string DerExistsPoBln = "DerExistsPoBln";
        public const string DerHasXref = "DerHasXref";
        public const string DerIsFixed = "DerIsFixed";
        public const string DerMessage = "DerMessage";
        public const string DerNewStat = "DerNewStat";
        public const string DerNULLValue = "DerNULLValue";
        public const string DerOldStat = "DerOldStat";
        public const string DerOldVendNum = "DerOldVendNum";
        public const string DerPchChgNum = "DerPchChgNum";
        public const string DerPchStat = "DerPchStat";
        public const string DerPoNum = "DerPoNum";
        public const string DerStatFormatted = "DerStatFormatted";
        public const string DerUpdatable = "DerUpdatable";
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
        public const string FlagChangeStat = "FlagChangeStat";
        public const string FlagPochange = "FlagPochange";
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
        public const string PoparAmendPo = "PoparAmendPo";
        public const string PoparPoChange = "PoparPoChange";
        public const string PoparVendorRequired = "PoparVendorRequired";
        public const string PrepaidAmt = "PrepaidAmt";
        public const string PrepaidT = "PrepaidT";
        public const string PrintPrice = "PrintPrice";
        public const string ProcessInd = "ProcessInd";
        public const string Received = "Received";
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
        public const string SLPochanges = "SLPochanges";
        public const string Stat = "Stat";
        public const string SupplyWebPoStat = "SupplyWebPoStat";
        public const string SynchronizedToBus = "SynchronizedToBus";
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
        public const string VenCurrCode = "VenCurrCode";
        public const string VendCatDesc = "VendCatDesc";
        public const string VendCategory = "VendCategory";
        public const string VendContact = "VendContact";
        public const string VendCountry = "VendCountry";
        public const string VendFaxNum = "VendFaxNum";
        public const string VendLcrNum = "VendLcrNum";
        public const string VendNum = "VendNum";
        public const string VendOrder = "VendOrder";
        public const string VendorName = "VendorName";
        public const string VendPhone = "VendPhone";
        public const string VendTelexNum = "VendTelexNum";
        public const string VendType = "VendType";
        public const string VenLcrReqd = "VenLcrReqd";
        public const string Whse = "Whse";
        public const string WhsName = "WhsName";


    }

    public class IdoPurchaseOrderBuilder
        : IdoQueryBuilder<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>
    {
        public IdoPurchaseOrderBuilder(IExpressionInterpreter interpreter) : base(IdoPurchaseOrder.IDO_NAME, interpreter) { }

        public IdoPurchaseOrderBuilder ActBrokerage { get { AddProperty(IdoPurchaseOrder.ActBrokerage); return this; } }
        public IdoPurchaseOrderBuilder ActDuty { get { AddProperty(IdoPurchaseOrder.ActDuty); return this; } }
        public IdoPurchaseOrderBuilder ActFreight { get { AddProperty(IdoPurchaseOrder.ActFreight); return this; } }
        public IdoPurchaseOrderBuilder ActInsurance { get { AddProperty(IdoPurchaseOrder.ActInsurance); return this; } }
        public IdoPurchaseOrderBuilder ActLocalFreight { get { AddProperty(IdoPurchaseOrder.ActLocalFreight); return this; } }
        public IdoPurchaseOrderBuilder BrkAllocMeth { get { AddProperty(IdoPurchaseOrder.BrkAllocMeth); return this; } }
        public IdoPurchaseOrderBuilder BrkAllocPercent { get { AddProperty(IdoPurchaseOrder.BrkAllocPercent); return this; } }
        public IdoPurchaseOrderBuilder BrkAllocType { get { AddProperty(IdoPurchaseOrder.BrkAllocType); return this; } }
        public IdoPurchaseOrderBuilder BrkVendCurrCode { get { AddProperty(IdoPurchaseOrder.BrkVendCurrCode); return this; } }
        public IdoPurchaseOrderBuilder BrokerageAmt { get { AddProperty(IdoPurchaseOrder.BrokerageAmt); return this; } }
        public IdoPurchaseOrderBuilder BrokerageAmtT { get { AddProperty(IdoPurchaseOrder.BrokerageAmtT); return this; } }
        public IdoPurchaseOrderBuilder BrokerageVendName { get { AddProperty(IdoPurchaseOrder.BrokerageVendName); return this; } }
        public IdoPurchaseOrderBuilder BrokerageVendNum { get { AddProperty(IdoPurchaseOrder.BrokerageVendNum); return this; } }
        public IdoPurchaseOrderBuilder BuilderPoNum { get { AddProperty(IdoPurchaseOrder.BuilderPoNum); return this; } }
        public IdoPurchaseOrderBuilder BuilderPoOrigSite { get { AddProperty(IdoPurchaseOrder.BuilderPoOrigSite); return this; } }
        public IdoPurchaseOrderBuilder BuilderPoPrinted { get { AddProperty(IdoPurchaseOrder.BuilderPoPrinted); return this; } }
        public IdoPurchaseOrderBuilder Buyer { get { AddProperty(IdoPurchaseOrder.Buyer); return this; } }
        public IdoPurchaseOrderBuilder Charfld1 { get { AddProperty(IdoPurchaseOrder.Charfld1); return this; } }
        public IdoPurchaseOrderBuilder Charfld2 { get { AddProperty(IdoPurchaseOrder.Charfld2); return this; } }
        public IdoPurchaseOrderBuilder Charfld3 { get { AddProperty(IdoPurchaseOrder.Charfld3); return this; } }
        public IdoPurchaseOrderBuilder ContainsOnlyTaxFreeMatls { get { AddProperty(IdoPurchaseOrder.ContainsOnlyTaxFreeMatls); return this; } }
        public IdoPurchaseOrderBuilder CurrAmtFormat { get { AddProperty(IdoPurchaseOrder.CurrAmtFormat); return this; } }
        public IdoPurchaseOrderBuilder CurrAmtTotFormat { get { AddProperty(IdoPurchaseOrder.CurrAmtTotFormat); return this; } }
        public IdoPurchaseOrderBuilder CurrCstPrcFormat { get { AddProperty(IdoPurchaseOrder.CurrCstPrcFormat); return this; } }
        public IdoPurchaseOrderBuilder Datefld { get { AddProperty(IdoPurchaseOrder.Datefld); return this; } }
        public IdoPurchaseOrderBuilder Decifld1 { get { AddProperty(IdoPurchaseOrder.Decifld1); return this; } }
        public IdoPurchaseOrderBuilder Decifld2 { get { AddProperty(IdoPurchaseOrder.Decifld2); return this; } }
        public IdoPurchaseOrderBuilder Decifld3 { get { AddProperty(IdoPurchaseOrder.Decifld3); return this; } }
        public IdoPurchaseOrderBuilder Delterm { get { AddProperty(IdoPurchaseOrder.Delterm); return this; } }
        public IdoPurchaseOrderBuilder DelTermDescription { get { AddProperty(IdoPurchaseOrder.DelTermDescription); return this; } }
        public IdoPurchaseOrderBuilder DerASPSearch { get { AddProperty(IdoPurchaseOrder.DerASPSearch); return this; } }
        public IdoPurchaseOrderBuilder DerExistsLine { get { AddProperty(IdoPurchaseOrder.DerExistsLine); return this; } }
        public IdoPurchaseOrderBuilder DerExistsPoBln { get { AddProperty(IdoPurchaseOrder.DerExistsPoBln); return this; } }
        public IdoPurchaseOrderBuilder DerHasXref { get { AddProperty(IdoPurchaseOrder.DerHasXref); return this; } }
        public IdoPurchaseOrderBuilder DerIsFixed { get { AddProperty(IdoPurchaseOrder.DerIsFixed); return this; } }
        public IdoPurchaseOrderBuilder DerMessage { get { AddProperty(IdoPurchaseOrder.DerMessage); return this; } }
        public IdoPurchaseOrderBuilder DerNewStat { get { AddProperty(IdoPurchaseOrder.DerNewStat); return this; } }
        public IdoPurchaseOrderBuilder DerNULLValue { get { AddProperty(IdoPurchaseOrder.DerNULLValue); return this; } }
        public IdoPurchaseOrderBuilder DerOldStat { get { AddProperty(IdoPurchaseOrder.DerOldStat); return this; } }
        public IdoPurchaseOrderBuilder DerOldVendNum { get { AddProperty(IdoPurchaseOrder.DerOldVendNum); return this; } }
        public IdoPurchaseOrderBuilder DerPchChgNum { get { AddProperty(IdoPurchaseOrder.DerPchChgNum); return this; } }
        public IdoPurchaseOrderBuilder DerPchStat { get { AddProperty(IdoPurchaseOrder.DerPchStat); return this; } }
        public IdoPurchaseOrderBuilder DerPoNum { get { AddProperty(IdoPurchaseOrder.DerPoNum); return this; } }
        public IdoPurchaseOrderBuilder DerStatFormatted { get { AddProperty(IdoPurchaseOrder.DerStatFormatted); return this; } }
        public IdoPurchaseOrderBuilder DerUpdatable { get { AddProperty(IdoPurchaseOrder.DerUpdatable); return this; } }
        public IdoPurchaseOrderBuilder DistDate { get { AddProperty(IdoPurchaseOrder.DistDate); return this; } }
        public IdoPurchaseOrderBuilder DropSeq { get { AddProperty(IdoPurchaseOrder.DropSeq); return this; } }
        public IdoPurchaseOrderBuilder DropShipNo { get { AddProperty(IdoPurchaseOrder.DropShipNo); return this; } }
        public IdoPurchaseOrderBuilder DutyAllocMeth { get { AddProperty(IdoPurchaseOrder.DutyAllocMeth); return this; } }
        public IdoPurchaseOrderBuilder DutyAllocPercent { get { AddProperty(IdoPurchaseOrder.DutyAllocPercent); return this; } }
        public IdoPurchaseOrderBuilder DutyAllocType { get { AddProperty(IdoPurchaseOrder.DutyAllocType); return this; } }
        public IdoPurchaseOrderBuilder DutyAmt { get { AddProperty(IdoPurchaseOrder.DutyAmt); return this; } }
        public IdoPurchaseOrderBuilder DutyAmtT { get { AddProperty(IdoPurchaseOrder.DutyAmtT); return this; } }
        public IdoPurchaseOrderBuilder DutyVendCurrCode { get { AddProperty(IdoPurchaseOrder.DutyVendCurrCode); return this; } }
        public IdoPurchaseOrderBuilder DutyVendName { get { AddProperty(IdoPurchaseOrder.DutyVendName); return this; } }
        public IdoPurchaseOrderBuilder DutyVendNum { get { AddProperty(IdoPurchaseOrder.DutyVendNum); return this; } }
        public IdoPurchaseOrderBuilder EffDate { get { AddProperty(IdoPurchaseOrder.EffDate); return this; } }
        public IdoPurchaseOrderBuilder EstBrokerage { get { AddProperty(IdoPurchaseOrder.EstBrokerage); return this; } }
        public IdoPurchaseOrderBuilder EstDuty { get { AddProperty(IdoPurchaseOrder.EstDuty); return this; } }
        public IdoPurchaseOrderBuilder EstFreight { get { AddProperty(IdoPurchaseOrder.EstFreight); return this; } }
        public IdoPurchaseOrderBuilder EstInsurance { get { AddProperty(IdoPurchaseOrder.EstInsurance); return this; } }
        public IdoPurchaseOrderBuilder EstLocalFreight { get { AddProperty(IdoPurchaseOrder.EstLocalFreight); return this; } }
        public IdoPurchaseOrderBuilder ExchRate { get { AddProperty(IdoPurchaseOrder.ExchRate); return this; } }
        public IdoPurchaseOrderBuilder ExpDate { get { AddProperty(IdoPurchaseOrder.ExpDate); return this; } }
        public IdoPurchaseOrderBuilder FixedRate { get { AddProperty(IdoPurchaseOrder.FixedRate); return this; } }
        public IdoPurchaseOrderBuilder FlagChangeStat { get { AddProperty(IdoPurchaseOrder.FlagChangeStat); return this; } }
        public IdoPurchaseOrderBuilder FlagPochange { get { AddProperty(IdoPurchaseOrder.FlagPochange); return this; } }
        public IdoPurchaseOrderBuilder Fob { get { AddProperty(IdoPurchaseOrder.Fob); return this; } }
        public IdoPurchaseOrderBuilder FormatedShipToAddress { get { AddProperty(IdoPurchaseOrder.FormatedShipToAddress); return this; } }
        public IdoPurchaseOrderBuilder FormatedVendAddress { get { AddProperty(IdoPurchaseOrder.FormatedVendAddress); return this; } }
        public IdoPurchaseOrderBuilder Freight { get { AddProperty(IdoPurchaseOrder.Freight); return this; } }
        public IdoPurchaseOrderBuilder FreightT { get { AddProperty(IdoPurchaseOrder.FreightT); return this; } }
        public IdoPurchaseOrderBuilder FreightVendName { get { AddProperty(IdoPurchaseOrder.FreightVendName); return this; } }
        public IdoPurchaseOrderBuilder FreightVendNum { get { AddProperty(IdoPurchaseOrder.FreightVendNum); return this; } }
        public IdoPurchaseOrderBuilder FrtAllocMeth { get { AddProperty(IdoPurchaseOrder.FrtAllocMeth); return this; } }
        public IdoPurchaseOrderBuilder FrtAllocPercent { get { AddProperty(IdoPurchaseOrder.FrtAllocPercent); return this; } }
        public IdoPurchaseOrderBuilder FrtAllocType { get { AddProperty(IdoPurchaseOrder.FrtAllocType); return this; } }
        public IdoPurchaseOrderBuilder FrtTaxCode1 { get { AddProperty(IdoPurchaseOrder.FrtTaxCode1); return this; } }
        public IdoPurchaseOrderBuilder FrtTaxCode2 { get { AddProperty(IdoPurchaseOrder.FrtTaxCode2); return this; } }
        public IdoPurchaseOrderBuilder FrtVendCurrCode { get { AddProperty(IdoPurchaseOrder.FrtVendCurrCode); return this; } }
        public IdoPurchaseOrderBuilder Ftx1Description { get { AddProperty(IdoPurchaseOrder.Ftx1Description); return this; } }
        public IdoPurchaseOrderBuilder Ftx2Description { get { AddProperty(IdoPurchaseOrder.Ftx2Description); return this; } }
        public IdoPurchaseOrderBuilder IncludeTaxInCost { get { AddProperty(IdoPurchaseOrder.IncludeTaxInCost); return this; } }
        public IdoPurchaseOrderBuilder InsAllocMeth { get { AddProperty(IdoPurchaseOrder.InsAllocMeth); return this; } }
        public IdoPurchaseOrderBuilder InsAllocPercent { get { AddProperty(IdoPurchaseOrder.InsAllocPercent); return this; } }
        public IdoPurchaseOrderBuilder InsAllocType { get { AddProperty(IdoPurchaseOrder.InsAllocType); return this; } }
        public IdoPurchaseOrderBuilder InsuranceAmt { get { AddProperty(IdoPurchaseOrder.InsuranceAmt); return this; } }
        public IdoPurchaseOrderBuilder InsuranceAmtT { get { AddProperty(IdoPurchaseOrder.InsuranceAmtT); return this; } }
        public IdoPurchaseOrderBuilder InsVendCurrCode { get { AddProperty(IdoPurchaseOrder.InsVendCurrCode); return this; } }
        public IdoPurchaseOrderBuilder InsVendName { get { AddProperty(IdoPurchaseOrder.InsVendName); return this; } }
        public IdoPurchaseOrderBuilder InsVendNum { get { AddProperty(IdoPurchaseOrder.InsVendNum); return this; } }
        public IdoPurchaseOrderBuilder InvDate { get { AddProperty(IdoPurchaseOrder.InvDate); return this; } }
        public IdoPurchaseOrderBuilder InvNum { get { AddProperty(IdoPurchaseOrder.InvNum); return this; } }
        public IdoPurchaseOrderBuilder InWorkflow { get { AddProperty(IdoPurchaseOrder.InWorkflow); return this; } }
        public IdoPurchaseOrderBuilder LocalFreightAmt { get { AddProperty(IdoPurchaseOrder.LocalFreightAmt); return this; } }
        public IdoPurchaseOrderBuilder LocalFreightAmtT { get { AddProperty(IdoPurchaseOrder.LocalFreightAmtT); return this; } }
        public IdoPurchaseOrderBuilder LocFrtAllocMeth { get { AddProperty(IdoPurchaseOrder.LocFrtAllocMeth); return this; } }
        public IdoPurchaseOrderBuilder LocFrtAllocPercent { get { AddProperty(IdoPurchaseOrder.LocFrtAllocPercent); return this; } }
        public IdoPurchaseOrderBuilder LocFrtAllocType { get { AddProperty(IdoPurchaseOrder.LocFrtAllocType); return this; } }
        public IdoPurchaseOrderBuilder LocFrtVendCurrCode { get { AddProperty(IdoPurchaseOrder.LocFrtVendCurrCode); return this; } }
        public IdoPurchaseOrderBuilder LocFrtVendName { get { AddProperty(IdoPurchaseOrder.LocFrtVendName); return this; } }
        public IdoPurchaseOrderBuilder LocFrtVendNum { get { AddProperty(IdoPurchaseOrder.LocFrtVendNum); return this; } }
        public IdoPurchaseOrderBuilder Logifld { get { AddProperty(IdoPurchaseOrder.Logifld); return this; } }
        public IdoPurchaseOrderBuilder MChargesT { get { AddProperty(IdoPurchaseOrder.MChargesT); return this; } }
        public IdoPurchaseOrderBuilder MiscCharges { get { AddProperty(IdoPurchaseOrder.MiscCharges); return this; } }
        public IdoPurchaseOrderBuilder Msc1Description { get { AddProperty(IdoPurchaseOrder.Msc1Description); return this; } }
        public IdoPurchaseOrderBuilder Msc2Description { get { AddProperty(IdoPurchaseOrder.Msc2Description); return this; } }
        public IdoPurchaseOrderBuilder MscTaxCode1 { get { AddProperty(IdoPurchaseOrder.MscTaxCode1); return this; } }
        public IdoPurchaseOrderBuilder MscTaxCode2 { get { AddProperty(IdoPurchaseOrder.MscTaxCode2); return this; } }
        public IdoPurchaseOrderBuilder NoteExistsFlag { get { AddProperty(IdoPurchaseOrder.NoteExistsFlag); return this; } }
        public IdoPurchaseOrderBuilder OrderDate { get { AddProperty(IdoPurchaseOrder.OrderDate); return this; } }
        public IdoPurchaseOrderBuilder PchChgNum { get { AddProperty(IdoPurchaseOrder.PchChgNum); return this; } }
        public IdoPurchaseOrderBuilder PchStat { get { AddProperty(IdoPurchaseOrder.PchStat); return this; } }
        public IdoPurchaseOrderBuilder PoCost { get { AddProperty(IdoPurchaseOrder.PoCost); return this; } }
        public IdoPurchaseOrderBuilder PoNum { get { AddProperty(IdoPurchaseOrder.PoNum); return this; } }
        public IdoPurchaseOrderBuilder PoparAmendPo { get { AddProperty(IdoPurchaseOrder.PoparAmendPo); return this; } }
        public IdoPurchaseOrderBuilder PoparPoChange { get { AddProperty(IdoPurchaseOrder.PoparPoChange); return this; } }
        public IdoPurchaseOrderBuilder PoparVendorRequired { get { AddProperty(IdoPurchaseOrder.PoparVendorRequired); return this; } }
        public IdoPurchaseOrderBuilder PrepaidAmt { get { AddProperty(IdoPurchaseOrder.PrepaidAmt); return this; } }
        public IdoPurchaseOrderBuilder PrepaidT { get { AddProperty(IdoPurchaseOrder.PrepaidT); return this; } }
        public IdoPurchaseOrderBuilder PrintPrice { get { AddProperty(IdoPurchaseOrder.PrintPrice); return this; } }
        public IdoPurchaseOrderBuilder ProcessInd { get { AddProperty(IdoPurchaseOrder.ProcessInd); return this; } }
        public IdoPurchaseOrderBuilder Received { get { AddProperty(IdoPurchaseOrder.Received); return this; } }
        public IdoPurchaseOrderBuilder RecordDate { get { AddProperty(IdoPurchaseOrder.RecordDate); return this; } }
        public IdoPurchaseOrderBuilder ReqNum { get { AddProperty(IdoPurchaseOrder.ReqNum); return this; } }
        public IdoPurchaseOrderBuilder RowPointer { get { AddProperty(IdoPurchaseOrder.RowPointer); return this; } }
        public IdoPurchaseOrderBuilder SalesTax { get { AddProperty(IdoPurchaseOrder.SalesTax); return this; } }
        public IdoPurchaseOrderBuilder SalesTax2 { get { AddProperty(IdoPurchaseOrder.SalesTax2); return this; } }
        public IdoPurchaseOrderBuilder SalesTaxT { get { AddProperty(IdoPurchaseOrder.SalesTaxT); return this; } }
        public IdoPurchaseOrderBuilder SalesTaxT2 { get { AddProperty(IdoPurchaseOrder.SalesTaxT2); return this; } }
        public IdoPurchaseOrderBuilder ShipAddr { get { AddProperty(IdoPurchaseOrder.ShipAddr); return this; } }
        public IdoPurchaseOrderBuilder ShipCode { get { AddProperty(IdoPurchaseOrder.ShipCode); return this; } }
        public IdoPurchaseOrderBuilder ShipCodeDesc { get { AddProperty(IdoPurchaseOrder.ShipCodeDesc); return this; } }
        public IdoPurchaseOrderBuilder SLPochanges { get { AddProperty(IdoPurchaseOrder.SLPochanges); return this; } }
        public IdoPurchaseOrderBuilder Stat { get { AddProperty(IdoPurchaseOrder.Stat); return this; } }
        public IdoPurchaseOrderBuilder SupplyWebPoStat { get { AddProperty(IdoPurchaseOrder.SupplyWebPoStat); return this; } }
        public IdoPurchaseOrderBuilder SynchronizedToBus { get { AddProperty(IdoPurchaseOrder.SynchronizedToBus); return this; } }
        public IdoPurchaseOrderBuilder TaxCode1 { get { AddProperty(IdoPurchaseOrder.TaxCode1); return this; } }
        public IdoPurchaseOrderBuilder TaxCode2 { get { AddProperty(IdoPurchaseOrder.TaxCode2); return this; } }
        public IdoPurchaseOrderBuilder TermsCode { get { AddProperty(IdoPurchaseOrder.TermsCode); return this; } }
        public IdoPurchaseOrderBuilder TermsCodeDesc { get { AddProperty(IdoPurchaseOrder.TermsCodeDesc); return this; } }
        public IdoPurchaseOrderBuilder TransNat { get { AddProperty(IdoPurchaseOrder.TransNat); return this; } }
        public IdoPurchaseOrderBuilder TransNat2 { get { AddProperty(IdoPurchaseOrder.TransNat2); return this; } }
        public IdoPurchaseOrderBuilder TransNat2Desc { get { AddProperty(IdoPurchaseOrder.TransNat2Desc); return this; } }
        public IdoPurchaseOrderBuilder TransNatDesc { get { AddProperty(IdoPurchaseOrder.TransNatDesc); return this; } }
        public IdoPurchaseOrderBuilder Tx1Description { get { AddProperty(IdoPurchaseOrder.Tx1Description); return this; } }
        public IdoPurchaseOrderBuilder Tx2Description { get { AddProperty(IdoPurchaseOrder.Tx2Description); return this; } }
        public IdoPurchaseOrderBuilder Type { get { AddProperty(IdoPurchaseOrder.Type); return this; } }
        public IdoPurchaseOrderBuilder VenCurrCode { get { AddProperty(IdoPurchaseOrder.VenCurrCode); return this; } }
        public IdoPurchaseOrderBuilder VendCatDesc { get { AddProperty(IdoPurchaseOrder.VendCatDesc); return this; } }
        public IdoPurchaseOrderBuilder VendCategory { get { AddProperty(IdoPurchaseOrder.VendCategory); return this; } }
        public IdoPurchaseOrderBuilder VendContact { get { AddProperty(IdoPurchaseOrder.VendContact); return this; } }
        public IdoPurchaseOrderBuilder VendCountry { get { AddProperty(IdoPurchaseOrder.VendCountry); return this; } }
        public IdoPurchaseOrderBuilder VendFaxNum { get { AddProperty(IdoPurchaseOrder.VendFaxNum); return this; } }
        public IdoPurchaseOrderBuilder VendLcrNum { get { AddProperty(IdoPurchaseOrder.VendLcrNum); return this; } }
        public IdoPurchaseOrderBuilder VendNum { get { AddProperty(IdoPurchaseOrder.VendNum); return this; } }
        public IdoPurchaseOrderBuilder VendOrder { get { AddProperty(IdoPurchaseOrder.VendOrder); return this; } }
        public IdoPurchaseOrderBuilder VendorName { get { AddProperty(IdoPurchaseOrder.VendorName); return this; } }
        public IdoPurchaseOrderBuilder VendPhone { get { AddProperty(IdoPurchaseOrder.VendPhone); return this; } }
        public IdoPurchaseOrderBuilder VendTelexNum { get { AddProperty(IdoPurchaseOrder.VendTelexNum); return this; } }
        public IdoPurchaseOrderBuilder VendType { get { AddProperty(IdoPurchaseOrder.VendType); return this; } }
        public IdoPurchaseOrderBuilder VenLcrReqd { get { AddProperty(IdoPurchaseOrder.VenLcrReqd); return this; } }
        public IdoPurchaseOrderBuilder Whse { get { AddProperty(IdoPurchaseOrder.Whse); return this; } }
        public IdoPurchaseOrderBuilder WhsName { get { AddProperty(IdoPurchaseOrder.WhsName); return this; } }


    }

    public class SLPosFilterExpressionBuilder
        : FilterExpressionBuilder<IdoPurchaseOrderBuilder>
    {
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ActBrokerage
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ActBrokerage); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ActDuty
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ActDuty); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ActFreight
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ActFreight); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ActInsurance
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ActInsurance); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ActLocalFreight
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ActLocalFreight); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> BrkAllocMeth
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.BrkAllocMeth); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> BrkAllocPercent
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.BrkAllocPercent); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> BrkAllocType
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.BrkAllocType); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> BrkVendCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.BrkVendCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> BrokerageAmt
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.BrokerageAmt); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> BrokerageAmtT
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.BrokerageAmtT); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> BrokerageVendName
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.BrokerageVendName); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> BrokerageVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.BrokerageVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> BuilderPoNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.BuilderPoNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> BuilderPoOrigSite
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.BuilderPoOrigSite); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> BuilderPoPrinted
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.BuilderPoPrinted); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Buyer
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Buyer); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Charfld1
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Charfld1); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Charfld2
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Charfld2); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Charfld3
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Charfld3); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ContainsOnlyTaxFreeMatls
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ContainsOnlyTaxFreeMatls); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> CurrAmtFormat
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.CurrAmtFormat); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> CurrAmtTotFormat
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.CurrAmtTotFormat); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> CurrCstPrcFormat
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.CurrCstPrcFormat); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Datefld
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Datefld); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Decifld1
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Decifld1); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Decifld2
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Decifld2); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Decifld3
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Decifld3); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Delterm
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Delterm); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DelTermDescription
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DelTermDescription); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerASPSearch
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerASPSearch); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerExistsLine
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerExistsLine); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerExistsPoBln
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerExistsPoBln); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerHasXref
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerHasXref); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerIsFixed
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerIsFixed); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerMessage
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerMessage); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerNewStat
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerNewStat); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerNULLValue
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerNULLValue); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerOldStat
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerOldStat); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerOldVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerOldVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerPchChgNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerPchChgNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerPchStat
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerPchStat); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerPoNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerPoNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerStatFormatted
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerStatFormatted); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DerUpdatable
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DerUpdatable); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DistDate
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DistDate); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DropSeq
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DropSeq); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DropShipNo
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DropShipNo); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DutyAllocMeth
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DutyAllocMeth); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DutyAllocPercent
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DutyAllocPercent); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DutyAllocType
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DutyAllocType); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DutyAmt
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DutyAmt); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DutyAmtT
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DutyAmtT); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DutyVendCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DutyVendCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DutyVendName
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DutyVendName); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> DutyVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.DutyVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> EffDate
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.EffDate); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> EstBrokerage
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.EstBrokerage); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> EstDuty
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.EstDuty); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> EstFreight
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.EstFreight); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> EstInsurance
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.EstInsurance); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> EstLocalFreight
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.EstLocalFreight); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ExchRate
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ExchRate); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ExpDate
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ExpDate); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FixedRate
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FixedRate); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FlagChangeStat
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FlagChangeStat); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FlagPochange
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FlagPochange); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Fob
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Fob); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FormatedShipToAddress
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FormatedShipToAddress); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FormatedVendAddress
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FormatedVendAddress); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Freight
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Freight); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FreightT
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FreightT); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FreightVendName
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FreightVendName); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FreightVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FreightVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FrtAllocMeth
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FrtAllocMeth); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FrtAllocPercent
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FrtAllocPercent); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FrtAllocType
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FrtAllocType); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FrtTaxCode1
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FrtTaxCode1); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FrtTaxCode2
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FrtTaxCode2); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> FrtVendCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.FrtVendCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Ftx1Description
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Ftx1Description); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Ftx2Description
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Ftx2Description); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> IncludeTaxInCost
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.IncludeTaxInCost); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> InsAllocMeth
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.InsAllocMeth); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> InsAllocPercent
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.InsAllocPercent); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> InsAllocType
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.InsAllocType); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> InsuranceAmt
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.InsuranceAmt); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> InsuranceAmtT
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.InsuranceAmtT); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> InsVendCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.InsVendCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> InsVendName
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.InsVendName); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> InsVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.InsVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> InvDate
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.InvDate); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> InvNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.InvNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.InWorkflow); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> LocalFreightAmt
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.LocalFreightAmt); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> LocalFreightAmtT
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.LocalFreightAmtT); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> LocFrtAllocMeth
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.LocFrtAllocMeth); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> LocFrtAllocPercent
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.LocFrtAllocPercent); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> LocFrtAllocType
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.LocFrtAllocType); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> LocFrtVendCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.LocFrtVendCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> LocFrtVendName
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.LocFrtVendName); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> LocFrtVendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.LocFrtVendNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Logifld
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Logifld); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> MChargesT
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.MChargesT); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> MiscCharges
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.MiscCharges); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Msc1Description
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Msc1Description); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Msc2Description
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Msc2Description); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> MscTaxCode1
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.MscTaxCode1); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> MscTaxCode2
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.MscTaxCode2); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.NoteExistsFlag); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> OrderDate
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.OrderDate); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> PchChgNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.PchChgNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> PchStat
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.PchStat); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> PoCost
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.PoCost); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> PoNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.PoNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> PoparAmendPo
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.PoparAmendPo); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> PoparPoChange
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.PoparPoChange); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> PoparVendorRequired
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.PoparVendorRequired); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> PrepaidAmt
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.PrepaidAmt); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> PrepaidT
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.PrepaidT); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> PrintPrice
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.PrintPrice); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ProcessInd
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ProcessInd); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Received
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Received); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.RecordDate); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ReqNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ReqNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.RowPointer); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> SalesTax
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.SalesTax); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> SalesTax2
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.SalesTax2); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> SalesTaxT
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.SalesTaxT); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> SalesTaxT2
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.SalesTaxT2); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ShipAddr
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ShipAddr); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ShipCode
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ShipCode); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> ShipCodeDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.ShipCodeDesc); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> SLPochanges
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.SLPochanges); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Stat
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Stat); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> SupplyWebPoStat
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.SupplyWebPoStat); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> SynchronizedToBus
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.SynchronizedToBus); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> TaxCode1
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.TaxCode1); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> TaxCode2
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.TaxCode2); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> TermsCode
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.TermsCode); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> TermsCodeDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.TermsCodeDesc); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> TransNat
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.TransNat); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> TransNat2
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.TransNat2); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> TransNat2Desc
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.TransNat2Desc); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> TransNatDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.TransNatDesc); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Tx1Description
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Tx1Description); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Tx2Description
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Tx2Description); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Type
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Type); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VenCurrCode
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VenCurrCode); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendCatDesc
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendCatDesc); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendCategory
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendCategory); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendContact
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendContact); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendCountry
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendCountry); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendFaxNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendFaxNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendLcrNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendLcrNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendOrder
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendOrder); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendorName
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendorName); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendPhone
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendPhone); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendTelexNum
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendTelexNum); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VendType
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VendType); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> VenLcrReqd
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.VenLcrReqd); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> Whse
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.Whse); }
        }
        public FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder> WhsName
        {
            get { return new FilterExpression<IdoPurchaseOrderBuilder, SLPosFilterExpressionBuilder>(_builder, IdoPurchaseOrder.WhsName); }
        }


    }
}
