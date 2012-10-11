using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Machine.Specifications;
using Mongoose.IDO.Protocol;
using Moq;
using SytelineIntegrationTests;
using SytelineInterface.Core;
using SytelineInterface.Core.impl;
using SytelineInterface.Dsl;
using SytelineInterface.Factories;
using It=Machine.Specifications.It;

namespace SytelineUnitTests
{
    [Subject(typeof(SytelineIdoClient))]
    public class when_response_to_load_collection_has_no_results
    {
        private static ISytelineIdoClient _client;
        private static Foo _response;
        private static string _scalar;
        private static IEnumerable<Foo> _list;
        //Mocks
        private static Mock<ILoadCollectionRequestFactory> _loadFactory;
        private static Mock<IUpdateCollectionRequestFactory> _updateFactory;
        private static Mock<IMethodRequestFactory> _methodFactory;
        private static Mock<IClientWrapper> _innerClient;
        private static Mock<IUserSessionService> _userSessionService;
            Establish context = () =>
        {
            _loadFactory = new Mock<ILoadCollectionRequestFactory>();
            _updateFactory = new Mock<IUpdateCollectionRequestFactory>();
            _methodFactory = new Mock<IMethodRequestFactory>();
            _innerClient = new Mock<IClientWrapper>();
            _userSessionService = new Mock<IUserSessionService>(); 
            _innerClient.Setup(c => c.LoadCollection(Moq.It.IsAny<LoadCollectionRequestData>())).Returns(get_response_with_no_results());
            _client = new SytelineIdoClient(_innerClient.Object, _loadFactory.Object, 
                _updateFactory.Object, _methodFactory.Object, _userSessionService.Object);
        };

        private static LoadCollectionResponseData get_response_with_no_results()
        {
            return new LoadCollectionResponseData();
        }

        Because of = () =>
        {
            var loc = TestHelper.GetTestSyteline();
            _response = _client.GetObject<Foo>(loc,
                                        FromSyteline.Customers.CustomerNumber.Where.CustomerNumber.Eq("AAA"),MapFoo);
            _scalar = _client.GetScalar(loc, FromSyteline.Customers.CustomerNumber.Where.CustomerNumber.Eq("AAA"));
            _list = _client.GetList<Foo>(loc,
                                 FromSyteline.Customers.CustomerNumber.Where.CustomerNumber.Eq("AAA"), MapFoo);
        };

        private static Foo MapFoo(IdoItemWrapper idoItemWrapper)
        {
            throw new NotImplementedException();
        }


        It should_return_a_null_object = () =>
        {
            _response.ShouldBeNull(); 

        };

        private It should_return_a_null_scalar_value = () =>
                                                           {
                                                               _scalar.ShouldBeNull();
                                                           };

        private It should_return_an_empty_list = () =>
                                                     {
                                                         _list.Count().ShouldEqual(0);
                                                     };

    }

    internal class Foo
    {
    }
}