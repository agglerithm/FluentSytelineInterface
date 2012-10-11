using System;
using FluentNHibernate.Data;
using FluentNHibernate.Mapping;

                namespace FluentNHibernateClasses.Mappings
                {
                  public class po_rcpt : Entity
            {
                       public virtual Guid RowPointer{ get;set; } 
          public virtual int by_cons{ get;set; } 
          public virtual int NoteExistsFlag{ get;set; } 
          public virtual int InWorkflow{ get;set; } 
          public virtual int po_line{ get;set; } 
          public virtual int po_release{ get;set; } 
          public virtual int date_seq{ get;set; } 
          public virtual int grn_line{ get;set; } 
          public virtual DateTime rcvd_date{ get;set; } 
          public virtual DateTime RecordDate{ get;set; } 
          public virtual DateTime CreateDate{ get;set; } 
          public virtual decimal qty_received{ get;set; } 
          public virtual decimal qty_returned{ get;set; } 
          public virtual decimal qty_vouchered{ get;set; } 
          public virtual decimal item_cost{ get;set; } 
          public virtual decimal unit_weight{ get;set; } 
          public virtual decimal unit_mat_cost{ get;set; } 
          public virtual decimal unit_duty_cost{ get;set; } 
          public virtual decimal unit_freight_cost{ get;set; } 
          public virtual decimal unit_brokerage_cost{ get;set; } 
          public virtual decimal exch_rate{ get;set; } 
          public virtual decimal unit_insurance_cost{ get;set; } 
          public virtual decimal unit_loc_frt_cost{ get;set; } 
          public virtual string po_num{ get;set; } 
          public virtual string pack_num{ get;set; } 
          public virtual string grn_num{ get;set; } 
          public virtual string vend_num{ get;set; } 
          public virtual string CreatedBy{ get;set; } 
          public virtual string UpdatedBy{ get;set; } 
          public virtual string uf_lot{ get;set; } 


            }
            public class po_rcptMap :  ClassMap<po_rcpt>
            {
             
               public po_rcptMap()
               {
                Table("po_rcpt");    Id(x => x.RowPointer);
    Map(x => x.by_cons);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.po_line);
    Map(x => x.po_release);
    Map(x => x.date_seq);
    Map(x => x.grn_line);
    Map(x => x.rcvd_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.qty_received);
    Map(x => x.qty_returned);
    Map(x => x.qty_vouchered);
    Map(x => x.item_cost);
    Map(x => x.unit_weight);
    Map(x => x.unit_mat_cost);
    Map(x => x.unit_duty_cost);
    Map(x => x.unit_freight_cost);
    Map(x => x.unit_brokerage_cost);
    Map(x => x.exch_rate);
    Map(x => x.unit_insurance_cost);
    Map(x => x.unit_loc_frt_cost);
    Map(x => x.po_num);
    Map(x => x.pack_num);
    Map(x => x.grn_num);
    Map(x => x.vend_num);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.uf_lot);

            }
          }
            
            }