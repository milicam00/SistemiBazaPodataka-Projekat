using System;
using System.Collections.Generic;
using System.Text;

namespace PuteviLibrary.DTOs
{
    public class SpoljniSaradnikView
    {
        public int IdSpoljnogSaradnika { get; set; }
        public int BrUgovoraODelu { get; set; }
        public virtual int Nadzornik { get; set; }
        public SpoljniSaradnikView() { }
        public SpoljniSaradnikView(int id, int br)
        {
            this.IdSpoljnogSaradnika = id;
            this.BrUgovoraODelu = br;
        }
        public SpoljniSaradnikView(int id, int buod, int idN)
        {
            this.IdSpoljnogSaradnika = id;
            this.BrUgovoraODelu = buod;
            this.Nadzornik = idN;

        }
       
    }
}
