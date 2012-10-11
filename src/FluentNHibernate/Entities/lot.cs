using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class lot : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int logifld{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int contains_tax_free_matl{ get;set; } 
        public virtual int uf_qc_hold{ get;set; } 
        public virtual int uf_CycleCountInProcess{ get;set; } 
        public virtual DateTime create_date{ get;set; } 
        public virtual DateTime exp_date{ get;set; } 
        public virtual DateTime purge_date{ get;set; } 
        public virtual DateTime datefld{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual DateTime uf_LastCountDate{ get;set; } 
        public virtual decimal rcvd_qty{ get;set; } 
        public virtual decimal decifld1{ get;set; } 
        public virtual decimal decifld2{ get;set; } 
        public virtual decimal decifld3{ get;set; } 
        public virtual string item{ get;set; } 
        public virtual string lotID{ get;set; } 
        public virtual string vend_lot{ get;set; } 
        public virtual string cert_num{ get;set; } 
        public virtual string charfld1{ get;set; } 
        public virtual string charfld2{ get;set; } 
        public virtual string charfld3{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string uf_CountedBy{ get;set; } 


    }
}