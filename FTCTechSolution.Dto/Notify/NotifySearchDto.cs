using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Notify
{
    public class NotifySearchDto
    {
        public long id { get; set; } = 0;
        public string account_id { get; set; }
        public int pageActive { get; set; } = 1;
        /// <summary>
        /// Nội dung tìm kiếm
        /// </summary>
        public string content { get; set; }
    }
}
