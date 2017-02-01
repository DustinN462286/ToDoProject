using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Model
{
    public class ToDoListViewModel
    {
        public int id { get; set; }

        public string MustDo { get; set; }

        public DateTime DueByDate { get; set; }

        public int EnableToDoList { get; set; }

    }
}
