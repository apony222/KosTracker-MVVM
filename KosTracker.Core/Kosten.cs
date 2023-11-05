using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosTracker.Core
{
    [Keyless]
    public class Kosten
    {
        public string Kategorie {  get; set; }
        public float Ausgabe {  get; set; }
        public DateTime Datum { get; set; }
    }
}
