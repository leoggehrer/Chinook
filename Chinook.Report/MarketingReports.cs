using System.Linq;
using System.Collections.Generic;

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
							.Select(e => new Marketing.Models.ArtistStatistic
							{
								Name = artists.SingleOrDefault(e1 => e1.Id == e.Key)?.Name,
								AlbumCount = e.Count(),
							});

			return result;
		}
		public static Contracts.Report.Marketing.IAlbumStatistic GetAlbumStatistic()
		{
			var albums = Logic.Factory.GetAllAlbums();
			var tracks = Logic.Factory.GetAllTracks();
			var qyr = tracks.GroupBy(s => s.AlbumId)
							.Select(e => new { e.Key, Time = e.Sum(x => x.Time)})
							.OrderBy(e => e.Time);
		
			var result = new Marketing.Models.AlbumStatistic
			{
				MinTitle = albums.FirstOrDefault(i => i.Id == qyr.FirstOrDefault().Key)?.Title,
				MinTime = qyr.FirstOrDefault().Time,
				MaxTitle = albums.FirstOrDefault(i => i.Id == qyr.LastOrDefault().Key)?.Title,
				MaxTime = qyr.LastOrDefault().Time,
				AverageTime = (long)qyr.Average(e => e.Time)
			};

			return result;
		}
		public static Contracts.Report.Marketing.ITrackStatistic GetTrackStatistic()
		{
			var tracks = Logic.Factory.GetAllTracks();
			var qyr = tracks.OrderBy(e => e.Time);

			var result = new Marketing.Models.TrackStatistic
			{
				MinName = tracks.FirstOrDefault(i => i.Id == qyr.FirstOrDefault().Id)?.Name,
				MinTime = qyr.FirstOrDefault().Time,
				MaxName = tracks.FirstOrDefault(i => i.Id == qyr.LastOrDefault().Id)?.Name,
				MaxTime = qyr.LastOrDefault().Time,
				AverageTime = (long)qyr.Average(e => e.Time)
			};
			return result;
		}
		public static Contracts.Report.Marketing.ITrackSalesStatistic GetTrackSalesStatistic()
		{
			var tracks = Logic.Factory.GetAllTracks();
			var invoiceLines = Logic.Factory.GetAllInvoiceLines();
			var qyr = invoiceLines.GroupBy(s => s.TrackId)
								  .Select(e => new { e.Key, Sales = e.Sum(x => x.Quantity * x.UnitPrice), Number = e.Sum(e => e.Quantity) })
								  .OrderBy(e => e.Sales);

			var result = new Marketing.Models.TrackSalesStatistic
			{
				LowestSaleTrackName = tracks.FirstOrDefault(i => i.Id == qyr.FirstOrDefault().Key)?.Name,
				LowestSaleNumber = qyr.FirstOrDefault().Number,
				LowestSales = qyr.FirstOrDefault().Sales,
				HighestSaleTrackName = tracks.FirstOrDefault(i => i.Id == qyr.LastOrDefault().Key)?.Name,
				HighestSaleNumber = qyr.LastOrDefault().Number,
				HighestSales = qyr.LastOrDefault().Sales,
				AverageSales = qyr.Average(e => e.Sales),
			};
			return result;
		}
		public static IEnumerable<Contracts.Report.Marketing.IGenreStatistic> GetGenreStatistics()
		{
			var genres = Logic.Factory.GetAllGenres();
			var tracks = Logic.Factory.GetAllTracks();
			var qyr = tracks.GroupBy(s => s.GenreId)
							.Select(e => new Marketing.Models.GenreStatistic()
							{
								Name = genres.SingleOrDefault(i => i.Id == e.Key).Name,
								Number = e.Count(),
							})
							.OrderByDescending(e => e.Number);

			return qyr;
		}
	}
}
