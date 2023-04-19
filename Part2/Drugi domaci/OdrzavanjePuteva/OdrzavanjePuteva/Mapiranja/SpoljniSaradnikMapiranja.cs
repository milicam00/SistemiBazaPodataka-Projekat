using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using OdrzavanjePuteva.Entiteti;

namespace OdrzavanjePuteva.Mapiranja
{
    class SpoljniSaradnikMapiranja:ClassMap<SpoljniSaradnik>
    {
        public SpoljniSaradnikMapiranja()
        {
            Table("SPOLJNI_SARADNIK");
            Id(x => x.IdSpoljnogSaradnika, "ID_SPOLJNOG_SARADNIKA").GeneratedBy.TriggerIdentity();
            Map(x => x.BrUgovoraODelu, "BR_UGOVORA_O_DELU");

            References(x => x.Nadzornik).Column("ID_NADZORNIKA").LazyLoad();

        }
    }
}
