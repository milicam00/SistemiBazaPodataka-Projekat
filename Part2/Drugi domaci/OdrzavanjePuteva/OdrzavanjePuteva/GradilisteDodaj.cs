using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OdrzavanjePuteva.Entiteti;

namespace OdrzavanjePuteva
{
    public partial class GradilisteDodaj : Form
    {
        public GradilisteDodaj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gradiliste gradiliste = new Gradiliste();
            gradiliste.Tip = txtTip.Text;
            DTOManager.CreateGradiliste(gradiliste);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
