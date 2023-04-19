using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OdrzavanjePuteva.Entiteti;


namespace OdrzavanjePuteva.Mapiranja
{
   public class AngazovaneMapiranja:ClassMap<Angazovane>
    {
        public AngazovaneMapiranja()
        {
            Table("ANGAZOVANE");
            Id(x => x.IdAngazovane, "ID_ANGAZOVANE").GeneratedBy.TriggerIdentity();
            Map(x => x.DatumOd, "DATUM_OD");
            Map(x => x.DatumDo, "DATUM_DO");
            References(x => x.Vozilo).Column("ID_VOZILA");
            References(x => x.Deonica).Column("ID_DEONICE");
        }
    }
}
