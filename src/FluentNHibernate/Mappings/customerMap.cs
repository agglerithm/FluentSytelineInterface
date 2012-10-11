using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class customerMap :  ClassMap<customer>
            {
             
               public customerMap()
               {
                Table("customer");    Id(x => x.RowPointer);
    Map(x => x.crm_guid);
    Map(x => x.fin_chg);
    Map(x => x.logifld);
    Map(x => x.edi_cust);
    Map(x => x.use_exch_rate);
    Map(x => x.ship_early);
    Map(x => x.ship_partial);
    Map(x => x.show_in_drop_down_list);
    Map(x => x.include_tax_in_price);
    Map(x => x.use_revision_pay_days);
    Map(x => x.revision_day);
    Map(x => x.pay_day);
    Map(x => x.active_for_data_integration);
    Map(x => x.show_in_ship_to_drop_down_list);
    Map(x => x.summarize);
    Map(x => x.NoteExistsFlag);
    Map(x => x.einvoice);
    Map(x => x.InWorkflow);
    Map(x => x.print_pack_inv);
    Map(x => x.one_pack_inv);
    Map(x => x.lcr_reqd);
    Map(x => x.draft_print_flag);
    Map(x => x.rcv_internal_email);
    Map(x => x.send_customer_email);
    Map(x => x.aps_pull_up);
    Map(x => x.consolidate);
    Map(x => x.num_periods);
    Map(x => x.avg_days_os);
    Map(x => x.last_days_os);
    Map(x => x.cust_seq);
    Map(x => x.num_invoices);
    Map(x => x.hist_days_os);
    Map(x => x.larg_days_os);
    Map(x => x.number_of_employees);
    Map(x => x.last_inv);
    Map(x => x.last_paid);
    Map(x => x.last_fin_chg);
    Map(x => x.calc_date);
    Map(x => x.datefld);
    Map(x => x.RecordDate);
    Map(x => x.pay_day_start_time1).Column("pay_day_start_time##1");
    Map(x => x.pay_day_start_time2).Column("pay_day_start_time##2");
    Map(x => x.pay_day_end_time1).Column("pay_day_end_time##1");
    Map(x => x.pay_day_end_time2).Column("pay_day_end_time##2");
    Map(x => x.CreateDate);
    Map(x => x.revision_day_start_time1).Column("revision_day_start_time##1");
    Map(x => x.revision_day_start_time2).Column("revision_day_start_time##2");
    Map(x => x.revision_day_end_time1).Column("revision_day_end_time##1");
    Map(x => x.revision_day_end_time2).Column("revision_day_end_time##2");
    Map(x => x.sales_ytd);
    Map(x => x.sales_lst_yr);
    Map(x => x.disc_ytd);
    Map(x => x.disc_lst_yr);
    Map(x => x.sales_ptd);
    Map(x => x.avg_bal_os);
    Map(x => x.posted_bal);
    Map(x => x.company_revenue);
    Map(x => x.large_bal_os);
    Map(x => x.last_bal_os);
    Map(x => x.decifld1);
    Map(x => x.decifld2);
    Map(x => x.decifld3);
    Map(x => x.order_bal);
    Map(x => x.cust_num);
    Map(x => x.contact1).Column("contact##1");
    Map(x => x.contact2).Column("contact##1");
    Map(x => x.contact3).Column("contact##1");
    Map(x => x.phone1).Column("phone##1");
    Map(x => x.phone2).Column("phone##2");
    Map(x => x.sic_code);
    Map(x => x.territory_code);
    Map(x => x.Uf_LRM_FreightAccount);
    Map(x => x.Uf_LRM_FreightTerms);
    Map(x => x.Uf_LRM_OnwardCarrier);
    Map(x => x.Uf_LRM_OnwardClassOfService);
    Map(x => x.Uf_accountrep);
    Map(x => x.Uf_accountrepPhone);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.inv_category);
    Map(x => x.trans_nat_2);
    Map(x => x.Uf_LRM_Carrier);
    Map(x => x.Uf_LRM_ClassOfService);
    Map(x => x.pricecode);
    Map(x => x.lang_code);
    Map(x => x.end_user_type);
    Map(x => x.ship_site);
    Map(x => x.cust_bank);
    Map(x => x.customer_email_addr);
    Map(x => x.branch_id);
    Map(x => x.trans_nat);
    Map(x => x.delterm);
    Map(x => x.process_ind);
    Map(x => x.tax_code1);
    Map(x => x.tax_code2);
    Map(x => x.charfld1);
    Map(x => x.charfld2);
    Map(x => x.charfld3);
    Map(x => x.tax_reg_num1);
    Map(x => x.bank_code);
    Map(x => x.tax_reg_num2);
    Map(x => x.phone3).Column("phone##3");
    Map(x => x.cust_type);
    Map(x => x.terms_code);
    Map(x => x.ship_code);
    Map(x => x.slsman);
    Map(x => x.whse);
    Map(x => x.state_cycle);
    Map(x => x.pay_type);
    Map(x => x.do_invoice);
    Map(x => x.inv_freq);
    Map(x => x.export_type);

            }
          }
            
            }