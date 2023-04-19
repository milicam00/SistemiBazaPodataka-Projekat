using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdrzavanjePuteva.Entiteti
{
    public class Radnik
    {
        public virtual int IdRadnika { get; protected set; }
        public virtual String Adresa { get; set; }
        public virtual String Jmbg { get; set; }
        public virtual String Ime { get; set; }
        public virtual String Prezime { get; set; }
        public virtual String OcevoIme { get; set; }
        public virtual String GodinaRodjenja { get; set; }
        public virtual String Specijalnost { get; set; }
        public virtual String TipRadnika { get; set; }
        public virtual String MatBrNadredjenog { get; set; }
        public virtual DateTime DatumPostavljanja { get; set; }
        public virtual IList<Upravlja> UpravljaVozilima { get; set; }
        public virtual IList<Koriste> KoristiVozila { get; set; }
        public virtual IList<SpoljniSaradnik> SpoljniSaradnici { get; set; }
        public virtual IList<Deonica> Deonice { get; set; }

        public Radnik()
        {
            UpravljaVozilima = new List<Upravlja>();
            KoristiVozila = new List<Koriste>();
            SpoljniSaradnici = new List<SpoljniSaradnik>();
            Deonice = new List<Deonica>();
        }
    }
    public class Nadredjeni:Radnik
    {
        public virtual IList<Radnik> NadredjeniRadnik { get; set; }
        public Nadredjeni()
        {
            NadredjeniRadnik = new List<Radnik>();
        }
    }
    public class Nadzornik : Radnik
    {

    }
    public class Izvrsilac : Radnik
    {

    }

}
