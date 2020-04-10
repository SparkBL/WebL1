using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebL_1.Models
{
    public class CalcUnitManager : ICalcUnitManager
    {
       
        public ICalcUnit cur { get; set; }
        public ICalcUnit Rebase () {  cur = new CalcUnit(); return cur ; }
    }
}
