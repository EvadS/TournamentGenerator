using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournametGenerator.ViewModels.Competitor;
using ViewModels;

namespace TournametGenerator.ViewModels.Pages
{
   public  class PageNetList
    {
        public Category Category { get; set; }

        public List<SortableCompetitor> CompetitorsList { get; set; }

    }
}
