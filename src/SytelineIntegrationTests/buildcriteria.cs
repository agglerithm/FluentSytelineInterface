using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Castle.Core;
using NUnit.Framework;
using SytelineInterface.Core;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class buildcriteria
    {
        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {

        }
        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test]
        public void can_hold_place_for_test()
        {
            var assm = System.Reflection.Assembly.GetAssembly(typeof (IdoConstants));
            var lst = assm.GetTypes().Where(t => t.IsSubclassOf(typeof (IdoConstants)));
            lst.ForEach(print_criteria);
        }

        private void print_criteria(Type obj)
        {
            if (obj == null) return;
            var classname = obj.Name + "Criteria";

            Console.WriteLine("public class " + classname + " : IdoCriteria");
            Console.WriteLine("{");
            Console.WriteLine("    public " + classname + "():base(" + obj.Name + ".IDO_NAME)");
            Console.WriteLine("    {");
            Console.WriteLine("    }");
            var props = obj.GetMembers().Where(m => m.MemberType != MemberTypes.Method && m.MemberType != MemberTypes.Constructor) ; 
            write_properties(props, obj.Name);
            Console.WriteLine("}");
        }

 

        private void write_properties(IEnumerable<MemberInfo> props, string className)
        {
            props.ForEach(p => write_property(p, className));
        }

        private void write_property(MemberInfo obj, string className)
        {
            Console.WriteLine("     [FieldName(" + className + "." + obj.Name + ")]");
            Console.WriteLine("     public string " + obj.Name + "{get; set;}");
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
