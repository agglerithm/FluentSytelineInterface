using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class aptrxMap :  ClassMap<aptrx>
            {
             
               public aptrxMap()
               {
                Table("aptrx");                         
                   Id(x => x.RowPointer);
                         Map(x => x.post_from_po);
                         Map(x => x.prox_day);
                         Map(x => x.includes_tax);
                         Map(x => x.fixed_rate);
                         Map(x => x.prox_code);
                         Map(x => x.NoteExistsFlag);
                         Map(x => x.InWorkflow);
                         Map(x => x.include_tax_in_cost);
                         Map(x => x.voucher);
                         Map(x => x.due_days);
                         Map(x => x.disc_days);
                         Map(x => x.pre_register);
                         Map(x => x.dist_date);
                         Map(x => x.inv_date);
                         Map(x => x.due_date);
                         Map(x => x.disc_date);
                         Map(x => x.RecordDate);
                         Map(x => x.CreateDate);
                         Map(x => x.tax_date);
                         Map(x => x.inv_amt);
                         Map(x => x.non_disc_amt);
                         Map(x => x.disc_pct);
                         Map(x => x.disc_amt);
                         Map(x => x.exch_rate);
                         Map(x => x.purch_amt);
                         Map(x => x.insurance_amt);
                         Map(x => x.loc_frt_amt);
                         Map(x => x.misc_charges);
                         Map(x => x.sales_tax);
                         Map(x => x.sales_tax_2);
                         Map(x => x.freight);
                         Map(x => x.duty_amt);
                         Map(x => x.brokerage_amt);
                         Map(x => x.vend_num);
                         Map(x => x.po_num);
                         Map(x => x.inv_num);
                         Map(x => x.ap_acct);
                         Map(x => x.reff).Column("ref");
                         Map(x => x.txt);
                         Map(x => x.builder_voucher_orig_site);
                         Map(x => x.builder_voucher);
                         Map(x => x.grn_num);
                         Map(x => x.authorizer);
                         Map(x => x.CreatedBy);
                         Map(x => x.UpdatedBy);
                         Map(x => x.builder_po_orig_site);
                         Map(x => x.builder_po_num);
                         Map(x => x.tax_code1);
                         Map(x => x.tax_code2);
                         Map(x => x.ap_acct_unit1);
                         Map(x => x.ap_acct_unit2);
                         Map(x => x.ap_acct_unit3);
                         Map(x => x.ap_acct_unit4);
                         Map(x => x.type);
                         Map(x => x.auth_status);

            }
          }
            
            }