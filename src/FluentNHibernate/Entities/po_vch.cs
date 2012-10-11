using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class po_vch : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int po_line{ get;set; } 
        public virtual int po_release{ get;set; } 
        public virtual int date_seq{ get;set; } 
        public virtual int voucher{ get;set; } 
        public virtual DateTime rcvd_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal exch_rate{ get;set; } 
        public virtual decimal item_cost{ get;set; } 
        public virtual decimal qty_received{ get;set; } 
        public virtual decimal qty_returned{ get;set; } 
        public virtual decimal qty_vouchered{ get;set; } 
        public virtual string po_num{ get;set; } 
        public virtual string grn_num{ get;set; } 
        public virtual string pack_num{ get;set; } 
        public virtual string vend_num{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string type{ get;set; } 


    }
}