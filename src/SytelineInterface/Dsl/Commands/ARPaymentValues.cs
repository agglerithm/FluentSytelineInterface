

using SytelineInterface.Core;
using SytelineInterface.Dsl.Queries;

namespace SytelineInterface.Dsl.Commands
{
    public class ARPaymentValues : IdoCommandBuilder
    {
        public ARPaymentValues()
            : base(ARPayments.IDO_NAME)
        {
        }

        public ARPaymentValues Description(string value)
        {
            AddValue(ARPayments.Description, value);
            return this;
        }

        public ARPaymentValues GLReference(string value)
        {
            AddValue(ARPayments.Ref, value);
            return this;
        }

        public ARPaymentValues CustomerNumber(string value)
        {
            AddValue(ARPayments.CustNum, value);
            return this;
        }

        public ARPaymentValues DueDate(string value)
        {
            AddValue(ARPayments.DueDate, value);
            return this;
        }

        public ARPaymentValues CheckNumber(string value)
        {
            AddValue(ARPayments.CheckNum, value);
            return this;
        }

        public ARPaymentValues DepositDate(string value)
        {
            AddValue(ARPayments.DepositDate, value);
            return this;
        }
        public ARPaymentValues CheckDate(string value)
        {
            AddValue(ARPayments.RecptDate,value);
            return this;
        }

        public ARPaymentValues CheckAmount(string value)
        {
            AddValue(ARPayments.ForCheckAmt, value);
            return this;
        }

        public ARPaymentValues DomesticCheckAmount(string value)
        {
            AddValue(ARPayments.DomesticCheckAmt, value);
            return this;
        }
        public ARPaymentValues ForCheckAmount(string value)
        {
            AddValue(ARPayments.ForCheckAmt, value);
            return this;
        }

        public ARPaymentValues RowNumber(string value)
        {
            AddValue(IdoConstants.ROW_POINTER, value); 
            return this;
        }

        public ARPaymentValues BankCode(string value)
        {
            AddValue(ARPayments.BankCode, value);
            return this;
        }

        public ARPaymentValues Type(string value)
        {
            AddValue(ARPayments.Type, value);
            return this;
        }
    }
}
