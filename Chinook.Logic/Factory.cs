﻿using System.Collections.Generic;

namespace Chinook.Logic
{
	public class Factory
	{
		public static IEnumerable<Contracts.Persistence.IGenre> GetAllGenres()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Genre>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IArtist> GetAllArtists()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Artist>();

			return result;
		}
		public static IEnumerable<Contracts.Persistence.IAlbum> GetAllAlbums()
		{
			var result = CsvMapper.Logic.CsvHelper.Read<Models.Persistence.Album>();

			return result;
		}
	}
}
