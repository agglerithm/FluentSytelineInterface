using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class poitemMap :  ClassMap<poitem>
            {
             
               public poitemMap()
               {
                Table("poitem");    Id(x => x.RowPointer);
    Map(x => x.lc_override);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.expedited);
    Map(x => x.unlinked_xref);
    Map(x => x.po_line);
    Map(x => x.po_release);
    Map(x => x.ref_line_suf);
    Map(x => x.ref_release);
    Map(x => x.root_suf);
    Map(x => x.req_line);
    Map(x => x.drop_seq);
    Map(x => x.cons_num);
    Map(x => x.due_date);
    Map(x => x.rcvd_date);
    Map(x => x.promise_date);
    Map(x => x.release_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.due_date_day);
    Map(x => x.qty_ordered);
    Map(x => x.qty_received);
    Map(x => x.qty_rejected);
    Map(x => x.qty_voucher);
    Map(x => x.qty_returned);
    Map(x => x.item_cost);
    Map(x => x.unit_loc_frt_cost_conv);
    Map(x => x.suppl_qty_conv_factor);
    Map(x => x.unit_duty_cost_conv);
    Map(x => x.unit_freight_cost_conv);
    Map(x => x.unit_brokerage_cost_conv);
    Map(x => x.unit_insurance_cost);
    Map(x => x.unit_insurance_cost_conv);
    Map(x => x.unit_loc_frt_cost);
    Map(x => x.unit_brokerage_cost);
    Map(x => x.export_value);
    Map(x => x.qty_ordered_conv);
    Map(x => x.item_cost_conv);
    Map(x => x.plan_cost_conv);
    Map(x => x.unit_mat_cost_conv);
    Map(x => x.plan_cost);
    Map(x => x.voucher_cost);
    Map(x => x.unit_weight);
    Map(x => x.unit_mat_cost);
    Map(x => x.unit_duty_cost);
    Map(x => x.unit_freight_cost);
    Map(x => x.rcpt_rqmt);
    Map(x => x.po_num);
    Map(x => x.item);
    Map(x => x.ref_num);
    Map(x => x.vend_item);
    Map(x => x.root_job);
    Map(x => x.non_inv_acct);
    Map(x => x.drawing_nbr);
    Map(x => x.po_vend_num);
    Map(x => x.description);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.trans_nat_2);
    Map(x => x.u_m);
    Map(x => x.non_inv_acct_unit1);
    Map(x => x.non_inv_acct_unit2);
    Map(x => x.non_inv_acct_unit3);
    Map(x => x.non_inv_acct_unit4);
    Map(x => x.revision);
    Map(x => x.origin);
    Map(x => x.tax_code1);
    Map(x => x.tax_code2);
    Map(x => x.ec_code);
    Map(x => x.transport);
    Map(x => x.req_num);
    Map(x => x.drop_ship_no);
    Map(x => x.whse);
    Map(x => x.comm_code);
    Map(x => x.trans_nat);
    Map(x => x.process_ind);
    Map(x => x.delterm);
    Map(x => x.stat);
    Map(x => x.ref_type);
    Map(x => x.ship_addr);
    Map(x => x.item_type);
    Map(x => x.cost_type);

            }
          }
            
            }