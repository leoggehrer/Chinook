using System;

namespace Chinook.Report.Marketing.Models
{
    class AlbumStatistic : Contracts.Report.Marketing.IAlbumStatistic
    {
        public string MinTitle { get; set; }

        public long MinTime { get; set; }
        public string MaxTitle { get; set; }

        public long MaxTime { get; set; }
        public long AverageTime { get; set; }
    }
}
