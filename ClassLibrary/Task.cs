using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Task
    {
        public string Title { get; set; }
        public DateTime Due { get; set; }
        public Boolean Done { get; set; }

        public Task(string title, DateTime due, Boolean done)
        {
            Title = title;
            Due = due;
            Done = done;
        }
    }
}
