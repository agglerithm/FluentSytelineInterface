using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class do_line : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int hazard{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int qty_packages{ get;set; } 
        public virtual int do_lineID{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal weight{ get;set; } 
        public virtual string do_num{ get;set; } 
        public virtual string package_type{ get;set; } 
        public virtual string nmfc{ get;set; } 
        public virtual string rate_code{ get;set; } 
        public virtual string description{ get;set; } 
        public virtual string marks_except{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 


    }
}