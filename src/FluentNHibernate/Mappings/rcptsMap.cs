using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class rcptsMap :  ClassMap<rcpts>
            {
             
               public rcptsMap()
               {
                Table("rcpts");    
                   Id(x => x.RowPointer);
                Map(x => x.NoteExistsFlag);
                Map(x => x.InWorkflow);
                Map(x => x.start_time);
                Map(x => x.end_time);
                Map(x => x.due_date);
                Map(x => x.start_date);
                Map(x => x.projected_date);
                Map(x => x.RecordDate);
                Map(x => x.CreateDate);
                Map(x => x.due_date_day);
                Map(x => x.projected_date_day);
                Map(x => x.rcpt_qty);
                Map(x => x.orig_qty);
                Map(x => x.rcpt_rqmt);
                Map(x => x.item);
                Map(x => x.ref_num);
                Map(x => x.aps_ref);
                Map(x => x.CreatedBy);
                Map(x => x.UpdatedBy);

            }
          }
            
            }