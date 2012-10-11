using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class lotMap :  ClassMap<lot>
            {
             
               public lotMap()
               {
                Table("lot");    Id(x => x.RowPointer);
    Map(x => x.logifld);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.contains_tax_free_matl);
    Map(x => x.uf_qc_hold);
    Map(x => x.uf_CycleCountInProcess);
    Map(x => x.create_date);
    Map(x => x.exp_date);
    Map(x => x.purge_date);
    Map(x => x.datefld);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.uf_LastCountDate);
    Map(x => x.rcvd_qty);
    Map(x => x.decifld1);
    Map(x => x.decifld2);
    Map(x => x.decifld3);
    Map(x => x.item);
    Map(x => x.lotID).Column("lot");
    Map(x => x.vend_lot);
    Map(x => x.cert_num);
    Map(x => x.charfld1);
    Map(x => x.charfld2);
    Map(x => x.charfld3);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.uf_CountedBy);

            }
          }
            
            }