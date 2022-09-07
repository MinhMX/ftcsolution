using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Account
{
    public class AccountDto
    {
        public long Id { get; set; }
        public string AccountId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string OtherName { get; set; }
        public string BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public string ReferralCode { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string TokenDate { get; set; }
        public string CreateDate { get; set; }
        public string CreateUser { get; set; }
        public string Enable { get; set; }
        public string ApiName { get; set; }
        public string ApiType { get; set; }
        public string ApiCode { get; set; }
        public string ApiSecret { get; set; }
        public string ApiConnectSuccess { get; set; }
        public string ReferralId { get; set; }
        public string BrowserName { get; set; }
        public string Tele_receiver { get; set; }
    }
}
