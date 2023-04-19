using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using OdrzavanjePuteva.Entiteti;
using NHibernate;
using System.Windows.Forms;

namespace OdrzavanjePuteva
{
    public class DTOManager
    {
        public static void CreateGradiliste(Gradiliste gradiliste)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(gradiliste);
                s.Flush();
                s.Close();

            }
            catch(Exception e)
            {

            }
        }

        public static GradilisteBasic UpdateGradilisteBasic(GradilisteBasic gradBasic)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Gradiliste gradiliste = s.Load<Gradiliste>(gradBasic.IdGradilista);
                gradiliste.Tip = gradBasic.Tip;
                s.Update(gradiliste);
                s.Flush();
                s.Close();

            }
            catch(Exception e)
            {

            }
            return gradBasic;
        }

        internal static GradilisteBasic GetGradilisteBasic(int gradilisteid)
        {
            GradilisteBasic gb = new GradilisteBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Gradiliste g = s.Load<Gradiliste>(gradilisteid);
                gb = new GradilisteBasic(g.IdGradilista, g.Tip);
                s.Close();

            }
            catch(Exception e)
            {

            }
            return gb;
        }

        public static List<GradilistePregled> GetGradilisteInfo()
        {
            List<GradilistePregled> gradilisteInfos = new List<GradilistePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Gradiliste> gradiliste = from g in s.Query<Gradiliste>() select g;
                foreach(Gradiliste g in gradiliste)
                {
                    gradilisteInfos.Add(new GradilistePregled(g.IdGradilista, g.Tip));
                }
                s.Close();

            }
            catch(Exception e)
            {

            }
            return gradilisteInfos;
        }

        public static void DeleteGradiliste(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Gradiliste g = s.Load<Gradiliste>(id);
                s.Delete(g);
                s.Flush();
                s.Close();

            }
            catch(Exception e)
            {

            }
        }

        public static void CreateIzvrsilac(Izvrsilac izvrsilac)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                s.Save(izvrsilac);
                s.Flush();
                s.Close();

            }
            catch(Exception e)
            {

            }
        }

        internal static List<Izvrsilac> GetIzvrsilac()
        {
            List<Izvrsilac> izvrsioci = new List<Izvrsilac>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Izvrsilac> iz = from i in s.Query<Izvrsilac>() select i;
                foreach(Izvrsilac i in iz)
                {
                    izvrsioci.Add(i);
                }
                s.Close();
            }
            catch(Exception e)
            {

            }
            return izvrsioci;
        }

        internal static Izvrsilac getIzvrsilacJMBG(string jmbg)
        {
            Izvrsilac izv = new Izvrsilac();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Izvrsilac> izvrsilacs = from i in s.Query<Izvrsilac>() where i.Jmbg == jmbg select i;
                foreach(Izvrsilac iz in izvrsilacs)
                {
                    izv = iz;
                }
                s.Close();
            }
            catch(Exception e)
            {

            }
            return izv;
        }

        internal static Izvrsilac GetIzvrsilac(int radnikId)
        {
            ISession s = DataLayer.GetSession();
            Izvrsilac izvrsilac = s.Get<Izvrsilac>(radnikId);
            s.Close();
            return izvrsilac;
        }

        public static List<IzvrsilacPregled> GetIzvrsiociInfo()
        {
            List<IzvrsilacPregled> izvrsioci = new List<IzvrsilacPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Izvrsilac> izvr = from i in s.Query<Izvrsilac>() select i;
                foreach(Izvrsilac i in izvr)
                {
                    izvrsioci.Add(new IzvrsilacPregled(i.IdRadnika, i.GodinaRodjenja, i.Adresa, i.Jmbg, i.Ime, i.Prezime));

                }
                s.Close();
            }
            catch(Exception e)
            {

            }
            return izvrsioci;
        }

        public static IzvrsilacBasic GetIzvrsilacBasic(int idD)
        {
            IzvrsilacBasic izvrsilacBasic = new IzvrsilacBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Izvrsilac izvrsilac = s.Load<Izvrsilac>(idD);
                izvrsilacBasic = new IzvrsilacBasic(izvrsilac.IdRadnika, izvrsilac.OcevoIme, izvrsilac.MatBrNadredjenog, izvrsilac.Ime, izvrsilac.Prezime);
                s.Close();
            }
            catch(Exception e)
            {

            }
            return izvrsilacBasic;
        }

        public static IzvrsilacBasic UpdateIzvrsilacBasic(IzvrsilacBasic izv)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Izvrsilac p = s.Load<Izvrsilac>(izv.IdRadnika);
                p.Ime = izv.Ime;
                p.MatBrNadredjenog = izv.MatBrNadredjenog;
                p.OcevoIme = izv.OcevoIme;
                p.Prezime = izv.Prezime;
                s.Update(p);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            {

            }
            return izv;
        }

        public static void DeleteIzvrsilacPregled(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Izvrsilac o = s.Load<Izvrsilac>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
               
            }
            catch (Exception e)
            {
               
            }
        }
        public static List<DeonicaPregled> GetDeonicaInfo()
        {
            List<DeonicaPregled> deonicaInfos = new List<DeonicaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Deonica> deonice = from d in s.Query<Deonica>() select d;
                foreach(Deonica d in deonice)
                {
                    deonicaInfos.Add(new DeonicaPregled(d.IdDeonice, d.OdKilometra, d.DoKilometra, d.OdGrada, d.DoGrada));
                }
                s.Close();

            }
            catch(Exception e)
            {

            }
            return deonicaInfos;
        }

        public static List<DeonicaPregled> GetDeonicaInfo(Izvrsilac izvrsilac)
        {
            List<DeonicaPregled> pregledDeonica = new List<DeonicaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Deonica> deonice = from d in s.Query<Deonica>() where d.Izvrsilac == izvrsilac select d;
                foreach(Deonica d in deonice)
                {
                    pregledDeonica.Add(new DeonicaPregled(d.IdDeonice, d.OdKilometra, d.DoKilometra, d.OdGrada, d.DoGrada));
                }
                s.Close();
            }
            catch(Exception e)
            {

            }
            return pregledDeonica;
        }

        public static Deonica GetDeonica(int deonId)
        {
            ISession s = DataLayer.GetSession();
            Deonica deonica = s.Get<Deonica>(deonId);
            s.Close();
            return deonica;
        }

        public static DeonicaBasic GetDeonicaBasic(int idD)
        {
            DeonicaBasic deonica = new DeonicaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Deonica deonica1 = s.Load<Deonica>(idD);
                deonica = new DeonicaBasic(deonica1.IdDeonice, deonica1.DoKilometra, deonica1.OdGrada, deonica1.DoGrada);
                s.Close();

            }
            catch(Exception e)
            {

            }
            return deonica;
        }

        public static DeonicaBasic UpdateDeonicaBasic(DeonicaBasic db)
        {
            
            try
            {
                ISession s = DataLayer.GetSession();
                Deonica d = s.Load<Deonica>(db.DeonicaId);
                d.DoKilometra = db.DoKilometra;
                d.OdGrada = db.OdGrada;
                d.DoGrada = db.DoGrada;
                s.Update(d);
                s.Flush();
                s.Close();


            }
            catch(Exception e)
            {

            }
            return db;
        }
        internal static List<Nadzornik> GetNadzornici(int voziloId)
        {
            List<Nadzornik> nadzornici = new List<Nadzornik>();
            try
            {
                ISession s = DataLayer.GetSession();
                Vozilo vozilo = s.Load<Vozilo>(voziloId);
                foreach(Koriste k in vozilo.RadniciKoriste)
                {
                    IEnumerable<Nadzornik> vozila = from v in s.Query<Nadzornik>() where k.Nadzornik == v select v;
                    foreach(Nadzornik v in vozila)
                    {
                        nadzornici.Add(v);
                    }
                }
                s.Close();
            }
            catch(Exception e)
            {

            }
            return nadzornici;
        }

        public static Nadzornik GetNadzornik(string jmb)
        {
            Nadzornik nadzornik = new Nadzornik();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Nadzornik> nadzornici = from n in s.Query<Nadzornik>() where n.Jmbg == jmb select n;
                foreach(Nadzornik na in nadzornici)
                {
                    nadzornik = na;
                }
                s.Close();
            }
            catch(Exception)
            {

            }
            return nadzornik;
        }

        public static List<Nadzornik> GetNadzornici()
        {
            List<Nadzornik> nadzornici = new List<Nadzornik>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Nadzornik> nad = from n in s.Query<Nadzornik>() select n;
                foreach(Nadzornik n in nad)
                {
                    nadzornici.Add(n);
                }
                s.Close();
            }
            catch(Exception e)
            {

            }
            return nadzornici;
        }

        public static List<PutnickaPregled> GetPutnickaInfo()
        {
            List<PutnickaPregled> putnickaVozila = new List<PutnickaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Putnicka> vozila = from v in s.Query<Putnicka>() select v;
                foreach(Vozilo v in vozila)
                {
                    putnickaVozila.Add(new PutnickaPregled(v.IdVozila, v.RegistarskaOznaka, v.TipGoriva, v.Boja, v.RadnaZapremina, v.BrojMesta));

                }
                s.Close();
            }
            catch(Exception e)
            {

            }return putnickaVozila;
        }

        public static Vozilo GetVozilo(string reg)
        {
            Vozilo vozilo = new Vozilo();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Vozilo> vozila = from v in s.Query<Vozilo>() where v.RegistarskaOznaka == reg select v;
                foreach(Vozilo vz in vozila)
                {
                    vozilo = vz;
                }
                s.Close();


            }
            catch(Exception ec)
            {
              //  System.Windows.Forms.MessageBox.Show(ec.ToString());
            }
            return vozilo;
        }

        public static List<SpoljniSaradnikPregled> GetSpoljniSaradniciInfo()
        {
            List<SpoljniSaradnikPregled> saradnici = new List<SpoljniSaradnikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<SpoljniSaradnik> spoljni = from sp in s.Query<SpoljniSaradnik>() select sp;
                foreach(SpoljniSaradnik sp in spoljni)
                {
                    saradnici.Add(new SpoljniSaradnikPregled(sp.IdSpoljnogSaradnika, sp.BrUgovoraODelu));
                }
                s.Close();
            }
            catch(Exception e)
            {

            }
            return saradnici;
        }

        public static SpoljniSaradnikPregled GetSpoljniSaradnik(int idD)
        {
            SpoljniSaradnikPregled ss = new SpoljniSaradnikPregled();
            try
            {
                //SpoljniSaradnikPregled ss = new SpoljniSaradnikPregled();
                ISession s = DataLayer.GetSession();
                SpoljniSaradnik p = s.Get<SpoljniSaradnik>(idD);
                ss = new SpoljniSaradnikPregled(p.IdSpoljnogSaradnika, p.BrUgovoraODelu);
                s.Close();

            }
            catch(Exception e)
            { 

            }
            return ss;
        }

        public static void DeleteSpoljniSaradnikPregled(SpoljniSaradnikPregled sp)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpoljniSaradnik spoljniSaradnik = s.Load<SpoljniSaradnik>(sp.IdSpoljnogSaradnika);
                s.Delete(spoljniSaradnik);
                s.Flush();
                s.Close();

            }
            catch(Exception e)
            {

            }

        }

        public static List<PutnickaPregled> GetVozInfo()
        {
            List<PutnickaPregled> vozila = new List<PutnickaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Putnicka> voz = from v in s.Query<Putnicka>() select v;
                foreach(Vozilo v in voz)
                {
                    vozila.Add(new PutnickaPregled(v.IdVozila, v.RegistarskaOznaka, v.TipGoriva, v.Boja, v.RadnaZapremina,v.BrojMesta));

                }
                s.Close();

            }
            catch(Exception e)
            {

            }
            return vozila;
        }

        public static List<Vozilo> GetVozilaInfo(int idi)
        {
            List<Vozilo> vozila = new List<Vozilo>();
            try
            {
                ISession s = DataLayer.GetSession();
                Izvrsilac izvrsilac = s.Load<Izvrsilac>(idi);
                foreach(Upravlja upr in izvrsilac.UpravljaVozilima)
                {
                    IEnumerable<Vozilo> voz = from v in s.Query<Vozilo>() where upr.Vozilo == v select v;
                    foreach(Vozilo v in voz)
                    {
                        vozila.Add(v);
                    }
                }
                s.Close();

            }
            catch(Exception e)
            {

            }
            return vozila;
        }
        public static List<VoziloPregled> GetVozilaInfo()
        {
            List<VoziloPregled> vozInfos = new List<VoziloPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> vozila = from o in s.Query<Vozilo>()
                                             select o;

                foreach (Vozilo o in vozila)
                {
                    vozInfos.Add(new VoziloPregled(o.IdVozila, o.RegistarskaOznaka, o.TipGoriva, o.Boja, o.RadnaZapremina));
                }

                s.Close();
            }
            catch (Exception e)

            {

            }
            return vozInfos;
        }


        /*public static Vozilo GetVoziloo(string reg)
        {
            Vozilo v = new Vozilo();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Vozilo> vozila = from x in s.Query<Vozilo>() where x.RegistarskaOznaka == reg select x;
                foreach(Vozilo vozilo in vozila)
                {
                    v = vozilo;
                }
                s.Close();
            }
            catch(Exception e)
            {

            }
            return v;
        }*/
    }
}
