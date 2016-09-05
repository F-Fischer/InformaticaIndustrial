namespace InformaticaIndustrial.Vista
{
    partial class ModificarBomForm
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
            System.Windows.Forms.Button btnModificar;
            System.Windows.Forms.Button btnCancelar;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArticuloPadre = new System.Windows.Forms.TextBox();
            this.cbArticulos = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dpFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.cbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            btnModificar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artículo Padre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artículo Hijo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de implementación";
            // 
            // txtArticuloPadre
            // 
            this.txtArticuloPadre.Location = new System.Drawing.Point(188, 19);
            this.txtArticuloPadre.Name = "txtArticuloPadre";
            this.txtArticuloPadre.ReadOnly = true;
            this.txtArticuloPadre.Size = new System.Drawing.Size(200, 20);
            this.txtArticuloPadre.TabIndex = 3;
            // 
            // cbArticulos
            // 
            this.cbArticulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArticulos.FormattingEnabled = true;
            this.cbArticulos.Location = new System.Drawing.Point(188, 45);
            this.cbArticulos.Name = "cbArticulos";
            this.cbArticulos.Size = new System.Drawing.Size(200, 21);
            this.cbArticulos.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(188, 72);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // dpFechaCreacion
            // 
            this.dpFechaCreacion.Enabled = false;
            this.dpFechaCreacion.Location = new System.Drawing.Point(188, 97);
            this.dpFechaCreacion.Name = "dpFechaCreacion";
            this.dpFechaCreacion.Size = new System.Drawing.Size(200, 20);
            this.dpFechaCreacion.TabIndex = 5;
            // 
            // cbUnidadMedida
            // 
            this.cbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadMedida.FormattingEnabled = true;
            this.cbUnidadMedida.Location = new System.Drawing.Point(188, 123);
            this.cbUnidadMedida.Name = "cbUnidadMedida";
            this.cbUnidadMedida.Size = new System.Drawing.Size(200, 21);
            this.cbUnidadMedida.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Unidad de medida";
            // 
            // btnModificar
            // 
            btnModificar.Location = new System.Drawing.Point(300, 150);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(88, 36);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(206, 150);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(88, 36);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ModificarBomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 197);
            this.Controls.Add(btnCancelar);
            this.Controls.Add(btnModificar);
            this.Controls.Add(this.cbUnidadMedida);
            this.Controls.Add(this.dpFechaCreacion);
            this.Controls.Add(this.cbArticulos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtArticuloPadre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarBomForm";
            this.Text = "3.";
            this.Load += new System.EventHandler(this.ModificarBomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArticuloPadre;
        private System.Windows.Forms.ComboBox cbArticulos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dpFechaCreacion;
        private System.Windows.Forms.ComboBox cbUnidadMedida;
        private System.Windows.Forms.Label label5;
    }
}