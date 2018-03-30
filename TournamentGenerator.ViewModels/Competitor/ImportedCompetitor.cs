using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournametGenerator.ViewModels.Competitor
{
    /// <summary>
    ///  импортируемый учасник из текстового файла 
    /// </summary>
    public class ImportedCompetitor
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string weight { get; set; }
        public string cloub { get; set; }

        public string sex { get; set; }
        public string Q { get; set; }
        public string Coach { get; set; }
    }
}
