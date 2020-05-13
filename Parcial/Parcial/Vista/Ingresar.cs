using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial.Model;
using Parcial.Vista;
namespace Parcial.Vista
{
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }
      
        Beneficiados Ben = new Beneficiados();
        private void btnGuardarI_Click(object sender, EventArgs e)
        {
            {
                using (GobEntities con = new GobEntities())
                {
                    Ben.Id = Convert.ToInt32(txtIdI.Text);
                    Ben.Nombre = txtNombreI.Text;
                    Ben.Dui = txtDuiI.Text;
                    con.Beneficiados.Add(Ben);
                    con.SaveChanges();
                }
                MessageBox.Show("Se han guardado los cambios");
            }
        }
    }
}
