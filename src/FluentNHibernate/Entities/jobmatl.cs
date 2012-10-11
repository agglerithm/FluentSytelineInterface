using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class jobmatl : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int backflush{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int planned_alternate{ get;set; } 
        public virtual int suffix{ get;set; } 
        public virtual int sequence{ get;set; } 
        public virtual int ref_line_suf{ get;set; } 
        public virtual int ref_release{ get;set; } 
        public virtual int bom_seq{ get;set; } 
        public virtual int alt_group{ get;set; } 
        public virtual int alt_group_rank{ get;set; } 
        public virtual int new_sequence{ get;set; } 
        public virtual int oper_num{ get;set; } 
        public virtual DateTime effect_date{ get;set; } 
        public virtual DateTime obs_date{ get;set; } 
        public virtual DateTime pick_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal matl_qty{ get;set; } 
        public virtual decimal cost{ get;set; } 
        public virtual decimal qty_issued{ get;set; } 
        public virtual decimal a_cost{ get;set; } 
        public virtual decimal po_unit_cost{ get;set; } 
        public virtual decimal scrap_fact{ get;set; } 
        public virtual decimal out_cost_conv{ get;set; } 
        public virtual decimal a_vovhd_cost{ get;set; } 
        public virtual decimal a_out_cost{ get;set; } 
        public virtual decimal matl_cost_conv{ get;set; } 
        public virtual decimal lbr_cost_conv{ get;set; } 
        public virtual decimal fovhd_cost_conv{ get;set; } 
        public virtual decimal vovhd_cost_conv{ get;set; } 
        public virtual decimal fovhd_cost{ get;set; } 
        public virtual decimal vovhd_cost{ get;set; } 
        public virtual decimal out_cost{ get;set; } 
        public virtual decimal a_matl_cost{ get;set; } 
        public virtual decimal a_lbr_cost{ get;set; } 
        public virtual decimal a_fovhd_cost{ get;set; } 
        public virtual decimal inc_price_conv{ get;set; } 
        public virtual decimal cost_conv{ get;set; } 
        public virtual decimal fmatlovhd{ get;set; } 
        public virtual decimal vmatlovhd{ get;set; } 
        public virtual decimal matl_cost{ get;set; } 
        public virtual decimal lbr_cost{ get;set; } 
        public virtual decimal qty_var{ get;set; } 
        public virtual decimal fixovhd_t{ get;set; } 
        public virtual decimal varovhd_t{ get;set; } 
        public virtual decimal probable{ get;set; } 
        public virtual decimal inc_price{ get;set; } 
        public virtual decimal matl_qty_conv{ get;set; } 
        public virtual string job{ get;set; } 
        public virtual string item{ get;set; } 
        public virtual string ref_num{ get;set; } 
        public virtual string feature{ get;set; } 
        public virtual string opt_code{ get;set; } 
        public virtual string description{ get;set; } 
        public virtual string u_m{ get;set; } 
        public virtual string bflush_loc{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string matl_type{ get;set; } 
        public virtual string units{ get;set; } 
        public virtual string ref_type{ get;set; } 


    }
}