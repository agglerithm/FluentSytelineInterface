using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class slsman : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int outside{ get;set; } 
        public virtual int logifld{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime datefld{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal sales_ptd{ get;set; } 
        public virtual decimal sales_ytd{ get;set; } 
        public virtual decimal decifld1{ get;set; } 
        public virtual decimal decifld2{ get;set; } 
        public virtual decimal decifld3{ get;set; } 
        public virtual string slsmanID{ get;set; } 
        public virtual string slsclass{ get;set; } 
        public virtual string ref_num{ get;set; } 
        public virtual string code{ get;set; } 
        public virtual string slsmangr{ get;set; } 
        public virtual string charfld1{ get;set; } 
        public virtual string charfld2{ get;set; } 
        public virtual string charfld3{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 


    }
}