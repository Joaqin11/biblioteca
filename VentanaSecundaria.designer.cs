namespace CopiaDeBiblio
{
    partial class VentanaSecundaria
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
            this.labNomAp = new System.Windows.Forms.Label();
            this.labDni = new System.Windows.Forms.Label();
            this.labMail = new System.Windows.Forms.Label();
            this.tbxNomAp = new System.Windows.Forms.TextBox();
            this.tbxDni = new System.Windows.Forms.TextBox();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbEstadoEjemplar = new System.Windows.Forms.CheckBox();
            this.cbDarDeBaja = new System.Windows.Forms.CheckBox();
            this.labCodPat = new System.Windows.Forms.Label();
            this.labUbicacion = new System.Windows.Forms.Label();
            this.tbxCodPat = new System.Windows.Forms.TextBox();
            this.tbxUbicacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labNomAp
            // 
            this.labNomAp.AutoSize = true;
            this.labNomAp.Location = new System.Drawing.Point(12, 15);
            this.labNomAp.Name = "labNomAp";
            this.labNomAp.Size = new System.Drawing.Size(98, 13);
            this.labNomAp.TabIndex = 0;
            this.labNomAp.Text = "Nombre y Apellido: ";
            // 
            // labDni
            // 
            this.labDni.AutoSize = true;
            this.labDni.Location = new System.Drawing.Point(12, 41);
            this.labDni.Name = "labDni";
            this.labDni.Size = new System.Drawing.Size(32, 13);
            this.labDni.TabIndex = 1;
            this.labDni.Text = "DNI: ";
            // 
            // labMail
            // 
            this.labMail.AutoSize = true;
            this.labMail.Location = new System.Drawing.Point(12, 67);
            this.labMail.Name = "labMail";
            this.labMail.Size = new System.Drawing.Size(42, 13);
            this.labMail.TabIndex = 2;
            this.labMail.Text = "E-Mail: ";
            // 
            // tbxNomAp
            // 
            this.tbxNomAp.Location = new System.Drawing.Point(156, 12);
            this.tbxNomAp.Name = "tbxNomAp";
            this.tbxNomAp.Size = new System.Drawing.Size(130, 20);
            this.tbxNomAp.TabIndex = 3;
            // 
            // tbxDni
            // 
            this.tbxDni.Location = new System.Drawing.Point(156, 38);
            this.tbxDni.Name = "tbxDni";
            this.tbxDni.Size = new System.Drawing.Size(130, 20);
            this.tbxDni.TabIndex = 4;
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(156, 64);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(130, 20);
            this.tbxMail.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnAceptar.Location = new System.Drawing.Point(15, 92);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(211, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cbEstadoEjemplar
            // 
            this.cbEstadoEjemplar.AutoSize = true;
            this.cbEstadoEjemplar.Location = new System.Drawing.Point(439, 66);
            this.cbEstadoEjemplar.Name = "cbEstadoEjemplar";
            this.cbEstadoEjemplar.Size = new System.Drawing.Size(75, 17);
            this.cbEstadoEjemplar.TabIndex = 8;
            this.cbEstadoEjemplar.Text = "Disponible";
            this.cbEstadoEjemplar.UseVisualStyleBackColor = true;
            this.cbEstadoEjemplar.Visible = false;
            // 
            // cbDarDeBaja
            // 
            this.cbDarDeBaja.AutoSize = true;
            this.cbDarDeBaja.Location = new System.Drawing.Point(336, 66);
            this.cbDarDeBaja.Name = "cbDarDeBaja";
            this.cbDarDeBaja.Size = new System.Drawing.Size(81, 17);
            this.cbDarDeBaja.TabIndex = 9;
            this.cbDarDeBaja.Text = "Dar de baja";
            this.cbDarDeBaja.UseVisualStyleBackColor = true;
            this.cbDarDeBaja.Visible = false;
            // 
            // labCodPat
            // 
            this.labCodPat.AutoSize = true;
            this.labCodPat.Location = new System.Drawing.Point(333, 15);
            this.labCodPat.Name = "labCodPat";
            this.labCodPat.Size = new System.Drawing.Size(100, 13);
            this.labCodPat.TabIndex = 10;
            this.labCodPat.Text = "Codigo Patrimonial: ";
            this.labCodPat.Visible = false;
            // 
            // labUbicacion
            // 
            this.labUbicacion.AutoSize = true;
            this.labUbicacion.Location = new System.Drawing.Point(333, 41);
            this.labUbicacion.Name = "labUbicacion";
            this.labUbicacion.Size = new System.Drawing.Size(61, 13);
            this.labUbicacion.TabIndex = 11;
            this.labUbicacion.Text = "Ubicacion: ";
            this.labUbicacion.Visible = false;
            // 
            // tbxCodPat
            // 
            this.tbxCodPat.Location = new System.Drawing.Point(439, 12);
            this.tbxCodPat.Name = "tbxCodPat";
            this.tbxCodPat.Size = new System.Drawing.Size(100, 20);
            this.tbxCodPat.TabIndex = 12;
            this.tbxCodPat.Visible = false;
            // 
            // tbxUbicacion
            // 
            this.tbxUbicacion.Location = new System.Drawing.Point(439, 38);
            this.tbxUbicacion.Name = "tbxUbicacion";
            this.tbxUbicacion.Size = new System.Drawing.Size(100, 20);
            this.tbxUbicacion.TabIndex = 13;
            this.tbxUbicacion.Visible = false;
            // 
            // VentanaSecundaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 127);
            this.Controls.Add(this.tbxUbicacion);
            this.Controls.Add(this.tbxCodPat);
            this.Controls.Add(this.labUbicacion);
            this.Controls.Add(this.labCodPat);
            this.Controls.Add(this.cbDarDeBaja);
            this.Controls.Add(this.cbEstadoEjemplar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.tbxDni);
            this.Controls.Add(this.tbxNomAp);
            this.Controls.Add(this.labMail);
            this.Controls.Add(this.labDni);
            this.Controls.Add(this.labNomAp);
            this.Name = "VentanaSecundaria";
            this.Text = "Ventana Secundaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox tbxNomAp;
        public System.Windows.Forms.TextBox tbxDni;
        public System.Windows.Forms.TextBox tbxMail;
        public System.Windows.Forms.Label labNomAp;
        public System.Windows.Forms.Label labDni;
        public System.Windows.Forms.Label labMail;
        public System.Windows.Forms.CheckBox cbEstadoEjemplar;
        public System.Windows.Forms.CheckBox cbDarDeBaja;
        public System.Windows.Forms.Label labCodPat;
        public System.Windows.Forms.Label labUbicacion;
        public System.Windows.Forms.TextBox tbxCodPat;
        public System.Windows.Forms.TextBox tbxUbicacion;
    }
}