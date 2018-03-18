using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class CompetitorsPage
    {
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public Category Category { get; set; }
        public List<Competitor> CompetitorPage { get; set; }
    }
}
