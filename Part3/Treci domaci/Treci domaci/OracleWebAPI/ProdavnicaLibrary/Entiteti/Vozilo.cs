using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuteviLibrary.Entiteti

{
    public class Vozilo
    {
        public virtual int IdVozila { get; protected set; }
        public virtual string RegistarskaOznaka { get; set; }
        public virtual string TipGoriva { get; set; }
        public virtual string Boja { get; set; }
        public virtual int RadnaZapremina { get; set; }
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
        public Vozilo(int id, string reg, string tg, string boja, int zapremina, string tip, int brmesta, int nosivost, int brosovine, string tipradnemasine, string tippogona)
        {
            this.IdVozila = id;
            this.RegistarskaOznaka = reg;
            this.TipGoriva = tg;
            this.Boja = boja;
            this.RadnaZapremina = zapremina;
            this.TipVozila = tip;
            this.BrojMesta = brmesta;
            this.Nosivost = nosivost;
            this.BrOsovina = brosovine;
            this.TipRadneMasine = tipradnemasine;
            this.TipPogonaRadneMasine = tippogona;

        }

      
       
    }

    public class RadneMasine : Vozilo
    {
        public RadneMasine(int id, string ro, string tg, string b, int zm, string tipradnemasine, string tippogona)
        {



            this.IdVozila = id;
            this.RegistarskaOznaka = ro;
            this.TipGoriva = tg;
            this.Boja = b;
            this.RadnaZapremina= zm;
            this.TipRadneMasine = tipradnemasine;
            this.TipPogonaRadneMasine = tippogona;
        }
        public RadneMasine()
        {

        }
    }

    public class TeretneMasine : Vozilo
    {
        public TeretneMasine(int id, string ro, string tg, string b, int zm, int nosivost, int brojosovina)
        {


            this.IdVozila = id;
            this.RegistarskaOznaka = ro;
            this.TipGoriva = tg;
            this.Boja = b;
            this.RadnaZapremina = zm;
            this.Nosivost = nosivost;
            this.BrOsovina = brojosovina;
        }
        public TeretneMasine()
        {

        }
    }

    public class Putnicka : Vozilo
    {
        public Putnicka(int id, string reg, string tipgoriva, string boja, int zapremina, int brojmesta)
        {
            this.IdVozila = id;
            this.RegistarskaOznaka = reg;
            this.TipGoriva = tipgoriva;
            this.Boja = boja;
            this.RadnaZapremina = zapremina;
            this.BrojMesta = brojmesta;
        }
        public Putnicka()
        {

        }
    }

}
