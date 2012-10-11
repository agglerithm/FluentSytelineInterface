using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class jobtran : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int close_job{ get;set; } 
        public virtual int issue_parent{ get;set; } 
        public virtual int complete_op{ get;set; } 
        public virtual int posted{ get;set; } 
        public virtual int low_level{ get;set; } 
        public virtual int backflush{ get;set; } 
        public virtual int awaiting_eop{ get;set; } 
        public virtual int co_product_mix{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int suffix{ get;set; } 
        public virtual int oper_num{ get;set; } 
        public virtual int next_oper{ get;set; } 
        public virtual int start_time{ get;set; } 
        public virtual int end_time{ get;set; } 
        public virtual DateTime trans_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal trans_num{ get;set; } 
        public virtual decimal qty_complete{ get;set; } 
        public virtual decimal qty_scrapped{ get;set; } 
        public virtual decimal a_hrs{ get;set; } 
        public virtual decimal a_{ get;set; } 
        public virtual decimal qty_moved{ get;set; } 
        public virtual decimal pr_rate{ get;set; } 
        public virtual decimal job_rate{ get;set; } 
        public virtual decimal fixovhd{ get;set; } 
        public virtual decimal varovhd{ get;set; } 
        public virtual string job{ get;set; } 
        public virtual string emp_num{ get;set; } 
        public virtual string ind_code{ get;set; } 
        public virtual string whse{ get;set; } 
        public virtual string loc{ get;set; } 
        public virtual string user_code{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string import_doc_id{ get;set; } 
        public virtual string lot{ get;set; } 
        public virtual string shift{ get;set; } 
        public virtual string reason_code{ get;set; } 
        public virtual string ps_num{ get;set; } 
        public virtual string wc{ get;set; } 
        public virtual string cost_code{ get;set; } 
        public virtual string trans_type{ get;set; } 
        public virtual string pay_rate{ get;set; } 
        public virtual string trans_class{ get;set; } 


    }
}