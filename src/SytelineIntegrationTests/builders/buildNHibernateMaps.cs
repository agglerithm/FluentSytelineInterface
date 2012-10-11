using System.Data;
using System.IO;
using System.Linq;
using AFPST.Common.Extensions;
using AFPST.Common.Infrastructure;
using AFPST.Common.Services;
using NUnit.Framework;

namespace SytelineIntegrationTests.builders
{
    [TestFixture]
    public class buildNHibernateMaps

    {
        class sytelinetableschema
        {
            internal string name { get; set; }
            internal string[][] columns
            {
                get; set;
            } 
        }
        private IDataUtilities _dataUtil;

        [TestFixtureSetUp]
        public void SetUp()
        {
            Container.Reset();
            Container.CommonSetUp(HostType.ApplicationOrTest);
            _dataUtil = Container.Resolve<IDataUtilities>();
        }

        [Test]
        public void can_build_maps()
        {
            var sql =
                @"select name, id from SQL2.Syteline_AUS_AppPlt.sys.sysobjects where name IN ( 'coitem_log')

";
            var lst = _dataUtil.CommandReturns<sytelinetableschema>(sql)
                .AsList(map);

             foreach(sytelinetableschema schema in lst)
                            save_file(schema);
        }

        private sytelinetableschema map(DataRow arg)
        {
            return new sytelinetableschema()
                       {
                           name = arg["name"].ToString(),
                           columns = get_columns(arg["id"].CastToInt())
                       };
        }

        private void save_file(sytelinetableschema schema)
        { 
            var writer = File.CreateText(string.Format("{0}Map.cs", schema.name));
            writer.Write(get_file_text(schema).Replace("[", "{").Replace("]", "}"));
            writer.Close();
        }

        private string get_file_text(sytelinetableschema schema)
        {
            return get_header() + get_entity(schema) + get_map(schema) + get_footer();
        }

        private string get_map(sytelinetableschema schema)
        {
            var cls = string.Format(@"public class {0}Map :  ClassMap<{0}>
            [
             
               public {0}Map()
               [
                ", schema.name);
            cls += "Table(\"" + schema.name + "\");";
            schema.columns.ForEach(c => cls += "                         Map(x => x." + c[0] + ");\r\n");
            return cls + @"
            ]
          ]
            ";
        }

        private string get_entity(sytelinetableschema schema)
        {
            var cls = string.Format(@"public class {0} : Entity
            [
             ",schema.name);
            schema.columns.ForEach(c => cls += "                         public virtual " + fix_type(c[1]) + " " + c[0] + "[ get;set; ] \r\n");
            return cls + @"

            ]
            ";
        }

        private string fix_type(string s)
        {
            return s.Replace("nchar", "string").Replace("nvarchar", "string")
                .Replace("tinyint", "int").Replace("datetime", "DateTime")
                .Replace("uniqueidentifier", "Guid");
        }

        private string get_header()
        {
            return @"using System;
using FluentNHibernate.Data;
using FluentNHibernate.Mapping;

                namespace FluentNHibernateClasses.Mappings
                {
                  ";
        }

        private string get_footer()
        {
            return @"
            }";
        }

        private string[][] get_columns(long id)
        {
            var sql =
                @"select  C.name, T.name as typename from  Syteline_AUS_AppPlt.sys.all_columns C INNER JOIN 
   Syteline_AUS_AppPlt.sys.systypes T ON C.system_type_id = xtype and xusertype 
<> usertype and T.name <> 'sysname' where object_id = @objid ";
            return _dataUtil.CommandReturns<string[]>(sql).AddLong("objid",id)
                .AsList(map_cols).ToArray();
        }

        private string[] map_cols(DataRow arg)
        {
            return new [] {arg["name"].ToString(),arg["typename"].ToString()}
            ;
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
        }
    }


}
