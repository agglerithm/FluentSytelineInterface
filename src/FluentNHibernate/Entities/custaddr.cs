using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class custaddr : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int credit_hold{ get;set; } 
        public virtual int corp_cred{ get;set; } 
        public virtual int corp_address{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int days_over_inv_due_date{ get;set; } 
        public virtual int cust_seq{ get;set; } 
        public virtual DateTime credit_hold_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal credit_limit{ get;set; } 
        public virtual decimal amt_over_inv_amt{ get;set; } 
        public virtual string cust_num{ get;set; } 
        public virtual string name{ get;set; } 
        public virtual string city{ get;set; } 
        public virtual string state{ get;set; } 
        public virtual string zip{ get;set; } 
        public virtual string county{ get;set; } 
        public virtual string bill_to_email{ get;set; } 
        public virtual string internet_url{ get;set; } 
        public virtual string internal_email_addr{ get;set; } 
        public virtual string external_email_addr{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string addr4{ get;set; } 
        public virtual string credit_hold_user{ get;set; } 
        public virtual string credit_hold_reason{ get;set; } 
        public virtual string curr_code{ get;set; } 
        public virtual string corp_cust{ get;set; } 
        public virtual string ship_to_email{ get;set; } 
        public virtual string country{ get;set; } 
        public virtual string fax_num{ get;set; } 
        public virtual string telex_num{ get;set; } 
        public virtual string addr1{ get;set; } 
        public virtual string addr2{ get;set; } 
        public virtual string addr3{ get;set; } 
        public virtual string bal_method{ get;set; } 


    }
}