namespace Agenda
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
            this.grilla_datos = new System.Windows.Forms.DataGridView();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla_datos
            // 
            this.grilla_datos.AllowUserToAddRows = false;
            this.grilla_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.Nombre,
            this.Dir,
            this.Fecha_Nac,
            this.Mail,
            this.Tipo_Tel,
            this.Num_Tel});
            this.grilla_datos.Location = new System.Drawing.Point(12, 70);
            this.grilla_datos.Name = "grilla_datos";
            this.grilla_datos.Size = new System.Drawing.Size(746, 150);
            this.grilla_datos.TabIndex = 0;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Dir
            // 
            this.Dir.HeaderText = "Direccion";
            this.Dir.Name = "Dir";
            // 
            // Fecha_Nac
            // 
            this.Fecha_Nac.HeaderText = "Fecha de Nacimiento";
            this.Fecha_Nac.Name = "Fecha_Nac";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // Tipo_Tel
            // 
            this.Tipo_Tel.HeaderText = "Tipo de Telefono";
            this.Tipo_Tel.Name = "Tipo_Tel";
            // 
            // Num_Tel
            // 
            this.Num_Tel.HeaderText = "Numero de Telefono";
            this.Num_Tel.Name = "Num_Tel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 292);
            this.Controls.Add(this.grilla_datos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Tel;
    }
}

