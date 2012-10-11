using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class jobtranitemMap :  ClassMap<jobtranitem>
            {
             
               public jobtranitemMap()
               {
                Table("jobtranitem");    Id(x => x.RowPointer);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.next_oper);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.trans_num);
    Map(x => x.qty_complete);
    Map(x => x.qty_scrapped);
    Map(x => x.a_).Column("a_$");
    Map(x => x.qty_moved);
    Map(x => x.fixovhd);
    Map(x => x.varovhd);
    Map(x => x.item);
    Map(x => x.loc);
    Map(x => x.lot);
    Map(x => x.reason_code);
    Map(x => x.cost_code);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.import_doc_id);

            }
          }
            
            }