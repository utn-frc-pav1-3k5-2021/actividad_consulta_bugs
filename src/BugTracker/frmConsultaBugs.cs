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
    public partial class frmConsultaBugs : Form
    {
        public frmConsultaBugs()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void llenarCombo(ComboBox cbo,Object source, string display,string value)
        {
            //Datasource establece el origen de datos
            cbo.DataSource = source;

            //DisplayMember Establece la propiedad que se va a mostrar para este ListControl
            cbo.DisplayMember = display;

            //ValueMember Establece la ruta de acceso de la propiedad que se utilizara como valor real para los elementos de ListControl
            cbo.ValueMember = value;

            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }

        private void frmConsultaBugs_Load(object sender, EventArgs e)
        {
            llenarCombo(cboEstados, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Estados"), "nombre", "id_estado");

            llenarCombo(cboAsignadoA, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Usuarios"), "nombre", "id_usuario");

            llenarCombo(cboPrioridades, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Prioridades"), "nombre", "id_prioridad");

            llenarCombo(cboCriticidades, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Criticidades"), "nombre", "id_criticidad");

            llenarCombo(cboProductos, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Productos"), "nombre", "id_producto");
        }
    }
}
