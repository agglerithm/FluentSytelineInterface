using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mongoose.FormServer.Protocol;
using Mongoose.IDO;
using Mongoose.IDO.Protocol;
using Mongoose.WinStudio.Enums;
using NUnit.Framework;
using SytelineInterface.Core.impl;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class TestFixtureTemplate
    {
        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {

        }
        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test, Explicit]
        public void can_load_global_objects()
        {
            var obj = new LoadGlobalObjectsRequestData()
                          {
                              ObjectType = GlobalObjectType.Form,
                              NameOrMask = "name",
                              ScopeInfo = new ScopeInfo(ScopeTypes.USER, "user")
                                              {
                                                  UserName = "sa"
                                              },
                              StringTableName = "DefineVariables"

                          };
            var client = new Client("http://jreesesyteline/IDORequestService/RequestService.aspx",IDOProtocol.Http);
           var resp = client.OpenSession("autotest",
                               "automation", "Austin Pilot");

//            var req = new IDORequest(RequestType.LoadGlobalObjects);
//            req.SetRequestPayload(obj);
//
//            var resp22 = client.GetResponse(req);

            client.CloseSession();
 
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
