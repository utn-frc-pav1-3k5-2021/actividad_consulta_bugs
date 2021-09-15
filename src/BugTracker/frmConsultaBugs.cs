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
            //consulto los 20 primeros registros de la tabla bugs
            string strSql = "SELECT TOP 20 * FROM bugs WHERE 1=1 ";

            //creo el diccionario parametros
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            //creo 2 variables 
            DateTime fechaDesde;
            DateTime fechaHasta;

            
            //Convierte una cadena de fecha y hora en su equivalente DateTime y devuelve un valor si la pudo convertir
            if (DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) &&
                DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {
                //concateno a la consulta los filtros de las fechas
                //tener en cuenta que los parámetros van precedidos de un @
                strSql += " AND (fecha_alta >= @fechaDesde AND fecha_alta <= @fechaHasta) ";

                //agrego al diccionario objetos
                parametros.Add("fechaDesde", fechaDesde);
                parametros.Add("fechaHasta", fechaHasta);
            }

            
            //Si el cboEstados no está vacio o nulo
            if (!string.IsNullOrEmpty(cboEstados.Text))
            {
                var idEstado = cboEstados.SelectedValue.ToString();
                strSql += "AND (id_estado = @idEstado) ";
                parametros.Add("idEstado", idEstado);
            }

            if (!string.IsNullOrEmpty(cboAsignadoA.Text))
            {
                var asignadoA = cboAsignadoA.SelectedValue.ToString();
                strSql += "AND (id_usuario_asignado=@idUsuarioAsignado) ";
                parametros.Add("idUsuarioAsignado", asignadoA);
            }

            if (!string.IsNullOrEmpty(cboPrioridades.Text))
            {
                var idPrioridad = cboPrioridades.SelectedValue.ToString();
                strSql += "AND (id_prioridad = @idPrioridad)";
                parametros.Add("idPrioridad", idPrioridad);
            }

            if (!string.IsNullOrEmpty(cboCriticidades.Text))
            {
                var idCriticidad = cboCriticidades.SelectedValue.ToString();
                strSql += "AND (id_criticidad = @idCriticidad)";
                parametros.Add("idCriticidad",idCriticidad);

            }

            if (!string.IsNullOrEmpty(cboProductos.Text))
            {
                var idProducto = cboProductos.SelectedValue.ToString();
                strSql += "AND (id_producto = @idProducto)";
                parametros.Add("idProducto", idProducto);
            }

            
            //ordeno la consulta por fecha de más reciente a más antiguo
            strSql += " ORDER BY fecha_alta DESC";
            
            //lleno el dgv con los datos obtenidos de la consulta
            dgvBugs.DataSource = DataManager.GetInstance().ConsultaSQL(strSql, parametros);

            //si el dgv tiene 0 filas muestro el mensaje de que no hay coincidencias para la consulta
            if (dgvBugs.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        } 

        //Objeto que quiero modificar, lista de valores que quiero agregar, lo que muestra, id del valor 
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            // En este caso es un DataTable que devuelve el método ConsultaSQL
            cbo.DataSource = source;

            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            // Es una cadena que especifica el nombre de la propiedad
            cbo.DisplayMember = display;

            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            // siempre es conveniente utilizar los PK de la tabla
            cbo.ValueMember = value;

            // SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            // es decir, el que va a figurar en el comboBox cuando se abra el formulario.
            cbo.SelectedIndex = -1;
        }

        private void frmConsultaBugs_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboEstados, DataManager.GetInstance().ConsultaSQL("Select * from Estados"), "nombre", "id_estado");

            LlenarCombo(cboPrioridades, DataManager.GetInstance().ConsultaSQL("Select * from Prioridades"), "nombre", "id_prioridad");

            LlenarCombo(cboCriticidades, DataManager.GetInstance().ConsultaSQL("Select * from Criticidades"), "nombre", "id_criticidad");

            LlenarCombo(cboAsignadoA, DataManager.GetInstance().ConsultaSQL("Select * from Usuarios"), "usuario", "id_usuario");

            LlenarCombo(cboProductos, DataManager.GetInstance().ConsultaSQL("Select * from Productos"), "nombre", "id_producto");
        }
    }
}
