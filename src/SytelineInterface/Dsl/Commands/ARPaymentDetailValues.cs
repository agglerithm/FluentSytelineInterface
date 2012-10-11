

using SytelineInterface.Core;
using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class ARPaymentDetailValues : IdoCommandBuilder
    {
        public ARPaymentDetailValues()
            : base(ARPaymentDetail.IDO_NAME)
        {
        }

        public ARPaymentDetailValues LinkBy(string parentField, string childField)
        {
            return (ARPaymentDetailValues)base.LinkBy(parentField, childField);
        }

        public ARPaymentDetailValues BankCode(string value)
        {
            AddValue(ARPaymentDetail.BankCode, value);
            return this;
        }

        public ARPaymentDetailValues AmountApplied(string value)
        {
            AddValue(ARPaymentDetail.AmtApplied, value);
            AddValue(ARPaymentDetail.ForAmtApplied, value);
            return this;
        }

        public ARPaymentDetailValues DiscountAmount(string value)
        {
            AddValue(ARPaymentDetail.DiscountAmount, value);
            AddValue(ARPaymentDetail.ForDiscountAmount, value);
            return this;
        }

        public ARPaymentDetailValues DiscountAccountUnit1(string value)
        {
            AddValue(ARPaymentDetail.DiscAcctUnit1, value);
            return this;
        }


        public ARPaymentDetailValues Site(string value)
        {
            AddValue(ARPaymentDetail.Site, value);
            return this;
        }

        public ARPaymentDetailValues OrderNumber(string value)
        {
            AddValue(ARPaymentDetail.OrderNumber, value);
            return this;
        }

        public ARPaymentDetailValues ApplyToCustomerNumber(string value)
        {
            AddValue(ARPaymentDetail.ApplyCustNum, value);
            return this;
        }

        public ARPaymentDetailValues CustomerNumber(string value)
        {
            AddValue(ARPaymentDetail.CustNum, value);
            return this;
        }

        public ARPaymentDetailValues CheckNumber(string value)
        {
            AddValue(ARPaymentDetail.CheckNum, value);
            return this;
        }

        public ARPaymentDetailValues InvoiceNumber(string value)
        {
            AddValue(ARPaymentDetail.InvNum, value);
            return this;
        }
        public ARPaymentDetailValues RowNumber(string value)
        {
            AddValue(IdoConstants.ROW_POINTER, value); return this;
        }

        public ARPaymentDetailValues ParentId(string value)
        {
            AddValue(ARPaymentDetail.ParentRowPointer, value); return this;
        }

        public ARPaymentDetailValues Type(string value)
        {
            AddValue(ARPaymentDetail.Type, value); return this;
        }

        public ARPaymentDetailValues DiscountAccount(string value)
        {
            AddValue(ARPaymentDetail.DiscAcct, value); return this;
        }
    }
}
