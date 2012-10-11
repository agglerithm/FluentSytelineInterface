using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class aptrxdMap :  ClassMap<aptrxd>
            {
             
               public aptrxdMap()
               {
                Table("aptrxd");                         
                   Id(x => x.RowPointer);
                         Map(x => x.tax_system);
                         Map(x => x.NoteExistsFlag);
                         Map(x => x.InWorkflow);
                         Map(x => x.voucher);
                         Map(x => x.dist_seq);
                         Map(x => x.task_num);
                         Map(x => x.RecordDate);
                         Map(x => x.CreateDate);
                         Map(x => x.amount);
                         Map(x => x.tax_basis);
                         Map(x => x.vend_num);
                         Map(x => x.acct);
                         Map(x => x.inv_num);
                         Map(x => x.tax_code);
                         Map(x => x.tax_code_e);
                         Map(x => x.acct_unit1);
                         Map(x => x.UpdatedBy);
                         Map(x => x.acct_unit2);
                         Map(x => x.acct_unit3);
                         Map(x => x.acct_unit4);
                         Map(x => x.proj_num);
                         Map(x => x.cost_code);
                         Map(x => x.CreatedBy);

            }
          }
            
            }