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
using Parcial.Model;
namespace Parcial
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }

        private void administrarBeneficiariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loguin frmL = new Loguin();
            frmL.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (GobEntities con = new GobEntities())
            {
                var lista = from Beneficiados in con.Beneficiados
                            where Beneficiados.Dui == txtDuiU.Text
                            select Beneficiados;
                if (lista.Count() > 0)
                {
                    MessageBox.Show("El Gobierno de El Salvador le informa que ha sido beneficiado/a" +
                        "favor de presentarse con su Dui al Banco de Fomento Agropecuario o consultar su cuenta de banco"
                        );
                }

                else
                {
                    MessageBox.Show("Lo sentimos, no ha sido beneficiado/a o el numero de Dui no es correcto "
                        +"Favor de Verificarlo o intentelo en otro momento");
                }
            }

        }
    }
}
