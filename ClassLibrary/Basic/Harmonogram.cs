using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Basic
{
    class Harmonogram
    {
        public int IdHarmonogramu { get; set; }
        public int IdDzien { get; set; }
        public int IdTrener { get; set; }
        public DateTime GodzinaRozpoczecia { get; set; }
        public DateTime GodzinaZakonczenia { get; set; }
    }
}
