using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            //creo un formulario login
            frmLogin login = new frmLogin();

            //abro el formulario
            login.ShowDialog();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cuando se quiera salir va a preguntar si está seguro que desea salir
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            //si el usuario selecciono No, se cancela el evento. 
            if (rpta == DialogResult.No)
                e.Cancel = true;
        }

        private void consultarBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Creo el formulario ConsultaBugs y lo abro.
            frmConsultaBugs frmDetalle = new frmConsultaBugs();
            frmDetalle.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cerrar el formulario actual
            this.Close();
        }
    }
}
