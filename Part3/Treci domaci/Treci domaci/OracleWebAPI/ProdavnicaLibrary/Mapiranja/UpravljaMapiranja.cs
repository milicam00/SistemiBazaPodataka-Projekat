using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PuteviLibrary.Entiteti;


namespace PuteviLibrary.Mapiranja
{
    class UpravljaMapiranja:ClassMap<Upravlja>
    {
        public UpravljaMapiranja()
        {
            Table("UPRAVLJA");
            Id(x => x.IdUpravlja, "ID_UPRAVLJA").GeneratedBy.TriggerIdentity();
            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");

            References(x => x.Vozilo).Column("ID_VOZILA");
            References(x => x.RadnikIzvrsilac).Column("ID_IZVRSIOCA");
        }
    }
}
