using System;
using FluentNHibernate.Data;

namespace FluentNHibernateClasses.Entities
{
    public class do_hdr : Entity
    {
        public virtual Guid RowPointer{ get;set; } 
        public virtual int bol_printed{ get;set; } 
        public virtual int pack_slip_printed{ get;set; } 
        public virtual int proforma_printed{ get;set; } 
        public virtual int invoice_printed{ get;set; } 
        public virtual int asn_extracted{ get;set; } 
        public virtual int shipped{ get;set; } 
        public virtual int asn_printed{ get;set; } 
        public virtual int NoteExistsFlag{ get;set; } 
        public virtual int InWorkflow{ get;set; } 
        public virtual int qty_packages{ get;set; } 
        public virtual int cust_seq{ get;set; } 
        public virtual DateTime do_hdr_date{ get;set; } 
        public virtual DateTime pickup_date{ get;set; } 
        public virtual DateTime shipped_date{ get;set; } 
        public virtual DateTime RecordDate{ get;set; } 
        public virtual DateTime CreateDate{ get;set; } 
        public virtual decimal do_value{ get;set; } 
        public virtual decimal weight{ get;set; } 
        public virtual decimal cod_amt{ get;set; } 
        public virtual decimal col_fee{ get;set; } 
        public virtual decimal col_misc_charges{ get;set; } 
        public virtual decimal col_freight_charges{ get;set; } 
        public virtual decimal ppd_fee{ get;set; } 
        public virtual decimal ppd_misc_charges{ get;set; } 
        public virtual decimal ppd_freight_charges{ get;set; } 
        public virtual string do_num{ get;set; } 
        public virtual string cust_num{ get;set; } 
        public virtual string carrier{ get;set; } 
        public virtual string carrier_contact{ get;set; } 
        public virtual string carrier_num{ get;set; } 
        public virtual string veh_num{ get;set; } 
        public virtual string UpdatedBy{ get;set; } 
        public virtual string special_inst1{ get;set; } 
        public virtual string special_inst2{ get;set; } 
        public virtual string consignee_country{ get;set; } 
        public virtual string consignor_contact_id{ get;set; } 
        public virtual string consignor_contact{ get;set; } 
        public virtual string CreatedBy{ get;set; } 
        public virtual string invoicee_zip{ get;set; } 
        public virtual string invoicee_county{ get;set; } 
        public virtual string invoicee_country{ get;set; } 
        public virtual string invoicee_contact{ get;set; } 
        public virtual string invoicee_phone{ get;set; } 
        public virtual string invoicee_fax{ get;set; } 
        public virtual string invoicee_addr1{ get;set; } 
        public virtual string invoicee_addr2{ get;set; } 
        public virtual string invoicee_addr3{ get;set; } 
        public virtual string invoicee_addr4{ get;set; } 
        public virtual string invoicee_city{ get;set; } 
        public virtual string invoicee_state{ get;set; } 
        public virtual string consignor_zip{ get;set; } 
        public virtual string consignor_county{ get;set; } 
        public virtual string consignor_country{ get;set; } 
        public virtual string consignor_phone{ get;set; } 
        public virtual string consignor_fax{ get;set; } 
        public virtual string invoicee_name{ get;set; } 
        public virtual string consignor_addr1{ get;set; } 
        public virtual string consignor_addr2{ get;set; } 
        public virtual string consignor_addr3{ get;set; } 
        public virtual string consignor_addr4{ get;set; } 
        public virtual string consignor_city{ get;set; } 
        public virtual string consignor_state{ get;set; } 
        public virtual string consignee_county{ get;set; } 
        public virtual string consignee_contact{ get;set; } 
        public virtual string consignee_phone{ get;set; } 
        public virtual string consignee_fax{ get;set; } 
        public virtual string consignor_name{ get;set; } 
        public virtual string consignor_whse{ get;set; } 
        public virtual string consignee_addr2{ get;set; } 
        public virtual string consignee_addr3{ get;set; } 
        public virtual string consignee_addr4{ get;set; } 
        public virtual string consignee_city{ get;set; } 
        public virtual string consignee_state{ get;set; } 
        public virtual string consignee_zip{ get;set; } 
        public virtual string pro_number{ get;set; } 
        public virtual string container{ get;set; } 
        public virtual string route{ get;set; } 
        public virtual string weight_u_m{ get;set; } 
        public virtual string consignee_name{ get;set; } 
        public virtual string consignee_addr1{ get;set; } 
        public virtual string stat{ get;set; } 
        public virtual string do_invoice{ get;set; } 
        public virtual string inv_freq{ get;set; } 


    }
}