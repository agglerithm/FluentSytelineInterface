
using System;
using SytelineInterface.Dsl.Commands;
using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl
{
    public static class ToSyteline
    { 
        public static CustomersValues Customers
        {
            get { return new CustomersValues(); }
        }

        public static CustomerOrderLineItemValues CustomerOrderLineItems
        {
            get { return new CustomerOrderLineItemValues(); }
        }

        public static CustomerOrderValues CustomerOrder
        {
            get { return new CustomerOrderValues();}
        }

        public static CustomerPartNumberValues CustomerPartNumbers
        {
            get { return new CustomerPartNumberValues(); }
        }

        public static ShipToAddressValues ShipToAddress
        {
            get { return new ShipToAddressValues(); }
        }

        public static ItemForecastValues ItemForecast
        {
            get { return new ItemForecastValues(); }
        }

        public static ARPaymentValues ARPayment
        {
            get {return new ARPaymentValues();}
        }

        public static ARPaymentDetailValues ARPaymentDistributions
        {
            get {return new ARPaymentDetailValues();}
        }

        public static UserSessionValues UserSession
        {
            get {return new UserSessionValues();}
        }
    }
}