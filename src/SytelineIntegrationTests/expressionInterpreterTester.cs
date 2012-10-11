using System;

using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Dsl;

namespace SytelineIntegrationTests
{
    [TestFixture]
    public class ExpressionInterpreterTester
    {
        private IExpressionInterpreter _interpreter;
        private string _addr = "123 ClassValue St";
        private string Address1 = "123 ClassObject St";

        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {
            _interpreter = ExpressionInterpreter.Build();
        }
        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test]
        public void can_parse_expr()
        {
            
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.Site == "AUS" && (c.Warehouse == "MAIN" || c.Warehouse == "VISTA") && c.BillToAddress1 != null && c.DiscountAmount == 0);
            condition.ShouldEqual(
                "(((( OrigSite  =  'AUS' ) AND (( Whse  =  'MAIN' ) OR ( Whse  =  'VISTA' ))) AND (NOT  BillToAddr_1  IS NULL) ) AND ( DiscAmount  =  0 ))");
        }

        [Test]
        public void can_parse_expr_with_variable()
        {
            var aus = "AUS";
            var main = "MAIN";
            var vista = "VISTA";
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.Site == aus && (c.Warehouse == main || c.Warehouse == vista) && c.BillToAddress1 != null && c.DiscountAmount == 0);
            condition.ShouldEqual(
                "(((( OrigSite  =  'AUS' ) AND (( Whse  =  'MAIN' ) OR ( Whse  =  'VISTA' ))) AND (NOT  BillToAddr_1  IS NULL) ) AND ( DiscAmount  =  0 ))");
        }


        [Test]
        public void can_parse_expr_with_date_variable()
        {
            var aus = "AUS";
            var main = "MAIN";
            var vista = "VISTA";
            var dte = DateTime.Today;
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.Site == aus && (c.Warehouse == main || c.Warehouse == vista) && c.OrderDate == dte);
            condition.ShouldEqual(
                string.Format("((( OrigSite  =  'AUS' ) AND (( Whse  =  'MAIN' ) OR ( Whse  =  'VISTA' ))) AND ( OrderDate  =  '{0}' ))", DateTime.Today));
        }
        [Test]
        public void can_parse_expr_with_date()
        {
            var aus = "AUS";
            var main = "MAIN";
            var vista = "VISTA";
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.Site == aus && (c.Warehouse == main || c.Warehouse == vista) && c.OrderDate == DateTime.Today);
            condition.ShouldEqual(
                string.Format("((( OrigSite  =  'AUS' ) AND (( Whse  =  'MAIN' ) OR ( Whse  =  'VISTA' ))) AND ( OrderDate  =  '{0}' ))", DateTime.Today));
        }


        [Test]
        public void can_parse_expr_with_null()
        { 
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.BillToAddress1 == null && null == c.BillToAddress2);
            condition.ShouldEqual(
                "(( BillToAddr_1  IS NULL)  AND ( BillToAddr_2  IS NULL) )");
        }

        [Test]
        public void can_parse_expr_with_not_null()
        { 
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.BillToAddress1 != null && null != c.BillToAddress2);
            condition.ShouldEqual(
                "((NOT  BillToAddr_1  IS NULL)  AND (NOT  BillToAddr_2  IS NULL) )");
        }


        [Test]
        public void can_parse_expr_with_different_type()
        { 
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(
                c => c.BillToAddress1 == "21 Elm St" && c.DiscountAmount == 0); 
            condition.ShouldEqual(
                 "(( BillToAddr_1  =  '21 Elm St' ) AND ( DiscAmount  =  0 ))");
        }

        [Test]
        public void can_parse_expr_with_method_parameter()
        {
            string condition = GetCondition(Address1,0);
            condition.ShouldEqual(
                 "(( BillToAddr_1  =  '123 ClassObject St' ) AND ( DiscAmount  = 0))");
        }

        private string GetCondition(string addr, int amt)
        {
            return _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(
                c => c.BillToAddress1 ==  Address1 && c.DiscountAmount == amt);
        }

        [Test]
        public void can_parse_expr_with_various_types()
        {
            var addr = "123 LocalObject St";
            var street = "123 LocalValue St";
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.BillToAddress1 == street 
                || c.BillToAddress1 == _addr
                || c.BillToAddress1 == addr 
                || c.BillToAddress1 ==  Address1
                );
            condition.ShouldEqual(
                "(((( BillToAddr_1  =  '123 LocalValue St' ) OR ( BillToAddr_1  =  '123 ClassValue St' )) OR ( BillToAddr_1  =  '123 LocalObject St' )) OR ( BillToAddr_1  =  '123 ClassObject St' ))");
        }

        [Test]
        public void can_parse_expr_with_null_variable()
        {
            var addr = "123 LocalObject St" ;
            var street = "123 LocalValue St";
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.BillToAddress2 == addr 
                );
            condition.ShouldEqual(
                "( BillToAddr_2  IS   NULL  )");
        }
        [Test]
        public void can_parse_expr_with_strings_and_ints()
        { 
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.BillToAddress1 ==  Address1
                && c.TermsCodeDueDays == 0
                );
            condition.ShouldEqual(
                "(( BillToAddr_1  =  '123 ClassObject St' ) AND ( TermsCodeDueDays  =  0 ))");
        }

        [Test]
        public void can_parse_expr_with_extension_method()
        {
            var addr =  "123 LocalObject St" ;
            var street = "123 LocalValue St";
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.BillToAddress1.Contains(street)
                );
            condition.ShouldEqual(
                " BillToAddr_1 LIKE '%123 LocalValue St%' ");
        }

        [Test]
        public void can_parse_expr_with_method_call()
        { 
            var street = "123 LocalValue St";
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.BillToAddress1 == street.Trim()
                );
            condition.ShouldEqual(
                "( BillToAddr_1  =  ltrim(rtrim('123 LocalValue St')) )");


            condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => street ==  c.BillToAddress1.Trim()
                );
            condition.ShouldEqual(
                "( '123 LocalValue St'  =  ltrim(rtrim(BillToAddr_1)) )");
        }

        [Test]
        public void can_parse_expr_with_negate()
        {
            var addr  = "123 LocalObject St" ;
            var street = "123 LocalValue St";
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => !c.BillToAddress1.Contains(street)
                );
            condition.ShouldEqual(
                " BillToAddr_1 NOT LIKE '%123 LocalValue St%' ");
             
        }

        [Test]
        public void can_parse_expr_with_isnull_extension_method()
        {
            var street = "123 LocalValue St";
            var condition =
                _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => string.IsNullOrEmpty(c.BillToAddress1)
                    );
            condition.ShouldEqual(
                " IsNull(BillToAddr_1, '') = '' ");
        }

        [Test]
        public void can_parse_expr_with_two_deep_property()
        {
            var cust   = "Vandalay Industries" ;
            var DiscountDays = 5;
            var condition = _interpreter.GetSytelineWhereClause<CustomerOrderCriteria>(c => c.TermsCodeDiscDays ==  DiscountDays
                );
            condition.ShouldEqual(
                "( TermsCodeDiscDays  =  5 )");
        }
        [TearDown]
        public void TearDownForEachTest()
        {

        }

        [TestFixtureTearDown]
        public void TearDownAfterAllTests()
        {

        }
    }
}
