using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Chinook.Report
{
	public class MarketingReports
	{
		public static IEnumerable<Contracts.Report.Marketing.IArtistStatistic> GetArtistStatistics()
		{
			var albums = Logic.Factory.GetAllAlbums();
			var artists = Logic.Factory.GetAllArtists();

			// Abfrage
			var qry = from artist in artists
					join album in albums on artist.Id equals album.ArtistId
					select new { album.Title, ArtistId = artist.Id, Name = artist.Name };

			var result = qry.GroupBy(e => e.ArtistId)
							.Select(e => new Report.Marketing.Models.ArtistStatistic
							{
								Name = artists.SingleOrDefault(e1 => e1.Id == e.Key)?.Name,
								AlbumCount = e.Count(),
							});

			return result;
		}
	}
}
