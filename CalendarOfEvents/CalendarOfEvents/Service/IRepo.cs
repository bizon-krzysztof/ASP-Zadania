using CalendarOfEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarOfEvents.Service
{
    public interface IRepo
    {
        IQueryable<Event> AsQueryable();
    }
}
