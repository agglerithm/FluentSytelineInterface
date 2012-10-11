using System;
using System.Collections.Generic;
using Mongoose.IDO.Protocol;

namespace SytelineInterface.Core.impl
{
    public class LoadCollectionResponseWrapper
    {
        private readonly IEnumerable<IdoItemWrapper> _records;
        private List<string> _keys;

        public LoadCollectionResponseWrapper(LoadCollectionResponseData responseData)
        {
            IDOName = responseData.IDOName;
            _records = responseData.BuildChildResponseWrappers();
            _keys = responseData.PropertyList.List;
        }


        public IEnumerable<IdoItemWrapper> Records
        {
            get { return _records; }
        }


        public string IDOName { get; private set; }


        public bool ContainsField(string fieldName)
        {
            try
            {
                var obj = _keys.Find(k => k == fieldName);
                if (obj == null) return false;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
            return true;
        }
 
    }
}