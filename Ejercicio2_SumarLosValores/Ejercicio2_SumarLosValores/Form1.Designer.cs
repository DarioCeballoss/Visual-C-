namespace Ejercicio2_SumarLosValores
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
            this.labelVal1 = new System.Windows.Forms.Label();
            this.labelVal2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonSumar = new System.Windows.Forms.Button();
            this.textBoxVal1 = new System.Windows.Forms.TextBox();
            this.textBoxVal2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelVal1
            // 
            this.labelVal1.AutoSize = true;
            this.labelVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVal1.ForeColor = System.Drawing.Color.Blue;
            this.labelVal1.Location = new System.Drawing.Point(44, 32);
            this.labelVal1.Name = "labelVal1";
            this.labelVal1.Size = new System.Drawing.Size(160, 13);
            this.labelVal1.TabIndex = 0;
            this.labelVal1.Text = "Ingrese un valor Numérico:";
            // 
            // labelVal2
            // 
            this.labelVal2.AutoSize = true;
            this.labelVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVal2.ForeColor = System.Drawing.Color.Blue;
            this.labelVal2.Location = new System.Drawing.Point(44, 64);
            this.labelVal2.Name = "labelVal2";
            this.labelVal2.Size = new System.Drawing.Size(168, 13);
            this.labelVal2.TabIndex = 1;
            this.labelVal2.Text = "Ingrese otro valor Numérico:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(243, 142);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(95, 13);
            this.labelResultado.TabIndex = 2;
            this.labelResultado.Text = "El resultado es:";
            // 
            // buttonSumar
            // 
            this.buttonSumar.Location = new System.Drawing.Point(47, 142);
            this.buttonSumar.Name = "buttonSumar";
            this.buttonSumar.Size = new System.Drawing.Size(157, 29);
            this.buttonSumar.TabIndex = 3;
            this.buttonSumar.Text = "Sumar los valores:";
            this.buttonSumar.UseVisualStyleBackColor = true;
            this.buttonSumar.Click += new System.EventHandler(this.buttonSumar_Click);
            // 
            // textBoxVal1
            // 
            this.textBoxVal1.Location = new System.Drawing.Point(246, 29);
            this.textBoxVal1.Name = "textBoxVal1";
            this.textBoxVal1.Size = new System.Drawing.Size(200, 20);
            this.textBoxVal1.TabIndex = 4;
            // 
            // textBoxVal2
            // 
            this.textBoxVal2.Location = new System.Drawing.Point(246, 61);
            this.textBoxVal2.Name = "textBoxVal2";
            this.textBoxVal2.Size = new System.Drawing.Size(200, 20);
            this.textBoxVal2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 207);
            this.Controls.Add(this.textBoxVal2);
            this.Controls.Add(this.textBoxVal1);
            this.Controls.Add(this.buttonSumar);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelVal2);
            this.Controls.Add(this.labelVal1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sumar dos valores numéricos:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVal1;
        private System.Windows.Forms.Label labelVal2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonSumar;
        private System.Windows.Forms.TextBox textBoxVal1;
        private System.Windows.Forms.TextBox textBoxVal2;
    }
}

