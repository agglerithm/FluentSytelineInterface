using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class arpmtMap :  ClassMap<arpmt>
            {
             
               public arpmtMap()
               {
                Table("arpmt");    
                   Id(x => x.RowPointer);
                    Map(x => x.transfer_cash);
                    Map(x => x.NoteExistsFlag);
                    Map(x => x.InWorkflow);
                    Map(x => x.check_num);
                    Map(x => x.recpt_date);
                    Map(x => x.due_date);
                    Map(x => x.RecordDate);
                    Map(x => x.CreateDate);
                    Map(x => x.deposit_date);
                    Map(x => x.dom_check_amt);
                    Map(x => x.exch_rate);
                    Map(x => x.for_check_amt);
                    Map(x => x.cust_num);
                    Map(x => x.reff).Column("ref");
                    Map(x => x.description);
                    Map(x => x.bank_code);
                    Map(x => x.CreatedBy);
                    Map(x => x.UpdatedBy);
                    Map(x => x.credit_memo_num);
                    Map(x => x.type);

            }
          }
            
            }