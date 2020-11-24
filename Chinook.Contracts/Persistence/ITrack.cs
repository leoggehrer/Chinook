
namespace Chinook.Contracts.Persistence
{
    public interface ITrack : IIdentifiable
    {
        int AlbumId { get; set; }
        int GenreId { get; set; }
        string Name { get; set; }
        string Composer { get; set; }
        long Time { get; set; }
        double UnitPrice { get; set; }
    }
}
