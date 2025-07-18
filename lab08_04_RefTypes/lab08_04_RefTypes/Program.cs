//Ex71

Invoice[] invoices = new Invoice[3];

invoices[0] = new Invoice();
invoices[0].Id = 1;
invoices[0].TotalPrice = 5000;
invoices[0].DateCreated = new DateTime(2015, 1, 31);

invoices[1] = new Invoice();
invoices[1].Id = 2;
invoices[1].TotalPrice = 20000;
invoices[1].DateCreated = new DateTime(2015, 2, 3);

InvoiceManager manager = new InvoiceManager();

invoices[2] = manager.MakeInvoice(3, 8000);

foreach (Invoice item in invoices)
{
    manager.PrintInvoice(item);
}

Console.WriteLine($"Invoice #0 DatePrinted: {invoices[0].DatePrinted}");

class Invoice
{
    public int Id;
    public decimal TotalPrice;
    public DateTime DateCreated;
    public DateTime DatePrinted;
}

class InvoiceManager
{
    public void PrintInvoice(Invoice invoice)
    {
        if (invoice == null)
        {
            Console.WriteLine("Invoice does not exist.");
            return;
        }
        Console.WriteLine("ID: {0}, TotalPrice: {1}, DateCreated: {2}", invoice.Id, invoice.TotalPrice, invoice.DateCreated);
        invoice.DatePrinted = DateTime.Now;
    }

    public Invoice MakeInvoice(int id, decimal totalPrice)
    {
        Invoice newInvoice = new Invoice();
        newInvoice.Id = id;
        newInvoice.TotalPrice = totalPrice;
        newInvoice.DateCreated = DateTime.Now;
        return newInvoice;

    }
}