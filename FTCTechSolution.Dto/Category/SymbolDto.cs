using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Category
{
    public class SymbolDto
    {
        public string exchange { get; set; }
        public string code { get; set; }
        public string trade_type { get; set; }
        public string name { get; set; }
        public string platform { get; set; }
        public Nullable<long> market_cap { get; set; }
        public Nullable<long> market_rank { get; set; }
        public Nullable<long> supply_max { get; set; }
        public Nullable<long> supply_total { get; set; }
        public Nullable<long> supply_circulating { get; set; }
        public Nullable<double> price_ath { get; set; }
        public Nullable<double> price_atl { get; set; }
        public Nullable<double> percent_ath { get; set; }
        public Nullable<double> percent_atl { get; set; }
        public Nullable<Boolean> is_disable { get; set; }

    }
}
