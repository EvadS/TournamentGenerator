using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class Category
    {
        //public Category()
        //{
        //    Players = new HashSet<Player>();
        //}

        public int id { get; set; }

        public int WeightFrom { get; set; }

        public int WeightTo { get; set; }

        public int Age { get; set; }

        public int Sex { get; set; }

     //  public virtual ICollection<Player> Players { get; set; }
    }
}
