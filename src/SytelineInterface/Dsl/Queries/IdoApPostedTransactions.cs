using SytelineInterface.Core;

                namespace SytelineInterface.Dsl
                {
                    public class IdoApPostedTransactions : IdoConstants
                    {
                        public const string IDO_NAME = "SLAptrxps";
                        public const string Active = "Active";
                        public const string AmtDisc = "AmtDisc";
                        public const string AmtPaid = "AmtPaid";
                        public const string ApAcct = "ApAcct";
                        public const string ApAcctUnit1 = "ApAcctUnit1";
                        public const string ApAcctUnit2 = "ApAcctUnit2";
                        public const string ApAcctUnit3 = "ApAcctUnit3";
                        public const string ApAcctUnit4 = "ApAcctUnit4";
                        public const string BrokerageAmt = "BrokerageAmt";
                        public const string BuilderPoNum = "BuilderPoNum";
                        public const string BuilderPoOrigSite = "BuilderPoOrigSite";
                        public const string BuilderVoucher = "BuilderVoucher";
                        public const string BuilderVoucherOrigSite = "BuilderVoucherOrigSite";
                        public const string ChartAccessUnit1 = "ChartAccessUnit1";
                        public const string ChartAccessUnit2 = "ChartAccessUnit2";
                        public const string ChartAccessUnit3 = "ChartAccessUnit3";
                        public const string ChartAccessUnit4 = "ChartAccessUnit4";
                        public const string ChartAcct = "ChartAcct";
                        public const string ChartDescription = "ChartDescription";
                        public const string ChartEffDate = "ChartEffDate";
                        public const string ChartNoteExistsFlag = "ChartNoteExistsFlag";
                        public const string ChartObsDate = "ChartObsDate";
                        public const string ChartRecordDate = "ChartRecordDate";
                        public const string ChartReportsToAcct = "ChartReportsToAcct";
                        public const string ChartRowPointer = "ChartRowPointer";
                        public const string ChartTransMethod = "ChartTransMethod";
                        public const string ChartType = "ChartType";
                        public const string ChartUseBuyRate = "ChartUseBuyRate";
                        public const string CheckNum = "CheckNum";
                        public const string DerAmtBal = "DerAmtBal";
                        public const string DerInvAdj = "DerInvAdj";
                        public const string DerMessage = "DerMessage";
                        public const string DerTypeDescription = "DerTypeDescription";
                        public const string DiscAmt = "DiscAmt";
                        public const string DiscDate = "DiscDate";
                        public const string DiscDays = "DiscDays";
                        public const string DiscPct = "DiscPct";
                        public const string DistDate = "DistDate";
                        public const string DueDate = "DueDate";
                        public const string DueDays = "DueDays";
                        public const string DutyAmt = "DutyAmt";
                        public const string ExchRate = "ExchRate";
                        public const string FixedRate = "FixedRate";
                        public const string Freight = "Freight";
                        public const string GrnNum = "GrnNum";
                        public const string HoldFlag = "HoldFlag";
                        public const string InvAmt = "InvAmt";
                        public const string InvDate = "InvDate";
                        public const string InvNum = "InvNum";
                        public const string InWorkflow = "InWorkflow";
                        public const string MiscCharges = "MiscCharges";
                        public const string NonDiscAmt = "NonDiscAmt";
                        public const string NoteExistsFlag = "NoteExistsFlag";
                        public const string PoNum = "PoNum";
                        public const string ProxDay = "ProxDay";
                        public const string PurchAmt = "PurchAmt";
                        public const string RecordDate = "RecordDate";
                        public const string Ref = "Ref";
                        public const string RowPointer = "RowPointer";
                        public const string SalesTax = "SalesTax";
                        public const string SalesTax_2 = "SalesTax_2";
                        public const string TaxCode1 = "TaxCode1";
                        public const string TaxCode2 = "TaxCode2";
                        public const string Txt = "Txt";
                        public const string Type = "Type";
                        public const string VendaddrAddr_1 = "VendaddrAddr_1";
                        public const string VendaddrAddr_2 = "VendaddrAddr_2";
                        public const string VendaddrAddr_3 = "VendaddrAddr_3";
                        public const string VendaddrAddr_4 = "VendaddrAddr_4";
                        public const string VendaddrCity = "VendaddrCity";
                        public const string VendaddrCountry = "VendaddrCountry";
                        public const string VendaddrCounty = "VendaddrCounty";
                        public const string VendaddrExternalEmailAddr = "VendaddrExternalEmailAddr";
                        public const string VendaddrFaxNum = "VendaddrFaxNum";
                        public const string VendaddrInternalEmailAddr = "VendaddrInternalEmailAddr";
                        public const string VendaddrInternetUrl = "VendaddrInternetUrl";
                        public const string VendaddrName = "VendaddrName";
                        public const string VendaddrNoteExistsFlag = "VendaddrNoteExistsFlag";
                        public const string VendaddrPayHold = "VendaddrPayHold";
                        public const string VendaddrPayHoldDate = "VendaddrPayHoldDate";
                        public const string VendaddrPayHoldReason = "VendaddrPayHoldReason";
                        public const string VendaddrPayHoldUser = "VendaddrPayHoldUser";
                        public const string VendaddrRecordDate = "VendaddrRecordDate";
                        public const string VendaddrRowPointer = "VendaddrRowPointer";
                        public const string VendaddrState = "VendaddrState";
                        public const string VendaddrTelexNum = "VendaddrTelexNum";
                        public const string VendaddrVendNum = "VendaddrVendNum";
                        public const string VendaddrZip = "VendaddrZip";
                        public const string VendNum = "VendNum";
                        public const string VendorBankCode = "VendorBankCode";
                        public const string VendorBranchId = "VendorBranchId";
                        public const string VendorCategory = "VendorCategory";
                        public const string VendorCharfld1 = "VendorCharfld1";
                        public const string VendorCharfld2 = "VendorCharfld2";
                        public const string VendorCharfld3 = "VendorCharfld3";
                        public const string VendorContact = "VendorContact";
                        public const string VendorCurrCode = "VendorCurrCode";
                        public const string VendorDatefld = "VendorDatefld";
                        public const string VendorDecifld1 = "VendorDecifld1";
                        public const string VendorDecifld2 = "VendorDecifld2";
                        public const string VendorDecifld3 = "VendorDecifld3";
                        public const string VendorDelterm = "VendorDelterm";
                        public const string VendorDiscLstYr = "VendorDiscLstYr";
                        public const string VendorDiscYtd = "VendorDiscYtd";
                        public const string VendorEdiVend = "VendorEdiVend";
                        public const string VendorFob = "VendorFob";
                        public const string VendorLangCode = "VendorLangCode";
                        public const string VendorLastPaid = "VendorLastPaid";
                        public const string VendorLastPurch = "VendorLastPurch";
                        public const string VendorLcrReqd = "VendorLcrReqd";
                        public const string VendorLogifld = "VendorLogifld";
                        public const string VendorNoteExistsFlag = "VendorNoteExistsFlag";
                        public const string VendorPayLstYr = "VendorPayLstYr";
                        public const string VendorPayType = "VendorPayType";
                        public const string VendorPayYtd = "VendorPayYtd";
                        public const string VendorPhone = "VendorPhone";
                        public const string VendorPrintPrice = "VendorPrintPrice";
                        public const string VendorProcessInd = "VendorProcessInd";
                        public const string VendorPurAcct = "VendorPurAcct";
                        public const string VendorPurAcctUnit1 = "VendorPurAcctUnit1";
                        public const string VendorPurAcctUnit2 = "VendorPurAcctUnit2";
                        public const string VendorPurAcctUnit3 = "VendorPurAcctUnit3";
                        public const string VendorPurAcctUnit4 = "VendorPurAcctUnit4";
                        public const string VendorPurchLstYr = "VendorPurchLstYr";
                        public const string VendorPurchYtd = "VendorPurchYtd";
                        public const string VendorRecordDate = "VendorRecordDate";
                        public const string VendorRowPointer = "VendorRowPointer";
                        public const string VendorShipCode = "VendorShipCode";
                        public const string VendorStat = "VendorStat";
                        public const string VendorTaxCode1 = "VendorTaxCode1";
                        public const string VendorTaxCode2 = "VendorTaxCode2";
                        public const string VendorTaxRegNum1 = "VendorTaxRegNum1";
                        public const string VendorTaxRegNum2 = "VendorTaxRegNum2";
                        public const string VendorTermsCode = "VendorTermsCode";
                        public const string VendorTransNat = "VendorTransNat";
                        public const string VendorUserId = "VendorUserId";
                        public const string VendorVendNum = "VendorVendNum";
                        public const string VendorVendRemit = "VendorVendRemit";
                        public const string VendorVendType = "VendorVendType";
                        public const string VendorWhse = "VendorWhse";
                        public const string VenTermsCode = "VenTermsCode";
                        public const string Voucher = "Voucher";
                        public const string VouchSeq = "VouchSeq";


                    }

                    public class IdoApPostedTransactionsBuilder
                        : IdoQueryBuilder<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>
                    {
                        public IdoApPostedTransactionsBuilder(IExpressionInterpreter interpreter) : base(IdoApPostedTransactions.IDO_NAME, interpreter) { }

                        public IdoApPostedTransactionsBuilder Active { get { AddProperty(IdoApPostedTransactions.Active); return this; } }
                        public IdoApPostedTransactionsBuilder AmtDisc { get { AddProperty(IdoApPostedTransactions.AmtDisc); return this; } }
                        public IdoApPostedTransactionsBuilder AmtPaid { get { AddProperty(IdoApPostedTransactions.AmtPaid); return this; } }
                        public IdoApPostedTransactionsBuilder ApAcct { get { AddProperty(IdoApPostedTransactions.ApAcct); return this; } }
                        public IdoApPostedTransactionsBuilder ApAcctUnit1 { get { AddProperty(IdoApPostedTransactions.ApAcctUnit1); return this; } }
                        public IdoApPostedTransactionsBuilder ApAcctUnit2 { get { AddProperty(IdoApPostedTransactions.ApAcctUnit2); return this; } }
                        public IdoApPostedTransactionsBuilder ApAcctUnit3 { get { AddProperty(IdoApPostedTransactions.ApAcctUnit3); return this; } }
                        public IdoApPostedTransactionsBuilder ApAcctUnit4 { get { AddProperty(IdoApPostedTransactions.ApAcctUnit4); return this; } }
                        public IdoApPostedTransactionsBuilder BrokerageAmt { get { AddProperty(IdoApPostedTransactions.BrokerageAmt); return this; } }
                        public IdoApPostedTransactionsBuilder BuilderPoNum { get { AddProperty(IdoApPostedTransactions.BuilderPoNum); return this; } }
                        public IdoApPostedTransactionsBuilder BuilderPoOrigSite { get { AddProperty(IdoApPostedTransactions.BuilderPoOrigSite); return this; } }
                        public IdoApPostedTransactionsBuilder BuilderVoucher { get { AddProperty(IdoApPostedTransactions.BuilderVoucher); return this; } }
                        public IdoApPostedTransactionsBuilder BuilderVoucherOrigSite { get { AddProperty(IdoApPostedTransactions.BuilderVoucherOrigSite); return this; } }
                        public IdoApPostedTransactionsBuilder ChartAccessUnit1 { get { AddProperty(IdoApPostedTransactions.ChartAccessUnit1); return this; } }
                        public IdoApPostedTransactionsBuilder ChartAccessUnit2 { get { AddProperty(IdoApPostedTransactions.ChartAccessUnit2); return this; } }
                        public IdoApPostedTransactionsBuilder ChartAccessUnit3 { get { AddProperty(IdoApPostedTransactions.ChartAccessUnit3); return this; } }
                        public IdoApPostedTransactionsBuilder ChartAccessUnit4 { get { AddProperty(IdoApPostedTransactions.ChartAccessUnit4); return this; } }
                        public IdoApPostedTransactionsBuilder ChartAcct { get { AddProperty(IdoApPostedTransactions.ChartAcct); return this; } }
                        public IdoApPostedTransactionsBuilder ChartDescription { get { AddProperty(IdoApPostedTransactions.ChartDescription); return this; } }
                        public IdoApPostedTransactionsBuilder ChartEffDate { get { AddProperty(IdoApPostedTransactions.ChartEffDate); return this; } }
                        public IdoApPostedTransactionsBuilder ChartNoteExistsFlag { get { AddProperty(IdoApPostedTransactions.ChartNoteExistsFlag); return this; } }
                        public IdoApPostedTransactionsBuilder ChartObsDate { get { AddProperty(IdoApPostedTransactions.ChartObsDate); return this; } }
                        public IdoApPostedTransactionsBuilder ChartRecordDate { get { AddProperty(IdoApPostedTransactions.ChartRecordDate); return this; } }
                        public IdoApPostedTransactionsBuilder ChartReportsToAcct { get { AddProperty(IdoApPostedTransactions.ChartReportsToAcct); return this; } }
                        public IdoApPostedTransactionsBuilder ChartRowPointer { get { AddProperty(IdoApPostedTransactions.ChartRowPointer); return this; } }
                        public IdoApPostedTransactionsBuilder ChartTransMethod { get { AddProperty(IdoApPostedTransactions.ChartTransMethod); return this; } }
                        public IdoApPostedTransactionsBuilder ChartType { get { AddProperty(IdoApPostedTransactions.ChartType); return this; } }
                        public IdoApPostedTransactionsBuilder ChartUseBuyRate { get { AddProperty(IdoApPostedTransactions.ChartUseBuyRate); return this; } }
                        public IdoApPostedTransactionsBuilder CheckNum { get { AddProperty(IdoApPostedTransactions.CheckNum); return this; } }
                        public IdoApPostedTransactionsBuilder DerAmtBal { get { AddProperty(IdoApPostedTransactions.DerAmtBal); return this; } }
                        public IdoApPostedTransactionsBuilder DerInvAdj { get { AddProperty(IdoApPostedTransactions.DerInvAdj); return this; } }
                        public IdoApPostedTransactionsBuilder DerMessage { get { AddProperty(IdoApPostedTransactions.DerMessage); return this; } }
                        public IdoApPostedTransactionsBuilder DerTypeDescription { get { AddProperty(IdoApPostedTransactions.DerTypeDescription); return this; } }
                        public IdoApPostedTransactionsBuilder DiscAmt { get { AddProperty(IdoApPostedTransactions.DiscAmt); return this; } }
                        public IdoApPostedTransactionsBuilder DiscDate { get { AddProperty(IdoApPostedTransactions.DiscDate); return this; } }
                        public IdoApPostedTransactionsBuilder DiscDays { get { AddProperty(IdoApPostedTransactions.DiscDays); return this; } }
                        public IdoApPostedTransactionsBuilder DiscPct { get { AddProperty(IdoApPostedTransactions.DiscPct); return this; } }
                        public IdoApPostedTransactionsBuilder DistDate { get { AddProperty(IdoApPostedTransactions.DistDate); return this; } }
                        public IdoApPostedTransactionsBuilder DueDate { get { AddProperty(IdoApPostedTransactions.DueDate); return this; } }
                        public IdoApPostedTransactionsBuilder DueDays { get { AddProperty(IdoApPostedTransactions.DueDays); return this; } }
                        public IdoApPostedTransactionsBuilder DutyAmt { get { AddProperty(IdoApPostedTransactions.DutyAmt); return this; } }
                        public IdoApPostedTransactionsBuilder ExchRate { get { AddProperty(IdoApPostedTransactions.ExchRate); return this; } }
                        public IdoApPostedTransactionsBuilder FixedRate { get { AddProperty(IdoApPostedTransactions.FixedRate); return this; } }
                        public IdoApPostedTransactionsBuilder Freight { get { AddProperty(IdoApPostedTransactions.Freight); return this; } }
                        public IdoApPostedTransactionsBuilder GrnNum { get { AddProperty(IdoApPostedTransactions.GrnNum); return this; } }
                        public IdoApPostedTransactionsBuilder HoldFlag { get { AddProperty(IdoApPostedTransactions.HoldFlag); return this; } }
                        public IdoApPostedTransactionsBuilder InvAmt { get { AddProperty(IdoApPostedTransactions.InvAmt); return this; } }
                        public IdoApPostedTransactionsBuilder InvDate { get { AddProperty(IdoApPostedTransactions.InvDate); return this; } }
                        public IdoApPostedTransactionsBuilder InvNum { get { AddProperty(IdoApPostedTransactions.InvNum); return this; } }
                        public IdoApPostedTransactionsBuilder InWorkflow { get { AddProperty(IdoApPostedTransactions.InWorkflow); return this; } }
                        public IdoApPostedTransactionsBuilder MiscCharges { get { AddProperty(IdoApPostedTransactions.MiscCharges); return this; } }
                        public IdoApPostedTransactionsBuilder NonDiscAmt { get { AddProperty(IdoApPostedTransactions.NonDiscAmt); return this; } }
                        public IdoApPostedTransactionsBuilder NoteExistsFlag { get { AddProperty(IdoApPostedTransactions.NoteExistsFlag); return this; } }
                        public IdoApPostedTransactionsBuilder PoNum { get { AddProperty(IdoApPostedTransactions.PoNum); return this; } }
                        public IdoApPostedTransactionsBuilder ProxDay { get { AddProperty(IdoApPostedTransactions.ProxDay); return this; } }
                        public IdoApPostedTransactionsBuilder PurchAmt { get { AddProperty(IdoApPostedTransactions.PurchAmt); return this; } }
                        public IdoApPostedTransactionsBuilder RecordDate { get { AddProperty(IdoApPostedTransactions.RecordDate); return this; } }
                        public IdoApPostedTransactionsBuilder Ref { get { AddProperty(IdoApPostedTransactions.Ref); return this; } }
                        public IdoApPostedTransactionsBuilder RowPointer { get { AddProperty(IdoApPostedTransactions.RowPointer); return this; } }
                        public IdoApPostedTransactionsBuilder SalesTax { get { AddProperty(IdoApPostedTransactions.SalesTax); return this; } }
                        public IdoApPostedTransactionsBuilder SalesTax_2 { get { AddProperty(IdoApPostedTransactions.SalesTax_2); return this; } }
                        public IdoApPostedTransactionsBuilder TaxCode1 { get { AddProperty(IdoApPostedTransactions.TaxCode1); return this; } }
                        public IdoApPostedTransactionsBuilder TaxCode2 { get { AddProperty(IdoApPostedTransactions.TaxCode2); return this; } }
                        public IdoApPostedTransactionsBuilder Txt { get { AddProperty(IdoApPostedTransactions.Txt); return this; } }
                        public IdoApPostedTransactionsBuilder Type { get { AddProperty(IdoApPostedTransactions.Type); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrAddr_1 { get { AddProperty(IdoApPostedTransactions.VendaddrAddr_1); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrAddr_2 { get { AddProperty(IdoApPostedTransactions.VendaddrAddr_2); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrAddr_3 { get { AddProperty(IdoApPostedTransactions.VendaddrAddr_3); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrAddr_4 { get { AddProperty(IdoApPostedTransactions.VendaddrAddr_4); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrCity { get { AddProperty(IdoApPostedTransactions.VendaddrCity); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrCountry { get { AddProperty(IdoApPostedTransactions.VendaddrCountry); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrCounty { get { AddProperty(IdoApPostedTransactions.VendaddrCounty); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrExternalEmailAddr { get { AddProperty(IdoApPostedTransactions.VendaddrExternalEmailAddr); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrFaxNum { get { AddProperty(IdoApPostedTransactions.VendaddrFaxNum); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrInternalEmailAddr { get { AddProperty(IdoApPostedTransactions.VendaddrInternalEmailAddr); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrInternetUrl { get { AddProperty(IdoApPostedTransactions.VendaddrInternetUrl); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrName { get { AddProperty(IdoApPostedTransactions.VendaddrName); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrNoteExistsFlag { get { AddProperty(IdoApPostedTransactions.VendaddrNoteExistsFlag); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrPayHold { get { AddProperty(IdoApPostedTransactions.VendaddrPayHold); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrPayHoldDate { get { AddProperty(IdoApPostedTransactions.VendaddrPayHoldDate); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrPayHoldReason { get { AddProperty(IdoApPostedTransactions.VendaddrPayHoldReason); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrPayHoldUser { get { AddProperty(IdoApPostedTransactions.VendaddrPayHoldUser); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrRecordDate { get { AddProperty(IdoApPostedTransactions.VendaddrRecordDate); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrRowPointer { get { AddProperty(IdoApPostedTransactions.VendaddrRowPointer); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrState { get { AddProperty(IdoApPostedTransactions.VendaddrState); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrTelexNum { get { AddProperty(IdoApPostedTransactions.VendaddrTelexNum); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrVendNum { get { AddProperty(IdoApPostedTransactions.VendaddrVendNum); return this; } }
                        public IdoApPostedTransactionsBuilder VendaddrZip { get { AddProperty(IdoApPostedTransactions.VendaddrZip); return this; } }
                        public IdoApPostedTransactionsBuilder VendNum { get { AddProperty(IdoApPostedTransactions.VendNum); return this; } }
                        public IdoApPostedTransactionsBuilder VendorBankCode { get { AddProperty(IdoApPostedTransactions.VendorBankCode); return this; } }
                        public IdoApPostedTransactionsBuilder VendorBranchId { get { AddProperty(IdoApPostedTransactions.VendorBranchId); return this; } }
                        public IdoApPostedTransactionsBuilder VendorCategory { get { AddProperty(IdoApPostedTransactions.VendorCategory); return this; } }
                        public IdoApPostedTransactionsBuilder VendorCharfld1 { get { AddProperty(IdoApPostedTransactions.VendorCharfld1); return this; } }
                        public IdoApPostedTransactionsBuilder VendorCharfld2 { get { AddProperty(IdoApPostedTransactions.VendorCharfld2); return this; } }
                        public IdoApPostedTransactionsBuilder VendorCharfld3 { get { AddProperty(IdoApPostedTransactions.VendorCharfld3); return this; } }
                        public IdoApPostedTransactionsBuilder VendorContact { get { AddProperty(IdoApPostedTransactions.VendorContact); return this; } }
                        public IdoApPostedTransactionsBuilder VendorCurrCode { get { AddProperty(IdoApPostedTransactions.VendorCurrCode); return this; } }
                        public IdoApPostedTransactionsBuilder VendorDatefld { get { AddProperty(IdoApPostedTransactions.VendorDatefld); return this; } }
                        public IdoApPostedTransactionsBuilder VendorDecifld1 { get { AddProperty(IdoApPostedTransactions.VendorDecifld1); return this; } }
                        public IdoApPostedTransactionsBuilder VendorDecifld2 { get { AddProperty(IdoApPostedTransactions.VendorDecifld2); return this; } }
                        public IdoApPostedTransactionsBuilder VendorDecifld3 { get { AddProperty(IdoApPostedTransactions.VendorDecifld3); return this; } }
                        public IdoApPostedTransactionsBuilder VendorDelterm { get { AddProperty(IdoApPostedTransactions.VendorDelterm); return this; } }
                        public IdoApPostedTransactionsBuilder VendorDiscLstYr { get { AddProperty(IdoApPostedTransactions.VendorDiscLstYr); return this; } }
                        public IdoApPostedTransactionsBuilder VendorDiscYtd { get { AddProperty(IdoApPostedTransactions.VendorDiscYtd); return this; } }
                        public IdoApPostedTransactionsBuilder VendorEdiVend { get { AddProperty(IdoApPostedTransactions.VendorEdiVend); return this; } }
                        public IdoApPostedTransactionsBuilder VendorFob { get { AddProperty(IdoApPostedTransactions.VendorFob); return this; } }
                        public IdoApPostedTransactionsBuilder VendorLangCode { get { AddProperty(IdoApPostedTransactions.VendorLangCode); return this; } }
                        public IdoApPostedTransactionsBuilder VendorLastPaid { get { AddProperty(IdoApPostedTransactions.VendorLastPaid); return this; } }
                        public IdoApPostedTransactionsBuilder VendorLastPurch { get { AddProperty(IdoApPostedTransactions.VendorLastPurch); return this; } }
                        public IdoApPostedTransactionsBuilder VendorLcrReqd { get { AddProperty(IdoApPostedTransactions.VendorLcrReqd); return this; } }
                        public IdoApPostedTransactionsBuilder VendorLogifld { get { AddProperty(IdoApPostedTransactions.VendorLogifld); return this; } }
                        public IdoApPostedTransactionsBuilder VendorNoteExistsFlag { get { AddProperty(IdoApPostedTransactions.VendorNoteExistsFlag); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPayLstYr { get { AddProperty(IdoApPostedTransactions.VendorPayLstYr); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPayType { get { AddProperty(IdoApPostedTransactions.VendorPayType); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPayYtd { get { AddProperty(IdoApPostedTransactions.VendorPayYtd); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPhone { get { AddProperty(IdoApPostedTransactions.VendorPhone); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPrintPrice { get { AddProperty(IdoApPostedTransactions.VendorPrintPrice); return this; } }
                        public IdoApPostedTransactionsBuilder VendorProcessInd { get { AddProperty(IdoApPostedTransactions.VendorProcessInd); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPurAcct { get { AddProperty(IdoApPostedTransactions.VendorPurAcct); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPurAcctUnit1 { get { AddProperty(IdoApPostedTransactions.VendorPurAcctUnit1); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPurAcctUnit2 { get { AddProperty(IdoApPostedTransactions.VendorPurAcctUnit2); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPurAcctUnit3 { get { AddProperty(IdoApPostedTransactions.VendorPurAcctUnit3); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPurAcctUnit4 { get { AddProperty(IdoApPostedTransactions.VendorPurAcctUnit4); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPurchLstYr { get { AddProperty(IdoApPostedTransactions.VendorPurchLstYr); return this; } }
                        public IdoApPostedTransactionsBuilder VendorPurchYtd { get { AddProperty(IdoApPostedTransactions.VendorPurchYtd); return this; } }
                        public IdoApPostedTransactionsBuilder VendorRecordDate { get { AddProperty(IdoApPostedTransactions.VendorRecordDate); return this; } }
                        public IdoApPostedTransactionsBuilder VendorRowPointer { get { AddProperty(IdoApPostedTransactions.VendorRowPointer); return this; } }
                        public IdoApPostedTransactionsBuilder VendorShipCode { get { AddProperty(IdoApPostedTransactions.VendorShipCode); return this; } }
                        public IdoApPostedTransactionsBuilder VendorStat { get { AddProperty(IdoApPostedTransactions.VendorStat); return this; } }
                        public IdoApPostedTransactionsBuilder VendorTaxCode1 { get { AddProperty(IdoApPostedTransactions.VendorTaxCode1); return this; } }
                        public IdoApPostedTransactionsBuilder VendorTaxCode2 { get { AddProperty(IdoApPostedTransactions.VendorTaxCode2); return this; } }
                        public IdoApPostedTransactionsBuilder VendorTaxRegNum1 { get { AddProperty(IdoApPostedTransactions.VendorTaxRegNum1); return this; } }
                        public IdoApPostedTransactionsBuilder VendorTaxRegNum2 { get { AddProperty(IdoApPostedTransactions.VendorTaxRegNum2); return this; } }
                        public IdoApPostedTransactionsBuilder VendorTermsCode { get { AddProperty(IdoApPostedTransactions.VendorTermsCode); return this; } }
                        public IdoApPostedTransactionsBuilder VendorTransNat { get { AddProperty(IdoApPostedTransactions.VendorTransNat); return this; } }
                        public IdoApPostedTransactionsBuilder VendorUserId { get { AddProperty(IdoApPostedTransactions.VendorUserId); return this; } }
                        public IdoApPostedTransactionsBuilder VendorVendNum { get { AddProperty(IdoApPostedTransactions.VendorVendNum); return this; } }
                        public IdoApPostedTransactionsBuilder VendorVendRemit { get { AddProperty(IdoApPostedTransactions.VendorVendRemit); return this; } }
                        public IdoApPostedTransactionsBuilder VendorVendType { get { AddProperty(IdoApPostedTransactions.VendorVendType); return this; } }
                        public IdoApPostedTransactionsBuilder VendorWhse { get { AddProperty(IdoApPostedTransactions.VendorWhse); return this; } }
                        public IdoApPostedTransactionsBuilder VenTermsCode { get { AddProperty(IdoApPostedTransactions.VenTermsCode); return this; } }
                        public IdoApPostedTransactionsBuilder Voucher { get { AddProperty(IdoApPostedTransactions.Voucher); return this; } }
                        public IdoApPostedTransactionsBuilder VouchSeq { get { AddProperty(IdoApPostedTransactions.VouchSeq); return this; } }


                    }

                    public class SLAptrxpsFilterExpressionBuilder
                        : FilterExpressionBuilder<IdoApPostedTransactionsBuilder>
                    {
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> Active
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.Active); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> AmtDisc
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.AmtDisc); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> AmtPaid
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.AmtPaid); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ApAcct
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ApAcct); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ApAcctUnit1
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ApAcctUnit1); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ApAcctUnit2
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ApAcctUnit2); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ApAcctUnit3
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ApAcctUnit3); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ApAcctUnit4
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ApAcctUnit4); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> BrokerageAmt
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.BrokerageAmt); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> BuilderPoNum
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.BuilderPoNum); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> BuilderPoOrigSite
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.BuilderPoOrigSite); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> BuilderVoucher
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.BuilderVoucher); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> BuilderVoucherOrigSite
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.BuilderVoucherOrigSite); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartAccessUnit1
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartAccessUnit1); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartAccessUnit2
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartAccessUnit2); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartAccessUnit3
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartAccessUnit3); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartAccessUnit4
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartAccessUnit4); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartAcct
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartAcct); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartDescription
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartDescription); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartEffDate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartEffDate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartNoteExistsFlag
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartNoteExistsFlag); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartObsDate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartObsDate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartRecordDate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartRecordDate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartReportsToAcct
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartReportsToAcct); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartRowPointer
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartRowPointer); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartTransMethod
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartTransMethod); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartType
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartType); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ChartUseBuyRate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ChartUseBuyRate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> CheckNum
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.CheckNum); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DerAmtBal
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DerAmtBal); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DerInvAdj
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DerInvAdj); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DerMessage
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DerMessage); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DerTypeDescription
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DerTypeDescription); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DiscAmt
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DiscAmt); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DiscDate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DiscDate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DiscDays
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DiscDays); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DiscPct
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DiscPct); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DistDate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DistDate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DueDate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DueDate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DueDays
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DueDays); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> DutyAmt
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.DutyAmt); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ExchRate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ExchRate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> FixedRate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.FixedRate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> Freight
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.Freight); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> GrnNum
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.GrnNum); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> HoldFlag
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.HoldFlag); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> InvAmt
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.InvAmt); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> InvDate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.InvDate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> InvNum
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.InvNum); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> InWorkflow
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.InWorkflow); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> MiscCharges
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.MiscCharges); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> NonDiscAmt
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.NonDiscAmt); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> NoteExistsFlag
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.NoteExistsFlag); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> PoNum
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.PoNum); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> ProxDay
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.ProxDay); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> PurchAmt
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.PurchAmt); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> RecordDate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.RecordDate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> Ref
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.Ref); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> RowPointer
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.RowPointer); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> SalesTax
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.SalesTax); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> SalesTax_2
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.SalesTax_2); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> TaxCode1
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.TaxCode1); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> TaxCode2
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.TaxCode2); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> Txt
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.Txt); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> Type
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.Type); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrAddr_1
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrAddr_1); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrAddr_2
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrAddr_2); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrAddr_3
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrAddr_3); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrAddr_4
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrAddr_4); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrCity
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrCity); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrCountry
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrCountry); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrCounty
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrCounty); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrExternalEmailAddr
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrExternalEmailAddr); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrFaxNum
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrFaxNum); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrInternalEmailAddr
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrInternalEmailAddr); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrInternetUrl
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrInternetUrl); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrName
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrName); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrNoteExistsFlag
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrNoteExistsFlag); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrPayHold
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrPayHold); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrPayHoldDate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrPayHoldDate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrPayHoldReason
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrPayHoldReason); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrPayHoldUser
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrPayHoldUser); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrRecordDate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrRecordDate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrRowPointer
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrRowPointer); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrState
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrState); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrTelexNum
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrTelexNum); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrVendNum
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrVendNum); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendaddrZip
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendaddrZip); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendNum
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendNum); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorBankCode
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorBankCode); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorBranchId
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorBranchId); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorCategory
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorCategory); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorCharfld1
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorCharfld1); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorCharfld2
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorCharfld2); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorCharfld3
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorCharfld3); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorContact
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorContact); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorCurrCode
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorCurrCode); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorDatefld
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorDatefld); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorDecifld1
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorDecifld1); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorDecifld2
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorDecifld2); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorDecifld3
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorDecifld3); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorDelterm
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorDelterm); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorDiscLstYr
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorDiscLstYr); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorDiscYtd
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorDiscYtd); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorEdiVend
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorEdiVend); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorFob
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorFob); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorLangCode
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorLangCode); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorLastPaid
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorLastPaid); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorLastPurch
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorLastPurch); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorLcrReqd
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorLcrReqd); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorLogifld
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorLogifld); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorNoteExistsFlag
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorNoteExistsFlag); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPayLstYr
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPayLstYr); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPayType
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPayType); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPayYtd
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPayYtd); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPhone
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPhone); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPrintPrice
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPrintPrice); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorProcessInd
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorProcessInd); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPurAcct
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPurAcct); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPurAcctUnit1
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPurAcctUnit1); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPurAcctUnit2
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPurAcctUnit2); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPurAcctUnit3
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPurAcctUnit3); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPurAcctUnit4
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPurAcctUnit4); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPurchLstYr
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPurchLstYr); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorPurchYtd
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorPurchYtd); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorRecordDate
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorRecordDate); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorRowPointer
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorRowPointer); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorShipCode
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorShipCode); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorStat
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorStat); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorTaxCode1
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorTaxCode1); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorTaxCode2
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorTaxCode2); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorTaxRegNum1
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorTaxRegNum1); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorTaxRegNum2
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorTaxRegNum2); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorTermsCode
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorTermsCode); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorTransNat
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorTransNat); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorUserId
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorUserId); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorVendNum
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorVendNum); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorVendRemit
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorVendRemit); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorVendType
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorVendType); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VendorWhse
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VendorWhse); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VenTermsCode
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VenTermsCode); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> Voucher
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.Voucher); }
                        }
                        public FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder> VouchSeq
                        {
                            get { return new FilterExpression<IdoApPostedTransactionsBuilder, SLAptrxpsFilterExpressionBuilder>(_builder, IdoApPostedTransactions.VouchSeq); }
                        }


                    }


            } 
 

 