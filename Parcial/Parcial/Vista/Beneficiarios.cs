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

namespace Parcial.Vista
{
    public partial class Beneficiarios : Form
    {
        public Beneficiarios()

        {
            InitializeComponent();
        }
        void CargarDatos()
        {
            using (GobEntities con = new GobEntities())
                dgvBeneficiadosB.DataSource = con.Beneficiados.ToList();
        }
        Beneficiados Ben = new Beneficiados();
       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminarB_Click(object sender, EventArgs e)
        {
            using (GobEntities con = new GobEntities())
            {
                String Id = dgvBeneficiadosB.CurrentRow.Cells[0].Value.ToString();
                Ben = con.Beneficiados.Find(int.Parse(Id));
                con.Beneficiados.Remove(Ben);
                con.SaveChanges();
            }
            CargarDatos();

        }

        private void Beneficiarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnActualizarB_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (GobEntities con = new GobEntities())
            {
                String Id = dgvBeneficiadosB.CurrentRow.Cells[0].Value.ToString();
                int Idc = int.Parse(Id);
                Ben = con.Beneficiados.Where(VerificarID => VerificarID.Id == Idc).First();
                Ben.Nombre = txtNombreB.Text;
                Ben.Dui = txtDuiB.Text;
                Ben.Id = Convert.ToInt32(txtIdB.Text);
                con.Entry(Ben).State = System.Data.Entity.EntityState.Modified;
                con.SaveChanges();
            }
            CargarDatos();
            MessageBox.Show("Se han guardado los cambios");
        }

        private void ingresarBeneficiadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ingresar frmI = new Ingresar();
            frmI.Show();
        }
    }
}
