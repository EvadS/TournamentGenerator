using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
   public class Category
    {
        public int WeightFrom { get; set; }
        public int WeightTo { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
