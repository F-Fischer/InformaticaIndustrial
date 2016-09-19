namespace InformaticaIndustrial.Vista
{
    partial class BomForm
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
            this.BomsGrid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.agregarBom = new System.Windows.Forms.Button();
            this.btnEliminarBom = new System.Windows.Forms.Button();
            this.btnVerArticulos = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.bom_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo_padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo_hijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.um_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semana_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semana_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkNroSemana = new System.Windows.Forms.CheckBox();
            this.cbNroFecha = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BomsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BomsGrid
            // 
            this.BomsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BomsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bom_id,
            this.articulo_padre,
            this.articulo_hijo,
            this.cantidad,
            this.um_id,
            this.fecha_inicio,
            this.semana_inicio,
            this.semana_fin,
            this.activo});
            this.BomsGrid.Location = new System.Drawing.Point(12, 12);
            this.BomsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BomsGrid.Name = "BomsGrid";
            this.BomsGrid.RowTemplate.Height = 24;
            this.BomsGrid.Size = new System.Drawing.Size(1032, 303);
            this.BomsGrid.TabIndex = 0;
            // 
            // agregarBom
            // 
            this.agregarBom.Location = new System.Drawing.Point(12, 321);
            this.agregarBom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregarBom.Name = "agregarBom";
            this.agregarBom.Size = new System.Drawing.Size(121, 42);
            this.agregarBom.TabIndex = 1;
            this.agregarBom.Text = "Agregar";
            this.agregarBom.UseVisualStyleBackColor = true;
            this.agregarBom.Click += new System.EventHandler(this.agregarBom_Click);
            // 
            // btnEliminarBom
            // 
            this.btnEliminarBom.Location = new System.Drawing.Point(260, 321);
            this.btnEliminarBom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarBom.Name = "btnEliminarBom";
            this.btnEliminarBom.Size = new System.Drawing.Size(115, 42);
            this.btnEliminarBom.TabIndex = 2;
            this.btnEliminarBom.Text = "Eliminar";
            this.btnEliminarBom.UseVisualStyleBackColor = true;
            this.btnEliminarBom.Click += new System.EventHandler(this.btnEliminarBom_Click);
            // 
            // btnVerArticulos
            // 
            this.btnVerArticulos.Location = new System.Drawing.Point(901, 321);
            this.btnVerArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerArticulos.Name = "btnVerArticulos";
            this.btnVerArticulos.Size = new System.Drawing.Size(143, 41);
            this.btnVerArticulos.TabIndex = 3;
            this.btnVerArticulos.Text = "Ver Articulos";
            this.btnVerArticulos.UseVisualStyleBackColor = true;
            this.btnVerArticulos.Click += new System.EventHandler(this.btnVerArticulos_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(140, 321);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(113, 42);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dpFecha
            // 
            this.dpFecha.Location = new System.Drawing.Point(401, 329);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(239, 22);
            this.dpFecha.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(677, 322);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(115, 41);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // bom_id
            // 
            this.bom_id.DataPropertyName = "bom_id";
            this.bom_id.HeaderText = "BOM ID";
            this.bom_id.Name = "bom_id";
            // 
            // articulo_padre
            // 
            this.articulo_padre.DataPropertyName = "articulo_padre";
            this.articulo_padre.HeaderText = "Articulo Padre";
            this.articulo_padre.Name = "articulo_padre";
            // 
            // articulo_hijo
            // 
            this.articulo_hijo.DataPropertyName = "articulo_hijo";
            this.articulo_hijo.HeaderText = "Articulo Hijo";
            this.articulo_hijo.Name = "articulo_hijo";
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // um_id
            // 
            this.um_id.DataPropertyName = "um_id";
            this.um_id.HeaderText = "Unidad de Medida";
            this.um_id.Name = "um_id";
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.DataPropertyName = "fecha_inicio";
            this.fecha_inicio.HeaderText = "Fecha Creación";
            this.fecha_inicio.Name = "fecha_inicio";
            // 
            // semana_inicio
            // 
            this.semana_inicio.DataPropertyName = "semana_inicio";
            this.semana_inicio.HeaderText = "Semana Inicio";
            this.semana_inicio.Name = "semana_inicio";
            // 
            // semana_fin
            // 
            this.semana_fin.DataPropertyName = "semana_fin";
            this.semana_fin.HeaderText = "Semana Fin";
            this.semana_fin.Name = "semana_fin";
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            // 
            // chkNroSemana
            // 
            this.chkNroSemana.AutoSize = true;
            this.chkNroSemana.Location = new System.Drawing.Point(401, 358);
            this.chkNroSemana.Name = "chkNroSemana";
            this.chkNroSemana.Size = new System.Drawing.Size(135, 21);
            this.chkNroSemana.TabIndex = 8;
            this.chkNroSemana.Text = "Por Nro Semana";
            this.chkNroSemana.UseVisualStyleBackColor = true;
            this.chkNroSemana.CheckedChanged += new System.EventHandler(this.chkNroSemana_CheckedChanged);
            // 
            // cbNroFecha
            // 
            this.cbNroFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNroFecha.Enabled = false;
            this.cbNroFecha.FormattingEnabled = true;
            this.cbNroFecha.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "52",
            "53"});
            this.cbNroFecha.Location = new System.Drawing.Point(543, 358);
            this.cbNroFecha.Name = "cbNroFecha";
            this.cbNroFecha.Size = new System.Drawing.Size(97, 24);
            this.cbNroFecha.TabIndex = 9;
            // 
            // BomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 437);
            this.Controls.Add(this.cbNroFecha);
            this.Controls.Add(this.chkNroSemana);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVerArticulos);
            this.Controls.Add(this.btnEliminarBom);
            this.Controls.Add(this.agregarBom);
            this.Controls.Add(this.BomsGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BomForm";
            this.Text = "BomForm";
            ((System.ComponentModel.ISupportInitialize)(this.BomsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BomsGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button agregarBom;
        private System.Windows.Forms.Button btnEliminarBom;
        private System.Windows.Forms.Button btnVerArticulos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker dpFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn bom_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo_padre;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo_hijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn um_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn semana_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn semana_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
        private System.Windows.Forms.CheckBox chkNroSemana;
        private System.Windows.Forms.ComboBox cbNroFecha;
    }
}