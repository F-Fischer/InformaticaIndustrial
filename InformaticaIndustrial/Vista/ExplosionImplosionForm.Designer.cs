namespace InformaticaIndustrial.Vista
{
    partial class ExplosionImplosionForm
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
            this.ArticuloGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImplosion = new System.Windows.Forms.Button();
            this.btnExplosion = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticuloGrid
            // 
            this.ArticuloGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArticuloGrid.Location = new System.Drawing.Point(12, 39);
            this.ArticuloGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArticuloGrid.Name = "ArticuloGrid";
            this.ArticuloGrid.RowTemplate.Height = 24;
            this.ArticuloGrid.Size = new System.Drawing.Size(1137, 293);
            this.ArticuloGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artículos";
            // 
            // btnImplosion
            // 
            this.btnImplosion.Location = new System.Drawing.Point(13, 337);
            this.btnImplosion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImplosion.Name = "btnImplosion";
            this.btnImplosion.Size = new System.Drawing.Size(180, 53);
            this.btnImplosion.TabIndex = 2;
            this.btnImplosion.Text = "Implosion";
            this.btnImplosion.UseVisualStyleBackColor = true;
            this.btnImplosion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExplosion
            // 
            this.btnExplosion.Location = new System.Drawing.Point(216, 337);
            this.btnExplosion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExplosion.Name = "btnExplosion";
            this.btnExplosion.Size = new System.Drawing.Size(180, 53);
            this.btnExplosion.TabIndex = 2;
            this.btnExplosion.Text = "Explosion";
            this.btnExplosion.UseVisualStyleBackColor = true;
            this.btnExplosion.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 410);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1137, 174);
            this.dataGridView2.TabIndex = 3;
            // 
            // ExplosionImplosionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 601);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnExplosion);
            this.Controls.Add(this.btnImplosion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArticuloGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExplosionImplosionForm";
            this.Text = "ExplosionImplosionForm";
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ArticuloGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImplosion;
        private System.Windows.Forms.Button btnExplosion;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}