namespace InformaticaIndustrial.Vista
{
    partial class MenuPrincipal
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
            this.btnBOM = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBOM
            // 
            this.btnBOM.Location = new System.Drawing.Point(12, 12);
            this.btnBOM.Name = "btnBOM";
            this.btnBOM.Size = new System.Drawing.Size(230, 60);
            this.btnBOM.TabIndex = 0;
            this.btnBOM.Text = "BOM";
            this.btnBOM.UseVisualStyleBackColor = true;
            this.btnBOM.Click += new System.EventHandler(this.btnBOM_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(13, 79);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(229, 61);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "Artículos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(13, 146);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(229, 61);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 261);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.btnBOM);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBOM;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnStock;
    }
}