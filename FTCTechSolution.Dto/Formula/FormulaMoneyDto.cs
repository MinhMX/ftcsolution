using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Formula
{
    public class FormulaMoneyDto
    {
        public long id { get; set; }
        public long formula_header_id { get; set; }
        public string item_key { get; set; }
        public string item_value { get; set; }
        public string item_type { get; set; }
    }
}
