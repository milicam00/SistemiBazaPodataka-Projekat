using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OdrzavanjePuteva.Entiteti;

namespace OdrzavanjePuteva.Mapiranja
{
    public class RadnikMapiranja : ClassMap<Radnik>
    {
        public RadnikMapiranja()
        {
            Table("RADNIK");
            Id(x => x.IdRadnika).Column("IDRADNIKA").GeneratedBy.TriggerIdentity();
            DiscriminateSubClassesOnColumn("TIPRADNIKA");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.Jmbg).Column("JMBG");
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.OcevoIme).Column("OCEVO_IME");
            Map(x => x.GodinaRodjenja).Column("GODINA_RODJENJA");
            Map(x => x.Specijalnost).Column("SPECIJALNOST");
            Map(x => x.MatBrNadredjenog).Column("MATBRNADREDJENOG");
            Map(x => x.DatumPostavljanja).Column("DATUM_POSTAVLJANJA");

            HasMany(x => x.UpravljaVozilima).KeyColumn("ID_IZVRSIOCA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.KoristiVozila).KeyColumn("ID_NADZORNIKA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Deonice).KeyColumn("IDIZVRSIOCA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.SpoljniSaradnici).KeyColumn("ID_NADZORNIKA").LazyLoad().Cascade.All().Inverse();

        }

    }
    public class NadredjeniMapiranja:SubclassMap<Nadredjeni>
    {
        public NadredjeniMapiranja()
        {
            DiscriminatorValue(1);
            HasMany(x => x.NadredjeniRadnik).KeyColumn("MATBRNADREDJENOG").LazyLoad().Cascade.All().Inverse();
        }
    }
    public class NadzornikMapiranja:SubclassMap<Nadzornik>
    {
        public NadzornikMapiranja()
        {
            DiscriminatorValue("nadzornik");
        }
    }
    public class IzvrsilacMapiranja:SubclassMap<Izvrsilac>
    {
        public IzvrsilacMapiranja()
        {
            DiscriminatorValue("izvrsilac");
        }
    }
}
