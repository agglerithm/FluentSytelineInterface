using System;

using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl
{
    public static class FromSyteline
    {
 
        public static class AllSites
        {
            
        }

        public static ARPaymentsBuilder ARPayments
        {
            get { return new ARPaymentsBuilder(ExpressionInterpreter.Build()); }
        }

        public static ARPaymentDetailBuilder ARPaymentDetail
        {
            get { return new ARPaymentDetailBuilder(ExpressionInterpreter.Build()); }
        }

        public static WarehouseBuilder Warehouses
        {
            get { return new WarehouseBuilder(ExpressionInterpreter.Build()); }
        }

        public static CustomerOrderLineItemBuilder CustomerOrderLineItems
        {
            get { return new CustomerOrderLineItemBuilder(ExpressionInterpreter.Build()); }
        }

        public static CustomerPartNumberBuilder CustomerPartNumbers
        {
            get { return new CustomerPartNumberBuilder(ExpressionInterpreter.Build()); }
        }

        public static InventoryBuilder Inventory
        {
            get { return new InventoryBuilder(ExpressionInterpreter.Build()); }
        }

        public static ItemPriceBuilder ItemPrice
        {
            get { return new ItemPriceBuilder(ExpressionInterpreter.Build()); }
        }

        public static ItemsBuilder Items
        {
            get { return new ItemsBuilder(ExpressionInterpreter.Build()); }
        }

        public static CustomerOrderBuilder CustomerOrder
        {
            get { return new CustomerOrderBuilder(ExpressionInterpreter.Build()); }
        }
        
        public static CustomersBuilder Customers
        {
            get { return new CustomersBuilder(ExpressionInterpreter.Build()); }
        }

        public static ShipToAddressBuilder ShipToAddress
        {
            get { return new ShipToAddressBuilder(ExpressionInterpreter.Build()); }
        }

        public static ShippedCustomerOrderBuilder ShippedCustomerOrder
        {
            get { return new ShippedCustomerOrderBuilder(ExpressionInterpreter.Build()); }
        }

        public static ShippedCustomerOrderLineItemBuilder ShippedCustomerOrderLineItem
        {
            get { return new ShippedCustomerOrderLineItemBuilder(ExpressionInterpreter.Build()); }
        }

        public static InvoicedOrdersBuilder InvoicedOrders
        {
            get { return new InvoicedOrdersBuilder(ExpressionInterpreter.Build()); }
        }

        public static ItemForecastBuilder ItemForecast
        {
            get { return new ItemForecastBuilder(ExpressionInterpreter.Build()); }
        }

        public static PullItemBuilder PullItem
        {
            get { return new PullItemBuilder(ExpressionInterpreter.Build()); }
        }

        public static PackItemBuilder PackItem
        {
            get { return new PackItemBuilder(ExpressionInterpreter.Build()); }
        }

        public static PackHeaderBuilder PackHeader
        {
            get { return new PackHeaderBuilder(ExpressionInterpreter.Build()); }
        }

        public static ItemWarehouseBuilder ItemWarehouse
        {
            get { return new ItemWarehouseBuilder(ExpressionInterpreter.Build()); }
        }

        public static IdoPropertiesBuilder IDOProperties
        {
            get { return new IdoPropertiesBuilder(ExpressionInterpreter.Build()); }
        }

        public static IdoCollectionsBuilder IDOCollections  
        {
            get { return new IdoCollectionsBuilder(ExpressionInterpreter.Build()); }
        }

        public static IdoMethodsBuilder IDOMethods
        {
            get { return new IdoMethodsBuilder(ExpressionInterpreter.Build()); }
        }

        public static IdoMethodParametersBuilder IDOMethodParameters
        {
            get { return new IdoMethodParametersBuilder(ExpressionInterpreter.Build()); }
        }

        public static SitesBuilder Sites
        {
            get { return new SitesBuilder(ExpressionInterpreter.Build()); }
        }

        public static JobMaterialsBuilder JobMaterials
        {
            get { return new JobMaterialsBuilder(ExpressionInterpreter.Build()); }
        }

        public static JobRoutesBuilder JobRoutes
        {
            get { return new JobRoutesBuilder(ExpressionInterpreter.Build()); }
        }

        public static JobsBuilder Jobs
        {
            get { return new JobsBuilder(ExpressionInterpreter.Build()); }
        }

        public static InventoryTransactionsBuilder InventoryTransactions
        {
            get { return new InventoryTransactionsBuilder(ExpressionInterpreter.Build()); }
        }

        public static InvoiceLineItemAllsBuilder InvoiceLineItems
        {
            get { return new InvoiceLineItemAllsBuilder(ExpressionInterpreter.Build()); }
        }

        public static IdoCustomerOrderLinesHistoryBuilder OrderLineItemHistory
        {
            get { return new IdoCustomerOrderLinesHistoryBuilder(ExpressionInterpreter.Build()); }
        }

        public static IdoCustomerOrderHistoryBuilder OrderHistory
        {
            get { return new IdoCustomerOrderHistoryBuilder(ExpressionInterpreter.Build()); }
        }

        public static IdoPurchaseOrderHistoryBuilder PurchaseOrderHistory
        {
            get { return new IdoPurchaseOrderHistoryBuilder(ExpressionInterpreter.Build()); }
        }

        public static IdoPurchaseOrderLineHistoryBuilder PurchaseOrderLineHistory
        {
            get { return new IdoPurchaseOrderLineHistoryBuilder(ExpressionInterpreter.Build());  }
        }
 
        public static IdoCustomerOrderItemLogsBuilder CustomerOrderItemLogs
        {
            get { return new IdoCustomerOrderItemLogsBuilder(ExpressionInterpreter.Build()); }
        }
  
        public static IdoApPostedTransactionsBuilder ApPostedTransactions
        {
            get { return new IdoApPostedTransactionsBuilder(ExpressionInterpreter.Build()); }
        }

        public static IdoApTransactionsBuilder ApTransactions
        { 
            get { return new IdoApTransactionsBuilder(ExpressionInterpreter.Build());}
        }

        public static IdoArTransactionBuilder ArTransactions
        {
            get { return new IdoArTransactionBuilder(ExpressionInterpreter.Build()); }
        }

        public static IdoItemLocsBuilder ItemLocs
        {
            get { return new IdoItemLocsBuilder(ExpressionInterpreter.Build());}
        }

        public static IdoPurchaseOrderBuilder PurchaseOrder
        {
            get { return new IdoPurchaseOrderBuilder(ExpressionInterpreter.Build()); }
        }


        public static IdoPurchaseOrderLinesBuilder PurchaseOrderLines
        {
            get { return new IdoPurchaseOrderLinesBuilder(ExpressionInterpreter.Build()); }
        }

        public static CustomerAddressesBuilder CustomerAddresses
        {
            get { return new CustomerAddressesBuilder(ExpressionInterpreter.Build()); }
        }

        public static LotLocationBuilder LotLocation
        {
            get { return new LotLocationBuilder(ExpressionInterpreter.Build()); }
        }


        public static NotesBuilder Notes
        {
            get { return new NotesBuilder(ExpressionInterpreter.Build()); }
        }

        public static ReceiptsBuilder Receipts
        {
            get { return new ReceiptsBuilder(ExpressionInterpreter.Build()); }
        }

        public static VendorsBuilder Vendors
        {
            get { return new VendorsBuilder(ExpressionInterpreter.Build());}
        }

        public static IdoJobRoutingSchedulesBuilder JobRoutingSchedules
        {
            get { return new IdoJobRoutingSchedulesBuilder(ExpressionInterpreter.Build()); }
        }

        public static UnitOfMeasureConversionsBuilder UnitOfMeasureConversions
        {
            get { return new UnitOfMeasureConversionsBuilder(ExpressionInterpreter.Build()); }
        }

        public static TermsBuilder Terms
        {
            get { return new TermsBuilder(ExpressionInterpreter.Build()); }
        }

        public static AFPShippingWorkbenchBuilder ShippingWorkbench
        {
            get { return new AFPShippingWorkbenchBuilder(ExpressionInterpreter.Build());  }
        }

        public static BlanketOrderLineBuilder BlanketOrderLine
        {
            get { return new BlanketOrderLineBuilder(ExpressionInterpreter.Build()); }
        }

        public static UserSessionBuilder UserSession
        {
            get { return new UserSessionBuilder(ExpressionInterpreter.Build()); }
        }

        public static ArInvoicesBuilder ArInvoices
        {
            get { return new ArInvoicesBuilder(ExpressionInterpreter.Build());  }
        }
    }
}