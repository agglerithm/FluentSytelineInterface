using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class itemcust : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int due_period{ get;set; } 
        public virtual int purch_ytd{ get;set; } 
        public virtual int cust_item_seq{ get;set; } 
        public virtual int rank{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal order_ytd{ get;set; } 
        public virtual decimal ship_ytd{ get;set; } 
        public virtual decimal order_ptd{ get;set; } 
        public virtual string item{ get;set; } 
        public virtual string cust_num{ get;set; } 
        public virtual string cust_item{ get;set; } 
        public virtual string u_m{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string end_user{ get;set; } 


    }
}