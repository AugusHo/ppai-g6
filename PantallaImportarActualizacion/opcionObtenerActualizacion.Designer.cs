namespace PantallaImportarActualizacion
{
    partial class opcionObtenerActualizacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opcionImportarActualizacionVino
            // 
            this.opcionImportarActualizacionVino.Location = new System.Drawing.Point(40, 85);
            this.opcionImportarActualizacionVino.Name = "opcionImportarActualizacionVino";
            this.opcionImportarActualizacionVino.Size = new System.Drawing.Size(227, 63);
            this.opcionImportarActualizacionVino.TabIndex = 0;
            this.opcionImportarActualizacionVino.Text = "Importar actualizacion de vinos de bodega";
            this.opcionImportarActualizacionVino.UseVisualStyleBackColor = true;
            this.opcionImportarActualizacionVino.Click += new System.EventHandler(this.opcionImportarActualizacionVino_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Importar actualizacion de vinos de bodega";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Con Solo Actualizacion de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Con Creacion de Vino";
            // 
            // opcionObtenerActualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.opcionImportarActualizacionVino);
            this.Name = "opcionObtenerActualizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion Vinos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opcionImportarActualizacionVino;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

