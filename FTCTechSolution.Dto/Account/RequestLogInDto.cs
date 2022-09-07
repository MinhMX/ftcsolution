using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Account
{
    public class RequestLogInDto
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RememberMe { get; set; }
        public string Browser { get; set; }
    }
}
