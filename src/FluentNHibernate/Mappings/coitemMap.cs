using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class coitemMap :  ClassMap<coitem>
            {
             
               public coitemMap()
               {
                Table("coitem");    Id(x => x.RowPointer);
    Map(x => x.reprice);
    Map(x => x.packed);
    Map(x => x.bol);
    Map(x => x.sync_reqd);
    Map(x => x.consolidate);
    Map(x => x.summarize);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.print_kit_components);
    Map(x => x.co_line);
    Map(x => x.co_release);
    Map(x => x.ref_line_suf);
    Map(x => x.ref_release);
    Map(x => x.rma_line);
    Map(x => x.cust_seq);
    Map(x => x.cons_num);
    Map(x => x.Uf_LRM_Priority);
    Map(x => x.Uf_LRM_IntermediateCustSeq);
    Map(x => x.due_date);
    Map(x => x.ship_date);
    Map(x => x.release_date);
    Map(x => x.promise_date);
    Map(x => x.pick_date);
    Map(x => x.projected_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.due_date_day);
    Map(x => x.qty_ordered);
    Map(x => x.qty_ready);
    Map(x => x.qty_shipped);
    Map(x => x.qty_packed);
    Map(x => x.disc);
    Map(x => x.cost);
    Map(x => x.fovhd_cost_conv);
    Map(x => x.vovhd_cost_conv);
    Map(x => x.out_cost_conv);
    Map(x => x.suppl_qty_conv_factor);
    Map(x => x.cgs_total_fovhd);
    Map(x => x.cgs_total_vovhd);
    Map(x => x.cgs_total_out);
    Map(x => x.cost_conv);
    Map(x => x.matl_cost_conv);
    Map(x => x.lbr_cost_conv);
    Map(x => x.lbr_cost);
    Map(x => x.fovhd_cost);
    Map(x => x.vovhd_cost);
    Map(x => x.out_cost);
    Map(x => x.cgs_total_matl);
    Map(x => x.cgs_total_lbr);
    Map(x => x.unit_weight);
    Map(x => x.export_value);
    Map(x => x.qty_ordered_conv);
    Map(x => x.price_conv);
    Map(x => x.qty_rsvd);
    Map(x => x.matl_cost);
    Map(x => x.qty_invoiced);
    Map(x => x.qty_returned);
    Map(x => x.cgs_total);
    Map(x => x.prg_bill_tot);
    Map(x => x.prg_bill_app);
    Map(x => x.wks_value);
    Map(x => x.price);
    Map(x => x.brk_qty1).Column("brk_qty##1");
    Map(x => x.brk_qty2).Column("brk_qty##2");
    Map(x => x.brk_qty3).Column("brk_qty##3");
    Map(x => x.brk_qty4).Column("brk_qty##4");
    Map(x => x.brk_qty5).Column("brk_qty##5");
    Map(x => x.rcpt_rqmt);
    Map(x => x.co_num);
    Map(x => x.item);
    Map(x => x.ref_num);
    Map(x => x.cust_item);
    Map(x => x.feat_str);
    Map(x => x.cust_num);
    Map(x => x.Uf_LRM_ShipPo);
    Map(x => x.Uf_LRM_IntermediateCustNum);
    Map(x => x.external_reservation_ref);
    Map(x => x.Uf_LRM_Carrier);
    Map(x => x.Uf_LRM_ClassOfService);
    Map(x => x.Uf_LRM_FreightAccount);
    Map(x => x.Uf_LRM_FreightTerms);
    Map(x => x.Uf_LRM_OnwardCarrier);
    Map(x => x.Uf_LRM_OnwardClassOfService);
    Map(x => x.config_id);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.trans_nat_2);
    Map(x => x.Uf_LRM_ShipmentServices1);
    Map(x => x.Uf_LRM_ShipmentServices2);
    Map(x => x.co_cust_num);
    Map(x => x.ship_site);
    Map(x => x.co_orig_site);
    Map(x => x.cust_po);
    Map(x => x.rma_num);
    Map(x => x.description);
    Map(x => x.tax_code1);
    Map(x => x.tax_code2);
    Map(x => x.ec_code);
    Map(x => x.transport);
    Map(x => x.pricecode);
    Map(x => x.u_m);
    Map(x => x.whse);
    Map(x => x.comm_code);
    Map(x => x.trans_nat);
    Map(x => x.process_ind);
    Map(x => x.delterm);
    Map(x => x.origin);
    Map(x => x.ref_type);
    Map(x => x.stat);
    Map(x => x.wks_basis);
    Map(x => x.inv_freq);

            }
          }
            
            }