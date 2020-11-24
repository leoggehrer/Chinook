using System;
using System.Collections.Generic;
using System.Linq;

namespace Chinook.ConApp
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("************************************************");
			Console.WriteLine("*              Chinook-Marketing!              *");
			Console.WriteLine("*              Prof.Gehrer                     *");
			Console.WriteLine("************************************************");

			var artistStatistics = Report.MarketingReports.GetArtistStatistics();
			var trackStatistc = Report.MarketingReports.GetTrackStatistic();
			var albumStatistc = Report.MarketingReports.GetAlbumStatistic();
			var trackSalesStatistc = Report.MarketingReports.GetTrackSalesStatistic();
			var genreStatistics = Report.MarketingReports.GetGenreStatistics();

			PrintTrackStatistic(trackStatistc);
            Console.WriteLine();
			PrintAlbumStatistic(albumStatistc);
			Console.WriteLine();
			PrintTrackSalesStatistic(trackSalesStatistc);
			Console.WriteLine();
			PrintGenreStatistic(genreStatistics);
		}

		static void PrintAlbumStatistic(Contracts.Report.Marketing.IAlbumStatistic albumStatistic)
        {
            Console.WriteLine("Album Statistic:");
			Console.WriteLine($"{"Album title",-50}{"Time", 10} s");
			Console.WriteLine($"{albumStatistic.MaxTitle, -50}{albumStatistic.MaxTime/1000, 10} s");
			Console.WriteLine($"{albumStatistic.MinTitle,-50}{albumStatistic.MinTime/1000, 10} s");
			Console.WriteLine($"{"Average time:",-50}{albumStatistic.AverageTime/1000, 10} s");
		}
		static void PrintTrackStatistic(Contracts.Report.Marketing.ITrackStatistic trackStatistic)
		{
			Console.WriteLine("Track Statistic:");
			Console.WriteLine($"{"Track name",-50}{"Time",10} s");
			Console.WriteLine($"{trackStatistic.MaxName,-50}{trackStatistic.MaxTime / 1000,10} s");
			Console.WriteLine($"{trackStatistic.MinName,-50}{trackStatistic.MinTime / 1000,10} s");
			Console.WriteLine($"{"Average time:",-50}{trackStatistic.AverageTime / 1000,10} s");
		}
		static void PrintTrackSalesStatistic(Contracts.Report.Marketing.ITrackSalesStatistic trackSalesStatistic)
		{
			Console.WriteLine("Track Sales Statistic:");
			Console.WriteLine($"{"Track name",-50}{"Quantity",10}");
			Console.WriteLine($"{trackSalesStatistic.HighestSaleTrackName,-50}{trackSalesStatistic.HighestSaleNumber, 10}");
			Console.WriteLine($"{trackSalesStatistic.LowestSaleTrackName,-50}{trackSalesStatistic.LowestSaleNumber, 10}");
			Console.WriteLine($"{trackSalesStatistic.HighestSaleTrackName,-50}{trackSalesStatistic.HighestSales, 10}");
			Console.WriteLine($"{trackSalesStatistic.LowestSaleTrackName,-50}{trackSalesStatistic.LowestSales, 10}");
			Console.WriteLine($"{"Average sales:",-50}{trackSalesStatistic.AverageSales, 10}");
		}
		static void PrintGenreStatistic(IEnumerable<Contracts.Report.Marketing.IGenreStatistic> genreStatistics)
		{
			Console.WriteLine("Genre Statistic:");
			Console.WriteLine($"{"Genre name",-50}{"Quantity",10}");
            foreach (var genreStatistic in genreStatistics)
            {
				Console.WriteLine($"{genreStatistic.Name,-50}{genreStatistic.Number,10}");
			}
			Console.WriteLine($"{"Average:",-50}{genreStatistics.Average(e => e.Number), 10}");
		}
	}
}
