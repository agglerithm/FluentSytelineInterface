using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class CustomerPartNumberValues :IdoCommandBuilder
    {
        public CustomerPartNumberValues() : base(CustomerPartNumbers.IDO_NAME)
        {
        }
 

        public override IIdoQueryBuilder GetBuilder()
        {
            return FromSyteline.CustomerPartNumbers.Add(get_property_names());
        }

        public CustomerPartNumberValues Item(string value)
        {
            AddValue(CustomerPartNumbers.Item,value);
            return this;
        }

        public CustomerPartNumberValues CustomerPartNumber(string value)
        {
            AddValue(CustomerPartNumbers.CustomerPartNumber, value);
            return this;
        }

        public CustomerPartNumberValues CustomerNumber(string value)
        {
            AddValue(CustomerPartNumbers.CustomerNumber, value);
            return this;
        }
    }
}