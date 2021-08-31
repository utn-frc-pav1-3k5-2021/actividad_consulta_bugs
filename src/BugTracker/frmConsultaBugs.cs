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

            string strSQL = "Select top 20 * From bugs Where 1=1";

            Dictionary<string, object> parametros = new Dictionary<string, object>();

            DateTime fechaDesde;
            DateTime fechaHasta;

            if(DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) && DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {

                strSQL += " AND (fecha_alta >= @fechaDesde AND fecha_alta <= @fechaHasta) ";

                parametros.Add("fechaDesde", fechaDesde);
                parametros.Add("fechaHasta", fechaHasta);

            }

            if (!String.IsNullOrEmpty(cboEstados.Text))
            {

                var idEstado = cboEstados.SelectedValue.ToString();
                strSQL += "AND (id_estado = @idEstado)";
                parametros.Add("idEstado", idEstado);

            }

            if (!String.IsNullOrEmpty(cboAsignadoA.Text))
            {

                var asignadoA = cboAsignadoA.SelectedValue.ToString();
                strSQL += " AND (id_usuario_asignado = @idUsuarioAsignado)";
                parametros.Add("idUsuarioAsignado", asignadoA);

            }

            if (!String.IsNullOrEmpty(cboCriticidades.Text))
            {

                var criticidad = cboCriticidades.SelectedValue.ToString();
                strSQL += "AND (id_criticidad = @idCriticidad)";
                parametros.Add("idCriticidad", criticidad);

            }

            if (!String.IsNullOrEmpty(cboPrioridades.Text))
            {

                var prioridad = cboPrioridades.SelectedValue.ToString();
                strSQL += "AND (id_prioridad = @idPrioridad)";
                parametros.Add("idPrioridad", prioridad);

            }

            if (!String.IsNullOrEmpty(cboProductos.Text))
            {

                var prod = cboProductos.SelectedValue.ToString();
                strSQL += "AND (id_producto = @idProducto)";
                parametros.Add("IdProducto", prod);

            }


            strSQL += "Order by fecha_alta Desc";

            dgvBugs.DataSource = DataManager.GetInstance().ConsultaSQL(strSQL, parametros);


            if(dgvBugs.Rows.Count == 0)
            {

                MessageBox.Show("No se encontraron coincidencia para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {

            // DataSource: establece el origen de datos de este objeto.
            cbo.DataSource = source;

            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;

            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;

            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;

        }

        private void frmBugs_Load(object sender, EventArgs e)
        {

            LlenarCombo(cboEstados, DataManager.GetInstance().ConsultaSQL("Select * From Estados"), "nombre", "id_estado");

            LlenarCombo(cboPrioridades, DataManager.GetInstance().ConsultaSQL("Select * From Prioridades"), "nombre", "id_prioridad");

            LlenarCombo(cboProductos, DataManager.GetInstance().ConsultaSQL("Select * From Productos"), "nombre", "id_producto");

            LlenarCombo(cboCriticidades, DataManager.GetInstance().ConsultaSQL("Select * From Criticidades"), "nombre", "id_criticidad");

            LlenarCombo(cboAsignadoA, DataManager.GetInstance().ConsultaSQL("Select * From Usuarios"), "usuario", "id_usuario");

        }



    }
}
