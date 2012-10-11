using System;
using FluentNHibernate.Data;
using FluentNHibernate.Mapping;

                namespace FluentNHibernateClasses.Mappings
                {
                  public class location : Entity
            {
                       public virtual Guid RowPointer{ get;set; } 
          public virtual int mrb_flag{ get;set; } 
          public virtual int NoteExistsFlag{ get;set; } 
          public virtual int InWorkflow{ get;set; } 
          public virtual DateTime RecordDate{ get;set; } 
          public virtual DateTime CreateDate{ get;set; } 
          public virtual string loc{ get;set; } 
          public virtual string description{ get;set; } 
          public virtual string wc{ get;set; } 
          public virtual string CreatedBy{ get;set; } 
          public virtual string UpdatedBy{ get;set; } 
          public virtual string uf_pick_zone{ get;set; } 
          public virtual string uf_loc_type{ get;set; } 
          public virtual string loc_type{ get;set; } 


            }
            public class locationMap :  ClassMap<location>
            {
             
               public locationMap()
               {
                Table("location");    Id(x => x.RowPointer);
    Map(x => x.mrb_flag);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.loc);
    Map(x => x.description);
    Map(x => x.wc);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.uf_pick_zone);
    Map(x => x.uf_loc_type);
    Map(x => x.loc_type);

            }
          }
            
            }