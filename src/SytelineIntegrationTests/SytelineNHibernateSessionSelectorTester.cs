using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using NHibernate;
using NUnit.Framework;
using SytelineInterface.Core;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class SytelineNHibernateSessionSelectorTester
    {
        private ISytelineNHibernateSessionSelector _sessionSelector;

        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {
            SytelineNHibernateSessionSelector.Setup();
            _sessionSelector = new SytelineNHibernateSessionSelector();
        }

        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test]
        public void can_select_session()
        {
            var loc = TestHelper.GetAustinSyteline();
            var sess = _sessionSelector.GetSession(loc);

            sess.ShouldNotBeNull();
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
