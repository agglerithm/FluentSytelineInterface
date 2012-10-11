using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class job : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int low_level{ get;set; } 
        public virtual int picked{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int co_product_mix{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int scheduled{ get;set; } 
        public virtual int contains_tax_free_matl{ get;set; } 
        public virtual int rework{ get;set; } 
        public virtual int unlinked_xref{ get;set; } 
        public virtual int suffix{ get;set; } 
        public virtual int ord_line{ get;set; } 
        public virtual int ord_release{ get;set; } 
        public virtual int est_suf{ get;set; } 
        public virtual int root_suf{ get;set; } 
        public virtual int ref_suf{ get;set; } 
        public virtual int ref_seq{ get;set; } 
        public virtual int ref_oper{ get;set; } 
        public virtual DateTime job_date{ get;set; } 
        public virtual DateTime lst_trx_date{ get;set; } 
        public virtual DateTime effect_date{ get;set; } 
        public virtual DateTime rollup_date{ get;set; } 
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
        public virtual string jobID{ get;set; } 
        public virtual string cust_num{ get;set; } 
        public virtual string ord_num{ get;set; } 
        public virtual string est_job{ get;set; } 
        public virtual string item{ get;set; } 
        public virtual string root_job{ get;set; } 
        public virtual string config_id{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string prospect_id{ get;set; } 
        public virtual string wip_out_acct_unit1{ get;set; } 
        public virtual string wip_out_acct_unit2{ get;set; } 
        public virtual string wip_out_acct_unit3{ get;set; } 
        public virtual string wip_out_acct_unit4{ get;set; } 
        public virtual string prod_mix{ get;set; } 
        public virtual string description{ get;set; } 
        public virtual string wip_fovhd_acct_unit3{ get;set; } 
        public virtual string wip_fovhd_acct_unit4{ get;set; } 
        public virtual string wip_vovhd_acct_unit1{ get;set; } 
        public virtual string wip_vovhd_acct_unit2{ get;set; } 
        public virtual string wip_vovhd_acct_unit3{ get;set; } 
        public virtual string wip_vovhd_acct_unit4{ get;set; } 
        public virtual string wip_lbr_acct_unit1{ get;set; } 
        public virtual string wip_lbr_acct_unit2{ get;set; } 
        public virtual string wip_lbr_acct_unit3{ get;set; } 
        public virtual string wip_lbr_acct_unit4{ get;set; } 
        public virtual string wip_fovhd_acct_unit1{ get;set; } 
        public virtual string wip_fovhd_acct_unit2{ get;set; } 
        public virtual string wip_acct_unit3{ get;set; } 
        public virtual string wip_acct_unit4{ get;set; } 
        public virtual string jcb_acct_unit1{ get;set; } 
        public virtual string jcb_acct_unit2{ get;set; } 
        public virtual string jcb_acct_unit3{ get;set; } 
        public virtual string jcb_acct_unit4{ get;set; } 
        public virtual string wip_lbr_acct{ get;set; } 
        public virtual string wip_fovhd_acct{ get;set; } 
        public virtual string wip_vovhd_acct{ get;set; } 
        public virtual string wip_out_acct{ get;set; } 
        public virtual string wip_acct_unit1{ get;set; } 
        public virtual string wip_acct_unit2{ get;set; } 
        public virtual string ref_job{ get;set; } 
        public virtual string wip_acct{ get;set; } 
        public virtual string revision{ get;set; } 
        public virtual string whse{ get;set; } 
        public virtual string jcb_acct{ get;set; } 
        public virtual string ps_num{ get;set; } 
        public virtual string type{ get;set; } 
        public virtual string ord_type{ get;set; } 
        public virtual string stat{ get;set; } 
        public virtual string export_type{ get;set; } 


    }
}