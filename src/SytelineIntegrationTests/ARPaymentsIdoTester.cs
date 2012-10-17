using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    using SytelineInterface.Dsl.Commands;

    [TestFixture]
    public class ARPaymentsIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;

        [SetUp]
        public void setup()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder =
                ARPayments.GetFullProjection();
        }
        [Test, Explicit]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(ARPayments.AppliedAmt).ShouldBeTrue();
            resp.ContainsField(ARPayments.BalMethod).ShouldBeTrue();
            resp.ContainsField(ARPayments.BankCode).ShouldBeTrue();
            resp.ContainsField(ARPayments.DomesticCheckAmt).ShouldBeTrue();
            resp.ContainsField(ARPayments.CheckNum).ShouldBeTrue();
            resp.ContainsField(ARPayments.CreditMemoNum).ShouldBeTrue();
            resp.ContainsField(ARPayments.CurrCode).ShouldBeTrue();
            resp.ContainsField(ARPayments.CustNum).ShouldBeTrue();
            resp.ContainsField(ARPayments.CustomerName).ShouldBeTrue();
            resp.ContainsField(ARPayments.DecimalPlaces).ShouldBeTrue();
            resp.ContainsField(ARPayments.DepositDate).ShouldBeTrue();
            resp.ContainsField(ARPayments.Description).ShouldBeTrue();
            resp.ContainsField(ARPayments.DueDate).ShouldBeTrue();
            resp.ContainsField(ARPayments.EnablePrepaidAmt).ShouldBeTrue(); 
            resp.ContainsField(ARPayments.InWorkflow).ShouldBeTrue();
            resp.ContainsField(ARPayments.Message).ShouldBeTrue();
            resp.ContainsField(ARPayments.NoteExistsFlag).ShouldBeTrue();
            resp.ContainsField(ARPayments.PayTypeCode).ShouldBeTrue();
            resp.ContainsField(ARPayments.PayTypeDescription).ShouldBeTrue();
            resp.ContainsField(ARPayments.RecordDate).ShouldBeTrue();
            resp.ContainsField(ARPayments.RecptDate).ShouldBeTrue();
            resp.ContainsField(ARPayments.Ref).ShouldBeTrue();
            resp.ContainsField(ARPayments.RemainingAmt).ShouldBeTrue();
            resp.ContainsField(ARPayments.RowPointer).ShouldBeTrue();
            resp.ContainsField(ARPayments.TransferCash).ShouldBeTrue(); 
        }
    }
}
