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
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            String consulta = "Select top 20 * from bugs where 1=1 ";
            DateTime fechaDesde;
            DateTime fechaHasta;

            if (!DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) ||
                !DateTime.TryParse(txtFechaHasta.Text, out fechaHasta) )
            {
                MessageBox.Show("Debe ingresar correctamente las fechas de búsqueda!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                consulta += "AND fecha_alta>=@fechaDesde AND fecha_alta<=@fechaHasta ";
                parametros.Add("fechaDesde", fechaDesde);
                parametros.Add("fechaHasta", fechaHasta);


                // agregamos el estado a si corresponde
                if (!String.IsNullOrEmpty(cboEstados.Text))
                {
                    consulta += "AND id_estado=@idEstdo";
                    parametros.Add("idEstado", cboEstados.SelectedValue.ToString());
                }

                // agregamos el asignado a si corresponde
                if (!String.IsNullOrEmpty(cboAsignadoA.Text))
                {
                    consulta += "AND id_usuario=@idUsuario";
                    parametros.Add("idUsuario", cboAsignadoA.SelectedValue.ToString());
                }

                // agregamos la criticidad si corresponde
                if (!String.IsNullOrEmpty(cboCriticidades.Text))
                {
                    consulta += "AND id_criticidad=@idCriticidad";
                    parametros.Add("idCriticidad", cboCriticidades.SelectedValue.ToString());
                }

                // agregamos la prioridad a si corresponde
                if (!String.IsNullOrEmpty(cboPrioridades.Text))
                {
                    consulta += "AND id_prioridad=@idPrioridad";
                    parametros.Add("idPrioridad", cboPrioridades.SelectedValue.ToString());
                }

                // agregamos el producto a si corresponde
                if (!String.IsNullOrEmpty(cboProductos.Text))
                {
                    consulta += "AND id_producto=@idProducto";
                    parametros.Add("idProducto", cboProductos.SelectedValue.ToString());
                }

                consulta += " ORDER BY fecha_alta DESC";
                MessageBox.Show("Consulta a ejecutar: " + consulta, "Info", MessageBoxButtons.OK);

                dgvBugs.DataSource = DataManager.GetInstance().ConsultaSQL(consulta);

                if (dgvBugs.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }

        private void frmConsultaBugs_Load(object sender, EventArgs e)
        {

            LlenarCombo(cboEstados, DataManager.GetInstance().ConsultaSQL("Select * from estados"), "Estado", "id_estado");
            LlenarCombo(cboAsignadoA, DataManager.GetInstance().ConsultaSQL("Select * from usuarios"), "nombre", "id_usuario");
            LlenarCombo(cboCriticidades, DataManager.GetInstance().ConsultaSQL("Select * from criticidades"), "nombre", "id_criticidad");
            LlenarCombo(cboPrioridades, DataManager.GetInstance().ConsultaSQL("Select * from prioridades"), "nombre", "id_prioridad");
            LlenarCombo(cboProductos, DataManager.GetInstance().ConsultaSQL("Select * from productos"), "nombre", "id_producto");
        }

    }
}
