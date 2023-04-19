using System;
using System.Collections.Generic;
using System.Text;

namespace PuteviLibrary.DTOs
{
    public class TeretnaView
    {
        public int IdVozila { get; set; }
        public string RegistarskaOznaka { get; set; }
        public string TipGoriva { get; set; }
        public string Boja { get; set; }
        public int ZapreminaMotora { get; set; }
        public int Nosivost { get; set; }
        public int BrojOsovina { get; set; }

        public TeretnaView(int id, string ro, string tg, string b, int zm, int nosivost, int brojosovina)
        {


            this.IdVozila = id;
            this.RegistarskaOznaka = ro;
            this.TipGoriva = tg;
            this.Boja = b;
            this.ZapreminaMotora = zm;
            this.Nosivost = nosivost;
            this.BrojOsovina = brojosovina;
        }
        public TeretnaView()
        {

        }
    }
}
