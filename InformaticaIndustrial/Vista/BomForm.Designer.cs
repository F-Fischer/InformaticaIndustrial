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
            ((System.ComponentModel.ISupportInitialize)(this.BomsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BomsGrid
            // 
            this.BomsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BomsGrid.Location = new System.Drawing.Point(27, 29);
            this.BomsGrid.Name = "BomsGrid";
            this.BomsGrid.RowTemplate.Height = 24;
            this.BomsGrid.Size = new System.Drawing.Size(1288, 286);
            this.BomsGrid.TabIndex = 0;
            // 
            // agregarBom
            // 
            this.agregarBom.Location = new System.Drawing.Point(27, 335);
            this.agregarBom.Name = "agregarBom";
            this.agregarBom.Size = new System.Drawing.Size(121, 42);
            this.agregarBom.TabIndex = 1;
            this.agregarBom.Text = "Agregar";
            this.agregarBom.UseVisualStyleBackColor = true;
            this.agregarBom.Click += new System.EventHandler(this.agregarBom_Click);
            // 
            // btnEliminarBom
            // 
            this.btnEliminarBom.Location = new System.Drawing.Point(178, 335);
            this.btnEliminarBom.Name = "btnEliminarBom";
            this.btnEliminarBom.Size = new System.Drawing.Size(115, 42);
            this.btnEliminarBom.TabIndex = 2;
            this.btnEliminarBom.Text = "Eliminar";
            this.btnEliminarBom.UseVisualStyleBackColor = true;
            this.btnEliminarBom.Click += new System.EventHandler(this.btnEliminarBom_Click);
            // 
            // BomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 618);
            this.Controls.Add(this.btnEliminarBom);
            this.Controls.Add(this.agregarBom);
            this.Controls.Add(this.BomsGrid);
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
    }
}