using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class po : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int print_price{ get;set; } 
        public virtual int logifld{ get;set; } 
        public virtual int fixed_rate{ get;set; } 
        public virtual int received{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int include_tax_in_cost{ get;set; } 
        public virtual int contains_only_tax_free_matls{ get;set; } 
        public virtual int builder_po_printed{ get;set; } 
        public virtual int synchronized_to_bus{ get;set; } 
        public virtual int drop_seq{ get;set; } 
        public virtual DateTime order_date{ get;set; } 
        public virtual DateTime inv_date{ get;set; } 
        public virtual DateTime dist_date{ get;set; } 
        public virtual DateTime eff_date{ get;set; } 
        public virtual DateTime exp_date{ get;set; } 
        public virtual DateTime datefld{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal po_cost{ get;set; } 
        public virtual decimal misc_charges{ get;set; } 
        public virtual decimal sales_tax{ get;set; } 
        public virtual decimal freight{ get;set; } 
        public virtual decimal m_charges_t{ get;set; } 
        public virtual decimal sales_tax_t{ get;set; } 
        public virtual decimal local_freight_amt{ get;set; } 
        public virtual decimal local_freight_amt_t{ get;set; } 
        public virtual decimal act_insurance{ get;set; } 
        public virtual decimal insurance_amt{ get;set; } 
        public virtual decimal insurance_amt_t{ get;set; } 
        public virtual decimal loc_frt_alloc_percent{ get;set; } 
        public virtual decimal est_local_freight{ get;set; } 
        public virtual decimal act_local_freight{ get;set; } 
        public virtual decimal est_brokerage{ get;set; } 
        public virtual decimal act_brokerage{ get;set; } 
        public virtual decimal est_duty{ get;set; } 
        public virtual decimal act_duty{ get;set; } 
        public virtual decimal ins_alloc_percent{ get;set; } 
        public virtual decimal est_insurance{ get;set; } 
        public virtual decimal exch_rate{ get;set; } 
        public virtual decimal frt_alloc_percent{ get;set; } 
        public virtual decimal duty_alloc_percent{ get;set; } 
        public virtual decimal brk_alloc_percent{ get;set; } 
        public virtual decimal est_freight{ get;set; } 
        public virtual decimal act_freight{ get;set; } 
        public virtual decimal duty_amt_t{ get;set; } 
        public virtual decimal duty_amt{ get;set; } 
        public virtual decimal brokerage_amt{ get;set; } 
        public virtual decimal brokerage_amt_t{ get;set; } 
        public virtual decimal prepaid_amt{ get;set; } 
        public virtual decimal prepaid_t{ get;set; } 
        public virtual decimal freight_t{ get;set; } 
        public virtual decimal sales_tax_2{ get;set; } 
        public virtual decimal sales_tax_t2{ get;set; } 
        public virtual decimal decifld1{ get;set; } 
        public virtual decimal decifld2{ get;set; } 
        public virtual decimal decifld3{ get;set; } 
        public virtual string po_num{ get;set; } 
        public virtual string vend_num{ get;set; } 
        public virtual string ship_code{ get;set; } 
        public virtual string terms_code{ get;set; } 
        public virtual string fob{ get;set; } 
        public virtual string vend_order{ get;set; } 
        public virtual string trans_nat_2{ get;set; } 
        public virtual string builder_po_orig_site{ get;set; } 
        public virtual string builder_po_num{ get;set; } 
        public virtual string vend_lcr_num{ get;set; } 
        public virtual string buyer{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string ins_vend_num{ get;set; } 
        public virtual string loc_frt_vend_num{ get;set; } 
        public virtual string frt_tax_code2{ get;set; } 
        public virtual string msc_tax_code1{ get;set; } 
        public virtual string msc_tax_code2{ get;set; } 
        public virtual string freight_vend_num{ get;set; } 
        public virtual string duty_vend_num{ get;set; } 
        public virtual string brokerage_vend_num{ get;set; } 
        public virtual string trans_nat{ get;set; } 
        public virtual string process_ind{ get;set; } 
        public virtual string delterm{ get;set; } 
        public virtual string tax_code1{ get;set; } 
        public virtual string tax_code2{ get;set; } 
        public virtual string frt_tax_code1{ get;set; } 
        public virtual string inv_num{ get;set; } 
        public virtual string drop_ship_no{ get;set; } 
        public virtual string whse{ get;set; } 
        public virtual string charfld1{ get;set; } 
        public virtual string charfld2{ get;set; } 
        public virtual string charfld3{ get;set; } 
        public virtual string stat{ get;set; } 
        public virtual string type{ get;set; } 
        public virtual string ship_addr{ get;set; } 
        public virtual string duty_alloc_meth{ get;set; } 
        public virtual string frt_alloc_meth{ get;set; } 
        public virtual string brk_alloc_meth{ get;set; } 
        public virtual string loc_frt_alloc_meth{ get;set; } 
        public virtual string supply_web_po_stat{ get;set; } 
        public virtual string duty_alloc_type{ get;set; } 
        public virtual string frt_alloc_type{ get;set; } 
        public virtual string brk_alloc_type{ get;set; } 
        public virtual string ins_alloc_type{ get;set; } 
        public virtual string ins_alloc_meth{ get;set; } 
        public virtual string loc_frt_alloc_type{ get;set; } 


    }
}