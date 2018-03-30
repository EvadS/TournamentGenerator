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

        public int Id { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public int PageNum { get; set; }
        public int PairItemId { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}