using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class rcpts : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int start_time{ get;set; } 
        public virtual int end_time{ get;set; } 
        public virtual DateTime due_date{ get;set; } 
        public virtual DateTime start_date{ get;set; } 
        public virtual DateTime projected_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual DateTime due_date_day{ get;set; } 
        public virtual DateTime projected_date_day{ get;set; } 
        public virtual decimal rcpt_qty{ get;set; } 
        public virtual decimal orig_qty{ get;set; } 
        public virtual string rcpt_rqmt{ get;set; } 
        public virtual string item{ get;set; } 
        public virtual string ref_num{ get;set; } 
        public virtual string aps_ref{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 


    }
}