using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class shipto : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int drop_seq{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual string drop_ship_no{ get;set; } 
        public virtual string name{ get;set; } 
        public virtual string city{ get;set; } 
        public virtual string state{ get;set; } 
        public virtual string zip{ get;set; } 
        public virtual string county{ get;set; } 
        public virtual string addr4{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string country{ get;set; } 
        public virtual string contact{ get;set; } 
        public virtual string phone{ get;set; } 
        public virtual string addr1{ get;set; } 
        public virtual string addr2{ get;set; } 
        public virtual string addr3{ get;set; } 


    }
}