
namespace Chinook.Report.Marketing.Models
{
    class TrackStatistic : Contracts.Report.Marketing.ITrackStatistic
    {
        public string MinName { get; set; }

        public long MinTime { get; set; }
        public string MaxName { get; set; }

        public long MaxTime { get; set; }
        public long AverageTime { get; set; }
    }
}
