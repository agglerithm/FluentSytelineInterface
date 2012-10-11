using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class customer : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual Guid crm_guid{ get;set; } 
        public virtual int fin_chg{ get;set; } 
        public virtual int logifld{ get;set; } 
        public virtual int edi_cust{ get;set; } 
        public virtual int use_exch_rate{ get;set; } 
        public virtual int ship_early{ get;set; } 
        public virtual int ship_partial{ get;set; } 
        public virtual int show_in_drop_down_list{ get;set; } 
        public virtual int include_tax_in_price{ get;set; } 
        public virtual int use_revision_pay_days{ get;set; } 
        public virtual int revision_day{ get;set; } 
        public virtual int pay_day{ get;set; } 
        public virtual int active_for_data_integration{ get;set; } 
        public virtual int show_in_ship_to_drop_down_list{ get;set; } 
        public virtual int summarize{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int einvoice{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int print_pack_inv{ get;set; } 
        public virtual int one_pack_inv{ get;set; } 
        public virtual int lcr_reqd{ get;set; } 
        public virtual int draft_print_flag{ get;set; } 
        public virtual int rcv_internal_email{ get;set; } 
        public virtual int send_customer_email{ get;set; } 
        public virtual int aps_pull_up{ get;set; } 
        public virtual int consolidate{ get;set; } 
        public virtual int num_periods{ get;set; } 
        public virtual int avg_days_os{ get;set; } 
        public virtual int last_days_os{ get;set; } 
        public virtual int cust_seq{ get;set; } 
        public virtual int num_invoices{ get;set; } 
        public virtual int hist_days_os{ get;set; } 
        public virtual int larg_days_os{ get;set; } 
        public virtual int number_of_employees{ get;set; } 
        public virtual DateTime last_inv{ get;set; } 
        public virtual DateTime last_paid{ get;set; } 
        public virtual DateTime last_fin_chg{ get;set; } 
        public virtual DateTime calc_date{ get;set; } 
        public virtual DateTime datefld{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime pay_day_start_time2{ get;set; } 
        public virtual DateTime pay_day_end_time1{ get;set; } 
        public virtual DateTime pay_day_end_time2{get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual DateTime revision_day_start_time1{ get;set; } 
        public virtual DateTime revision_day_start_time2{ get;set; } 
        public virtual DateTime revision_day_end_time1{ get;set; } 
        public virtual DateTime revision_day_end_time2{ get;set; } 
        public virtual DateTime pay_day_start_time1{ get;set; } 
        public virtual decimal sales_ytd{ get;set; } 
        public virtual decimal sales_lst_yr{ get;set; } 
        public virtual decimal disc_ytd{ get;set; } 
        public virtual decimal disc_lst_yr{ get;set; } 
        public virtual decimal sales_ptd{ get;set; } 
        public virtual decimal avg_bal_os{ get;set; } 
        public virtual decimal posted_bal{ get;set; } 
        public virtual decimal company_revenue{ get;set; } 
        public virtual decimal large_bal_os{ get;set; } 
        public virtual decimal last_bal_os{ get;set; } 
        public virtual decimal decifld1{ get;set; } 
        public virtual decimal decifld2{ get;set; } 
        public virtual decimal decifld3{ get;set; } 
        public virtual decimal order_bal{ get;set; } 
        public virtual string cust_num{ get;set; } 
        public virtual string contact1{ get;set; } 
        public virtual string contact2{ get;set; } 
        public virtual string contact3{ get;set; } 
        public virtual string phone1{ get;set; } 
        public virtual string phone2{ get;set; } 
        public virtual string sic_code{ get;set; } 
        public virtual string territory_code{ get;set; } 
        public virtual string Uf_LRM_FreightAccount{ get;set; } 
        public virtual string Uf_LRM_FreightTerms{ get;set; } 
        public virtual string Uf_LRM_OnwardCarrier{ get;set; } 
        public virtual string Uf_LRM_OnwardClassOfService{ get;set; } 
        public virtual string Uf_accountrep{ get;set; } 
        public virtual string Uf_accountrepPhone{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string inv_category{ get;set; } 
        public virtual string trans_nat_2{ get;set; } 
        public virtual string Uf_LRM_Carrier{ get;set; } 
        public virtual string Uf_LRM_ClassOfService{ get;set; } 
        public virtual string pricecode{ get;set; } 
        public virtual string lang_code{ get;set; } 
        public virtual string end_user_type{ get;set; } 
        public virtual string ship_site{ get;set; } 
        public virtual string cust_bank{ get;set; } 
        public virtual string customer_email_addr{ get;set; } 
        public virtual string branch_id{ get;set; } 
        public virtual string trans_nat{ get;set; } 
        public virtual string delterm{ get;set; } 
        public virtual string process_ind{ get;set; } 
        public virtual string tax_code1{ get;set; } 
        public virtual string tax_code2{ get;set; } 
        public virtual string charfld1{ get;set; } 
        public virtual string charfld2{ get;set; } 
        public virtual string charfld3{ get;set; } 
        public virtual string tax_reg_num1{ get;set; } 
        public virtual string bank_code{ get;set; } 
        public virtual string tax_reg_num2{ get;set; } 
        public virtual string phone3{ get;set; } 
        public virtual string cust_type{ get;set; } 
        public virtual string terms_code{ get;set; } 
        public virtual string ship_code{ get;set; } 
        public virtual string slsman{ get;set; } 
        public virtual string whse{ get;set; } 
        public virtual string state_cycle{ get;set; } 
        public virtual string pay_type{ get;set; } 
        public virtual string do_invoice{ get;set; } 
        public virtual string inv_freq{ get;set; } 
        public virtual string export_type{ get;set; } 


    }
}