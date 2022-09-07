using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Formula
{
    public class FormulaSignalDto
    {
        public long id { get; set; }
        public Nullable<long> formula_header_id { get; set; }
        public string signal_type { get; set; }
        public string signal_name { get; set; }
        //public string signal_input { get; set; }
        //public long signal_right_id { get; set; } = 0;
        public string json_params { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string compare { get; set; }
        public int position { get; set; }
        public string description { get; set; }
        // public int page_number { get; set; } = 1;
    }
}
