using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class po_vchMap :  ClassMap<po_vch>
            {
             
               public po_vchMap()
               {
                Table("po_vch");    Id(x => x.RowPointer);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.po_line);
    Map(x => x.po_release);
    Map(x => x.date_seq);
    Map(x => x.voucher);
    Map(x => x.rcvd_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.exch_rate);
    Map(x => x.item_cost);
    Map(x => x.qty_received);
    Map(x => x.qty_returned);
    Map(x => x.qty_vouchered);
    Map(x => x.po_num);
    Map(x => x.grn_num);
    Map(x => x.pack_num);
    Map(x => x.vend_num);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.type);

            }
          }
            
            }