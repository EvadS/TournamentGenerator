using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournametGenerator.ViewModels
{
    /// <summary>
    /// Статистика по турниру 
    /// </summary>
   public  class TournametStatistics
    {
        public int ActiveCompetitorNum { get; set; }      
        public int MoreTwoCompetitorNum { get; set; }
        public int NonActiveCompetitorNum { get; set; }
        public int OneCometitorOnCategoryNum { get; set; }
        public int CategoriesNum { get; set; }
        public bool IsBigQDifferent { get; set; }
        public int GetPagesNum { get; set; }
    }
}
