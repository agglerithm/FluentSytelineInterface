using FluentNHibernate.Mapping;
using FluentNHibernateClasses.Entities;

namespace FluentNHibernateClasses.Mappings
                {
                    public class jobtranMap :  ClassMap<jobtran>
            {
             
               public jobtranMap()
               {
                Table("jobtran");    Id(x => x.RowPointer);
    Map(x => x.close_job);
    Map(x => x.issue_parent);
    Map(x => x.complete_op);
    Map(x => x.posted);
    Map(x => x.low_level);
    Map(x => x.backflush);
    Map(x => x.awaiting_eop);
    Map(x => x.co_product_mix);
    Map(x => x.NoteExistsFlag);
    Map(x => x.InWorkflow);
    Map(x => x.suffix);
    Map(x => x.oper_num);
    Map(x => x.next_oper);
    Map(x => x.start_time);
    Map(x => x.end_time);
    Map(x => x.trans_date);
    Map(x => x.RecordDate);
    Map(x => x.CreateDate);
    Map(x => x.trans_num);
    Map(x => x.qty_complete);
    Map(x => x.qty_scrapped);
    Map(x => x.a_hrs);
    Map(x => x.a_).Column("a_$");
    Map(x => x.qty_moved);
    Map(x => x.pr_rate);
    Map(x => x.job_rate);
    Map(x => x.fixovhd);
    Map(x => x.varovhd);
    Map(x => x.job);
    Map(x => x.emp_num);
    Map(x => x.ind_code);
    Map(x => x.whse);
    Map(x => x.loc);
    Map(x => x.user_code);
    Map(x => x.CreatedBy);
    Map(x => x.UpdatedBy);
    Map(x => x.import_doc_id);
    Map(x => x.lot);
    Map(x => x.shift);
    Map(x => x.reason_code);
    Map(x => x.ps_num);
    Map(x => x.wc);
    Map(x => x.cost_code);
    Map(x => x.trans_type);
    Map(x => x.pay_rate);
    Map(x => x.trans_class);

            }
          }
            
            }