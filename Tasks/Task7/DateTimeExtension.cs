using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal static class DateTimeExtension
    {
        public static int GetAge (this DateTime birthdate){
            if (birthdate > DateTime.Now) return -1;
            return DateTime.Now.Year - birthdate.Year;
        }
    }
}
