using System.ComponentModel.DataAnnotations;

namespace NewDemoInvoiceApplication.Model
{
    public class Invoice
    {
        //Invoice_no, Invoice_Datetime, Invoice_customername, Invoice_customermno, Invoice_paymentmode
        [Key]
        public int Invoice_no { get; set; }
        public DateTime Invoice_Datetime { get; set; }
        public string Invoice_customername { get; set; }
        public string Invoice_customermno { get; set; }
        public string Invoice_paymentmode { get; set; }
    }
}
