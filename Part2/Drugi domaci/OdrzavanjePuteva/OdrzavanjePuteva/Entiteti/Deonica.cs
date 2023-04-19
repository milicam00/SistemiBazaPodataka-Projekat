using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdrzavanjePuteva.Entiteti
{
    public class Deonica
    {
        public virtual int IdDeonice { get; protected set; }
        public virtual int OdKilometra { get; set; }
        public virtual int DoKilometra { get; set; }
        public virtual String OdGrada { get; set; }
        public virtual String DoGrada { get; set; }
        public virtual DateTime DatumOd { get; set; }
        public virtual DateTime DatumDo { get; set; }
        public virtual Gradiliste Gradiliste { get; set; }
        public virtual Radnik Izvrsilac { get; set; }
        public virtual IList<Angazovane> AngazovanaVozila { get; set; }


        public Deonica()
        {
            AngazovanaVozila = new List<Angazovane>();
        }

    }
}
