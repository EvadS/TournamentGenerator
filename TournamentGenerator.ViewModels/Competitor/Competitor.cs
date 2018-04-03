using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Enum;

namespace ViewModels
{
    /// <summary>
    /// учасник отображаемый на странице 
    /// </summary>
    public class Competitor
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
        public int Q { get; set; }
        public Sex Sex { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
