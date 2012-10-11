using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class appmtdMap :  ClassMap<appmtd>
            {
             
               public appmtdMap()
               {
                Table("appmtd");              
                   Id(x => x.RowPointer);
                  Map(x => x.NoteExistsFlag);
                  Map(x => x.InWorkflow);
                  Map(x => x.check_seq);
                  Map(x => x.voucher);
                  Map(x => x.RecordDate);
                  Map(x => x.CreateDate);
                  Map(x => x.dom_amt_paid);
                  Map(x => x.dom_amt_disc);
                  Map(x => x.for_amt_paid);
                  Map(x => x.for_amt_disc);
                  Map(x => x.exch_rate);
                  Map(x => x.for_tax_1);
                  Map(x => x.for_tax_2);
                  Map(x => x.dom_tax_1);
                  Map(x => x.dom_tax_2);
                  Map(x => x.vend_num);
                  Map(x => x.site);
                  Map(x => x.disc_acct);
                  Map(x => x.inv_num);
                  Map(x => x.apply_vend_num);
                  Map(x => x.bank_code);
                  Map(x => x.CreatedBy);
                  Map(x => x.UpdatedBy);
                  Map(x => x.disc_acct_unit1);
                  Map(x => x.disc_acct_unit2);
                  Map(x => x.disc_acct_unit3);
                  Map(x => x.disc_acct_unit4);
                  Map(x => x.po_num);
                  Map(x => x.grn_num);
                  Map(x => x.type);

            }
          }
            
            }