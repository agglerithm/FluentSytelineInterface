using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class appmtMap :  ClassMap<appmt>
            {
             
               public appmtMap()
               {
                Table("appmt");             
                   Id(x => x.RowPointer);
                  Map(x => x.NoteExistsFlag);
                  Map(x => x.InWorkflow);
                  Map(x => x.check_seq);
                  Map(x => x.check_num);
                  Map(x => x.check_date);
                  Map(x => x.due_date);
                  Map(x => x.RecordDate);
                  Map(x => x.CreateDate);
                  Map(x => x.dom_check_amt);
                  Map(x => x.exch_rate);
                  Map(x => x.for_check_amt);
                  Map(x => x.vend_num);
                  Map(x => x.reff).Column("ref");
                  Map(x => x.txt);
                  Map(x => x.inv_num);
                  Map(x => x.bank_code);
                  Map(x => x.CreatedBy);
                  Map(x => x.UpdatedBy);
                  Map(x => x.pay_type);

            }
          }
            
            }