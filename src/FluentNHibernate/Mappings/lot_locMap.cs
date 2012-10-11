using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class lot_locMap :  ClassMap<lot_loc>
            {
             
               public lot_locMap()
               {
                Table("lot_loc");    Id(x => x.RowPointer);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.unit_cost);
    Map(x => x.qty_on_hand);
    Map(x => x.qty_rsvd);
    Map(x => x.matl_cost);
    Map(x => x.lbr_cost);
    Map(x => x.fovhd_cost);
    Map(x => x.vovhd_cost);
    Map(x => x.out_cost);
    Map(x => x.last_count_qty_on_hand);
    Map(x => x.last_count_qty_rsvd);
    Map(x => x.whse);
    Map(x => x.item);
    Map(x => x.loc);
    Map(x => x.lot);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);

            }
          }
            
            }