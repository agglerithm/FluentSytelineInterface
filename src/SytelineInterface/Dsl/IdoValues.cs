
namespace SytelineInterface.Dsl
{
    public class IdoValues : IdoDataBuilder
    {
        public IdoValues(string idoName) : base(idoName)
        {
        }

 

        public IdoValues RowNumber(string value)
        {
            AddValue(Core.IdoConstants.ROW_POINTER, value); return this;
        }
    }
}