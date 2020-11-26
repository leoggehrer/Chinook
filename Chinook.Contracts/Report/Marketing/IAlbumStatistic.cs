
namespace Chinook.Contracts.Report.Marketing
{
    /// <summary>
    /// Album-Statistik
    /// </summary>
    public interface IAlbumStatistic
    {
        string MinTitle { get; }
        long MinTime { get; }
        string MaxTitle { get; }
        long MaxTime { get; }
        long AverageTime { get; }
    }
}
