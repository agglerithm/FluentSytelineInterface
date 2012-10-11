using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class PJ_ShipmentData : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int ExtOrderDetailLineNumber{ get;set; } 
        public virtual int ExtOrderDetailReleaseNumber{ get;set; } 
        public virtual DateTime ShipDate{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal ShipQuantity{ get;set; } 
        public virtual decimal DeliveryOrderTotalWeight{ get;set; } 
        public virtual string ExtOrderSource{ get;set; } 
        public virtual string ExtOrderSourceRefNumber{ get;set; } 
        public virtual string DeliveryOrderControlNumber{ get;set; } 
        public virtual string Carrier{ get;set; } 
        public virtual string ClassOfService{ get;set; } 
        public virtual string PrimaryTracking{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string DeliveryOrderFreightTermsCode{ get;set; } 


    }
}