using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PuteviLibrary.Entiteti;


namespace PuteviLibrary.Mapiranja
{
    public class VoziloMapiranja:ClassMap<Vozilo>
    {
        public VoziloMapiranja()
        {
            Table("VOZILO");
            DiscriminateSubClassesOnColumn("TIP_VOZILA");
            Id(x => x.IdVozila, "IDVOZILA").GeneratedBy.TriggerIdentity();
            Map(x => x.RegistarskaOznaka, "REGISTARSKA_OZNAKA");
            Map(x => x.TipGoriva, "TIP_GORIVA");
            Map(x => x.Boja, "BOJA");
            Map(x => x.RadnaZapremina, "RADNA_ZAPREMINA");
           // Map(x => x.TipVozila, "TIP_VOZILA");
            Map(x => x.BrojMesta,"BROJ_MESTA");
            Map(x => x.Nosivost, "NOSIVOST");
            Map(x => x.BrOsovina, "BR_OSOVINA");
            Map(x => x.TipRadneMasine, "TIP_RADNE_MASINE");
            Map(x => x.TipPogonaRadneMasine, "TIP_POGONA_RADNE_MASINE");
            HasMany(x => x.RadniciKoriste).KeyColumn("ID_VOZILA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.UpravljaIzvrsilac).KeyColumn("ID_VOZILA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.AngazovaneMasine).KeyColumn("ID_VOZILA").LazyLoad().Cascade.All().Inverse();


        }
    }
    public class PutnickaMapiranja : SubclassMap<Putnicka>
    { 
        public PutnickaMapiranja()
        {
            DiscriminatorValue("putnicka");
        }
    }

    public class TeretnaMapiranja : SubclassMap<TeretneMasine>
    {
        public TeretnaMapiranja()
        {
            DiscriminatorValue("teretna");

        }
    }

    public class RadneMasineMapiranja : SubclassMap<RadneMasine>
    { 
       public RadneMasineMapiranja()
        {
            DiscriminatorValue("radna masina");
        }
    }

}
