using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{

    /// <summary>
    ///  строка с екселя 
    /// </summary>
    public class ImportedCompetitor
    {
        public string FullName { get; set; }
        public string BirthDate { get; set; }
        public string Weigth { get; set; }
        public string Club { get; set; }
        public string Sex { set; get; }
        public string Degree { get; set; }
        public string Coach { get; set; }
    }
}
