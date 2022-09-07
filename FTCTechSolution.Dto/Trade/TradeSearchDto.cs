using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Trade
{
    public class TradeSearchDto
    {
        public string account_id { get; set; }
        public long formula_header_id { get; set; } = 0;
        public int pageActive { get; set; } = 1;
    }
}
