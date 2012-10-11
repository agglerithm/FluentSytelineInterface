using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class appmt : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual  int check_seq{ get;set; } 
        public virtual int check_num{ get;set; } 
        public virtual DateTime check_date{ get;set; } 
        public virtual DateTime due_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal dom_check_amt{ get;set; } 
        public virtual decimal exch_rate{ get;set; } 
        public virtual decimal for_check_amt{ get;set; } 
        public virtual string vend_num{ get;set; } 
        public virtual string reff{ get;set; } 
        public virtual string txt{ get;set; } 
        public virtual string inv_num{ get;set; } 
        public virtual string bank_code{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string pay_type{ get;set; } 


    }
}