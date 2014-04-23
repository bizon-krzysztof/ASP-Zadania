using CalendarOfEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalendarOfEvents.Service
{
    public class Repo: IRepo
    {
        private readonly List<Event> events;

        public Repo()
        {
            events = new List<Event> 
            {
                new Event {Date = DateTime.Now, Description = "Event 1"},
                new Event {Date = DateTime.Now.AddDays(6), Description = "Event 2"},
                new Event {Date = DateTime.Now.AddMonths(4), Description = "Event 3"},
                new Event {Date = DateTime.Now.AddMonths(-1), Description = "Event 4"},
                new Event {Date = DateTime.Now.AddMonths(-1), Description = "Event 5"},
                new Event {Date = DateTime.Now.AddMonths(-1), Description = "Event 6"},
                new Event {Date = DateTime.Now.AddMonths(-1), Description = "Event 7"},
                new Event {Date = DateTime.Now.AddMonths(-2), Description = "Event 8"},
                new Event {Date = DateTime.Now.AddMonths(-2), Description = "Event 9"},
                new Event {Date = DateTime.Now.AddMonths(-2), Description = "Event 10"},
                new Event {Date = DateTime.Now, Description = "Event 11"},
                new Event {Date = DateTime.Now, Description = "Event 12"},
            };
        }

        public IQueryable<Event> AsQueryable()
        {
            return events.AsQueryable();
        }
    }
}