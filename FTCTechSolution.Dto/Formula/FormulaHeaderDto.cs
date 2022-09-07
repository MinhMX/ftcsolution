using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Formula
{
    public class FormulaHeaderDto
    {
        public long id { get; set; }
        public string account_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public Nullable<bool> is_trade { get; set; }
        public Nullable<bool> is_public { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public int page_number { get; set; } = 1;
    }
}
