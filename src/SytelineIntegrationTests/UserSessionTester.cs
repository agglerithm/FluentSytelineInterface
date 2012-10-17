using System;
using System.Linq;
using NUnit.Framework;

namespace SytelineIntegrationTests
{
    
    using Machine.Specifications;
    using Mongoose.IDO.Protocol;
    using SytelineInterface;
    using SytelineInterface.Core;
    using SytelineInterface.Core.impl;
    using SytelineInterface.Dsl;
    using SytelineInterface.Dsl.Commands;
    using SytelineInterface.Dsl.Queries;

    [TestFixture]
    public class UserSessionTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;
        private SLConfiguration _testLoc;

        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {

            _client = TestHelper.GetTestIdoClient();
            _builder = FromSyteline.UserSession.ConnectionID.UserName.RecordDate.CreateDate;
            _testLoc = TestHelper.GetTestSyteline();
        }
        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test]
        public void can_get_session_info()
        {

            var resp = _client.GetData(_testLoc, _builder);
            resp.ContainsField(UserSession.ConnectionID).ShouldBeTrue();
            resp.ContainsField(UserSession.UserName).ShouldBeTrue();
            resp.ContainsField(UserSession.RecordDate).ShouldBeTrue(); 
        }

        [Test, Explicit]
        public void can_delete_session()
        {
            var resp = _client.GetList<ActiveUserSession>(_testLoc, _builder, map).Where(s => s.RecordDate < DateTime.Today);
            var session = resp.First();
            if(session != null)
            {
                Console.WriteLine("Deleting session for user {0}, last accessed on {1}.", session.UserName,  session.RecordDate );
            _client.UpdateCollection(_testLoc, ToSyteline.UserSession.Action(UpdateAction.Delete), 
                FromSyteline.UserSession.WhereExp<UserSessionCriteria>(s => s.ConnectionID == session.ConnectionID));
            }
        }
        [Test]
        public void can_get_session_info_through_client()
        {

            var lst = _client.ActiveSessions(_testLoc);
            lst.ShouldNotBeNull();
        }

        [Test, Explicit]
        public void can_delete_session_through_client()
        {
            var lst = _client.ActiveSessions(_testLoc).Where(s => s.RecordDate < DateTime.Now.AddMinutes(-90));
            var session = lst.First();
            if (session != null)
            {
                Console.WriteLine("Deleting session through client for user {0}, last accessed on {1}.", session.UserName, session.RecordDate);
                _client.KillSession(_testLoc, session);
            }
        }
        private ActiveUserSession map(IdoItemWrapper arg)
        {
            return new ActiveUserSession()
                       {
                           UserName = arg[UserSession.UserName].ToString(),
                           RecordDate = arg[UserSession.RecordDate].ToString().FromSytelineDateTime(),
                           ConnectionID = arg[UserSession.ConnectionID].ToString()
                       };
        }

        [TearDown]
        public void TearDownForEachTest()
        {

        }

        [TestFixtureTearDown]
        public void TearDownAfterAllTests()
        {

        }
    }
}
