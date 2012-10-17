using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class  Terms : IdoConstants
    {
        public const string IDO_NAME = "SLTerms";
        public const string Advanced = "Advanced";
        public const string CashOnly = "CashOnly";
        public const string DerDiscDays = "DerDiscDays";
        public const string DerDiscPct = "DerDiscPct";
        public const string DerTotalPercent = "DerTotalPercent";
        public const string DerUseMultiDueDates = "DerUseMultiDueDates";
        public const string Description = "Description";
        public const string DiscDays = "DiscDays";
        public const string DiscPct = "DiscPct";
        public const string DueDays = "DueDays";
        public const string InWorkflow = "InWorkflow";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string ProxCode = "ProxCode";
        public const string ProxDay = "ProxDay";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string SLTermsSeqs = "SLTermsSeqs";
        public const string TaxDisc = "TaxDisc";
        public const string TermsCode = "TermsCode";
        public const string UseMultiDueDates = "UseMultiDueDates";


    }

    public class TermsBuilder
        : IdoQueryBuilder<TermsBuilder, SLTermsFilterExpressionBuilder>
    {
        public TermsBuilder(IExpressionInterpreter interpreter) : base(Terms.IDO_NAME, interpreter) { }

        public TermsBuilder Advanced { get { AddProperty(Terms.Advanced); return this; } }
        public TermsBuilder CashOnly { get { AddProperty(Terms.CashOnly); return this; } }
        public TermsBuilder DerDiscDays { get { AddProperty(Terms.DerDiscDays); return this; } }
        public TermsBuilder DerDiscPct { get { AddProperty(Terms.DerDiscPct); return this; } }
        public TermsBuilder DerTotalPercent { get { AddProperty(Terms.DerTotalPercent); return this; } }
        public TermsBuilder DerUseMultiDueDates { get { AddProperty(Terms.DerUseMultiDueDates); return this; } }
        public TermsBuilder Description { get { AddProperty(Terms.Description); return this; } }
        public TermsBuilder DiscDays { get { AddProperty(Terms.DiscDays); return this; } }
        public TermsBuilder DiscPct { get { AddProperty(Terms.DiscPct); return this; } }
        public TermsBuilder DueDays { get { AddProperty(Terms.DueDays); return this; } }
        public TermsBuilder InWorkflow { get { AddProperty(Terms.InWorkflow); return this; } }
        public TermsBuilder NoteExistsFlag { get { AddProperty(Terms.NoteExistsFlag); return this; } }
        public TermsBuilder ProxCode { get { AddProperty(Terms.ProxCode); return this; } }
        public TermsBuilder ProxDay { get { AddProperty(Terms.ProxDay); return this; } }
        public TermsBuilder RecordDate { get { AddProperty(Terms.RecordDate); return this; } }
        public TermsBuilder RowPointer { get { AddProperty(Terms.RowPointer); return this; } }
        public TermsBuilder SLTermsSeqs { get { AddProperty(Terms.SLTermsSeqs); return this; } }
        public TermsBuilder TaxDisc { get { AddProperty(Terms.TaxDisc); return this; } }
        public TermsBuilder TermsCode { get { AddProperty(Terms.TermsCode); return this; } }
        public TermsBuilder UseMultiDueDates { get { AddProperty(Terms.UseMultiDueDates); return this; } }


    }

    public class SLTermsFilterExpressionBuilder
        : FilterExpressionBuilder<TermsBuilder>
    {
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> Advanced
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.Advanced); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> CashOnly
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.CashOnly); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> DerDiscDays
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.DerDiscDays); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> DerDiscPct
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.DerDiscPct); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> DerTotalPercent
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.DerTotalPercent); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> DerUseMultiDueDates
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.DerUseMultiDueDates); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> Description
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.Description); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> DiscDays
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.DiscDays); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> DiscPct
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.DiscPct); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> DueDays
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.DueDays); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.InWorkflow); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.NoteExistsFlag); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> ProxCode
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.ProxCode); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> ProxDay
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.ProxDay); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.RecordDate); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.RowPointer); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> SLTermsSeqs
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.SLTermsSeqs); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> TaxDisc
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.TaxDisc); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> TermsCode
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.TermsCode); }
        }
        public FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder> UseMultiDueDates
        {
            get { return new FilterExpression<TermsBuilder, SLTermsFilterExpressionBuilder>(_builder, Terms.UseMultiDueDates); }
        }


    }
}
