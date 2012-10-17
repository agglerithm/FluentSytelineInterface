 

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class ItemForecast : IdoConstants
    {
        public const string IDO_NAME = "SLForecasts";
        public const string AvailQty = "AvailQty";
        public const string CreateDate = "CreateDate";
        public const string CreatedBy = "CreatedBy"; 
        public const string ForecastDate = "FcstDate";
        public const string InWorkflow = "InWorkflow";
        public const string Item = "Item";
        public const string ItemDescription = "ItemDescription";
        public const string ItemUOM = "ItemUM";
        public const string NoteExists = "NoteExistsFlag";
        public const string OrigQty = "OrigQty";
        public const string ProjectedDate = "ProjectedDate";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string Status = "Stat";
        public const string UpdatedBy = "UpdatedBy"; 
    }

    public class ItemForecastBuilder :
        IdoQueryBuilder<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>
    {
        public ItemForecastBuilder(IExpressionInterpreter ei) : base(ItemForecast.IDO_NAME, ei) { }

        public ItemForecastBuilder AvailQty { get { AddProperty(ItemForecast.AvailQty); return this; } }
        public ItemForecastBuilder CreateDate { get { AddProperty(ItemForecast.CreateDate); return this; } }
        public ItemForecastBuilder CreatedBy { get { AddProperty(ItemForecast.CreatedBy); return this; } } 
        public ItemForecastBuilder ForecastDate { get { AddProperty(ItemForecast.ForecastDate); return this; } }
        public ItemForecastBuilder InWorkflow { get { AddProperty(ItemForecast.InWorkflow); return this; } }
        public ItemForecastBuilder Item { get { AddProperty(ItemForecast.Item); return this; } }
        public ItemForecastBuilder ItemDescription { get { AddProperty(ItemForecast.ItemDescription); return this; } }
        public ItemForecastBuilder ItemUOM { get { AddProperty(ItemForecast.ItemUOM); return this; } }
        public ItemForecastBuilder NoteExists { get { AddProperty(ItemForecast.NoteExists); return this; } }
        public ItemForecastBuilder OrigQty { get { AddProperty(ItemForecast.OrigQty); return this; } }
        public ItemForecastBuilder ProjectedDate { get { AddProperty(ItemForecast.ProjectedDate); return this; } }
        public ItemForecastBuilder RecordDate { get { AddProperty(ItemForecast.RecordDate); return this; } }
        public new ItemForecastBuilder RowPointer { get { AddProperty(ItemForecast.RowPointer); return this; } }
        public ItemForecastBuilder Status { get { AddProperty(ItemForecast.Status); return this; } }
        public ItemForecastBuilder UpdatedBy { get { AddProperty(ItemForecast.UpdatedBy); return this; } }
 

        public ItemForecastBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (ItemForecastBuilder) base.WithChildren(builders);
        }

        public ItemForecastBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (ItemForecastBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class ItemForecastFilterExpressionBuilder  : FilterExpressionBuilder<ItemForecastBuilder>
    {
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> AvailQty{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.AvailQty);  }  } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> CreateDate{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.CreateDate);  }  } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> CreatedBy{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.CreatedBy);  }  }
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> ForecastDate { get { return new FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.ForecastDate); } } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> InWorkflow{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.InWorkflow);  }  } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> Item{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.Item);  }  } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> ItemDescription{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.ItemDescription);  }  } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> ItemUOM{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.ItemUOM);  }  } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> NoteExists{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.NoteExists);  }  } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> OrigQty{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.OrigQty);  }  } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> ProjectedDate{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.ProjectedDate);  }  } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> RecordDate{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.RecordDate);  }  } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> RowPointer{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.RowPointer);  }  } 
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> Status{ get { return new FilterExpression<ItemForecastBuilder,ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.Status);  }  }
        public FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder> UpdatedBy { get { return new FilterExpression<ItemForecastBuilder, ItemForecastFilterExpressionBuilder>(_builder, ItemForecast.UpdatedBy); } } 
    }
}