
using Mongoose.IDO.Protocol;
using SytelineInterface.Core;

namespace SytelineInterface.Dsl.Queries
{
    using Commands;

    public class ItemPrice : IdoConstants
    {
        public const string IDO_NAME = "SL.SLItemprices";
        public const string UnitPrice = "UnitPrice1";
        public const string Item = "Item";
        public const string EffectiveDate = "EffectDate";
        public const string BreakPrice1 = "BrkPrice_1";
        public const string BreakQty1 = "BrkQty_1";
        public const string BreakPrice2 = "BrkPrice_2";
        public const string BreakQty2 = "BrkQty_2";
        public const string BreakPrice3 = "BrkPrice_3";
        public const string BreakQty3 = "BrkQty_3";
        public const string BreakPrice4 = "BrkPrice_4";
        public const string BreakQty4 = "BrkQty_4";
        public const string BreakPrice5 = "BrkPrice_5";
        public const string BreakQty5 = "BrkQty_5";
    }

    public class ItemPriceBuilder :
        IdoQueryBuilder<ItemPriceBuilder,ItemPriceFilterExpressionBuilder>
    {
        public ItemPriceBuilder(IExpressionInterpreter ei) : base(ItemPrice.IDO_NAME, ei) { }
        public ItemPriceBuilder UnitPrice { get { AddProperty(ItemPrice.UnitPrice); return this; } }
        public ItemPriceBuilder Item { get { AddProperty(ItemPrice.Item); return this; } }
        public ItemPriceBuilder BreakPrice1 { get { AddProperty(ItemPrice.BreakPrice1); return this; } }
        public ItemPriceBuilder BreakQty1 { get { AddProperty(ItemPrice.BreakQty1); return this; } }
        public ItemPriceBuilder BreakPrice2 { get { AddProperty(ItemPrice.BreakPrice2); return this; } }
        public ItemPriceBuilder BreakQty2 { get { AddProperty(ItemPrice.BreakQty2); return this; } }
        public ItemPriceBuilder BreakPrice3 { get { AddProperty(ItemPrice.BreakPrice3); return this; } }
        public ItemPriceBuilder BreakQty3 { get { AddProperty(ItemPrice.BreakQty3); return this; } }
        public ItemPriceBuilder BreakPrice4 { get { AddProperty(ItemPrice.BreakPrice4); return this; } }
        public ItemPriceBuilder BreakQty4 { get { AddProperty(ItemPrice.BreakQty4); return this; } }
        public ItemPriceBuilder BreakPrice5 { get { AddProperty(ItemPrice.BreakPrice5); return this; } }
        public ItemPriceBuilder BreakQty5 { get { AddProperty(ItemPrice.BreakQty5); return this; } }
        public ItemPriceBuilder EffectiveDate{ get {AddProperty(ItemPrice.EffectiveDate);
            return this;}}
        public ItemPriceBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (ItemPriceBuilder) base.WithChildren(builders);
        }

        public ItemPriceBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (ItemPriceBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class ItemPriceFilterExpressionBuilder : FilterExpressionBuilder<ItemPriceBuilder>
    {
        public FilterExpression<ItemPriceBuilder, ItemPriceFilterExpressionBuilder> UnitPrice
        {
            get { return new FilterExpression<ItemPriceBuilder, ItemPriceFilterExpressionBuilder>(_builder, ItemPrice.UnitPrice); }
        }
        public FilterExpression<ItemPriceBuilder, ItemPriceFilterExpressionBuilder> Item
        {
            get { return new FilterExpression<ItemPriceBuilder, ItemPriceFilterExpressionBuilder>(_builder, ItemPrice.Item); }
        }

    }
}