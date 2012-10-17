using System;

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class Items : IdoConstants
    {
        public const string IDO_NAME = "SLItems";
        public const string AbcCode = "AbcCode";
        public const string AcceptReq = "AcceptReq";
        public const string ActiveForDataIntegration = "ActiveForDataIntegration";
        public const string AltItem = "AltItem";
        public const string AsmFixed = "AsmFixed";
        public const string AsmFixture = "AsmFixture";
        public const string AsmMatl = "AsmMatl";
        public const string AsmOther = "AsmOther";
        public const string AsmOutside = "AsmOutside";
        public const string AsmRun = "AsmRun";
        public const string AsmSetup = "AsmSetup";
        public const string AsmTool = "AsmTool";
        public const string AsmVar = "AsmVar";
        public const string AutoJob = "AutoJob";
        public const string AvgFovhdCost = "AvgFovhdCost";
        public const string AvgLbrCost = "AvgLbrCost";
        public const string AvgMatlCost = "AvgMatlCost";
        public const string AvgOutCost = "AvgOutCost";
        public const string AvgUCost = "AvgUCost";
        public const string AvgVovhdCost = "AvgVovhdCost";
        public const string Backflush = "Backflush";
        public const string BflushLoc = "BflushLoc";
        public const string Buyer = "Buyer";
        public const string CfgModel = "CfgModel";
        public const string ChangeDate = "ChangeDate";
        public const string Charfld1 = "Charfld1";
        public const string Charfld2 = "Charfld2";
        public const string Charfld3 = "Charfld3";
        public const string Charfld4 = "Charfld4";
        public const string ChgDate = "ChgDate";
        public const string CntryCountry = "CntryCountry";
        public const string CommodityCode = "CommCode";
        public const string CommCodeDescription = "CommCodeDescription";
        public const string CompFixed = "CompFixed";
        public const string CompFixture = "CompFixture";
        public const string CompMatl = "CompMatl";
        public const string CompOther = "CompOther";
        public const string CompOutside = "CompOutside";
        public const string CompRun = "CompRun";
        public const string CompSetup = "CompSetup";
        public const string CompTool = "CompTool";
        public const string CompVar = "CompVar";
        public const string ControlledByExternalIcs = "ControlledByExternalIcs";
        public const string CoPostConfig = "CoPostConfig";
        public const string CostMethod = "CostMethod";
        public const string CostType = "CostType";
        public const string CurBrokerageCost = "CurBrokerageCost";
        public const string CurDutyCost = "CurDutyCost";
        public const string CurFovhdCost = "CurFovhdCost";
        public const string CurFreightCost = "CurFreightCost";
        public const string CurInsuranceCost = "CurInsuranceCost";
        public const string CurLbrCost = "CurLbrCost";
        public const string CurLocFrtCost = "CurLocFrtCost";
        public const string CurMatCost = "CurMatCost";
        public const string CurMatlCost = "CurMatlCost";
        public const string CurOutCost = "CurOutCost";
        public const string CurUCost = "CurUCost";
        public const string CurVovhdCost = "CurVovhdCost";
        public const string Datefld = "Datefld";
        public const string DaysSupply = "DaysSupply";
        public const string Decifld1 = "Decifld1";
        public const string Decifld2 = "Decifld2";
        public const string Decifld3 = "Decifld3";
        public const string DerAccumValue = "DerAccumValue";
        public const string DerBOMExist = "DerBOMExist";
        public const string DerCanChangeKit = "DerCanChangeKit";
        public const string DerCanChangeKit1 = "DerCanChangeKit1";
        public const string DerCanChangeKit2 = "DerCanChangeKit2";
        public const string DerCanChangeRev = "DerCanChangeRev";
        public const string DerCanLotSerial = "DerCanLotSerial";
        public const string DerCanPromptCost1 = "DerCanPromptCost1";
        public const string DerCanPromptCost2 = "DerCanPromptCost2";
        public const string DerCanUpdateCosts = "DerCanUpdateCosts";
        public const string DerCanUpdateCur = "DerCanUpdateCur";
        public const string DerChangePosted = "DerChangePosted";
        public const string DerCumPct = "DerCumPct";
        public const string DerDisplayUnitCosts = "DerDisplayUnitCosts";
        public const string DerEcnTracked = "DerEcnTracked";
        public const string DerFrzAsmSubtotal = "DerFrzAsmSubtotal";
        public const string DerFrzAsmTotal = "DerFrzAsmTotal";
        public const string DerFrzCompTotal = "DerFrzCompTotal";
        public const string DerFrzcostExist = "DerFrzcostExist";
        public const string DerHasRsvdInv = "DerHasRsvdInv";
        public const string DerItemPct = "DerItemPct";
        public const string DerItmAsmSubtotal = "DerItmAsmSubtotal";
        public const string DerItmAsmTotal = "DerItmAsmTotal";
        public const string DerItmCompTotal = "DerItmCompTotal";
        public const string DerMatCurCost = "DerMatCurCost";
        public const string DerMessage = "DerMessage";
        public const string DerNewAbcCode = "DerNewAbcCode";
        public const string DerNewStat = "DerNewStat";
        public const string DerNonNettableStock = "DerNonNettableStock";
        public const string DerNotRsvdOnHand = "DerNotRsvdOnHand";
        public const string DerPurCurCost = "DerPurCurCost";
        public const string DerQtyAllocCo = "DerQtyAllocCo";
        public const string DerQtyOnHand = "DerQtyOnHand";
        public const string DerQtyOrdered = "DerQtyOrdered";
        public const string DerQtyPurYtd = "DerQtyPurYtd";
        public const string DerQtyReorder = "DerQtyReorder";
        public const string DerQtyRsvdCo = "DerQtyRsvdCo";
        public const string DerQtySoldYtd = "DerQtySoldYtd";
        public const string DerQtyWip = "DerQtyWip";
        public const string DerRecursive = "DerRecursive";
        public const string DerRefType = "DerRefType";
        public const string DerSafetyStock = "DerSafetyStock";
        public const string DerSSDate = "DerSSDate";
        public const string DerTotCost = "DerTotCost";
        public const string DerVariance = "DerVariance";
        public const string Description = "Description";
        public const string DockTime = "DockTime";
        public const string DrawingNbr = "DrawingNbr";
        public const string DuePeriod = "DuePeriod";
        public const string EarliestPlannedPoReceipt = "EarliestPlannedPoReceipt";
        public const string ExpLeadTime = "ExpLeadTime";
        public const string ProductCategory = "FamilyCode";
        public const string FamilyCode = "FamilyCode";
        public const string FeatStr = "FeatStr";
        public const string FeatTempl = "FeatTempl";
        public const string FeatType = "FeatType";
        public const string FixedOrderQty = "FixedOrderQty";
        public const string FovhdCost = "FovhdCost";
        public const string FrzAsmFixed = "FrzAsmFixed";
        public const string FrzAsmFixture = "FrzAsmFixture";
        public const string FrzAsmMatl = "FrzAsmMatl";
        public const string FrzAsmOther = "FrzAsmOther";
        public const string FrzAsmOutside = "FrzAsmOutside";
        public const string FrzAsmRun = "FrzAsmRun";
        public const string FrzAsmSetup = "FrzAsmSetup";
        public const string FrzAsmTool = "FrzAsmTool";
        public const string FrzAsmVar = "FrzAsmVar";
        public const string FrzCompFixed = "FrzCompFixed";
        public const string FrzCompFixture = "FrzCompFixture";
        public const string FrzCompMatl = "FrzCompMatl";
        public const string FrzCompOther = "FrzCompOther";
        public const string FrzCompOutside = "FrzCompOutside";
        public const string FrzCompRun = "FrzCompRun";
        public const string FrzCompSetup = "FrzCompSetup";
        public const string FrzCompTool = "FrzCompTool";
        public const string FrzCompVar = "FrzCompVar";
        public const string FrzFreezeDate = "FrzFreezeDate";
        public const string FrzSubMatl = "FrzSubMatl";
        public const string IncludeInNetChangePlanning = "IncludeInNetChangePlanning";
        public const string InfinitePart = "InfinitePart";
        public const string InWorkflow = "InWorkflow";
        public const string IssueBy = "IssueBy";
        public const string Item = "Item";
        public const string ItemChangeDate = "ItemChangeDate";
        public const string Job = "Job";
        public const string JobConfigurable = "JobConfigurable";
        public const string JobPostConfig = "JobPostConfig";
        public const string JobRollupDate = "JobRollupDate";
        public const string Kit = "Kit";
        public const string LastInv = "LastInv";
        public const string LbrCost = "LbrCost";
        public const string LeadTime = "LeadTime";
        public const string Logifld = "Logifld";
        public const string LotGenExp = "LotGenExp";
        public const string LotPrefix = "LotPrefix";
        public const string LotSize = "LotSize";
        public const string LotTracked = "LotTracked";
        public const string LowLevel = "LowLevel";
        public const string LstLotSize = "LstLotSize";
        public const string LstUCost = "LstUCost";
        public const string MatlCost = "MatlCost";
        public const string MatlType = "MatlType";
        public const string MfgSupplySwitchingActive = "MfgSupplySwitchingActive";
        public const string MpsFlag = "MpsFlag";
        public const string MpsPlanFence = "MpsPlanFence";
        public const string MrpPart = "MrpPart";
        public const string NextConfig = "NextConfig";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string OrderConfigurable = "OrderConfigurable";
        public const string OrderMax = "OrderMax";
        public const string OrderMin = "OrderMin";
        public const string OrderMultiple = "OrderMult";
        public const string Origin = "Origin";
        public const string OutCost = "OutCost";
        public const string PaperTime = "PaperTime";
        public const string ParmCurrCode = "ParmCurrCode";
        public const string PassReq = "PassReq";
        public const string PhantomFlag = "PhantomFlag";
        public const string PlanCode = "PlanCode";
        public const string PlanFlag = "PlanFlag";
        public const string PMTCode = "PMTCode";
        public const string PrintKitComponents = "PrintKitComponents";
        public const string PriUnitPrice1 = "PriUnitPrice1";
        public const string PriUnitPrice2 = "PriUnitPrice2";
        public const string PriUnitPrice3 = "PriUnitPrice3";
        public const string PriUnitPrice4 = "PriUnitPrice4";
        public const string PriUnitPrice5 = "PriUnitPrice5";
        public const string PriUnitPrice6 = "PriUnitPrice6";
        public const string ProdMix = "ProdMix";
        public const string ProdType = "ProdType";
        public const string ProductCode = "ProductCode";
        public const string QtyAllocjob = "QtyAllocjob";
        public const string QtyMfgYtd = "QtyMfgYtd";
        public const string QtyUsedYtd = "QtyUsedYtd";
        public const string RatePerDay = "RatePerDay";
        public const string RcvdOverPoQtyTolerance = "RcvdOverPoQtyTolerance";
        public const string RcvdUnderPoQtyTolerance = "RcvdUnderPoQtyTolerance";
        public const string ReasonCode = "ReasonCode";
        public const string RecordDate = "RecordDate";
        public const string ReorderPoint = "ReorderPoint";
        public const string Reservable = "Reservable";
        public const string ItemRevision = "Revision";
        public const string RowPointer = "RowPointer";
        public const string SafetyStockPercent = "SafetyStockPercent";
        public const string SerialLength = "SerialLength";
        public const string SerialPrefix = "SerialPrefix";
        public const string SerialTracked = "SerialTracked";
        public const string Setupgroup = "Setupgroup";
        public const string ShelfLife = "ShelfLife";
        public const string ShowInDropDownList = "ShowInDropDownList";
        public const string ShrinkFact = "ShrinkFact";
        public const string SLCfgUis = "SLCfgUis";
        public const string SLJobmatls = "SLJobmatls";
        public const string SLJobRoutes = "SLJobRoutes";
        public const string SLSupDems = "SLSupDems";
        public const string SSDATE = "SSDATE";
        public const string Status = "Stat";
        public const string StatusChgUserCode = "StatusChgUserCode";
        public const string Stocked = "Stocked";
        public const string SubMatl = "SubMatl";
        public const string ItemSuffix = "Suffix";
        public const string SupplySite = "SupplySite";
        public const string SupplyToleranceHrs = "SupplyToleranceHrs";
        public const string SupplyWhse = "SupplyWhse";
        public const string TariffClassification = "TariffClassification";
        public const string TaxCode1 = "TaxCode1";
        public const string TaxCode1Description = "TaxCode1Description";
        public const string TaxCode2 = "TaxCode2";
        public const string TaxCode2Description = "TaxCode2Description";
        public const string TaxFreeDays = "TaxFreeDays";
        public const string TaxFreeMatl = "TaxFreeMatl";
        public const string Taxsys1TaxMode = "Taxsys1TaxMode";
        public const string Taxsys2TaxMode = "Taxsys2TaxMode";
        public const string TimeFenceRule = "TimeFenceRule";
        public const string TimeFenceValue = "TimeFenceValue";
        public const string TrackEcn = "TrackEcn";
        public const string UbSelect = "UbSelect";
        public const string UBViewType = "UBViewType";
        public const string UoM = "UM";
        public const string UnitBrokerageCost = "UnitBrokerageCost";
        public const string UnitCost = "UnitCost";
        public const string UnitDutyCost = "UnitDutyCost";
        public const string UnitFreightCost = "UnitFreightCost";
        public const string UnitInsuranceCost = "UnitInsuranceCost";
        public const string UnitLocFrtCost = "UnitLocFrtCost";
        public const string UnitMatCost = "UnitMatCost";
        public const string UnitWeight = "UnitWeight";
        public const string UseReorderPoint = "UseReorderPoint";
        public const string UnitPrice = "UWsPrice";
        public const string VarExpLead = "VarExpLead";
        public const string VarLead = "VarLead";
        public const string VovhdCost = "VovhdCost";
        public const string WeightUnits = "WeightUnits";

        public static ItemsBuilder GetFullProjection()
        {
            return FromSyteline.Items.Item.OrderMultiple.UnitWeight.Description.UnitCost.UoM.UnitPrice.DaysSupply.RowPointer.ItemRevision.ItemSuffix.Job;
        }

    }

    public class ItemsBuilder :
        IdoQueryBuilder<ItemsBuilder,ItemsFilterExpressionBuilder>
    {
        public ItemsBuilder(IExpressionInterpreter ei) : base(Items.IDO_NAME, ei) { }
        public ItemsBuilder ProductCategory { get { AddProperty(Items.ProductCategory); return this; } }
        public ItemsBuilder Item { get { AddProperty(Items.Item); return this; } }
        public ItemsBuilder OrderMultiple { get { AddProperty(Items.OrderMultiple); return this; } }
        public ItemsBuilder FamilyCode { get { AddProperty(Items.FamilyCode); return this; } }
        public ItemsBuilder DaysSupply { get { AddProperty(Items.DaysSupply); return this; } }
        public ItemsBuilder CostType { get { AddProperty(Items.CostType); return this; } }
        public ItemsBuilder LowLevel { get { AddProperty(Items.LowLevel); return this; } }
        public ItemsBuilder CommodityCode { get { AddProperty(Items.CommodityCode); return this; } }
        public ItemsBuilder ChangeDate { get { AddProperty(Items.ChangeDate); return this; } }
        public ItemsBuilder Status
        {
            get { AddProperty(Items.Status); return this; }
        }
        public ItemsBuilder UnitWeight
        {
            get { AddProperty(Items.UnitWeight); return this; }  
        }

        public ItemsBuilder UoM
        {
            get { AddProperty(Items.UoM);
                return this;  }
        }
        public ItemsBuilder UnitCost
        {
            get { AddProperty(Items.UnitCost); return this; }
        }

        public ItemsBuilder Description
        {
            get { AddProperty(Items.Description); return this; } 
        }


        public ItemsBuilder UnitPrice
        {
            get { AddProperty(Items.UnitPrice); return this; }
        }

        public ItemsBuilder ItemRevision
        {
            get { AddProperty(Items.ItemRevision); return this; }
        }

        public ItemsBuilder ItemSuffix
        {
            get { AddProperty(Items.ItemSuffix); return this; }
        }

        public ItemsBuilder Job
        {
            get { AddProperty(Items.Job); return this; }
        }


        public ItemsBuilder AbcCode { get { AddProperty(Items.AbcCode); return this; } }
        public ItemsBuilder AcceptReq { get { AddProperty(Items.AcceptReq); return this; } }
        public ItemsBuilder ActiveForDataIntegration { get { AddProperty(Items.ActiveForDataIntegration); return this; } }
        public ItemsBuilder AltItem { get { AddProperty(Items.AltItem); return this; } }
        public ItemsBuilder AsmFixed { get { AddProperty(Items.AsmFixed); return this; } }
        public ItemsBuilder AsmFixture { get { AddProperty(Items.AsmFixture); return this; } }
        public ItemsBuilder AsmMatl { get { AddProperty(Items.AsmMatl); return this; } }
        public ItemsBuilder AsmOther { get { AddProperty(Items.AsmOther); return this; } }
        public ItemsBuilder AsmOutside { get { AddProperty(Items.AsmOutside); return this; } }
        public ItemsBuilder AsmRun { get { AddProperty(Items.AsmRun); return this; } }
        public ItemsBuilder AsmSetup { get { AddProperty(Items.AsmSetup); return this; } }
        public ItemsBuilder AsmTool { get { AddProperty(Items.AsmTool); return this; } }
        public ItemsBuilder AsmVar { get { AddProperty(Items.AsmVar); return this; } }
        public ItemsBuilder AutoJob { get { AddProperty(Items.AutoJob); return this; } }
        public ItemsBuilder AvgFovhdCost { get { AddProperty(Items.AvgFovhdCost); return this; } }
        public ItemsBuilder AvgLbrCost { get { AddProperty(Items.AvgLbrCost); return this; } }
        public ItemsBuilder AvgMatlCost { get { AddProperty(Items.AvgMatlCost); return this; } }
        public ItemsBuilder AvgOutCost { get { AddProperty(Items.AvgOutCost); return this; } }
        public ItemsBuilder AvgUCost { get { AddProperty(Items.AvgUCost); return this; } }
        public ItemsBuilder AvgVovhdCost { get { AddProperty(Items.AvgVovhdCost); return this; } }
        public ItemsBuilder Backflush { get { AddProperty(Items.Backflush); return this; } }
        public ItemsBuilder BflushLoc { get { AddProperty(Items.BflushLoc); return this; } }
        public ItemsBuilder Buyer { get { AddProperty(Items.Buyer); return this; } }
        public ItemsBuilder CfgModel { get { AddProperty(Items.CfgModel); return this; } } 
        public ItemsBuilder Charfld1 { get { AddProperty(Items.Charfld1); return this; } }
        public ItemsBuilder Charfld2 { get { AddProperty(Items.Charfld2); return this; } }
        public ItemsBuilder Charfld3 { get { AddProperty(Items.Charfld3); return this; } }
        public ItemsBuilder Charfld4 { get { AddProperty(Items.Charfld4); return this; } }
        public ItemsBuilder ChgDate { get { AddProperty(Items.ChgDate); return this; } }
        public ItemsBuilder CntryCountry { get { AddProperty(Items.CntryCountry); return this; } } 
        public ItemsBuilder CommCodeDescription { get { AddProperty(Items.CommCodeDescription); return this; } }
        public ItemsBuilder CompFixed { get { AddProperty(Items.CompFixed); return this; } }
        public ItemsBuilder CompFixture { get { AddProperty(Items.CompFixture); return this; } }
        public ItemsBuilder CompMatl { get { AddProperty(Items.CompMatl); return this; } }
        public ItemsBuilder CompOther { get { AddProperty(Items.CompOther); return this; } }
        public ItemsBuilder CompOutside { get { AddProperty(Items.CompOutside); return this; } }
        public ItemsBuilder CompRun { get { AddProperty(Items.CompRun); return this; } }
        public ItemsBuilder CompSetup { get { AddProperty(Items.CompSetup); return this; } }
        public ItemsBuilder CompTool { get { AddProperty(Items.CompTool); return this; } }
        public ItemsBuilder CompVar { get { AddProperty(Items.CompVar); return this; } }
        public ItemsBuilder ControlledByExternalIcs { get { AddProperty(Items.ControlledByExternalIcs); return this; } }
        public ItemsBuilder CoPostConfig { get { AddProperty(Items.CoPostConfig); return this; } }
        public ItemsBuilder CostMethod { get { AddProperty(Items.CostMethod); return this; } } 
        public ItemsBuilder CurBrokerageCost { get { AddProperty(Items.CurBrokerageCost); return this; } }
        public ItemsBuilder CurDutyCost { get { AddProperty(Items.CurDutyCost); return this; } }
        public ItemsBuilder CurFovhdCost { get { AddProperty(Items.CurFovhdCost); return this; } }
        public ItemsBuilder CurFreightCost { get { AddProperty(Items.CurFreightCost); return this; } }
        public ItemsBuilder CurInsuranceCost { get { AddProperty(Items.CurInsuranceCost); return this; } }
        public ItemsBuilder CurLbrCost { get { AddProperty(Items.CurLbrCost); return this; } }
        public ItemsBuilder CurLocFrtCost { get { AddProperty(Items.CurLocFrtCost); return this; } }
        public ItemsBuilder CurMatCost { get { AddProperty(Items.CurMatCost); return this; } }
        public ItemsBuilder CurMatlCost { get { AddProperty(Items.CurMatlCost); return this; } }
        public ItemsBuilder CurOutCost { get { AddProperty(Items.CurOutCost); return this; } }
        public ItemsBuilder CurUCost { get { AddProperty(Items.CurUCost); return this; } }
        public ItemsBuilder CurVovhdCost { get { AddProperty(Items.CurVovhdCost); return this; } }
        public ItemsBuilder Datefld { get { AddProperty(Items.Datefld); return this; } } 
        public ItemsBuilder Decifld1 { get { AddProperty(Items.Decifld1); return this; } }
        public ItemsBuilder Decifld2 { get { AddProperty(Items.Decifld2); return this; } }
        public ItemsBuilder Decifld3 { get { AddProperty(Items.Decifld3); return this; } }
        public ItemsBuilder DerAccumValue { get { AddProperty(Items.DerAccumValue); return this; } }
        public ItemsBuilder DerBOMExist { get { AddProperty(Items.DerBOMExist); return this; } }
        public ItemsBuilder DerCanChangeKit { get { AddProperty(Items.DerCanChangeKit); return this; } }
        public ItemsBuilder DerCanChangeKit1 { get { AddProperty(Items.DerCanChangeKit1); return this; } }
        public ItemsBuilder DerCanChangeKit2 { get { AddProperty(Items.DerCanChangeKit2); return this; } }
        public ItemsBuilder DerCanChangeRev { get { AddProperty(Items.DerCanChangeRev); return this; } }
        public ItemsBuilder DerCanLotSerial { get { AddProperty(Items.DerCanLotSerial); return this; } }
        public ItemsBuilder DerCanPromptCost1 { get { AddProperty(Items.DerCanPromptCost1); return this; } }
        public ItemsBuilder DerCanPromptCost2 { get { AddProperty(Items.DerCanPromptCost2); return this; } }
        public ItemsBuilder DerCanUpdateCosts { get { AddProperty(Items.DerCanUpdateCosts); return this; } }
        public ItemsBuilder DerCanUpdateCur { get { AddProperty(Items.DerCanUpdateCur); return this; } }
        public ItemsBuilder DerChangePosted { get { AddProperty(Items.DerChangePosted); return this; } }
        public ItemsBuilder DerCumPct { get { AddProperty(Items.DerCumPct); return this; } }
        public ItemsBuilder DerDisplayUnitCosts { get { AddProperty(Items.DerDisplayUnitCosts); return this; } }
        public ItemsBuilder DerEcnTracked { get { AddProperty(Items.DerEcnTracked); return this; } }
        public ItemsBuilder DerFrzAsmSubtotal { get { AddProperty(Items.DerFrzAsmSubtotal); return this; } }
        public ItemsBuilder DerFrzAsmTotal { get { AddProperty(Items.DerFrzAsmTotal); return this; } }
        public ItemsBuilder DerFrzCompTotal { get { AddProperty(Items.DerFrzCompTotal); return this; } }
        public ItemsBuilder DerFrzcostExist { get { AddProperty(Items.DerFrzcostExist); return this; } }
        public ItemsBuilder DerHasRsvdInv { get { AddProperty(Items.DerHasRsvdInv); return this; } }
        public ItemsBuilder DerItemPct { get { AddProperty(Items.DerItemPct); return this; } }
        public ItemsBuilder DerItmAsmSubtotal { get { AddProperty(Items.DerItmAsmSubtotal); return this; } }
        public ItemsBuilder DerItmAsmTotal { get { AddProperty(Items.DerItmAsmTotal); return this; } }
        public ItemsBuilder DerItmCompTotal { get { AddProperty(Items.DerItmCompTotal); return this; } }
        public ItemsBuilder DerMatCurCost { get { AddProperty(Items.DerMatCurCost); return this; } }
        public ItemsBuilder DerMessage { get { AddProperty(Items.DerMessage); return this; } }
        public ItemsBuilder DerNewAbcCode { get { AddProperty(Items.DerNewAbcCode); return this; } }
        public ItemsBuilder DerNewStat { get { AddProperty(Items.DerNewStat); return this; } }
        public ItemsBuilder DerNonNettableStock { get { AddProperty(Items.DerNonNettableStock); return this; } }
        public ItemsBuilder DerNotRsvdOnHand { get { AddProperty(Items.DerNotRsvdOnHand); return this; } }
        public ItemsBuilder DerPurCurCost { get { AddProperty(Items.DerPurCurCost); return this; } }
        public ItemsBuilder DerQtyAllocCo { get { AddProperty(Items.DerQtyAllocCo); return this; } }
        public ItemsBuilder DerQtyOnHand { get { AddProperty(Items.DerQtyOnHand); return this; } }
        public ItemsBuilder DerQtyOrdered { get { AddProperty(Items.DerQtyOrdered); return this; } }
        public ItemsBuilder DerQtyPurYtd { get { AddProperty(Items.DerQtyPurYtd); return this; } }
        public ItemsBuilder DerQtyReorder { get { AddProperty(Items.DerQtyReorder); return this; } }
        public ItemsBuilder DerQtyRsvdCo { get { AddProperty(Items.DerQtyRsvdCo); return this; } }
        public ItemsBuilder DerQtySoldYtd { get { AddProperty(Items.DerQtySoldYtd); return this; } }
        public ItemsBuilder DerQtyWip { get { AddProperty(Items.DerQtyWip); return this; } }
        public ItemsBuilder DerRecursive { get { AddProperty(Items.DerRecursive); return this; } }
        public ItemsBuilder DerRefType { get { AddProperty(Items.DerRefType); return this; } }
        public ItemsBuilder DerSafetyStock { get { AddProperty(Items.DerSafetyStock); return this; } }
        public ItemsBuilder DerSSDate { get { AddProperty(Items.DerSSDate); return this; } }
        public ItemsBuilder DerTotCost { get { AddProperty(Items.DerTotCost); return this; } }
        public ItemsBuilder DerVariance { get { AddProperty(Items.DerVariance); return this; } } 
        public ItemsBuilder DockTime { get { AddProperty(Items.DockTime); return this; } }
        public ItemsBuilder DrawingNbr { get { AddProperty(Items.DrawingNbr); return this; } }
        public ItemsBuilder DuePeriod { get { AddProperty(Items.DuePeriod); return this; } }
        public ItemsBuilder EarliestPlannedPoReceipt { get { AddProperty(Items.EarliestPlannedPoReceipt); return this; } }
        public ItemsBuilder ExpLeadTime { get { AddProperty(Items.ExpLeadTime); return this; } } 
        public ItemsBuilder FeatStr { get { AddProperty(Items.FeatStr); return this; } }
        public ItemsBuilder FeatTempl { get { AddProperty(Items.FeatTempl); return this; } }
        public ItemsBuilder FeatType { get { AddProperty(Items.FeatType); return this; } }
        public ItemsBuilder FixedOrderQty { get { AddProperty(Items.FixedOrderQty); return this; } }
        public ItemsBuilder FovhdCost { get { AddProperty(Items.FovhdCost); return this; } }
        public ItemsBuilder FrzAsmFixed { get { AddProperty(Items.FrzAsmFixed); return this; } }
        public ItemsBuilder FrzAsmFixture { get { AddProperty(Items.FrzAsmFixture); return this; } }
        public ItemsBuilder FrzAsmMatl { get { AddProperty(Items.FrzAsmMatl); return this; } }
        public ItemsBuilder FrzAsmOther { get { AddProperty(Items.FrzAsmOther); return this; } }
        public ItemsBuilder FrzAsmOutside { get { AddProperty(Items.FrzAsmOutside); return this; } }
        public ItemsBuilder FrzAsmRun { get { AddProperty(Items.FrzAsmRun); return this; } }
        public ItemsBuilder FrzAsmSetup { get { AddProperty(Items.FrzAsmSetup); return this; } }
        public ItemsBuilder FrzAsmTool { get { AddProperty(Items.FrzAsmTool); return this; } }
        public ItemsBuilder FrzAsmVar { get { AddProperty(Items.FrzAsmVar); return this; } }
        public ItemsBuilder FrzCompFixed { get { AddProperty(Items.FrzCompFixed); return this; } }
        public ItemsBuilder FrzCompFixture { get { AddProperty(Items.FrzCompFixture); return this; } }
        public ItemsBuilder FrzCompMatl { get { AddProperty(Items.FrzCompMatl); return this; } }
        public ItemsBuilder FrzCompOther { get { AddProperty(Items.FrzCompOther); return this; } }
        public ItemsBuilder FrzCompOutside { get { AddProperty(Items.FrzCompOutside); return this; } }
        public ItemsBuilder FrzCompRun { get { AddProperty(Items.FrzCompRun); return this; } }
        public ItemsBuilder FrzCompSetup { get { AddProperty(Items.FrzCompSetup); return this; } }
        public ItemsBuilder FrzCompTool { get { AddProperty(Items.FrzCompTool); return this; } }
        public ItemsBuilder FrzCompVar { get { AddProperty(Items.FrzCompVar); return this; } }
        public ItemsBuilder FrzFreezeDate { get { AddProperty(Items.FrzFreezeDate); return this; } }
        public ItemsBuilder FrzSubMatl { get { AddProperty(Items.FrzSubMatl); return this; } }
        public ItemsBuilder IncludeInNetChangePlanning { get { AddProperty(Items.IncludeInNetChangePlanning); return this; } }
        public ItemsBuilder InfinitePart { get { AddProperty(Items.InfinitePart); return this; } }
        public ItemsBuilder InWorkflow { get { AddProperty(Items.InWorkflow); return this; } }
        public ItemsBuilder IssueBy { get { AddProperty(Items.IssueBy); return this; } } 
        public ItemsBuilder ItemChangeDate { get { AddProperty(Items.ItemChangeDate); return this; } } 
        public ItemsBuilder JobConfigurable { get { AddProperty(Items.JobConfigurable); return this; } }
        public ItemsBuilder JobPostConfig { get { AddProperty(Items.JobPostConfig); return this; } }
        public ItemsBuilder JobRollupDate { get { AddProperty(Items.JobRollupDate); return this; } }
        public ItemsBuilder Kit { get { AddProperty(Items.Kit); return this; } }
        public ItemsBuilder LastInv { get { AddProperty(Items.LastInv); return this; } }
        public ItemsBuilder LbrCost { get { AddProperty(Items.LbrCost); return this; } }
        public ItemsBuilder LeadTime { get { AddProperty(Items.LeadTime); return this; } }
        public ItemsBuilder Logifld { get { AddProperty(Items.Logifld); return this; } }
        public ItemsBuilder LotGenExp { get { AddProperty(Items.LotGenExp); return this; } }
        public ItemsBuilder LotPrefix { get { AddProperty(Items.LotPrefix); return this; } }
        public ItemsBuilder LotSize { get { AddProperty(Items.LotSize); return this; } }
        public ItemsBuilder LotTracked { get { AddProperty(Items.LotTracked); return this; } } 
        public ItemsBuilder LstLotSize { get { AddProperty(Items.LstLotSize); return this; } }
        public ItemsBuilder LstUCost { get { AddProperty(Items.LstUCost); return this; } }
        public ItemsBuilder MatlCost { get { AddProperty(Items.MatlCost); return this; } }
        public ItemsBuilder MatlType { get { AddProperty(Items.MatlType); return this; } }
        public ItemsBuilder MfgSupplySwitchingActive { get { AddProperty(Items.MfgSupplySwitchingActive); return this; } }
        public ItemsBuilder MpsFlag { get { AddProperty(Items.MpsFlag); return this; } }
        public ItemsBuilder MpsPlanFence { get { AddProperty(Items.MpsPlanFence); return this; } }
        public ItemsBuilder MrpPart { get { AddProperty(Items.MrpPart); return this; } }
        public ItemsBuilder NextConfig { get { AddProperty(Items.NextConfig); return this; } }
        public ItemsBuilder NoteExistsFlag { get { AddProperty(Items.NoteExistsFlag); return this; } }
        public ItemsBuilder OrderConfigurable { get { AddProperty(Items.OrderConfigurable); return this; } }
        public ItemsBuilder OrderMax { get { AddProperty(Items.OrderMax); return this; } }
        public ItemsBuilder OrderMin { get { AddProperty(Items.OrderMin); return this; } } 
        public ItemsBuilder Origin { get { AddProperty(Items.Origin); return this; } }
        public ItemsBuilder OutCost { get { AddProperty(Items.OutCost); return this; } }
        public ItemsBuilder PaperTime { get { AddProperty(Items.PaperTime); return this; } }
        public ItemsBuilder ParmCurrCode { get { AddProperty(Items.ParmCurrCode); return this; } }
        public ItemsBuilder PassReq { get { AddProperty(Items.PassReq); return this; } }
        public ItemsBuilder PhantomFlag { get { AddProperty(Items.PhantomFlag); return this; } }
        public ItemsBuilder PlanCode { get { AddProperty(Items.PlanCode); return this; } }
        public ItemsBuilder PlanFlag { get { AddProperty(Items.PlanFlag); return this; } }
        public ItemsBuilder PMTCode { get { AddProperty(Items.PMTCode); return this; } }
        public ItemsBuilder PrintKitComponents { get { AddProperty(Items.PrintKitComponents); return this; } }
        public ItemsBuilder PriUnitPrice1 { get { AddProperty(Items.PriUnitPrice1); return this; } }
        public ItemsBuilder PriUnitPrice2 { get { AddProperty(Items.PriUnitPrice2); return this; } }
        public ItemsBuilder PriUnitPrice3 { get { AddProperty(Items.PriUnitPrice3); return this; } }
        public ItemsBuilder PriUnitPrice4 { get { AddProperty(Items.PriUnitPrice4); return this; } }
        public ItemsBuilder PriUnitPrice5 { get { AddProperty(Items.PriUnitPrice5); return this; } }
        public ItemsBuilder PriUnitPrice6 { get { AddProperty(Items.PriUnitPrice6); return this; } }
        public ItemsBuilder ProdMix { get { AddProperty(Items.ProdMix); return this; } }
        public ItemsBuilder ProdType { get { AddProperty(Items.ProdType); return this; } }
        public ItemsBuilder ProductCode { get { AddProperty(Items.ProductCode); return this; } }
        public ItemsBuilder QtyAllocjob { get { AddProperty(Items.QtyAllocjob); return this; } }
        public ItemsBuilder QtyMfgYtd { get { AddProperty(Items.QtyMfgYtd); return this; } }
        public ItemsBuilder QtyUsedYtd { get { AddProperty(Items.QtyUsedYtd); return this; } }
        public ItemsBuilder RatePerDay { get { AddProperty(Items.RatePerDay); return this; } }
        public ItemsBuilder RcvdOverPoQtyTolerance { get { AddProperty(Items.RcvdOverPoQtyTolerance); return this; } }
        public ItemsBuilder RcvdUnderPoQtyTolerance { get { AddProperty(Items.RcvdUnderPoQtyTolerance); return this; } }
        public ItemsBuilder ReasonCode { get { AddProperty(Items.ReasonCode); return this; } }
        public ItemsBuilder RecordDate { get { AddProperty(Items.RecordDate); return this; } }
        public ItemsBuilder ReorderPoint { get { AddProperty(Items.ReorderPoint); return this; } }
        public ItemsBuilder Reservable { get { AddProperty(Items.Reservable); return this; } }  
        public ItemsBuilder SafetyStockPercent { get { AddProperty(Items.SafetyStockPercent); return this; } }
        public ItemsBuilder SerialLength { get { AddProperty(Items.SerialLength); return this; } }
        public ItemsBuilder SerialPrefix { get { AddProperty(Items.SerialPrefix); return this; } }
        public ItemsBuilder SerialTracked { get { AddProperty(Items.SerialTracked); return this; } }
        public ItemsBuilder Setupgroup { get { AddProperty(Items.Setupgroup); return this; } }
        public ItemsBuilder ShelfLife { get { AddProperty(Items.ShelfLife); return this; } }
        public ItemsBuilder ShowInDropDownList { get { AddProperty(Items.ShowInDropDownList); return this; } }
        public ItemsBuilder ShrinkFact { get { AddProperty(Items.ShrinkFact); return this; } }
        public ItemsBuilder SLCfgUis { get { AddProperty(Items.SLCfgUis); return this; } }
        public ItemsBuilder SLJobmatls { get { AddProperty(Items.SLJobmatls); return this; } }
        public ItemsBuilder SLJobRoutes { get { AddProperty(Items.SLJobRoutes); return this; } }
        public ItemsBuilder SLSupDems { get { AddProperty(Items.SLSupDems); return this; } }
        public ItemsBuilder SSDATE { get { AddProperty(Items.SSDATE); return this; } } 
        public ItemsBuilder StatusChgUserCode { get { AddProperty(Items.StatusChgUserCode); return this; } }
        public ItemsBuilder Stocked { get { AddProperty(Items.Stocked); return this; } }
        public ItemsBuilder SubMatl { get { AddProperty(Items.SubMatl); return this; } } 
        public ItemsBuilder SupplySite { get { AddProperty(Items.SupplySite); return this; } }
        public ItemsBuilder SupplyToleranceHrs { get { AddProperty(Items.SupplyToleranceHrs); return this; } }
        public ItemsBuilder SupplyWhse { get { AddProperty(Items.SupplyWhse); return this; } }
        public ItemsBuilder TariffClassification { get { AddProperty(Items.TariffClassification); return this; } }
        public ItemsBuilder TaxCode1 { get { AddProperty(Items.TaxCode1); return this; } }
        public ItemsBuilder TaxCode1Description { get { AddProperty(Items.TaxCode1Description); return this; } }
        public ItemsBuilder TaxCode2 { get { AddProperty(Items.TaxCode2); return this; } }
        public ItemsBuilder TaxCode2Description { get { AddProperty(Items.TaxCode2Description); return this; } }
        public ItemsBuilder TaxFreeDays { get { AddProperty(Items.TaxFreeDays); return this; } }
        public ItemsBuilder TaxFreeMatl { get { AddProperty(Items.TaxFreeMatl); return this; } }
        public ItemsBuilder Taxsys1TaxMode { get { AddProperty(Items.Taxsys1TaxMode); return this; } }
        public ItemsBuilder Taxsys2TaxMode { get { AddProperty(Items.Taxsys2TaxMode); return this; } }
        public ItemsBuilder TimeFenceRule { get { AddProperty(Items.TimeFenceRule); return this; } }
        public ItemsBuilder TimeFenceValue { get { AddProperty(Items.TimeFenceValue); return this; } }
        public ItemsBuilder TrackEcn { get { AddProperty(Items.TrackEcn); return this; } }
        public ItemsBuilder UbSelect { get { AddProperty(Items.UbSelect); return this; } }
        public ItemsBuilder UBViewType { get { AddProperty(Items.UBViewType); return this; } } 
        public ItemsBuilder UnitBrokerageCost { get { AddProperty(Items.UnitBrokerageCost); return this; } } 
        public ItemsBuilder UnitDutyCost { get { AddProperty(Items.UnitDutyCost); return this; } }
        public ItemsBuilder UnitFreightCost { get { AddProperty(Items.UnitFreightCost); return this; } }
        public ItemsBuilder UnitInsuranceCost { get { AddProperty(Items.UnitInsuranceCost); return this; } }
        public ItemsBuilder UnitLocFrtCost { get { AddProperty(Items.UnitLocFrtCost); return this; } }
        public ItemsBuilder UnitMatCost { get { AddProperty(Items.UnitMatCost); return this; } } 
        public ItemsBuilder UseReorderPoint { get { AddProperty(Items.UseReorderPoint); return this; } } 
        public ItemsBuilder VarExpLead { get { AddProperty(Items.VarExpLead); return this; } }
        public ItemsBuilder VarLead { get { AddProperty(Items.VarLead); return this; } }
        public ItemsBuilder VovhdCost { get { AddProperty(Items.VovhdCost); return this; } }
        public ItemsBuilder WeightUnits { get { AddProperty(Items.WeightUnits); return this; } } 

        public ItemsBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (ItemsBuilder) base.WithChildren(builders);
        }

        public ItemsBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (ItemsBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class ItemsFilterExpressionBuilder : FilterExpressionBuilder<ItemsBuilder>
    {
        public FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder> Item
        {
            get { return new FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder>(_builder, Items.Item); }
        }
        public FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder> OrderMultiple
        {
            get { return new FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder>(_builder, Items.OrderMultiple); }
        }

        public FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder> UnitCost
        {
            get { return new FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder>(_builder, Items.UnitCost); }
        }

        public FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder> UnitWeight
        {
            get { return new FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder>(_builder, Items.UnitWeight); }
        }

        public FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder> UoM
        {
            get { return new FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder>(_builder, Items.UoM); }
        }

        public FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder> DaysSupply
        {
            get { return new FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder>(_builder, Items.DaysSupply); }
        }

        public FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder> Job
        {
            get { return new FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder>(_builder, Items.Job); }
        }
        public FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder> ProductCategory
        {
            get { return new FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder>(_builder, Items.ProductCategory); }
        }
        public FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder> CommodityCode
        {
            get { return new FilterExpression<ItemsBuilder, ItemsFilterExpressionBuilder>(_builder, Items.CommodityCode); }
        }
    }
}