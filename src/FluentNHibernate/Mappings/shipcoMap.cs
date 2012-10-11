using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class shipcoMap :  ClassMap<shipco>
            {
             
               public shipcoMap()
               {
                Table("shipco");    
                   Id(x => x.RowPointer);
                Map(x => x.batch_id);
                Map(x => x.active);
                Map(x => x.pick_accept_defaults);
                Map(x => x.ship_accept_defaults);
                Map(x => x.pack_accept_defaults);
                Map(x => x.bol_accept_defaults);
                Map(x => x.invoice_accept_defaults);
                Map(x => x.NoteExistsFlag);
                Map(x => x.InWorkflow);
                Map(x => x.lines);
                Map(x => x.ready_to_process);
                Map(x => x.picked);
                Map(x => x.shipped);
                Map(x => x.packed);
                Map(x => x.bol);
                Map(x => x.invoiced);
                Map(x => x.RecordDate);
                Map(x => x.CreateDate);
                Map(x => x.co_num);
                Map(x => x.CreatedBy);
                Map(x => x.UpdatedBy);

            }
          }
            
            }