using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
 
using Mongoose.Core.Configuration;
using Mongoose.IDO;
using Mongoose.IDO.DataAccess;
using Mongoose.IDO.Protocol; 
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.MethodCalls;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories;

namespace SytelineInterface.Core.impl
{
    using Dsl.Commands;

    public class SytelineIdoClient : ISytelineIdoClient
    {

        private readonly IClientWrapper _client;  
        private readonly ILoadCollectionRequestFactory _loadFactory;
        private readonly IUpdateCollectionRequestFactory _updateFactory;
        private readonly IMethodRequestFactory _methodRequestFactory;
        private readonly IUserSessionService _sessionService;

        public SytelineIdoClient(IClientWrapper client, 
            ILoadCollectionRequestFactory loadFactory, 
            IUpdateCollectionRequestFactory updateFactory,
            IMethodRequestFactory methodRequestFactory,
            IUserSessionService sessionService)
        {
            _client = client;
            _updateFactory = updateFactory;
            _methodRequestFactory = methodRequestFactory;
            _sessionService = sessionService;
            _loadFactory = loadFactory;
        }
 

 
 

        public string GetScalar(SLConfiguration config, string idoName, string props, string filter)
        {
            var result = GetData(config, idoName, props, filter);
            return result.Items.Count() == 0 ? null : result.Items[0].PropertyValues[0].Value;
        }

        public LoadCollectionResponseData GetData(SLConfiguration config, string idoName, string props, string filter)
        {
            LoadCollectionResponseData response;
            var request = _loadFactory.GetLoadCollectionRequest(idoName, props, filter);
            _client.Login(config);
            try
            {
                response = _client.LoadCollection(request);
            }
            finally
            {
                _client.Logout();
            }
            return response;
        }

        public void ForceLogout(SLConfiguration config, string user, string password)
        {
            if(_client.SessionInfo != null)
                _client.Logout();
            else
            {
                
            }
        }

        public string GetScalar(SLConfiguration config, IIdoQueryBuilder idoParameterBuilder)
        {
            return GetScalar(config, idoParameterBuilder.GetIDOName(), idoParameterBuilder.GetProperties(),
                             idoParameterBuilder.GetFilter());
        }

        

 
//        public void ExecuteProcedure(SLConfiguration config, string idoName, string methodName, string parms)
//        {
//            login(config);
//            _client.Invoke(idoName, methodName, parms);
//        }



        public UpdateCollectionResponseWrapper Insert(SLConfiguration config, IIdoCommandBuilder dataBuilder)
        {
            UpdateCollectionResponseData response = null;
            var request = _updateFactory.GetInsertCollectionRequest(dataBuilder);
            _client.Login(config);
            try
            { 
                response = _client.UpdateCollection(request); 
            }
            finally
            {
                _client.Logout();
            }
            return new UpdateCollectionResponseWrapper(response);
        }

        public IEnumerable<ActiveUserSession> ActiveSessions(SLConfiguration config)
        {
            return _sessionService.GetActiveSessions(config, this);
        }

        public void KillSession(SLConfiguration config, ActiveUserSession session)
        {
            _sessionService.KillSession(config, session, this);
        }


        public IEnumerable<UpdateCollectionResponseWrapper> Insert(SLConfiguration config, IEnumerable<IIdoCommandBuilder> datasetBuilders)
        {
            var lst = new List<UpdateCollectionResponseWrapper>();
            foreach(IIdoCommandBuilder b in datasetBuilders)
            {
                lst.Add(Insert(config, b));
            }
            return lst;
        }

        public MethodCallResponseWrapper ExecuteMethod(SLConfiguration config, IIdoMethodCallBuilder builder)
        {
            InvokeResponseData response;
            InvokeRequestData request = _methodRequestFactory.GetMethodRequest(builder);
            _client.Login(config);
            try
            {
                response = _client.Execute(request); 
            }
            finally
            {
                _client.Logout();
            }
            return new MethodCallResponseWrapper(response);
        }

        public UpdateCollectionResponseWrapper UpdateCollection(SLConfiguration config, IIdoCommandBuilder datasetBuilder, IIdoQueryBuilder paramBuilder)
        {
            var toUpdate = GetData(config, paramBuilder);
            UpdateCollectionResponseData response;
            var request = _updateFactory.GetUpdateCollectionRequest(datasetBuilder, toUpdate);
            _client.Login(config);
            try
            { 
                response =  _client.UpdateCollection(request) ;
            }
            finally
            {
                _client.Logout();
            }
            
            return new UpdateCollectionResponseWrapper(response);
        }

        public T GetObject<T>(SLConfiguration config, IIdoQueryBuilder builder, Func<IdoItemWrapper, T> mapFunction) where T : class
        {
            var response = GetData(config, builder);
            if (response.Records.Count() == 0) return null;
            var record = response.Records.First();
            return mapFunction.Invoke(record);
        }

        public IEnumerable<T> GetList<T>(SLConfiguration config, IIdoQueryBuilder builder, Func<IdoItemWrapper, T> mapFunction)
        {
            var response = GetData(config, builder);
            return response.Records.Select<IdoItemWrapper, T>(mapFunction.Invoke);
        }

        public LoadCollectionResponseWrapper GetData(SLConfiguration config, IIdoQueryBuilder builder)
        {
            LoadCollectionResponseData response;
            var request = _loadFactory.GetLoadCollectionRequest(builder);
            _client.Login(config);
            try
            {
                response = _client.LoadCollection(request);
            }
            finally
            {
                _client.Logout();
            }
            
            return new LoadCollectionResponseWrapper(response);
        }

      
    }
}