namespace SytelineInterface.Core
{
    using System;

    public class ActiveUserSession
    {
        public string UserName { get; set; }
        public DateTime RecordDate { get; set; }

        public string ConnectionID
        {
            get; set;
        }
        public DateTime CreateDate { get; set; }

    }
}