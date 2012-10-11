using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class co_shipMap :  ClassMap<co_ship>
            {
             
               public co_shipMap()
               {
                Table("co_ship");    Id(x => x.RowPointer);
    Map(x => x.by_cons);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.co_line);
    Map(x => x.co_release);
    Map(x => x.date_seq);
    Map(x => x.do_seq);
    Map(x => x.do_line);
    Map(x => x.pack_num);
    Map(x => x.ship_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.qty_invoiced);
    Map(x => x.qty_shipped);
    Map(x => x.qty_returned);
    Map(x => x.cost);
    Map(x => x.price);
    Map(x => x.unit_weight);
    Map(x => x.matl_cost);
    Map(x => x.lbr_cost);
    Map(x => x.fovhd_cost);
    Map(x => x.vovhd_cost);
    Map(x => x.out_cost);
    Map(x => x.co_num);
    Map(x => x.shipper_num);
    Map(x => x.do_num);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.orig_inv_num);
    Map(x => x.reason_text);

            }
          }
            
            }