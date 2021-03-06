using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class itemMap :  ClassMap<item>
            {
             
               public itemMap()
               {
                Table("item");    Id(x => x.RowPointer);
    Map(x => x.stocked);
    Map(x => x.low_level);
    Map(x => x.mps_flag);
    Map(x => x.accept_req);
    Map(x => x.phantom_flag);
    Map(x => x.plan_flag);
    Map(x => x.print_kit_components);
    Map(x => x.show_in_drop_down_list);
    Map(x => x.controlled_by_external_ics);
    Map(x => x.active_for_data_integration);
    Map(x => x.include_in_net_change_planning);
    Map(x => x.uf_plank_item);
    Map(x => x.Uf_LRM_IsShipped);
    Map(x => x.uf_qc_required);
    Map(x => x.kit);
    Map(x => x.order_configurable);
    Map(x => x.job_configurable);
    Map(x => x.InWorkflow);
    Map(x => x.mfg_supply_switching_active);
    Map(x => x.use_reorder_point);
    Map(x => x.tax_free_matl);
    Map(x => x.lot_tracked);
    Map(x => x.pass_req);
    Map(x => x.lot_gen_exp);
    Map(x => x.mrp_part);
    Map(x => x.infinite_part);
    Map(x => x.NoteExistsFlag);
    Map(x => x.backflush);
    Map(x => x.logifld);
    Map(x => x.track_ecn);
    Map(x => x.reservable);
    Map(x => x.serial_length);
    Map(x => x.serial_tracked);
    Map(x => x.lead_time);
    Map(x => x.suffix);
    Map(x => x.days_supply);
    Map(x => x.paper_time);
    Map(x => x.dock_time);
    Map(x => x.next_config);
    Map(x => x.safety_stock_rule);
    Map(x => x.shelf_life);
    Map(x => x.mps_plan_fence);
    Map(x => x.due_period);
    Map(x => x.exp_lead_time);
    Map(x => x.time_fence_rule);
    Map(x => x.tax_free_days);
    Map(x => x.uf_skid_qty);
    Map(x => x.Uf_LRM_ProductAllocationMethod);
    Map(x => x.last_inv);
    Map(x => x.change_date);
    Map(x => x.datefld);
    Map(x => x.chg_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.earliest_planned_po_receipt);
    Map(x => x.lowdate);
    Map(x => x.time_fence_value);
    Map(x => x.qty_allocjob);
    Map(x => x.lot_size);
    Map(x => x.qty_used_ytd);
    Map(x => x.qty_mfg_ytd);
    Map(x => x.lst_lot_size);
    Map(x => x.unit_cost);
    Map(x => x.rcvd_under_po_qty_tolerance);
    Map(x => x.unit_insurance_cost);
    Map(x => x.unit_loc_frt_cost);
    Map(x => x.cur_insurance_cost);
    Map(x => x.cur_loc_frt_cost);
    Map(x => x.safety_stock_percent);
    Map(x => x.rcvd_over_po_qty_tolerance);
    Map(x => x.rate_per_day);
    Map(x => x.order_max);
    Map(x => x.supply_tolerance_hrs);
    Map(x => x.var_exp_lead);
    Map(x => x.reorder_point);
    Map(x => x.fixed_order_qty);
    Map(x => x.cur_out_cost);
    Map(x => x.avg_matl_cost);
    Map(x => x.avg_lbr_cost);
    Map(x => x.avg_fovhd_cost);
    Map(x => x.avg_vovhd_cost);
    Map(x => x.avg_out_cost);
    Map(x => x.vovhd_cost);
    Map(x => x.out_cost);
    Map(x => x.cur_matl_cost);
    Map(x => x.cur_lbr_cost);
    Map(x => x.cur_fovhd_cost);
    Map(x => x.cur_vovhd_cost);
    Map(x => x.cur_duty_cost);
    Map(x => x.cur_freight_cost);
    Map(x => x.cur_brokerage_cost);
    Map(x => x.matl_cost);
    Map(x => x.lbr_cost);
    Map(x => x.fovhd_cost);
    Map(x => x.u_ws_price);
    Map(x => x.unit_mat_cost);
    Map(x => x.unit_duty_cost);
    Map(x => x.unit_freight_cost);
    Map(x => x.unit_brokerage_cost);
    Map(x => x.cur_mat_cost);
    Map(x => x.unit_weight);
    Map(x => x.cur_u_cost);
    Map(x => x.var_lead);
    Map(x => x.decifld1);
    Map(x => x.decifld2);
    Map(x => x.decifld3);
    Map(x => x.comp_other);
    Map(x => x.comp_fixed);
    Map(x => x.comp_var);
    Map(x => x.comp_outside);
    Map(x => x.sub_matl);
    Map(x => x.shrink_fact);
    Map(x => x.asm_outside);
    Map(x => x.comp_setup);
    Map(x => x.comp_run);
    Map(x => x.comp_matl);
    Map(x => x.comp_tool);
    Map(x => x.comp_fixture);
    Map(x => x.asm_matl);
    Map(x => x.asm_tool);
    Map(x => x.asm_fixture);
    Map(x => x.asm_other);
    Map(x => x.asm_fixed);
    Map(x => x.asm_var);
    Map(x => x.lst_u_cost);
    Map(x => x.avg_u_cost);
    Map(x => x.order_min);
    Map(x => x.order_mult);
    Map(x => x.asm_setup);
    Map(x => x.asm_run);
    Map(x => x.rcpt_rqmt);
    Map(x => x.itemID).Column("item");
    Map(x => x.description);
    Map(x => x.u_m);
    Map(x => x.drawing_nbr);
    Map(x => x.product_code);
    Map(x => x.job);
    Map(x => x.Uf_LRM_UPCCode);
    Map(x => x.Uf_LRM_HSTariff);
    Map(x => x.Uf_LRM_NetCost);
    Map(x => x.Uf_LRM_NMFC);
    Map(x => x.Uf_LRM_NMFCSub);
    Map(x => x.Uf_LRM_PrefCriterion);
    Map(x => x.Uf_LRM_Producer);
    Map(x => x.tariff_classification);
    Map(x => x.Uf_ItemDescription2);
    Map(x => x.uf_label_type);
    Map(x => x.uf_pick_zone);
    Map(x => x.Uf_LRM_CountryOfOrigin);
    Map(x => x.Uf_LRM_Eccn);
    Map(x => x.cfg_model);
    Map(x => x.co_post_config);
    Map(x => x.job_post_config);
    Map(x => x.setupgroup);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.supply_site);
    Map(x => x.prod_mix);
    Map(x => x.status_chg_user_code);
    Map(x => x.reason_code);
    Map(x => x.supply_whse);
    Map(x => x.buyer);
    Map(x => x.origin);
    Map(x => x.tax_code1);
    Map(x => x.tax_code2);
    Map(x => x.bflush_loc);
    Map(x => x.lot_prefix);
    Map(x => x.serial_prefix);
    Map(x => x.feat_str);
    Map(x => x.feat_templ);
    Map(x => x.charfld1);
    Map(x => x.charfld2);
    Map(x => x.charfld3);
    Map(x => x.comm_code);
    Map(x => x.family_code);
    Map(x => x.plan_code);
    Map(x => x.revision);
    Map(x => x.alt_item);
    Map(x => x.weight_units);
    Map(x => x.charfld4);
    Map(x => x.abc_code);
    Map(x => x.p_m_t_code);
    Map(x => x.cost_method);
    Map(x => x.matl_type);
    Map(x => x.feat_type);
    Map(x => x.issue_by);
    Map(x => x.cost_type);
    Map(x => x.prod_type);
    Map(x => x.stat);
    Map(x => x.auto_job);
    Map(x => x.auto_post);

            }
          }
            
            }