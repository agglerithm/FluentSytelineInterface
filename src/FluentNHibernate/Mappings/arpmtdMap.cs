using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class arpmtdMap :  ClassMap<arpmtd>
            {
             
               public arpmtdMap()
               {
                Table("arpmtd");   
                   Id(x => x.RowPointer);
                    Map(x => x.NoteExistsFlag);
                    Map(x => x.InWorkflow);
                    Map(x => x.check_num);
                    Map(x => x.RecordDate);
                    Map(x => x.CreateDate);
                    Map(x => x.dom_amt_applied);
                    Map(x => x.dom_disc_amt);
                    Map(x => x.dom_allow_amt);
                    Map(x => x.for_amt_applied);
                    Map(x => x.for_disc_amt);
                    Map(x => x.for_allow_amt);
                    Map(x => x.exch_rate);
                    Map(x => x.for_tax_1);
                    Map(x => x.for_tax_2);
                    Map(x => x.dom_tax_1);
                    Map(x => x.dom_tax_2);
                    Map(x => x.cust_num);
                    Map(x => x.inv_num);
                    Map(x => x.site);
                    Map(x => x.disc_acct);
                    Map(x => x.allow_acct);
                    Map(x => x.deposit_acct);
                    Map(x => x.credit_memo_num);
                    Map(x => x.deposit_acct_unit2);
                    Map(x => x.deposit_acct_unit3);
                    Map(x => x.deposit_acct_unit4);
                    Map(x => x.do_num);
                    Map(x => x.CreatedBy);
                    Map(x => x.UpdatedBy);
                    Map(x => x.disc_acct_unit4);
                    Map(x => x.allow_acct_unit1);
                    Map(x => x.allow_acct_unit2);
                    Map(x => x.allow_acct_unit3);
                    Map(x => x.allow_acct_unit4);
                    Map(x => x.deposit_acct_unit1);
                    Map(x => x.apply_cust_num);
                    Map(x => x.bank_code);
                    Map(x => x.co_num);
                    Map(x => x.disc_acct_unit1);
                    Map(x => x.disc_acct_unit2);
                    Map(x => x.disc_acct_unit3);
                    Map(x => x.type);

            }
          }
            
            }