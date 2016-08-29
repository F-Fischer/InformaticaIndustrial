namespace InformaticaIndustrial.Vista
{
    partial class AgregarBom
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
            this.cbArticuloPadre = new System.Windows.Forms.ComboBox();
            this.cbArticuloHijo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarBom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articulo Padre";
            // 
            // cbArticuloPadre
            // 
            this.cbArticuloPadre.FormattingEnabled = true;
            this.cbArticuloPadre.Location = new System.Drawing.Point(167, 12);
            this.cbArticuloPadre.Name = "cbArticuloPadre";
            this.cbArticuloPadre.Size = new System.Drawing.Size(121, 24);
            this.cbArticuloPadre.TabIndex = 1;
            // 
            // cbArticuloHijo
            // 
            this.cbArticuloHijo.FormattingEnabled = true;
            this.cbArticuloHijo.Location = new System.Drawing.Point(167, 53);
            this.cbArticuloHijo.Name = "cbArticuloHijo";
            this.cbArticuloHijo.Size = new System.Drawing.Size(121, 24);
            this.cbArticuloHijo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Articulo Hijo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidad de medida";
            // 
            // cbUnidadMedida
            // 
            this.cbUnidadMedida.FormattingEnabled = true;
            this.cbUnidadMedida.Location = new System.Drawing.Point(167, 208);
            this.cbUnidadMedida.Name = "cbUnidadMedida";
            this.cbUnidadMedida.Size = new System.Drawing.Size(121, 24);
            this.cbUnidadMedida.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(167, 92);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 5;
            // 
            // dpFechaFin
            // 
            this.dpFechaFin.Location = new System.Drawing.Point(167, 169);
            this.dpFechaFin.Name = "dpFechaFin";
            this.dpFechaFin.Size = new System.Drawing.Size(200, 22);
            this.dpFechaFin.TabIndex = 6;
            this.dpFechaFin.Value = new System.DateTime(2016, 8, 29, 1, 33, 38, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fecha Fin";
            // 
            // dpFechaInicio
            // 
            this.dpFechaInicio.Location = new System.Drawing.Point(164, 127);
            this.dpFechaInicio.Name = "dpFechaInicio";
            this.dpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dpFechaInicio.TabIndex = 6;
            this.dpFechaInicio.Value = new System.DateTime(2016, 8, 28, 23, 22, 27, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha Inicio";
            // 
            // btnAgregarBom
            // 
            this.btnAgregarBom.Location = new System.Drawing.Point(324, 267);
            this.btnAgregarBom.Name = "btnAgregarBom";
            this.btnAgregarBom.Size = new System.Drawing.Size(100, 51);
            this.btnAgregarBom.TabIndex = 8;
            this.btnAgregarBom.Text = "Agregar";
            this.btnAgregarBom.UseVisualStyleBackColor = true;
            this.btnAgregarBom.Click += new System.EventHandler(this.btnAgregarBom_Click);
            // 
            // AgregarBom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 330);
            this.Controls.Add(this.btnAgregarBom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dpFechaInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dpFechaFin);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUnidadMedida);
            this.Controls.Add(this.cbArticuloHijo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbArticuloPadre);
            this.Controls.Add(this.label1);
            this.Name = "AgregarBom";
            this.Text = "AgregarBom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArticuloPadre;
        private System.Windows.Forms.ComboBox cbArticuloHijo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbUnidadMedida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dpFechaFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpFechaInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregarBom;
    }
}