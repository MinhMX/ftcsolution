using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Account
{
    public class RefreshTokenDto
    {
        /// <summary>
        /// Email của account đăng nhập
        /// </summary>
        public string Email { set; get; }
        /// <summary>
        /// Username của account đăng nhập
        /// </summary>
        public string Username { set; get; }
        /// <summary>
        /// Giá trị này được lưu trong DB để kiểm tra
        /// </summary>
        public string RefreshGuid { set; get; }
        /// <summary>
        /// Thời gian RefreshTokenDto được tạo
        /// Kiểm tra để sau 5 phút refresh token lại một lần
        /// </summary>
        public string CreateDateTime { set; get; }
        public RefreshTokenDto() { }
        public RefreshTokenDto(string email, string username, string refreshId, string createDate)
        {
            Email = email;
            Username = username;
            RefreshGuid = refreshId;
            CreateDateTime = createDate;
        }

    }
}
