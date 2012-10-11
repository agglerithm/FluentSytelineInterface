using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class jobitemMap :  ClassMap<jobitem>
            {
             
               public jobitemMap()
               {
                Table("jobitem");    Id(x => x.RowPointer);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.suffix);
    Map(x => x.ord_line);
    Map(x => x.ord_release);
    Map(x => x.ratio1);
    Map(x => x.ratio2);
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
    Map(x => x.job);
    Map(x => x.item);
    Map(x => x.cust_num);
    Map(x => x.ord_num);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.ord_type);

            }
          }
            
            }