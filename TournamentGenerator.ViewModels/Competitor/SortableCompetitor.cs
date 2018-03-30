using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournametGenerator.ViewModels.Competitor
{
    /// <summary>
    /// учасник из списка ля групировки 
    /// </summary>
   public  class SortableCompetitor
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Weight { get; set; }
        public string Club { get; set; }
        public int Sex { get; set; }
        public int Q { get; set; }
        public string Coach { get; set; }
    }
}
