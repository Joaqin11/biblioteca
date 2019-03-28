namespace CopiaDeBiblio
{
    partial class VentanaDeCarga
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.labDniUsuario = new System.Windows.Forms.Label();
            this.labCodPatEjemplar = new System.Windows.Forms.Label();
            this.FechaDev = new System.Windows.Forms.Label();
            this.tbxBuscarDni = new System.Windows.Forms.TextBox();
            this.tbxBuscarCodPat = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(12, 263);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(212, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labDniUsuario
            // 
            this.labDniUsuario.AutoSize = true;
            this.labDniUsuario.Location = new System.Drawing.Point(12, 15);
            this.labDniUsuario.Name = "labDniUsuario";
            this.labDniUsuario.Size = new System.Drawing.Size(169, 13);
            this.labDniUsuario.TabIndex = 2;
            this.labDniUsuario.Text = "Numero de documento del usuario";
            // 
            // labCodPatEjemplar
            // 
            this.labCodPatEjemplar.AutoSize = true;
            this.labCodPatEjemplar.Location = new System.Drawing.Point(12, 41);
            this.labCodPatEjemplar.Name = "labCodPatEjemplar";
            this.labCodPatEjemplar.Size = new System.Drawing.Size(158, 13);
            this.labCodPatEjemplar.TabIndex = 3;
            this.labCodPatEjemplar.Text = "Codigo patrimonial del ejemplar: ";
            // 
            // FechaDev
            // 
            this.FechaDev.AutoSize = true;
            this.FechaDev.Location = new System.Drawing.Point(12, 67);
            this.FechaDev.Name = "FechaDev";
            this.FechaDev.Size = new System.Drawing.Size(158, 13);
            this.FechaDev.TabIndex = 4;
            this.FechaDev.Text = "Fecha estimada de devolucion: ";
            // 
            // tbxBuscarDni
            // 
            this.tbxBuscarDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxBuscarDni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxBuscarDni.Location = new System.Drawing.Point(187, 12);
            this.tbxBuscarDni.Name = "tbxBuscarDni";
            this.tbxBuscarDni.Size = new System.Drawing.Size(100, 20);
            this.tbxBuscarDni.TabIndex = 5;
            // 
            // tbxBuscarCodPat
            // 
            this.tbxBuscarCodPat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbxBuscarCodPat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxBuscarCodPat.Location = new System.Drawing.Point(187, 38);
            this.tbxBuscarCodPat.Name = "tbxBuscarCodPat";
            this.tbxBuscarCodPat.Size = new System.Drawing.Size(100, 20);
            this.tbxBuscarCodPat.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(60, 89);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // VentanaDeCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 299);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tbxBuscarCodPat);
            this.Controls.Add(this.tbxBuscarDni);
            this.Controls.Add(this.FechaDev);
            this.Controls.Add(this.labCodPatEjemplar);
            this.Controls.Add(this.labDniUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "VentanaDeCarga";
            this.Text = "Ventana De Prestamos";
            this.Load += new System.EventHandler(this.VentanaDeCarga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Label labDniUsuario;
        public System.Windows.Forms.Label labCodPatEjemplar;
        public System.Windows.Forms.Label FechaDev;
        public System.Windows.Forms.TextBox tbxBuscarDni;
        public System.Windows.Forms.TextBox tbxBuscarCodPat;
        private System.Windows.Forms.MonthCalendar monthCalendar1;

    }
}