using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.BackTest
{
    public class BackTestDetailDto
    {
        public long id { get; set; }
        public Nullable<long> backtest_header_id { get; set; }
        public string symbol { get; set; }
        public Nullable<System.DateTime> time_start { get; set; }
        public Nullable<System.DateTime> time_end { get; set; }
        public string signal_status { get; set; }
        public string signal_type { get; set; }
        public Nullable<double> price_entry { get; set; }
        public Nullable<double> price_sl { get; set; }
        public Nullable<double> price_tp { get; set; }
        public Nullable<double> volume { get; set; }
        public Nullable<double> price_close { get; set; }
        public Nullable<double> profit_percent { get; set; }
        public Nullable<bool> is_error { get; set; }
        public string error_text { get; set; }
    }
}
