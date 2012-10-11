using System.Data;
using System.Linq;
using Machine.Specifications;
using Mongoose.IDO.Protocol;
using SytelineInterface.Core.impl;

namespace SytelineUnitTests
{

    [Subject("LoadItemResponseWrapper")]
    public class when_created_from_syteline_load_data
    {
        static LoadCollectionResponseWrapper _response;
        static LoadCollectionResponseData _data;

        Establish context = () =>
        {
            _data = get_response_data();
        };

        static LoadCollectionResponseData get_response_data()
        {
            var data = new LoadCollectionResponseData()
            {
                IDOName = "MyIDOName"
            };
            data.PropertyList.Add("OrderNumber");
            data.Items.Add(get_item());
            return data;
        }

        static IDOItem get_item()
        {
            var item = new IDOItem();
            item.PropertyValues.Add("234323");
            item.AddNestedResponse(get_child_collection());
            return item;
        }

        static LoadCollectionResponseData get_child_collection()
        {
            var data = new LoadCollectionResponseData()
            {
                IDOName = "MyChildIDOName"
            };
            data.PropertyList.Add("OrderNumber");
            data.PropertyList.Add("LineNumber");
            data.Items.Add(get_child_item());
            return data;
        }

        static IDOItem get_child_item()
        {

            var item = new IDOItem();
            item.PropertyValues.Add("234323");
            item.PropertyValues.Add("2");
            return item;
        }



        Because of = () =>
        {
            _response = new LoadCollectionResponseWrapper(_data);
        };




        It should_allow_access_to_properties = () =>
        { 
            _response.Records.ToList().ForEach(check); 

        };

        static void check(IdoItemWrapper record)
        {
            record.GetValue("OrderNumber").ToString().ShouldEqual("234323");
        }
    }
}