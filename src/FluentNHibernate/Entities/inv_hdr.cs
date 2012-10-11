using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class inv_hdr : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int use_exch_rate{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int qty_packages{ get;set; } 
        public virtual int inv_seq{ get;set; } 
        public virtual int cust_seq{ get;set; } 
        public virtual DateTime inv_date{ get;set; } 
        public virtual DateTime ship_date{ get;set; } 
        public virtual DateTime tax_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal weight{ get;set; } 
        public virtual decimal misc_charges{ get;set; } 
        public virtual decimal prepaid_amt{ get;set; } 
        public virtual decimal freight{ get;set; } 
        public virtual decimal cost{ get;set; } 
        public virtual decimal price{ get;set; } 
        public virtual decimal mgr_comm_cal{ get;set; } 
        public virtual decimal mgr_comm_bse{ get;set; } 
        public virtual decimal exch_rate{ get;set; } 
        public virtual decimal disc{ get;set; } 
        public virtual decimal disc_amount{ get;set; } 
        public virtual decimal comm_calc{ get;set; } 
        public virtual decimal comm_due{ get;set; } 
        public virtual decimal comm_paid{ get;set; } 
        public virtual decimal comm_base{ get;set; } 
        public virtual decimal tot_comm_due{ get;set; } 
        public virtual decimal tot_comm_pd{ get;set; } 
        public virtual string inv_num{ get;set; } 
        public virtual string cust_num{ get;set; } 
        public virtual string co_num{ get;set; } 
        public virtual string terms_code{ get;set; } 
        public virtual string ship_code{ get;set; } 
        public virtual string cust_po{ get;set; } 
        public virtual string freight_acct_unit4{ get;set; } 
        public virtual string do_num{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string misc_acct_unit2{ get;set; } 
        public virtual string misc_acct_unit3{ get;set; } 
        public virtual string misc_acct_unit4{ get;set; } 
        public virtual string freight_acct_unit1{ get;set; } 
        public virtual string freight_acct_unit2{ get;set; } 
        public virtual string freight_acct_unit3{ get;set; } 
        public virtual string ec_code{ get;set; } 
        public virtual string frt_tax_code1{ get;set; } 
        public virtual string frt_tax_code2{ get;set; } 
        public virtual string msc_tax_code1{ get;set; } 
        public virtual string msc_tax_code2{ get;set; } 
        public virtual string misc_acct_unit1{ get;set; } 
        public virtual string slsman{ get;set; } 
        public virtual string state{ get;set; } 
        public virtual string misc_acct{ get;set; } 
        public virtual string freight_acct{ get;set; } 
        public virtual string tax_code1{ get;set; } 
        public virtual string tax_code2{ get;set; } 
        public virtual string bill_type{ get;set; } 


    }
}