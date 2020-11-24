
namespace Chinook.Report.Marketing.Models
{
    class TrackSalesStatistic : Contracts.Report.Marketing.ITrackSalesStatistic
    {
        public string HighestSaleTrackName { get; set; }

        public int HighestSaleNumber { get; set; }

        public double HighestSales { get; set; }

        public string LowestSaleTrackName { get; set; }

        public int LowestSaleNumber { get; set; }

        public double LowestSales { get; set; }

        public double AverageSales { get; set; }
    }
}
