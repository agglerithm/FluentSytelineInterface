using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using Machine.Specifications;
using Mongoose.IDO.Protocol;
using Moq;
using SytelineIntegrationTests;
using SytelineInterface.Core;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;
using SytelineInterface.Factories;
using It=Machine.Specifications.It;

namespace SytelineUnitTests
{
    using SytelineInterface;

    public class ido_client_test_context
    {
        protected static ISytelineIdoClient _sut;
        protected static Mock<IClientWrapper> _client;
        protected static Mock<ILoadCollectionRequestFactory> _loadFactory;
        protected static Mock<IUpdateCollectionRequestFactory> _updateFactory;
        protected static Mock<IMethodRequestFactory> _methodFactory;
        protected static SLConfiguration _loc; 

        protected static Mock<IUpdateCollectionRequestFactory> get_update_factory()
        {
            var factory = new Mock<IUpdateCollectionRequestFactory>();


            return factory;
        }

        protected static Mock<IUserSessionService> get_session_service()
        {
            return new Mock<IUserSessionService>();
        }
        protected static Mock<ILoadCollectionRequestFactory> get_load_factory()
        {
            var factory = new Mock<ILoadCollectionRequestFactory>();


            return factory;
        }

        protected static Mock<IMethodRequestFactory> get_method_factory()
        {
            return new Mock<IMethodRequestFactory>();
        }

        protected static Mock<IClientWrapper> get_client()
        {
            var client = new Mock<IClientWrapper>();
            client.Setup(c => c.LoadCollection(null)).Returns(get_response());

            return client;
        }

        static LoadCollectionResponseData get_response()
        {

            var data = new LoadCollectionResponseData();
            data.PropertyList.Add(Customers.CustomerNumber);
            data.PropertyList.Add(Customers.Name);
            var item = new IDOItem() { ItemID = "1342" };
            item.PropertyValues.Add(new IDOPropertyValue("WWTI001"));
            item.PropertyValues.Add(new IDOPropertyValue("WWT"));
            data.Items.Add(item);
            item = new IDOItem() { ItemID = "1343" };
            item.PropertyValues.Add(new IDOPropertyValue("WWTI002"));
            item.PropertyValues.Add(new IDOPropertyValue("WWT2"));
            data.Items.Add(item);
            return data;
        }
    }

    [Subject("SytelineIdoClient")]
    public class when_ido_client_gets_scalar : ido_client_test_context
    {

        static string _result;
        Establish context = () =>
        {
            _client = get_client();
            _loadFactory = get_load_factory();
            _updateFactory = get_update_factory();
            _methodFactory = get_method_factory();
            _userSessionService = get_session_service();
            _loc = TestHelper.GetTestSyteline();
            _sut = new SytelineIdoClient(_client.Object, _loadFactory.Object, _updateFactory.Object, _methodFactory.Object, _userSessionService.Object);
        };




        Because of = () =>
        {
            _result = _sut.GetScalar(_loc, FromSyteline.Customers.CustomerNumber.Where<CustomersCriteria>(x => x.Name.Contains("FedEx")));
        };

 
        It should_return_scalar = () =>
        {
            _result.ShouldEqual("WWTI001");

        };

        private static Mock<IUserSessionService> _userSessionService;
    }

    [Subject("SytelineIdoClient")]
    public class when_ido_client_gets_object : ido_client_test_context
    {
        static CustomerEntity _result;
        
        Establish context = () =>
        {
            _client = get_client();
            _loadFactory = get_load_factory();
            _updateFactory = get_update_factory();
            _methodFactory = get_method_factory();
            _userSessionService = get_session_service();
            _loc = TestHelper.GetTestSyteline();
            _sut = new SytelineIdoClient(_client.Object, _loadFactory.Object, _updateFactory.Object, _methodFactory.Object, _userSessionService.Object);
        };


        Because of = () =>
                                 {
                                     
                                     _result = _sut.GetObject<CustomerEntity>(_loc, FromSyteline.Customers.CustomerNumber.Where<CustomersCriteria>(x => x.Name.Contains("FedEx")), map);
                                 };

        static CustomerEntity map(IdoItemWrapper record)
        {
            return new CustomerEntity()
                       {
                           CustomerID = record.GetValue(Customers.CustomerNumber).ToString(),
                           CustomerName = record.GetValue(Customers.Name).ToString(),
                       };
        }


        It should_return_object = () =>
        {
            _result.CustomerName.ShouldEqual("WWT");

        };

        private static Mock<IUserSessionService> _userSessionService;
    }

    [Subject("SytelineIdoClient")]
    public class when_ido_client_gets_list : ido_client_test_context
    {
        static IEnumerable<CustomerEntity> _result;
        
        Establish context = () =>
        {
            _client = get_client();
            _loadFactory = get_load_factory();
            _updateFactory = get_update_factory();
            _methodFactory = get_method_factory();
            _userSessionService = get_session_service();
            _loc = TestHelper.GetTestSyteline();
            _sut = new SytelineIdoClient(_client.Object, _loadFactory.Object, _updateFactory.Object, _methodFactory.Object, _userSessionService.Object);
        };


        Because of = () =>
        {

            _result = _sut.GetList<CustomerEntity>(_loc, FromSyteline.Customers.CustomerNumber.Where<CustomersCriteria>(x => x.Name.Contains("FedEx")), map);
        };

        static CustomerEntity map(IdoItemWrapper record)
        {
            return new CustomerEntity()
            {
                CustomerID = record.GetValue(Customers.CustomerNumber).ToString(),
                CustomerName = record.GetValue(Customers.Name).ToString(),
            };
        }


        It should_return_list_of_objects = () =>
        {
            _result.Count().ShouldEqual(2);

        };

        private static Mock<IUserSessionService> _userSessionService;
    }
}