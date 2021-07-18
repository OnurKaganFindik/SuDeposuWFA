using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDeposuWFA
{
   public class SuTastiEventArgs:EventArgs
    {
        public decimal TasanMiktar { get; private set; }
        public SuTastiEventArgs(decimal tasanMiktar)
        {
            TasanMiktar = tasanMiktar;
        }

    }
}
