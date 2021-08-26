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
            //Comando SQL base
            string stringComando = "SELECT TOP 20 * FROM Bugs WHERE 1=1 ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            //Añadir limites de fecha
            DateTime fechaDesde, fechaHasta;
            if(DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) && DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {
                stringComando += "AND (fecha_alta>=@fechaDesde AND fecha_alta<=@fechaHasta) ";
                parametros.Add("fechaHasta", txtFechaHasta.Text);
                parametros.Add("fechaDesde", txtFechaDesde.Text);
            }

            //Estados
            if(!string.IsNullOrEmpty(cboEstados.Text))
            {
                var idEstado = cboEstados.SelectedValue.ToString();
                stringComando += "AND (id_estado=@idEstado) ";
                parametros.Add("idEstado", idEstado);
            }

            //Prioridades
            if(!string.IsNullOrEmpty(cboPrioridades.Text))
            {
                var idPrioridades = cboPrioridades.SelectedValue.ToString();
                stringComando += "AND (id_prioridad=@idPrioridad) ";
                parametros.Add("idPrioridad", idPrioridades);
            }

            //Criticidades
            if(!string.IsNullOrEmpty(cboCriticidades.Text))
            {
                var idCriticidades = cboCriticidades.SelectedValue.ToString();
                stringComando += "AND (id_criticidad)=@idCriticidades ";
                parametros.Add("idCriticidades", idCriticidades);
            }

            //Asignado
            if (!string.IsNullOrEmpty(cboAsignadoA.Text))
            {
                var idAsignado = cboAsignadoA.SelectedValue.ToString();
                stringComando += "AND (id_usuario_asignado)=@idAsignado ";
                parametros.Add("idAsignado", idAsignado);
            }

            //Productos
            if (!string.IsNullOrEmpty(cboProductos.Text))
            {
                var idProducto = cboProductos.SelectedValue.ToString();
                stringComando += "AND (id_producto)=@idProducto ";
                parametros.Add("idProducto", idProducto);
            }

            //Ordenar por fecha
            stringComando += "ORDER BY fecha_alta DESC";

            //Hace la consulta
            dgvBugs.DataSource = DataManager.GetInstance().ConsultaSQL(stringComando, parametros);

            if (dgvBugs.Rows.Count == 0)
                MessageBox.Show("No existen coincidencias para los filtros seleccionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmConsultaBugs_Load(object sender, EventArgs e)
        {
            //LLenar las comboBox con los datos
            LLenarComboBox(cboEstados, DataManager.GetInstance().ConsultaSQL("Select * from Estados"), "nombre", "id_estado");

            LLenarComboBox(cboPrioridades, DataManager.GetInstance().ConsultaSQL("Select * from Prioridades"), "nombre", "id_prioridad");

            LLenarComboBox(cboCriticidades, DataManager.GetInstance().ConsultaSQL("Select * from Criticidades"), "nombre", "id_criticidad");

            LLenarComboBox(cboAsignadoA, DataManager.GetInstance().ConsultaSQL("Select * from Usuarios"), "usuario", "id_usuario");

            LLenarComboBox(cboProductos, DataManager.GetInstance().ConsultaSQL("Select * from Productos"), "nombre", "id_producto");

        }

        private void LLenarComboBox(ComboBox comboBox, Object fuente, string nombre, String valor)
        {
            comboBox.DataSource = fuente;
            comboBox.DisplayMember = nombre;
            comboBox.ValueMember = valor;
            comboBox.SelectedIndex = -1;
        }
    }
}
