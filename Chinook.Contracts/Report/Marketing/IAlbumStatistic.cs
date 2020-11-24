
namespace Chinook.Contracts.Report.Marketing
{
    public interface IAlbumStatistic
    {
        string MinTitle { get; }
        long MinTime { get; }
        string MaxTitle { get; }
        long MaxTime { get; }
        long AverageTime { get; }
    }
}
