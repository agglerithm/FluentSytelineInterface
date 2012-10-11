using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class PJ_ShipmentDataMap :  ClassMap<PJ_ShipmentData>
            {
             
               public PJ_ShipmentDataMap()
               {
                Table("PJ_ShipmentData");    Id(x => x.RowPointer);
    Map(x => x.InWorkflow);
    Map(x => x.NoteExistsFlag);
    Map(x => x.ExtOrderDetailLineNumber);
    Map(x => x.ExtOrderDetailReleaseNumber);
    Map(x => x.ShipDate);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.ShipQuantity);
    Map(x => x.DeliveryOrderTotalWeight);
    Map(x => x.ExtOrderSource);
    Map(x => x.ExtOrderSourceRefNumber);
    Map(x => x.DeliveryOrderControlNumber);
    Map(x => x.Carrier);
    Map(x => x.ClassOfService);
    Map(x => x.PrimaryTracking);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.DeliveryOrderFreightTermsCode);

            }
          }
            
            }