using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PuteviLibrary.Entiteti;


namespace PuteviLibrary.Mapiranja
{
    public class GradilisteMapiranja:ClassMap<Gradiliste>
    {
        public GradilisteMapiranja()
        {
            Table("GRADILISTE");
            Id(x => x.IdGradilista, "GRADILISTEID").GeneratedBy.TriggerIdentity();
            Map(x => x.Tip, "TIP");

            HasMany(x => x.Deonice).KeyColumn("IDGRADILISTA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
