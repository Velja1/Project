using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Reservations
    {
        public int ID { get; set; }
        public int User_ID { get; set; }
        public DateTime Date { get; set; }
    }
}
