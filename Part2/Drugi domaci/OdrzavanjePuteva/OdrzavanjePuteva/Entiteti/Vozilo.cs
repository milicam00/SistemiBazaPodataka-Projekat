using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdrzavanjePuteva.Entiteti
{
    public class Vozilo
    {
        public virtual int IdVozila { get; protected set; }
        public virtual string RegistarskaOznaka { get; set; }
        public virtual string TipGoriva { get; set; }
        public virtual string Boja { get; set; }
        public virtual int  RadnaZapremina { get; set; }
        public virtual string TipVozila { get; set; }
        public virtual int BrojMesta { get; set; }
        public virtual int Nosivost { get; set; }
        public virtual int BrOsovina { get; set; }
        public virtual string TipRadneMasine { get; set; }
        public virtual string TipPogonaRadneMasine { get; set; }
        public virtual IList<Koriste> RadniciKoriste { get; set; }
        public virtual IList<Upravlja> UpravljaIzvrsilac { get; set; }
        public virtual IList<Angazovane> AngazovaneMasine { get; set; }
        public Vozilo()
        {
            RadniciKoriste = new List<Koriste>();
            UpravljaIzvrsilac = new List<Upravlja>();
            AngazovaneMasine = new List<Angazovane>();
        }
    }

    public class RadneMasine : Vozilo
    {

    }

    public class TeretneMasine : Vozilo 
    {

    }

    public class Putnicka:Vozilo
    {

    }

}
