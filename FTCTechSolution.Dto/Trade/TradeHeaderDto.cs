using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Trade
{
    public class TradeHeaderDto
    {
        public long id { get; set; }
        public string account_id { get; set; }
        public Nullable<long> formula_header_id { get; set; }
        public Nullable<System.DateTime> run_time_start { get; set; }
        public Nullable<System.DateTime> run_time_end { get; set; }
        public string backtest_from { get; set; }
        public string backtest_to { get; set; }
        public string exchange { get; set; }
        public Nullable<double> balance_start { get; set; }
        public Nullable<double> balance_end { get; set; }
        public Nullable<long> signal_total { get; set; }
        public Nullable<long> signal_win { get; set; }
        public Nullable<long> signal_lost { get; set; }
        public Nullable<long> signal_win_continuous { get; set; }
        public Nullable<long> signal_lost_continuous { get; set; }
        public string run_status { get; set; }
        public string run_server_status { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public int page_number { get; set; } = 1;
    }
}
