namespace PantallaImportarActualizacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.opcionImportarActualizacionVino = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opcionImportarActualizacionVino
            // 
            this.opcionImportarActualizacionVino.Location = new System.Drawing.Point(35, 166);
            this.opcionImportarActualizacionVino.Name = "opcionImportarActualizacionVino";
            this.opcionImportarActualizacionVino.Size = new System.Drawing.Size(227, 63);
            this.opcionImportarActualizacionVino.TabIndex = 0;
            this.opcionImportarActualizacionVino.Text = "Importar actualizacion de vinos de bodega";
            this.opcionImportarActualizacionVino.UseVisualStyleBackColor = true;
            this.opcionImportarActualizacionVino.Click += new System.EventHandler(this.opcionImportarActualizacionVino_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 446);
            this.Controls.Add(this.opcionImportarActualizacionVino);
            this.Name = "Form1";
            this.Text = "Administracion Vinos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button opcionImportarActualizacionVino;
    }
}

