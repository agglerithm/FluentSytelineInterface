

using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class PullItemValues : IdoCommandBuilder
    {
        public PullItemValues()
            : base(PullItem.IDO_NAME)
        {       

        }

        public PullItemValues  Item (string value) { AddValue(PullItem.Item , value); return this; } 
        public PullItemValues  TriggerPoint (string value) { AddValue(PullItem.TriggerPoint , value); return this; } 
        public PullItemValues  Warehouse(string value) { AddValue(PullItem.Warehouse, value); return this; }
        public override IIdoQueryBuilder GetBuilder()
        {
            return FromSyteline.PullItem.Add(get_property_names());
        }

    }
}