using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    public class UnitOfMeasureConversions : IdoConstants
    {
        public const string IDO_NAME = "SLUMConvs";
        public const string ConvFactor = "ConvFactor";
        public const string CustVendName = "CustVendName";
        public const string FromDesc = "FromDesc";
        public const string FromUM = "FromUM";
        public const string InWorkflow = "InWorkflow";
        public const string Item = "Item";
        public const string ItemDesc = "ItemDesc";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string ToDesc = "ToDesc";
        public const string ToUM = "ToUM";
        public const string Type = "Type";
        public const string VendNum = "VendNum";


    }

    public class UnitOfMeasureConversionsBuilder
        : IdoQueryBuilder<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>
    {
        public UnitOfMeasureConversionsBuilder(IExpressionInterpreter interpreter) : base(UnitOfMeasureConversions.IDO_NAME, interpreter) { }

        public UnitOfMeasureConversionsBuilder ConvFactor { get { AddProperty(UnitOfMeasureConversions.ConvFactor); return this; } }
        public UnitOfMeasureConversionsBuilder CustVendName { get { AddProperty(UnitOfMeasureConversions.CustVendName); return this; } }
        public UnitOfMeasureConversionsBuilder FromDesc { get { AddProperty(UnitOfMeasureConversions.FromDesc); return this; } }
        public UnitOfMeasureConversionsBuilder FromUM { get { AddProperty(UnitOfMeasureConversions.FromUM); return this; } }
        public UnitOfMeasureConversionsBuilder InWorkflow { get { AddProperty(UnitOfMeasureConversions.InWorkflow); return this; } }
        public UnitOfMeasureConversionsBuilder Item { get { AddProperty(UnitOfMeasureConversions.Item); return this; } }
        public UnitOfMeasureConversionsBuilder ItemDesc { get { AddProperty(UnitOfMeasureConversions.ItemDesc); return this; } }
        public UnitOfMeasureConversionsBuilder NoteExistsFlag { get { AddProperty(UnitOfMeasureConversions.NoteExistsFlag); return this; } }
        public UnitOfMeasureConversionsBuilder RecordDate { get { AddProperty(UnitOfMeasureConversions.RecordDate); return this; } }
        public UnitOfMeasureConversionsBuilder RowPointer { get { AddProperty(UnitOfMeasureConversions.RowPointer); return this; } }
        public UnitOfMeasureConversionsBuilder ToDesc { get { AddProperty(UnitOfMeasureConversions.ToDesc); return this; } }
        public UnitOfMeasureConversionsBuilder ToUM { get { AddProperty(UnitOfMeasureConversions.ToUM); return this; } }
        public UnitOfMeasureConversionsBuilder Type { get { AddProperty(UnitOfMeasureConversions.Type); return this; } }
        public UnitOfMeasureConversionsBuilder VendNum { get { AddProperty(UnitOfMeasureConversions.VendNum); return this; } }


    }

    public class SLUMConvsFilterExpressionBuilder
        : FilterExpressionBuilder<UnitOfMeasureConversionsBuilder>
    {
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> ConvFactor
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.ConvFactor); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> CustVendName
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.CustVendName); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> FromDesc
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.FromDesc); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> FromUM
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.FromUM); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.InWorkflow); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> Item
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.Item); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> ItemDesc
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.ItemDesc); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.NoteExistsFlag); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.RecordDate); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.RowPointer); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> ToDesc
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.ToDesc); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> ToUM
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.ToUM); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> Type
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.Type); }
        }
        public FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder> VendNum
        {
            get { return new FilterExpression<UnitOfMeasureConversionsBuilder, SLUMConvsFilterExpressionBuilder>(_builder, UnitOfMeasureConversions.VendNum); }
        }


    }
}
