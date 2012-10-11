using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class arpmtd : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int check_num{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal dom_amt_applied{ get;set; } 
        public virtual decimal dom_disc_amt{ get;set; } 
        public virtual decimal dom_allow_amt{ get;set; } 
        public virtual decimal for_amt_applied{ get;set; } 
        public virtual decimal for_disc_amt{ get;set; } 
        public virtual decimal for_allow_amt{ get;set; } 
        public virtual decimal exch_rate{ get;set; } 
        public virtual decimal for_tax_1{ get;set; } 
        public virtual decimal for_tax_2{ get;set; } 
        public virtual decimal dom_tax_1{ get;set; } 
        public virtual decimal dom_tax_2{ get;set; } 
        public virtual string cust_num{ get;set; } 
        public virtual string inv_num{ get;set; } 
        public virtual string site{ get;set; } 
        public virtual string disc_acct{ get;set; } 
        public virtual string allow_acct{ get;set; } 
        public virtual string deposit_acct{ get;set; } 
        public virtual string credit_memo_num{ get;set; } 
        public virtual string deposit_acct_unit2{ get;set; } 
        public virtual string deposit_acct_unit3{ get;set; } 
        public virtual string deposit_acct_unit4{ get;set; } 
        public virtual string do_num{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string disc_acct_unit4{ get;set; } 
        public virtual string allow_acct_unit1{ get;set; } 
        public virtual string allow_acct_unit2{ get;set; } 
        public virtual string allow_acct_unit3{ get;set; } 
        public virtual string allow_acct_unit4{ get;set; } 
        public virtual string deposit_acct_unit1{ get;set; } 
        public virtual string apply_cust_num{ get;set; } 
        public virtual string bank_code{ get;set; } 
        public virtual string co_num{ get;set; } 
        public virtual string disc_acct_unit1{ get;set; } 
        public virtual string disc_acct_unit2{ get;set; } 
        public virtual string disc_acct_unit3{ get;set; } 
        public virtual string type{ get;set; } 


    }
}