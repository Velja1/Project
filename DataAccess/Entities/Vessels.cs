using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Vessels
    {
        public int ID { get; set; }
        public int Type_ID { get; set; }
        public int Manufacter_ID { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Length { get; set; }
    }
}
