using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Category
{
    public class CategorySearchDto
    {
        public string content { get; set; }
        public int page_number { get; set; } = 1;
        public string account_id { get; set; }
    }
}
