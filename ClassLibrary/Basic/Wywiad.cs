using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Basic
{
    class Wywiad
    {
        public int IdWywiad { get; set; }
        public int IdKlient { get; set; }
        public bool WadaSerca { get; set; }
        public bool Nadcisnienie { get; set; }
        public bool ZabRytmSerca { get; set; }
        public bool Epilepsja { get; set; }
        public bool Alergia { get; set; }
        public bool Astma { get; set; }
        public bool Cukrzyca { get; set; }
        public string InneChoroby { get; set; }
    }
}
