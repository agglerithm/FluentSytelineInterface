using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class jobitem : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int suffix{ get;set; } 
        public virtual int ord_line{ get;set; } 
        public virtual int ord_release{ get;set; } 
        public virtual int ratio1{ get;set; } 
        public virtual int ratio2{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual DateTime midnight_of_job_sch_end_date{ get;set; } 
        public virtual DateTime midnight_of_job_sch_compdate{ get;set; } 
        public virtual decimal qty_released{ get;set; } 
        public virtual decimal qty_complete{ get;set; } 
        public virtual decimal qty_scrapped{ get;set; } 
        public virtual decimal wip_total{ get;set; } 
        public virtual decimal wip_complete{ get;set; } 
        public virtual decimal wip_special{ get;set; } 
        public virtual decimal wip_lbr_comp{ get;set; } 
        public virtual decimal wip_fovhd_comp{ get;set; } 
        public virtual decimal wip_vovhd_comp{ get;set; } 
        public virtual decimal wip_out_comp{ get;set; } 
        public virtual decimal wip_matl_total{ get;set; } 
        public virtual decimal wip_lbr_total{ get;set; } 
        public virtual decimal wip_fovhd_total{ get;set; } 
        public virtual decimal wip_vovhd_total{ get;set; } 
        public virtual decimal wip_out_total{ get;set; } 
        public virtual decimal wip_matl_comp{ get;set; } 
        public virtual string rcpt_rqmt{ get;set; } 
        public virtual string job{ get;set; } 
        public virtual string item{ get;set; } 
        public virtual string cust_num{ get;set; } 
        public virtual string ord_num{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string ord_type{ get;set; } 


    }
}