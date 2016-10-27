using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baseball
{

    /// <summary>
    /// Base class for different filters on the Game list.
    /// </summary>
    public abstract class Filter
    {
        public static IEnumerable<Filter> FromCommand(Command cmd)
        {
            var filters = new List<Filter>();
            foreach (var pair in cmd.Args)
            {
                switch (pair.Key)
                {
                    case "dateFrom":
                        filters.Add(new DateFromFilter { Date = DateTime.Parse(pair.Value).Date });
                        break;
                    case "dateTo":
                        filters.Add(new DateToFilter { Date = DateTime.Parse(pair.Value).Date });
                        break;
                    case "homeTeam":
                        filters.Add(new HomeTeamFilter { Team = pair.Value });
                        break;
                    case "visitorTeam":
                        filters.Add(new AwayTeamFilter { Team = pair.Value });
                        break;
                }
            }
            return filters;
        }
    }

    /// <summary>
    /// Base class for Game.Date filters
    /// </summary>
    public abstract class DateFilter : Filter
    {
        public DateTime Date { get; set; }
    }


    /// <summary>
    /// Select all games after the specified date.
    /// </summary>
    public class DateFromFilter : DateFilter
    {
    }

    /// <summary>
    /// Select all games before the specified date.
    /// </summary>
    public class DateToFilter : DateFilter
    {
    }

    /// <summary>
    /// Base class for Game.[Home/Visiting]Team.
    /// </summary>
    public abstract class TeamFilter : Filter
    {
        public string Team { get; set; }
    }

    /// <summary>
    /// Select all games with the specified home Team
    /// </summary>
    public class HomeTeamFilter : TeamFilter
    {
    }

    /// <summary>
    /// Select all games with the specified away Team
    /// </summary>
    public class AwayTeamFilter : TeamFilter
    {
    }

}
