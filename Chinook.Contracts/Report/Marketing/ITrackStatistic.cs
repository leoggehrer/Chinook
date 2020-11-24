
namespace Chinook.Contracts.Report.Marketing
{
    public interface ITrackStatistic
    {
        string MinName { get; }
        long MinTime { get; }
        string MaxName { get; }
        long MaxTime { get; }
        long AverageTime { get; }
    }
}
