using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdrzavanjePuteva.Entiteti
{
    public class Upravlja
    {
        public virtual int IdUpravlja { get; protected set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public virtual Radnik RadnikIzvrsilac { get; set; }
        public virtual Vozilo Vozilo { get; set; }

    }
}
