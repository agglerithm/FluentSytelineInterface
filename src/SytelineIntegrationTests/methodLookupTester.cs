using System;
using System.Data;
using System.IO;
using System.Linq;
using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories;
using SytelineInterface.Factories.impl;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class methodLookupTester
    {
        private SytelineIdoClient _client;

        [TestFixtureSetUp]
        public void SetUp()
        {
            var loadFactory = new LoadCollectionRequestFactory();
            _client = new SytelineIdoClient(TestHelper.GetTestClientWrapper(),
                loadFactory,
                new UpdateCollectionRequestFactory(),
                new MethodRequestFactory(),
                new UserSessionService());

        }

        [Test]
        public void can_get_all_idos_and_methods()
        {
            var response = _client.GetData(TestHelper.GetTestSyteline(),
                                           FromSyteline.IDOMethods.CollectionName.MethodName.MethodDescription.WithMaxResults(50) 
                                           .WithChildren( FromSyteline.IDOMethodParameters.ParameterName.Sequence
                                           .LinkBy(IDOMethods.CollectionName,IDOMethodParameters.MethodName)
                                           .LinkBy(IDOMethods.MethodName,IDOMethodParameters.MethodName)));
            response.ShouldNotBeNull();

//                        foreach (DataRow row in response.Rows)
//                            save_file(row, response);
        }

        private void save_file(DataRow row, LoadCollectionResponseWrapper response)
        {
            var ido = row["CollectionName"].ToString();
            var method = row["MethodName"].ToString();
            var writer = File.CreateText(string.Format("IDO{0}.{1}MethodCallBuilder.cs", ido, method));
            writer.Write(get_file_text(ido, method, response.Records.First()).Replace("[", "{").Replace("]", "}"));
            writer.Close();
        }

        private string get_file_text(string ido, string method, IdoItemWrapper response)
        {
            return get_header() + get_method_partial(method) + get_builder(ido, method, response)
                + get_footer();
        }

        private string get_method_partial(string method)
        {
            return
                string.Format(@"        public static {0}MethodCallBuilder {0}
        [
            get [ return new {0}MethodCallBuilder(); ]
        ]
    ]

", method);
        }

        private string get_header()
        {
            return @"namespace SytelineInterface.Dsl.MethodCalls
            {
            public static partial class SytelineMethod
            {

                ";
        }

        private string get_footer()
        {
            return @"
            }";
        }
 

 

 

        private string get_builder_declaration(string method, string val, int seq)
        {
            return string.Format(@"      public {0}MethodParameterBuilder {1}(string val) 
            [   
                AddParameter({2}, val);
                return this;
            ]
     ", method, val, "\"" + seq + "\"").Replace("[", "{").Replace("]", "}");
        }

        private string get_builder(string ido, string method, IdoItemWrapper response)
        {
            var retstr = string.Format(@"public class {0}MethodCallBuilder  
                :   IdoMethodCallBuilder<IIdoMethodParameterBuilder>
                [
                    public string IDOName
                    [
                         get [ return {2}{1}{2}; ]
                    ]


                ", method, ido, "\"").Replace("[", "{");
            retstr += string.Format(@"     

        public {0}MethodParameterBuilder {0}
        [
            get
            [
                var del = _ido = new {0}MethodParameterBuilder(this);
                return ({0}MethodParameterBuilder)del;
            ]
        ]

        ]

        public class {0}MethodParameterBuilder : IdoMethodParameterBuilder
        [

        ", method);

            string mainFunc =
                string.Format(@"
            public {0}MethodParameterBuilder(IdoMethodCallBuilder<IIdoMethodParameterBuilder> parent):base(parent)
            [ 
                _method_name = {1}{0}{1};
            ", method, "\"");
            var seq = 1;
            foreach (var record in response.Records)
            {
                var val = record.GetValue("ParameterName").ToString();
                retstr += get_builder_declaration(method, val, seq);
                mainFunc += get_func_append(seq);
            }
            return retstr + @"
                " + mainFunc + @" 
                }
            }
            ";
        }

        private string get_func_append( int seq)
        {
            return string.Format("_params.Add({0}, new InvokeParameter(IDONull.Value)); \r\n ","\"" + seq + "\""); 
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }


}

