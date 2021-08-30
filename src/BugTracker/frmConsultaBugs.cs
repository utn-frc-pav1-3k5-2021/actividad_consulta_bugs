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
            string strSql = "SELECT TOP 20 * FROM bugs WHERE 1=1";
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            DateTime fecheDesde;
            DateTime fechaHasta;

            //DateTime.tryParse Intenta transformar una fecha en formato string a DateTime y si puede, devuelve true
            if(DateTime.TryParse(txtFechaDesde.Text, out fecheDesde) && DateTime.TryParse(txtFechaHasta.Text, out fechaHasta)) {

                strSql += " AND (fecha_alta>=@fechaDesde AND fecha_alta<=@fechaHasta) ";
                parametros.Add("fechaDesde", txtFechaDesde.Text);
                parametros.Add("fechaHasta", txtFechaHasta.Text);
            }

            //Chequeo de combos
            if (!string.IsNullOrEmpty(cboEstados.Text)) {
                var idEstado = cboEstados.SelectedValue.ToString();
                strSql += " AND id_estado=@idEstado ";
                parametros.Add("idEstado", idEstado);
            }

            if (!string.IsNullOrEmpty(cboAsignadoA.Text))
            {
                var idAsignacion = cboAsignadoA.Text.ToString();
                strSql += " AND id_usuario_asignado=@idAsignacion ";
                parametros.Add("idAsignacion", idAsignacion);
            }

            if (!string.IsNullOrEmpty(cboPrioridades.Text))
            {
                var idPrioridad = cboPrioridades.SelectedValue.ToString();
                strSql += " AND id_prioridad=@idPrioridad ";
                parametros.Add("idPrioridad", idPrioridad);
            }

            if (!string.IsNullOrEmpty(cboCriticidades.Text))
            {
                var idCriticidad = cboCriticidades.SelectedValue.ToString();
                strSql += " AND id_criticidad=@idCriticidad ";
                parametros.Add("idCriticidad", idCriticidad);
            }

            if (!string.IsNullOrEmpty(cboProductos.Text))
            {
                var idProducto = cboProductos.SelectedValue.ToString();
                strSql += " AND id_producto=@idProducto ";
                parametros.Add("idProducto", idProducto);
            }

            strSql += " ORDER BY fecha_alta DESC";

            //Cargar DataGridView con el dataSource de la consulta

            dgvBugs.DataSource = DataManager.GetInstance().ConsultaSQL(strSql, parametros);

            if (dgvBugs.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


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
