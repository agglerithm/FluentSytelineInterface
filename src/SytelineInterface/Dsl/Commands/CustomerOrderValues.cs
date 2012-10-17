using System;
using SytelineInterface.Core;
using SytelineInterface.Core.Enums;
using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class CustomerOrderValues :IdoCommandBuilder
    {
        public CustomerOrderValues( ) : base(CustomerOrder.IDO_NAME)
        {  
        }

        public CustomerOrderValues LinkBy(string parentField, string childField)
        {
            return (CustomerOrderValues)base.LinkBy(parentField, childField);
        }

        public override IIdoQueryBuilder GetBuilder()
        {
            return FromSyteline.CustomerOrder.Add(get_property_names());
        }

  
 
        public CustomerOrderValues CustomerNumber(string value)
        {
            AddValue(CustomerOrder.CustomerNumber, value);
            return this;
        }

        public CustomerOrderValues Discount(string value)
        {
            AddValue(CustomerOrder.Discount, value);
            return this;
        }

        public CustomerOrderValues EndUserType(string value)
        {
            AddValue(CustomerOrder.EndUserType, value);
            return this;
        }

        public CustomerOrderValues OrderDate(DateTime value)
        {
            AddValue(CustomerOrder.OrderDate, value.ToSytelineDate());
            return this;
        }

        public CustomerOrderValues OrderNumber(string value)
        {
            AddValue(CustomerOrder.OrderNumber, value);
            return this;
        }

        public CustomerOrderValues OrderType(string value)
        {
            AddValue(CustomerOrder.OrderType, value);
            return this;
        }

        public CustomerOrderValues PONumber(string value)
        {
            AddValue(CustomerOrder.PONumber, value);
            return this;
        }

        public CustomerOrderValues Salesman(string value)
        {
            AddValue(CustomerOrder.Salesman, value);
            return this;
        }

 
 

        public CustomerOrderValues ShipToCode(string value)
        {
            AddValue(CustomerOrder.ShipToCode, value);
            return this;
        }

        public CustomerOrderValues Site(string value)
        {
            AddValue(CustomerOrder.Site, value);
            return this;
        }

        public CustomerOrderValues Status(string value)
        {
            AddValue(CustomerOrder.Status, value);
            return this;
        }

        public CustomerOrderValues TaxCode(string value)
        {
            AddValue(CustomerOrder.TaxCode, value);
            return this;
        }

        public CustomerOrderValues Terms(string value)
        {
            AddValue(CustomerOrder.TermsCode, value);
            return this;
        }

        public CustomerOrderValues Warehouse(string value)
        {
            AddValue(CustomerOrder.Warehouse, value);
            return this;
        }

        public CustomerOrderValues ShipToAddr1(string value)
        {
            AddValue(CustomerOrder.ShipToAddr1, value);
            return this;
        }

        public CustomerOrderValues ShipToAddr2(string value)
        {
            AddValue(CustomerOrder.ShipToAddr2, value);
            return this;
        }
  

        public CustomerOrderValues ShipToCity(string value)
        {
            AddValue(CustomerOrder.ShipToCity, value);
            return this;
        }

        public CustomerOrderValues ShipToState(string value)
        {
            AddValue(CustomerOrder.ShipToState, value);
            return this;
        }
        public CustomerOrderValues ShipToZip(string value)
        {
            AddValue(CustomerOrder.ShipToZip, value);
            return this;
        }
        public CustomerOrderValues ShipToCountry(string value)
        {
            AddValue(CustomerOrder.ShipToCountry, value);
            return this;
        }
        public CustomerOrderValues ShipEarly(string value)
        {
            AddValue(CustomerOrder.ShipEarly, value);
            return this;
        }

 
  
//        public CustomerOrderValues ShipToEmailAddr(string value)
//        {
//            AddValue(CustomerOrder.ShipToEmailAddr, value);
//            return this;
//        }
//        public CustomerOrderValues ShipToFaxNum(string value)
//        {
//            AddValue(CustomerOrder.ShipToFaxNum, value);
//            return this;
//        }
//        public CustomerOrderValues ShipToPhone2(string value)
//        {
//            AddValue(CustomerOrder.ShipToPhone2, value);
//            return this;
//        }
        public CustomerOrderValues ShipToName(string value)
        {
            AddValue(CustomerOrder.ShipToName, value);
            return this;
        }
 
 
 
        public CustomerOrderValues TakenBy(string value)
        {
            AddValue(CustomerOrder.TakenBy, value);
            return this;
        }
    }
}