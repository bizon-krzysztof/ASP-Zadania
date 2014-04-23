using CalendarOfEvents.Models;
using CalendarOfEvents.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalendarOfEvents.Controllers
{
    public class EventsController : ApiController
    {
        private readonly IRepo repository;

        public EventsController(IRepo repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Event> GetEventsByDate(int month, int year)
        {
            return repository.AsQueryable().Where(n => n.Date.Month == month && n.Date.Year == year);
        }
    }
}
