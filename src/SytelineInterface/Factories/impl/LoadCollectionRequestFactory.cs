using System.Collections.Generic;

using Mongoose.IDO.Protocol;
using SytelineInterface.Core;
using SytelineInterface.Dsl;

namespace SytelineInterface.Factories.impl
{
    using Common.Extensions;

    public class LoadCollectionRequestFactory : ILoadCollectionRequestFactory
    {
        public LoadCollectionRequestData GetLoadCollectionRequest(IIdoQueryBuilder idoParameterBuilder)
        {
            return getLoadCollectionRequest(idoParameterBuilder, true);
        }

        private static LoadCollectionRequestData getLoadCollectionRequest(IIdoQueryBuilder idoParameterBuilder, bool topLevel)
        {
            var props = idoParameterBuilder.GetProperties();
            if (props.IsNullOrEmpty())
            {
                idoParameterBuilder.Add(new[] { IdoConstants.KEY });
            }
            var loadCollectionRequest = new LoadCollectionRequestData(idoParameterBuilder.GetIDOName(),
                                                                      idoParameterBuilder.GetProperties(),
                                                                      idoParameterBuilder.GetFilter(), "", idoParameterBuilder.GetMaxResults()) { LoadCap = 0 };
            loadCollectionRequest.SetContext("AUTOMATION", "AUTOMATION", "AUTOMATION", "IDO");

            if (idoParameterBuilder.HasLinkFields)
            {
                if (topLevel)
                    throw new SytelineInterfaceQueryException();
                var pairList = idoParameterBuilder.GetLinkFields();
                var linkField = pairList[0];
                if (pairList.Length == 1)
                    loadCollectionRequest.SetLinkBy(linkField.ParentProperty, linkField.ChildProperty);
                else
                    loadCollectionRequest.SetLinkBy(linkField.ParentProperty, linkField.ChildProperty,
                        get_additional_pairs(pairList));
            }


            foreach (IIdoQueryBuilder child in idoParameterBuilder.GetChildren())
            {
                loadCollectionRequest.AddNestedRequest(getLoadCollectionRequest(child, false));
            }
            return loadCollectionRequest;
        }
        private static string[] get_additional_pairs(IEnumerable<PropertyPair> pairs)
        {
            var returnList = new List<string>();
            bool skipMe = true;
            foreach(PropertyPair pair in pairs)
            {
                if (skipMe)
                    skipMe = false;
                else
                {
                    returnList.Add(pair.ParentProperty);
                    returnList.Add(pair.ChildProperty); 
                }
            }
                return returnList.ToArray();
        }

        public LoadCollectionRequestData GetLoadCollectionRequest(string idoName, string props, string filter)
        {
            return new LoadCollectionRequestData(idoName, props, filter, "", 0);
        }
    }
}