
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.cboCriticidades = new System.Windows.Forms.ComboBox();
            this.cboAsignadoA = new System.Windows.Forms.ComboBox();
            this.cboPrioridades = new System.Windows.Forms.ComboBox();
            this.txtFechaDesde = new System.Windows.Forms.TextBox();
            this.txtFechaHasta = new System.Windows.Forms.TextBox();
            this.dgvBugs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asignado a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prioridad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha hasta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Criticidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha desde:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Producto";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(647, 180);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // cboEstados
            // 
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(101, 89);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(226, 23);
            this.cboEstados.TabIndex = 11;
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(435, 122);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(238, 23);
            this.cboProductos.TabIndex = 12;
            // 
            // cboCriticidades
            // 
            this.cboCriticidades.FormattingEnabled = true;
            this.cboCriticidades.Location = new System.Drawing.Point(435, 89);
            this.cboCriticidades.Name = "cboCriticidades";
            this.cboCriticidades.Size = new System.Drawing.Size(238, 23);
            this.cboCriticidades.TabIndex = 13;
            // 
            // cboAsignadoA
            // 
            this.cboAsignadoA.FormattingEnabled = true;
            this.cboAsignadoA.Location = new System.Drawing.Point(101, 122);
            this.cboAsignadoA.Name = "cboAsignadoA";
            this.cboAsignadoA.Size = new System.Drawing.Size(226, 23);
            this.cboAsignadoA.TabIndex = 14;
            // 
            // cboPrioridades
            // 
            this.cboPrioridades.FormattingEnabled = true;
            this.cboPrioridades.Location = new System.Drawing.Point(101, 151);
            this.cboPrioridades.Name = "cboPrioridades";
            this.cboPrioridades.Size = new System.Drawing.Size(226, 23);
            this.cboPrioridades.TabIndex = 15;
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(101, 52);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(226, 23);
            this.txtFechaDesde.TabIndex = 16;
            this.txtFechaDesde.Text = "__/__/____";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(435, 52);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(238, 23);
            this.txtFechaHasta.TabIndex = 17;
            this.txtFechaHasta.Text = "__/__/____";
            // 
            // dgvBugs
            // 
            this.dgvBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugs.Location = new System.Drawing.Point(32, 209);
            this.dgvBugs.Name = "dgvBugs";
            this.dgvBugs.RowTemplate.Height = 25;
            this.dgvBugs.Size = new System.Drawing.Size(753, 204);
            this.dgvBugs.TabIndex = 18;
            // 
            // frmConsultaBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 448);
            this.Controls.Add(this.dgvBugs);
            this.Controls.Add(this.txtFechaHasta);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.cboPrioridades);
            this.Controls.Add(this.cboAsignadoA);
            this.Controls.Add(this.cboCriticidades);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConsultaBugs";
            this.Text = "Consultar Bugs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.ComboBox cboCriticidades;
        private System.Windows.Forms.ComboBox cboAsignadoA;
        private System.Windows.Forms.ComboBox cboPrioridades;
        private System.Windows.Forms.TextBox txtFechaDesde;
        private System.Windows.Forms.TextBox txtFechaHasta;
        private System.Windows.Forms.DataGridView dgvBugs;
    }
}