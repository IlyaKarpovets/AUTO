using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2Auto.Models
{
  partial class Auto
    {
        public string MaskStateNumber {
            get
            {
                return $"{StateNumber[0]}**{StateNumber.Substring(3)}";
            }
        }
    }
}
