
using Mongoose.IDO.Protocol;

namespace SytelineInterface.Dsl.Queries
{
    
    public class ShipToAddress
    {
        public const string IDO_NAME = "SL.SLCustAddrs";
        public const string Address1 = "Addr_1";
        public const string Address2 = "Addr_2";
        public const string Address3 = "Addr_3";
        public const string Address4 = "Addr_4";
        public const string City = "City";
        public const string State = "State";
        public const string Zip = "Zip";
        public const string CustSeq = "CustSeq";
        public const string CustNum = "CustNum";
        public const string Contact = "Name";

        public static ShipToAddressBuilder GetFullProjection()
        {
            return FromSyteline.ShipToAddress.Address1.Address2.Address3.Address4.City
                .State.Zip.Contact.CustSeq.CustomerNumber;
        }
    }

    public class  ShipToAddressBuilder :IdoQueryBuilder<ShipToAddressBuilder,ShipToAddressFilterExpressionBuilder>
    {
        public ShipToAddressBuilder(IExpressionInterpreter ei) : base(ShipToAddress.IDO_NAME, ei) { }
        public ShipToAddressBuilder Contact { get { AddProperty(ShipToAddress.Contact);
        return this;
        }
        }
        public ShipToAddressBuilder CustSeq
        {
            get
            {
                AddProperty(ShipToAddress.CustSeq);
                return this;
            }
        }
        public ShipToAddressBuilder CustomerNumber
        {
            get
            {
                AddProperty(ShipToAddress.CustNum);
                return this;
            }
        }
        public ShipToAddressBuilder Address1 { get { AddProperty(ShipToAddress.Address1); return this; } }
        public ShipToAddressBuilder Address2 { get { AddProperty(ShipToAddress.Address2); return this; } }
        public ShipToAddressBuilder Address3 { get { AddProperty(ShipToAddress.Address3); return this; } }
        public ShipToAddressBuilder Address4 { get { AddProperty(ShipToAddress.Address4); return this; } }
        
        public ShipToAddressBuilder City { get { AddProperty(ShipToAddress.City); return this; } }
        public ShipToAddressBuilder State { get { AddProperty(ShipToAddress.State); return this; } }
        public ShipToAddressBuilder Zip { get { AddProperty(ShipToAddress.Zip); return this; } }

        public ShipToAddressBuilder ShipToCode { get { AddProperty(ShipToAddress.CustSeq); return this; } }


        public ShipToAddressBuilder WithChildren(params IIdoQueryBuilder[] builders)
        {
            return (ShipToAddressBuilder) base.WithChildren(builders);
        }

        public ShipToAddressBuilder LinkBy(string parentFieldName, string childFieldName)
        {
            return (ShipToAddressBuilder) base.LinkBy(parentFieldName, childFieldName);
        }
    }

    public class ShipToAddressFilterExpressionBuilder : FilterExpressionBuilder<ShipToAddressBuilder>
    {
        public FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder> Address1
        {
            get { return new FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder>(_builder, ShipToAddress.Address1); }
        }
        public FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder> Address2
        {
            get { return new FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder>(_builder, ShipToAddress.Address2); }
        }
        public FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder> Address3
        {
            get { return new FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder>(_builder, ShipToAddress.Address3); }
        }
        public FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder> Address4
        {
            get { return new FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder>(_builder, ShipToAddress.Address4); }
        }
        public FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder> City
        {
            get { return new FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder>(_builder, ShipToAddress.City); }
        }
        public FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder> State
        {
            get { return new FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder>(_builder, ShipToAddress.State); }
        }
        public FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder> Zip
        {
            get { return new FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder>(_builder, ShipToAddress.Zip); }
        }

        public FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder> CustID
        {
            get { return new FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder>(_builder, ShipToAddress.CustNum); }
        }

        public FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder> CustSeq
        {
            get { return new FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder>(_builder, ShipToAddress.CustSeq); }
        }
        public FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder> ShipToCode
        {
            get { return new FilterExpression<ShipToAddressBuilder, ShipToAddressFilterExpressionBuilder>(_builder, ShipToAddress.CustSeq); }
        }
    }
}