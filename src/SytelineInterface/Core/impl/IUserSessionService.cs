namespace SytelineInterface.Core.impl
{
    using System;
    using System.Collections.Generic;
    
    using Dsl;
    using Dsl.Queries;
    using Mongoose.IDO.Protocol;

    public interface IUserSessionService
    {
        IEnumerable<ActiveUserSession> GetActiveSessions(SLConfiguration config, ISytelineIdoClient sytelineIdoClient);
        void KillSession(SLConfiguration config, ActiveUserSession session, ISytelineIdoClient client);
    }

    public class UserSessionService : IUserSessionService
    {
        public IEnumerable<ActiveUserSession> GetActiveSessions(SLConfiguration config, ISytelineIdoClient client)
        {
            return client.GetList<ActiveUserSession>(config, getUserSessionBuilder(), mapUserSession);
        }

        public void KillSession(SLConfiguration config, ActiveUserSession session, ISytelineIdoClient client)
        { 
            client.UpdateCollection(config, ToSyteline.UserSession.Action(UpdateAction.Delete),
                FromSyteline.UserSession.WhereExp<UserSessionCriteria>(s => s.ConnectionID == session.ConnectionID));
        }

        private ActiveUserSession mapUserSession(IdoItemWrapper arg)
        {
            return new ActiveUserSession()
            {
                ConnectionID = arg[UserSession.ConnectionID].ToString(),
                CreateDate = arg[UserSession.CreateDate].FromSytelineDateTime(),
                RecordDate = arg[UserSession.RecordDate].FromSytelineDateTime(),
                UserName = arg[UserSession.UserName].ToString()
            };
        }

        private UserSessionBuilder getUserSessionBuilder()
        {
            return FromSyteline.UserSession.ConnectionID.UserName.RecordDate.CreateDate;
        }
    }
}