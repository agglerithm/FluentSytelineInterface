using System;

using Mongoose.IDO;
using Mongoose.IDO.Protocol;

namespace SytelineInterface.Core.impl
{
    using System.Collections.Generic;

    public interface IClientWrapper
    {
        void Login(SLConfiguration config);
        OpenSessionResponseData SessionInfo { get; }
        void Logout();
        LoadCollectionResponseData LoadCollection(LoadCollectionRequestData request);
        UpdateCollectionResponseData UpdateCollection(UpdateCollectionRequestData request);
        InvokeResponseData Execute(InvokeRequestData request);
    }

    public class ClientWrapper : IClientWrapper
    {
        private readonly Client _client;
        private readonly string _user;
        private readonly string _password;
        private OpenSessionResponseData _sessionInfo;

        public ClientWrapper(string url, string user, string password )
        {
            _client = new Client(url, IDOProtocol.Http); 
            _user = user;
            _password = password; 
        }

        public void Login(SLConfiguration config)
        {
            _sessionInfo = _client.OpenSession(_user, _password, config.Database);
            if (!SessionInfo.LogonSucceeded)
                throw new Exception(SessionInfo.AdditionalFailureInformation);
        }

        public OpenSessionResponseData SessionInfo
        {
            get{ return _sessionInfo;}
        }

        public void Logout()
        {
            _sessionInfo = null;
            _client.CloseSession(); 
        }

        public LoadCollectionResponseData LoadCollection(LoadCollectionRequestData request)
        {
            return _client.LoadCollection(request);
        }

        public UpdateCollectionResponseData UpdateCollection(UpdateCollectionRequestData request)
        {
            return _client.UpdateCollection(request);
        }

        public InvokeResponseData Execute(InvokeRequestData request)
        {
            return _client.Invoke(request);
        }

 
    }
}
