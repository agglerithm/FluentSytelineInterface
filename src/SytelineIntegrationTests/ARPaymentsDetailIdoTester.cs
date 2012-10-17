using Machine.Specifications;
using NUnit.Framework;
using SytelineInterface.Core;
using SytelineInterface.Dsl;
using SytelineInterface.Dsl.Queries;

namespace SytelineIntegrationTests
{
    using SytelineInterface.Dsl.Commands;

    [TestFixture]
    public class ARPaymentsDetailIdoTester
    {
        private IIdoQueryBuilder _builder;
        private ISytelineIdoClient _client;

        [SetUp]
        public void setup()
        {
            _client = TestHelper.GetTestIdoClient();
            _builder =
                FromSyteline.ARPaymentDetail.AlChtAccessUnit1.AlChtAccessUnit2.AlChtAccessUnit3.AlChtAccessUnit4
                    .AlChtDescription.AllowAcct.AllowAcctUnit1.AllowAcctUnit2.AllowAcctUnit3.AlChtAccessUnit4
                    .CheckAmt.DueDate.RecptDate
                    .ParentRowPointer.BankCode.CheckNum.CoNum.CreditMemoNum.DecimalPlaces.CustomerName
                    .CustNum.BalMethod.CurrCode.DeChtAccessUnit1.DeChtAccessUnit2
            .DeChtAccessUnit3.DeChtAccessUnit4.DeChtDescription.DepositAcct.DepositAcctUnit1.DepositAcctUnit2
            .DepositAcctUnit3.DepositAcctUnit4.PayTypeCode.DerAvailCustDrft.DerDefaultType
                    .AmtBalance.AmtRemaining
                    .AllowAmt.AmtApplied.DerOrigForAllowAmt
                    .InvNum.InWorkflow.NoteExistsFlag.RecordDate.RowPointer.Site;
        }

        [Test]
        public void can_get_records_from_ido()
        {
            var resp = _client.GetData(TestHelper.GetTestSyteline(), _builder);
            resp.ContainsField(ARPaymentDetail.AmtApplied).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.BalMethod).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.BankCode).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.CheckAmt).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.CheckNum).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.CreditMemoNum).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.CurrCode).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.CustNum).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.CustomerName).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.DecimalPlaces).ShouldBeTrue(); 
            resp.ContainsField(ARPaymentDetail.DueDate).ShouldBeTrue(); 
            resp.ContainsField(ARPaymentDetail.InWorkflow).ShouldBeTrue(); 
            resp.ContainsField(ARPaymentDetail.NoteExistsFlag).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.PayTypeCode).ShouldBeTrue(); 
            resp.ContainsField(ARPaymentDetail.RecordDate).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.RecptDate).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.AmtRemaining).ShouldBeTrue();
            resp.ContainsField(ARPaymentDetail.AmtBalance).ShouldBeTrue(); 
            resp.ContainsField(ARPaymentDetail.RowPointer).ShouldBeTrue(); 
        }
    }
}
