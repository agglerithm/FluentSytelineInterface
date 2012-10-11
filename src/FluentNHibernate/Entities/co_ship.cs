using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class co_ship : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int by_cons{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int co_line{ get;set; } 
        public virtual int co_release{ get;set; } 
        public virtual int date_seq{ get;set; } 
        public virtual int do_seq{ get;set; } 
        public virtual int do_line{ get;set; } 
        public virtual int pack_num{ get;set; } 
        public virtual DateTime ship_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal qty_invoiced{ get;set; } 
        public virtual decimal qty_shipped{ get;set; } 
        public virtual decimal qty_returned{ get;set; } 
        public virtual decimal cost{ get;set; } 
        public virtual decimal price{ get;set; } 
        public virtual decimal unit_weight{ get;set; } 
        public virtual decimal matl_cost{ get;set; } 
        public virtual decimal lbr_cost{ get;set; } 
        public virtual decimal fovhd_cost{ get;set; } 
        public virtual decimal vovhd_cost{ get;set; } 
        public virtual decimal out_cost{ get;set; } 
        public virtual string co_num{ get;set; } 
        public virtual string shipper_num{ get;set; } 
        public virtual string do_num{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string orig_inv_num{ get;set; } 
        public virtual string reason_text{ get;set; } 


    }
}