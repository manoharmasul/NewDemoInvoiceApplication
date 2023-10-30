using Microsoft.EntityFrameworkCore;
using NewDemoInvoiceApplication.Context;
using NewDemoInvoiceApplication.Model;
using NewDemoInvoiceApplication.Repository.Interface;

namespace NewDemoInvoiceApplication.Repository
{
    public class InvoiceItemAsyncRepository:IInvoiceAsycRepositoryAsync
    {
        private readonly MyContext context;
        public InvoiceItemAsyncRepository(MyContext context)
        {
            this.context = context;
        }

        public async Task<int> AddInvoiceData(InvoiceItem item)
        {
            var query = context.AddAsync(item);
            var result = await context.SaveChangesAsync();
            return result;
        }

        public async Task<int> DeleteInvoiceData(int Invoice_no)
        {
            var item = await context.InvoiceItem.FindAsync(Invoice_no);
            var result = context.Remove(item);
            var ret = await context.SaveChangesAsync();
            return ret;
        }

        public async Task<List<InvoiceItem>> GetInvoiceData()
        {
        
            var query = from item in context.InvoiceItem select item;
            var invoiceitem = await query.ToListAsync();


            return invoiceitem;
        }

        public async Task<InvoiceItem> GetInvoiceDataById(int Invoice_no)
        {
            var item = await context.InvoiceItem.FindAsync(Invoice_no);
            return item;
        }

        public async Task<int> UpdateInvoiceData(InvoiceItem item)
        {
            var finditem = await context.InvoiceItem.FindAsync(item.Invoice_no);
            var query = context.InvoiceItem.Update(finditem);
            var result = await context.SaveChangesAsync();
            return result;
        }
    
    }
}
