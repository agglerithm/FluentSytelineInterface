using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class aptrxd : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int tax_system{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int voucher{ get;set; } 
        public virtual int dist_seq{ get;set; } 
        public virtual int task_num{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal amount{ get;set; } 
        public virtual decimal tax_basis{ get;set; } 
        public virtual string vend_num{ get;set; } 
        public virtual string acct{ get;set; } 
        public virtual string inv_num{ get;set; } 
        public virtual string tax_code{ get;set; } 
        public virtual string tax_code_e{ get;set; } 
        public virtual string acct_unit1{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string acct_unit2{ get;set; } 
        public virtual string acct_unit3{ get;set; } 
        public virtual string acct_unit4{ get;set; } 
        public virtual string proj_num{ get;set; } 
        public virtual string cost_code{ get;set; } 
        public virtual string CreatedBy{ get;set; } 


    }
}