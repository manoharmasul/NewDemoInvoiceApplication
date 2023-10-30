using System.ComponentModel.DataAnnotations;

namespace NewDemoInvoiceApplication.Model
{
    public class Item
    {
        //Item_code, Item_name, item_category, Item_unitprice, Item_discountInPer
        [Key]
        public int Item_code { get; set; }
        public string Item_name { get; set; }
        public string item_category { get; set; }
        public double Item_unitprice { get; set; }
        public double Item_discountInPer { get; set; }
    }
}
