using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class aptrx : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int post_from_po{ get;set; } 
        public virtual int prox_day{ get;set; } 
        public virtual int includes_tax{ get;set; } 
        public virtual int fixed_rate{ get;set; } 
        public virtual int prox_code{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int include_tax_in_cost{ get;set; } 
        public virtual int voucher{ get;set; } 
        public virtual int due_days{ get;set; } 
        public virtual int disc_days{ get;set; } 
        public virtual int pre_register{ get;set; } 
        public virtual DateTime dist_date{ get;set; } 
        public virtual DateTime inv_date{ get;set; } 
        public virtual DateTime due_date{ get;set; } 
        public virtual DateTime disc_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual DateTime tax_date{ get;set; } 
        public virtual decimal inv_amt{ get;set; } 
        public virtual decimal non_disc_amt{ get;set; } 
        public virtual decimal disc_pct{ get;set; } 
        public virtual decimal disc_amt{ get;set; } 
        public virtual decimal exch_rate{ get;set; } 
        public virtual decimal purch_amt{ get;set; } 
        public virtual decimal insurance_amt{ get;set; } 
        public virtual decimal loc_frt_amt{ get;set; } 
        public virtual decimal misc_charges{ get;set; } 
        public virtual decimal sales_tax{ get;set; } 
        public virtual decimal sales_tax_2{ get;set; } 
        public virtual decimal freight{ get;set; } 
        public virtual decimal duty_amt{ get;set; } 
        public virtual decimal brokerage_amt{ get;set; } 
        public virtual string vend_num{ get;set; } 
        public virtual string po_num{ get;set; } 
        public virtual string inv_num{ get;set; } 
        public virtual string ap_acct{ get;set; } 
        public virtual string reff{ get;set; } 
        public virtual string txt{ get;set; } 
        public virtual string builder_voucher_orig_site{ get;set; } 
        public virtual string builder_voucher{ get;set; } 
        public virtual string grn_num{ get;set; } 
        public virtual string authorizer{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string builder_po_orig_site{ get;set; } 
        public virtual string builder_po_num{ get;set; } 
        public virtual string tax_code1{ get;set; } 
        public virtual string tax_code2{ get;set; } 
        public virtual string ap_acct_unit1{ get;set; } 
        public virtual string ap_acct_unit2{ get;set; } 
        public virtual string ap_acct_unit3{ get;set; } 
        public virtual string ap_acct_unit4{ get;set; } 
        public virtual string type{ get;set; } 
        public virtual string auth_status{ get;set; } 


    }
}