
namespace Chinook.Contracts.Persistence
{
    public interface IInvoiceLine : IIdentifiable
    {
        int InvoiceId { get; set; }
        int TrackId { get; set; }
        double UnitPrice { get; set; }
        int Quantity { get; set; }
    }
}
