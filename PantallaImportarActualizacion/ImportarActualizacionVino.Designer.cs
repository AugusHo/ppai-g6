namespace PantallaImportarActualizacion
{
    partial class ImportarActualizacionVino
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.cmbBodegas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar bodega a actualizar";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(108, 175);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // cmbBodegas
            // 
            this.cmbBodegas.FormattingEnabled = true;
            this.cmbBodegas.Location = new System.Drawing.Point(85, 148);
            this.cmbBodegas.Name = "cmbBodegas";
            this.cmbBodegas.Size = new System.Drawing.Size(121, 21);
            this.cmbBodegas.TabIndex = 3;
            this.cmbBodegas.SelectedIndexChanged += new System.EventHandler(this.cmbBodegas_SelectedIndexChanged);
            // 
            // ImportarActualizacionVino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 458);
            this.Controls.Add(this.cmbBodegas);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.label1);
            this.Name = "ImportarActualizacionVino";
            this.Text = "Importar Actualizacion Vino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.ComboBox cmbBodegas;
    }
}