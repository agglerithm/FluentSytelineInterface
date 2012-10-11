using System;

using NUnit.Framework;
using SytelineInterface.Core;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class FailureRecoveryTester
    {
        private ISytelineIdoClient _client;
        [TestFixtureSetUp]
        public void SetUp()
        {
            _client = TestHelper.GetTestIdoClient();
        }

        [Test, ExpectedException(ExpectedMessage = "SLNotAnIdo is not a valid IDO name\r\n")]
        public void can_recover_from_failure()
        {
            try
            {
                _client.GetData(TestHelper.GetTestSyteline(), "SLNotAnIdo", "fakeProps", "fakeFilter");
            }
            catch (Exception ex)
            {
                //swallow exception
            }
            _client.GetData(TestHelper.GetTestSyteline(), "SLNotAnIdo", "fakeProps", "fakeFilter");
        }

        [TestFixtureTearDown]
        public void TearDown()
        { 
        }
    }
}
