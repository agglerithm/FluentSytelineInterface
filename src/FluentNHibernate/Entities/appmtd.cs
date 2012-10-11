using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class appmtd : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual  int check_seq{ get;set; } 
        public virtual int voucher{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal dom_amt_paid{ get;set; } 
        public virtual decimal dom_amt_disc{ get;set; } 
        public virtual decimal for_amt_paid{ get;set; } 
        public virtual decimal for_amt_disc{ get;set; } 
        public virtual decimal exch_rate{ get;set; } 
        public virtual decimal for_tax_1{ get;set; } 
        public virtual decimal for_tax_2{ get;set; } 
        public virtual decimal dom_tax_1{ get;set; } 
        public virtual decimal dom_tax_2{ get;set; } 
        public virtual string vend_num{ get;set; } 
        public virtual string site{ get;set; } 
        public virtual string disc_acct{ get;set; } 
        public virtual string inv_num{ get;set; } 
        public virtual string apply_vend_num{ get;set; } 
        public virtual string bank_code{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string disc_acct_unit1{ get;set; } 
        public virtual string disc_acct_unit2{ get;set; } 
        public virtual string disc_acct_unit3{ get;set; } 
        public virtual string disc_acct_unit4{ get;set; } 
        public virtual string po_num{ get;set; } 
        public virtual string grn_num{ get;set; } 
        public virtual string type{ get;set; } 


    }
}