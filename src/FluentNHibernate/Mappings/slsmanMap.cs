using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class slsmanMap :  ClassMap<slsman>
            {
             
               public slsmanMap()
               {
                Table("slsman");    
                   Id(x => x.RowPointer);
                    Map(x => x.outside);
                    Map(x => x.logifld);
                    Map(x => x.NoteExistsFlag);
                    Map(x => x.InWorkflow);
                    Map(x => x.RecordDate);
                    Map(x => x.datefld);
                    Map(x => x.CreateDate);
                    Map(x => x.sales_ptd);
                    Map(x => x.sales_ytd);
                    Map(x => x.decifld1);
                    Map(x => x.decifld2);
                    Map(x => x.decifld3);
                    Map(x => x.slsmanID).Column("slsman");
                    Map(x => x.slsclass);
                    Map(x => x.ref_num);
                    Map(x => x.code);
                    Map(x => x.slsmangr);
                    Map(x => x.charfld1);
                    Map(x => x.charfld2);
                    Map(x => x.charfld3);
                    Map(x => x.CreatedBy);
                    Map(x => x.UpdatedBy);

            }
          }
            
            }