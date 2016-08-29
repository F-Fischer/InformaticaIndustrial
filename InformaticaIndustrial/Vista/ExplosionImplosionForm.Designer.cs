﻿namespace InformaticaIndustrial.Vista
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
            this.articulo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_std = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad_med = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ArticuloGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articulo_id,
            this.descripcion,
            this.precio_std,
            this.tipo_articulo,
            this.unidad_med,
            this.fecha_inicio});
            this.ArticuloGrid.Location = new System.Drawing.Point(9, 32);
            this.ArticuloGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArticuloGrid.Name = "ArticuloGrid";
            this.ArticuloGrid.RowTemplate.Height = 24;
            this.ArticuloGrid.Size = new System.Drawing.Size(853, 238);
            this.ArticuloGrid.TabIndex = 0;
            // 
            // articulo_id
            // 
            this.articulo_id.HeaderText = "Articulo ID";
            this.articulo_id.Name = "articulo_id";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // precio_std
            // 
            this.precio_std.HeaderText = "Precio Std";
            this.precio_std.Name = "precio_std";
            // 
            // tipo_articulo
            // 
            this.tipo_articulo.HeaderText = "Tipo articulo";
            this.tipo_articulo.Name = "tipo_articulo";
            // 
            // unidad_med
            // 
            this.unidad_med.HeaderText = "Unidad de Medida";
            this.unidad_med.Name = "unidad_med";
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.HeaderText = "Fecha Inicio";
            this.fecha_inicio.Name = "fecha_inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artículos";
            // 
            // btnImplosion
            // 
            this.btnImplosion.Location = new System.Drawing.Point(10, 274);
            this.btnImplosion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImplosion.Name = "btnImplosion";
            this.btnImplosion.Size = new System.Drawing.Size(135, 43);
            this.btnImplosion.TabIndex = 2;
            this.btnImplosion.Text = "Implosion";
            this.btnImplosion.UseVisualStyleBackColor = true;
            this.btnImplosion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExplosion
            // 
            this.btnExplosion.Location = new System.Drawing.Point(162, 274);
            this.btnExplosion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExplosion.Name = "btnExplosion";
            this.btnExplosion.Size = new System.Drawing.Size(135, 43);
            this.btnExplosion.TabIndex = 2;
            this.btnExplosion.Text = "Explosion";
            this.btnExplosion.UseVisualStyleBackColor = true;
            this.btnExplosion.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 333);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(853, 141);
            this.dataGridView2.TabIndex = 3;
            // 
            // ExplosionImplosionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 488);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnExplosion);
            this.Controls.Add(this.btnImplosion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArticuloGrid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_std;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad_med;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inicio;
    }
}