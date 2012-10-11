using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class jobMap :  ClassMap<job>
            {
             
               public jobMap()
               {
                Table("job");    Id(x => x.RowPointer);
    Map(x => x.low_level);
    Map(x => x.picked);
    Map(x => x.NoteExistsFlag);
    Map(x => x.co_product_mix);
    Map(x => x.InWorkflow);
    Map(x => x.scheduled);
    Map(x => x.contains_tax_free_matl);
    Map(x => x.rework);
    Map(x => x.unlinked_xref);
    Map(x => x.suffix);
    Map(x => x.ord_line);
    Map(x => x.ord_release);
    Map(x => x.est_suf);
    Map(x => x.root_suf);
    Map(x => x.ref_suf);
    Map(x => x.ref_seq);
    Map(x => x.ref_oper);
    Map(x => x.job_date);
    Map(x => x.lst_trx_date);
    Map(x => x.effect_date);
    Map(x => x.rollup_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.midnight_of_job_sch_end_date);
    Map(x => x.midnight_of_job_sch_compdate);
    Map(x => x.qty_released);
    Map(x => x.qty_complete);
    Map(x => x.qty_scrapped);
    Map(x => x.wip_total);
    Map(x => x.wip_complete);
    Map(x => x.wip_special);
    Map(x => x.wip_lbr_comp);
    Map(x => x.wip_fovhd_comp);
    Map(x => x.wip_vovhd_comp);
    Map(x => x.wip_out_comp);
    Map(x => x.wip_matl_total);
    Map(x => x.wip_lbr_total);
    Map(x => x.wip_fovhd_total);
    Map(x => x.wip_vovhd_total);
    Map(x => x.wip_out_total);
    Map(x => x.wip_matl_comp);
    Map(x => x.rcpt_rqmt);
    Map(x => x.jobID).Column("job");
    Map(x => x.cust_num);
    Map(x => x.ord_num);
    Map(x => x.est_job);
    Map(x => x.item);
    Map(x => x.root_job);
    Map(x => x.config_id);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.prospect_id);
    Map(x => x.wip_out_acct_unit1);
    Map(x => x.wip_out_acct_unit2);
    Map(x => x.wip_out_acct_unit3);
    Map(x => x.wip_out_acct_unit4);
    Map(x => x.prod_mix);
    Map(x => x.description);
    Map(x => x.wip_fovhd_acct_unit3);
    Map(x => x.wip_fovhd_acct_unit4);
    Map(x => x.wip_vovhd_acct_unit1);
    Map(x => x.wip_vovhd_acct_unit2);
    Map(x => x.wip_vovhd_acct_unit3);
    Map(x => x.wip_vovhd_acct_unit4);
    Map(x => x.wip_lbr_acct_unit1);
    Map(x => x.wip_lbr_acct_unit2);
    Map(x => x.wip_lbr_acct_unit3);
    Map(x => x.wip_lbr_acct_unit4);
    Map(x => x.wip_fovhd_acct_unit1);
    Map(x => x.wip_fovhd_acct_unit2);
    Map(x => x.wip_acct_unit3);
    Map(x => x.wip_acct_unit4);
    Map(x => x.jcb_acct_unit1);
    Map(x => x.jcb_acct_unit2);
    Map(x => x.jcb_acct_unit3);
    Map(x => x.jcb_acct_unit4);
    Map(x => x.wip_lbr_acct);
    Map(x => x.wip_fovhd_acct);
    Map(x => x.wip_vovhd_acct);
    Map(x => x.wip_out_acct);
    Map(x => x.wip_acct_unit1);
    Map(x => x.wip_acct_unit2);
    Map(x => x.ref_job);
    Map(x => x.wip_acct);
    Map(x => x.revision);
    Map(x => x.whse);
    Map(x => x.jcb_acct);
    Map(x => x.ps_num);
    Map(x => x.type);
    Map(x => x.ord_type);
    Map(x => x.stat);
    Map(x => x.export_type);

            }
          }
            
            }