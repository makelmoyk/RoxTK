using System;
using System.Collections.Generic;
using System.Text;

namespace RoxTK.Models
{
    public class Timekeep
    {

        public Timekeep()
        {
            DateCreated = DateTime.Now;
        }

        public int TimekeepId { get; set; }
        public DateTime? LoggedIn { get; set; }
        public DateTime? LoggedOut { get; set; }
        public DateTime DateCreated { get; set; }
        public int EmployeeId { get; set; }

    }
}
