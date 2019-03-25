using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCgoesSPA.Models
{
    public class Spa
    {
        public string Name { get; set; }
        public decimal DayTicketPrice { get; set; }
        public decimal WeekEndTicketPrice { get; set; }
        public ICollection<Visitor> Visitors { get; set; }
    }

    public class Visitor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime VisitTime { get; set; }
        public int? FeedbackRate { get; set; }
    }
}