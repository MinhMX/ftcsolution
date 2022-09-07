using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Category
{
    public class IndicatorDto
    {
        public long id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string json_params { get; set; }
        public string output { get; set; }
        public Nullable<bool> is_disable { get; set; }
        public int page_number { get; set; } = 1;
    }
}
