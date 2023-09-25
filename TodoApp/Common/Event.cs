﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Common
{
    public class Event
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public List<string> Details { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Event()
        {
            Id = Guid.NewGuid();
        }

    }
}
