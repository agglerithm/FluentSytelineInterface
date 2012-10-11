

using System;
using System.Collections.Generic; 
using System.Reflection; 
using EdiMessages;
using FluentNHibernate.Data;  
using AFPST.Common.Extensions;

namespace Reporting.Common.Extensions
{
    public static class CommonExtensions  
    {


        public static string GetFlatFile(this FinishedAndRawInventoryCountedList inv)
        {
            return get_lines(inv.InventoryList); 
        }
 
        private static string get_lines(IList<FinishedAndRawInventoryCounted> counteds)
        {
            var retVal = "Dell Part Number	Available FG Qty	Available RAW Qty\r\n";
            counteds.ForEach(
                i => retVal += get_line(i) + "\r\n");
            return retVal;
        }

        private static string get_line(FinishedAndRawInventoryCounted i)
        {
            return string.Format("{0}\t{1}\t{2}", i.CustomerPartNumber, 
                                 i.AvailableFinishedQuantity,   // + i.AvailableRawQuantity, //temporary fix for wwt SNAFU
                                 i.AvailableRawQuantity);
        }

        public static TimeSpan TimeOfDay(this string timeStr)
        {
            var timeOfDay = DateTime.MinValue;
            if (DateTime.TryParse(timeStr, out timeOfDay))
                return timeOfDay.TimeOfDay;
            return DateTime.MinValue.TimeOfDay;
        }

        public static DateTime RoundDateDown(this DateTime dte)
        {
            return DateTime.Parse(dte.ToString("MM/dd/yyyy"));
        }
 


    }
}