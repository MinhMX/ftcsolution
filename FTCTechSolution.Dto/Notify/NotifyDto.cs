using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Notify
{
    public class NotifyDto
    {
        public long id { get; set; } = 0;
        public string account_id { get; set; }
        public string notify_type { get; set; }
        public Nullable<long> link_id { get; set; }
        public string link_url { get; set; }
        public string text { get; set; }
        public Nullable<DateTime> bot_date { get; set; }
        public Nullable<DateTime> read_date { get; set; }
        public Nullable<DateTime> create_date { get; set; }

    }
}
