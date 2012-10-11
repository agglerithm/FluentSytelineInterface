using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class shiptoMap :  ClassMap<shipto>
            {
             
               public shiptoMap()
               {
                Table("shipto");    
                   Id(x => x.RowPointer);
                    Map(x => x.NoteExistsFlag);
                    Map(x => x.InWorkflow);
                    Map(x => x.drop_seq);
                    Map(x => x.RecordDate);
                    Map(x => x.CreateDate);
                    Map(x => x.drop_ship_no);
                    Map(x => x.name);
                    Map(x => x.city);
                    Map(x => x.state);
                    Map(x => x.zip);
                    Map(x => x.county);
                    Map(x => x.addr4);
                    Map(x => x.CreatedBy);
                    Map(x => x.UpdatedBy);
                    Map(x => x.country);
                    Map(x => x.contact);
                    Map(x => x.phone);
                    Map(x => x.addr1);
                    Map(x => x.addr2);
                    Map(x => x.addr3);

            }
          }
            
            }