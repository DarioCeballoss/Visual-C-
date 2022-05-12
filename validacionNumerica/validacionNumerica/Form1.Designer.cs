namespace validacionNumerica
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
            this.components = new System.ComponentModel.Container();
            this.tBvalidacion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CajaTexto = new System.Windows.Forms.TextBox();
            this.ProveedorDeError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).BeginInit();
            this.SuspendLayout();
            // 
            // tBvalidacion
            // 
            this.tBvalidacion.Location = new System.Drawing.Point(86, 85);
            this.tBvalidacion.Name = "tBvalidacion";
            this.tBvalidacion.Size = new System.Drawing.Size(251, 20);
            this.tBvalidacion.TabIndex = 0;
            this.tBvalidacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKeyPres);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CajaTexto
            // 
            this.CajaTexto.Location = new System.Drawing.Point(86, 134);
            this.CajaTexto.Name = "CajaTexto";
            this.CajaTexto.Size = new System.Drawing.Size(251, 20);
            this.CajaTexto.TabIndex = 2;
            this.CajaTexto.Validating += new System.ComponentModel.CancelEventHandler(this.tbValidating);
            this.CajaTexto.Validated += new System.EventHandler(this.tbValidated);
            // 
            // ProveedorDeError
            // 
            this.ProveedorDeError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 261);
            this.Controls.Add(this.CajaTexto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBvalidacion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBvalidacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CajaTexto;
        private System.Windows.Forms.ErrorProvider ProveedorDeError;
    }
}

