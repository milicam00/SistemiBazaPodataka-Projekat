using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuteviLibrary.Entiteti
{
    public class Koriste
    {
        public virtual int IdKoriste { get; protected set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public virtual Radnik Nadzornik { get; set; }
        public virtual Vozilo Vozilo { get; set; }
    }
}
