namespace AccesoDB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Conecta = new System.Windows.Forms.Button();
            this.Carga = new System.Windows.Forms.Button();
            this.Desconecta = new System.Windows.Forms.Button();
            this.dataGridViewPersona = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // Conecta
            // 
            this.Conecta.BackColor = System.Drawing.Color.PaleGreen;
            this.Conecta.Location = new System.Drawing.Point(13, 13);
            this.Conecta.Name = "Conecta";
            this.Conecta.Size = new System.Drawing.Size(100, 23);
            this.Conecta.TabIndex = 0;
            this.Conecta.Text = "ConectaDB";
            this.Conecta.UseVisualStyleBackColor = false;
            this.Conecta.Click += new System.EventHandler(this.Conecta_Click);
            // 
            // Carga
            // 
            this.Carga.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Carga.Location = new System.Drawing.Point(159, 12);
            this.Carga.Name = "Carga";
            this.Carga.Size = new System.Drawing.Size(100, 23);
            this.Carga.TabIndex = 1;
            this.Carga.Text = "Carga Tabla";
            this.Carga.UseVisualStyleBackColor = false;
            this.Carga.Click += new System.EventHandler(this.Carga_Click);
            // 
            // Desconecta
            // 
            this.Desconecta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(194)))), ((int)(((byte)(120)))));
            this.Desconecta.FlatAppearance.BorderSize = 0;
            this.Desconecta.Location = new System.Drawing.Point(299, 12);
            this.Desconecta.Name = "Desconecta";
            this.Desconecta.Size = new System.Drawing.Size(100, 23);
            this.Desconecta.TabIndex = 2;
            this.Desconecta.Text = "Desconecta DB";
            this.Desconecta.UseVisualStyleBackColor = false;
            this.Desconecta.Click += new System.EventHandler(this.Desconecta_Click);
            // 
            // dataGridViewPersona
            // 
            this.dataGridViewPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersona.Location = new System.Drawing.Point(36, 63);
            this.dataGridViewPersona.Name = "dataGridViewPersona";
            this.dataGridViewPersona.Size = new System.Drawing.Size(340, 138);
            this.dataGridViewPersona.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.dataGridViewPersona);
            this.Controls.Add(this.Desconecta);
            this.Controls.Add(this.Carga);
            this.Controls.Add(this.Conecta);
            this.Name = "Form1";
            this.Text = "Conecta a una DB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Conecta;
        private System.Windows.Forms.Button Carga;
        private System.Windows.Forms.Button Desconecta;
        private System.Windows.Forms.DataGridView dataGridViewPersona;
    }
}

