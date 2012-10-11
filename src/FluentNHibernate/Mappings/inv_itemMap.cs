using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class inv_itemMap :  ClassMap<inv_item>
            {
             
               public inv_itemMap()
               {
                Table("inv_item");    Id(x => x.RowPointer);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.co_line);
    Map(x => x.co_release);
    Map(x => x.do_seq);
    Map(x => x.inv_seq);
    Map(x => x.inv_line);
    Map(x => x.cons_num);
    Map(x => x.do_line);
    Map(x => x.tax_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.qty_invoiced);
    Map(x => x.disc);
    Map(x => x.cost);
    Map(x => x.price);
    Map(x => x.old_price);
    Map(x => x.new_price);
    Map(x => x.restock_fee_amt);
    Map(x => x.inv_num);
    Map(x => x.co_num);
    Map(x => x.item);
    Map(x => x.sales_acct);
    Map(x => x.process_ind);
    Map(x => x.tax_code1);
    Map(x => x.do_num);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.orig_inv_num);
    Map(x => x.reason_text);
    Map(x => x.tax_code2);
    Map(x => x.sales_acct_unit1);
    Map(x => x.sales_acct_unit2);
    Map(x => x.sales_acct_unit3);
    Map(x => x.sales_acct_unit4);
    Map(x => x.cust_po);

            }
          }
            
            }