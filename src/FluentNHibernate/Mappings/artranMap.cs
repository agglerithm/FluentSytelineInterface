using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class artranMap :  ClassMap<artran>
            {
             
               public artranMap()
               {
                Table("artran");    Id(x => x.RowPointer);
    Map(x => x.post_from_co);
    Map(x => x.active);
    Map(x => x.fixed_rate);
    Map(x => x.rma);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.apply_to_inv_num_category);
    Map(x => x.inv_seq);
    Map(x => x.check_seq);
    Map(x => x.is_invoice);
    Map(x => x.inv_date);
    Map(x => x.due_date);
    Map(x => x.disc_date);
    Map(x => x.issue_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.amount);
    Map(x => x.disc_amt);
    Map(x => x.exch_rate);
    Map(x => x.misc_charges);
    Map(x => x.sales_tax);
    Map(x => x.freight);
    Map(x => x.sales_tax_2);
    Map(x => x.cust_num);
    Map(x => x.inv_num);
    Map(x => x.co_num);
    Map(x => x.acct);
    Map(x => x.description);
    Map(x => x.bank_code);
    Map(x => x.acct_unit4);
    Map(x => x.reff).Column("ref");
    Map(x => x.do_num);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.apply_to_inv_num);
    Map(x => x.tax_code1);
    Map(x => x.tax_code2);
    Map(x => x.corp_cust);
    Map(x => x.acct_unit1);
    Map(x => x.acct_unit2);
    Map(x => x.acct_unit3);
    Map(x => x.type);
    Map(x => x.pay_type);
    Map(x => x.approval_status);

            }
          }
            
            }