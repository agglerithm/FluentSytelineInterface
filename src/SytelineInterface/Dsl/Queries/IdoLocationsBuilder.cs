using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    public class  Locations : IdoConstants
    {
        public const string IDO_NAME = "SLLocations";
        public const string derIsRankOne = "derIsRankOne";
        public const string derUsedAsTranLoc = "derUsedAsTranLoc";
        public const string Description = "Description";
        public const string InWorkflow = "InWorkflow";
        public const string Loc = "Loc";
        public const string LocType = "LocType";
        public const string MrbFlag = "MrbFlag";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer"; 
        public const string Wc = "Wc";
        public const string WcDescription = "WcDescription";


    }

    public class LocationsBuilder
        : IdoQueryBuilder<LocationsBuilder, SLLocationsFilterExpressionBuilder>
    {
        public LocationsBuilder(IExpressionInterpreter interpreter) : base(Locations.IDO_NAME, interpreter) { }

        public LocationsBuilder derIsRankOne { get { AddProperty(Locations.derIsRankOne); return this; } }
        public LocationsBuilder derUsedAsTranLoc { get { AddProperty(Locations.derUsedAsTranLoc); return this; } }
        public LocationsBuilder Description { get { AddProperty(Locations.Description); return this; } }
        public LocationsBuilder InWorkflow { get { AddProperty(Locations.InWorkflow); return this; } }
        public LocationsBuilder Loc { get { AddProperty(Locations.Loc); return this; } }
        public LocationsBuilder LocType { get { AddProperty(Locations.LocType); return this; } }
        public LocationsBuilder MrbFlag { get { AddProperty(Locations.MrbFlag); return this; } }
        public LocationsBuilder NoteExistsFlag { get { AddProperty(Locations.NoteExistsFlag); return this; } }
        public LocationsBuilder RecordDate { get { AddProperty(Locations.RecordDate); return this; } }
        public LocationsBuilder RowPointer { get { AddProperty(Locations.RowPointer); return this; } } 
        public LocationsBuilder Wc { get { AddProperty(Locations.Wc); return this; } }
        public LocationsBuilder WcDescription { get { AddProperty(Locations.WcDescription); return this; } }


    }

    public class SLLocationsFilterExpressionBuilder
        : FilterExpressionBuilder<LocationsBuilder>
    {
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> derIsRankOne
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.derIsRankOne); }
        }
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> derUsedAsTranLoc
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.derUsedAsTranLoc); }
        }
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> Description
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.Description); }
        }
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> InWorkflow
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.InWorkflow); }
        }
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> Loc
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.Loc); }
        }
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> LocType
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.LocType); }
        }
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> MrbFlag
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.MrbFlag); }
        }
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> NoteExistsFlag
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.NoteExistsFlag); }
        }
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> RecordDate
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.RecordDate); }
        }
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> RowPointer
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.RowPointer); }
        }
 
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> Wc
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.Wc); }
        }
        public FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder> WcDescription
        {
            get { return new FilterExpression<LocationsBuilder, SLLocationsFilterExpressionBuilder>(_builder, Locations.WcDescription); }
        }


    }
}
