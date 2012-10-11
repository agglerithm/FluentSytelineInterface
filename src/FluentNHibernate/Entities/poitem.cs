using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class poitem : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int lc_override{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int expedited{ get;set; } 
        public virtual int unlinked_xref{ get;set; } 
        public virtual int po_line{ get;set; } 
        public virtual int po_release{ get;set; } 
        public virtual int ref_line_suf{ get;set; } 
        public virtual int ref_release{ get;set; } 
        public virtual int root_suf{ get;set; } 
        public virtual int req_line{ get;set; } 
        public virtual int drop_seq{ get;set; } 
        public virtual int cons_num{ get;set; } 
        public virtual DateTime due_date{ get;set; } 
        public virtual DateTime rcvd_date{ get;set; } 
        public virtual DateTime promise_date{ get;set; } 
        public virtual DateTime release_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual DateTime due_date_day{ get;set; } 
        public virtual decimal qty_ordered{ get;set; } 
        public virtual decimal qty_received{ get;set; } 
        public virtual decimal qty_rejected{ get;set; } 
        public virtual decimal qty_voucher{ get;set; } 
        public virtual decimal qty_returned{ get;set; } 
        public virtual decimal item_cost{ get;set; } 
        public virtual decimal unit_loc_frt_cost_conv{ get;set; } 
        public virtual decimal suppl_qty_conv_factor{ get;set; } 
        public virtual decimal unit_duty_cost_conv{ get;set; } 
        public virtual decimal unit_freight_cost_conv{ get;set; } 
        public virtual decimal unit_brokerage_cost_conv{ get;set; } 
        public virtual decimal unit_insurance_cost{ get;set; } 
        public virtual decimal unit_insurance_cost_conv{ get;set; } 
        public virtual decimal unit_loc_frt_cost{ get;set; } 
        public virtual decimal unit_brokerage_cost{ get;set; } 
        public virtual decimal export_value{ get;set; } 
        public virtual decimal qty_ordered_conv{ get;set; } 
        public virtual decimal item_cost_conv{ get;set; } 
        public virtual decimal plan_cost_conv{ get;set; } 
        public virtual decimal unit_mat_cost_conv{ get;set; } 
        public virtual decimal plan_cost{ get;set; } 
        public virtual decimal voucher_cost{ get;set; } 
        public virtual decimal unit_weight{ get;set; } 
        public virtual decimal unit_mat_cost{ get;set; } 
        public virtual decimal unit_duty_cost{ get;set; } 
        public virtual decimal unit_freight_cost{ get;set; } 
        public virtual string rcpt_rqmt{ get;set; } 
        public virtual string po_num{ get;set; } 
        public virtual string item{ get;set; } 
        public virtual string ref_num{ get;set; } 
        public virtual string vend_item{ get;set; } 
        public virtual string root_job{ get;set; } 
        public virtual string non_inv_acct{ get;set; } 
        public virtual string drawing_nbr{ get;set; } 
        public virtual string po_vend_num{ get;set; } 
        public virtual string description{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string trans_nat_2{ get;set; } 
        public virtual string u_m{ get;set; } 
        public virtual string non_inv_acct_unit1{ get;set; } 
        public virtual string non_inv_acct_unit2{ get;set; } 
        public virtual string non_inv_acct_unit3{ get;set; } 
        public virtual string non_inv_acct_unit4{ get;set; } 
        public virtual string revision{ get;set; } 
        public virtual string origin{ get;set; } 
        public virtual string tax_code1{ get;set; } 
        public virtual string tax_code2{ get;set; } 
        public virtual string ec_code{ get;set; } 
        public virtual string transport{ get;set; } 
        public virtual string req_num{ get;set; } 
        public virtual string drop_ship_no{ get;set; } 
        public virtual string whse{ get;set; } 
        public virtual string comm_code{ get;set; } 
        public virtual string trans_nat{ get;set; } 
        public virtual string process_ind{ get;set; } 
        public virtual string delterm{ get;set; } 
        public virtual string stat{ get;set; } 
        public virtual string ref_type{ get;set; } 
        public virtual string ship_addr{ get;set; } 
        public virtual string item_type{ get;set; } 
        public virtual string cost_type{ get;set; } 


    }
}