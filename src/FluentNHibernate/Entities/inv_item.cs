using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class inv_item : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int co_line{ get;set; } 
        public virtual int co_release{ get;set; } 
        public virtual int do_seq{ get;set; } 
        public virtual int inv_seq{ get;set; } 
        public virtual int inv_line{ get;set; } 
        public virtual int cons_num{ get;set; } 
        public virtual int do_line{ get;set; } 
        public virtual DateTime tax_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal qty_invoiced{ get;set; } 
        public virtual decimal disc{ get;set; } 
        public virtual decimal cost{ get;set; } 
        public virtual decimal price{ get;set; } 
        public virtual decimal old_price{ get;set; } 
        public virtual decimal new_price{ get;set; } 
        public virtual decimal restock_fee_amt{ get;set; } 
        public virtual string inv_num{ get;set; } 
        public virtual string co_num{ get;set; } 
        public virtual string item{ get;set; } 
        public virtual string sales_acct{ get;set; } 
        public virtual string process_ind{ get;set; } 
        public virtual string tax_code1{ get;set; } 
        public virtual string do_num{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string orig_inv_num{ get;set; } 
        public virtual string reason_text{ get;set; } 
        public virtual string tax_code2{ get;set; } 
        public virtual string sales_acct_unit1{ get;set; } 
        public virtual string sales_acct_unit2{ get;set; } 
        public virtual string sales_acct_unit3{ get;set; } 
        public virtual string sales_acct_unit4{ get;set; } 
        public virtual string cust_po{ get;set; } 


    }
}