using System;
using System.Collections.Generic;
using System.Text;

namespace PuteviLibrary.DTOs
{ 
    public class GradilisteView
    {
        public int IdGradilista { get; set; }
        public string Tip { get; set; }
        public GradilisteView(int id, string tip)
        {
            this.IdGradilista = id;
            this.Tip = tip;
        }
        public GradilisteView()
        {

        }
    }
}
