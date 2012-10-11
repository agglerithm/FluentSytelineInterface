using System.Linq;

using Machine.Specifications;
using Mongoose.IDO.Protocol;
using Moq;
using SytelineInterface.Core;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories;
using SytelineInterface.Factories.impl;
using It=Machine.Specifications.It;

namespace SytelineUnitTests
{
    using SytelineInterface;

    [Subject(typeof(UpdateCollectionRequestFactory))]
    public class when_update_collection_envelope_is_requested_for_update
    {
        static IUpdateCollectionRequestFactory _factory;
        static UpdateCollectionRequestData _req;
        static Mock<ILoadCollectionRequestFactory> _loadFactory;
        static Mock<ISytelineIdoClient> _client;
        static SLConfiguration _loc;
        static IIdoQueryBuilder _builder;
        
        Establish context = () =>
        {
            _loadFactory = new Mock<ILoadCollectionRequestFactory>();
            _client = new Mock<ISytelineIdoClient>();
            _builder =
                FromSyteline.CustomerOrder.Where.CustomerNumber.Eq("WWTI001"); 
            _factory = new UpdateCollectionRequestFactory();
        };

        Because of = () =>
                                 {
            _req = _factory.GetUpdateCollectionRequest(ToSyteline.CustomerOrder,
                new LoadCollectionResponseWrapper(get_response_data()));

                                 };

  


        It should_provide_update_collection_envelope = () =>
        {
            _req.IDOName.ShouldEqual(CustomerOrder.IDO_NAME);
            _req.Items.Count().ShouldEqual(3);

        };

        private static LoadCollectionResponseData get_response_data()
        {
            var data = new LoadCollectionResponseData();
            data.Items.Add(new IDOItem() { ItemID = "1342" });
            data.Items.Add(new IDOItem() { ItemID = "1343" });
            data.Items.Add(new IDOItem() { ItemID = "1344" });
            return data;
        }
    }

    public class when_update_collection_envelope_is_requested_for_insert
    {
        static IUpdateCollectionRequestFactory _factory;
        static UpdateCollectionRequestData _req;
        static Mock<ILoadCollectionRequestFactory> _loadFactory;
        static Mock<ISytelineIdoClient> _client;
        
        Establish context = () =>
        {
            _loadFactory = new Mock<ILoadCollectionRequestFactory>();
            _client = new Mock<ISytelineIdoClient>();
            _factory = new UpdateCollectionRequestFactory();

        };

        Because of = () =>
                                 {

                                     _req =
                                         _factory.GetInsertCollectionRequest(ToSyteline.CustomerOrder.CustomerNumber(
                                                                                 "WWTI001").Carrier("01")
                                                                                 .OrderNumber("9230493").LinkProperty(
                                                                                 CustomerOrder.OrderNumber).WithChildren(
                                                                                 () => ToSyteline.CustomerOrderLineItems.
                                                                                     OrderNumber("9230493")
                                                                                     .Item("FIN23432343")
                                                                                     .LineNumber("1")
                                                                                     .Price("0.1234")
                                                                                     .QtyOrdered("23")
                                                                                     .LinkProperty(
                                                                                     CustomerOrderLineItem.OrderNumber)
                                                                                     .Action(UpdateAction.Insert),
                                                                               ()=>  ToSyteline.CustomerOrderLineItems.
                                                                                     OrderNumber("9230493")
                                                                                     .Item("FIN55432334")
                                                                                     .Price("1")
                                                                                     .QtyOrdered("1")
                                                                                     .LinkProperty(
                                                                                     CustomerOrderLineItem.OrderNumber)
                                                                                     .Action(UpdateAction.Insert)
                                                                                 ));
                                 };
        It should_provide_update_collection_envelope = () =>
        {
            _req.IDOName.ShouldEqual(CustomerOrder.IDO_NAME);
            _req.Items.Count().ShouldEqual(1);
            _req.ContainsNestedUpdateRequests().ShouldEqual(true);
        };


    }
}
