namespace SytelineInterface.Common
{
    using System;

    public static class SystemTime
    {
        public static Func<DateTime> Now = () => DateTime.Now;
        public static Func<DateTime> Today = () => DateTime.Today;

        public static void Reset()
        {
            Now = () => DateTime.Now;
            Today = () => DateTime.Today;
        }
         
    }
}