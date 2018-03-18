using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class Page
    {
        public Page()
        {
            Players = new HashSet<Player>();
        }

        public int id { get; set; }

        public int PageNumber { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}