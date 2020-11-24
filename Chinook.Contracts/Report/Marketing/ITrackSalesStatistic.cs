
namespace Chinook.Contracts.Report.Marketing
{
    public interface ITrackSalesStatistic
    {
        string HighestSaleTrackName { get; }
        int HighestSaleNumber { get; }
        double HighestSales { get; }
        string LowestSaleTrackName { get; }
        int LowestSaleNumber { get; }
        double LowestSales { get; }
        double AverageSales { get; }
    }
}
