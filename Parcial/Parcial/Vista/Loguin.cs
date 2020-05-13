using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial.Vista;

namespace Parcial.Vista
{
    public partial class Loguin : Form
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void btnEntrarL_Click(object sender, EventArgs e)
        {
           
            if ((txtUsuarioL.Text == "Master")&&(txtContraL.Text=="AdminMaster"))
            {
                MessageBox.Show("Bienvenido " + txtUsuarioL.Text);
                Hide();
                Beneficiarios frmB = new Beneficiarios();
                frmB.Show();
            }

        }
    }
}
