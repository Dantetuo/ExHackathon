using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace oopsAPI.Models
{
    public class Oops
    {
        public int ID { get; set; }
        public string EventType { get; set; }
        public string Action { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}