namespace JugandoDataGridView
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
            this.dataGridViewClick = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFlecha = new System.Windows.Forms.Label();
            this.textBoxClick = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClick)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClick
            // 
            this.dataGridViewClick.AllowUserToAddRows = false;
            this.dataGridViewClick.AllowUserToDeleteRows = false;
            this.dataGridViewClick.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClick.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.DNI});
            this.dataGridViewClick.Location = new System.Drawing.Point(204, 44);
            this.dataGridViewClick.Name = "dataGridViewClick";
            this.dataGridViewClick.ReadOnly = true;
            this.dataGridViewClick.Size = new System.Drawing.Size(343, 150);
            this.dataGridViewClick.TabIndex = 0;
            this.dataGridViewClick.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gilla_cellmouseclick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coloque un valor en el textBox y luego haga click en la celda de la grilla en don" +
                "de lo qioera colocar";
            // 
            // labelFlecha
            // 
            this.labelFlecha.AutoSize = true;
            this.labelFlecha.Location = new System.Drawing.Point(160, 47);
            this.labelFlecha.Name = "labelFlecha";
            this.labelFlecha.Size = new System.Drawing.Size(25, 13);
            this.labelFlecha.TabIndex = 2;
            this.labelFlecha.Text = "==>";
            // 
            // textBoxClick
            // 
            this.textBoxClick.Location = new System.Drawing.Point(28, 44);
            this.textBoxClick.Name = "textBoxClick";
            this.textBoxClick.Size = new System.Drawing.Size(111, 20);
            this.textBoxClick.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 219);
            this.Controls.Add(this.textBoxClick);
            this.Controls.Add(this.labelFlecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFlecha;
        private System.Windows.Forms.TextBox textBoxClick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
    }
}

