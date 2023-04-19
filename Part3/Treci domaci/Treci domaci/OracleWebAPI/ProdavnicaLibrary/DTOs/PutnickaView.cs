using System;
using System.Collections.Generic;
using System.Text;

namespace PuteviLibrary.DTOs
{ 
    public class PutnickaView
    {
        public int IdVozila { get; set; }
        public string RegistarskaOznaka { get; set; }
        public string TipGoriva { get; set; }
        public string Boja { get; set; }
        public int ZapreminaMotora { get; set; }
        public int BrojMesta { get; set; }

        public PutnickaView(int id, string ro, string tg, string b, int zm, int bm)
        {
            this.IdVozila = id;
            this.RegistarskaOznaka = ro;
            this.TipGoriva = tg;
            this.Boja = b;
            this.ZapreminaMotora = zm;
            this.BrojMesta = bm;
        }
        public PutnickaView()
        {

        }
    }
}
