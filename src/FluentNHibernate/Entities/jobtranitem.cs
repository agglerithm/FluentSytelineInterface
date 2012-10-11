using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class jobtranitem : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int next_oper{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal trans_num{ get;set; } 
        public virtual decimal qty_complete{ get;set; } 
        public virtual decimal qty_scrapped{ get;set; } 
        public virtual decimal a_{ get;set; } 
        public virtual decimal qty_moved{ get;set; } 
        public virtual decimal fixovhd{ get;set; } 
        public virtual decimal varovhd{ get;set; } 
        public virtual string item{ get;set; } 
        public virtual string loc{ get;set; } 
        public virtual string lot{ get;set; } 
        public virtual string reason_code{ get;set; } 
        public virtual string cost_code{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string import_doc_id{ get;set; } 


    }
}