using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class custaddrMap :  ClassMap<custaddr>
            {
             
               public custaddrMap()
               {
                Table("custaddr");    Id(x => x.RowPointer);
    Map(x => x.credit_hold);
    Map(x => x.corp_cred);
    Map(x => x.corp_address);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.days_over_inv_due_date);
    Map(x => x.cust_seq);
    Map(x => x.credit_hold_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.credit_limit);
    Map(x => x.amt_over_inv_amt);
    Map(x => x.cust_num);
    Map(x => x.name);
    Map(x => x.city);
    Map(x => x.state);
    Map(x => x.zip);
    Map(x => x.county);
    Map(x => x.bill_to_email);
    Map(x => x.internet_url);
    Map(x => x.internal_email_addr);
    Map(x => x.external_email_addr);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.addr4).Column("addr##4");
    Map(x => x.credit_hold_user);
    Map(x => x.credit_hold_reason);
    Map(x => x.curr_code);
    Map(x => x.corp_cust);
    Map(x => x.ship_to_email);
    Map(x => x.country);
    Map(x => x.fax_num);
    Map(x => x.telex_num);
    Map(x => x.addr1).Column("addr##1");
    Map(x => x.addr2).Column("addr##2");
    Map(x => x.addr3).Column("addr##3");
    Map(x => x.bal_method);

            }
          }
            
            }