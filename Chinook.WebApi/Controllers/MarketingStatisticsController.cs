using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chinook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketingStatisticsController : ControllerBase
    {
        [HttpGet("/api/[controller]/TrackStatistic")]
        public Contracts.Report.Marketing.ITrackStatistic GetTrackStatistic()
        {
            return Report.MarketingReports.GetTrackStatistic();
        }

        [HttpGet("/api/[controller]/GenreStatistics")]
        public IEnumerable<Contracts.Report.Marketing.IGenreStatistic> GetGenreStatitics()
        {
            return Report.MarketingReports.GetGenreStatistics();
        }
    }
}
