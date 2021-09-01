namespace BugTracker
{
    partial class frmConsultaBugs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_filtros = new System.Windows.Forms.GroupBox();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.cboCriticidades = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboPrioridades = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboAsignadoA = new System.Windows.Forms.ComboBox();
            this.lbl_asignado = new System.Windows.Forms.Label();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.dgvBugs = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnl_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_filtros
            // 
            this.pnl_filtros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_filtros.Controls.Add(this.cboProductos);
            this.pnl_filtros.Controls.Add(this.Label5);
            this.pnl_filtros.Controls.Add(this.txtFechaHasta);
            this.pnl_filtros.Controls.Add(this.Label4);
            this.pnl_filtros.Controls.Add(this.Label3);
            this.pnl_filtros.Controls.Add(this.txtFechaDesde);
            this.pnl_filtros.Controls.Add(this.cboCriticidades);
            this.pnl_filtros.Controls.Add(this.Label1);
            this.pnl_filtros.Controls.Add(this.cboPrioridades);
            this.pnl_filtros.Controls.Add(this.Label2);
            this.pnl_filtros.Controls.Add(this.btnConsultar);
            this.pnl_filtros.Controls.Add(this.cboAsignadoA);
            this.pnl_filtros.Controls.Add(this.lbl_asignado);
            this.pnl_filtros.Controls.Add(this.cboEstados);
            this.pnl_filtros.Controls.Add(this.lbl_estado);
            this.pnl_filtros.Location = new System.Drawing.Point(14, 14);
            this.pnl_filtros.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_filtros.Name = "pnl_filtros";
            this.pnl_filtros.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnl_filtros.Size = new System.Drawing.Size(1050, 164);
            this.pnl_filtros.TabIndex = 1;
            this.pnl_filtros.TabStop = false;
            this.pnl_filtros.Text = "Filtros";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(435, 87);
            this.cboProductos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(210, 23);
            this.cboProductos.TabIndex = 15;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(364, 90);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(59, 15);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Producto:";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(436, 25);
            this.txtFechaHasta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFechaHasta.Mask = "00/00/0000";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(209, 23);
            this.txtFechaHasta.TabIndex = 13;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(352, 29);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(74, 15);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Fecha Hasta:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(4, 29);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 15);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Fecha desde:";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(89, 25);
            this.txtFechaDesde.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFechaDesde.Mask = "00/00/0000";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(210, 23);
            this.txtFechaDesde.TabIndex = 9;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // cboCriticidades
            // 
            this.cboCriticidades.FormattingEnabled = true;
            this.cboCriticidades.Location = new System.Drawing.Point(435, 55);
            this.cboCriticidades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCriticidades.Name = "cboCriticidades";
            this.cboCriticidades.Size = new System.Drawing.Size(210, 23);
            this.cboCriticidades.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(364, 59);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(61, 15);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Criticidad:";
            // 
            // cboPrioridades
            // 
            this.cboPrioridades.FormattingEnabled = true;
            this.cboPrioridades.Location = new System.Drawing.Point(89, 118);
            this.cboPrioridades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboPrioridades.Name = "cboPrioridades";
            this.cboPrioridades.Size = new System.Drawing.Size(210, 23);
            this.cboPrioridades.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 121);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 15);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Prioridad:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(940, 131);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(102, 27);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cboAsignadoA
            // 
            this.cboAsignadoA.FormattingEnabled = true;
            this.cboAsignadoA.Location = new System.Drawing.Point(89, 87);
            this.cboAsignadoA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboAsignadoA.Name = "cboAsignadoA";
            this.cboAsignadoA.Size = new System.Drawing.Size(210, 23);
            this.cboAsignadoA.TabIndex = 3;
            // 
            // lbl_asignado
            // 
            this.lbl_asignado.AutoSize = true;
            this.lbl_asignado.Location = new System.Drawing.Point(8, 90);
            this.lbl_asignado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_asignado.Name = "lbl_asignado";
            this.lbl_asignado.Size = new System.Drawing.Size(69, 15);
            this.lbl_asignado.TabIndex = 2;
            this.lbl_asignado.Text = "Asignado a:";
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(89, 55);
            this.cboEstados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(210, 23);
            this.cboEstados.TabIndex = 1;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(37, 59);
            this.lbl_estado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(45, 15);
            this.lbl_estado.TabIndex = 0;
            this.lbl_estado.Text = "Estado:";
            // 
            // dgvBugs
            // 
            this.dgvBugs.AllowUserToAddRows = false;
            this.dgvBugs.AllowUserToDeleteRows = false;
            this.dgvBugs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugs.Location = new System.Drawing.Point(14, 184);
            this.dgvBugs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvBugs.Name = "dgvBugs";
            this.dgvBugs.ReadOnly = true;
            this.dgvBugs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBugs.Size = new System.Drawing.Size(1050, 361);
            this.dgvBugs.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1080, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmConsultaBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 556);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvBugs);
            this.Controls.Add(this.pnl_filtros);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmConsultaBugs";
            this.Text = "Consultar Bugs";
            this.Load += new System.EventHandler(this.frmConsultaBugs_Load);
            this.pnl_filtros.ResumeLayout(false);
            this.pnl_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox pnl_filtros;
        internal System.Windows.Forms.ComboBox cboProductos;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.MaskedTextBox txtFechaHasta;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.MaskedTextBox txtFechaDesde;
        internal System.Windows.Forms.ComboBox cboCriticidades;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboPrioridades;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnConsultar;
        internal System.Windows.Forms.ComboBox cboAsignadoA;
        internal System.Windows.Forms.Label lbl_asignado;
        internal System.Windows.Forms.ComboBox cboEstados;
        internal System.Windows.Forms.Label lbl_estado;
        internal System.Windows.Forms.DataGridView dgvBugs;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}