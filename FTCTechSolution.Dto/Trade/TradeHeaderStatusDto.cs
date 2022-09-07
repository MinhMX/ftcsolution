using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCTechSolution.Dto.Trade
{
  public  class TradeHeaderStatusDto
    {
        /// <summary>
        /// NULL: chưa chạy
        /// </summary>
        public static string Default = null;
        /// <summary>
        /// R: running-đang chạy
        /// </summary>
        public static string Running = "R";
        /// <summary>
        /// C: complete-chạy xong
        /// </summary>
        public static string Compelete = "C";
        /// <summary>
        /// E: error-chạy lỗi
        /// </summary>
        public static string Error = "E";
        public static string Stop = "S";
        public static bool IsValid(string status)
        {
            if (status != Default
                && status != Running
                 && status != Compelete
                  && status != Error && status != Stop)
            {
                return false;
            }
            return true;
        }
    }
}
