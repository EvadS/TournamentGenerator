using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public partial class Player
    {
       public Player()
        {
            Pages = new HashSet<Page>();
            Phases = new HashSet<Phase>();
            Positions = new HashSet<Position>();
        }

        public int Id { get; set; }

        [Required]
        public string FName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        public int CategoryID { get; set; }

        public int Q { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime BirthDate { get; set; }

        public int СoachID { get; set; }

        public int ClubID { get; set; }

        public virtual Club Club { get; set; }

        public virtual Сoach Сoach { get; set; }

        public virtual ICollection<Page> Pages { get; set; }

         public virtual ICollection<Phase> Phases { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
    }
}
