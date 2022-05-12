namespace Ejercicio3_CargaComboBox
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
            this.buttonCarga = new System.Windows.Forms.Button();
            this.buttonBorra = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCarga
            // 
            this.buttonCarga.Location = new System.Drawing.Point(38, 38);
            this.buttonCarga.Name = "buttonCarga";
            this.buttonCarga.Size = new System.Drawing.Size(97, 23);
            this.buttonCarga.TabIndex = 0;
            this.buttonCarga.Text = "Cargar Combo";
            this.buttonCarga.UseVisualStyleBackColor = true;
            this.buttonCarga.Click += new System.EventHandler(this.buttonCarga_Click);
            // 
            // buttonBorra
            // 
            this.buttonBorra.Location = new System.Drawing.Point(209, 37);
            this.buttonBorra.Name = "buttonBorra";
            this.buttonBorra.Size = new System.Drawing.Size(97, 23);
            this.buttonBorra.TabIndex = 1;
            this.buttonBorra.Text = "Vaciar Combo";
            this.buttonBorra.UseVisualStyleBackColor = true;
            this.buttonBorra.Click += new System.EventHandler(this.buttonBorra_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 211);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonBorra);
            this.Controls.Add(this.buttonCarga);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCarga;
        private System.Windows.Forms.Button buttonBorra;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

