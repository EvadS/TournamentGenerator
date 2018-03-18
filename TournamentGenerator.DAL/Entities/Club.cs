using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class Club
    {
        public Club()
        {
            Players = new HashSet<Player>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

       public virtual ICollection<Player> Players { get; set; }
    }
}
