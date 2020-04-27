using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebL_1.Models
{
    [BindProperties(SupportsGet = true)]
    public class BindedCalcUnit : CalcUnit
    {
        public int type { get; set; }
        public int Action()
        {
            return Action(type);
        }
    }
}
