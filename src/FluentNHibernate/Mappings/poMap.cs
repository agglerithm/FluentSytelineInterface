using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class poMap :  ClassMap<po>
            {
             
               public poMap()
               {
                Table("po");    Id(x => x.RowPointer);
    Map(x => x.print_price);
    Map(x => x.logifld);
    Map(x => x.fixed_rate);
    Map(x => x.received);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.include_tax_in_cost);
    Map(x => x.contains_only_tax_free_matls);
    Map(x => x.builder_po_printed);
    Map(x => x.synchronized_to_bus);
    Map(x => x.drop_seq);
    Map(x => x.order_date);
    Map(x => x.inv_date);
    Map(x => x.dist_date);
    Map(x => x.eff_date);
    Map(x => x.exp_date);
    Map(x => x.datefld);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.po_cost);
    Map(x => x.misc_charges);
    Map(x => x.sales_tax);
    Map(x => x.freight);
    Map(x => x.m_charges_t);
    Map(x => x.sales_tax_t);
    Map(x => x.local_freight_amt);
    Map(x => x.local_freight_amt_t);
    Map(x => x.act_insurance);
    Map(x => x.insurance_amt);
    Map(x => x.insurance_amt_t);
    Map(x => x.loc_frt_alloc_percent);
    Map(x => x.est_local_freight);
    Map(x => x.act_local_freight);
    Map(x => x.est_brokerage);
    Map(x => x.act_brokerage);
    Map(x => x.est_duty);
    Map(x => x.act_duty);
    Map(x => x.ins_alloc_percent);
    Map(x => x.est_insurance);
    Map(x => x.exch_rate);
    Map(x => x.frt_alloc_percent);
    Map(x => x.duty_alloc_percent);
    Map(x => x.brk_alloc_percent);
    Map(x => x.est_freight);
    Map(x => x.act_freight);
    Map(x => x.duty_amt_t);
    Map(x => x.duty_amt);
    Map(x => x.brokerage_amt);
    Map(x => x.brokerage_amt_t);
    Map(x => x.prepaid_amt);
    Map(x => x.prepaid_t);
    Map(x => x.freight_t);
    Map(x => x.sales_tax_2);
    Map(x => x.sales_tax_t2);
    Map(x => x.decifld1);
    Map(x => x.decifld2);
    Map(x => x.decifld3);
    Map(x => x.po_num);
    Map(x => x.vend_num);
    Map(x => x.ship_code);
    Map(x => x.terms_code);
    Map(x => x.fob);
    Map(x => x.vend_order);
    Map(x => x.trans_nat_2);
    Map(x => x.builder_po_orig_site);
    Map(x => x.builder_po_num);
    Map(x => x.vend_lcr_num);
    Map(x => x.buyer);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.ins_vend_num);
    Map(x => x.loc_frt_vend_num);
    Map(x => x.frt_tax_code2);
    Map(x => x.msc_tax_code1);
    Map(x => x.msc_tax_code2);
    Map(x => x.freight_vend_num);
    Map(x => x.duty_vend_num);
    Map(x => x.brokerage_vend_num);
    Map(x => x.trans_nat);
    Map(x => x.process_ind);
    Map(x => x.delterm);
    Map(x => x.tax_code1);
    Map(x => x.tax_code2);
    Map(x => x.frt_tax_code1);
    Map(x => x.inv_num);
    Map(x => x.drop_ship_no);
    Map(x => x.whse);
    Map(x => x.charfld1);
    Map(x => x.charfld2);
    Map(x => x.charfld3);
    Map(x => x.stat);
    Map(x => x.type);
    Map(x => x.ship_addr);
    Map(x => x.duty_alloc_meth);
    Map(x => x.frt_alloc_meth);
    Map(x => x.brk_alloc_meth);
    Map(x => x.loc_frt_alloc_meth);
    Map(x => x.supply_web_po_stat);
    Map(x => x.duty_alloc_type);
    Map(x => x.frt_alloc_type);
    Map(x => x.brk_alloc_type);
    Map(x => x.ins_alloc_type);
    Map(x => x.ins_alloc_meth);
    Map(x => x.loc_frt_alloc_type);

            }
          }
            
            }