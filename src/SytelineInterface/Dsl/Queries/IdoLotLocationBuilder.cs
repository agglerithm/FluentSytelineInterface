using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class LotLocation : IdoConstants
    {
        public const string IDO_NAME = "SLLotLocs";
        public const string DerASPSearch = "DerASPSearch";
        public const string DerTotalCost = "DerTotalCost";
        public const string DerTotalItemWhseOnHand = "DerTotalItemWhseOnHand";
        public const string DerTotalItemWhseReserved = "DerTotalItemWhseReserved";
        public const string DerTotalNonNettableStock = "DerTotalNonNettableStock";
        public const string DerTotalUnitCost = "DerTotalUnitCost";
        public const string FovhdCost = "FovhdCost";
        public const string InWorkflow = "InWorkflow";
        public const string Item = "Item";
        public const string ItemCostMethod = "ItemCostMethod";
        public const string ItemCostType = "ItemCostType";
        public const string ItemDescription = "ItemDescription";
        public const string ItemIssueBy = "ItemIssueBy";
        public const string ItemLotTracked = "ItemLotTracked";
        public const string ItemSerialTracked = "ItemSerialTracked";
        public const string ItemUM = "ItemUM";
        public const string ItmlcLocType = "ItmlcLocType";
        public const string ItwCntInProc = "ItwCntInProc";
        public const string LbrCost = "LbrCost";
        public const string Loc = "Loc";
        public const string LocationDescription = "LocationDescription";
        public const string Lot = "Lot";
        public const string MatlCost = "MatlCost";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string OutCost = "OutCost";
        public const string QtyOnHand = "QtyOnHand";
        public const string QtyRsvd = "QtyRsvd";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string UnitCost = "UnitCost";
        public const string VovhdCost = "VovhdCost";
        public const string Whse = "Whse";
        public const string WhseName = "WhseName";
        public const string WhsePhyInvFlg = "WhsePhyInvFlg";


    }

    public class LotLocationBuilder
        : IdoQueryBuilder<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>
    {
        public LotLocationBuilder(IExpressionInterpreter interpreter) : base(LotLocation.IDO_NAME, interpreter) { }

        public LotLocationBuilder DerASPSearch { get { AddProperty(LotLocation.DerASPSearch); return this; } }
        public LotLocationBuilder DerTotalCost { get { AddProperty(LotLocation.DerTotalCost); return this; } }
        public LotLocationBuilder DerTotalItemWhseOnHand { get { AddProperty(LotLocation.DerTotalItemWhseOnHand); return this; } }
        public LotLocationBuilder DerTotalItemWhseReserved { get { AddProperty(LotLocation.DerTotalItemWhseReserved); return this; } }
        public LotLocationBuilder DerTotalNonNettableStock { get { AddProperty(LotLocation.DerTotalNonNettableStock); return this; } }
        public LotLocationBuilder DerTotalUnitCost { get { AddProperty(LotLocation.DerTotalUnitCost); return this; } }
        public LotLocationBuilder FovhdCost { get { AddProperty(LotLocation.FovhdCost); return this; } }
        public LotLocationBuilder InWorkflow { get { AddProperty(LotLocation.InWorkflow); return this; } }
        public LotLocationBuilder Item { get { AddProperty(LotLocation.Item); return this; } }
        public LotLocationBuilder ItemCostMethod { get { AddProperty(LotLocation.ItemCostMethod); return this; } }
        public LotLocationBuilder ItemCostType { get { AddProperty(LotLocation.ItemCostType); return this; } }
        public LotLocationBuilder ItemDescription { get { AddProperty(LotLocation.ItemDescription); return this; } }
        public LotLocationBuilder ItemIssueBy { get { AddProperty(LotLocation.ItemIssueBy); return this; } }
        public LotLocationBuilder ItemLotTracked { get { AddProperty(LotLocation.ItemLotTracked); return this; } }
        public LotLocationBuilder ItemSerialTracked { get { AddProperty(LotLocation.ItemSerialTracked); return this; } }
        public LotLocationBuilder ItemUM { get { AddProperty(LotLocation.ItemUM); return this; } }
        public LotLocationBuilder ItmlcLocType { get { AddProperty(LotLocation.ItmlcLocType); return this; } }
        public LotLocationBuilder ItwCntInProc { get { AddProperty(LotLocation.ItwCntInProc); return this; } }
        public LotLocationBuilder LbrCost { get { AddProperty(LotLocation.LbrCost); return this; } }
        public LotLocationBuilder Loc { get { AddProperty(LotLocation.Loc); return this; } }
        public LotLocationBuilder LocationDescription { get { AddProperty(LotLocation.LocationDescription); return this; } }
        public LotLocationBuilder Lot { get { AddProperty(LotLocation.Lot); return this; } }
        public LotLocationBuilder MatlCost { get { AddProperty(LotLocation.MatlCost); return this; } }
        public LotLocationBuilder NoteExistsFlag { get { AddProperty(LotLocation.NoteExistsFlag); return this; } }
        public LotLocationBuilder OutCost { get { AddProperty(LotLocation.OutCost); return this; } }
        public LotLocationBuilder QtyOnHand { get { AddProperty(LotLocation.QtyOnHand); return this; } }
        public LotLocationBuilder QtyRsvd { get { AddProperty(LotLocation.QtyRsvd); return this; } }
        public LotLocationBuilder RecordDate { get { AddProperty(LotLocation.RecordDate); return this; } } 
        public LotLocationBuilder UnitCost { get { AddProperty(LotLocation.UnitCost); return this; } }
        public LotLocationBuilder VovhdCost { get { AddProperty(LotLocation.VovhdCost); return this; } }
        public LotLocationBuilder Whse { get { AddProperty(LotLocation.Whse); return this; } }
        public LotLocationBuilder WhseName { get { AddProperty(LotLocation.WhseName); return this; } }
        public LotLocationBuilder WhsePhyInvFlg { get { AddProperty(LotLocation.WhsePhyInvFlg); return this; } }


    }

    public class SLLotLocsFilterExpressionBuilder
        : FilterExpressionBuilder<LotLocationBuilder>
    {
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> DerASPSearch
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.DerASPSearch); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> DerTotalCost
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.DerTotalCost); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> DerTotalItemWhseOnHand
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.DerTotalItemWhseOnHand); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> DerTotalItemWhseReserved
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.DerTotalItemWhseReserved); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> DerTotalNonNettableStock
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.DerTotalNonNettableStock); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> DerTotalUnitCost
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.DerTotalUnitCost); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> FovhdCost
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.FovhdCost); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.InWorkflow); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> Item
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.Item); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> ItemCostMethod
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.ItemCostMethod); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> ItemCostType
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.ItemCostType); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> ItemDescription
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.ItemDescription); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> ItemIssueBy
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.ItemIssueBy); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> ItemLotTracked
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.ItemLotTracked); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> ItemSerialTracked
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.ItemSerialTracked); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> ItemUM
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.ItemUM); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> ItmlcLocType
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.ItmlcLocType); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> ItwCntInProc
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.ItwCntInProc); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> LbrCost
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.LbrCost); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> Loc
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.Loc); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> LocationDescription
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.LocationDescription); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> Lot
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.Lot); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> MatlCost
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.MatlCost); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.NoteExistsFlag); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> OutCost
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.OutCost); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> QtyOnHand
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.QtyOnHand); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> QtyRsvd
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.QtyRsvd); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.RecordDate); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.RowPointer); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> UnitCost
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.UnitCost); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> VovhdCost
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.VovhdCost); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> Whse
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.Whse); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> WhseName
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.WhseName); }
        }
        public FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder> WhsePhyInvFlg
        {
            get { return new FilterExpression<LotLocationBuilder, SLLotLocsFilterExpressionBuilder>(_builder, LotLocation.WhsePhyInvFlg); }
        }


    }
}
