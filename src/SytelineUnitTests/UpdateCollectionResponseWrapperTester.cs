using System.Collections.Generic;
using System.Data;
using Machine.Specifications;
using Mongoose.IDO.Protocol;
using SytelineInterface.Core.impl;

namespace SytelineUnitTests
{

    [Subject(typeof(UpdateCollectionResponseWrapper))]
    public class when_created_from_syteline_update_data
    {
        static UpdateCollectionResponseWrapper _response;
        static UpdateCollectionResponseData _data;
        
        Establish context = () =>
        {
            _data = get_response_data();
        };

        static UpdateCollectionResponseData get_response_data()
        {
            var data = new UpdateCollectionResponseData()
                       {
                           IDOName = "MyIDOName" 
                       };
            data.Items.Add(get_item());
            return data;
        }

        static IDOUpdateItem get_item()
        {
            var item = new IDOUpdateItem(UpdateAction.All);
            item.Properties.Add("OrderNumber", "234323");
            item.NestedUpdates.Add(get_child_collection());
            return item;
        }

        static UpdateCollectionDataBase get_child_collection()
        {            
            var data = new UpdateCollectionResponseData()
                       {
                           IDOName = "MyChildIDOName" 
                       };
            data.Items.Add(get_child_item("1"));
            data.Items.Add(get_child_item("2"));
            return data;
        }

        static IDOUpdateItem get_child_item(string line)
        {

            var item = new IDOUpdateItem(UpdateAction.All);
            item.Properties.Add("OrderNumber", "234323");
            item.Properties.Add("LineNumber", line); 
            return item;
        }

 

        Because of = () =>
        {
            _response = new UpdateCollectionResponseWrapper(_data);
        };




        It should_allow_access_to_properties = () =>
        {
            var item = _response.Rows[0];
            item["OrderNumber"].ShouldEqual("234323");
//            var children = _response.GetLinkedIdoResultsFrom(item);
//            children.Count().ShouldEqual(1);
//            children.First().Rows[0]["OrderNumber"].ShouldEqual(item["OrderNumber"]); 
//            var lineNums = children.First().ReturnListOf<string>(map);
//            lineNums.Count().ShouldEqual(2);
//            lineNums.First().ShouldEqual("1");

        };
 

        static string map(DataRow arg1, IEnumerable<UpdateCollectionResponseWrapper> arg2)
        {
            return arg1["LineNumber"].ToString();
        }
    }

}