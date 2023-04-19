using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdrzavanjePuteva.Entiteti
{
    public class Koriste
    {
        public virtual int IdKoriste { get; protected set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        /// <summary>
        /// ///////
        /// </summary>
        public virtual Radnik Nadzornik { get; set; }
        public virtual Vozilo Vozilo { get; set; }
    }
}
