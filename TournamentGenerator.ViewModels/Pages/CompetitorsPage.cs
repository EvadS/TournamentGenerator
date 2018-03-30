using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournametGenerator.ViewModels.Competitor;

namespace ViewModels
{
    public class CompetitorsPage
    {
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public Category Category { get; set; }
        List<SortableCompetitor> CompetitorsList { get; set; }
    }
}
