using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class Phase
    {
        public Phase()
        {
            Players = new HashSet<Player>();
        }

        public int Id { get; set; }

        public int? StatementNumber { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
