using System.Collections.Generic;
using Mongoose.IDO.Protocol;
using SytelineInterface.Dsl;

namespace SytelineInterface.Factories
{
    using Dsl.Commands;

    public interface ILoadCollectionRequestFactory
    {
        LoadCollectionRequestData GetLoadCollectionRequest(IIdoQueryBuilder idoParameterBuilder);
        LoadCollectionRequestData GetLoadCollectionRequest(string idoName, string props, string filter);
    }
}