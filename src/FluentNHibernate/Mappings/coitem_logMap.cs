using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class coitem_logMap :  ClassMap<coitem_log>
            {
             
               public coitem_logMap()
               {
                Table("coitem_log");                         
                   Id(x => x.RowPointer);
                         Map(x => x.NoteExistsFlag);
                         Map(x => x.InWorkflow);
                         Map(x => x.co_line);
                         Map(x => x.co_release);
                         Map(x => x.activity_date);
                         Map(x => x.due_date);
                         Map(x => x.projected_date);
                         Map(x => x.RecordDate);
                         Map(x => x.CreateDate);
                         Map(x => x.activity_seq);
                         Map(x => x.qty_chg);
                         Map(x => x.price_chg);
                         Map(x => x.disc_chg);
                         Map(x => x.co_disc_chg);
                         Map(x => x.trans_disc);
                         Map(x => x.trans_amt);
                         Map(x => x.price_chg_conv);
                         Map(x => x.qty_chg_conv);
                         Map(x => x.co_num);
                         Map(x => x.item);
                         Map(x => x.u_m);
                         Map(x => x.CreatedBy);
                         Map(x => x.UpdatedBy);

            }
          }
            
            }