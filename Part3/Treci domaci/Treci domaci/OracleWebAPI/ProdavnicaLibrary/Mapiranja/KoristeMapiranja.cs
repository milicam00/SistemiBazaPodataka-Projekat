using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PuteviLibrary.Entiteti;


namespace PuteviLibrary.Mapiranja
{
    public class KoristeMapiranja:ClassMap<Koriste>
    {
        public KoristeMapiranja()
        {
            Table("KORISTE");

            Id(x => x.IdKoriste, "ID_KORISTE").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumOd, "DATUM_OD");

            Map(x => x.DatumDo, "DATUM_DO");
            References(x => x.Vozilo).Column("ID_VOZILA");
            References(x => x.Nadzornik).Column("ID_NADZORNIKA");
        }
    }
}
