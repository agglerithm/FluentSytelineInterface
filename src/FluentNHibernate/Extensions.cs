

using System;
using System.Collections.Generic;
using System.Reflection;
using EdiMessages;
using FluentNHibernate.Data;
using AFPST.Common.Extensions;
using ReportingRepositories.Entities;

namespace Reporting.Common.Extensions
{
    public static class CommonExtensions
    {
  
        public static DateTime RoundDateDown(this DateTime dte)
        {
            return DateTime.Parse(dte.ToString("MM/dd/yyyy"));
        }

        public static void SetTimeOfDay(this ReportScheduleEntity schedule, TimeSpan timeOfDay)
        {
            var roundDate = schedule.LastRunDate.RoundDateDown();
            schedule.LastRunDate = roundDate.Add(timeOfDay);
        }


        public static DateTime ToSqlDateTime(this DateTime dte)
        {
            return dte == DateTime.MinValue ? "1/1/1900".CastToDateTime() : dte;
        }
        public static string GetLogMessage(this Entity obj)
        {
            var tpe = obj.GetType();
            var val = string.Format("Entity name:{0};", tpe.Name);
            var info = new TypeDelegator(tpe);
            var props = info.GetProperties();
            props.ForEach(p => val += string.Format("{0}='{1}',", p.Name, tpe.InvokeMember(p.Name, BindingFlags.GetProperty, null, obj, null)));
            return val;
        }

    }
}