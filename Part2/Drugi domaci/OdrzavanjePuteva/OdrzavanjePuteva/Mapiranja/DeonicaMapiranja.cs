using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OdrzavanjePuteva.Entiteti;


namespace OdrzavanjePuteva.Mapiranja
{
    public class DeonicaMapiranja:ClassMap<Deonica>
    {
        public DeonicaMapiranja()
        {
            Table("DEONICA");
            Id(x => x.IdDeonice, "IDDEONICE").GeneratedBy.TriggerIdentity().UnsavedValue(-1);

            Map(x => x.OdKilometra, "OD_KILOMETRA");
            Map(x => x.DoKilometra, "DO_KILOMETRA");
            Map(x => x.OdGrada, "OD_GRADA");
            Map(x => x.DoGrada, "DO_GRADA");
            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");

            References(x => x.Gradiliste).Column("IDGRADILISTA");
            References(x => x.Izvrsilac).Column("IDIZVRSIOCA");
            HasMany(x => x.AngazovanaVozila).KeyColumn("ID_DEONICE").LazyLoad().Cascade.All().Inverse();

        }
    }
}
