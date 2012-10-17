using SytelineInterface.Core;

                namespace SytelineInterface.Dsl.Queries
                {
                    using Commands;

                    public class Jobs : IdoConstants 
                { 
                           public const string IDO_NAME = "SLJobs";
       public const string CfgMainConfigGid = "CfgMainConfigGid";
       public const string CfgMainConfigStatus = "CfgMainConfigStatus";
       public const string ChFovAccessUnit1 = "ChFovAccessUnit1";
       public const string ChFovAccessUnit2 = "ChFovAccessUnit2";
       public const string ChFovAccessUnit3 = "ChFovAccessUnit3";
       public const string ChFovAccessUnit4 = "ChFovAccessUnit4";
       public const string ChFovDescription = "ChFovDescription";
       public const string ChJcbAccessUnit1 = "ChJcbAccessUnit1";
       public const string ChJcbAccessUnit2 = "ChJcbAccessUnit2";
       public const string ChJcbAccessUnit3 = "ChJcbAccessUnit3";
       public const string ChJcbAccessUnit4 = "ChJcbAccessUnit4";
       public const string ChJcbDescription = "ChJcbDescription";
       public const string ChLbrAccessUnit1 = "ChLbrAccessUnit1";
       public const string ChLbrAccessUnit2 = "ChLbrAccessUnit2";
       public const string ChLbrAccessUnit3 = "ChLbrAccessUnit3";
       public const string ChLbrAccessUnit4 = "ChLbrAccessUnit4";
       public const string ChLbrDescription = "ChLbrDescription";
       public const string ChOutAccessUnit1 = "ChOutAccessUnit1";
       public const string ChOutAccessUnit2 = "ChOutAccessUnit2";
       public const string ChOutAccessUnit3 = "ChOutAccessUnit3";
       public const string ChOutAccessUnit4 = "ChOutAccessUnit4";
       public const string ChOutDescription = "ChOutDescription";
       public const string ChVovAccessUnit1 = "ChVovAccessUnit1";
       public const string ChVovAccessUnit2 = "ChVovAccessUnit2";
       public const string ChVovAccessUnit3 = "ChVovAccessUnit3";
       public const string ChVovAccessUnit4 = "ChVovAccessUnit4";
       public const string ChVovDescription = "ChVovDescription";
       public const string ChWipAccessUnit1 = "ChWipAccessUnit1";
       public const string ChWipAccessUnit2 = "ChWipAccessUnit2";
       public const string ChWipAccessUnit3 = "ChWipAccessUnit3";
       public const string ChWipAccessUnit4 = "ChWipAccessUnit4";
       public const string ChWipDescription = "ChWipDescription";
       public const string ConfigId = "ConfigId";
       public const string CoProductMix = "CoProductMix";
       public const string CustNum = "CustNum";
       public const string DerApsOrderID = "DerApsOrderID";
       public const string DerASPSearch = "DerASPSearch";
       public const string DerCriticalRatio = "DerCriticalRatio";
       public const string DerCurrentBOMExists = "DerCurrentBOMExists";
       public const string DerCustName = "DerCustName";
       public const string DerCustNum = "DerCustNum";
       public const string DerDaysRem = "DerDaysRem";
       public const string DerDueDate = "DerDueDate";
       public const string DerEcnPending = "DerEcnPending";
       public const string DerECNTracked = "DerECNTracked";
       public const string DerEnableCoProductMix = "DerEnableCoProductMix";
       public const string DerEnableItem = "DerEnableItem";
       public const string DerEndDueDate = "DerEndDueDate";
       public const string DerHasXRef = "DerHasXRef";
       public const string DerIsScheduled = "DerIsScheduled";
       public const string DerJobDate = "DerJobDate";
       public const string DerJobFormatted = "DerJobFormatted";
       public const string DerJobrouteExists = "DerJobrouteExists";
       public const string DerJobSuffix = "DerJobSuffix";
       public const string DerMessageText = "DerMessageText";
       public const string DerNewCost = "DerNewCost";
       public const string DerNewStatus = "DerNewStatus";
       public const string DerOldCost = "DerOldCost";
       public const string DerOldStat = "DerOldStat";
       public const string DerOrderDate = "DerOrderDate";
       public const string DerOrderQty = "DerOrderQty";
       public const string DerPriority = "DerPriority";
       public const string DerProspectId = "DerProspectId";
       public const string DerPsDesc = "DerPsDesc";
       public const string DerPsItemBOMExists = "DerPsItemBOMExists";
       public const string DerPsItemRelBOMExists = "DerPsItemRelBOMExists";
       public const string DerQtyRemaining = "DerQtyRemaining";
       public const string DerRework = "DerRework";
       public const string DerStandardBOMExists = "DerStandardBOMExists";
       public const string DerStatFormatted = "DerStatFormatted";
       public const string DerStdJobExists = "DerStdJobExists";
       public const string DerSubJobExists = "DerSubJobExists";
       public const string DerWorkRem = "DerWorkRem";
       public const string Description = "Description";
       public const string EffectDate = "EffectDate";
       public const string EstJob = "EstJob";
       public const string EstSuf = "EstSuf";
       public const string InWorkflow = "InWorkflow";
       public const string Item = "Item";
       public const string ItemAutoPost = "ItemAutoPost";
       public const string ItemCfgModel = "ItemCfgModel";
       public const string ItemDescription = "ItemDescription";
       public const string ItemEcnTracked = "ItemEcnTracked";
       public const string ItemJobConfigurable = "ItemJobConfigurable";
       public const string ItemJobPostConfig = "ItemJobPostConfig";
       public const string ItemLotTracked = "ItemLotTracked";
       public const string ItemPlanFlag = "ItemPlanFlag";
       public const string ItemSerialPrefix = "ItemSerialPrefix";
       public const string ItemSerialTracked = "ItemSerialTracked";
       public const string ItemStat = "ItemStat";
       public const string ItemTaxFreeMatl = "ItemTaxFreeMatl";
       public const string JcbAcct = "JcbAcct";
       public const string JcbAcctUnit1 = "JcbAcctUnit1";
       public const string JcbAcctUnit2 = "JcbAcctUnit2";
       public const string JcbAcctUnit3 = "JcbAcctUnit3";
       public const string JcbAcctUnit4 = "JcbAcctUnit4";
       public const string Job = "Job";
       public const string JobDate = "JobDate";
       public const string JobDescription = "JobDescription";
       public const string JschCompdate = "JschCompdate";
       public const string JschEndDate = "JschEndDate";
       public const string JschEndTick = "JschEndTick";
       public const string JschPrfreeze = "JschPrfreeze";
       public const string JschPriority = "JschPriority";
       public const string JschRecordDate = "JschRecordDate";
       public const string JschRowPointer = "JschRowPointer";
       public const string JschStartDate = "JschStartDate";
       public const string JschStartTick = "JschStartTick";
       public const string LowLevel = "LowLevel";
       public const string LstTrxDate = "LstTrxDate";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string OrdLine = "OrdLine";
       public const string OrdNum = "OrdNum";
       public const string OrdRelease = "OrdRelease";
       public const string OrdType = "OrdType";
       public const string ParCfgConfigGid = "ParCfgConfigGid";
       public const string Picked = "Picked";
       public const string ProCompany = "ProCompany";
       public const string ProdMix = "ProdMix";
       public const string ProspectId = "ProspectId";
       public const string PsNum = "PsNum";
       public const string QtyComplete = "QtyComplete";
       public const string QtyReleased = "QtyReleased";
       public const string QtyScrapped = "QtyScrapped";
       public const string RecordDate = "RecordDate";
       public const string RefJob = "RefJob";
       public const string RefOper = "RefOper";
       public const string RefSeq = "RefSeq";
       public const string RefSuf = "RefSuf";
       public const string Revision = "Revision";
       public const string Rework = "Rework";
       public const string RollupDate = "RollupDate";
       public const string RootJob = "RootJob";
       public const string RootSuf = "RootSuf";
       public const string RowPointer = "RowPointer";
       public const string ShowInDropDownList = "ShowInDropDownList";
       public const string SLJobmatlJobs = "SLJobmatlJobs";
       public const string SLJobmatlPos = "SLJobmatlPos";
       public const string SLJobmatlReqs = "SLJobmatlReqs";
       public const string SLJobmatls = "SLJobmatls";
       public const string SLJobmatlTrns = "SLJobmatlTrns";
       public const string SLJobRoutes = "SLJobRoutes";
       public const string Stat = "Stat";
       public const string Suffix = "Suffix";
       public const string Type = "Type";
       public const string UbCopyBOM = "UbCopyBOM";
       public const string UbDispXRefMsg = "UbDispXRefMsg";
       public const string UbDispXRefMsg1 = "UbDispXRefMsg1";
       public const string UbItem = "UbItem";
       public const string UbJob = "UbJob";
       public const string UBPerformSubJobDateRecalc = "UBPerformSubJobDateRecalc";
       public const string UBPlanOnSave = "UBPlanOnSave";
       public const string UBViewType = "UBViewType";
       public const string UnlinkedXref = "UnlinkedXref";
       public const string Whse = "Whse";
       public const string WipAcct = "WipAcct";
       public const string WipAcctUnit1 = "WipAcctUnit1";
       public const string WipAcctUnit2 = "WipAcctUnit2";
       public const string WipAcctUnit3 = "WipAcctUnit3";
       public const string WipAcctUnit4 = "WipAcctUnit4";
       public const string WipComplete = "WipComplete";
       public const string WipFovhdAcct = "WipFovhdAcct";
       public const string WipFovhdAcctUnit1 = "WipFovhdAcctUnit1";
       public const string WipFovhdAcctUnit2 = "WipFovhdAcctUnit2";
       public const string WipFovhdAcctUnit3 = "WipFovhdAcctUnit3";
       public const string WipFovhdAcctUnit4 = "WipFovhdAcctUnit4";
       public const string WipFovhdComp = "WipFovhdComp";
       public const string WipFovhdTotal = "WipFovhdTotal";
       public const string WipLbrAcct = "WipLbrAcct";
       public const string WipLbrAcctUnit1 = "WipLbrAcctUnit1";
       public const string WipLbrAcctUnit2 = "WipLbrAcctUnit2";
       public const string WipLbrAcctUnit3 = "WipLbrAcctUnit3";
       public const string WipLbrAcctUnit4 = "WipLbrAcctUnit4";
       public const string WipLbrComp = "WipLbrComp";
       public const string WipLbrTotal = "WipLbrTotal";
       public const string WipMatlComp = "WipMatlComp";
       public const string WipMatlTotal = "WipMatlTotal";
       public const string WipOutAcct = "WipOutAcct";
       public const string WipOutAcctUnit1 = "WipOutAcctUnit1";
       public const string WipOutAcctUnit2 = "WipOutAcctUnit2";
       public const string WipOutAcctUnit3 = "WipOutAcctUnit3";
       public const string WipOutAcctUnit4 = "WipOutAcctUnit4";
       public const string WipOutComp = "WipOutComp";
       public const string WipOutTotal = "WipOutTotal";
       public const string WipSpecial = "WipSpecial";
       public const string WipTotal = "WipTotal";
       public const string WipVovhdAcct = "WipVovhdAcct";
       public const string WipVovhdAcctUnit1 = "WipVovhdAcctUnit1";
       public const string WipVovhdAcctUnit2 = "WipVovhdAcctUnit2";
       public const string WipVovhdAcctUnit3 = "WipVovhdAcctUnit3";
       public const string WipVovhdAcctUnit4 = "WipVovhdAcctUnit4";
       public const string WipVovhdComp = "WipVovhdComp";
       public const string WipVovhdTotal = "WipVovhdTotal";
       public const string ActualCompleteDate = "jobub_midnight_of_job_sch_compdate";


                }
                    
                    public class JobsBuilder  
                :   IdoQueryBuilder<JobsBuilder, JobsFilterExpressionBuilder>
                {
                        public JobsBuilder(IExpressionInterpreter ei) : base(Jobs.IDO_NAME, ei) { }

                      public JobsBuilder CfgMainConfigGid { get {  AddProperty(Jobs.CfgMainConfigGid); return this; } }         
                    public JobsBuilder CfgMainConfigStatus { get {  AddProperty(Jobs.CfgMainConfigStatus); return this; } }     
                        public JobsBuilder ActualCompleteDate { get { AddProperty(Jobs.ActualCompleteDate);
                            return this;}}
                    public JobsBuilder ChFovAccessUnit1 { get {  AddProperty(Jobs.ChFovAccessUnit1); return this; } }         
                    public JobsBuilder ChFovAccessUnit2 { get {  AddProperty(Jobs.ChFovAccessUnit2); return this; } }         
                    public JobsBuilder ChFovAccessUnit3 { get {  AddProperty(Jobs.ChFovAccessUnit3); return this; } }         
                    public JobsBuilder ChFovAccessUnit4 { get {  AddProperty(Jobs.ChFovAccessUnit4); return this; } }         
                    public JobsBuilder ChFovDescription { get {  AddProperty(Jobs.ChFovDescription); return this; } }         
                    public JobsBuilder ChJcbAccessUnit1 { get {  AddProperty(Jobs.ChJcbAccessUnit1); return this; } }         
                    public JobsBuilder ChJcbAccessUnit2 { get {  AddProperty(Jobs.ChJcbAccessUnit2); return this; } }         
                    public JobsBuilder ChJcbAccessUnit3 { get {  AddProperty(Jobs.ChJcbAccessUnit3); return this; } }         
                    public JobsBuilder ChJcbAccessUnit4 { get {  AddProperty(Jobs.ChJcbAccessUnit4); return this; } }         
                    public JobsBuilder ChJcbDescription { get {  AddProperty(Jobs.ChJcbDescription); return this; } }         
                    public JobsBuilder ChLbrAccessUnit1 { get {  AddProperty(Jobs.ChLbrAccessUnit1); return this; } }         
                    public JobsBuilder ChLbrAccessUnit2 { get {  AddProperty(Jobs.ChLbrAccessUnit2); return this; } }         
                    public JobsBuilder ChLbrAccessUnit3 { get {  AddProperty(Jobs.ChLbrAccessUnit3); return this; } }         
                    public JobsBuilder ChLbrAccessUnit4 { get {  AddProperty(Jobs.ChLbrAccessUnit4); return this; } }         
                    public JobsBuilder ChLbrDescription { get {  AddProperty(Jobs.ChLbrDescription); return this; } }         
                    public JobsBuilder ChOutAccessUnit1 { get {  AddProperty(Jobs.ChOutAccessUnit1); return this; } }         
                    public JobsBuilder ChOutAccessUnit2 { get {  AddProperty(Jobs.ChOutAccessUnit2); return this; } }         
                    public JobsBuilder ChOutAccessUnit3 { get {  AddProperty(Jobs.ChOutAccessUnit3); return this; } }         
                    public JobsBuilder ChOutAccessUnit4 { get {  AddProperty(Jobs.ChOutAccessUnit4); return this; } }         
                    public JobsBuilder ChOutDescription { get {  AddProperty(Jobs.ChOutDescription); return this; } }         
                    public JobsBuilder ChVovAccessUnit1 { get {  AddProperty(Jobs.ChVovAccessUnit1); return this; } }         
                    public JobsBuilder ChVovAccessUnit2 { get {  AddProperty(Jobs.ChVovAccessUnit2); return this; } }         
                    public JobsBuilder ChVovAccessUnit3 { get {  AddProperty(Jobs.ChVovAccessUnit3); return this; } }         
                    public JobsBuilder ChVovAccessUnit4 { get {  AddProperty(Jobs.ChVovAccessUnit4); return this; } }         public JobsBuilder ChVovDescription { get {  AddProperty(Jobs.ChVovDescription); return this; } }         public JobsBuilder ChWipAccessUnit1 { get {  AddProperty(Jobs.ChWipAccessUnit1); return this; } }         public JobsBuilder ChWipAccessUnit2 { get {  AddProperty(Jobs.ChWipAccessUnit2); return this; } }         public JobsBuilder ChWipAccessUnit3 { get {  AddProperty(Jobs.ChWipAccessUnit3); return this; } }         public JobsBuilder ChWipAccessUnit4 { get {  AddProperty(Jobs.ChWipAccessUnit4); return this; } }         public JobsBuilder ChWipDescription { get {  AddProperty(Jobs.ChWipDescription); return this; } }         public JobsBuilder ConfigId { get {  AddProperty(Jobs.ConfigId); return this; } }         public JobsBuilder CoProductMix { get {  AddProperty(Jobs.CoProductMix); return this; } }         public JobsBuilder CustNum { get {  AddProperty(Jobs.CustNum); return this; } }         public JobsBuilder DerApsOrderID { get {  AddProperty(Jobs.DerApsOrderID); return this; } }         public JobsBuilder DerASPSearch { get {  AddProperty(Jobs.DerASPSearch); return this; } }         public JobsBuilder DerCriticalRatio { get {  AddProperty(Jobs.DerCriticalRatio); return this; } }         public JobsBuilder DerCurrentBOMExists { get {  AddProperty(Jobs.DerCurrentBOMExists); return this; } }         public JobsBuilder DerCustName { get {  AddProperty(Jobs.DerCustName); return this; } }         public JobsBuilder DerCustNum { get {  AddProperty(Jobs.DerCustNum); return this; } }         public JobsBuilder DerDaysRem { get {  AddProperty(Jobs.DerDaysRem); return this; } }         public JobsBuilder DerDueDate { get {  AddProperty(Jobs.DerDueDate); return this; } }         public JobsBuilder DerEcnPending { get {  AddProperty(Jobs.DerEcnPending); return this; } }         public JobsBuilder DerECNTracked { get {  AddProperty(Jobs.DerECNTracked); return this; } }         public JobsBuilder DerEnableCoProductMix { get {  AddProperty(Jobs.DerEnableCoProductMix); return this; } }         public JobsBuilder DerEnableItem { get {  AddProperty(Jobs.DerEnableItem); return this; } }         public JobsBuilder DerEndDueDate { get {  AddProperty(Jobs.DerEndDueDate); return this; } }         public JobsBuilder DerHasXRef { get {  AddProperty(Jobs.DerHasXRef); return this; } }         public JobsBuilder DerIsScheduled { get {  AddProperty(Jobs.DerIsScheduled); return this; } }         public JobsBuilder DerJobDate { get {  AddProperty(Jobs.DerJobDate); return this; } }         public JobsBuilder DerJobFormatted { get {  AddProperty(Jobs.DerJobFormatted); return this; } }         public JobsBuilder DerJobrouteExists { get {  AddProperty(Jobs.DerJobrouteExists); return this; } }         public JobsBuilder DerJobSuffix { get {  AddProperty(Jobs.DerJobSuffix); return this; } }         public JobsBuilder DerMessageText { get {  AddProperty(Jobs.DerMessageText); return this; } }         public JobsBuilder DerNewCost { get {  AddProperty(Jobs.DerNewCost); return this; } }         public JobsBuilder DerNewStatus { get {  AddProperty(Jobs.DerNewStatus); return this; } }         public JobsBuilder DerOldCost { get {  AddProperty(Jobs.DerOldCost); return this; } }         public JobsBuilder DerOldStat { get {  AddProperty(Jobs.DerOldStat); return this; } }         public JobsBuilder DerOrderDate { get {  AddProperty(Jobs.DerOrderDate); return this; } }         public JobsBuilder DerOrderQty { get {  AddProperty(Jobs.DerOrderQty); return this; } }         public JobsBuilder DerPriority { get {  AddProperty(Jobs.DerPriority); return this; } }         public JobsBuilder DerProspectId { get {  AddProperty(Jobs.DerProspectId); return this; } }         public JobsBuilder DerPsDesc { get {  AddProperty(Jobs.DerPsDesc); return this; } }         public JobsBuilder DerPsItemBOMExists { get {  AddProperty(Jobs.DerPsItemBOMExists); return this; } }         public JobsBuilder DerPsItemRelBOMExists { get {  AddProperty(Jobs.DerPsItemRelBOMExists); return this; } }         public JobsBuilder DerQtyRemaining { get {  AddProperty(Jobs.DerQtyRemaining); return this; } }         public JobsBuilder DerRework { get {  AddProperty(Jobs.DerRework); return this; } }         public JobsBuilder DerStandardBOMExists { get {  AddProperty(Jobs.DerStandardBOMExists); return this; } }         public JobsBuilder DerStatFormatted { get {  AddProperty(Jobs.DerStatFormatted); return this; } }         public JobsBuilder DerStdJobExists { get {  AddProperty(Jobs.DerStdJobExists); return this; } }         public JobsBuilder DerSubJobExists { get {  AddProperty(Jobs.DerSubJobExists); return this; } }         public JobsBuilder DerWorkRem { get {  AddProperty(Jobs.DerWorkRem); return this; } }         public JobsBuilder Description { get {  AddProperty(Jobs.Description); return this; } }         public JobsBuilder EffectDate { get {  AddProperty(Jobs.EffectDate); return this; } }         public JobsBuilder EstJob { get {  AddProperty(Jobs.EstJob); return this; } }         public JobsBuilder EstSuf { get {  AddProperty(Jobs.EstSuf); return this; } }         public JobsBuilder InWorkflow { get {  AddProperty(Jobs.InWorkflow); return this; } }         public JobsBuilder Item { get {  AddProperty(Jobs.Item); return this; } }         public JobsBuilder ItemAutoPost { get {  AddProperty(Jobs.ItemAutoPost); return this; } }         public JobsBuilder ItemCfgModel { get {  AddProperty(Jobs.ItemCfgModel); return this; } }         public JobsBuilder ItemDescription { get {  AddProperty(Jobs.ItemDescription); return this; } }         public JobsBuilder ItemEcnTracked { get {  AddProperty(Jobs.ItemEcnTracked); return this; } }         public JobsBuilder ItemJobConfigurable { get {  AddProperty(Jobs.ItemJobConfigurable); return this; } }         public JobsBuilder ItemJobPostConfig { get {  AddProperty(Jobs.ItemJobPostConfig); return this; } }         public JobsBuilder ItemLotTracked { get {  AddProperty(Jobs.ItemLotTracked); return this; } }         public JobsBuilder ItemPlanFlag { get {  AddProperty(Jobs.ItemPlanFlag); return this; } }         public JobsBuilder ItemSerialPrefix { get {  AddProperty(Jobs.ItemSerialPrefix); return this; } }         public JobsBuilder ItemSerialTracked { get {  AddProperty(Jobs.ItemSerialTracked); return this; } }         public JobsBuilder ItemStat { get {  AddProperty(Jobs.ItemStat); return this; } }         public JobsBuilder ItemTaxFreeMatl { get {  AddProperty(Jobs.ItemTaxFreeMatl); return this; } }         public JobsBuilder JcbAcct { get {  AddProperty(Jobs.JcbAcct); return this; } }         public JobsBuilder JcbAcctUnit1 { get {  AddProperty(Jobs.JcbAcctUnit1); return this; } }         public JobsBuilder JcbAcctUnit2 { get {  AddProperty(Jobs.JcbAcctUnit2); return this; } }         public JobsBuilder JcbAcctUnit3 { get {  AddProperty(Jobs.JcbAcctUnit3); return this; } }         public JobsBuilder JcbAcctUnit4 { get {  AddProperty(Jobs.JcbAcctUnit4); return this; } }         public JobsBuilder Job { get {  AddProperty(Jobs.Job); return this; } }         public JobsBuilder JobDate { get {  AddProperty(Jobs.JobDate); return this; } }         public JobsBuilder JobDescription { get {  AddProperty(Jobs.JobDescription); return this; } }         public JobsBuilder JschCompdate { get {  AddProperty(Jobs.JschCompdate); return this; } }         public JobsBuilder JschEndDate { get {  AddProperty(Jobs.JschEndDate); return this; } }         public JobsBuilder JschEndTick { get {  AddProperty(Jobs.JschEndTick); return this; } }         public JobsBuilder JschPrfreeze { get {  AddProperty(Jobs.JschPrfreeze); return this; } }         public JobsBuilder JschPriority { get {  AddProperty(Jobs.JschPriority); return this; } }         public JobsBuilder JschRecordDate { get {  AddProperty(Jobs.JschRecordDate); return this; } }         public JobsBuilder JschRowPointer { get {  AddProperty(Jobs.JschRowPointer); return this; } }         public JobsBuilder JschStartDate { get {  AddProperty(Jobs.JschStartDate); return this; } }         public JobsBuilder JschStartTick { get {  AddProperty(Jobs.JschStartTick); return this; } }         public JobsBuilder LowLevel { get {  AddProperty(Jobs.LowLevel); return this; } }         public JobsBuilder LstTrxDate { get {  AddProperty(Jobs.LstTrxDate); return this; } }         public JobsBuilder NoteExistsFlag { get {  AddProperty(Jobs.NoteExistsFlag); return this; } }         public JobsBuilder OrdLine { get {  AddProperty(Jobs.OrdLine); return this; } }         public JobsBuilder OrdNum { get {  AddProperty(Jobs.OrdNum); return this; } }         public JobsBuilder OrdRelease { get {  AddProperty(Jobs.OrdRelease); return this; } }         public JobsBuilder OrdType { get {  AddProperty(Jobs.OrdType); return this; } }         public JobsBuilder ParCfgConfigGid { get {  AddProperty(Jobs.ParCfgConfigGid); return this; } }         public JobsBuilder Picked { get {  AddProperty(Jobs.Picked); return this; } }         public JobsBuilder ProCompany { get {  AddProperty(Jobs.ProCompany); return this; } }         public JobsBuilder ProdMix { get {  AddProperty(Jobs.ProdMix); return this; } }         public JobsBuilder ProspectId { get {  AddProperty(Jobs.ProspectId); return this; } }         public JobsBuilder PsNum { get {  AddProperty(Jobs.PsNum); return this; } }         public JobsBuilder QtyComplete { get {  AddProperty(Jobs.QtyComplete); return this; } }         public JobsBuilder QtyReleased { get {  AddProperty(Jobs.QtyReleased); return this; } }         public JobsBuilder QtyScrapped { get {  AddProperty(Jobs.QtyScrapped); return this; } }         public JobsBuilder RecordDate { get {  AddProperty(Jobs.RecordDate); return this; } }         public JobsBuilder RefJob { get {  AddProperty(Jobs.RefJob); return this; } }         public JobsBuilder RefOper { get {  AddProperty(Jobs.RefOper); return this; } }         public JobsBuilder RefSeq { get {  AddProperty(Jobs.RefSeq); return this; } }         public JobsBuilder RefSuf { get {  AddProperty(Jobs.RefSuf); return this; } }         public JobsBuilder Revision { get {  AddProperty(Jobs.Revision); return this; } }         public JobsBuilder Rework { get {  AddProperty(Jobs.Rework); return this; } }         public JobsBuilder RollupDate { get {  AddProperty(Jobs.RollupDate); return this; } }         public JobsBuilder RootJob { get {  AddProperty(Jobs.RootJob); return this; } }         public JobsBuilder RootSuf { get {  AddProperty(Jobs.RootSuf); return this; } }         public JobsBuilder RowPointer { get {  AddProperty(Jobs.RowPointer); return this; } }         public JobsBuilder ShowInDropDownList { get {  AddProperty(Jobs.ShowInDropDownList); return this; } }         public JobsBuilder JobmatlJobs { get {  AddProperty(Jobs.SLJobmatlJobs); return this; } }         public JobsBuilder JobmatlPos { get {  AddProperty(Jobs.SLJobmatlPos); return this; } }         public JobsBuilder JobmatlReqs { get {  AddProperty(Jobs.SLJobmatlReqs); return this; } }         public JobsBuilder Jobmatls { get {  AddProperty(Jobs.SLJobmatls); return this; } }         public JobsBuilder JobmatlTrns { get {  AddProperty(Jobs.SLJobmatlTrns); return this; } }         public JobsBuilder JobRoutes { get {  AddProperty(Jobs.SLJobRoutes); return this; } }         public JobsBuilder Stat { get {  AddProperty(Jobs.Stat); return this; } }         public JobsBuilder Suffix { get {  AddProperty(Jobs.Suffix); return this; } }         public JobsBuilder Type { get {  AddProperty(Jobs.Type); return this; } }         public JobsBuilder UbCopyBOM { get {  AddProperty(Jobs.UbCopyBOM); return this; } }         public JobsBuilder UbDispXRefMsg { get {  AddProperty(Jobs.UbDispXRefMsg); return this; } }         public JobsBuilder UbDispXRefMsg1 { get {  AddProperty(Jobs.UbDispXRefMsg1); return this; } }         public JobsBuilder UbItem { get {  AddProperty(Jobs.UbItem); return this; } }         public JobsBuilder UbJob { get {  AddProperty(Jobs.UbJob); return this; } }         public JobsBuilder UBPerformSubJobDateRecalc { get {  AddProperty(Jobs.UBPerformSubJobDateRecalc); return this; } }         public JobsBuilder UBPlanOnSave { get {  AddProperty(Jobs.UBPlanOnSave); return this; } }         public JobsBuilder UBViewType { get {  AddProperty(Jobs.UBViewType); return this; } }         public JobsBuilder UnlinkedXref { get {  AddProperty(Jobs.UnlinkedXref); return this; } }         public JobsBuilder Whse { get {  AddProperty(Jobs.Whse); return this; } }         public JobsBuilder WipAcct { get {  AddProperty(Jobs.WipAcct); return this; } }         public JobsBuilder WipAcctUnit1 { get {  AddProperty(Jobs.WipAcctUnit1); return this; } }         public JobsBuilder WipAcctUnit2 { get {  AddProperty(Jobs.WipAcctUnit2); return this; } }         public JobsBuilder WipAcctUnit3 { get {  AddProperty(Jobs.WipAcctUnit3); return this; } }         public JobsBuilder WipAcctUnit4 { get {  AddProperty(Jobs.WipAcctUnit4); return this; } }         public JobsBuilder WipComplete { get {  AddProperty(Jobs.WipComplete); return this; } }         public JobsBuilder WipFovhdAcct { get {  AddProperty(Jobs.WipFovhdAcct); return this; } }         public JobsBuilder WipFovhdAcctUnit1 { get {  AddProperty(Jobs.WipFovhdAcctUnit1); return this; } }         public JobsBuilder WipFovhdAcctUnit2 { get {  AddProperty(Jobs.WipFovhdAcctUnit2); return this; } }         public JobsBuilder WipFovhdAcctUnit3 { get {  AddProperty(Jobs.WipFovhdAcctUnit3); return this; } }         public JobsBuilder WipFovhdAcctUnit4 { get {  AddProperty(Jobs.WipFovhdAcctUnit4); return this; } }         public JobsBuilder WipFovhdComp { get {  AddProperty(Jobs.WipFovhdComp); return this; } }         public JobsBuilder WipFovhdTotal { get {  AddProperty(Jobs.WipFovhdTotal); return this; } }         public JobsBuilder WipLbrAcct { get {  AddProperty(Jobs.WipLbrAcct); return this; } }         public JobsBuilder WipLbrAcctUnit1 { get {  AddProperty(Jobs.WipLbrAcctUnit1); return this; } }         public JobsBuilder WipLbrAcctUnit2 { get {  AddProperty(Jobs.WipLbrAcctUnit2); return this; } }         public JobsBuilder WipLbrAcctUnit3 { get {  AddProperty(Jobs.WipLbrAcctUnit3); return this; } }         public JobsBuilder WipLbrAcctUnit4 { get {  AddProperty(Jobs.WipLbrAcctUnit4); return this; } }         public JobsBuilder WipLbrComp { get {  AddProperty(Jobs.WipLbrComp); return this; } }         public JobsBuilder WipLbrTotal { get {  AddProperty(Jobs.WipLbrTotal); return this; } }         public JobsBuilder WipMatlComp { get {  AddProperty(Jobs.WipMatlComp); return this; } }         public JobsBuilder WipMatlTotal { get {  AddProperty(Jobs.WipMatlTotal); return this; } }         public JobsBuilder WipOutAcct { get {  AddProperty(Jobs.WipOutAcct); return this; } }         public JobsBuilder WipOutAcctUnit1 { get {  AddProperty(Jobs.WipOutAcctUnit1); return this; } }         public JobsBuilder WipOutAcctUnit2 { get {  AddProperty(Jobs.WipOutAcctUnit2); return this; } }         public JobsBuilder WipOutAcctUnit3 { get {  AddProperty(Jobs.WipOutAcctUnit3); return this; } }         public JobsBuilder WipOutAcctUnit4 { get {  AddProperty(Jobs.WipOutAcctUnit4); return this; } }         public JobsBuilder WipOutComp { get {  AddProperty(Jobs.WipOutComp); return this; } }         public JobsBuilder WipOutTotal { get {  AddProperty(Jobs.WipOutTotal); return this; } }         public JobsBuilder WipSpecial { get {  AddProperty(Jobs.WipSpecial); return this; } }         public JobsBuilder WipTotal { get {  AddProperty(Jobs.WipTotal); return this; } }         public JobsBuilder WipVovhdAcct { get {  AddProperty(Jobs.WipVovhdAcct); return this; } }         public JobsBuilder WipVovhdAcctUnit1 { get {  AddProperty(Jobs.WipVovhdAcctUnit1); return this; } }         public JobsBuilder WipVovhdAcctUnit2 { get {  AddProperty(Jobs.WipVovhdAcctUnit2); return this; } }         public JobsBuilder WipVovhdAcctUnit3 { get {  AddProperty(Jobs.WipVovhdAcctUnit3); return this; } }         public JobsBuilder WipVovhdAcctUnit4 { get {  AddProperty(Jobs.WipVovhdAcctUnit4); return this; } }         public JobsBuilder WipVovhdComp { get {  AddProperty(Jobs.WipVovhdComp); return this; } }         public JobsBuilder WipVovhdTotal { get {  AddProperty(Jobs.WipVovhdTotal); return this; } }   

                }
                    
                    
                    public class JobsFilterExpressionBuilder  
                :   FilterExpressionBuilder<JobsBuilder>
                {
                        public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> CfgMainConfigGid
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.CfgMainConfigGid); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> CfgMainConfigStatus
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.CfgMainConfigStatus); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChFovAccessUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChFovAccessUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChFovAccessUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChFovAccessUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChFovAccessUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChFovAccessUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChFovAccessUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChFovAccessUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChFovDescription
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChFovDescription); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChJcbAccessUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChJcbAccessUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChJcbAccessUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChJcbAccessUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChJcbAccessUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChJcbAccessUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChJcbAccessUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChJcbAccessUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChJcbDescription
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChJcbDescription); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChLbrAccessUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChLbrAccessUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChLbrAccessUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChLbrAccessUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChLbrAccessUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChLbrAccessUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChLbrAccessUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChLbrAccessUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChLbrDescription
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChLbrDescription); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChOutAccessUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChOutAccessUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChOutAccessUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChOutAccessUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChOutAccessUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChOutAccessUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChOutAccessUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChOutAccessUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChOutDescription
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChOutDescription); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChVovAccessUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChVovAccessUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChVovAccessUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChVovAccessUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChVovAccessUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChVovAccessUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChVovAccessUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChVovAccessUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChVovDescription
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChVovDescription); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChWipAccessUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChWipAccessUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChWipAccessUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChWipAccessUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChWipAccessUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChWipAccessUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChWipAccessUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChWipAccessUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ChWipDescription
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ChWipDescription); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ConfigId
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ConfigId); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> CoProductMix
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.CoProductMix); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> CustNum
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.CustNum); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerApsOrderID
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerApsOrderID); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerASPSearch
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerASPSearch); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerCriticalRatio
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerCriticalRatio); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerCurrentBOMExists
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerCurrentBOMExists); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerCustName
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerCustName); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerCustNum
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerCustNum); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerDaysRem
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerDaysRem); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerDueDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerDueDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerEcnPending
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerEcnPending); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerECNTracked
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerECNTracked); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerEnableCoProductMix
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerEnableCoProductMix); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerEnableItem
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerEnableItem); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerEndDueDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerEndDueDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerHasXRef
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerHasXRef); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerIsScheduled
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerIsScheduled); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerJobDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerJobDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerJobFormatted
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerJobFormatted); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerJobrouteExists
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerJobrouteExists); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerJobSuffix
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerJobSuffix); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerMessageText
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerMessageText); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerNewCost
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerNewCost); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerNewStatus
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerNewStatus); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerOldCost
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerOldCost); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerOldStat
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerOldStat); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerOrderDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerOrderDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerOrderQty
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerOrderQty); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerPriority
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerPriority); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerProspectId
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerProspectId); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerPsDesc
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerPsDesc); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerPsItemBOMExists
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerPsItemBOMExists); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerPsItemRelBOMExists
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerPsItemRelBOMExists); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerQtyRemaining
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerQtyRemaining); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerRework
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerRework); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerStandardBOMExists
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerStandardBOMExists); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerStatFormatted
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerStatFormatted); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerStdJobExists
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerStdJobExists); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerSubJobExists
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerSubJobExists); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> DerWorkRem
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.DerWorkRem); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> Description
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.Description); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> EffectDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.EffectDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> EstJob
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.EstJob); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> EstSuf
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.EstSuf); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.InWorkflow); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> Item
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.Item); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemAutoPost
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemAutoPost); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemCfgModel
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemCfgModel); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemDescription
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemDescription); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemEcnTracked
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemEcnTracked); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemJobConfigurable
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemJobConfigurable); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemJobPostConfig
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemJobPostConfig); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemLotTracked
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemLotTracked); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemPlanFlag
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemPlanFlag); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemSerialPrefix
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemSerialPrefix); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemSerialTracked
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemSerialTracked); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemStat
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemStat); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ItemTaxFreeMatl
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ItemTaxFreeMatl); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JcbAcct
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JcbAcct); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JcbAcctUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JcbAcctUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JcbAcctUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JcbAcctUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JcbAcctUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JcbAcctUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JcbAcctUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JcbAcctUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> Job
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.Job); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JobDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JobDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JobDescription
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JobDescription); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JschCompdate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JschCompdate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JschEndDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JschEndDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JschEndTick
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JschEndTick); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JschPrfreeze
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JschPrfreeze); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JschPriority
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JschPriority); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JschRecordDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JschRecordDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JschRowPointer
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JschRowPointer); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JschStartDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JschStartDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> JschStartTick
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.JschStartTick); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> LowLevel
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.LowLevel); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> LstTrxDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.LstTrxDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.NoteExistsFlag); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> OrdLine
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.OrdLine); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> OrdNum
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.OrdNum); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> OrdRelease
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.OrdRelease); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> OrdType
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.OrdType); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ParCfgConfigGid
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ParCfgConfigGid); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> Picked
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.Picked); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ProCompany
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ProCompany); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ProdMix
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ProdMix); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ProspectId
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ProspectId); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> PsNum
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.PsNum); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> QtyComplete
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.QtyComplete); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> QtyReleased
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.QtyReleased); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> QtyScrapped
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.QtyScrapped); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.RecordDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> RefJob
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.RefJob); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> RefOper
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.RefOper); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> RefSeq
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.RefSeq); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> RefSuf
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.RefSuf); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> Revision
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.Revision); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> Rework
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.Rework); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> RollupDate
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.RollupDate); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> RootJob
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.RootJob); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> RootSuf
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.RootSuf); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.RowPointer); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> ShowInDropDownList
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.ShowInDropDownList); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> SLJobmatlJobs
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.SLJobmatlJobs); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> SLJobmatlPos
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.SLJobmatlPos); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> SLJobmatlReqs
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.SLJobmatlReqs); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> SLJobmatls
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.SLJobmatls); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> SLJobmatlTrns
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.SLJobmatlTrns); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> SLJobRoutes
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.SLJobRoutes); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> Stat
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.Stat); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> Suffix
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.Suffix); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> Type
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.Type); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> UbCopyBOM
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.UbCopyBOM); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> UbDispXRefMsg
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.UbDispXRefMsg); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> UbDispXRefMsg1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.UbDispXRefMsg1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> UbItem
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.UbItem); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> UbJob
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.UbJob); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> UBPerformSubJobDateRecalc
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.UBPerformSubJobDateRecalc); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> UBPlanOnSave
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.UBPlanOnSave); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> UBViewType
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.UBViewType); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> UnlinkedXref
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.UnlinkedXref); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> Whse
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.Whse); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipAcct
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipAcct); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipAcctUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipAcctUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipAcctUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipAcctUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipAcctUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipAcctUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipAcctUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipAcctUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipComplete
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipComplete); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipFovhdAcct
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipFovhdAcct); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipFovhdAcctUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipFovhdAcctUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipFovhdAcctUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipFovhdAcctUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipFovhdAcctUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipFovhdAcctUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipFovhdAcctUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipFovhdAcctUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipFovhdComp
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipFovhdComp); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipFovhdTotal
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipFovhdTotal); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipLbrAcct
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipLbrAcct); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipLbrAcctUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipLbrAcctUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipLbrAcctUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipLbrAcctUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipLbrAcctUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipLbrAcctUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipLbrAcctUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipLbrAcctUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipLbrComp
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipLbrComp); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipLbrTotal
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipLbrTotal); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipMatlComp
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipMatlComp); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipMatlTotal
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipMatlTotal); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipOutAcct
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipOutAcct); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipOutAcctUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipOutAcctUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipOutAcctUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipOutAcctUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipOutAcctUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipOutAcctUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipOutAcctUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipOutAcctUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipOutComp
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipOutComp); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipOutTotal
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipOutTotal); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipSpecial
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipSpecial); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipTotal
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipTotal); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipVovhdAcct
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipVovhdAcct); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipVovhdAcctUnit1
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipVovhdAcctUnit1); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipVovhdAcctUnit2
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipVovhdAcctUnit2); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipVovhdAcctUnit3
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipVovhdAcctUnit3); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipVovhdAcctUnit4
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipVovhdAcctUnit4); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipVovhdComp
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipVovhdComp); }
                    }
                            public FilterExpression<JobsBuilder, JobsFilterExpressionBuilder> WipVovhdTotal
                    {
                        get { return new FilterExpression<JobsBuilder, JobsFilterExpressionBuilder>(_builder, Jobs.WipVovhdTotal); }
                    }
                    

                }
            }