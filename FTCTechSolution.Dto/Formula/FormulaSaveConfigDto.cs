using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Formula
{
    public class FormulaSaveConfigDto
    {
        public long headerId { get; set; }
        public string account_id { get; set; }
        public List<FormulaConfigDto> lstConfig { get; set; }
        public List<FormulaMoneyDto> lstMoney { get; set; }
    }
}
