using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Notify
{
    public class NotifyStatusDto
    {
        /// <summary>
        /// NULL: chưa chạy
        /// </summary>
        public static string Default = null;
        /// <summary>
        /// R: running-đang chạy
        /// </summary>
        public static string Warning = "W";
        /// <summary>
        /// C: complete-chạy xong
        /// </summary>
        public static string Success = "S";
        /// <summary>
        /// E: error-chạy lỗi
        /// </summary>
        public static string Error = "E";
    }
}
