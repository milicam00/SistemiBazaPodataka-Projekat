using OdrzavanjePuteva.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
namespace OdrzavanjePuteva
{
    public partial class SpoljniSaradnikDodaj : Form
    {
        public SpoljniSaradnikDodaj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            SpoljniSaradnik spoljni = new SpoljniSaradnik();
            spoljni.BrUgovoraODelu = Convert.ToInt32(txtB.Text);
            spoljni.Nadzornik = DTOManager.GetNadzornik(cbxNad.SelectedItem.ToString());
            listBox1.Refresh();
            s.Save(spoljni);
            s.Close();
           // listBox1.Refresh();
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void SpoljniSaradnikDodaj_Load(object sender, EventArgs e)
        {
            
            
            cbxNad.Items.Clear();
            List<Nadzornik> nad = DTOManager.GetNadzornici();

     

            foreach (Nadzornik op in nad)
            {
                cbxNad.Items.Add($"{op.Jmbg}");
                listBox1.Items.Add($"{op.Ime} {op.Prezime} {op.Jmbg}");
            }
            cbxNad.Refresh();
            listBox1.Refresh();

        }
    }
}
