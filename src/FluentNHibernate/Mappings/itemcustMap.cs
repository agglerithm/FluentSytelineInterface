using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class itemcustMap :  ClassMap<itemcust>
            {
             
               public itemcustMap()
               {
                Table("itemcust");    Id(x => x.RowPointer);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.due_period);
    Map(x => x.purch_ytd);
    Map(x => x.cust_item_seq);
    Map(x => x.rank);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.order_ytd);
    Map(x => x.ship_ytd);
    Map(x => x.order_ptd);
    Map(x => x.item);
    Map(x => x.cust_num);
    Map(x => x.cust_item);
    Map(x => x.u_m);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.end_user);

            }
          }
            
            }