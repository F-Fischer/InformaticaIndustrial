namespace InformaticaIndustrial.Vista
{
    partial class Deposito
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
            this.stockGrid = new System.Windows.Forms.DataGridView();
            this.Stock = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGenerarStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // stockGrid
            // 
            this.stockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockGrid.Location = new System.Drawing.Point(12, 35);
            this.stockGrid.Name = "stockGrid";
            this.stockGrid.RowTemplate.Height = 24;
            this.stockGrid.Size = new System.Drawing.Size(633, 183);
            this.stockGrid.TabIndex = 0;
            // 
            // Stock
            // 
            this.Stock.AutoSize = true;
            this.Stock.Location = new System.Drawing.Point(12, 9);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(43, 17);
            this.Stock.TabIndex = 1;
            this.Stock.Text = "Stock";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(451, 265);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 44);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGenerarStock
            // 
            this.btnGenerarStock.Location = new System.Drawing.Point(551, 265);
            this.btnGenerarStock.Name = "btnGenerarStock";
            this.btnGenerarStock.Size = new System.Drawing.Size(94, 44);
            this.btnGenerarStock.TabIndex = 3;
            this.btnGenerarStock.Text = "Generar Stock";
            this.btnGenerarStock.UseVisualStyleBackColor = true;
            this.btnGenerarStock.Click += new System.EventHandler(this.btnGenerarStock_Click);
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 321);
            this.Controls.Add(this.btnGenerarStock);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.stockGrid);
            this.Name = "Deposito";
            this.Text = "Deposito";
            ((System.ComponentModel.ISupportInitialize)(this.stockGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockGrid;
        private System.Windows.Forms.Label Stock;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGenerarStock;
    }
}