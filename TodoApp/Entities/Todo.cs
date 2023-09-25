using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Common;
using TodoApp.Enums;

namespace TodoApp.Entities
{
    public class Todo : Event
    {

        public Importance Importance { get; set; }

        public Todo() {
            
       }
    }
}
