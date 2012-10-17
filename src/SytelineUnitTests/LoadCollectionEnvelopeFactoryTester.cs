using Machine.Specifications;
using Mongoose.IDO.Protocol;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories;
using SytelineInterface.Factories.impl;

namespace SytelineUnitTests
{
    [Subject("LoadCollectionRequestFactory")]
    public class when_load_collection_envelope_is_requested
    {
        static ILoadCollectionRequestFactory _factory;
        static LoadCollectionRequestData _req;
        
        Establish context = () =>
        {
            _factory = new LoadCollectionRequestFactory();
            _req = _factory.GetLoadCollectionRequest(FromSyteline.CustomerOrder.CustomerNumber
                .OrderNumber.Where<CustomerOrderCriteria>(x => x.CustomerNumber == "FEDEX01")
                .WithChildren(
                FromSyteline.CustomerOrderLineItems.CustomerPartNumber.Item.LineNumber.QtyOrdered ))
                ;
        };

        It should_provide_load_collection_envelope = () =>
        {
            _req.IDOName.ShouldEqual(CustomerOrder.IDO_NAME);
            _req.NestedRequests.Count.ShouldEqual(1);
        };

    }
}
