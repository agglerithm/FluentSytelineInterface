using SytelineInterface.Core;

                namespace SytelineInterface.Dsl.Queries
                {
                  public class JobRoutes : IdoConstants 
                { 
                           public const string IDO_NAME = "SLJobRoutes";
       public const string BflushType = "BflushType";
       public const string CdrCustSeq = "CdrCustSeq";
       public const string CntrlPoint = "CntrlPoint";
       public const string Complete = "Complete";
       public const string DerAnyCanAdd = "DerAnyCanAdd";
       public const string DerAnyCanDelete = "DerAnyCanDelete";
       public const string DerAnyCanUpdate = "DerAnyCanUpdate";
       public const string DerApsRoutedId = "DerApsRoutedId";
       public const string DerASPSearch = "DerASPSearch";
       public const string DerAvailableJrtItem = "DerAvailableJrtItem";
       public const string DerCompletedUM = "DerCompletedUM";
       public const string DerHasXRef = "DerHasXRef";
       public const string DerJob = "DerJob";
       public const string DerMovedUM = "DerMovedUM";
       public const string DerOperNum = "DerOperNum";
       public const string DerPSReleaseLbrPosted = "DerPSReleaseLbrPosted";
       public const string DerReadOnlyFlagForStdOper = "DerReadOnlyFlagForStdOper";
       public const string DerReadOnlyForPSOper = "DerReadOnlyForPSOper";
       public const string DerReadOnlyForTypeJ = "DerReadOnlyForTypeJ";
       public const string DerReadOnlyRecordFlag = "DerReadOnlyRecordFlag";
       public const string DerReceivedUM = "DerReceivedUM";
       public const string DerRunLbrHrs = "DerRunLbrHrs";
       public const string DerRunMchHrs = "DerRunMchHrs";
       public const string DerScrappedUM = "DerScrappedUM";
       public const string DerSuffix = "DerSuffix";
       public const string DerTotLbrPct = "DerTotLbrPct";
       public const string DerTotMachPct = "DerTotMachPct";
       public const string DerTotMatPct = "DerTotMatPct";
       public const string EffectDate = "EffectDate";
       public const string Efficiency = "Efficiency";
       public const string FixovhdRate = "FixovhdRate";
       public const string FixovhdTLbr = "FixovhdTLbr";
       public const string FixovhdTMch = "FixovhdTMch";
       public const string FovhdRateMch = "FovhdRateMch";
       public const string InWorkflow = "InWorkflow";
       public const string ItmDescription = "ItmDescription";
       public const string ItmItem = "ItmItem";
       public const string ItmjrtDescription = "ItmjrtDescription";
       public const string ItmjrtItem = "ItmjrtItem";
       public const string ItmjrtTrackEcn = "ItmjrtTrackEcn";
       public const string ItmpsDescription = "ItmpsDescription";
       public const string JbhEndDate = "JbhEndDate";
       public const string Job = "Job";
       public const string JobCoProductMix = "JobCoProductMix";
       public const string JobDescription = "JobDescription";
       public const string JobItem = "JobItem";
       public const string JobJob = "JobJob";
       public const string JobQtyReleased = "JobQtyReleased";
       public const string JobStat = "JobStat";
       public const string JobSuffix = "JobSuffix";
       public const string JobType = "JobType";
       public const string JshAllowReallocation = "JshAllowReallocation";
       public const string JshCrsBrkRule = "JshCrsBrkRule";
       public const string JshEndDate = "JshEndDate";
       public const string JshFinishHrs = "JshFinishHrs";
       public const string JshMatrixType = "JshMatrixType";
       public const string JshMoveHrs = "JshMoveHrs";
       public const string JshOffsetHrs = "JshOffsetHrs";
       public const string JshPcsPerLbrHr = "JshPcsPerLbrHr";
       public const string JshPcsPerMchHr = "JshPcsPerMchHr";
       public const string JshPlannerstep = "JshPlannerstep";
       public const string JshQueueHrs = "JshQueueHrs";
       public const string JshRunLbrHrs = "JshRunLbrHrs";
       public const string JshRunMchHrs = "JshRunMchHrs";
       public const string JshSchedDrv = "JshSchedDrv";
       public const string JshSchedHrs = "JshSchedHrs";
       public const string JshSchedStepRule = "JshSchedStepRule";
       public const string JshSchedTicks = "JshSchedTicks";
       public const string JshSetupHrs = "JshSetupHrs";
       public const string JshSetuprgid = "JshSetuprgid";
       public const string JshSetuprule = "JshSetuprule";
       public const string JshSplitSize = "JshSplitSize";
       public const string JshStartDate = "JshStartDate";
       public const string JshTabid = "JshTabid";
       public const string JshWhenRule = "JshWhenRule";
       public const string NoteExistsFlag = "NoteExistsFlag";
       public const string ObsDate = "ObsDate";
       public const string OperNum = "OperNum";
       public const string PitmItem = "PitmItem";
       public const string PrevEffectDate = "PrevEffectDate";
       public const string PrevObsDate = "PrevObsDate";
       public const string PsPsNum = "PsPsNum";
       public const string PsStat = "PsStat";
       public const string QtyComplete = "QtyComplete";
       public const string QtyMoved = "QtyMoved";
       public const string QtyReceived = "QtyReceived";
       public const string QtyScrapped = "QtyScrapped";
       public const string RecordDate = "RecordDate";
       public const string RowPointer = "RowPointer";
       public const string RunBasisLbr = "RunBasisLbr";
       public const string RunBasisMch = "RunBasisMch";
       public const string RunCostTLbr = "RunCostTLbr";
       public const string RunDur = "RunDur";
       public const string RunHrsTLbr = "RunHrsTLbr";
       public const string RunHrsTMch = "RunHrsTMch";
       public const string RunHrsVLbr = "RunHrsVLbr";
       public const string RunHrsVMch = "RunHrsVMch";
       public const string RunRateLbr = "RunRateLbr";
       public const string ScheduleDriver = "ScheduleDriver";
       public const string SetupCostT = "SetupCostT";
       public const string SetupHrsT = "SetupHrsT";
       public const string SetupHrsV = "SetupHrsV";
       public const string SetupRate = "SetupRate";
       public const string ShowInDropDownList = "ShowInDropDownList";
       public const string SLJrtItems = "SLJrtItems";
       public const string SLJrtResourceGroups = "SLJrtResourceGroups";
       public const string SLWcResourceGroups = "SLWcResourceGroups";
       public const string Suffix = "Suffix";
       public const string Type = "Type";
       public const string UbCurrOperOldRowPtr = "UbCurrOperOldRowPtr";
       public const string UbJobOperOldRowPtr = "UbJobOperOldRowPtr";
       public const string UBPrevJshEndDate = "UBPrevJshEndDate";
       public const string UBPrevJshStartDate = "UBPrevJshStartDate";
       public const string UbProcessId = "UbProcessId";
       public const string UBUpdateResourceGroupFrom = "UBUpdateResourceGroupFrom";
       public const string UseFixedSchedule = "UseFixedSchedule";
       public const string UseOffsetHrs = "UseOffsetHrs";
       public const string VarovhdRate = "VarovhdRate";
       public const string VarovhdTLbr = "VarovhdTLbr";
       public const string VarovhdTMch = "VarovhdTMch";
       public const string VovhdRateMch = "VovhdRateMch";
       public const string Wc = "Wc";
       public const string WcDescription = "WcDescription";
       public const string WcOutside = "WcOutside";
       public const string WcStatus = "WcStatus";
       public const string WipAmt = "WipAmt";
       public const string WipFovhdAmt = "WipFovhdAmt";
       public const string WipLbrAmt = "WipLbrAmt";
       public const string WipMatlAmt = "WipMatlAmt";
       public const string WipOutAmt = "WipOutAmt";
       public const string WipVovhdAmt = "WipVovhdAmt";


                }
                    
                    public class JobRoutesBuilder  
                :   IdoQueryBuilder<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>
                {
                        public JobRoutesBuilder(IExpressionInterpreter ei) : base(JobRoutes.IDO_NAME, ei) { }

                      public JobRoutesBuilder BflushType { get {  AddProperty(JobRoutes.BflushType); return this; } }         
                        public JobRoutesBuilder CdrCustSeq { get {  AddProperty(JobRoutes.CdrCustSeq); return this; } }         
                        public JobRoutesBuilder CntrlPoint { get {  AddProperty(JobRoutes.CntrlPoint); return this; } }         
                        public JobRoutesBuilder Complete { get {  AddProperty(JobRoutes.Complete); return this; } }         
                        public JobRoutesBuilder DerAnyCanAdd { get {  AddProperty(JobRoutes.DerAnyCanAdd); return this; } }         
                        public JobRoutesBuilder DerAnyCanDelete { get {  AddProperty(JobRoutes.DerAnyCanDelete); return this; } }         
                        public JobRoutesBuilder DerAnyCanUpdate { get {  AddProperty(JobRoutes.DerAnyCanUpdate); return this; } }         
                        public JobRoutesBuilder DerApsRoutedId { get {  AddProperty(JobRoutes.DerApsRoutedId); return this; } }         
                        public JobRoutesBuilder DerASPSearch { get {  AddProperty(JobRoutes.DerASPSearch); return this; } }         
                        public JobRoutesBuilder DerAvailableJrtItem { get {  AddProperty(JobRoutes.DerAvailableJrtItem); return this; } }         
                        public JobRoutesBuilder DerCompletedUM { get {  AddProperty(JobRoutes.DerCompletedUM); return this; } }         
                        public JobRoutesBuilder DerHasXRef { get {  AddProperty(JobRoutes.DerHasXRef); return this; } }         
                        public JobRoutesBuilder DerJob { get {  AddProperty(JobRoutes.DerJob); return this; } }         
                        public JobRoutesBuilder DerMovedUM { get {  AddProperty(JobRoutes.DerMovedUM); return this; } }         
                        public JobRoutesBuilder DerOperNum { get {  AddProperty(JobRoutes.DerOperNum); return this; } }         
                        public JobRoutesBuilder DerPSReleaseLbrPosted { get {  AddProperty(JobRoutes.DerPSReleaseLbrPosted); return this; } }         
                        public JobRoutesBuilder DerReadOnlyFlagForStdOper { get {  AddProperty(JobRoutes.DerReadOnlyFlagForStdOper); return this; } }         
                        public JobRoutesBuilder DerReadOnlyForPSOper { get {  AddProperty(JobRoutes.DerReadOnlyForPSOper); return this; } }         
                        public JobRoutesBuilder DerReadOnlyForTypeJ { get {  AddProperty(JobRoutes.DerReadOnlyForTypeJ); return this; } }         
                        public JobRoutesBuilder DerReadOnlyRecordFlag { get {  AddProperty(JobRoutes.DerReadOnlyRecordFlag); return this; } }         
                        public JobRoutesBuilder DerReceivedUM { get {  AddProperty(JobRoutes.DerReceivedUM); return this; } }         
                        public JobRoutesBuilder DerRunLbrHrs { get {  AddProperty(JobRoutes.DerRunLbrHrs); return this; } }         
                        public JobRoutesBuilder DerRunMchHrs { get {  AddProperty(JobRoutes.DerRunMchHrs); return this; } }         
                        public JobRoutesBuilder DerScrappedUM { get {  AddProperty(JobRoutes.DerScrappedUM); return this; } }         
                        public JobRoutesBuilder DerSuffix { get {  AddProperty(JobRoutes.DerSuffix); return this; } }         
                        public JobRoutesBuilder DerTotLbrPct { get {  AddProperty(JobRoutes.DerTotLbrPct); return this; } }         
                        public JobRoutesBuilder DerTotMachPct { get {  AddProperty(JobRoutes.DerTotMachPct); return this; } }         
                        public JobRoutesBuilder DerTotMatPct { get {  AddProperty(JobRoutes.DerTotMatPct); return this; } }         
                        public JobRoutesBuilder EffectDate { get {  AddProperty(JobRoutes.EffectDate); return this; } }         
                        public JobRoutesBuilder Efficiency { get {  AddProperty(JobRoutes.Efficiency); return this; } }         
                        public JobRoutesBuilder FixovhdRate { get {  AddProperty(JobRoutes.FixovhdRate); return this; } }         
                        public JobRoutesBuilder FixovhdTLbr { get {  AddProperty(JobRoutes.FixovhdTLbr); return this; } }         
                        public JobRoutesBuilder FixovhdTMch { get {  AddProperty(JobRoutes.FixovhdTMch); return this; } }         
                        public JobRoutesBuilder FovhdRateMch { get {  AddProperty(JobRoutes.FovhdRateMch); return this; } }         
                        public JobRoutesBuilder InWorkflow { get {  AddProperty(JobRoutes.InWorkflow); return this; } }         
                        public JobRoutesBuilder ItmDescription { get {  AddProperty(JobRoutes.ItmDescription); return this; } }         
                        public JobRoutesBuilder ItmItem { get {  AddProperty(JobRoutes.ItmItem); return this; } }         
                        public JobRoutesBuilder ItmjrtDescription { get {  AddProperty(JobRoutes.ItmjrtDescription); return this; } }         
                        public JobRoutesBuilder ItmjrtItem { get {  AddProperty(JobRoutes.ItmjrtItem); return this; } }         
                        public JobRoutesBuilder ItmjrtTrackEcn { get {  AddProperty(JobRoutes.ItmjrtTrackEcn); return this; } }         
                        public JobRoutesBuilder ItmpsDescription { get {  AddProperty(JobRoutes.ItmpsDescription); return this; } }         
                        public JobRoutesBuilder JbhEndDate { get {  AddProperty(JobRoutes.JbhEndDate); return this; } }         
                        public JobRoutesBuilder Job { get {  AddProperty(JobRoutes.Job); return this; } }         
                        public JobRoutesBuilder JobCoProductMix { get {  AddProperty(JobRoutes.JobCoProductMix); return this; } }         
                        public JobRoutesBuilder JobDescription { get {  AddProperty(JobRoutes.JobDescription); return this; } }         
                        public JobRoutesBuilder JobItem { get {  AddProperty(JobRoutes.JobItem); return this; } }         
                        public JobRoutesBuilder JobJob { get {  AddProperty(JobRoutes.JobJob); return this; } }         
                        public JobRoutesBuilder JobQtyReleased { get {  AddProperty(JobRoutes.JobQtyReleased); return this; } }         
                        public JobRoutesBuilder JobStat { get {  AddProperty(JobRoutes.JobStat); return this; } }         
                        public JobRoutesBuilder JobSuffix { get {  AddProperty(JobRoutes.JobSuffix); return this; } }         
                        public JobRoutesBuilder JobType { get {  AddProperty(JobRoutes.JobType); return this; } }         
                        public JobRoutesBuilder JshAllowReallocation { get {  AddProperty(JobRoutes.JshAllowReallocation); return this; } }         
                        public JobRoutesBuilder JshCrsBrkRule { get {  AddProperty(JobRoutes.JshCrsBrkRule); return this; } }         
                        public JobRoutesBuilder JshEndDate { get {  AddProperty(JobRoutes.JshEndDate); return this; } }         
                        public JobRoutesBuilder JshFinishHrs { get {  AddProperty(JobRoutes.JshFinishHrs); return this; } }         
                        public JobRoutesBuilder JshMatrixType { get {  AddProperty(JobRoutes.JshMatrixType); return this; } }         
                        public JobRoutesBuilder JshMoveHrs { get {  AddProperty(JobRoutes.JshMoveHrs); return this; } }         
                        public JobRoutesBuilder JshOffsetHrs { get {  AddProperty(JobRoutes.JshOffsetHrs); return this; } }         
                        public JobRoutesBuilder JshPcsPerLbrHr { get {  AddProperty(JobRoutes.JshPcsPerLbrHr); return this; } }         
                        public JobRoutesBuilder JshPcsPerMchHr { get {  AddProperty(JobRoutes.JshPcsPerMchHr); return this; } }         
                        public JobRoutesBuilder JshPlannerstep { get {  AddProperty(JobRoutes.JshPlannerstep); return this; } }         
                        public JobRoutesBuilder JshQueueHrs { get {  AddProperty(JobRoutes.JshQueueHrs); return this; } }         
                        public JobRoutesBuilder JshRunLbrHrs { get {  AddProperty(JobRoutes.JshRunLbrHrs); return this; } }         
                        public JobRoutesBuilder JshRunMchHrs { get {  AddProperty(JobRoutes.JshRunMchHrs); return this; } }         
                        public JobRoutesBuilder JshSchedDrv { get {  AddProperty(JobRoutes.JshSchedDrv); return this; } }         
                        public JobRoutesBuilder JshSchedHrs { get {  AddProperty(JobRoutes.JshSchedHrs); return this; } }         
                        public JobRoutesBuilder JshSchedStepRule { get {  AddProperty(JobRoutes.JshSchedStepRule); return this; } }         
                        public JobRoutesBuilder JshSchedTicks { get {  AddProperty(JobRoutes.JshSchedTicks); return this; } }         
                        public JobRoutesBuilder JshSetupHrs { get {  AddProperty(JobRoutes.JshSetupHrs); return this; } }         
                        public JobRoutesBuilder JshSetuprgid { get {  AddProperty(JobRoutes.JshSetuprgid); return this; } }         public JobRoutesBuilder JshSetuprule { get {  AddProperty(JobRoutes.JshSetuprule); return this; } }         public JobRoutesBuilder JshSplitSize { get {  AddProperty(JobRoutes.JshSplitSize); return this; } }         public JobRoutesBuilder JshStartDate { get {  AddProperty(JobRoutes.JshStartDate); return this; } }         public JobRoutesBuilder JshTabid { get {  AddProperty(JobRoutes.JshTabid); return this; } }         public JobRoutesBuilder JshWhenRule { get {  AddProperty(JobRoutes.JshWhenRule); return this; } }         public JobRoutesBuilder NoteExistsFlag { get {  AddProperty(JobRoutes.NoteExistsFlag); return this; } }         public JobRoutesBuilder ObsDate { get {  AddProperty(JobRoutes.ObsDate); return this; } }         public JobRoutesBuilder OperNum { get {  AddProperty(JobRoutes.OperNum); return this; } }         public JobRoutesBuilder PitmItem { get {  AddProperty(JobRoutes.PitmItem); return this; } }         public JobRoutesBuilder PrevEffectDate { get {  AddProperty(JobRoutes.PrevEffectDate); return this; } }         public JobRoutesBuilder PrevObsDate { get {  AddProperty(JobRoutes.PrevObsDate); return this; } }         public JobRoutesBuilder PsPsNum { get {  AddProperty(JobRoutes.PsPsNum); return this; } }         public JobRoutesBuilder PsStat { get {  AddProperty(JobRoutes.PsStat); return this; } }         public JobRoutesBuilder QtyComplete { get {  AddProperty(JobRoutes.QtyComplete); return this; } }         public JobRoutesBuilder QtyMoved { get {  AddProperty(JobRoutes.QtyMoved); return this; } }         public JobRoutesBuilder QtyReceived { get {  AddProperty(JobRoutes.QtyReceived); return this; } }         public JobRoutesBuilder QtyScrapped { get {  AddProperty(JobRoutes.QtyScrapped); return this; } }         public JobRoutesBuilder RecordDate { get {  AddProperty(JobRoutes.RecordDate); return this; } }         public JobRoutesBuilder RowPointer { get {  AddProperty(JobRoutes.RowPointer); return this; } }         public JobRoutesBuilder RunBasisLbr { get {  AddProperty(JobRoutes.RunBasisLbr); return this; } }         public JobRoutesBuilder RunBasisMch { get {  AddProperty(JobRoutes.RunBasisMch); return this; } }         public JobRoutesBuilder RunCostTLbr { get {  AddProperty(JobRoutes.RunCostTLbr); return this; } }         public JobRoutesBuilder RunDur { get {  AddProperty(JobRoutes.RunDur); return this; } }         public JobRoutesBuilder RunHrsTLbr { get {  AddProperty(JobRoutes.RunHrsTLbr); return this; } }         public JobRoutesBuilder RunHrsTMch { get {  AddProperty(JobRoutes.RunHrsTMch); return this; } }         public JobRoutesBuilder RunHrsVLbr { get {  AddProperty(JobRoutes.RunHrsVLbr); return this; } }         public JobRoutesBuilder RunHrsVMch { get {  AddProperty(JobRoutes.RunHrsVMch); return this; } }         public JobRoutesBuilder RunRateLbr { get {  AddProperty(JobRoutes.RunRateLbr); return this; } }         public JobRoutesBuilder ScheduleDriver { get {  AddProperty(JobRoutes.ScheduleDriver); return this; } }         public JobRoutesBuilder SetupCostT { get {  AddProperty(JobRoutes.SetupCostT); return this; } }         public JobRoutesBuilder SetupHrsT { get {  AddProperty(JobRoutes.SetupHrsT); return this; } }         public JobRoutesBuilder SetupHrsV { get {  AddProperty(JobRoutes.SetupHrsV); return this; } }         public JobRoutesBuilder SetupRate { get {  AddProperty(JobRoutes.SetupRate); return this; } }         public JobRoutesBuilder ShowInDropDownList { get {  AddProperty(JobRoutes.ShowInDropDownList); return this; } }         public JobRoutesBuilder JrtItems { get {  AddProperty(JobRoutes.SLJrtItems); return this; } }         public JobRoutesBuilder JrtResourceGroups { get {  AddProperty(JobRoutes.SLJrtResourceGroups); return this; } }         public JobRoutesBuilder WcResourceGroups { get {  AddProperty(JobRoutes.SLWcResourceGroups); return this; } }         public JobRoutesBuilder Suffix { get {  AddProperty(JobRoutes.Suffix); return this; } }         public JobRoutesBuilder Type { get {  AddProperty(JobRoutes.Type); return this; } }         public JobRoutesBuilder UbCurrOperOldRowPtr { get {  AddProperty(JobRoutes.UbCurrOperOldRowPtr); return this; } }         public JobRoutesBuilder UbJobOperOldRowPtr { get {  AddProperty(JobRoutes.UbJobOperOldRowPtr); return this; } }         public JobRoutesBuilder UBPrevJshEndDate { get {  AddProperty(JobRoutes.UBPrevJshEndDate); return this; } }         public JobRoutesBuilder UBPrevJshStartDate { get {  AddProperty(JobRoutes.UBPrevJshStartDate); return this; } }         public JobRoutesBuilder UbProcessId { get {  AddProperty(JobRoutes.UbProcessId); return this; } }         public JobRoutesBuilder UBUpdateResourceGroupFrom { get {  AddProperty(JobRoutes.UBUpdateResourceGroupFrom); return this; } }         public JobRoutesBuilder UseFixedSchedule { get {  AddProperty(JobRoutes.UseFixedSchedule); return this; } }         public JobRoutesBuilder UseOffsetHrs { get {  AddProperty(JobRoutes.UseOffsetHrs); return this; } }         public JobRoutesBuilder VarovhdRate { get {  AddProperty(JobRoutes.VarovhdRate); return this; } }         public JobRoutesBuilder VarovhdTLbr { get {  AddProperty(JobRoutes.VarovhdTLbr); return this; } }         public JobRoutesBuilder VarovhdTMch { get {  AddProperty(JobRoutes.VarovhdTMch); return this; } }         public JobRoutesBuilder VovhdRateMch { get {  AddProperty(JobRoutes.VovhdRateMch); return this; } }         public JobRoutesBuilder Wc { get {  AddProperty(JobRoutes.Wc); return this; } }         public JobRoutesBuilder WcDescription { get {  AddProperty(JobRoutes.WcDescription); return this; } }         public JobRoutesBuilder WcOutside { get {  AddProperty(JobRoutes.WcOutside); return this; } }         public JobRoutesBuilder WcStatus { get {  AddProperty(JobRoutes.WcStatus); return this; } }         public JobRoutesBuilder WipAmt { get {  AddProperty(JobRoutes.WipAmt); return this; } }         public JobRoutesBuilder WipFovhdAmt { get {  AddProperty(JobRoutes.WipFovhdAmt); return this; } }         public JobRoutesBuilder WipLbrAmt { get {  AddProperty(JobRoutes.WipLbrAmt); return this; } }         public JobRoutesBuilder WipMatlAmt { get {  AddProperty(JobRoutes.WipMatlAmt); return this; } }         public JobRoutesBuilder WipOutAmt { get {  AddProperty(JobRoutes.WipOutAmt); return this; } }         public JobRoutesBuilder WipVovhdAmt { get {  AddProperty(JobRoutes.WipVovhdAmt); return this; } }   

                }
                    
                    public class JobRoutesFilterExpressionBuilder  
                :   FilterExpressionBuilder<JobRoutesBuilder>
                {
                        public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> BflushType
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.BflushType); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> CdrCustSeq
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.CdrCustSeq); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> CntrlPoint
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.CntrlPoint); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> Complete
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.Complete); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerAnyCanAdd
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerAnyCanAdd); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerAnyCanDelete
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerAnyCanDelete); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerAnyCanUpdate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerAnyCanUpdate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerApsRoutedId
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerApsRoutedId); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerASPSearch
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerASPSearch); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerAvailableJrtItem
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerAvailableJrtItem); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerCompletedUM
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerCompletedUM); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerHasXRef
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerHasXRef); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerJob
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerJob); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerMovedUM
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerMovedUM); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerOperNum
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerOperNum); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerPSReleaseLbrPosted
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerPSReleaseLbrPosted); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerReadOnlyFlagForStdOper
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerReadOnlyFlagForStdOper); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerReadOnlyForPSOper
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerReadOnlyForPSOper); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerReadOnlyForTypeJ
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerReadOnlyForTypeJ); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerReadOnlyRecordFlag
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerReadOnlyRecordFlag); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerReceivedUM
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerReceivedUM); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerRunLbrHrs
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerRunLbrHrs); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerRunMchHrs
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerRunMchHrs); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerScrappedUM
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerScrappedUM); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerSuffix
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerSuffix); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerTotLbrPct
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerTotLbrPct); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerTotMachPct
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerTotMachPct); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> DerTotMatPct
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.DerTotMatPct); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> EffectDate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.EffectDate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> Efficiency
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.Efficiency); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> FixovhdRate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.FixovhdRate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> FixovhdTLbr
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.FixovhdTLbr); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> FixovhdTMch
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.FixovhdTMch); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> FovhdRateMch
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.FovhdRateMch); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> InWorkflow
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.InWorkflow); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> ItmDescription
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.ItmDescription); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> ItmItem
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.ItmItem); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> ItmjrtDescription
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.ItmjrtDescription); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> ItmjrtItem
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.ItmjrtItem); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> ItmjrtTrackEcn
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.ItmjrtTrackEcn); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> ItmpsDescription
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.ItmpsDescription); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JbhEndDate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JbhEndDate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> Job
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.Job); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JobCoProductMix
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JobCoProductMix); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JobDescription
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JobDescription); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JobItem
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JobItem); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JobJob
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JobJob); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JobQtyReleased
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JobQtyReleased); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JobStat
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JobStat); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JobSuffix
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JobSuffix); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JobType
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JobType); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshAllowReallocation
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshAllowReallocation); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshCrsBrkRule
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshCrsBrkRule); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshEndDate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshEndDate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshFinishHrs
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshFinishHrs); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshMatrixType
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshMatrixType); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshMoveHrs
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshMoveHrs); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshOffsetHrs
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshOffsetHrs); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshPcsPerLbrHr
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshPcsPerLbrHr); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshPcsPerMchHr
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshPcsPerMchHr); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshPlannerstep
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshPlannerstep); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshQueueHrs
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshQueueHrs); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshRunLbrHrs
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshRunLbrHrs); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshRunMchHrs
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshRunMchHrs); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshSchedDrv
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshSchedDrv); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshSchedHrs
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshSchedHrs); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshSchedStepRule
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshSchedStepRule); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshSchedTicks
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshSchedTicks); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshSetupHrs
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshSetupHrs); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshSetuprgid
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshSetuprgid); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshSetuprule
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshSetuprule); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshSplitSize
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshSplitSize); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshStartDate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshStartDate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshTabid
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshTabid); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> JshWhenRule
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.JshWhenRule); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> NoteExistsFlag
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.NoteExistsFlag); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> ObsDate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.ObsDate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> OperNum
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.OperNum); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> PitmItem
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.PitmItem); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> PrevEffectDate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.PrevEffectDate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> PrevObsDate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.PrevObsDate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> PsPsNum
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.PsPsNum); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> PsStat
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.PsStat); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> QtyComplete
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.QtyComplete); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> QtyMoved
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.QtyMoved); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> QtyReceived
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.QtyReceived); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> QtyScrapped
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.QtyScrapped); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> RecordDate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.RecordDate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> RowPointer
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.RowPointer); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> RunBasisLbr
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.RunBasisLbr); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> RunBasisMch
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.RunBasisMch); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> RunCostTLbr
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.RunCostTLbr); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> RunDur
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.RunDur); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> RunHrsTLbr
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.RunHrsTLbr); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> RunHrsTMch
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.RunHrsTMch); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> RunHrsVLbr
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.RunHrsVLbr); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> RunHrsVMch
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.RunHrsVMch); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> RunRateLbr
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.RunRateLbr); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> ScheduleDriver
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.ScheduleDriver); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> SetupCostT
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.SetupCostT); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> SetupHrsT
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.SetupHrsT); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> SetupHrsV
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.SetupHrsV); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> SetupRate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.SetupRate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> ShowInDropDownList
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.ShowInDropDownList); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> SLJrtItems
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.SLJrtItems); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> SLJrtResourceGroups
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.SLJrtResourceGroups); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> SLWcResourceGroups
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.SLWcResourceGroups); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> Suffix
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.Suffix); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> Type
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.Type); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> UbCurrOperOldRowPtr
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.UbCurrOperOldRowPtr); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> UbJobOperOldRowPtr
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.UbJobOperOldRowPtr); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> UBPrevJshEndDate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.UBPrevJshEndDate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> UBPrevJshStartDate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.UBPrevJshStartDate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> UbProcessId
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.UbProcessId); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> UBUpdateResourceGroupFrom
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.UBUpdateResourceGroupFrom); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> UseFixedSchedule
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.UseFixedSchedule); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> UseOffsetHrs
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.UseOffsetHrs); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> VarovhdRate
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.VarovhdRate); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> VarovhdTLbr
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.VarovhdTLbr); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> VarovhdTMch
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.VarovhdTMch); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> VovhdRateMch
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.VovhdRateMch); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> Wc
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.Wc); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> WcDescription
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.WcDescription); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> WcOutside
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.WcOutside); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> WcStatus
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.WcStatus); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> WipAmt
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.WipAmt); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> WipFovhdAmt
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.WipFovhdAmt); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> WipLbrAmt
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.WipLbrAmt); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> WipMatlAmt
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.WipMatlAmt); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> WipOutAmt
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.WipOutAmt); }
                    }
                            public FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder> WipVovhdAmt
                    {
                        get { return new FilterExpression<JobRoutesBuilder, JobRoutesFilterExpressionBuilder>(_builder, JobRoutes.WipVovhdAmt); }
                    }
                    

                }
            }