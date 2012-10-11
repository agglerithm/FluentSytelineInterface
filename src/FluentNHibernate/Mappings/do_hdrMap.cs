using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class do_hdrMap :  ClassMap<do_hdr>
            {
             
               public do_hdrMap()
               {
                Table("do_hdr");    Id(x => x.RowPointer);
    Map(x => x.bol_printed);
    Map(x => x.pack_slip_printed);
    Map(x => x.proforma_printed);
    Map(x => x.invoice_printed);
    Map(x => x.asn_extracted);
    Map(x => x.shipped);
    Map(x => x.asn_printed);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.qty_packages);
    Map(x => x.cust_seq);
    Map(x => x.do_hdr_date);
    Map(x => x.pickup_date);
    Map(x => x.shipped_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.do_value);
    Map(x => x.weight);
    Map(x => x.cod_amt);
    Map(x => x.col_fee);
    Map(x => x.col_misc_charges);
    Map(x => x.col_freight_charges);
    Map(x => x.ppd_fee);
    Map(x => x.ppd_misc_charges);
    Map(x => x.ppd_freight_charges);
    Map(x => x.do_num);
    Map(x => x.cust_num);
    Map(x => x.carrier);
    Map(x => x.carrier_contact);
    Map(x => x.carrier_num);
    Map(x => x.veh_num);
    Map(x => x.UpdatedBy);
    Map(x => x.special_inst1).Column("special_inst##1");
    Map(x => x.special_inst2).Column("special_inst##2");
    Map(x => x.consignee_country);
    Map(x => x.consignor_contact_id);
    Map(x => x.consignor_contact);
    Map(x => x.CreatedBy);
    Map(x => x.invoicee_zip);
    Map(x => x.invoicee_county);
    Map(x => x.invoicee_country);
    Map(x => x.invoicee_contact);
    Map(x => x.invoicee_phone);
    Map(x => x.invoicee_fax);
    Map(x => x.invoicee_addr1).Column("invoicee_addr##1");
    Map(x => x.invoicee_addr2).Column("invoicee_addr##2");
    Map(x => x.invoicee_addr3).Column("invoicee_addr##3");
    Map(x => x.invoicee_addr4).Column("invoicee_addr##4");
    Map(x => x.invoicee_city);
    Map(x => x.invoicee_state);
    Map(x => x.consignor_zip);
    Map(x => x.consignor_county);
    Map(x => x.consignor_country);
    Map(x => x.consignor_phone);
    Map(x => x.consignor_fax);
    Map(x => x.invoicee_name);
    Map(x => x.consignor_addr1).Column("consignor_addr##1");
    Map(x => x.consignor_addr2).Column("consignor_addr##2");
    Map(x => x.consignor_addr3).Column("consignor_addr##3");
    Map(x => x.consignor_addr4).Column("consignor_addr##4");
    Map(x => x.consignor_city);
    Map(x => x.consignor_state);
    Map(x => x.consignee_county);
    Map(x => x.consignee_contact);
    Map(x => x.consignee_phone);
    Map(x => x.consignee_fax);
    Map(x => x.consignor_name);
    Map(x => x.consignor_whse);
    Map(x => x.consignee_addr2).Column("consignee_addr##2");
    Map(x => x.consignee_addr3).Column("consignee_addr##3");
    Map(x => x.consignee_addr4).Column("consignee_addr##4");
    Map(x => x.consignee_city);
    Map(x => x.consignee_state);
    Map(x => x.consignee_zip);
    Map(x => x.pro_number);
    Map(x => x.container);
    Map(x => x.route);
    Map(x => x.weight_u_m);
    Map(x => x.consignee_name);
    Map(x => x.consignee_addr1).Column("consignee_addr##1");
    Map(x => x.stat);
    Map(x => x.do_invoice);
    Map(x => x.inv_freq);

            }
          }
            
            }