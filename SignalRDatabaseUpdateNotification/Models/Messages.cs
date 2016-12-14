using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRDatabaseUpdateNotification.Models
{
    public class Messages
    {
        public int MessageId { get; set; }
        public string Message { get; set; }
        public string EmptyMessage { get; set; }
        public DateTime Date { get; set; }
    }
}