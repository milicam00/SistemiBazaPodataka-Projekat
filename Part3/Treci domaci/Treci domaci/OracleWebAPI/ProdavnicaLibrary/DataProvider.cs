using NHibernate;
using PuteviLibrary.DTOs;
using PuteviLibrary.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using PuteviLibrary;

namespace PuteviLibrary
{
    public class DataProvider
    {
        #region Izvrsilac
        public static List<IzvrsilacView> GetIzvrsiociInfo()
        {
            List<IzvrsilacView> izvrsioci = new List<IzvrsilacView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Izvrsilac> izvr = from i in s.Query<Izvrsilac>() select i;
                foreach (Izvrsilac i in izvr)
                {
                    izvrsioci.Add(new IzvrsilacView(i.IdRadnika, i.GodinaRodjenja, i.Adresa, i.Jmbg, i.Ime, i.Prezime, i.OcevoIme));

                }
                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return izvrsioci;
        }

        public static IzvrsilacView GetIzvrsilacViewId(int id)
        {

            try
            {
                ISession sesija = DataLayer.GetSession();


                Izvrsilac izv = sesija.Load<Izvrsilac>(id);
                IzvrsilacView izvRet = new IzvrsilacView(izv.IdRadnika, izv.GodinaRodjenja, izv.Adresa, izv.Jmbg, izv.Ime, izv.Prezime, izv.OcevoIme);
                sesija.Close();
                return izvRet;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public static bool CreateIzvrsilac(String gr, String a, String jmbg, String ime, String p, String oi)
        {
            Izvrsilac iz = new Izvrsilac();
            iz.GodinaRodjenja = gr;
            iz.Ime = ime;
            iz.Prezime = p;
            iz.Adresa = a;
            iz.Jmbg = jmbg;
            iz.OcevoIme = oi;

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(iz);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                return false;
            }
            return true;

        }

        public static int UpdateIzvrsilacView(IzvrsilacView ip)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Izvrsilac o = s.Load<Izvrsilac>(ip.IdRadnika);

                o.GodinaRodjenja = ip.GodinaRodjenja;
                o.Adresa = ip.Adresa;
                o.Ime = ip.Ime;
                o.Prezime = ip.Prezime;
                o.Jmbg = o.Jmbg;
                o.OcevoIme = ip.OcevoIme;

                s.Update(o);
                s.Flush();

                s.Close();
                return 1;
            }
            catch (Exception ec)
            {

                return -1;
            }
        }
        public static void DeleteIzvrsilacView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Izvrsilac o = s.Load<Izvrsilac>(id);

                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }


        #endregion

        #region Deonica
        public static List<DeonicaView> GetDeonInfo()
        {
            List<DeonicaView> deoInfos = new List<DeonicaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Deonica> deonice = from o in s.Query<Deonica>() select o;

                foreach (Deonica o in deonice)
                {
                    deoInfos.Add(new DeonicaView(o.IdDeonice, o.OdKilometra, o.DoKilometra, o.OdGrada, o.DoGrada, o.Izvrsilac.IdRadnika, o.Gradiliste.IdGradilista, o.DatumOd));
                }

                s.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return deoInfos;

        }


        public static DeonicaView UcitajInformacijeDeonicaPoId(int id)
        {
            try
            {

                ISession sesija = DataLayer.GetSession();


                Deonica deonica = sesija.Load<Deonica>(id);
                DeonicaView deonicaRet = new DeonicaView(deonica.IdDeonice, deonica.OdKilometra, deonica.DoKilometra, deonica.OdGrada, deonica.DoGrada, deonica.Izvrsilac.IdRadnika, deonica.Gradiliste.IdGradilista, deonica.DatumOd);
                sesija.Close();
                return deonicaRet;
            }
            catch (Exception ec)
            {
                return null;

            }

        }

        public static int UpdateDeonicaView(DeonicaView db)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Deonica o = s.Load<Deonica>(db.IdDeonice);
                o.OdKilometra = db.OdKilometra;
                o.DoKilometra = db.DoKilometra;
                o.OdGrada = db.OdGrada;
                o.DoGrada = db.DoGrada;
                o.DatumOd = db.DatumOd;

                s.Update(o);
                s.Flush();

                s.Close();
                return 1;

            }
            catch (Exception ec)
            {

                return -1;
            }
        }

        public static bool DodajDeonicu(Deonica deonica)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                Deonica deonicaZaBazu = new Deonica();
                deonicaZaBazu.OdKilometra = deonica.OdKilometra;
                deonicaZaBazu.DoKilometra = deonica.DoKilometra;
                deonicaZaBazu.OdGrada = deonica.OdGrada;
                deonicaZaBazu.DoGrada = deonica.DoGrada;
                deonicaZaBazu.DatumOd = deonica.DatumOd;



                Gradiliste gradiliste = s.Load<Gradiliste>(deonica.Gradiliste.IdGradilista);
                Radnik izvrsilac = s.Load<Radnik>(deonica.Izvrsilac.IdRadnika);


                deonicaZaBazu.Izvrsilac = izvrsilac;
                deonicaZaBazu.Gradiliste = gradiliste;
                s.Save(deonicaZaBazu);
                s.Flush();
                s.Close();
                return true;
            }
            catch (Exception ec)
            {
                return false;
            }

        }

        public static void DeleteDeonicu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Deonica d = s.Load<Deonica>(id);

                s.Delete(d);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
        }
        #endregion

        #region Gradiliste
        public static List<GradilisteView> GetGradilistaInfo()
        {
            List<GradilisteView> gradInfos = new List<GradilisteView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Gradiliste> gradiliste = from o in s.Query<Gradiliste>()
                                                     select o;

                foreach (Gradiliste o in gradiliste)
                {
                    gradInfos.Add(new GradilisteView(o.IdGradilista, o.Tip));
                }

                s.Close();
            }
            catch (Exception e)
            {

            }
            return gradInfos;
        }

        public static GradilisteView GetGradilisteId(int id)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();


                Gradiliste gradiliste = sesija.Load<Gradiliste>(id);
                GradilisteView gradilisteRet = new GradilisteView(gradiliste.IdGradilista, gradiliste.Tip);
                sesija.Close();
                return gradilisteRet;
            }
            catch (Exception ec)
            {
                return null;
            }
        }


        public static bool DodajGradiliste(String tip)
        {
            Gradiliste gradiliste = new Gradiliste();
            gradiliste.Tip = tip;

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(gradiliste);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                return false;
            }
            return true;
        }

        public static int UpdateGradilisteView(GradilisteView gb)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Gradiliste o = s.Load<Gradiliste>(gb.IdGradilista);
                o.Tip = gb.Tip;


                s.Update(o);
                s.Flush();

                s.Close();
                return 1;
            }
            catch (Exception ec)
            {

                return -1;
            }


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
            catch (Exception e)
            {

            }
        }
        #endregion

        #region Vozilo
        public static List<VoziloView> GetVozilaInfo()
        {
            List<VoziloView> vozInfos = new List<VoziloView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> vozila = from o in s.Query<Vozilo>()
                                             select o;

                foreach (Vozilo o in vozila)
                {
                    vozInfos.Add(new VoziloView(o.IdVozila, o.RegistarskaOznaka, o.TipGoriva, o.Boja, o.RadnaZapremina));
                }

                s.Close();
            }
            catch (Exception e)
            {

            }
            return vozInfos;
        }

        public static VoziloView GetVoziloId(int id)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();


                Vozilo vozilo = sesija.Load<Vozilo>(id);
                VoziloView voziloP = new VoziloView(vozilo.IdVozila, vozilo.RegistarskaOznaka, vozilo.TipGoriva, vozilo.Boja, vozilo.RadnaZapremina);
                sesija.Close();
                return voziloP;
            }
            catch (Exception ec)
            {
                return null;
            }
        }
        public static List<VoziloView> GetAllVozila()
        {
            List<VoziloView> vozila = new List<VoziloView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Vozilo> izvr = from i in s.Query<Vozilo>() select i;
                foreach (Vozilo i in izvr)
                {
                    vozila.Add(new VoziloView(i.IdVozila, i.RegistarskaOznaka, i.TipGoriva, i.Boja, i.RadnaZapremina));

                }
                s.Close();
            }
            catch (Exception e)
            {

            }
            return vozila;
        }

        public static List<Vozilo> GetVoziloInfo()
        {
            List<Vozilo> voziloInfo = new List<Vozilo>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Vozilo> vozilo = from o in s.Query<Vozilo>()
                                             select o;

                foreach (Vozilo o in vozilo)
                {
                    voziloInfo.Add(new Vozilo(o.IdVozila, o.RegistarskaOznaka, o.TipGoriva, o.Boja, o.RadnaZapremina, o.TipVozila, o.BrojMesta, o.Nosivost, o.BrOsovina, o.TipRadneMasine, o.TipPogonaRadneMasine));
                }

                s.Close();
            }
            catch (Exception e)
            {

            }
            return voziloInfo;
        }

        public static bool DeleteVozilo(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Vozilo o = s.Load<Vozilo>(id);

                s.Delete(o);
                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }
        #endregion

        #region Nadzornik
        public static List<NadzornikView> GetNadzornikInfo()
        {
            List<NadzornikView> nadInfos = new List<NadzornikView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Nadzornik> nadzornik = from o in s.Query<Nadzornik>()
                                                   select o;

                foreach (Nadzornik o in nadzornik)
                {
                    nadInfos.Add(new NadzornikView(o.IdRadnika, o.GodinaRodjenja, o.Adresa, o.Jmbg, o.Ime, o.Prezime, o.OcevoIme));
                }

                s.Close();
            }
            catch (Exception e)
            {

            }
            return nadInfos;
        }

         public static NadzornikView GetNadzornikPregledId(int id)
        {

            try
            {
                ISession sesija = DataLayer.GetSession();


                Nadzornik izv = sesija.Load<Nadzornik>(id);
                NadzornikView izvRet = new NadzornikView(izv.IdRadnika, izv.GodinaRodjenja, izv.Adresa, izv.Jmbg, izv.Ime, izv.Prezime, izv.OcevoIme);
                sesija.Close();
                return izvRet;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public static bool CreateNadzornik(String gr, String a, String jmbg, String ime, String p, String oi)
        {
            Nadzornik iz = new Nadzornik();
            iz.GodinaRodjenja = gr;
            iz.Ime = ime;
            iz.Prezime = p;
            iz.Adresa = a;
            iz.Jmbg = jmbg;
            iz.OcevoIme = oi;

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(iz);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
               
                return false;
            }
            return true;

        }
        public static void DeleteNadzornikView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nadzornik o = s.Load<Nadzornik>(id);

                s.Delete(o);
                s.Flush();

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static int UpdateNadzornikView(NadzornikView ip)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                Nadzornik o = s.Load<Nadzornik>(ip.IdRadnika);

                o.GodinaRodjenja = ip.GodinaRodjenja;
                o.Adresa = ip.Adresa;
                o.Ime = ip.Ime;
                o.Prezime = ip.Prezime;
                o.Jmbg = o.Jmbg;


                s.Update(o);
                s.Flush();

                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
               
                return -1;
            }
        }
        #endregion

        #region SpoljniSaradnik
        public static List<SpoljniSaradnikView> GetSpoljniSaradniciInfo()
        {
            List<SpoljniSaradnikView> saradnici = new List<SpoljniSaradnikView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<SpoljniSaradnik> spoljni = from sp in s.Query<SpoljniSaradnik>() select sp;
                foreach (SpoljniSaradnik sp in spoljni)
                {
                    saradnici.Add(new SpoljniSaradnikView(sp.IdSpoljnogSaradnika, sp.BrUgovoraODelu));
                }
                s.Close();
            }
            catch (Exception e)
            {

            }
            return saradnici;
        }

        public static SpoljniSaradnikView GetSpoljniSaradnikId(int id)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();


                SpoljniSaradnik ss = sesija.Load<SpoljniSaradnik>(id);
                SpoljniSaradnikView saradnikRet = new SpoljniSaradnikView(ss.IdSpoljnogSaradnika, ss.BrUgovoraODelu, ss.Nadzornik.IdRadnika);
                sesija.Close();
                return saradnikRet;
            }
            catch (Exception ec)
            {
                return null;
            }
        }

        public static bool DodajSaradnika(int brU)
        {
            SpoljniSaradnik ss = new SpoljniSaradnik();
            ss.BrUgovoraODelu = brU;
            Radnik nadzornik = new Radnik();


            try
            {
                ISession s = DataLayer.GetSession();
                nadzornik = s.Load<Nadzornik>(10);
                ss.Nadzornik = nadzornik;
                s.SaveOrUpdate(ss);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                return false;
            }
            return true;
        }

        public static void DeleteSpoljniSaradnikView(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpoljniSaradnik o = s.Load<SpoljniSaradnik>(id);

                s.Delete(o);
                s.Flush();

                s.Close();
                    
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static int UpdateSpoljniSaradnikView(SpoljniSaradnikView ssp)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                SpoljniSaradnik o = s.Load<SpoljniSaradnik>(ssp.IdSpoljnogSaradnika);
                o.BrUgovoraODelu = ssp.BrUgovoraODelu;


                s.Update(o);
                s.Flush();

                s.Close();
                return 1;
            }
            catch (Exception ec)
            {
               
                return -1;
            }


        }
        #endregion

        #region PutnickaVozila
        public static List<PutnickaView> GetPutnickaView()
        {
            List<PutnickaView> lista = new List<PutnickaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from Putnicka order by IdVozila asc");

                IList<Putnicka> vozila = q.List<Putnicka>();


                foreach (Putnicka p in vozila)
                {
                    lista.Add(new PutnickaView(p.IdVozila, p.RegistarskaOznaka, p.TipGoriva, p.Boja, p.RadnaZapremina, p.BrojMesta));
                }

                s.Close();


            }
            catch (Exception ec)
            {
               
            }
            return lista;
        }


        public static PutnickaView GetPutnickaIdView(int id)
        {
            PutnickaView putnickaPregled = null;
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Putnicka where IdVozila = " + id.ToString() + " order by IdVozila asc");

                Putnicka p = q.UniqueResult<Putnicka>();


                putnickaPregled = new PutnickaView(p.IdVozila, p.RegistarskaOznaka, p.TipGoriva, p.Boja, p.RadnaZapremina, p.BrojMesta);


                s.Close();

            }
            catch (Exception ec)
            {

            }
            return putnickaPregled;
        }


        public static bool CreatePutnicka(PutnickaView p)
        {
            Putnicka putnicko = new Putnicka(p.IdVozila, p.RegistarskaOznaka, p.TipGoriva, p.Boja, p.ZapreminaMotora, p.BrojMesta);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(putnicko);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                return false;
            }
            return true;
        }

        public static bool UpdatePutnicka(PutnickaView vozilo)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Putnicka ucitanoVozilo = sesija.Load<Putnicka>(vozilo.IdVozila);


                ucitanoVozilo.BrojMesta = vozilo.BrojMesta;
                ucitanoVozilo.TipGoriva = vozilo.TipGoriva;
                ucitanoVozilo.RegistarskaOznaka = vozilo.RegistarskaOznaka;
                ucitanoVozilo.Boja = vozilo.Boja;
                ucitanoVozilo.RadnaZapremina = vozilo.ZapreminaMotora;


                sesija.Update(ucitanoVozilo);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }

        public static bool DeletePutnicka(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Putnicka o = s.Load<Putnicka>(id);

                s.Delete(o);
                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }
        #endregion

        #region TeretnaVozila
        public static List<TeretnaView> GetTeretna()
        {
            List<TeretnaView> lista = new List<TeretnaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from TeretneMasine order by IdVozila asc");

                IList<TeretneMasine> vozila = q.List<TeretneMasine>();


                foreach (TeretneMasine p in vozila)
                {
                    lista.Add(new TeretnaView(p.IdVozila, p.RegistarskaOznaka, p.TipGoriva, p.Boja, p.RadnaZapremina,p.Nosivost, p.BrOsovina));
                }

                s.Close();


            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return lista;
        }

        public static TeretnaView GetTeretnaId(int id)
        {
            TeretnaView teretnaPregled = null;
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from TeretneMasine where IdVozila = " + id.ToString() + " order by IdVozila asc");

                TeretneMasine p = q.UniqueResult<TeretneMasine>();


                teretnaPregled = new TeretnaView(p.IdVozila, p.RegistarskaOznaka, p.TipGoriva, p.Boja, p.RadnaZapremina, p.Nosivost, p.BrOsovina);


                s.Close();

            }
            catch (Exception ec)
            {
                //handle exceptions
            }
            return teretnaPregled;
        }

        public static bool CreateTeretna(TeretnaView p)
        {
            TeretneMasine teretne = new TeretneMasine(p.IdVozila, p.RegistarskaOznaka, p.TipGoriva, p.Boja, p.ZapreminaMotora, p.Nosivost, p.BrojOsovina);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(teretne);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

                return false;
            }
            return true;
        }

        public static bool UpdateTeretna(TeretnaView vozilo)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                TeretneMasine ucitanoVozilo = sesija.Load<TeretneMasine>(vozilo.IdVozila);


                ucitanoVozilo.BrOsovina = vozilo.BrojOsovina;
                ucitanoVozilo.Nosivost = vozilo.Nosivost;
                ucitanoVozilo.TipGoriva = vozilo.TipGoriva;
                ucitanoVozilo.RegistarskaOznaka = vozilo.RegistarskaOznaka;
                ucitanoVozilo.Boja = vozilo.Boja;
                ucitanoVozilo.RadnaZapremina = vozilo.ZapreminaMotora;


                sesija.Update(ucitanoVozilo);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }
        public static bool DeleteTeretna(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                TeretneMasine o = s.Load<TeretneMasine>(id);

                s.Delete(o);
                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }
        #endregion

        #region RadneMasine
        public static List<RadneMasineView> GetRadneMasineInfo()
        {
            List<RadneMasineView> lista = new List<RadneMasineView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from RadneMasine order by IdVozila asc");

                IList<RadneMasine> vozila = q.List<RadneMasine>();


                foreach (RadneMasine p in vozila)
                {
                    lista.Add(new RadneMasineView(p.IdVozila, p.RegistarskaOznaka, p.TipGoriva, p.Boja, p.RadnaZapremina, p.TipRadneMasine, p.TipPogonaRadneMasine));
                }

                s.Close();

            }
            catch (Exception ec)
            {
              
            }
            return lista;
        }


        public static RadneMasineView GetRadneMasineId(int id)
        {
            RadneMasineView masinePregled = null;
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from RadneMasine where IdVozila = " + id.ToString() + " order by IdVozila asc");

                RadneMasine p = q.UniqueResult<RadneMasine>();


                masinePregled = new RadneMasineView(p.IdVozila, p.RegistarskaOznaka, p.TipGoriva, p.Boja, p.RadnaZapremina, p.TipRadneMasine, p.TipPogonaRadneMasine);


                s.Close();

            }
            catch (Exception ec)
            {
               
            }
            return masinePregled;
        }

        public static bool CreateRadneMasine(RadneMasineView p)
        {
            RadneMasine masine = new RadneMasine(p.IdVozila, p.RegistarskaOznaka, p.TipGoriva, p.Boja, p.ZapreminaMotora, p.TipRadneMasine, p.TipPogonaRadneMasine);

            try
            {
                ISession s = DataLayer.GetSession();
                s.SaveOrUpdate(masine);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
               
                return false;
            }
            return true;
        }

        public static bool UpdateRadneMasine(RadneMasineView vozilo)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                RadneMasine ucitanoVozilo = sesija.Load<RadneMasine>(vozilo.IdVozila);


                ucitanoVozilo.TipRadneMasine = vozilo.TipRadneMasine;
                ucitanoVozilo.TipPogonaRadneMasine = vozilo.TipPogonaRadneMasine;
                ucitanoVozilo.TipGoriva = vozilo.TipGoriva;
                ucitanoVozilo.RegistarskaOznaka = vozilo.RegistarskaOznaka;
                ucitanoVozilo.Boja = vozilo.Boja;
                ucitanoVozilo.RadnaZapremina= vozilo.ZapreminaMotora;


                sesija.Update(ucitanoVozilo);
                sesija.Flush();
                sesija.Close();
                return true;
            }
            catch (Exception ec)
            {

                return false;
            }
        }
        public static bool DeleteRadneMasine(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RadneMasine o = s.Load<RadneMasine>(id);

                s.Delete(o);
                s.Flush();

                s.Close();

                return true;
            }
            catch (Exception ec)
            {
                return false;
            }
        }
        #endregion
       


        
    }


}
