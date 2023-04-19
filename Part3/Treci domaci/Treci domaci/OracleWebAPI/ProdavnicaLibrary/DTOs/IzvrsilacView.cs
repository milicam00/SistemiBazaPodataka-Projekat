using System;
using System.Collections.Generic;
using System.Text;

namespace PuteviLibrary.DTOs
{
    public class IzvrsilacView
    {
        public int IdRadnika { get; set; }
        public String GodinaRodjenja { get; set; }
        public String Adresa { get; set; }
        public String Jmbg { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public String OcevoIme { get; set; }

        public IzvrsilacView(int id, String gr, String a, String j, String i, String p, String oi)
        {
            this.IdRadnika = id;
            this.GodinaRodjenja = gr;
            this.OcevoIme = oi;
            this.Adresa = a;
            this.Jmbg = j;
            this.Ime = i;
            this.Prezime = p;
        }
        public IzvrsilacView()
        {

        }
    }
}
