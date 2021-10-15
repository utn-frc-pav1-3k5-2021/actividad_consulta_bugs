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
            string strSql = "select top 20 * from bugs where 1=1";
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            DateTime fechaDesde;
            DateTime fechaHasta;

            if(DateTime.TryParse(txtFechaDesde.Text, out fechaDesde)&& DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {
                strSql += "and (fecha_alta>=@fechaDesde anf fecha_alta<=@fechaHasta)";
                parametros.Add("fechaDesde", txtFechaDesde.Text);
                parametros.Add("fechaHasta", txtFechaHasta.Text);
            }

            if(!string.IsNullOrEmpty(cboEstados.Text))
            {
                var idEstado = cboEstados.SelectedValue.ToString();
                strSql += "And (id_estado=@idEstado)";
                parametros.Add("idEstado", idEstado);
            }
            if (!string.IsNullOrEmpty(cboAsignadoA.Text))
            {
                var asignadoA = cboAsignadoA.SelectedValue.ToString();
                strSql += "And (id_usuario_asignado=@idUsuarioAsignado)";
                parametros.Add("idUsuarioAsignado", asignadoA);
            }

            strSql += "order by fecha_alta desc";
            dgvBugs.DataSource = DataManager.GetInstance().ConsultaSQL(strSql, parametros);

            if(dgvBugs.Rows.Count==0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        { // el datasourse determina el origen de los datos del objeto
            cbo.DataSource = source;
            // displaymember establece la propiedad que se va a mostrar para este listctontrol
            cbo.DisplayMember = display;
            //valuemember establece la ruta de acceso que se utilizará como valor real
            cbo.ValueMember = value;
            // selected index establece el índice que especifica el elemento seleccionado actualmente
            cbo.SelectedItem = -1;

        }

        private void frmBugs_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboEstados, DataManager.GetInstance().ConsultaSQL("Select * from dbo.Estados"), "nombre", "id_estado");
            LlenarCombo(cboPrioridades, DataManager.GetInstance().ConsultaSQL("Select * from dbo.Prioridades"), "nombre", "id_prioridad");
            LlenarCombo(cboCriticidades, DataManager.GetInstance().ConsultaSQL("Select * from dbo.Criticidades"), "nombre", "id_criticidades");
            LlenarCombo(cboAsignadoA, DataManager.GetInstance().ConsultaSQL("Select * from dbo.Usuarios"), "usuario", "id_usuario");
            LlenarCombo(cboProductos, DataManager.GetInstance().ConsultaSQL("Select * from dbo.Productos"), "nombre", "id_producto");
        }
    }
}
