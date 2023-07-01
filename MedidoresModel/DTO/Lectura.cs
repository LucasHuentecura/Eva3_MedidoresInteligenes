using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel
{
    public class Lectura
    {
        private DateTime readingDate;
        private int hour;
        private int minutes;
        private int consume;

        public DateTime ReadingDate { get => readingDate; set => readingDate = value; }
        public int Hour { get => hour; set => hour = value; }
        public int Minutes { get => minutes; set => minutes = value; }
        public int Consume { get => consume; set => consume = value; }
    }
}
