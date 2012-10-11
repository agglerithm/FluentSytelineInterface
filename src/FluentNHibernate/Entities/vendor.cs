using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class vendor : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int print_price{ get;set; } 
        public virtual int logifld{ get;set; } 
        public virtual int edi_vend{ get;set; } 
        public virtual int lcr_reqd{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int show_in_drop_down_list{ get;set; } 
        public virtual int print_vat_on_po{ get;set; } 
        public virtual int include_tax_in_cost{ get;set; } 
        public virtual int active_for_data_integration{ get;set; } 
        public virtual int supply_web_vendor{ get;set; } 
        public virtual int request_acknowledgement{ get;set; } 
        public virtual int synchronized_to_bus{ get;set; } 
        public virtual int transit{ get;set; } 
        public virtual DateTime last_purch{ get;set; } 
        public virtual DateTime last_paid{ get;set; } 
        public virtual DateTime datefld{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal purch_ytd{ get;set; } 
        public virtual decimal purch_lst_yr{ get;set; } 
        public virtual decimal disc_ytd{ get;set; } 
        public virtual decimal disc_lst_yr{ get;set; } 
        public virtual decimal pay_ytd{ get;set; } 
        public virtual decimal decifld1{ get;set; } 
        public virtual decimal pay_lst_fiscal_yr{ get;set; } 
        public virtual decimal decifld2{ get;set; } 
        public virtual decimal decifld3{ get;set; } 
        public virtual decimal pay_lst_yr{ get;set; } 
        public virtual decimal vch_over_po_cost_tolerance{ get;set; } 
        public virtual decimal vch_under_po_cost_tolerance{ get;set; } 
        public virtual decimal pay_fiscal_ytd{ get;set; } 
        public virtual string vend_num{ get;set; } 
        public virtual string contact{ get;set; } 
        public virtual string phone{ get;set; } 
        public virtual string vend_type{ get;set; } 
        public virtual string terms_code{ get;set; } 
        public virtual string ship_code{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string account{ get;set; } 
        public virtual string account_name{ get;set; } 
        public virtual string EFT_bank_num{ get;set; } 
        public virtual string trans_nat_2{ get;set; } 
        public virtual string pur_acct_unit1{ get;set; } 
        public virtual string pur_acct_unit2{ get;set; } 
        public virtual string pur_acct_unit3{ get;set; } 
        public virtual string pur_acct_unit4{ get;set; } 
        public virtual string category{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string process_ind{ get;set; } 
        public virtual string tax_reg_num2{ get;set; } 
        public virtual string tax_code1{ get;set; } 
        public virtual string tax_code2{ get;set; } 
        public virtual string lang_code{ get;set; } 
        public virtual string pur_acct{ get;set; } 
        public virtual string curr_code{ get;set; } 
        public virtual string tax_reg_num1{ get;set; } 
        public virtual string bank_code{ get;set; } 
        public virtual string branch_id{ get;set; } 
        public virtual string trans_nat{ get;set; } 
        public virtual string delterm{ get;set; } 
        public virtual string fob{ get;set; } 
        public virtual string vend_remit{ get;set; } 
        public virtual string whse{ get;set; } 
        public virtual string charfld1{ get;set; } 
        public virtual string charfld2{ get;set; } 
        public virtual string charfld3{ get;set; } 
        public virtual string stat{ get;set; } 
        public virtual string pay_type{ get;set; } 
        public virtual string price_by{ get;set; } 


    }
}