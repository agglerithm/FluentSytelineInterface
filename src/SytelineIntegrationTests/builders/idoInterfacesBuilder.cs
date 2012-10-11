using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection; 
using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories;
using SytelineInterface.Factories.impl;
using SytelineInterface.Common.Extensions;



namespace SytelineIntegrationTests.builders
{
    [TestFixture]
    public class idoInterfacesBuilder
    {
        //Builds interface for a particular IDO
        private SytelineIdoClient _client;

        [TestFixtureSetUp]
        public void SetUp()
        {
            var loadFactory = new LoadCollectionRequestFactory();
            _client = new SytelineIdoClient(TestHelper.GetTestClientWrapper(),
                loadFactory,
                new UpdateCollectionRequestFactory(),
                new MethodRequestFactory(), new UserSessionService()); 

        }

        [Test, Explicit]
        public void build_ido()
        {
            var response = _client.GetData(TestHelper.GetTestSyteline(),
                                           FromSyteline.IDOCollections.CollectionName.Where.CollectionName.StartsWith("SL")
                                           .WithChildren(FromSyteline.IDOProperties.PropertyName.LinkBy(IDOCollections.CollectionName, IDOProperties.CollectionName)));
            response.ShouldNotBeNull();

            foreach (var row in response.Records)
            {
                var collectionName = row["CollectionName"].ToString();
                //Put the ido name here to assign to collectionName, then run test to build IDO classes
                if (collectionName == "SLCoBlns") print_file_to_screen(row, response);
            }
        }

        [Test, Explicit]
        public void  print_file_to_screen(IdoItemWrapper row, LoadCollectionResponseWrapper response)
        { 
            var ido = row["CollectionName"].ToString();
            Console.WriteLine(get_file_text(ido, response.Records.Find(r => r.GetValue("CollectionName").ToString() == ido)).Replace("[", "{").Replace("]", "}"));
        }

        private void save_file(IdoItemWrapper row, LoadCollectionResponseWrapper response)
        {
            var ido = row["CollectionName"].ToString();
            var writer = File.CreateText(string.Format("IDO{0}Builder.cs", ido));
            writer.Write(get_file_text(ido, response.Records.First()).Replace("[", "{").Replace("]", "}"));
            writer.Close();
        }

        private string get_file_text(string ido, IdoItemWrapper response)
        {
            return get_header() + get_constant_class(ido, response) + get_builder(ido, response) + get_filter_builder(ido, response)
                + get_footer();
        }

        private string get_header()
        {
            return @"using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                  ";
        }

        private string get_footer()
        {
            return @"
            }";
        }
        private string get_filter_builder(string ido, IdoItemWrapper response)
        {
            var retstr = string.Format(@"public class {0}FilterExpressionBuilder  
                :   FilterExpressionBuilder<{0}Builder>
                [
                ", ido); 
            foreach (var record in response.Records)
            {
                var val = record.GetValue("PropertyName").ToString();
                retstr += get_filter_builder_declaration(ido, val);
            }
            return retstr + @"

                }

".Replace("[", "{").Replace("]", "}");
        }

        private string get_filter_builder_declaration(string ido, string val)
        {
            return
                string.Format(
                    @"        public FilterExpression<{0}Builder, {0}FilterExpressionBuilder> {1}
                    [
                        get [ return new FilterExpression<{0}Builder, {0}FilterExpressionBuilder>(_builder, {0}.{1}); ]
                    ]
                    ", ido, val).Replace("[", "{").Replace("]", "}");
        }

        private string get_builder_constructor(string ido)
        {
            return string.Format(@"        public {0}Builder(IExpressionInterpreter interpreter) : base({0}.IDO_NAME, interpreter) [ ]

                ", ido);
        }
 
        private string get_builder_declaration(string ido, string val)
        {
            return string.Format(@"      public {0}Builder {1} [ get [  AddProperty({0}.{1}); return this; ]  ] 
                    ", ido, val).Replace("[", "{").Replace("]", "}"); 
        }

        private string get_builder(string ido, IdoItemWrapper response)
        {
            var retstr = string.Format(@"public class {0}Builder  
                :   IdoQueryBuilder<{0}Builder, {0}FilterExpressionBuilder>
                [
                ", ido).Replace("[","{");
            retstr += get_builder_constructor(ido);
            foreach (var record in response.Records)
            {
                var val = record.GetValue("PropertyName").ToString();
                retstr += get_builder_declaration(ido, val);
            }
            return retstr + @"

                }

            ";
        }

        private string get_constant_class(string ido, IdoItemWrapper response)
        {
            var retstr = "public class " + ido + @" : IdoConstants 
                { 
                    " +
                         get_const_declaration("IDO_NAME", ido);
            foreach (var record in response.Records)
            {
                var val = record.GetValue("PropertyName").ToString();
                retstr += get_const_declaration(val, val);
            }
            return retstr + @"

                }

            ";
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
            var props = obj.GetMembers().Where(m => m.MemberType != MemberTypes.Method && m.MemberType != MemberTypes.Constructor);
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
        private string get_const_declaration(string name, string value)
        {
            return string.Format("       public const string {0} = \"{1}\";\r\n",name,value);
        }

        [TestFixtureTearDown]
        public void TearDown()
        { 
        }
    }

 
    }
