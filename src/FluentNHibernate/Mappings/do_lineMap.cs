using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class do_lineMap :  ClassMap<do_line>
            {
             
               public do_lineMap()
               {
                Table("do_line");    Id(x => x.RowPointer);
    Map(x => x.hazard);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.qty_packages);
    Map(x => x.do_lineID).Column("do_line");
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.weight);
    Map(x => x.do_num);
    Map(x => x.package_type);
    Map(x => x.nmfc);
    Map(x => x.rate_code);
    Map(x => x.description);
    Map(x => x.marks_except);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);

            }
          }
            
            }