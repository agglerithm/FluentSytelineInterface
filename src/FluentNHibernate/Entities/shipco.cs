using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class shipco : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int batch_id{ get;set; } 
        public virtual int active{ get;set; } 
        public virtual int pick_accept_defaults{ get;set; } 
        public virtual int ship_accept_defaults{ get;set; } 
        public virtual int pack_accept_defaults{ get;set; } 
        public virtual int bol_accept_defaults{ get;set; } 
        public virtual int invoice_accept_defaults{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int lines{ get;set; } 
        public virtual int ready_to_process{ get;set; } 
        public virtual int picked{ get;set; } 
        public virtual int shipped{ get;set; } 
        public virtual int packed{ get;set; } 
        public virtual int bol{ get;set; } 
        public virtual int invoiced{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual string co_num{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 


    }
}