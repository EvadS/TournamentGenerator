using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class Category
    {
        public Category()
        {
            Players = new HashSet<Player>();
        }

        public int id { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public int Weight { get; set; }

        public int Sex { get; set; }

        public int IsBoundary { get; set; }

        public virtual ICollection<Player> Players { get; set; }

     }
}
