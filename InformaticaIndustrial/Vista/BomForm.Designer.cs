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
            this.bom_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo_padre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo_hijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.um_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.agregarBom = new System.Windows.Forms.Button();
            this.btnEliminarBom = new System.Windows.Forms.Button();
            this.btnVerArticulos = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
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
            this.fecha_inicio,
            this.um_id});
            this.BomsGrid.Location = new System.Drawing.Point(9, 10);
            this.BomsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.BomsGrid.Name = "BomsGrid";
            this.BomsGrid.RowTemplate.Height = 24;
            this.BomsGrid.Size = new System.Drawing.Size(774, 246);
            this.BomsGrid.TabIndex = 0;
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
            // fecha_inicio
            // 
            this.fecha_inicio.DataPropertyName = "fecha_inicio";
            this.fecha_inicio.HeaderText = "Fecha Creación";
            this.fecha_inicio.Name = "fecha_inicio";
            // 
            // um_id
            // 
            this.um_id.DataPropertyName = "um_id";
            this.um_id.HeaderText = "Unidad de Medida";
            this.um_id.Name = "um_id";
            // 
            // agregarBom
            // 
            this.agregarBom.Location = new System.Drawing.Point(9, 261);
            this.agregarBom.Margin = new System.Windows.Forms.Padding(2);
            this.agregarBom.Name = "agregarBom";
            this.agregarBom.Size = new System.Drawing.Size(91, 34);
            this.agregarBom.TabIndex = 1;
            this.agregarBom.Text = "Agregar";
            this.agregarBom.UseVisualStyleBackColor = true;
            this.agregarBom.Click += new System.EventHandler(this.agregarBom_Click);
            // 
            // btnEliminarBom
            // 
            this.btnEliminarBom.Location = new System.Drawing.Point(195, 261);
            this.btnEliminarBom.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarBom.Name = "btnEliminarBom";
            this.btnEliminarBom.Size = new System.Drawing.Size(86, 34);
            this.btnEliminarBom.TabIndex = 2;
            this.btnEliminarBom.Text = "Eliminar";
            this.btnEliminarBom.UseVisualStyleBackColor = true;
            this.btnEliminarBom.Click += new System.EventHandler(this.btnEliminarBom_Click);
            // 
            // btnVerArticulos
            // 
            this.btnVerArticulos.Location = new System.Drawing.Point(676, 261);
            this.btnVerArticulos.Name = "btnVerArticulos";
            this.btnVerArticulos.Size = new System.Drawing.Size(107, 33);
            this.btnVerArticulos.TabIndex = 3;
            this.btnVerArticulos.Text = "Ver Articulos";
            this.btnVerArticulos.UseVisualStyleBackColor = true;
            
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(105, 261);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 34);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // BomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 355);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVerArticulos);
            this.Controls.Add(this.btnEliminarBom);
            this.Controls.Add(this.agregarBom);
            this.Controls.Add(this.BomsGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BomForm";
            this.Text = "BomForm";
            ((System.ComponentModel.ISupportInitialize)(this.BomsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BomsGrid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button agregarBom;
        private System.Windows.Forms.Button btnEliminarBom;
        private System.Windows.Forms.DataGridViewTextBoxColumn bom_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo_padre;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo_hijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn um_id;
        private System.Windows.Forms.Button btnVerArticulos;
        private System.Windows.Forms.Button btnModificar;
    }
}