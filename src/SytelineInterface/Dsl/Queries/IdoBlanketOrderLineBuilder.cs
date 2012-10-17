namespace SytelineInterface.Dsl.Queries
{
    using Commands;
    using SytelineInterface.Core;

    public class BlanketOrderLine : IdoConstants
    {
        public const string IDO_NAME = "SLCoBlns";
        public const string BlanketQty = "BlanketQty";
        public const string BlanketQtyConv = "BlanketQtyConv";
        public const string Cadr01CreditHold = "Cadr01CreditHold";
        public const string Cadr0CorpCred = "Cadr0CorpCred";
        public const string Cadr0CorpCust = "Cadr0CorpCust";
        public const string Cadr0CreditHold = "Cadr0CreditHold";
        public const string CadrCreditHold = "CadrCreditHold";
        public const string CadrCurrCode = "CadrCurrCode";
        public const string CadrName = "CadrName";
        public const string CfgMainConfigGid = "CfgMainConfigGid";
        public const string CfgMainConfigStatus = "CfgMainConfigStatus";
        public const string CoCreditHold = "CoCreditHold";
        public const string CoCustNum = "CoCustNum";
        public const string CoExchRate = "CoExchRate";
        public const string CoExportType = "CoExportType";
        public const string CoLine = "CoLine";
        public const string ConfigId = "ConfigId";
        public const string ContPrice = "ContPrice";
        public const string ContPriceConv = "ContPriceConv";
        public const string OrderNumber = "CoNum";
        public const string OrderDate = "CoOrderDate";
        public const string OrigSite = "CoOrigSite";
        public const string CoPricecode = "CoPricecode";
        public const string Status = "CoStat";
        public const string OrderType = "CoType";
        public const string CurrCstPrcFormat = "CurrCstPrcFormat";
        public const string CustItem = "CustItem";
        public const string DerCadrName = "DerCadrName";
        public const string DerCanChangeItem = "DerCanChangeItem";
        public const string DerCanChangeShipSite = "DerCanChangeShipSite";
        public const string DerHasXRef = "DerHasXRef";
        public const string DerItemFeatTempl = "DerItemFeatTempl";
        public const string Description = "Description";
        public const string EffDate = "EffDate";
        public const string ExpDate = "ExpDate";
        public const string FeatStr = "FeatStr";
        public const string InWorkflow = "InWorkflow";
        public const string Item = "Item";
        public const string ItemAutoPost = "ItemAutoPost";
        public const string ItemCfgModel = "ItemCfgModel";
        public const string ItemCoPostConfig = "ItemCoPostConfig";
        public const string ItemDescription = "ItemDescription";
        public const string ItemKit = "ItemKit";
        public const string ItemOrderConfigurable = "ItemOrderConfigurable";
        public const string ItemPlanFlag = "ItemPlanFlag";
        public const string ItemSerialTracked = "ItemSerialTracked";
        public const string NoteExistsFlag = "NoteExistsFlag";
        public const string ParCfgConfigGid = "ParCfgConfigGid";
        public const string PcoDescription = "PcoDescription";
        public const string Pricecode = "Pricecode";
        public const string PrintKitComponents = "PrintKitComponents";
        public const string PromiseDate = "PromiseDate";
        public const string RecordDate = "RecordDate";
        public const string RowPointer = "RowPointer";
        public const string ShipSite = "ShipSite"; 
        public const string LineStatus = "Stat";
        public const string UBDispMsg = "UBDispMsg";
        public const string UbIncrPrice = "UbIncrPrice";
        public const string UbItemCustAdd = "UbItemCustAdd";
        public const string UbItemCustUpdate = "UbItemCustUpdate";
        public const string UbQtyReleased = "UbQtyReleased";
        public const string UbQtyReserved = "UbQtyReserved";
        public const string UbQtyShipped = "UbQtyShipped";
        public const string UM = "UM";


    }

    public class BlanketOrderLineBuilder
        : IdoQueryBuilder<BlanketOrderLineBuilder, SLCoBlnsFilterExpressionBuilder>
    {
        public BlanketOrderLineBuilder(IExpressionInterpreter interpreter) : base(BlanketOrderLine.IDO_NAME, interpreter) { }

        public BlanketOrderLineBuilder BlanketQty { get { AddProperty(BlanketOrderLine.BlanketQty); return this; } }
        public BlanketOrderLineBuilder BlanketQtyConv { get { AddProperty(BlanketOrderLine.BlanketQtyConv); return this; } }
        public BlanketOrderLineBuilder Cadr01CreditHold { get { AddProperty(BlanketOrderLine.Cadr01CreditHold); return this; } }
        public BlanketOrderLineBuilder Cadr0CorpCred { get { AddProperty(BlanketOrderLine.Cadr0CorpCred); return this; } }
        public BlanketOrderLineBuilder Cadr0CorpCust { get { AddProperty(BlanketOrderLine.Cadr0CorpCust); return this; } }
        public BlanketOrderLineBuilder Cadr0CreditHold { get { AddProperty(BlanketOrderLine.Cadr0CreditHold); return this; } }
        public BlanketOrderLineBuilder CadrCreditHold { get { AddProperty(BlanketOrderLine.CadrCreditHold); return this; } }
        public BlanketOrderLineBuilder CadrCurrCode { get { AddProperty(BlanketOrderLine.CadrCurrCode); return this; } }
        public BlanketOrderLineBuilder CadrName { get { AddProperty(BlanketOrderLine.CadrName); return this; } }
        public BlanketOrderLineBuilder CfgMainConfigGid { get { AddProperty(BlanketOrderLine.CfgMainConfigGid); return this; } }
        public BlanketOrderLineBuilder CfgMainConfigStatus { get { AddProperty(BlanketOrderLine.CfgMainConfigStatus); return this; } }
        public BlanketOrderLineBuilder CoCreditHold { get { AddProperty(BlanketOrderLine.CoCreditHold); return this; } }
        public BlanketOrderLineBuilder CoCustNum { get { AddProperty(BlanketOrderLine.CoCustNum); return this; } }
        public BlanketOrderLineBuilder CoExchRate { get { AddProperty(BlanketOrderLine.CoExchRate); return this; } }
        public BlanketOrderLineBuilder CoExportType { get { AddProperty(BlanketOrderLine.CoExportType); return this; } }
        public BlanketOrderLineBuilder CoLine { get { AddProperty(BlanketOrderLine.CoLine); return this; } }
        public BlanketOrderLineBuilder ConfigId { get { AddProperty(BlanketOrderLine.ConfigId); return this; } }
        public BlanketOrderLineBuilder ContPrice { get { AddProperty(BlanketOrderLine.ContPrice); return this; } }
        public BlanketOrderLineBuilder ContPriceConv { get { AddProperty(BlanketOrderLine.ContPriceConv); return this; } }
        public BlanketOrderLineBuilder OrderNumber { get { AddProperty(BlanketOrderLine.OrderNumber); return this; } }
        public BlanketOrderLineBuilder OrderDate { get { AddProperty(BlanketOrderLine.OrderDate); return this; } }
        public BlanketOrderLineBuilder OrigSite { get { AddProperty(BlanketOrderLine.OrigSite); return this; } }
        public BlanketOrderLineBuilder CoPricecode { get { AddProperty(BlanketOrderLine.CoPricecode); return this; } }
        public BlanketOrderLineBuilder CoStat { get { AddProperty(BlanketOrderLine.Status); return this; } }
        public BlanketOrderLineBuilder OrderType { get { AddProperty(BlanketOrderLine.OrderType); return this; } }
        public BlanketOrderLineBuilder CurrCstPrcFormat { get { AddProperty(BlanketOrderLine.CurrCstPrcFormat); return this; } }
        public BlanketOrderLineBuilder CustItem { get { AddProperty(BlanketOrderLine.CustItem); return this; } }
        public BlanketOrderLineBuilder DerCadrName { get { AddProperty(BlanketOrderLine.DerCadrName); return this; } }
        public BlanketOrderLineBuilder DerCanChangeItem { get { AddProperty(BlanketOrderLine.DerCanChangeItem); return this; } }
        public BlanketOrderLineBuilder DerCanChangeShipSite { get { AddProperty(BlanketOrderLine.DerCanChangeShipSite); return this; } }
        public BlanketOrderLineBuilder DerHasXRef { get { AddProperty(BlanketOrderLine.DerHasXRef); return this; } }
        public BlanketOrderLineBuilder DerItemFeatTempl { get { AddProperty(BlanketOrderLine.DerItemFeatTempl); return this; } }
        public BlanketOrderLineBuilder Description { get { AddProperty(BlanketOrderLine.Description); return this; } }
        public BlanketOrderLineBuilder EffDate { get { AddProperty(BlanketOrderLine.EffDate); return this; } }
        public BlanketOrderLineBuilder ExpDate { get { AddProperty(BlanketOrderLine.ExpDate); return this; } }
        public BlanketOrderLineBuilder FeatStr { get { AddProperty(BlanketOrderLine.FeatStr); return this; } }
        public BlanketOrderLineBuilder InWorkflow { get { AddProperty(BlanketOrderLine.InWorkflow); return this; } }
        public BlanketOrderLineBuilder Item { get { AddProperty(BlanketOrderLine.Item); return this; } }
        public BlanketOrderLineBuilder ItemAutoPost { get { AddProperty(BlanketOrderLine.ItemAutoPost); return this; } }
        public BlanketOrderLineBuilder ItemCfgModel { get { AddProperty(BlanketOrderLine.ItemCfgModel); return this; } }
        public BlanketOrderLineBuilder ItemCoPostConfig { get { AddProperty(BlanketOrderLine.ItemCoPostConfig); return this; } }
        public BlanketOrderLineBuilder ItemDescription { get { AddProperty(BlanketOrderLine.ItemDescription); return this; } }
        public BlanketOrderLineBuilder ItemKit { get { AddProperty(BlanketOrderLine.ItemKit); return this; } }
        public BlanketOrderLineBuilder ItemOrderConfigurable { get { AddProperty(BlanketOrderLine.ItemOrderConfigurable); return this; } }
        public BlanketOrderLineBuilder ItemPlanFlag { get { AddProperty(BlanketOrderLine.ItemPlanFlag); return this; } }
        public BlanketOrderLineBuilder ItemSerialTracked { get { AddProperty(BlanketOrderLine.ItemSerialTracked); return this; } }
        public BlanketOrderLineBuilder NoteExistsFlag { get { AddProperty(BlanketOrderLine.NoteExistsFlag); return this; } }
        public BlanketOrderLineBuilder ParCfgConfigGid { get { AddProperty(BlanketOrderLine.ParCfgConfigGid); return this; } }
        public BlanketOrderLineBuilder PcoDescription { get { AddProperty(BlanketOrderLine.PcoDescription); return this; } }
        public BlanketOrderLineBuilder Pricecode { get { AddProperty(BlanketOrderLine.Pricecode); return this; } }
        public BlanketOrderLineBuilder PrintKitComponents { get { AddProperty(BlanketOrderLine.PrintKitComponents); return this; } }
        public BlanketOrderLineBuilder PromiseDate { get { AddProperty(BlanketOrderLine.PromiseDate); return this; } }
        public BlanketOrderLineBuilder RecordDate { get { AddProperty(BlanketOrderLine.RecordDate); return this; } }
        public BlanketOrderLineBuilder RowPointer { get { AddProperty(BlanketOrderLine.RowPointer); return this; } }
        public BlanketOrderLineBuilder ShipSite { get { AddProperty(BlanketOrderLine.ShipSite); return this; } } 
        public BlanketOrderLineBuilder LineStatus { get { AddProperty(BlanketOrderLine.LineStatus); return this; } }
        public BlanketOrderLineBuilder UBDispMsg { get { AddProperty(BlanketOrderLine.UBDispMsg); return this; } }
        public BlanketOrderLineBuilder UbIncrPrice { get { AddProperty(BlanketOrderLine.UbIncrPrice); return this; } }
        public BlanketOrderLineBuilder UbItemCustAdd { get { AddProperty(BlanketOrderLine.UbItemCustAdd); return this; } }
        public BlanketOrderLineBuilder UbItemCustUpdate { get { AddProperty(BlanketOrderLine.UbItemCustUpdate); return this; } }
        public BlanketOrderLineBuilder UbQtyReleased { get { AddProperty(BlanketOrderLine.UbQtyReleased); return this; } }
        public BlanketOrderLineBuilder UbQtyReserved { get { AddProperty(BlanketOrderLine.UbQtyReserved); return this; } }
        public BlanketOrderLineBuilder UbQtyShipped { get { AddProperty(BlanketOrderLine.UbQtyShipped); return this; } }
        public BlanketOrderLineBuilder UM { get { AddProperty(BlanketOrderLine.UM); return this; } }


    }

    public class SLCoBlnsFilterExpressionBuilder
    : FilterExpressionBuilder<BlanketOrderLineBuilder>
    {
    }

}
