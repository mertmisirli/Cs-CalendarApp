using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Common;

namespace TodoApp.Entities
{
    public class Meeting : Event
    {
        public List<string> Guests { get; set; }



    }
}
