using System;
using System.Collections.Generic;
using System.Data;

using Mongoose.IDO.Protocol;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.MethodCalls;
using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Core
{
    public interface ISytelineIdoClient
    { 
        string GetScalar(SLConfiguration config, string idoName, string props, string filter);
        string GetScalar(SLConfiguration config, IIdoQueryBuilder idoParameterBuilder);
        UpdateCollectionResponseWrapper Insert(SLConfiguration config, IIdoCommandBuilder dataBuilder);
        IEnumerable<ActiveUserSession> ActiveSessions(SLConfiguration config);
        void KillSession(SLConfiguration config, ActiveUserSession session);

        IEnumerable<UpdateCollectionResponseWrapper> Insert(SLConfiguration config, IEnumerable<IIdoCommandBuilder> datasetBuilders);
        MethodCallResponseWrapper ExecuteMethod(SLConfiguration config, IIdoMethodCallBuilder builder);
        UpdateCollectionResponseWrapper UpdateCollection(SLConfiguration config, IIdoCommandBuilder datasetBuilders, IIdoQueryBuilder paramBuilder);
        LoadCollectionResponseWrapper GetData(SLConfiguration config, IIdoQueryBuilder builder);
        T GetObject<T>(SLConfiguration config, IIdoQueryBuilder builder, Func<IdoItemWrapper, T> mapFunction) where T : class;
        IEnumerable<T> GetList<T>(SLConfiguration config, IIdoQueryBuilder builder, Func<IdoItemWrapper, T> mapFunction);
        LoadCollectionResponseData GetData(SLConfiguration config, string idoName, string props, string filter);
        void ForceLogout(SLConfiguration config, string user, string password);
    }
}