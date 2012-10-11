using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class coitem_log : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual  int co_line{ get;set; } 
        public virtual int co_release{ get;set; } 
        public virtual DateTime activity_date{ get;set; } 
        public virtual DateTime due_date{ get;set; } 
        public virtual DateTime projected_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal activity_seq{ get;set; } 
        public virtual decimal qty_chg{ get;set; } 
        public virtual decimal price_chg{ get;set; } 
        public virtual decimal disc_chg{ get;set; } 
        public virtual decimal co_disc_chg{ get;set; } 
        public virtual decimal trans_disc{ get;set; } 
        public virtual decimal trans_amt{ get;set; } 
        public virtual decimal price_chg_conv{ get;set; } 
        public virtual decimal qty_chg_conv{ get;set; } 
        public virtual string co_num{ get;set; } 
        public virtual string item{ get;set; } 
        public virtual string u_m{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 


    }
}