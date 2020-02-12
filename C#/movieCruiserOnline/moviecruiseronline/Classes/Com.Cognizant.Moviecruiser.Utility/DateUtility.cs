using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Cognizant.Moviecruiser.Utility
{
    public class DateUtility
    {
        public DateTime ConvertToDate(string inputDate)
        {
            return DateTime.Parse(inputDate);
        }
    }
}