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
            String strSql = "SELECT TOP 20 * FROM bugs WHERE 1=1";
            //Clase Dictionary<TKey,TValue>: Representa una colección de claves (TKey)
            //y valores (TValue).
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            DateTime fechaDesde;
            DateTime fechaHasta;
            if (DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) &&
                DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {
                strSql += " AND (fecha_alta>=@fechaDesde AND fecha_alta<=@fechaHasta)";
                parametros.Add("fechaDesde", txtFechaDesde.Text);
                parametros.Add("fechaHasta", txtFechaHasta.Text);
            }

            if (!string.IsNullOrEmpty(cboEstados.Text))
            {
                var idEstado = cboEstados.SelectedValue.ToString();
                strSql += "AND (id_estado=@idEstado)";
                parametros.Add("idEstado", idEstado);
            }

            if (!string.IsNullOrEmpty(cboAsignadoA.Text))
            {
                var asignadoA = cboAsignadoA.SelectedValue.ToString();
                strSql += "AND (id_usuario_asignado=@idUsuarioAsignado)";
                parametros.Add("idUsuarioAsignado", asignadoA);
            }

            //Resto de las validaciones

            if (!string.IsNullOrEmpty(cboPrioridades.Text))
            {
                var idPrioridad = cboPrioridades.SelectedValue.ToString();
                strSql += "AND (id_prioridad=@idPrioridad)";
                parametros.Add("idPrioridad", idPrioridad);
            }

            if (!string.IsNullOrEmpty(cboCriticidades.Text))
            {
                var idcritiricidad = cboCriticidades.SelectedValue.ToString();
                strSql += "AND (id_criticidad=@idCritricidad)";
                parametros.Add("idCritricidad", idcritiricidad);
            }

            if (!string.IsNullOrEmpty(cboProductos.Text))
            {
                var idProducto = cboProductos.SelectedValue.ToString();
                strSql += "AND (id_producto=@idProducto)";
                parametros.Add("idProducto", idProducto);
            }

            strSql += "ORDER BY fecha_alta DESC";
            dgvBugs.DataSource = DataManager.GetInstance().ConsultaSQL(strSql, parametros);

            if (dgvBugs.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, String display, String value)
        {
            //DataSource: establece el origen de datos de este objeto
            cbo.DataSource = source;

            //DisplayMember: establece la propiedad que se va a mostrar para este ListControl
            cbo.DisplayMember = display;

            //ValueMember: establece la ruta de acceso de la propiedad que se utilizara
            //como valor real para los elementos de ListControl
            cbo.ValueMember = value;

            //SelectedIndex: establece el indice que especifica el elemento seleccionado
            //actualmente
            cbo.SelectedIndex = -1;
        }

        private void frmConsultaBugs_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboEstados, DataManager.GetInstance().ConsultaSQL("Select * from Estados"), "nombre", "id_estado");

            LlenarCombo(cboPrioridades, DataManager.GetInstance().ConsultaSQL("Select * from Prioridades"), "nombre", "id_prioridad");

            LlenarCombo(cboCriticidades, DataManager.GetInstance().ConsultaSQL("Select * from Criticidades"), "nombre", "id_criticidad");

            LlenarCombo(cboAsignadoA, DataManager.GetInstance().ConsultaSQL("Select * from Usuarios"), "nombre", "id_usuario");

            LlenarCombo(cboProductos, DataManager.GetInstance().ConsultaSQL("Select * from Productos"), "nombre", "id_producto");
        }


    }
}
