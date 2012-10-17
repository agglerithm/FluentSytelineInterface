using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class IdoJobRoutingSchedules : IdoConstants
    {
        public const string IDO_NAME = "SLJrtSchs";
        public const string CreateDate = "CreateDate";
        public const string CreatedBy = "CreatedBy";
        public const string Crsbrkrule = "Crsbrkrule";
        public const string EndDate = "EndDate";
        public const string EndTick = "EndTick";
        public const string FinishHrs = "FinishHrs";
        public const string FreezeSch = "FreezeSch";
        public const string InWorkflow = "InWorkflow";
        public const string Job = "Job";
        public const string Matrixtype = "Matrixtype";
        public const string MoveHrs = "MoveHrs";
        public const string MoveTicks = "MoveTicks";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string OffsetHrs = "OffsetHrs";
        public const string OperNum = "OperNum";
        public const string PcsPerLbrHr = "PcsPerLbrHr";
        public const string PcsPerMchHr = "PcsPerMchHr";
        public const string Plannerstep = "Plannerstep";
        public const string QueueHrs = "QueueHrs";
        public const string QueueTicks = "QueueTicks";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string RunLbrHrs = "RunLbrHrs";
        public const string RunMchHrs = "RunMchHrs";
        public const string RunTicksLbr = "RunTicksLbr";
        public const string RunTicksMch = "RunTicksMch";
        public const string SchedDrv = "SchedDrv";
        public const string SchedHrs = "SchedHrs";
        public const string SchedOff = "SchedOff";
        public const string Schedsteprule = "Schedsteprule";
        public const string SchedTicks = "SchedTicks";
        public const string SetupHrs = "SetupHrs";
        public const string Setuprgid = "Setuprgid";
        public const string Setuprule = "Setuprule";
        public const string SetupTicks = "SetupTicks";
        public const string Splitsize = "Splitsize";
        public const string StartDate = "StartDate";
        public const string StartTick = "StartTick";
        public const string Suffix = "Suffix";
        public const string Tabid = "Tabid";
        public const string UpdatedBy = "UpdatedBy";
        public const string Whenrule = "Whenrule";


    }

    public class IdoJobRoutingSchedulesBuilder
        : IdoQueryBuilder<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>
    {
        public IdoJobRoutingSchedulesBuilder(IExpressionInterpreter interpreter) : base(IdoJobRoutingSchedules.IDO_NAME, interpreter) { }

        public IdoJobRoutingSchedulesBuilder CreateDate { get { AddProperty(IdoJobRoutingSchedules.CreateDate); return this; } }
        public IdoJobRoutingSchedulesBuilder CreatedBy { get { AddProperty(IdoJobRoutingSchedules.CreatedBy); return this; } }
        public IdoJobRoutingSchedulesBuilder Crsbrkrule { get { AddProperty(IdoJobRoutingSchedules.Crsbrkrule); return this; } }
        public IdoJobRoutingSchedulesBuilder EndDate { get { AddProperty(IdoJobRoutingSchedules.EndDate); return this; } }
        public IdoJobRoutingSchedulesBuilder EndTick { get { AddProperty(IdoJobRoutingSchedules.EndTick); return this; } }
        public IdoJobRoutingSchedulesBuilder FinishHrs { get { AddProperty(IdoJobRoutingSchedules.FinishHrs); return this; } }
        public IdoJobRoutingSchedulesBuilder FreezeSch { get { AddProperty(IdoJobRoutingSchedules.FreezeSch); return this; } }
        public IdoJobRoutingSchedulesBuilder InWorkflow { get { AddProperty(IdoJobRoutingSchedules.InWorkflow); return this; } }
        public IdoJobRoutingSchedulesBuilder Job { get { AddProperty(IdoJobRoutingSchedules.Job); return this; } }
        public IdoJobRoutingSchedulesBuilder Matrixtype { get { AddProperty(IdoJobRoutingSchedules.Matrixtype); return this; } }
        public IdoJobRoutingSchedulesBuilder MoveHrs { get { AddProperty(IdoJobRoutingSchedules.MoveHrs); return this; } }
        public IdoJobRoutingSchedulesBuilder MoveTicks { get { AddProperty(IdoJobRoutingSchedules.MoveTicks); return this; } }
        public IdoJobRoutingSchedulesBuilder NoteExistsFlag { get { AddProperty(IdoJobRoutingSchedules.NoteExistsFlag); return this; } }
        public IdoJobRoutingSchedulesBuilder OffsetHrs { get { AddProperty(IdoJobRoutingSchedules.OffsetHrs); return this; } }
        public IdoJobRoutingSchedulesBuilder OperNum { get { AddProperty(IdoJobRoutingSchedules.OperNum); return this; } }
        public IdoJobRoutingSchedulesBuilder PcsPerLbrHr { get { AddProperty(IdoJobRoutingSchedules.PcsPerLbrHr); return this; } }
        public IdoJobRoutingSchedulesBuilder PcsPerMchHr { get { AddProperty(IdoJobRoutingSchedules.PcsPerMchHr); return this; } }
        public IdoJobRoutingSchedulesBuilder Plannerstep { get { AddProperty(IdoJobRoutingSchedules.Plannerstep); return this; } }
        public IdoJobRoutingSchedulesBuilder QueueHrs { get { AddProperty(IdoJobRoutingSchedules.QueueHrs); return this; } }
        public IdoJobRoutingSchedulesBuilder QueueTicks { get { AddProperty(IdoJobRoutingSchedules.QueueTicks); return this; } }
        public IdoJobRoutingSchedulesBuilder RecordDate { get { AddProperty(IdoJobRoutingSchedules.RecordDate); return this; } }
        public IdoJobRoutingSchedulesBuilder RowPointer { get { AddProperty(IdoJobRoutingSchedules.RowPointer); return this; } }
        public IdoJobRoutingSchedulesBuilder RunLbrHrs { get { AddProperty(IdoJobRoutingSchedules.RunLbrHrs); return this; } }
        public IdoJobRoutingSchedulesBuilder RunMchHrs { get { AddProperty(IdoJobRoutingSchedules.RunMchHrs); return this; } }
        public IdoJobRoutingSchedulesBuilder RunTicksLbr { get { AddProperty(IdoJobRoutingSchedules.RunTicksLbr); return this; } }
        public IdoJobRoutingSchedulesBuilder RunTicksMch { get { AddProperty(IdoJobRoutingSchedules.RunTicksMch); return this; } }
        public IdoJobRoutingSchedulesBuilder SchedDrv { get { AddProperty(IdoJobRoutingSchedules.SchedDrv); return this; } }
        public IdoJobRoutingSchedulesBuilder SchedHrs { get { AddProperty(IdoJobRoutingSchedules.SchedHrs); return this; } }
        public IdoJobRoutingSchedulesBuilder SchedOff { get { AddProperty(IdoJobRoutingSchedules.SchedOff); return this; } }
        public IdoJobRoutingSchedulesBuilder Schedsteprule { get { AddProperty(IdoJobRoutingSchedules.Schedsteprule); return this; } }
        public IdoJobRoutingSchedulesBuilder SchedTicks { get { AddProperty(IdoJobRoutingSchedules.SchedTicks); return this; } }
        public IdoJobRoutingSchedulesBuilder SetupHrs { get { AddProperty(IdoJobRoutingSchedules.SetupHrs); return this; } }
        public IdoJobRoutingSchedulesBuilder Setuprgid { get { AddProperty(IdoJobRoutingSchedules.Setuprgid); return this; } }
        public IdoJobRoutingSchedulesBuilder Setuprule { get { AddProperty(IdoJobRoutingSchedules.Setuprule); return this; } }
        public IdoJobRoutingSchedulesBuilder SetupTicks { get { AddProperty(IdoJobRoutingSchedules.SetupTicks); return this; } }
        public IdoJobRoutingSchedulesBuilder Splitsize { get { AddProperty(IdoJobRoutingSchedules.Splitsize); return this; } }
        public IdoJobRoutingSchedulesBuilder StartDate { get { AddProperty(IdoJobRoutingSchedules.StartDate); return this; } }
        public IdoJobRoutingSchedulesBuilder StartTick { get { AddProperty(IdoJobRoutingSchedules.StartTick); return this; } }
        public IdoJobRoutingSchedulesBuilder Suffix { get { AddProperty(IdoJobRoutingSchedules.Suffix); return this; } }
        public IdoJobRoutingSchedulesBuilder Tabid { get { AddProperty(IdoJobRoutingSchedules.Tabid); return this; } }
        public IdoJobRoutingSchedulesBuilder UpdatedBy { get { AddProperty(IdoJobRoutingSchedules.UpdatedBy); return this; } }
        public IdoJobRoutingSchedulesBuilder Whenrule { get { AddProperty(IdoJobRoutingSchedules.Whenrule); return this; } }


    }

    public class SLJrtSchsFilterExpressionBuilder
        : FilterExpressionBuilder<IdoJobRoutingSchedulesBuilder>
    {
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> CreateDate
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.CreateDate); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> CreatedBy
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.CreatedBy); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> Crsbrkrule
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.Crsbrkrule); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> EndDate
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.EndDate); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> EndTick
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.EndTick); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> FinishHrs
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.FinishHrs); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> FreezeSch
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.FreezeSch); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.InWorkflow); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> Job
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.Job); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> Matrixtype
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.Matrixtype); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> MoveHrs
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.MoveHrs); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> MoveTicks
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.MoveTicks); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.NoteExistsFlag); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> OffsetHrs
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.OffsetHrs); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> OperNum
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.OperNum); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> PcsPerLbrHr
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.PcsPerLbrHr); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> PcsPerMchHr
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.PcsPerMchHr); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> Plannerstep
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.Plannerstep); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> QueueHrs
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.QueueHrs); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> QueueTicks
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.QueueTicks); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.RecordDate); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.RowPointer); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> RunLbrHrs
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.RunLbrHrs); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> RunMchHrs
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.RunMchHrs); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> RunTicksLbr
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.RunTicksLbr); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> RunTicksMch
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.RunTicksMch); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> SchedDrv
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.SchedDrv); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> SchedHrs
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.SchedHrs); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> SchedOff
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.SchedOff); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> Schedsteprule
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.Schedsteprule); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> SchedTicks
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.SchedTicks); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> SetupHrs
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.SetupHrs); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> Setuprgid
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.Setuprgid); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> Setuprule
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.Setuprule); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> SetupTicks
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.SetupTicks); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> Splitsize
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.Splitsize); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> StartDate
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.StartDate); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> StartTick
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.StartTick); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> Suffix
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.Suffix); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> Tabid
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.Tabid); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> UpdatedBy
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.UpdatedBy); }
        }
        public FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder> Whenrule
        {
            get { return new FilterExpression<IdoJobRoutingSchedulesBuilder, SLJrtSchsFilterExpressionBuilder>(_builder, IdoJobRoutingSchedules.Whenrule); }
        }


    }
}
