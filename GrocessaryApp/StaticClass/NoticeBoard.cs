using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrocessaryApp.StaticClass
{
    //inside static class all members are static
    internal static class NoticeBoard
    {
        public static string description;
        public static int numberNotice;
        public static int SizeOfNoticeBooard{get;set;}
        public static string GetNoticeBoardColor()
        {
            return "red";
        }
    }
}
