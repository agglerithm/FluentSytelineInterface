using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection; 

using SytelineInterface.Core;
using SytelineInterface.Core.impl;
using SytelineInterface.Factories;
using SytelineInterface.Factories.impl;


namespace SytelineIntegrationTests
{
    using SytelineInterface;

    public class TestHelper
    {
        public static DataTable ListToTable<T>(List<T> rows)
        {
            var dt = new DataTable();
            PropertyInfo[] props = typeof (T).GetProperties();
            Array.ForEach(props, p => dt.Columns.Add(p.Name, p.PropertyType));
            foreach (T r in rows)
            {
                var vals = new object[props.Length];
                for (int idx = 0; idx < vals.Length; idx++)
                {
                    vals[idx] = props[idx].GetValue(r, null);
                }
                dt.Rows.Add(vals);
            }
            return dt;
        }

 


        public static SLConfiguration GetTestSyteline()
        {
            var loc = new SLConfiguration("Austin", "Syteline_AUS_App");
             
            return loc;
        }
        public static ISytelineIdoClient GetTestIdoClient()
        {
            return new SytelineIdoClient(GetTestClientWrapper(), new LoadCollectionRequestFactory(),
                                         new UpdateCollectionRequestFactory(), new MethodRequestFactory(), new UserSessionService());
        }

        public static ISytelineIdoClient GetLiveIdoClient()
        {
            return new SytelineIdoClient(GetLiveClientWrapper(), new LoadCollectionRequestFactory(),
                                          new UpdateCollectionRequestFactory(), new MethodRequestFactory(), new UserSessionService());
        }

        private static IClientWrapper GetLiveClientWrapper()
        {
            return new ClientWrapper("http://sl_util2/IDORequestService/RequestService.aspx", "autotest", "automation"); 
        }

        public static IClientWrapper GetTestClientWrapper()
        {
            return new ClientWrapper("http://sl_util2_cloned/IDORequestService/RequestService.aspx", "autotest", "autotest"); 
        }


        public static SLConfiguration GetLiveSyteline()
        {
            var loc = new SLConfiguration(  "Nashville", "Syteline_NAS_App" );
            return loc;
        }

        public static SLConfiguration GetDallasTestSyteline()
        {
            var loc = new SLConfiguration(  "Dallas",   "7" );
           
            return loc;
        }
    }
}