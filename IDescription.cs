using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_AWzorek_167366
{
    internal interface IDescription
    {
        string description { get; set; }
        public string ShowDescription() {  return description; }
    }
}
