﻿namespace PantallaImportarActualizacion
{
    partial class pantallaActualizarBodega
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBodegas = new System.Windows.Forms.ComboBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgBodega = new System.Windows.Forms.DataGridView();
            this.lblNombreBodega = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // opcionImportarActualizacionVino
            // 
            this.opcionImportarActualizacionVino.Location = new System.Drawing.Point(528, 83);
            this.opcionImportarActualizacionVino.Name = "opcionImportarActualizacionVino";
            this.opcionImportarActualizacionVino.Size = new System.Drawing.Size(232, 43);
            this.opcionImportarActualizacionVino.TabIndex = 0;
            this.opcionImportarActualizacionVino.Text = "Importar actualizacion de vinos de bodega";
            this.opcionImportarActualizacionVino.UseVisualStyleBackColor = true;
            this.opcionImportarActualizacionVino.Click += new System.EventHandler(this.opcionImportarActualizacionVino_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccionar bodega a actualizar";
            // 
            // cmbBodegas
            // 
            this.cmbBodegas.FormattingEnabled = true;
            this.cmbBodegas.Location = new System.Drawing.Point(566, 158);
            this.cmbBodegas.Name = "cmbBodegas";
            this.cmbBodegas.Size = new System.Drawing.Size(121, 21);
            this.cmbBodegas.TabIndex = 4;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(587, 197);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgBodega
            // 
            this.dgBodega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBodega.Location = new System.Drawing.Point(22, 241);
            this.dgBodega.Name = "dgBodega";
            this.dgBodega.Size = new System.Drawing.Size(1200, 94);
            this.dgBodega.TabIndex = 6;
            // 
            // lblNombreBodega
            // 
            this.lblNombreBodega.AutoSize = true;
            this.lblNombreBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBodega.Location = new System.Drawing.Point(33, 225);
            this.lblNombreBodega.Name = "lblNombreBodega";
            this.lblNombreBodega.Size = new System.Drawing.Size(41, 13);
            this.lblNombreBodega.TabIndex = 7;
            this.lblNombreBodega.Text = "label2";
            // 
            // pantallaActualizarBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 552);
            this.Controls.Add(this.lblNombreBodega);
            this.Controls.Add(this.dgBodega);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.cmbBodegas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opcionImportarActualizacionVino);
            this.Name = "pantallaActualizarBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion Vinos";
            ((System.ComponentModel.ISupportInitialize)(this.dgBodega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opcionImportarActualizacionVino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBodegas;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgBodega;
        private System.Windows.Forms.Label lblNombreBodega;
    }
}

