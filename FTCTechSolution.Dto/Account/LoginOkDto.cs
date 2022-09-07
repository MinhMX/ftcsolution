using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Account
{
    public class LoginOkDto
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string AccountId { get; set; }
        public LoginOkDto()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t">Token</param>
        /// <param name="rt">Refresh Token</param>
        public LoginOkDto(string t, string rt)
        {
            Token = t;
            RefreshToken = rt;
        }
    }
}
