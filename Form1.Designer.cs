namespace CopiaDeBiblio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.disponiblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listViewLibros2 = new System.Windows.Forms.ListView();
            this.listViewEjemplares3 = new System.Windows.Forms.ListView();
            this.listViewPrestamos4 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.verListaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.libroToolStripMenuItem,
            this.ejemplarToolStripMenuItem,
            this.prestamoToolStripMenuItem,
            this.devolucionToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.agregarToolStripMenuItem.Text = "&Agregar";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.usuarioToolStripMenuItem.Text = "U&suario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.libroToolStripMenuItem.Text = "&Libro";
            this.libroToolStripMenuItem.Click += new System.EventHandler(this.libroToolStripMenuItem_Click);
            // 
            // ejemplarToolStripMenuItem
            // 
            this.ejemplarToolStripMenuItem.Name = "ejemplarToolStripMenuItem";
            this.ejemplarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ejemplarToolStripMenuItem.Text = "&Ejemplar";
            this.ejemplarToolStripMenuItem.Click += new System.EventHandler(this.ejemplarToolStripMenuItem_Click);
            // 
            // prestamoToolStripMenuItem
            // 
            this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.prestamoToolStripMenuItem.Text = "&Prestamo";
            this.prestamoToolStripMenuItem.Click += new System.EventHandler(this.prestamoToolStripMenuItem_Click);
            // 
            // devolucionToolStripMenuItem
            // 
            this.devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            this.devolucionToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.devolucionToolStripMenuItem.Text = "&Devolucion";
            this.devolucionToolStripMenuItem.Click += new System.EventHandler(this.devolucionToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.ejemplarToolStripMenuItem1});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // usuarioToolStripMenuItem1
            // 
            this.usuarioToolStripMenuItem1.Name = "usuarioToolStripMenuItem1";
            this.usuarioToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.usuarioToolStripMenuItem1.Text = "&Usuario";
            this.usuarioToolStripMenuItem1.Click += new System.EventHandler(this.usuarioToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem2.Text = "&Libro";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ejemplarToolStripMenuItem1
            // 
            this.ejemplarToolStripMenuItem1.Name = "ejemplarToolStripMenuItem1";
            this.ejemplarToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.ejemplarToolStripMenuItem1.Text = "&Ejemplar";
            this.ejemplarToolStripMenuItem1.Click += new System.EventHandler(this.ejemplarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem2,
            this.toolStripMenuItem3,
            this.ejemplarToolStripMenuItem2});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.eliminarToolStripMenuItem.Text = "E&liminar";
            // 
            // usuarioToolStripMenuItem2
            // 
            this.usuarioToolStripMenuItem2.Name = "usuarioToolStripMenuItem2";
            this.usuarioToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.usuarioToolStripMenuItem2.Text = "&Usuario";
            this.usuarioToolStripMenuItem2.Click += new System.EventHandler(this.usuarioToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem3.Text = "&Libro";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // ejemplarToolStripMenuItem2
            // 
            this.ejemplarToolStripMenuItem2.Name = "ejemplarToolStripMenuItem2";
            this.ejemplarToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.ejemplarToolStripMenuItem2.Text = "&Ejemplar";
            this.ejemplarToolStripMenuItem2.Click += new System.EventHandler(this.ejemplarToolStripMenuItem2_Click);
            // 
            // verListaDeToolStripMenuItem
            // 
            this.verListaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem3,
            this.libroToolStripMenuItem1,
            this.ejemplarToolStripMenuItem3,
            this.prestamosToolStripMenuItem});
            this.verListaDeToolStripMenuItem.Name = "verListaDeToolStripMenuItem";
            this.verListaDeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.verListaDeToolStripMenuItem.Text = "L&istar";
            // 
            // usuarioToolStripMenuItem3
            // 
            this.usuarioToolStripMenuItem3.Name = "usuarioToolStripMenuItem3";
            this.usuarioToolStripMenuItem3.Size = new System.Drawing.Size(137, 22);
            this.usuarioToolStripMenuItem3.Text = "&Usuarios";
            this.usuarioToolStripMenuItem3.Click += new System.EventHandler(this.usuarioToolStripMenuItem3_Click);
            // 
            // libroToolStripMenuItem1
            // 
            this.libroToolStripMenuItem1.Name = "libroToolStripMenuItem1";
            this.libroToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.libroToolStripMenuItem1.Text = "&Libros";
            this.libroToolStripMenuItem1.Click += new System.EventHandler(this.libroToolStripMenuItem1_Click);
            // 
            // ejemplarToolStripMenuItem3
            // 
            this.ejemplarToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disponiblesToolStripMenuItem,
            this.dadosDeBajaToolStripMenuItem});
            this.ejemplarToolStripMenuItem3.Name = "ejemplarToolStripMenuItem3";
            this.ejemplarToolStripMenuItem3.Size = new System.Drawing.Size(137, 22);
            this.ejemplarToolStripMenuItem3.Text = "&Ejemplares";
            this.ejemplarToolStripMenuItem3.Click += new System.EventHandler(this.ejemplarToolStripMenuItem3_Click);
            // 
            // disponiblesToolStripMenuItem
            // 
            this.disponiblesToolStripMenuItem.Name = "disponiblesToolStripMenuItem";
            this.disponiblesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.disponiblesToolStripMenuItem.Text = "&No dados de baja";
            this.disponiblesToolStripMenuItem.Click += new System.EventHandler(this.disponiblesToolStripMenuItem_Click);
            // 
            // dadosDeBajaToolStripMenuItem
            // 
            this.dadosDeBajaToolStripMenuItem.Name = "dadosDeBajaToolStripMenuItem";
            this.dadosDeBajaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dadosDeBajaToolStripMenuItem.Text = "&Dados de baja";
            this.dadosDeBajaToolStripMenuItem.Click += new System.EventHandler(this.dadosDeBajaToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.prestamosToolStripMenuItem.Text = "&Prestamos";
            this.prestamosToolStripMenuItem.Click += new System.EventHandler(this.prestamosToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(13, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(571, 314);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // listViewLibros2
            // 
            this.listViewLibros2.Location = new System.Drawing.Point(12, 27);
            this.listViewLibros2.Name = "listViewLibros2";
            this.listViewLibros2.Size = new System.Drawing.Size(572, 314);
            this.listViewLibros2.TabIndex = 2;
            this.listViewLibros2.UseCompatibleStateImageBehavior = false;
            this.listViewLibros2.Visible = false;
            this.listViewLibros2.SelectedIndexChanged += new System.EventHandler(this.listViewLibros2_SelectedIndexChanged);
            this.listViewLibros2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewLibros2_ItemSelectionChanged);
            // 
            // listViewEjemplares3
            // 
            this.listViewEjemplares3.Location = new System.Drawing.Point(13, 27);
            this.listViewEjemplares3.Name = "listViewEjemplares3";
            this.listViewEjemplares3.Size = new System.Drawing.Size(571, 314);
            this.listViewEjemplares3.TabIndex = 3;
            this.listViewEjemplares3.UseCompatibleStateImageBehavior = false;
            this.listViewEjemplares3.Visible = false;
            this.listViewEjemplares3.SelectedIndexChanged += new System.EventHandler(this.listViewEjemplares3_SelectedIndexChanged);
            this.listViewEjemplares3.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewEjemplares3_ItemSelectionChanged);
            // 
            // listViewPrestamos4
            // 
            this.listViewPrestamos4.Location = new System.Drawing.Point(13, 27);
            this.listViewPrestamos4.Name = "listViewPrestamos4";
            this.listViewPrestamos4.Size = new System.Drawing.Size(627, 314);
            this.listViewPrestamos4.TabIndex = 4;
            this.listViewPrestamos4.UseCompatibleStateImageBehavior = false;
            this.listViewPrestamos4.Visible = false;
            this.listViewPrestamos4.SelectedIndexChanged += new System.EventHandler(this.listViewPrestamos4_SelectedIndexChanged);
            this.listViewPrestamos4.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewPrestamos4_ItemSelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 353);
            this.Controls.Add(this.listViewPrestamos4);
            this.Controls.Add(this.listViewEjemplares3);
            this.Controls.Add(this.listViewLibros2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem ejemplarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ejemplarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem verListaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ejemplarToolStripMenuItem3;
        private System.Windows.Forms.ListView listViewLibros2;
        private System.Windows.Forms.ListView listViewEjemplares3;
        private System.Windows.Forms.ListView listViewPrestamos4;
        private System.Windows.Forms.ToolStripMenuItem disponiblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosDeBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
    }
}

