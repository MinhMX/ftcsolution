using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Account
{
   public  class ApiExchangeDto
    {
        public string ApiCode { set; get; }
        public string ApiSecret { set; get; }
        public int ApiType { set; get; } = 0;
    }
}
