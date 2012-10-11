using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class inv_hdrMap :  ClassMap<inv_hdr>
            {
             
               public inv_hdrMap()
               {
                Table("inv_hdr");    Id(x => x.RowPointer);
    Map(x => x.use_exch_rate);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.qty_packages);
    Map(x => x.inv_seq);
    Map(x => x.cust_seq);
    Map(x => x.inv_date);
    Map(x => x.ship_date);
    Map(x => x.tax_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.weight);
    Map(x => x.misc_charges);
    Map(x => x.prepaid_amt);
    Map(x => x.freight);
    Map(x => x.cost);
    Map(x => x.price);
    Map(x => x.mgr_comm_cal);
    Map(x => x.mgr_comm_bse);
    Map(x => x.exch_rate);
    Map(x => x.disc);
    Map(x => x.disc_amount);
    Map(x => x.comm_calc);
    Map(x => x.comm_due);
    Map(x => x.comm_paid);
    Map(x => x.comm_base);
    Map(x => x.tot_comm_due);
    Map(x => x.tot_comm_pd);
    Map(x => x.inv_num);
    Map(x => x.cust_num);
    Map(x => x.co_num);
    Map(x => x.terms_code);
    Map(x => x.ship_code);
    Map(x => x.cust_po);
    Map(x => x.freight_acct_unit4);
    Map(x => x.do_num);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.misc_acct_unit2);
    Map(x => x.misc_acct_unit3);
    Map(x => x.misc_acct_unit4);
    Map(x => x.freight_acct_unit1);
    Map(x => x.freight_acct_unit2);
    Map(x => x.freight_acct_unit3);
    Map(x => x.ec_code);
    Map(x => x.frt_tax_code1);
    Map(x => x.frt_tax_code2);
    Map(x => x.msc_tax_code1);
    Map(x => x.msc_tax_code2);
    Map(x => x.misc_acct_unit1);
    Map(x => x.slsman);
    Map(x => x.state);
    Map(x => x.misc_acct);
    Map(x => x.freight_acct);
    Map(x => x.tax_code1);
    Map(x => x.tax_code2);
    Map(x => x.bill_type);

            }
          }
            
            }