using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.BackTest
{
    public class BackTestSearchDto
    {
        public string account_id { get; set; }
        public long header_id { get; set; }

        public long id { get; set; }
        public string symbol { get; set; }
        public string content { get; set; }     
        public int page_number { get; set; } = 1;      
       
    }
}
