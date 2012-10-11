using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class arpmt : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int transfer_cash{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int check_num{ get;set; } 
        public virtual DateTime recpt_date{ get;set; } 
        public virtual DateTime due_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual DateTime deposit_date{ get;set; } 
        public virtual decimal dom_check_amt{ get;set; } 
        public virtual decimal exch_rate{ get;set; } 
        public virtual decimal for_check_amt{ get;set; } 
        public virtual string cust_num{ get;set; } 
        public virtual string reff{ get;set; } 
        public virtual string description{ get;set; } 
        public virtual string bank_code{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string credit_memo_num{ get;set; } 
        public virtual string type{ get;set; } 


    }
}