using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class artran : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int post_from_co{ get;set; } 
        public virtual int active{ get;set; } 
        public virtual int fixed_rate{ get;set; } 
        public virtual int rma{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int apply_to_inv_num_category{ get;set; } 
        public virtual int inv_seq{ get;set; } 
        public virtual int check_seq{ get;set; } 
        public virtual int is_invoice{ get;set; } 
        public virtual DateTime inv_date{ get;set; } 
        public virtual DateTime due_date{ get;set; } 
        public virtual DateTime disc_date{ get;set; } 
        public virtual DateTime issue_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal amount{ get;set; } 
        public virtual decimal disc_amt{ get;set; } 
        public virtual decimal exch_rate{ get;set; } 
        public virtual decimal misc_charges{ get;set; } 
        public virtual decimal sales_tax{ get;set; } 
        public virtual decimal freight{ get;set; } 
        public virtual decimal sales_tax_2{ get;set; } 
        public virtual string cust_num{ get;set; } 
        public virtual string inv_num{ get;set; } 
        public virtual string co_num{ get;set; } 
        public virtual string acct{ get;set; } 
        public virtual string description{ get;set; } 
        public virtual string bank_code{ get;set; } 
        public virtual string acct_unit4{ get;set; } 
        public virtual string reff{ get;set; } 
        public virtual string do_num{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string apply_to_inv_num{ get;set; } 
        public virtual string tax_code1{ get;set; } 
        public virtual string tax_code2{ get;set; } 
        public virtual string corp_cust{ get;set; } 
        public virtual string acct_unit1{ get;set; } 
        public virtual string acct_unit2{ get;set; } 
        public virtual string acct_unit3{ get;set; } 
        public virtual string type{ get;set; } 
        public virtual string pay_type{ get;set; } 
        public virtual string approval_status{ get;set; } 


    }
}