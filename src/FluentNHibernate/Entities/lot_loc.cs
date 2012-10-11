using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class lot_loc : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal unit_cost{ get;set; } 
        public virtual decimal qty_on_hand{ get;set; } 
        public virtual decimal qty_rsvd{ get;set; } 
        public virtual decimal matl_cost{ get;set; } 
        public virtual decimal lbr_cost{ get;set; } 
        public virtual decimal fovhd_cost{ get;set; } 
        public virtual decimal vovhd_cost{ get;set; } 
        public virtual decimal out_cost{ get;set; } 
        public virtual decimal last_count_qty_on_hand{ get;set; } 
        public virtual decimal last_count_qty_rsvd{ get;set; } 
        public virtual string whse{ get;set; } 
        public virtual string item{ get;set; } 
        public virtual string loc{ get;set; } 
        public virtual string lot{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 


    }
}