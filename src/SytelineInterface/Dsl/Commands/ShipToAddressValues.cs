using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class ShipToAddressValues:IdoCommandBuilder
    {
        public ShipToAddressValues()
            : base(ShipToAddress.IDO_NAME)
        {
        }

        public ShipToAddressValues Address1(string value)
        {
            AddValue(ShipToAddress.Address1, value);
            return this;
        }

        public ShipToAddressValues Address2(string value)
        {
            AddValue(ShipToAddress.Address2, value);
            return this;
        }

        public ShipToAddressValues City(string value)
        {
            AddValue(ShipToAddress.City, value);
            return this;
        }

        public ShipToAddressValues State(string value)
        {
            AddValue(ShipToAddress.State, value);
            return this;
        }

        public ShipToAddressValues Zip(string value)
        {
            AddValue(ShipToAddress.Zip, value);
            return this;
        }

        public ShipToAddressValues CustID(string value)
        {
            AddValue(ShipToAddress.CustNum, value);
            return this;
        }

        public ShipToAddressValues ShipToCode(string value)
        {
            AddValue(ShipToAddress.CustSeq, value);
            return this;
        }

        public IIdoQueryBuilder GetBuilder()
        {
            return FromSyteline.ShipToAddress.Add(get_property_names());
        }

 
    }
}