using System;
using System.Collections.Generic;
using System.Text;

namespace PuteviLibrary.DTOs
{
    public class DeonicaView
    {
        public int IdDeonice { get; set; }
        public int OdKilometra { get; set; }
        public int DoKilometra { get; set; }
        public string OdGrada { get; set; }
        public string DoGrada { get; set; }

        public int IdIzvrsioca { get; set; }
        public int IdGradiliste { get; set; }
        public DateTime DatumOd { get; set; }



        public DeonicaView(int id, int ok, int dk, string og, string dg, int idI, int idG, DateTime datumod)
        {
            this.IdDeonice = id;
            this.OdKilometra = ok;
            this.DoKilometra = dk;
            this.OdGrada = og;
            this.DoGrada = dg;
            this.IdIzvrsioca = idI;
            this.IdGradiliste = idG;
            this.DatumOd = datumod;
        }
        public DeonicaView()
        {

        }
    }
}
