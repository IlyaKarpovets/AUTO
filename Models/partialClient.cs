using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj2Auto.Models
{
    partial class Client
    {
        public string FullName
        {
            get
            {
                return $"{LastName}{FirstName}{MiddleName}";
            }
        }
    }
    
}
