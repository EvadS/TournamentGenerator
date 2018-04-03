using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
   public class Category
    {
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public int  Weight { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
