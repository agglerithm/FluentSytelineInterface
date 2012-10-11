using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class vendorMap :  ClassMap<vendor>
            {
             
               public vendorMap()
               {
                Table("vendor");    
                   Id(x => x.RowPointer);
                Map(x => x.print_price);
                Map(x => x.logifld);
                Map(x => x.edi_vend);
                Map(x => x.lcr_reqd);
                Map(x => x.NoteExistsFlag);
                Map(x => x.InWorkflow);
                Map(x => x.show_in_drop_down_list);
                Map(x => x.print_vat_on_po);
                Map(x => x.include_tax_in_cost);
                Map(x => x.active_for_data_integration);
                Map(x => x.supply_web_vendor);
                Map(x => x.request_acknowledgement);
                Map(x => x.synchronized_to_bus);
                Map(x => x.transit);
                Map(x => x.last_purch);
                Map(x => x.last_paid);
                Map(x => x.datefld);
                Map(x => x.RecordDate);
                Map(x => x.CreateDate);
                Map(x => x.purch_ytd);
                Map(x => x.purch_lst_yr);
                Map(x => x.disc_ytd);
                Map(x => x.disc_lst_yr);
                Map(x => x.pay_ytd);
                Map(x => x.decifld1);
                Map(x => x.pay_lst_fiscal_yr);
                Map(x => x.decifld2);
                Map(x => x.decifld3);
                Map(x => x.pay_lst_yr);
                Map(x => x.vch_over_po_cost_tolerance);
                Map(x => x.vch_under_po_cost_tolerance);
                Map(x => x.pay_fiscal_ytd);
                Map(x => x.vend_num);
                Map(x => x.contact);
                Map(x => x.phone);
                Map(x => x.vend_type);
                Map(x => x.terms_code);
                Map(x => x.ship_code);
                Map(x => x.UpdatedBy);
                Map(x => x.account);
                Map(x => x.account_name);
                Map(x => x.EFT_bank_num);
                Map(x => x.trans_nat_2);
                Map(x => x.pur_acct_unit1);
                Map(x => x.pur_acct_unit2);
                Map(x => x.pur_acct_unit3);
                Map(x => x.pur_acct_unit4);
                Map(x => x.category);
                Map(x => x.CreatedBy);
                Map(x => x.process_ind);
                Map(x => x.tax_reg_num2);
                Map(x => x.tax_code1);
                Map(x => x.tax_code2);
                Map(x => x.lang_code);
                Map(x => x.pur_acct);
                Map(x => x.curr_code);
                Map(x => x.tax_reg_num1);
                Map(x => x.bank_code);
                Map(x => x.branch_id);
                Map(x => x.trans_nat);
                Map(x => x.delterm);
                Map(x => x.fob);
                Map(x => x.vend_remit);
                Map(x => x.whse);
                Map(x => x.charfld1);
                Map(x => x.charfld2);
                Map(x => x.charfld3);
                Map(x => x.stat);
                Map(x => x.pay_type);
                Map(x => x.price_by);

            }
          }
            
            }