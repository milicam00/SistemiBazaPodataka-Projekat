using System;
using System.Collections.Generic;
using System.Text;

namespace PuteviLibrary.DTOs
{ 
    public class RadneMasineView
    {
        public int IdVozila { get; set; }
        public string RegistarskaOznaka { get; set; }
        public string TipGoriva { get; set; }
        public string Boja { get; set; }
        public int ZapreminaMotora { get; set; }
        public String TipRadneMasine { get; set; }
        public string TipPogonaRadneMasine { get; set; }

        public RadneMasineView(int id, string ro, string tg, string b, int zm, string tipradnemasine, string tippogona)
        {



            this.IdVozila = id;
            this.RegistarskaOznaka = ro;
            this.TipGoriva = tg;
            this.Boja = b;
            this.ZapreminaMotora = zm;
            this.TipRadneMasine = tipradnemasine;
            this.TipPogonaRadneMasine = tippogona;
        }
        public RadneMasineView()
        {

        }
    }
}
