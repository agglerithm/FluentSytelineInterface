using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl
{
    public class IdoCriteria
    {
        public IdoCriteria(string idoName)
        {
            IDO_NAME =  idoName;
        }
        public string IDO_NAME { get; set; }
    }
}