using CsvMapper.Logic.Attributes;

namespace Chinook.Logic.Models.Persistence
{
    [DataClass(HasHeader = true, FileName = "CsvData/Track.csv")]
    internal class Track : Models.IdentityObject, Contracts.Persistence.ITrack
    {
        [DataPropertyInfo(OrderPosition = 2)]
        public int AlbumId { get; set; }
        [DataPropertyInfo(OrderPosition = 1)]
        public string Name { get; set; }
        [DataPropertyInfo(OrderPosition = 4)]
        public int GenreId { get; set; }
        [DataPropertyInfo(OrderPosition = 5)]
        public string Composer { get; set; }
        [DataPropertyInfo(OrderPosition = 6)]
        public long Time { get; set; }
        [DataPropertyInfo(OrderPosition = 8)]
        public double UnitPrice { get; set; }
    }
}
