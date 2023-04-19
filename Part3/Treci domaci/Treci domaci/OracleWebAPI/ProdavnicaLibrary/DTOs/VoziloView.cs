using System;
using System.Collections.Generic;
using System.Text;

namespace PuteviLibrary.DTOs
{
    public class VoziloView
    {
        public int IdVozila { get; set; }
        public string RegistarskaOznaka { get; set; }
        public string TipGoriva { get; set; }
        public string Boja { get; set; }
        public int RadnaZapremina  { get; set; }

        public VoziloView(int id, string ro, string tip, string bo, int rz)
        {
            this.IdVozila = id;
            this.RegistarskaOznaka = ro;
            this.TipGoriva = tip;
            this.Boja = bo;
            this.RadnaZapremina = rz;

        }

        public VoziloView()
        {

        }
    }
}
