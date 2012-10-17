using SytelineInterface.Core; 

                namespace SytelineInterface.Dsl.Queries
                {
                    using Commands;

                    public class JobMaterials : IdoConstants 
                { 
                           public const string IDO_NAME = "SLJobmatls";
       public const string ACost = "ACost";
       public const string AFovhdCost = "AFovhdCost";
       public const string ALbrCost = "ALbrCost";
       public const string AltGroup = "AltGroup";
       public const string AltGroupRank = "AltGroupRank";
       public const string AMatlCost = "AMatlCost";
       public const string AOutCost = "AOutCost";
       public const string AVovhdCost = "AVovhdCost";
       public const string Backflush = "Backflush";
       public const string BflushLoc = "BflushLoc";
       public const string BomSeq = "BomSeq";
       public const string Cost = "Cost";
       public const string CostConv = "CostConv";
       public const string DerAltGroupRankText = "DerAltGroupRankText";
       public const string DerASPSearch = "DerASPSearch";
       public const string DerBflushLocRequired = "DerBflushLocRequired";
       public const string DerByProduct = "DerByProduct";
       public const string DerCostCode = "DerCostCode";
       public const string DerDelete = "DerDelete";
       public const string DerExtScrap = "DerExtScrap";
       public const string DerIsPSLbrPosted = "DerIsPSLbrPosted";
       public const string DerItemDescription = "DerItemDescription";
       public const string DerItemExist = "DerItemExist";
       public const string DerItemIssueBy = "DerItemIssueBy";
       public const string DerItemLotTracked = "DerItemLotTracked";
       public const string DerItemRowPointer = "DerItemRowPointer";
       public const string DerItemSerialTracked = "DerItemSerialTracked";
       public const string DerItemTaxFreeMatl = "DerItemTaxFreeMatl";
       public const string DerItemUM = "DerItemUM";
       public const string DerItemUMConvFactor = "DerItemUMConvFactor";
       public const string DerJobmatlRowPointer = "DerJobmatlRowPointer";
       public const string DerJobRowPointer = "DerJobRowPointer";
       public const string DerJobSuffix = "DerJobSuffix";
       public const string DerLevel = "DerLevel";
       public const string DerLoc = "DerLoc";
       public const string DerLot = "DerLot";
       public const string DerMatlExist = "DerMatlExist";
       public const string DerMatlLotTracked = "DerMatlLotTracked";
       public const string DerMatlQtyRequired = "DerMatlQtyRequired";
       public const string DerMatlSerialTracked = "DerMatlSerialTracked";
       public const string DerMatlSuffix = "DerMatlSuffix";
       public const string DerMatlTransQty = "DerMatlTransQty";
       public const string DerMessage = "DerMessage";
       public const string DerOrdType = "DerOrdType";
       public const string DerPlanCost = "DerPlanCost";
       public const string DerPlanCostConv = "DerPlanCostConv";
       public const string DerPMTCode = "DerPMTCode";
       public const string DerPoVendNum = "DerPoVendNum";
       public const string DerQty = "DerQty";
       public const string DerQtyConv = "DerQtyConv";
       public const string DerQtyIssuedConv = "DerQtyIssuedConv";
       public const string DerQtyOnHand = "DerQtyOnHand";
       public const string DerQtyOnHandConv = "DerQtyOnHandConv";
       public const string DerQtyPicked = "DerQtyPicked";
       public const string DerQtyToPick = "DerQtyToPick";
       public const string DerReqQty = "DerReqQty";
       public const string DerReqQtyConv = "DerReqQtyConv";
       public const string DerSelected = "DerSelected";
       public const string DerSequence = "DerSequence";
       public const string DerSerialPrefix = "DerSerialPrefix";
       public const string DerStartDate = "DerStartDate";
       public const string DerTransDate = "DerTransDate";
       public const string DerUM = "DerUM";
       public const string DerUOMConvFactor = "DerUOMConvFactor";
       public const string DerWC = "DerWC";
       public const string DerWhse = "DerWhse";
       public const string Description = "Description";
       public const string EffectDate = "EffectDate";
       public const string Feature = "Feature";
       public const string FixovhdT = "FixovhdT";
       public const string Fmatlovhd = "Fmatlovhd";
       public const string FovhdCost = "FovhdCost";
       public const string FovhdCostConv = "FovhdCostConv";
       public const string IncPrice = "IncPrice";
       public const string IncPriceConv = "IncPriceConv";
       public const string InWorkflow = "InWorkflow";
       public const string Item = "Item";
       public const string ItmDescription = "ItmDescription";
       public const string ItmEcnTracked = "ItmEcnTracked";
       public const string ItmFovhdCost = "ItmFovhdCost";
       public const string ItmIssueBy = "ItmIssueBy";
       public const string ItmItem = "ItmItem";
       public const string ItmLbrCost = "ItmLbrCost";
       public const string ItmLotTracked = "ItmLotTracked";
       public const string ItmLowLevel = "ItmLowLevel";
       public const string ItmMatlCost = "ItmMatlCost";
       public const string ItmOutCost = "ItmOutCost";
       public const string ItmPhantomFlag = "ItmPhantomFlag";
       public const string ItmPlanFlag = "ItmPlanFlag";
       public const string ItmPMTCode = "ItmPMTCode";
       public const string ItmProductCode = "ItmProductCode";
       public const string ItmRevision = "ItmRevision";
       public const string ItmSerialTracked = "ItmSerialTracked";
       public const string ItmTaxFreeMatl = "ItmTaxFreeMatl";
       public const string ItmUM = "ItmUM";
       public const string ItmVovhdCost = "ItmVovhdCost";
       public const string JbrWc = "JbrWc";
       public const string JbsJob = "JbsJob";
       public const string JbsSuffix = "JbsSuffix";
       public const string JitemDescription = "JitemDescription";
       public const string JitemLowLevel = "JitemLowLevel";
       public const string JitemPhantomFlag = "JitemPhantomFlag";
       public const string JitemPlanFlag = "JitemPlanFlag";
       public const string JitemTrackEcn = "JitemTrackEcn";
       public const string Job = "Job";
       public const string JobDescription = "JobDescription";
       public const string JobExportType = "JobExportType";
       public const string JobItem = "JobItem";
       public const string JobJobDate = "JobJobDate";
       public const string JobStat = "JobStat";
       public const string JobType = "JobType";
       public const string JshEndDate = "JshEndDate";
       public const string LbrCost = "LbrCost";
       public const string LbrCostConv = "LbrCostConv";
       public const string MatlBflushLoc = "MatlBflushLoc";
       public const string MatlCost = "MatlCost";
       public const string MatlCostConv = "MatlCostConv";
       public const string MatlDescription = "MatlDescription";
       public const string MatlJob = "MatlJob";
       public const string MatlKit = "MatlKit";
       public const string MatlLotTracked = "MatlLotTracked";
       public const string MatlLowLevel = "MatlLowLevel";
       public const string MatlPhantomFlag = "MatlPhantomFlag";
       public const string MatlPMTCode = "MatlPMTCode";
       public const string MatlQty = "MatlQty";
       public const string MatlQtyConv = "MatlQtyConv";
       public const string MatlRevision = "MatlRevision";
       public const string MatlSerialTracked = "MatlSerialTracked";
       public const string MatlStat = "MatlStat";
       public const string MatlSuffix = "MatlSuffix";
       public const string MatlType = "MatlType";
       public const string MatlUM = "MatlUM";
       public const string NewSequence = "NewSequence";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string ObsDate = "ObsDate";
       public const string OperNum = "OperNum";
       public const string OptCode = "OptCode";
       public const string OrdType = "OrdType";
       public const string OutCost = "OutCost";
       public const string OutCostConv = "OutCostConv";
       public const string PickDate = "PickDate";
       public const string PitmDescription = "PitmDescription";
       public const string PlannedAlternate = "PlannedAlternate";
       public const string PoUnitCost = "PoUnitCost";
       public const string Probable = "Probable";
       public const string PsiItem = "PsiItem";
       public const string PsiPsNum = "PsiPsNum";
       public const string PsStat = "PsStat";
       public const string QtyIssued = "QtyIssued";
       public const string QtyReleased = "QtyReleased";
       public const string QtyVar = "QtyVar";
       public const string RecordDate = "RecordDate";
       public const string RefLineSuf = "RefLineSuf";
       public const string RefNum = "RefNum";
       public const string RefRelease = "RefRelease";
       public const string RefType = "RefType";
       public const string RowPointer = "RowPointer";
       public const string ScrapFact = "ScrapFact";
       public const string Sequence = "Sequence";
       public const string SLJobRefs = "SLJobRefs";
       public const string SLSerials = "SLSerials";
       public const string Suffix = "Suffix";
       public const string UbAcct = "UbAcct";
       public const string UbAcctAccessUnit1 = "UbAcctAccessUnit1";
       public const string UbAcctAccessUnit2 = "UbAcctAccessUnit2";
       public const string UbAcctAccessUnit3 = "UbAcctAccessUnit3";
       public const string UbAcctAccessUnit4 = "UbAcctAccessUnit4";
       public const string UbAcctUnit1 = "UbAcctUnit1";
       public const string UbAcctUnit2 = "UbAcctUnit2";
       public const string UbAcctUnit3 = "UbAcctUnit3";
       public const string UbAcctUnit4 = "UbAcctUnit4";
       public const string UbCopyJobRef = "UbCopyJobRef";
       public const string UbCreate = "UbCreate";
       public const string UbCurrMatlOldRowPtr = "UbCurrMatlOldRowPtr";
       public const string UbDelTempSer = "UbDelTempSer";
       public const string UbDispXRefMsg = "UbDispXRefMsg";
       public const string UbEmpName = "UbEmpName";
       public const string UbEmpNum = "UbEmpNum";
       public const string UbGenerateQty = "UbGenerateQty";
       public const string UbImportDocId = "UbImportDocId";
       public const string UbItmItem = "UbItmItem";
       public const string UbItmLowLevel = "UbItmLowLevel";
       public const string UbJobMatlOldRowPtr = "UbJobMatlOldRowPtr";
       public const string UbJobType = "UbJobType";
       public const string UbLoc = "UbLoc";
       public const string UbLocQty = "UbLocQty";
       public const string UbLot = "UbLot";
       public const string UbNonInvItem = "UbNonInvItem";
       public const string UbNotInInventory = "UbNotInInventory";
       public const string UbPlanCostConv = "UbPlanCostConv";
       public const string UbProcessId = "UbProcessId";
       public const string UbProductCode = "UbProductCode";
       public const string UbQty = "UbQty";
       public const string UbQtyConv = "UbQtyConv";
       public const string UbQtyOnHand = "UbQtyOnHand";
       public const string UbQtyOnHandConv = "UbQtyOnHandConv";
       public const string UbQtyRequired = "UbQtyRequired";
       public const string UbQtyRequiredConv = "UbQtyRequiredConv";
       public const string UbRangeQty = "UbRangeQty";
       public const string UbSelect = "UbSelect";
       public const string UbSelectedQty = "UbSelectedQty";
       public const string UbSerialPrefix = "UbSerialPrefix";
       public const string UbTargetQty = "UbTargetQty";
       public const string UbTotalCost = "UbTotalCost";
       public const string UbTransDate = "UbTransDate";
       public const string UbUmConvFactor = "UbUmConvFactor";
       public const string UbWc = "UbWc";
       public const string UbWhse = "UbWhse";
       public const string UM = "UM";
       public const string Units = "Units";
       public const string VarovhdT = "VarovhdT";
       public const string Vmatlovhd = "Vmatlovhd";
       public const string VovhdCost = "VovhdCost";
       public const string VovhdCostConv = "VovhdCostConv";
       public const string WcDescription = "WcDescription";
       public const string WcOutside = "WcOutside";


                }public class JobMaterialsBuilder  
                :   IdoQueryBuilder<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>
                {
                    public JobMaterialsBuilder(IExpressionInterpreter ei) : base(JobMaterials.IDO_NAME, ei) { }

                      public JobMaterialsBuilder ACost { get {  AddProperty(JobMaterials.ACost); return this; } }         public JobMaterialsBuilder AFovhdCost { get {  AddProperty(JobMaterials.AFovhdCost); return this; } }         public JobMaterialsBuilder ALbrCost { get {  AddProperty(JobMaterials.ALbrCost); return this; } }         public JobMaterialsBuilder AltGroup { get {  AddProperty(JobMaterials.AltGroup); return this; } }         public JobMaterialsBuilder AltGroupRank { get {  AddProperty(JobMaterials.AltGroupRank); return this; } }         public JobMaterialsBuilder AMatlCost { get {  AddProperty(JobMaterials.AMatlCost); return this; } }         public JobMaterialsBuilder AOutCost { get {  AddProperty(JobMaterials.AOutCost); return this; } }         public JobMaterialsBuilder AVovhdCost { get {  AddProperty(JobMaterials.AVovhdCost); return this; } }         public JobMaterialsBuilder Backflush { get {  AddProperty(JobMaterials.Backflush); return this; } }         public JobMaterialsBuilder BflushLoc { get {  AddProperty(JobMaterials.BflushLoc); return this; } }         public JobMaterialsBuilder BomSeq { get {  AddProperty(JobMaterials.BomSeq); return this; } }         public JobMaterialsBuilder Cost { get {  AddProperty(JobMaterials.Cost); return this; } }         public JobMaterialsBuilder CostConv { get {  AddProperty(JobMaterials.CostConv); return this; } }         public JobMaterialsBuilder DerAltGroupRankText { get {  AddProperty(JobMaterials.DerAltGroupRankText); return this; } }         public JobMaterialsBuilder DerASPSearch { get {  AddProperty(JobMaterials.DerASPSearch); return this; } }         public JobMaterialsBuilder DerBflushLocRequired { get {  AddProperty(JobMaterials.DerBflushLocRequired); return this; } }         public JobMaterialsBuilder DerByProduct { get {  AddProperty(JobMaterials.DerByProduct); return this; } }         public JobMaterialsBuilder DerCostCode { get {  AddProperty(JobMaterials.DerCostCode); return this; } }         public JobMaterialsBuilder DerDelete { get {  AddProperty(JobMaterials.DerDelete); return this; } }         public JobMaterialsBuilder DerExtScrap { get {  AddProperty(JobMaterials.DerExtScrap); return this; } }         public JobMaterialsBuilder DerIsPSLbrPosted { get {  AddProperty(JobMaterials.DerIsPSLbrPosted); return this; } }         public JobMaterialsBuilder DerItemDescription { get {  AddProperty(JobMaterials.DerItemDescription); return this; } }         public JobMaterialsBuilder DerItemExist { get {  AddProperty(JobMaterials.DerItemExist); return this; } }         public JobMaterialsBuilder DerItemIssueBy { get {  AddProperty(JobMaterials.DerItemIssueBy); return this; } }         public JobMaterialsBuilder DerItemLotTracked { get {  AddProperty(JobMaterials.DerItemLotTracked); return this; } }         public JobMaterialsBuilder DerItemRowPointer { get {  AddProperty(JobMaterials.DerItemRowPointer); return this; } }         public JobMaterialsBuilder DerItemSerialTracked { get {  AddProperty(JobMaterials.DerItemSerialTracked); return this; } }         public JobMaterialsBuilder DerItemTaxFreeMatl { get {  AddProperty(JobMaterials.DerItemTaxFreeMatl); return this; } }         public JobMaterialsBuilder DerItemUM { get {  AddProperty(JobMaterials.DerItemUM); return this; } }         public JobMaterialsBuilder DerItemUMConvFactor { get {  AddProperty(JobMaterials.DerItemUMConvFactor); return this; } }         public JobMaterialsBuilder DerJobmatlRowPointer { get {  AddProperty(JobMaterials.DerJobmatlRowPointer); return this; } }         public JobMaterialsBuilder DerJobRowPointer { get {  AddProperty(JobMaterials.DerJobRowPointer); return this; } }         public JobMaterialsBuilder DerJobSuffix { get {  AddProperty(JobMaterials.DerJobSuffix); return this; } }         public JobMaterialsBuilder DerLevel { get {  AddProperty(JobMaterials.DerLevel); return this; } }         public JobMaterialsBuilder DerLoc { get {  AddProperty(JobMaterials.DerLoc); return this; } }         public JobMaterialsBuilder DerLot { get {  AddProperty(JobMaterials.DerLot); return this; } }         public JobMaterialsBuilder DerMatlExist { get {  AddProperty(JobMaterials.DerMatlExist); return this; } }         public JobMaterialsBuilder DerMatlLotTracked { get {  AddProperty(JobMaterials.DerMatlLotTracked); return this; } }         public JobMaterialsBuilder DerMatlQtyRequired { get {  AddProperty(JobMaterials.DerMatlQtyRequired); return this; } }         public JobMaterialsBuilder DerMatlSerialTracked { get {  AddProperty(JobMaterials.DerMatlSerialTracked); return this; } }         public JobMaterialsBuilder DerMatlSuffix { get {  AddProperty(JobMaterials.DerMatlSuffix); return this; } }         public JobMaterialsBuilder DerMatlTransQty { get {  AddProperty(JobMaterials.DerMatlTransQty); return this; } }         public JobMaterialsBuilder DerMessage { get {  AddProperty(JobMaterials.DerMessage); return this; } }         public JobMaterialsBuilder DerOrdType { get {  AddProperty(JobMaterials.DerOrdType); return this; } }         public JobMaterialsBuilder DerPlanCost { get {  AddProperty(JobMaterials.DerPlanCost); return this; } }         public JobMaterialsBuilder DerPlanCostConv { get {  AddProperty(JobMaterials.DerPlanCostConv); return this; } }         public JobMaterialsBuilder DerPMTCode { get {  AddProperty(JobMaterials.DerPMTCode); return this; } }         public JobMaterialsBuilder DerPoVendNum { get {  AddProperty(JobMaterials.DerPoVendNum); return this; } }         public JobMaterialsBuilder DerQty { get {  AddProperty(JobMaterials.DerQty); return this; } }         public JobMaterialsBuilder DerQtyConv { get {  AddProperty(JobMaterials.DerQtyConv); return this; } }         public JobMaterialsBuilder DerQtyIssuedConv { get {  AddProperty(JobMaterials.DerQtyIssuedConv); return this; } }         public JobMaterialsBuilder DerQtyOnHand { get {  AddProperty(JobMaterials.DerQtyOnHand); return this; } }         public JobMaterialsBuilder DerQtyOnHandConv { get {  AddProperty(JobMaterials.DerQtyOnHandConv); return this; } }         public JobMaterialsBuilder DerQtyPicked { get {  AddProperty(JobMaterials.DerQtyPicked); return this; } }         public JobMaterialsBuilder DerQtyToPick { get {  AddProperty(JobMaterials.DerQtyToPick); return this; } }         public JobMaterialsBuilder DerReqQty { get {  AddProperty(JobMaterials.DerReqQty); return this; } }         public JobMaterialsBuilder DerReqQtyConv { get {  AddProperty(JobMaterials.DerReqQtyConv); return this; } }         public JobMaterialsBuilder DerSelected { get {  AddProperty(JobMaterials.DerSelected); return this; } }         public JobMaterialsBuilder DerSequence { get {  AddProperty(JobMaterials.DerSequence); return this; } }         public JobMaterialsBuilder DerSerialPrefix { get {  AddProperty(JobMaterials.DerSerialPrefix); return this; } }         public JobMaterialsBuilder DerStartDate { get {  AddProperty(JobMaterials.DerStartDate); return this; } }         public JobMaterialsBuilder DerTransDate { get {  AddProperty(JobMaterials.DerTransDate); return this; } }         public JobMaterialsBuilder DerUM { get {  AddProperty(JobMaterials.DerUM); return this; } }         public JobMaterialsBuilder DerUOMConvFactor { get {  AddProperty(JobMaterials.DerUOMConvFactor); return this; } }         public JobMaterialsBuilder DerWC { get {  AddProperty(JobMaterials.DerWC); return this; } }         public JobMaterialsBuilder DerWhse { get {  AddProperty(JobMaterials.DerWhse); return this; } }         public JobMaterialsBuilder Description { get {  AddProperty(JobMaterials.Description); return this; } }         public JobMaterialsBuilder EffectDate { get {  AddProperty(JobMaterials.EffectDate); return this; } }         public JobMaterialsBuilder Feature { get {  AddProperty(JobMaterials.Feature); return this; } }         public JobMaterialsBuilder FixovhdT { get {  AddProperty(JobMaterials.FixovhdT); return this; } }         public JobMaterialsBuilder Fmatlovhd { get {  AddProperty(JobMaterials.Fmatlovhd); return this; } }         public JobMaterialsBuilder FovhdCost { get {  AddProperty(JobMaterials.FovhdCost); return this; } }         public JobMaterialsBuilder FovhdCostConv { get {  AddProperty(JobMaterials.FovhdCostConv); return this; } }         public JobMaterialsBuilder IncPrice { get {  AddProperty(JobMaterials.IncPrice); return this; } }         public JobMaterialsBuilder IncPriceConv { get {  AddProperty(JobMaterials.IncPriceConv); return this; } }         public JobMaterialsBuilder InWorkflow { get {  AddProperty(JobMaterials.InWorkflow); return this; } }         public JobMaterialsBuilder Item { get {  AddProperty(JobMaterials.Item); return this; } }         public JobMaterialsBuilder ItmDescription { get {  AddProperty(JobMaterials.ItmDescription); return this; } }         public JobMaterialsBuilder ItmEcnTracked { get {  AddProperty(JobMaterials.ItmEcnTracked); return this; } }         public JobMaterialsBuilder ItmFovhdCost { get {  AddProperty(JobMaterials.ItmFovhdCost); return this; } }         public JobMaterialsBuilder ItmIssueBy { get {  AddProperty(JobMaterials.ItmIssueBy); return this; } }         public JobMaterialsBuilder ItmItem { get {  AddProperty(JobMaterials.ItmItem); return this; } }         public JobMaterialsBuilder ItmLbrCost { get {  AddProperty(JobMaterials.ItmLbrCost); return this; } }         public JobMaterialsBuilder ItmLotTracked { get {  AddProperty(JobMaterials.ItmLotTracked); return this; } }         public JobMaterialsBuilder ItmLowLevel { get {  AddProperty(JobMaterials.ItmLowLevel); return this; } }         public JobMaterialsBuilder ItmMatlCost { get {  AddProperty(JobMaterials.ItmMatlCost); return this; } }         public JobMaterialsBuilder ItmOutCost { get {  AddProperty(JobMaterials.ItmOutCost); return this; } }         public JobMaterialsBuilder ItmPhantomFlag { get {  AddProperty(JobMaterials.ItmPhantomFlag); return this; } }         public JobMaterialsBuilder ItmPlanFlag { get {  AddProperty(JobMaterials.ItmPlanFlag); return this; } }         public JobMaterialsBuilder ItmPMTCode { get {  AddProperty(JobMaterials.ItmPMTCode); return this; } }         public JobMaterialsBuilder ItmProductCode { get {  AddProperty(JobMaterials.ItmProductCode); return this; } }         public JobMaterialsBuilder ItmRevision { get {  AddProperty(JobMaterials.ItmRevision); return this; } }         public JobMaterialsBuilder ItmSerialTracked { get {  AddProperty(JobMaterials.ItmSerialTracked); return this; } }         public JobMaterialsBuilder ItmTaxFreeMatl { get {  AddProperty(JobMaterials.ItmTaxFreeMatl); return this; } }         public JobMaterialsBuilder ItmUM { get {  AddProperty(JobMaterials.ItmUM); return this; } }         public JobMaterialsBuilder ItmVovhdCost { get {  AddProperty(JobMaterials.ItmVovhdCost); return this; } }         public JobMaterialsBuilder JbrWc { get {  AddProperty(JobMaterials.JbrWc); return this; } }         public JobMaterialsBuilder JbsJob { get {  AddProperty(JobMaterials.JbsJob); return this; } }         public JobMaterialsBuilder JbsSuffix { get {  AddProperty(JobMaterials.JbsSuffix); return this; } }         public JobMaterialsBuilder JitemDescription { get {  AddProperty(JobMaterials.JitemDescription); return this; } }         public JobMaterialsBuilder JitemLowLevel { get {  AddProperty(JobMaterials.JitemLowLevel); return this; } }         public JobMaterialsBuilder JitemPhantomFlag { get {  AddProperty(JobMaterials.JitemPhantomFlag); return this; } }         public JobMaterialsBuilder JitemPlanFlag { get {  AddProperty(JobMaterials.JitemPlanFlag); return this; } }         public JobMaterialsBuilder JitemTrackEcn { get {  AddProperty(JobMaterials.JitemTrackEcn); return this; } }         public JobMaterialsBuilder Job { get {  AddProperty(JobMaterials.Job); return this; } }         public JobMaterialsBuilder JobDescription { get {  AddProperty(JobMaterials.JobDescription); return this; } }         public JobMaterialsBuilder JobExportType { get {  AddProperty(JobMaterials.JobExportType); return this; } }         public JobMaterialsBuilder JobItem { get {  AddProperty(JobMaterials.JobItem); return this; } }         public JobMaterialsBuilder JobJobDate { get {  AddProperty(JobMaterials.JobJobDate); return this; } }         public JobMaterialsBuilder JobStat { get {  AddProperty(JobMaterials.JobStat); return this; } }         public JobMaterialsBuilder JobType { get {  AddProperty(JobMaterials.JobType); return this; } }         public JobMaterialsBuilder JshEndDate { get {  AddProperty(JobMaterials.JshEndDate); return this; } }         public JobMaterialsBuilder LbrCost { get {  AddProperty(JobMaterials.LbrCost); return this; } }         public JobMaterialsBuilder LbrCostConv { get {  AddProperty(JobMaterials.LbrCostConv); return this; } }         public JobMaterialsBuilder MatlBflushLoc { get {  AddProperty(JobMaterials.MatlBflushLoc); return this; } }         public JobMaterialsBuilder MatlCost { get {  AddProperty(JobMaterials.MatlCost); return this; } }         public JobMaterialsBuilder MatlCostConv { get {  AddProperty(JobMaterials.MatlCostConv); return this; } }         public JobMaterialsBuilder MatlDescription { get {  AddProperty(JobMaterials.MatlDescription); return this; } }         public JobMaterialsBuilder MatlJob { get {  AddProperty(JobMaterials.MatlJob); return this; } }         public JobMaterialsBuilder MatlKit { get {  AddProperty(JobMaterials.MatlKit); return this; } }         public JobMaterialsBuilder MatlLotTracked { get {  AddProperty(JobMaterials.MatlLotTracked); return this; } }         public JobMaterialsBuilder MatlLowLevel { get {  AddProperty(JobMaterials.MatlLowLevel); return this; } }         public JobMaterialsBuilder MatlPhantomFlag { get {  AddProperty(JobMaterials.MatlPhantomFlag); return this; } }         public JobMaterialsBuilder MatlPMTCode { get {  AddProperty(JobMaterials.MatlPMTCode); return this; } }         public JobMaterialsBuilder MatlQty { get {  AddProperty(JobMaterials.MatlQty); return this; } }         public JobMaterialsBuilder MatlQtyConv { get {  AddProperty(JobMaterials.MatlQtyConv); return this; } }         public JobMaterialsBuilder MatlRevision { get {  AddProperty(JobMaterials.MatlRevision); return this; } }         public JobMaterialsBuilder MatlSerialTracked { get {  AddProperty(JobMaterials.MatlSerialTracked); return this; } }         public JobMaterialsBuilder MatlStat { get {  AddProperty(JobMaterials.MatlStat); return this; } }         public JobMaterialsBuilder MatlSuffix { get {  AddProperty(JobMaterials.MatlSuffix); return this; } }         public JobMaterialsBuilder MatlType { get {  AddProperty(JobMaterials.MatlType); return this; } }         public JobMaterialsBuilder MatlUM { get {  AddProperty(JobMaterials.MatlUM); return this; } }         public JobMaterialsBuilder NewSequence { get {  AddProperty(JobMaterials.NewSequence); return this; } }         public JobMaterialsBuilder NoteExistsFlag { get {  AddProperty(JobMaterials.NoteExistsFlag); return this; } }         public JobMaterialsBuilder ObsDate { get {  AddProperty(JobMaterials.ObsDate); return this; } }         public JobMaterialsBuilder OperNum { get {  AddProperty(JobMaterials.OperNum); return this; } }         public JobMaterialsBuilder OptCode { get {  AddProperty(JobMaterials.OptCode); return this; } }         public JobMaterialsBuilder OrdType { get {  AddProperty(JobMaterials.OrdType); return this; } }         public JobMaterialsBuilder OutCost { get {  AddProperty(JobMaterials.OutCost); return this; } }         public JobMaterialsBuilder OutCostConv { get {  AddProperty(JobMaterials.OutCostConv); return this; } }         public JobMaterialsBuilder PickDate { get {  AddProperty(JobMaterials.PickDate); return this; } }         public JobMaterialsBuilder PitmDescription { get {  AddProperty(JobMaterials.PitmDescription); return this; } }         public JobMaterialsBuilder PlannedAlternate { get {  AddProperty(JobMaterials.PlannedAlternate); return this; } }         public JobMaterialsBuilder PoUnitCost { get {  AddProperty(JobMaterials.PoUnitCost); return this; } }         public JobMaterialsBuilder Probable { get {  AddProperty(JobMaterials.Probable); return this; } }         public JobMaterialsBuilder PsiItem { get {  AddProperty(JobMaterials.PsiItem); return this; } }         public JobMaterialsBuilder PsiPsNum { get {  AddProperty(JobMaterials.PsiPsNum); return this; } }         public JobMaterialsBuilder PsStat { get {  AddProperty(JobMaterials.PsStat); return this; } }         public JobMaterialsBuilder QtyIssued { get {  AddProperty(JobMaterials.QtyIssued); return this; } }         public JobMaterialsBuilder QtyReleased { get {  AddProperty(JobMaterials.QtyReleased); return this; } }         public JobMaterialsBuilder QtyVar { get {  AddProperty(JobMaterials.QtyVar); return this; } }         public JobMaterialsBuilder RecordDate { get {  AddProperty(JobMaterials.RecordDate); return this; } }         public JobMaterialsBuilder RefLineSuf { get {  AddProperty(JobMaterials.RefLineSuf); return this; } }         public JobMaterialsBuilder RefNum { get {  AddProperty(JobMaterials.RefNum); return this; } }         public JobMaterialsBuilder RefRelease { get {  AddProperty(JobMaterials.RefRelease); return this; } }         public JobMaterialsBuilder RefType { get {  AddProperty(JobMaterials.RefType); return this; } }         public JobMaterialsBuilder RowPointer { get {  AddProperty(JobMaterials.RowPointer); return this; } }         public JobMaterialsBuilder ScrapFact { get {  AddProperty(JobMaterials.ScrapFact); return this; } }         public JobMaterialsBuilder Sequence { get {  AddProperty(JobMaterials.Sequence); return this; } }         public JobMaterialsBuilder SLJobRefs { get {  AddProperty(JobMaterials.SLJobRefs); return this; } }         public JobMaterialsBuilder SLSerials { get {  AddProperty(JobMaterials.SLSerials); return this; } }         public JobMaterialsBuilder Suffix { get {  AddProperty(JobMaterials.Suffix); return this; } }         public JobMaterialsBuilder UbAcct { get {  AddProperty(JobMaterials.UbAcct); return this; } }         public JobMaterialsBuilder UbAcctAccessUnit1 { get {  AddProperty(JobMaterials.UbAcctAccessUnit1); return this; } }         public JobMaterialsBuilder UbAcctAccessUnit2 { get {  AddProperty(JobMaterials.UbAcctAccessUnit2); return this; } }         public JobMaterialsBuilder UbAcctAccessUnit3 { get {  AddProperty(JobMaterials.UbAcctAccessUnit3); return this; } }         public JobMaterialsBuilder UbAcctAccessUnit4 { get {  AddProperty(JobMaterials.UbAcctAccessUnit4); return this; } }         public JobMaterialsBuilder UbAcctUnit1 { get {  AddProperty(JobMaterials.UbAcctUnit1); return this; } }         public JobMaterialsBuilder UbAcctUnit2 { get {  AddProperty(JobMaterials.UbAcctUnit2); return this; } }         public JobMaterialsBuilder UbAcctUnit3 { get {  AddProperty(JobMaterials.UbAcctUnit3); return this; } }         public JobMaterialsBuilder UbAcctUnit4 { get {  AddProperty(JobMaterials.UbAcctUnit4); return this; } }         public JobMaterialsBuilder UbCopyJobRef { get {  AddProperty(JobMaterials.UbCopyJobRef); return this; } }         public JobMaterialsBuilder UbCreate { get {  AddProperty(JobMaterials.UbCreate); return this; } }         public JobMaterialsBuilder UbCurrMatlOldRowPtr { get {  AddProperty(JobMaterials.UbCurrMatlOldRowPtr); return this; } }         public JobMaterialsBuilder UbDelTempSer { get {  AddProperty(JobMaterials.UbDelTempSer); return this; } }         public JobMaterialsBuilder UbDispXRefMsg { get {  AddProperty(JobMaterials.UbDispXRefMsg); return this; } }         public JobMaterialsBuilder UbEmpName { get {  AddProperty(JobMaterials.UbEmpName); return this; } }         public JobMaterialsBuilder UbEmpNum { get {  AddProperty(JobMaterials.UbEmpNum); return this; } }         public JobMaterialsBuilder UbGenerateQty { get {  AddProperty(JobMaterials.UbGenerateQty); return this; } }         public JobMaterialsBuilder UbImportDocId { get {  AddProperty(JobMaterials.UbImportDocId); return this; } }         public JobMaterialsBuilder UbItmItem { get {  AddProperty(JobMaterials.UbItmItem); return this; } }         public JobMaterialsBuilder UbItmLowLevel { get {  AddProperty(JobMaterials.UbItmLowLevel); return this; } }         public JobMaterialsBuilder UbJobMatlOldRowPtr { get {  AddProperty(JobMaterials.UbJobMatlOldRowPtr); return this; } }         public JobMaterialsBuilder UbJobType { get {  AddProperty(JobMaterials.UbJobType); return this; } }         public JobMaterialsBuilder UbLoc { get {  AddProperty(JobMaterials.UbLoc); return this; } }         public JobMaterialsBuilder UbLocQty { get {  AddProperty(JobMaterials.UbLocQty); return this; } }         public JobMaterialsBuilder UbLot { get {  AddProperty(JobMaterials.UbLot); return this; } }         public JobMaterialsBuilder UbNonInvItem { get {  AddProperty(JobMaterials.UbNonInvItem); return this; } }         public JobMaterialsBuilder UbNotInInventory { get {  AddProperty(JobMaterials.UbNotInInventory); return this; } }         public JobMaterialsBuilder UbPlanCostConv { get {  AddProperty(JobMaterials.UbPlanCostConv); return this; } }         public JobMaterialsBuilder UbProcessId { get {  AddProperty(JobMaterials.UbProcessId); return this; } }         public JobMaterialsBuilder UbProductCode { get {  AddProperty(JobMaterials.UbProductCode); return this; } }         public JobMaterialsBuilder UbQty { get {  AddProperty(JobMaterials.UbQty); return this; } }         public JobMaterialsBuilder UbQtyConv { get {  AddProperty(JobMaterials.UbQtyConv); return this; } }         public JobMaterialsBuilder UbQtyOnHand { get {  AddProperty(JobMaterials.UbQtyOnHand); return this; } }         public JobMaterialsBuilder UbQtyOnHandConv { get {  AddProperty(JobMaterials.UbQtyOnHandConv); return this; } }         public JobMaterialsBuilder UbQtyRequired { get {  AddProperty(JobMaterials.UbQtyRequired); return this; } }         public JobMaterialsBuilder UbQtyRequiredConv { get {  AddProperty(JobMaterials.UbQtyRequiredConv); return this; } }         public JobMaterialsBuilder UbRangeQty { get {  AddProperty(JobMaterials.UbRangeQty); return this; } }         public JobMaterialsBuilder UbSelect { get {  AddProperty(JobMaterials.UbSelect); return this; } }         public JobMaterialsBuilder UbSelectedQty { get {  AddProperty(JobMaterials.UbSelectedQty); return this; } }         public JobMaterialsBuilder UbSerialPrefix { get {  AddProperty(JobMaterials.UbSerialPrefix); return this; } }         public JobMaterialsBuilder UbTargetQty { get {  AddProperty(JobMaterials.UbTargetQty); return this; } }         public JobMaterialsBuilder UbTotalCost { get {  AddProperty(JobMaterials.UbTotalCost); return this; } }         public JobMaterialsBuilder UbTransDate { get {  AddProperty(JobMaterials.UbTransDate); return this; } }         public JobMaterialsBuilder UbUmConvFactor { get {  AddProperty(JobMaterials.UbUmConvFactor); return this; } }         public JobMaterialsBuilder UbWc { get {  AddProperty(JobMaterials.UbWc); return this; } }         public JobMaterialsBuilder UbWhse { get {  AddProperty(JobMaterials.UbWhse); return this; } }         public JobMaterialsBuilder UM { get {  AddProperty(JobMaterials.UM); return this; } }         public JobMaterialsBuilder Units { get {  AddProperty(JobMaterials.Units); return this; } }         public JobMaterialsBuilder VarovhdT { get {  AddProperty(JobMaterials.VarovhdT); return this; } }         public JobMaterialsBuilder Vmatlovhd { get {  AddProperty(JobMaterials.Vmatlovhd); return this; } }         public JobMaterialsBuilder VovhdCost { get {  AddProperty(JobMaterials.VovhdCost); return this; } }         public JobMaterialsBuilder VovhdCostConv { get {  AddProperty(JobMaterials.VovhdCostConv); return this; } }         public JobMaterialsBuilder WcDescription { get {  AddProperty(JobMaterials.WcDescription); return this; } }         public JobMaterialsBuilder WcOutside { get {  AddProperty(JobMaterials.WcOutside); return this; } }   

                }
                    
                    
                    public class JobMaterialsFilterExpressionBuilder  
                :   FilterExpressionBuilder<JobMaterialsBuilder>
                {
                        public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ACost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ACost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> AFovhdCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.AFovhdCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ALbrCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ALbrCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> AltGroup
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.AltGroup); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> AltGroupRank
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.AltGroupRank); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> AMatlCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.AMatlCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> AOutCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.AOutCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> AVovhdCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.AVovhdCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Backflush
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Backflush); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> BflushLoc
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.BflushLoc); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> BomSeq
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.BomSeq); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Cost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Cost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> CostConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.CostConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerAltGroupRankText
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerAltGroupRankText); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerASPSearch
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerASPSearch); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerBflushLocRequired
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerBflushLocRequired); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerByProduct
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerByProduct); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerCostCode
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerCostCode); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerDelete
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerDelete); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerExtScrap
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerExtScrap); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerIsPSLbrPosted
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerIsPSLbrPosted); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerItemDescription
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerItemDescription); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerItemExist
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerItemExist); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerItemIssueBy
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerItemIssueBy); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerItemLotTracked
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerItemLotTracked); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerItemRowPointer
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerItemRowPointer); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerItemSerialTracked
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerItemSerialTracked); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerItemTaxFreeMatl
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerItemTaxFreeMatl); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerItemUM
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerItemUM); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerItemUMConvFactor
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerItemUMConvFactor); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerJobmatlRowPointer
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerJobmatlRowPointer); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerJobRowPointer
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerJobRowPointer); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerJobSuffix
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerJobSuffix); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerLevel
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerLevel); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerLoc
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerLoc); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerLot
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerLot); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerMatlExist
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerMatlExist); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerMatlLotTracked
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerMatlLotTracked); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerMatlQtyRequired
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerMatlQtyRequired); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerMatlSerialTracked
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerMatlSerialTracked); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerMatlSuffix
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerMatlSuffix); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerMatlTransQty
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerMatlTransQty); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerMessage
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerMessage); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerOrdType
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerOrdType); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerPlanCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerPlanCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerPlanCostConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerPlanCostConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerPMTCode
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerPMTCode); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerPoVendNum
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerPoVendNum); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerQty
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerQty); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerQtyConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerQtyConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerQtyIssuedConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerQtyIssuedConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerQtyOnHand
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerQtyOnHand); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerQtyOnHandConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerQtyOnHandConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerQtyPicked
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerQtyPicked); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerQtyToPick
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerQtyToPick); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerReqQty
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerReqQty); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerReqQtyConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerReqQtyConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerSelected
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerSelected); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerSequence
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerSequence); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerSerialPrefix
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerSerialPrefix); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerStartDate
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerStartDate); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerTransDate
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerTransDate); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerUM
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerUM); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerUOMConvFactor
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerUOMConvFactor); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerWC
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerWC); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> DerWhse
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.DerWhse); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Description
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Description); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> EffectDate
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.EffectDate); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Feature
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Feature); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> FixovhdT
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.FixovhdT); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Fmatlovhd
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Fmatlovhd); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> FovhdCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.FovhdCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> FovhdCostConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.FovhdCostConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> IncPrice
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.IncPrice); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> IncPriceConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.IncPriceConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.InWorkflow); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Item
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Item); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmDescription
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmDescription); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmEcnTracked
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmEcnTracked); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmFovhdCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmFovhdCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmIssueBy
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmIssueBy); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmItem
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmItem); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmLbrCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmLbrCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmLotTracked
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmLotTracked); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmLowLevel
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmLowLevel); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmMatlCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmMatlCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmOutCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmOutCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmPhantomFlag
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmPhantomFlag); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmPlanFlag
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmPlanFlag); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmPMTCode
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmPMTCode); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmProductCode
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmProductCode); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmRevision
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmRevision); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmSerialTracked
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmSerialTracked); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmTaxFreeMatl
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmTaxFreeMatl); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmUM
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmUM); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ItmVovhdCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ItmVovhdCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JbrWc
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JbrWc); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JbsJob
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JbsJob); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JbsSuffix
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JbsSuffix); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JitemDescription
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JitemDescription); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JitemLowLevel
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JitemLowLevel); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JitemPhantomFlag
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JitemPhantomFlag); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JitemPlanFlag
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JitemPlanFlag); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JitemTrackEcn
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JitemTrackEcn); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Job
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Job); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JobDescription
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JobDescription); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JobExportType
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JobExportType); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JobItem
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JobItem); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JobJobDate
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JobJobDate); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JobStat
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JobStat); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JobType
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JobType); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> JshEndDate
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.JshEndDate); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> LbrCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.LbrCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> LbrCostConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.LbrCostConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlBflushLoc
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlBflushLoc); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlCostConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlCostConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlDescription
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlDescription); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlJob
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlJob); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlKit
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlKit); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlLotTracked
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlLotTracked); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlLowLevel
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlLowLevel); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlPhantomFlag
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlPhantomFlag); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlPMTCode
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlPMTCode); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlQty
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlQty); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlQtyConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlQtyConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlRevision
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlRevision); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlSerialTracked
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlSerialTracked); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlStat
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlStat); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlSuffix
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlSuffix); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlType
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlType); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> MatlUM
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.MatlUM); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> NewSequence
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.NewSequence); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.NoteExistsFlag); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ObsDate
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ObsDate); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> OperNum
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.OperNum); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> OptCode
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.OptCode); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> OrdType
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.OrdType); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> OutCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.OutCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> OutCostConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.OutCostConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> PickDate
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.PickDate); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> PitmDescription
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.PitmDescription); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> PlannedAlternate
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.PlannedAlternate); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> PoUnitCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.PoUnitCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Probable
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Probable); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> PsiItem
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.PsiItem); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> PsiPsNum
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.PsiPsNum); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> PsStat
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.PsStat); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> QtyIssued
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.QtyIssued); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> QtyReleased
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.QtyReleased); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> QtyVar
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.QtyVar); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.RecordDate); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> RefLineSuf
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.RefLineSuf); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> RefNum
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.RefNum); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> RefRelease
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.RefRelease); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> RefType
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.RefType); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.RowPointer); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> ScrapFact
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.ScrapFact); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Sequence
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Sequence); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> SLJobRefs
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.SLJobRefs); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> SLSerials
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.SLSerials); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Suffix
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Suffix); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbAcct
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbAcct); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbAcctAccessUnit1
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbAcctAccessUnit1); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbAcctAccessUnit2
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbAcctAccessUnit2); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbAcctAccessUnit3
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbAcctAccessUnit3); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbAcctAccessUnit4
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbAcctAccessUnit4); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbAcctUnit1
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbAcctUnit1); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbAcctUnit2
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbAcctUnit2); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbAcctUnit3
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbAcctUnit3); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbAcctUnit4
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbAcctUnit4); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbCopyJobRef
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbCopyJobRef); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbCreate
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbCreate); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbCurrMatlOldRowPtr
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbCurrMatlOldRowPtr); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbDelTempSer
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbDelTempSer); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbDispXRefMsg
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbDispXRefMsg); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbEmpName
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbEmpName); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbEmpNum
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbEmpNum); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbGenerateQty
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbGenerateQty); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbImportDocId
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbImportDocId); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbItmItem
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbItmItem); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbItmLowLevel
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbItmLowLevel); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbJobMatlOldRowPtr
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbJobMatlOldRowPtr); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbJobType
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbJobType); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbLoc
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbLoc); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbLocQty
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbLocQty); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbLot
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbLot); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbNonInvItem
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbNonInvItem); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbNotInInventory
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbNotInInventory); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbPlanCostConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbPlanCostConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbProcessId
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbProcessId); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbProductCode
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbProductCode); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbQty
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbQty); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbQtyConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbQtyConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbQtyOnHand
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbQtyOnHand); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbQtyOnHandConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbQtyOnHandConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbQtyRequired
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbQtyRequired); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbQtyRequiredConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbQtyRequiredConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbRangeQty
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbRangeQty); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbSelect
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbSelect); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbSelectedQty
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbSelectedQty); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbSerialPrefix
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbSerialPrefix); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbTargetQty
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbTargetQty); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbTotalCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbTotalCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbTransDate
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbTransDate); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbUmConvFactor
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbUmConvFactor); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbWc
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbWc); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UbWhse
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UbWhse); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> UM
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.UM); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Units
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Units); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> VarovhdT
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.VarovhdT); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> Vmatlovhd
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.Vmatlovhd); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> VovhdCost
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.VovhdCost); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> VovhdCostConv
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.VovhdCostConv); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> WcDescription
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.WcDescription); }
                    }
                            public FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder> WcOutside
                    {
                        get { return new FilterExpression<JobMaterialsBuilder, JobMaterialsFilterExpressionBuilder>(_builder, JobMaterials.WcOutside); }
                    }
                    

                }
            }