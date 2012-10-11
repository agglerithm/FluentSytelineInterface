using System;
using System.Collections.Generic;
using System.Text;
using Machine.Specifications;
using Mongoose.IDO.Protocol;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Commands;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories.impl;

namespace SytelineUnitTests
{
    [Subject(typeof(UpdateCollectionRequestFactory))]
    public class when_passed_a_builder_with_delete_action
    {
        private static UpdateCollectionRequestFactory _factory;
        private static ItemForecastValues _builder;
        private static UpdateCollectionRequestData _data;
        Establish context = () =>
        {
            _factory = new UpdateCollectionRequestFactory();
            _builder = (ItemForecastValues) ToSyteline.ItemForecast.Action(UpdateAction.Delete);
        };

        Because of = () =>
        {
            _data = _factory.GetUpdateCollectionRequest(_builder, new LoadCollectionResponseWrapper(get_response_data()));
        };

        private static LoadCollectionResponseData get_response_data()
        {
            var data = new LoadCollectionResponseData();
            data.Items.Add(new IDOItem());
            return data;
        }


        It should_produce_request_with_delete_action = () =>
        {
            _data.Items.Count.ShouldEqual(1);
            _data.Items[0].Action.ShouldEqual(UpdateAction.Delete);

        };
    }

    [Subject(typeof(UpdateCollectionRequestFactory))]
    public class when_passed_a_builder_with_no_action_specified
    {
        private static UpdateCollectionRequestFactory _factory;
        private static ItemForecastValues _builder;
        private static UpdateCollectionRequestData _data;
        Establish context = () =>
        {
            _factory = new UpdateCollectionRequestFactory();
            _builder =  ToSyteline.ItemForecast;
        };

        Because of = () =>
        {
            _data = _factory.GetUpdateCollectionRequest(_builder, 
                new LoadCollectionResponseWrapper(get_response_data()));
        };

        It should_produce_request_with_update_action = () =>
        {
            _data.Items.Count.ShouldEqual(1);
            _data.Items[0].Action.ShouldEqual(UpdateAction.Update);

        };

        private static LoadCollectionResponseData get_response_data()
        {
            var data = new LoadCollectionResponseData();
            data.Items.Add(new IDOItem());
            return data;
        }
    }

    [Subject(typeof(UpdateCollectionRequestFactory))]
    public class when_a_builder_with_children_is_passed_to_factory
    {
        private static CustomerOrderValues _builder;
        private static UpdateCollectionRequestFactory _factory;
        private static UpdateCollectionRequestData _data;

        private Establish context = () =>
                                        {
                                            _factory = new UpdateCollectionRequestFactory();
                                            _builder = ToSyteline.CustomerOrder.ShippingInstructions("Instructions")
                                                           .WithChildren(() =>
                                                                         ToSyteline.CustomerOrderLineItems
                                                                             .UnitOfMeasure("EA")
                                                                             .LinkBy(CustomerOrder.OrderNumber,
                                                                                     CustomerOrderLineItem.OrderNumber)
                                                           ) as CustomerOrderValues;
                                        };

        private Because of = () =>
                                 {
                                     _data = _factory.GetUpdateCollectionRequest(_builder, new LoadCollectionResponseWrapper(get_response_data()));
                                 };

        private It should_cascade_update = () =>
                                               {
                                                   _data.Items[0].Action.ShouldEqual(UpdateAction.Update);
                                                   _data.Items[0].NestedUpdates[0].Items[0].Action.ShouldEqual(
                                                       UpdateAction.Update);
                                               };


       private static LoadCollectionResponseData get_response_data()
       {
           var customerOrderResponseData = new LoadCollectionResponseData();
           var customerOrderLineResponseData = new LoadCollectionResponseData();
           customerOrderLineResponseData.Items.Add(new IDOItem());
           customerOrderLineResponseData.IDOName = "SLCoitems";

           customerOrderResponseData.Items.Add(new IDOItem());


           customerOrderResponseData.Items[0].AddNestedResponse(customerOrderLineResponseData);
           return customerOrderResponseData;
        }

    }
}