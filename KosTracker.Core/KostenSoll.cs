using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosTracker.Core
{
    [Keyless]
    public class KostenSoll
    {
        public KostenSoll(float Miete, float Nebenkosten, float Lebensmittel, float Gesundheit, float Versicherung, float Transport, float Bekleidung, float Unterhaltung)
        {
            this.Miete = Miete;
            this.Nebenkosten = Nebenkosten;
            this.Lebensmittel = Lebensmittel;
            this.Gesundheit = Gesundheit;
            this.Versicherung = Versicherung;
            this.Transport = Transport;
            this.Bekleidung = Bekleidung;
            this.Unterhaltung = Unterhaltung;
        }
        public KostenSoll()
        {
            
        }
        public float Miete {  get; set; }
        public float Nebenkosten { get; set; }
        public float Lebensmittel { get; set; }
        public float Gesundheit { get; set; }
        public float Versicherung { get; set; }
        public float Transport { get; set; }
        public float Bekleidung { get; set; }
        public float Unterhaltung { get; set; }

    }
}
