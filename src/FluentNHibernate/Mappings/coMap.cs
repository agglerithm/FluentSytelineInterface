using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class coMap :  ClassMap<co>
            {
             
               public coMap()
               {
                Table("co");    Id(x => x.RowPointer);
    Map(x => x.edi_order);
    Map(x => x.use_exch_rate);
    Map(x => x.ship_partial);
    Map(x => x.ship_early);
    Map(x => x.fixed_rate);
    Map(x => x.invoiced);
    Map(x => x.uf_enduser_flag);
    Map(x => x.einvoice);
    Map(x => x.logifld);
    Map(x => x.InWorkflow);
    Map(x => x.include_tax_in_price);
    Map(x => x.Uf_LRM_Integrate);
    Map(x => x.is_external);
    Map(x => x.credit_hold);
    Map(x => x.sync_reqd);
    Map(x => x.aps_pull_up);
    Map(x => x.consolidate);
    Map(x => x.summarize);
    Map(x => x.NoteExistsFlag);
    Map(x => x.qty_packages);
    Map(x => x.cust_seq);
    Map(x => x.Uf_LRM_Priority);
    Map(x => x.Uf_LRM_IntermediateCustSeq);
    Map(x => x.order_date);
    Map(x => x.close_date);
    Map(x => x.eff_date);
    Map(x => x.exp_date);
    Map(x => x.credit_hold_date);
    Map(x => x.projected_date);
    Map(x => x.RecordDate);
    Map(x => x.datefld);
    Map(x => x.CreateDate);
    Map(x => x.price);
    Map(x => x.weight);
    Map(x => x.freight);
    Map(x => x.misc_charges);
    Map(x => x.prepaid_amt);
    Map(x => x.sales_tax);
    Map(x => x.vovhd_cost_t);
    Map(x => x.out_cost_t);
    Map(x => x.exch_rate);
    Map(x => x.decifld1);
    Map(x => x.decifld2);
    Map(x => x.decifld3);
    Map(x => x.sales_tax_t2);
    Map(x => x.disc_amount);
    Map(x => x.disc);
    Map(x => x.matl_cost_t);
    Map(x => x.lbr_cost_t);
    Map(x => x.fovhd_cost_t);
    Map(x => x.cost);
    Map(x => x.freight_t);
    Map(x => x.m_charges_t);
    Map(x => x.prepaid_t);
    Map(x => x.sales_tax_t);
    Map(x => x.sales_tax_2);
    Map(x => x.co_num);
    Map(x => x.est_num);
    Map(x => x.cust_num);
    Map(x => x.contact);
    Map(x => x.phone);
    Map(x => x.cust_po);
    Map(x => x.uf_enduser_fax);
    Map(x => x.uf_enduser_name);
    Map(x => x.uf_enduser_other);
    Map(x => x.uf_enduser_phone);
    Map(x => x.uf_enduser_state);
    Map(x => x.uf_enduser_zip);
    Map(x => x.uf_enduser_addr4);
    Map(x => x.uf_enduser_city);
    Map(x => x.uf_enduser_contact);
    Map(x => x.uf_enduser_country);
    Map(x => x.uf_enduser_county);
    Map(x => x.uf_enduser_email);
    Map(x => x.external_confirmation_ref);
    Map(x => x.prospect_id);
    Map(x => x.opp_id);
    Map(x => x.uf_enduser_addr1);
    Map(x => x.uf_enduser_addr2);
    Map(x => x.uf_enduser_addr3);
    Map(x => x.Uf_LRM_FreightTerms);
    Map(x => x.Uf_LRM_OnwardCarrier);
    Map(x => x.Uf_LRM_OnwardClassOfService);
    Map(x => x.Uf_LRM_ShipPo);
    Map(x => x.Uf_LRM_ConsigneeShipType);
    Map(x => x.Uf_LRM_IntermediateCustNum);
    Map(x => x.Uf_LRM_PackListMsg);
    Map(x => x.Uf_LRM_ShipmentServices1);
    Map(x => x.Uf_LRM_ShipmentServices2);
    Map(x => x.Uf_LRM_Carrier);
    Map(x => x.Uf_LRM_ClassOfService);
    Map(x => x.Uf_LRM_FreightAccount);
    Map(x => x.config_id);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.trans_nat_2);
    Map(x => x.apply_to_inv_num);
    Map(x => x.Uf_LRM_BOLMsg);
    Map(x => x.credit_hold_reason);
    Map(x => x.credit_hold_user);
    Map(x => x.order_source);
    Map(x => x.charfld1);
    Map(x => x.charfld2);
    Map(x => x.charfld3);
    Map(x => x.msc_tax_code1);
    Map(x => x.msc_tax_code2);
    Map(x => x.pricecode);
    Map(x => x.end_user_type);
    Map(x => x.orig_site);
    Map(x => x.lcr_num);
    Map(x => x.process_ind);
    Map(x => x.delterm);
    Map(x => x.tax_code1);
    Map(x => x.tax_code2);
    Map(x => x.frt_tax_code1);
    Map(x => x.frt_tax_code2);
    Map(x => x.taken_by);
    Map(x => x.terms_code);
    Map(x => x.ship_code);
    Map(x => x.slsman);
    Map(x => x.whse);
    Map(x => x.trans_nat);
    Map(x => x.type);
    Map(x => x.stat);
    Map(x => x.discount_type);
    Map(x => x.edi_type);
    Map(x => x.convert_type);
    Map(x => x.inv_freq);
    Map(x => x.ack_stat);
    Map(x => x.export_type);

            }
          }
            
            }