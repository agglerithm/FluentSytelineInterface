

using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class ItemForecastValues : IdoCommandBuilder
    {
        public ItemForecastValues()
            : base(ItemForecast.IDO_NAME)
        {
        }

        public ItemForecastValues AvailQty(string value) { AddValue(ItemForecast.AvailQty, value); return this; }
        public ItemForecastValues CreateDate(string value) { AddValue(ItemForecast.CreateDate, value); return this; }
        public ItemForecastValues CreatedBy(string value) { AddValue(ItemForecast.CreatedBy, value); return this; }
        public ItemForecastValues ForecastDate(string value) { AddValue(ItemForecast.ForecastDate, value); return this; }
        public ItemForecastValues InWorkflow(string value) { AddValue(ItemForecast.InWorkflow, value); return this; }
        public ItemForecastValues Item(string value) { AddValue(ItemForecast.Item, value); return this; }
        public ItemForecastValues ItemDescription(string value) { AddValue(ItemForecast.ItemDescription, value); return this; }
        public ItemForecastValues ItemUOM(string value) { AddValue(ItemForecast.ItemUOM, value); return this; }
        public ItemForecastValues NoteExists(string value) { AddValue(ItemForecast.NoteExists, value); return this; }
        public ItemForecastValues OrigQty(string value) { AddValue(ItemForecast.OrigQty, value); return this; }
        public ItemForecastValues ProjectedDate(string value) { AddValue(ItemForecast.ProjectedDate, value); return this; }
        public ItemForecastValues RecordDate(string value) { AddValue(ItemForecast.RecordDate, value); return this; }
        public ItemForecastValues RowPointer(string value) { AddValue(ItemForecast.RowPointer, value); return this; }
        public ItemForecastValues Status(string value) { AddValue(ItemForecast.Status, value); return this; }
        public ItemForecastValues UpdatedBy(string value) { AddValue(ItemForecast.UpdatedBy, value); return this; } 
        public override IIdoQueryBuilder GetBuilder()
        {
            return FromSyteline.ItemForecast.Add(get_property_names());
        }
    }
}