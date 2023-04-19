using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OdrzavanjePuteva.Entiteti;

namespace OdrzavanjePuteva
{
    public class SpoljniSaradnikPregled
    {
        public int IdSpoljnogSaradnika { get; set; }
        public int BrUgovoraODelu { get; set; }

        public SpoljniSaradnikPregled() { }
        public SpoljniSaradnikPregled(int id,int br)
        {
            this.IdSpoljnogSaradnika = id;
            this.BrUgovoraODelu = br;
        }
    }

    

    public class GradilistePregled
    {
        public int IdGradilista { get; set; }
        public string Tip { get; set; }
        public GradilistePregled(int id,string tip)
        {
            this.IdGradilista = id;
            this.Tip = tip;
        }
    }

    public class GradilisteBasic
    {
        public int IdGradilista { get; set; }
        public string Tip { get; set; }
        public GradilisteBasic(int id, string tip)
        {
            this.IdGradilista = id;
            this.Tip = tip;
        }
        public GradilisteBasic()
        {

        }
    }

    public class DeonicaPregled
    {
        public int IdDeonice { get; set; }
        public int OdKilometra { get; set; }
        public int DoKilometra { get; set; }
        public string OdGrada { get; set; }
        public string DoGrada { get; set; }

        public DeonicaPregled(int id,int od,int dk,string og,string dg)
        {
            this.IdDeonice = id;
            this.OdKilometra = od;
            this.DoKilometra = dk;
            this.OdGrada = og;
            this.DoGrada = dg;

        }
    }


    public class DeonicaBasic
    { 
        public int DeonicaId { get; set; }
        public int DoKilometra { get; set; }
        public int OdKilometra { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public virtual String OdGrada { get; set; }
        public virtual String DoGrada { get; set; }

        public DeonicaBasic() { }
        public DeonicaBasic(int id,int dok,string og,string dg)
        {
            this.DeonicaId = id;
            this.DoKilometra = dok;
            this.OdGrada = og;
            this.DoGrada = dg;
        }
    }

    public class VoziloPregled
    {
        public int IdVozila { get; set; }
        public string RegistarskaOznaka { get; set; }
        public string TipGoriva { get; set; }
        public string Boja { get; set; }
        public int RadnaZapremina { get; set; }

        public VoziloPregled(int id,string ro,string tip,string bo,int rz)
        {
            this.IdVozila = id;
            this.RegistarskaOznaka = ro;
            this.TipGoriva = tip;
            this.Boja = bo;
            this.RadnaZapremina = rz;

        }
    }

    public class PutnickaPregled
    { 
        public int IdVozila { get; set; }
        public string RegistarskaOznaka { get; set; }
        public string TipGoriva { get; set; }
        public string Boja { get; set; }
        public int RadnaZapremina { get; set; }
        public int BrojMesta { get; set; }

        public PutnickaPregled(int id,string reg,string tip,string boj,int rz,int br)
        {
            this.IdVozila = id;
            this.RegistarskaOznaka = reg;
            this.TipGoriva = tip;
            this.Boja = boj;
            this.RadnaZapremina = rz;
            this.BrojMesta = br;
        }

    }
     

    public class IzvrsilacPregled
    {
        public int IdRadnika { get; protected set; }
        public String GodinaRodjenja { get; set; }
        public String Adresa { get; set; }
        public String Jmbg { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }

        public IzvrsilacPregled(int id,String g,String a,String jmbg,String ime,String pre)
        {
            this.IdRadnika = id;
            this.GodinaRodjenja = g;
            this.Adresa = a;
            this.Jmbg = jmbg;
            this.Ime = ime;
            this.Prezime = pre;
        }
    }

    public class IzvrsilacBasic
    { 
        public int IdRadnika { get; protected set; }
        public String OcevoIme { get; set; }
        public String MatBrNadredjenog { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }

        public IzvrsilacBasic() { }
        public IzvrsilacBasic(int id,String ocevo,String mat,String im,String pr)
        {
            this.IdRadnika = id;
            this.OcevoIme = ocevo;
            this.MatBrNadredjenog = mat;
            this.Ime = im;
            this.Prezime = pr;
        }
    }


}
