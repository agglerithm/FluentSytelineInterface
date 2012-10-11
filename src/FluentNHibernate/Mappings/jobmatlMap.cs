using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class jobmatlMap :  ClassMap<jobmatl>
            {
             
               public jobmatlMap()
               {
                Table("jobmatl");    Id(x => x.RowPointer);
    Map(x => x.backflush);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.planned_alternate);
    Map(x => x.suffix);
    Map(x => x.sequence);
    Map(x => x.ref_line_suf);
    Map(x => x.ref_release);
    Map(x => x.bom_seq);
    Map(x => x.alt_group);
    Map(x => x.alt_group_rank);
    Map(x => x.new_sequence);
    Map(x => x.oper_num);
    Map(x => x.effect_date);
    Map(x => x.obs_date);
    Map(x => x.pick_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.matl_qty);
    Map(x => x.cost);
    Map(x => x.qty_issued);
    Map(x => x.a_cost);
    Map(x => x.po_unit_cost);
    Map(x => x.scrap_fact);
    Map(x => x.out_cost_conv);
    Map(x => x.a_vovhd_cost);
    Map(x => x.a_out_cost);
    Map(x => x.matl_cost_conv);
    Map(x => x.lbr_cost_conv);
    Map(x => x.fovhd_cost_conv);
    Map(x => x.vovhd_cost_conv);
    Map(x => x.fovhd_cost);
    Map(x => x.vovhd_cost);
    Map(x => x.out_cost);
    Map(x => x.a_matl_cost);
    Map(x => x.a_lbr_cost);
    Map(x => x.a_fovhd_cost);
    Map(x => x.inc_price_conv);
    Map(x => x.cost_conv);
    Map(x => x.fmatlovhd);
    Map(x => x.vmatlovhd);
    Map(x => x.matl_cost);
    Map(x => x.lbr_cost);
    Map(x => x.qty_var);
    Map(x => x.fixovhd_t);
    Map(x => x.varovhd_t);
    Map(x => x.probable);
    Map(x => x.inc_price);
    Map(x => x.matl_qty_conv);
    Map(x => x.job);
    Map(x => x.item);
    Map(x => x.ref_num);
    Map(x => x.feature);
    Map(x => x.opt_code);
    Map(x => x.description);
    Map(x => x.u_m);
    Map(x => x.bflush_loc);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.matl_type);
    Map(x => x.units);
    Map(x => x.ref_type);

            }
          }
            
            }