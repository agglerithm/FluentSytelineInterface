using System;
using System.Text;
using Machine.Specifications;
using Mongoose.IDO.Protocol;
using SytelineInterface.Core.impl;

namespace SytelineUnitTests
{
    [Subject(typeof(UpdateCollectionResponseWrapper))]
    public class when_created_with_response_with_no_records
    {
        private static UpdateCollectionResponseWrapper _response;
        private static UpdateCollectionResponseData _data;
    
        Establish context = () =>
        {
            _data = new UpdateCollectionResponseData();
        };

        Because of = () =>
        {
            _response = new UpdateCollectionResponseWrapper(_data);
        };




        It should_expose_rows_collection_with_no_rows = () =>
        {
            _response.Rows.ShouldNotBeNull();
            _response.Rows.Count.ShouldEqual(0);

        };
    }
}