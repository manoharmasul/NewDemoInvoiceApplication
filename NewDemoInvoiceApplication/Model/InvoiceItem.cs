using System.ComponentModel.DataAnnotations;

namespace NewDemoInvoiceApplication.Model
{
    public class InvoiceItem
    {
        //Invoice_no, Item_code, Item_qty, Item_unitprice,
        //Item_discount, Item_amount, Item_amountpaid
        [Key]
        public int Id { get; set; }
        public int Invoice_no { get; set; }
        public int Item_code { get; set; }
        public int Item_qty { get; set; }
        public double Item_unitprice { get; set; }
        public double Item_discount { get; set; }
        public double Item_amount { get; set; }
        public double Item_amountpaid { get; set; }
    }
}
