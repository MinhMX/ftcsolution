using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Formula
{
    public class FormulaJsonParamDto
    {
        public object left { get; set; }
        public object right { get; set; }
        public string compare { get; set; } = "";
        public int position { get; set; } = 0;
    }
}
