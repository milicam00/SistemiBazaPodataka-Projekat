using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuteviLibrary.Entiteti

{
    public class SpoljniSaradnik
    {
        public virtual int IdSpoljnogSaradnika { get; protected set; }
        public virtual int BrUgovoraODelu { get; set; }
        public virtual Radnik Nadzornik { get; set; }


    }
}
