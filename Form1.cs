using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace CopiaDeBiblio
{
    public partial class Form1 : Form
    {
        ArrayList usuarios;
        Biblioteca biblio;
        ArrayList libros;
        ArrayList ejemplares;
        ArrayList prestamos;

        private string nomAp;
        private string numDoc;
        private string mail;
        private DateTime fecha;
        private string tit;
        private bool dis;

        public const int maxPrestamos = 5;
        public static AutoCompleteStringCollection autoCompleteDni;
        public static AutoCompleteStringCollection autoCompleteCodPat;

        public Form1()
        {
            InitializeComponent();
            biblio = new Biblioteca();
            usuarios = new ArrayList();
            libros = new ArrayList();
            ejemplares = new ArrayList();
            prestamos = new ArrayList();
            //Booleano de estado de ejemplar
            //dis = false;
            //ListView tamaños
            listView1.Height = this.Height - 74;
            listView1.Width = this.Width - 41;
            listViewLibros2.Height = this.Height - 74;
            listViewLibros2.Width = this.Width - 41;
            listViewEjemplares3.Height = this.Height - 74;
            listViewEjemplares3.Width = this.Width - 41;
            listViewPrestamos4.Height = this.Height - 74;
            listViewPrestamos4.Width = this.Width - 41;

            autoCompleteDni = new AutoCompleteStringCollection();
            autoCompleteCodPat = new AutoCompleteStringCollection();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AgregarUsuario
            int dni;
            VentanaSecundaria vc = new VentanaSecundaria();
            vc.labNomAp.Text = "Nombre y Apellido: ";
            vc.labDni.Text = "DNI: ";
            vc.labMail.Text = "E-Mail: ";
            usuarios = biblio.RetornarListaDeUsuarios();

            while (vc.ShowDialog() == DialogResult.Retry)
            {
                if (vc.tbxDni.Text != "" && vc.tbxNomAp.Text != "" && vc.tbxMail.Text != "")
                {
                    try
                    {
                        dni = Convert.ToInt32(vc.tbxDni.Text);
                        Usuario unUsuario = new Usuario(vc.tbxNomAp.Text,
                                                        vc.tbxMail.Text,
                                                        dni);

                        autoCompleteDni.Add(vc.tbxDni.Text);

                        biblio.AgregarUsuario(unUsuario);//vc.tbxNomAp.Text, vc.tbxMail.Text, dni);

                        usuarios = biblio.RetornarListaDeUsuarios();

                        MessageBox.Show("El usuario fue cargado exitosamente");
                        
                        //this.ActualizarListarUsuarios();
                        
                        vc.tbxNomAp.Clear();
                        vc.tbxDni.Clear();
                        vc.tbxMail.Clear();
                    }
                    catch (FormatException ez)
                    {
                        MessageBox.Show("Error!" + " " + ez.Message);
                    }
                    catch (Exception ez)
                    {
                        MessageBox.Show("Error!" + " " + ez.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Falta llenar un campo");
                }
            }
            vc.Dispose();
        }

        public void ActualizarListarUsuarios()
        {
            //ActualizarListViewDeUsuarios

            listView1.Visible = true;
            listViewLibros2.Visible = false;
            listViewEjemplares3.Visible = false;
            listViewPrestamos4.Visible = false;

            listView1.View = System.Windows.Forms.View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Clear();
            listView1.Items.Clear();

            listView1.Columns.Add("DNI", 67);
            listView1.Columns.Add("Nombre y Apellido", 107);
            listView1.Columns.Add("E-mail", 139);

            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (Usuario usuario in this.usuarios)
            {
                ListViewItem listViewItem = new ListViewItem(usuario.Dni().ToString());
                listViewItem.SubItems.Add(usuario.NAp);
                listViewItem.SubItems.Add(usuario.Mail);
                listView1.Items.Add(listViewItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int dniSeleccionado = 0;
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Evento ItemSelectio del ListViewDeUsuarios
            if (e.IsSelected)
            {
                string selectedIDText = e.Item.Text;
                dniSeleccionado = Convert.ToInt32(selectedIDText);

                foreach (Usuario usuario in usuarios)
                {
                    if (dniSeleccionado == usuario.Dni())
                    {
                        nomAp = usuario.NAp;
                        numDoc = usuario.Dni().ToString();
                        mail = usuario.Mail;
                        break;
                    }
                }
            }
            else
            {
                dniSeleccionado = 0;
            }
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Editar Usuario
            VentanaSecundaria vc = new VentanaSecundaria();
            vc.tbxNomAp.Text = nomAp;
            vc.tbxDni.Text = numDoc;
            vc.tbxMail.Text = mail;

            if (dniSeleccionado != 0)
            {
                if (vc.ShowDialog() == DialogResult.Retry)
                {
                    Usuario miUsuario;
                    miUsuario = biblio.EditarUsuario(dniSeleccionado);

                    if (vc.tbxDni.Text != miUsuario.Dni().ToString())
                    {
                        autoCompleteDni.Remove(miUsuario.Dni().ToString());
                        autoCompleteDni.Add(vc.tbxDni.Text);
                    }

                    miUsuario = new Usuario(vc.tbxNomAp.Text,
                                            vc.tbxMail.Text,
                                            Convert.ToInt32(vc.tbxDni.Text));
                    
                    biblio.AgregarUsuario(miUsuario);
                    usuarios = biblio.RetornarListaDeUsuarios();
                    //this.ActualizarListarUsuarios();
                }
            }
            else
            {
                MessageBox.Show("No se puede editar, si no hay ningun usuario seleccionado");
            }
            vc.Dispose();
        }

        private void usuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Eliminar Usuario
            if (dniSeleccionado != 0)
            {
                biblio.EliminarUsuario(dniSeleccionado);
                usuarios = biblio.RetornarListaDeUsuarios();
                MessageBox.Show("Usuario Eliminado con éxito");
                autoCompleteDni.Remove(dniSeleccionado.ToString());
                //this.ActualizarListarUsuarios();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar usuario. Asegurese de que haya seleccionado un usuario");
            }
        }

        private void usuarioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Listar Usuario en el ListView
            if (this.usuarios.Count == 0)
            {
                MessageBox.Show("La lista esta vacia! Asegurese de cargar al menos un usuario para poder visualizarlo!");
            }

            listView1.Visible = true;
            listViewLibros2.Visible = false;
            listViewEjemplares3.Visible = false;
            listViewPrestamos4.Visible = false;

            listView1.View = System.Windows.Forms.View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Clear();
            listView1.Items.Clear();

            listView1.Columns.Add("DNI", 67);
            listView1.Columns.Add("Nombre y Apellido", 107);
            listView1.Columns.Add("E-mail", 139);
            listView1.Columns.Add("Habilitado", 77);

            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            string ret = "";
            foreach (Usuario usuario in this.usuarios)
            {
                ListViewItem listViewItem = new ListViewItem(usuario.Dni().ToString());
                listViewItem.SubItems.Add(usuario.NAp);
                listViewItem.SubItems.Add(usuario.Mail);
                if (!usuario.Estado)
                {
                    ret = "Si";
                }
                else
                {
                    ret = "No";
                }
                listViewItem.SubItems.Add(ret);
                listView1.Items.Add(listViewItem);
            }
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaSecundaria vc = new VentanaSecundaria();
            vc.labNomAp.Text = "Titulo del libro: ";
            vc.labDni.Text = "Codigo ISBN: ";
            vc.labMail.Text = "Autor del libro: ";
            libros = biblio.RetornarListaDeLibros();

            while (vc.ShowDialog() == DialogResult.Retry)
            {
                if (vc.tbxDni.Text != "" && vc.tbxNomAp.Text != "" && vc.tbxMail.Text != "")
                {
                    Libro unLibro = new Libro(vc.tbxDni.Text,vc.tbxNomAp.Text, vc.tbxMail.Text);

                    if (!unLibro.Estado)
                    {
                        biblio.AgregarLibro(unLibro);//vc.tbxNomAp.Text, vc.tbxMail.Text, dni);
                        libros = biblio.RetornarListaDeLibros();

                        MessageBox.Show("El Libro fue cargado exitosamente");
                        //this.ActulizarListarLibros();
                        vc.tbxNomAp.Clear();
                        vc.tbxDni.Clear();
                        vc.tbxMail.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Codigo ISBN Invalido por favor verifique que dicho codigo sea correcto e ingreselo de nuevo");
                    }
                }
                else
                {
                    MessageBox.Show("Falta llenar un campo");
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VentanaSecundaria vc = new VentanaSecundaria();
            vc.labNomAp.Text = "Titulo del libro: ";
            vc.labDni.Text = "Codigo ISBN: ";
            vc.labMail.Text = "Autor del libro: ";
            //vc.tbxDni.MaxLength = 17;
            vc.tbxNomAp.Text = nomAp;
            vc.tbxDni.Text = numDoc;
            vc.tbxMail.Text = mail;

            if (isbnSeleccionado != "")
            {
                if (vc.ShowDialog() == DialogResult.Retry)
                {
                    Libro milibro;

                    milibro = biblio.EditarLibro(isbnSeleccionado);

                    milibro = new Libro(vc.tbxDni.Text,
                                        vc.tbxNomAp.Text,
                                        vc.tbxMail.Text);
                    if (!milibro.Estado)
                    {
                        biblio.AgregarLibro(milibro);
                        libros = biblio.RetornarListaDeLibros();

                        //this.ActulizarListarLibros();
                    }
                    else
                    {
                        MessageBox.Show("ISBN invalido verifiquelo e ingreselo nuevamente");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede editar, si no hay ningun libro seleccionado");
            }
            //vc.tbxDni.MaxLength = 32767;
            vc.Dispose();
        }

        private void listViewLibros2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string isbnSeleccionado = "";
        private void listViewLibros2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                isbnSeleccionado = e.Item.Text;
                
                foreach (Libro lib in libros)
                {
                    if (isbnSeleccionado == lib.CodISBN)
                    {
                        nomAp = lib.Titulo;
                        numDoc = lib.CodISBN;
                        mail = lib.Autor;
                        break;
                    }
                }
            }
            else
            {
                isbnSeleccionado = "";
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (isbnSeleccionado != "")
            {
                biblio.EliminarLibro(isbnSeleccionado);
                libros = biblio.RetornarListaDeLibros();
                MessageBox.Show("El Libro Eliminado con éxito");
                //this.ActulizarListarLibros();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el libro. Asegurese de que haya seleccionado un libro");
            }
        }

        private void libroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.libros.Count == 0)
            {
                MessageBox.Show("La lista esta vacia! Asegurese de cargar al menos un libro para poder visualizarlo!");
            }

            listView1.Visible = false;
            listViewLibros2.Visible = true;
            listViewEjemplares3.Visible = false;
            listViewPrestamos4.Visible = false;

            listViewLibros2.View = System.Windows.Forms.View.Details;
            listViewLibros2.GridLines = true;
            listViewLibros2.FullRowSelect = true;

            listViewLibros2.Columns.Clear();
            listViewLibros2.Items.Clear();

            listViewLibros2.Columns.Add("Codigo ISBN", 107);
            listViewLibros2.Columns.Add("Titulo", 70);
            listViewLibros2.Columns.Add("Autor", 100);

            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            foreach (Libro lib in this.libros)
            {
                ListViewItem listViewItem = new ListViewItem(lib.CodISBN.ToString());
                listViewItem.SubItems.Add(lib.Titulo);
                listViewItem.SubItems.Add(lib.Autor);
                listViewLibros2.Items.Add(listViewItem);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            listView1.Height = this.Height - 74;
            listView1.Width = this.Width - 41;
            listViewLibros2.Height = this.Height - 74;
            listViewLibros2.Width = this.Width - 41;
            listViewEjemplares3.Height = this.Height - 74;
            listViewEjemplares3.Width = this.Width - 41;
            listViewPrestamos4.Height = this.Height - 74;
            listViewPrestamos4.Width = this.Width - 41;
        }

        private void ejemplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Cambiar el boleano de la clase y del form
             * que siempre este disponible al
             * principio! Y que despues lo puedas
             * cambiar a NO disponible*/
            VentanaSecundaria vc = new VentanaSecundaria();
            if (isbnSeleccionado != "")
            {
                vc.labNomAp.Text = "Titulo del libro: ";
                vc.labDni.Text = "Codigo ISBN: ";
                vc.labMail.Text = "Autor del libro: ";
                //vc.tbxDni.MaxLength = 17;
                vc.tbxNomAp.Text = nomAp;
                vc.tbxDni.Text = numDoc;
                vc.tbxMail.Text = mail;
                vc.tbxDni.Enabled = false;
                vc.tbxNomAp.Enabled = false;
                vc.tbxMail.Enabled = false;
                vc.tbxCodPat.Enabled = false;
                vc.labUbicacion.Visible = true;
                vc.labCodPat.Visible = true;
                vc.tbxUbicacion.Visible = true;
                vc.tbxCodPat.Visible = true;
                vc.cbEstadoEjemplar.Visible = true;
                vc.Width = 570;

                //Cambiar las propiedades de los componentes

                ejemplares = biblio.RetornarListaDeEjemplar();

                while (vc.ShowDialog() == DialogResult.Retry)
                {
                    if (vc.tbxUbicacion.Text != "")
                    {

                        Libro milibro;
                        //Hacer un metodo buscar libro
                        milibro = biblio.BuscarLibro(isbnSeleccionado);

                        Ejemplar ej = new Ejemplar(vc.tbxUbicacion.Text, milibro);
                        vc.tbxCodPat.Text = ej.NumPatrimonial.ToString("0000");

                        autoCompleteCodPat.Add(ej.NumPatrimonial.ToString("0000"));

                        biblio.AgregarEjemplar(ej);//vc.tbxNomAp.Text, vc.tbxMail.Text, dni);

                        if (!vc.cbEstadoEjemplar.Checked)
                        {
                            ej.NoDisponible();
                        }
                        else
                        {
                            ej.Disponible();
                        }

                        ejemplares = biblio.RetornarListaDeEjemplar();

                        MessageBox.Show("El ejemplar fue cargado con exito");
                        //this.ActulizarListarEjemplares();

                    }
                    else
                    {
                        MessageBox.Show("Falta llenar un campo");
                    }
                }
            }
            else
            {
                vc.Close();
                vc.Dispose();
                MessageBox.Show("Asegurese de seleccionar un Libro para poder agregar un ejemplar");
            }
            vc.tbxNomAp.Clear();
            vc.tbxDni.Clear();
            vc.tbxMail.Clear();
            vc.tbxDni.Enabled = true;
            vc.tbxNomAp.Enabled = true;
            vc.tbxMail.Enabled = true;
            vc.tbxCodPat.Enabled = false;
            vc.labUbicacion.Visible = false;
            vc.labCodPat.Visible = false;
            vc.tbxUbicacion.Visible = false;
            vc.tbxCodPat.Visible = false;
            vc.cbEstadoEjemplar.Visible = false;
            vc.Width = 315;
            vc.Dispose();
        }

        public void ActulizarListarLibros()
        {
            //ActualizarListViewDeUsuarios

            listView1.Visible = false;
            listViewLibros2.Visible = true;
            listViewEjemplares3.Visible = false;
            listViewPrestamos4.Visible = false;

            listViewLibros2.View = System.Windows.Forms.View.Details;
            listViewLibros2.GridLines = true;
            listViewLibros2.FullRowSelect = true;

            listViewLibros2.Columns.Clear();
            listViewLibros2.Items.Clear();

            listViewLibros2.Columns.Add("Codigo ISBN", 67);
            listViewLibros2.Columns.Add("Titulo", 107);
            listViewLibros2.Columns.Add("Autor", 139);

            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (Libro lib in this.libros)
            {
                ListViewItem listViewItem = new ListViewItem(lib.CodISBN);
                listViewItem.SubItems.Add(lib.Titulo);
                listViewItem.SubItems.Add(lib.Autor);
                listView1.Items.Add(listViewItem);
            }
        }

        private void ejemplarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VentanaSecundaria vc = new VentanaSecundaria();
            vc.labNomAp.Text = "Titulo del libro: ";
            vc.labDni.Text = "Codigo ISBN: ";
            vc.labMail.Text = "Autor del libro: ";
            //vc.tbxDni.MaxLength = 17;
            vc.tbxNomAp.Text = nomAp;
            vc.tbxDni.Text = numDoc;
            vc.tbxMail.Text = mail;
            vc.tbxDni.Enabled = false;
            vc.tbxNomAp.Enabled = false;
            vc.tbxMail.Enabled = false;
            vc.tbxCodPat.Enabled = false;
            vc.labUbicacion.Visible = true;
            vc.labCodPat.Visible = true;
            vc.tbxUbicacion.Visible = true;
            vc.tbxCodPat.Visible = true;
            vc.cbEstadoEjemplar.Visible = true;
            vc.cbDarDeBaja.Visible = true;
            vc.Width = 570;
            vc.cbEstadoEjemplar.Checked = dis;
            vc.tbxCodPat.Text = numPatSeleccionado.ToString("0000");

            ejemplares = biblio.RetornarListaDeEjemplar();

            if (numPatSeleccionado > -1)
            {
                if (vc.ShowDialog() == DialogResult.Retry)
                {
                    Ejemplar miEj;
                    miEj = biblio.BuscarEjemplar(numPatSeleccionado);

                    if (vc.tbxUbicacion.Text != "" && vc.tbxCodPat.Text != "")
                    {
                        Libro milibro;
                        milibro = biblio.BuscarLibro(miEj.ISBNEj);

                        biblio.EliminarEjemplar(numPatSeleccionado);

                        miEj = new Ejemplar(vc.tbxUbicacion.Text, Convert.ToInt32(vc.tbxCodPat.Text),milibro);
                        biblio.AgregarEjemplar(miEj);

                        if (vc.cbEstadoEjemplar.Checked)
                        {
                            miEj.Disponible();
                        }
                        else
                        {
                            miEj.NoDisponible();
                        }

                        if (vc.cbDarDeBaja.Checked)
                        {
                            miEj.DarDeBaja = true;
                            miEj.NoDisponible();
                        }
                        else
                        {
                            miEj.DarDeBaja = false;
                        }

                        ejemplares = biblio.RetornarListaDeEjemplar();
                        MessageBox.Show("Ejemplar cargado con exito!");
                        //this.ActulizarListarEjemplares();
                    }
                    else
                    {
                        MessageBox.Show("Falta completar algun campo!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede editar, si no hay ningun ejemplar seleccionado");
            }
            vc.tbxNomAp.Clear();
            vc.tbxDni.Clear();
            vc.tbxMail.Clear();
            vc.tbxDni.Enabled = true;
            vc.tbxNomAp.Enabled = true;
            vc.tbxMail.Enabled = true;
            vc.tbxCodPat.Enabled = false;
            vc.labUbicacion.Visible = false;
            vc.labCodPat.Visible = false;
            vc.tbxUbicacion.Visible = false;
            vc.tbxCodPat.Visible = false;
            vc.cbEstadoEjemplar.Visible = false;
            vc.cbDarDeBaja.Visible = false;
            vc.Width = 315;
            vc.Dispose();
        }

        private void listViewEjemplares3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int numPatSeleccionado = -1;
        private void listViewEjemplares3_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {            
            if (e.IsSelected)
            {
                string selectedIDText = e.Item.Text;
                numPatSeleccionado = Convert.ToInt32(selectedIDText);

                foreach (Ejemplar ej in ejemplares)
                {
                    if (numPatSeleccionado == ej.NumPatrimonial)
                    {
                        nomAp = ej.Ubicacion;
                        numDoc = ej.NumPatrimonial.ToString("0000");
                        mail = ej.Estado.ToString();
                        dis = ej.Estado;
                        break;
                    }
                }
            }
            else
            {
                numPatSeleccionado = -1;
            }
        }

        private void ejemplarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (numPatSeleccionado > -1)
            {
                biblio.EliminarEjemplar(numPatSeleccionado);
                ejemplares = biblio.RetornarListaDeEjemplar();
                MessageBox.Show("Ejemplar Eliminado con éxito");
                autoCompleteCodPat.Remove(numPatSeleccionado.ToString());
                //this.ActualizarListarEjemplares();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el ejemplar. Asegurese de que haya seleccionado un ejemplar");
            }
        }

        private void ejemplarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void disponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Listar Usuario en el ListView
            if (this.ejemplares.Count == 0)
            {
                MessageBox.Show("La lista esta vacia! Asegurese de cargar al menos un ejemplar para poder visualizarlo!");
            }

            listView1.Visible = false;
            listViewLibros2.Visible = false;
            listViewEjemplares3.Visible = true;
            listViewPrestamos4.Visible = false;

            listViewEjemplares3.View = System.Windows.Forms.View.Details;
            listViewEjemplares3.GridLines = true;
            listViewEjemplares3.FullRowSelect = true;

            listViewEjemplares3.Columns.Clear();
            listViewEjemplares3.Items.Clear();

            listViewEjemplares3.Columns.Add("Codigo Patrimonial", 106);
            listViewEjemplares3.Columns.Add("Titulo de la Obra", 107);
            listViewEjemplares3.Columns.Add("Disponible", 100);
            listViewEjemplares3.Columns.Add("Ubicacion", 100);

            string ret = "";

            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            foreach (Ejemplar ej in this.ejemplares)
            {
                if (!ej.DarDeBaja)
                {
                    ListViewItem listViewItem = new ListViewItem(ej.NumPatrimonial.ToString("0000"));
                    listViewItem.SubItems.Add(ej.NomEj);
                    if (ej.Estado)
                    {
                        ret = "Si";
                    }
                    else
                    {
                        ret = "No";
                    }
                    listViewItem.SubItems.Add(ret);
                    listViewItem.SubItems.Add(ej.Ubicacion);
                    listViewEjemplares3.Items.Add(listViewItem);
                }
            }
        }

        private void dadosDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Listar Usuario en el ListView
            if (this.ejemplares.Count == 0)
            {
                MessageBox.Show("La lista esta vacia! Asegurese de cargar al menos un ejemplar para poder visualizarlo!");
            }

            listView1.Visible = false;
            listViewLibros2.Visible = false;
            listViewEjemplares3.Visible = true;
            listViewPrestamos4.Visible = false;

            listViewEjemplares3.View = System.Windows.Forms.View.Details;
            listViewEjemplares3.GridLines = true;
            listViewEjemplares3.FullRowSelect = true;

            listViewEjemplares3.Columns.Clear();
            listViewEjemplares3.Items.Clear();

            listViewEjemplares3.Columns.Add("Codigo Patrimonial", 106);
            listViewEjemplares3.Columns.Add("Titulo de la Obra", 107);
            listViewEjemplares3.Columns.Add("Disponible", 100);
            listViewEjemplares3.Columns.Add("Ubicacion", 100);

            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            foreach (Ejemplar ej in this.ejemplares)
            {
                if (ej.DarDeBaja)
                {
                    ListViewItem listViewItem = new ListViewItem(ej.NumPatrimonial.ToString("0000"));
                    listViewItem.SubItems.Add(ej.NomEj);
                    listViewItem.SubItems.Add("No! Fueron dados de baja");
                    listViewItem.SubItems.Add(ej.Ubicacion);
                    listViewEjemplares3.Items.Add(listViewItem);
                }
            }
        }

        public void AcutalizarListarEjemplares()
        {
            listView1.Visible = false;
            listViewLibros2.Visible = false;
            listViewEjemplares3.Visible = true;
            listViewPrestamos4.Visible = false;

            listViewEjemplares3.View = System.Windows.Forms.View.Details;
            listViewEjemplares3.GridLines = true;
            listViewEjemplares3.FullRowSelect = true;

            listViewEjemplares3.Columns.Clear();
            listViewEjemplares3.Items.Clear();

            listViewEjemplares3.Columns.Add("Codigo Patrimonial", 106);
            listViewEjemplares3.Columns.Add("Titulo de la Obra", 107);
            listViewEjemplares3.Columns.Add("Disponible", 100);
            listViewEjemplares3.Columns.Add("Ubicacion", 100);

            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            foreach (Ejemplar ej in this.ejemplares)
            {
                if (ej.DarDeBaja)
                {
                    ListViewItem listViewItem = new ListViewItem(ej.NumPatrimonial.ToString("0000"));
                    listViewItem.SubItems.Add(ej.NomEj);
                    listViewItem.SubItems.Add(ej.Ubicacion);
                    listViewEjemplares3.Items.Add(listViewItem);
                }
            }
        }
        
        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ret = "";
            Prestamo unPrestamo;
            VentanaDeCarga vc = new VentanaDeCarga();
            //vc.autoCompletDni = autoCompleteDni;
            //vc.autoCompletCodPat = autoCompleteCodPat;

            if (vc.ShowDialog() == DialogResult.OK)
            {
                Usuario unUsuario = biblio.BuscarUsuario(Convert.ToInt32(vc.tbxBuscarDni.Text));
                Ejemplar unEjemplar = biblio.BuscarEjemplar(Convert.ToInt32(vc.tbxBuscarCodPat.Text));
                
                if (unUsuario == null)
                {
                    ret = "Con el DNI ingresado! Por favor verifique y vuelva a ingresarlo!";
                    MessageBox.Show("No existe un usuario con ese numero dni");
                }
                else if (unEjemplar == null)
                {
                    ret = "Con el Codigo Patrimonial ingresado! Por favor verifique y vuelva a ingresarlo!";
                    MessageBox.Show("No existe un ejemplar con ese numero de codigo patrimonial");
                }
                else if (vc.fechaDev != new DateTime() && unUsuario != null && unEjemplar != null)
                {
                    if (unUsuario.ContDePrestamos < maxPrestamos && unEjemplar.Estado)
                    {
                        unPrestamo = new Prestamo(vc.fechaDev,unUsuario, unEjemplar);
                        if (unPrestamo != null)
                        {
                            unUsuario.ContarPrestamos();
                            unEjemplar.NoDisponible();
                            biblio.AgregarPrestamo(unPrestamo);
                            prestamos = biblio.RetornarListaDePrestamo();
                            MessageBox.Show("Se agrego con exito el prestamo!");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el prestamo!");
                        }
                    }
                    else
                    {
                        if (unUsuario.ContDePrestamos == maxPrestamos)
                        {
                            MessageBox.Show("El usuario ya tiene 5 prestamos! No puede realizar mas prestamos hasta que devuelva uno o mas ejemplares de los que posee!");
                        }
                        if (!unEjemplar.Estado)
                        {
                            MessageBox.Show("El ejemplar no esta disponible para ser prestado! No puede prestar este ejemplar ya que ya fue prestado o esta dado de baja o no se encuentra disponible!");
                        }

                    }
                }
                else if (vc.fechaDev == new DateTime() && unUsuario != null && unEjemplar != null)
                {
                    if (unUsuario.ContDePrestamos < maxPrestamos && unEjemplar.Estado)
                    {
                        unPrestamo = new Prestamo(unUsuario, unEjemplar);
                        if (unPrestamo != null)
                        {
                            unUsuario.ContarPrestamos();
                            unEjemplar.NoDisponible();
                            biblio.AgregarPrestamo(unPrestamo);
                            prestamos = biblio.RetornarListaDePrestamo();
                            MessageBox.Show("Se agrego con exito el prestamo!");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el prestamo!");
                        }
                    }
                    else
                    {
                        if (unUsuario.ContDePrestamos == maxPrestamos)
                        {
                            MessageBox.Show("El usuario ya tiene 5 prestamos! No puede realizar mas prestamos hasta que devuelva uno o mas ejemplares de los que posee!");
                        }
                        if (!unEjemplar.Estado)
                        {
                            MessageBox.Show("El ejemplar no esta disponible para ser prestado! No puede prestar este ejemplar ya que ya fue prestado o esta dado de baja o no se encuentra disponible!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Asegurese de que el DNI del usuario sea correcto y el Codigo Patrimonial del ejemplar sea correcto!");
                }
            }
            vc.Dispose();
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ret = "";
            Prestamo unPrestamo;
            VentanaDeCarga vc = new VentanaDeCarga();
            vc.autoCompletDni = autoCompleteDni;
            vc.autoCompletCodPat = autoCompleteCodPat;

            if (vc.ShowDialog() == DialogResult.OK)
            {
                if (vc.tbxBuscarDni.Text != "" && vc.tbxBuscarCodPat.Text != "")
                {
                    Usuario unUsuario = biblio.BuscarUsuario(Convert.ToInt32(vc.tbxBuscarDni.Text));
                    Ejemplar unEjemplar = biblio.BuscarEjemplar(Convert.ToInt32(vc.tbxBuscarCodPat.Text));
                    unPrestamo = biblio.BuscarPrestamo(Convert.ToInt32(vc.tbxBuscarDni.Text), Convert.ToInt32(vc.tbxBuscarCodPat.Text));
                    if (unUsuario == null)
                    {
                        ret = "Con el DNI ingresado! Por favor verifique y vuelva a ingresarlo!";
                        MessageBox.Show("No existe un usuario con ese numero dni");
                    }
                    else if (unEjemplar == null)
                    {
                        ret = "Con el Codigo Patrimonial ingresado! Por favor verifique y vuelva a ingresarlo!";
                        MessageBox.Show("No existe un ejemplar con ese numero de codigo patrimonial");
                    }
                    else if (unPrestamo == null)
                    {                        
                        if ((unUsuario == null) && (unEjemplar == null))
                        {
                            ret = "Con el DNI y Codigo Patrimonial ingresado! Por favor verifique y vuelva a ingresar!";
                        }
                        MessageBox.Show("No existe un prestamo" + " " + ret);
                    }
                    else if (unUsuario.ContDePrestamos > 0 && !unEjemplar.Estado)
                    {
                        unUsuario.RestarPrestamos();
                        unEjemplar.Disponible();
                        biblio.EliminarPrestamo(Convert.ToInt32(vc.tbxBuscarDni.Text), Convert.ToInt32(vc.tbxBuscarCodPat.Text));
                        prestamos = biblio.RetornarListaDePrestamo();

                        MessageBox.Show("Se devolvio el ejemplar con exito!");
                    }
                    else
                    {
                        if (unUsuario.ContDePrestamos <= 0)
                        {
                            MessageBox.Show("El usuario no puede devolver prestamos sino tiene niguno prestamo realizado!");
                        }
                        if (unEjemplar.Estado)
                        {
                            MessageBox.Show("El ejemplar esta disponible para ser prestado! Por ende no puede ser devuelto ya que no fue prestado!");
                        }
                    }
                }
                /*else if (vc.tbxBuscarDni.Text != "" && vc.tbxBuscarCodPat.Text != "")
                {
                    unPrestamo = biblio.BuscarPrestamo(Convert.ToInt32(vc.tbxBuscarDni.Text), Convert.ToInt32(vc.tbxBuscarCodPat.Text));

                    Usuario unUsuario = biblio.BuscarUsuario(Convert.ToInt32(vc.tbxBuscarDni.Text));
                    Ejemplar unEjemplar = biblio.BuscarEjemplar(Convert.ToInt32(vc.tbxBuscarCodPat.Text));
                    
                    if (unUsuario.ContDePrestamos > 0  && !unEjemplar.Estado)
                    {
                        unEjemplar.Disponible();
                        biblio.EliminarPrestamo(Convert.ToInt32(vc.tbxBuscarDni.Text), Convert.ToInt32(vc.tbxBuscarCodPat.Text));
                        prestamos = biblio.RetornarListaDePrestamo();

                        MessageBox.Show("Se devolvio el ejemplar con exito!");
                    }
                    else
                    {
                        if (unUsuario.ContDePrestamos <= 0)
                        {
                            MessageBox.Show("El usuario no puede devolver prestamos sino tiene niguno prestamo realizado!");
                        }
                        if (unEjemplar.Estado)
                        {
                            MessageBox.Show("El ejemplar esta disponible para ser prestado! Por ende no puede ser devuelto ya que no fue prestado!");
                        }
                    }
                }*/
                else
                {
                    MessageBox.Show("Falta llenar un campo!");
                }
            }
            vc.Dispose();
        }

        private void listViewPrestamos4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //int dniPrestamo = 0;
        //int codPatPrestamo = -1;
        private void listViewPrestamos4_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            /*if (e.IsSelected)
            {
                dniPrestamo = Convert.ToInt32(e.Item.SubItems.Count == 2);
                codPatPrestamo = Convert.ToInt32(e.Item.SubItems.Count == 3);

                foreach (Prestamo pres in prestamos)
                {
                    if ((dniPrestamo == pres.DniDeUsuario) && (codPatPrestamo == pres.CodigoPatrimonialDelEjemplar))
                    {
                        nomAp = pres.UsuarioQueLoTiene;
                        numDoc = pres.DniDeUsuario.ToString();
                        mail = pres.CodigoPatrimonialDelEjemplar.ToString("0000");
                        tit = pres.TituloDeEjemplar;
                        if (DateTime.Now > pres.FechaDevolucion)
                        {
                            pres.InhabilitarUsuario();
                            MessageBox.Show("Usuario " + pres.UsuarioQueLoTiene + " " + pres.DniDeUsuario + " " +
                                "Esta INHABILITADO para retirar libros! Hasta que no devuelva" + " " + pres.TituloDeEjemplar
                                + " " + pres.CodigoPatrimonialDelEjemplar.ToString("0000") + " " + "Fecha que retiro dicho libro: " + " " +
                                pres.FechaActual + " " + "Fecha de devolucion: " + " " + pres.FechaDevolucion + " " +
                                "La fecha de hoy es: " + " " + DateTime.Now.ToString("dd/MM/yyyy"));
                        }
                        else
                        {
                            pres.HabilitarUsuario();
                        }
                        break;
                    }
                }
            }
            else
            {
                dniPrestamo = 0;
                codPatPrestamo = -1;
            }*/
        }

        private void ActualizarFechaDePrestamos()
        {
            if (prestamos.Count != 0)
            {
                foreach (Prestamo pres in prestamos)
                {
                    if (DateTime.Now > pres.FechaDevolucion)
                    {
                        pres.InhabilitarUsuario();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay hecho ningun prestamo!");
            }
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.prestamos.Count == 0)
            {
                MessageBox.Show("La lista esta vacia! Asegurese de cargar al menos un ejemplar para poder visualizarlo!");
            }

            listView1.Visible = false;
            listViewLibros2.Visible = false;
            listViewEjemplares3.Visible = false;
            listViewPrestamos4.Visible = true;

            listViewPrestamos4.View = System.Windows.Forms.View.Details;
            listViewPrestamos4.GridLines = true;
            listViewPrestamos4.FullRowSelect = true;

            listViewPrestamos4.Columns.Clear();
            listViewPrestamos4.Items.Clear();

            listViewPrestamos4.Columns.Add("Fecha del Prestamo", 106);
            listViewPrestamos4.Columns.Add("Usuario", 107);
            listViewPrestamos4.Columns.Add("DNI", 100);
            listViewPrestamos4.Columns.Add("Codigo Patrimonial", 100);
            listViewPrestamos4.Columns.Add("Titulo del Ejemplar",100);
            listViewPrestamos4.Columns.Add("Fecha de Devolucion",100);

            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            foreach (Prestamo pres in this.prestamos)
            {
                ListViewItem listViewItem = new ListViewItem(pres.FechaActual.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(pres.UsuarioQueLoTiene);
                listViewItem.SubItems.Add(pres.DniDeUsuario.ToString());
                listViewItem.SubItems.Add(pres.CodigoPatrimonialDelEjemplar.ToString("0000"));
                listViewItem.SubItems.Add(pres.TituloDeEjemplar);
                listViewItem.SubItems.Add(pres.FechaDevolucion.ToString("dd/MM/yyyy"));
                listViewPrestamos4.Items.Add(listViewItem);
            }
        }

        public void AcutalizarListarPrestamos()
        {
            listView1.Visible = false;
            listViewLibros2.Visible = false;
            listViewEjemplares3.Visible = false;
            listViewPrestamos4.Visible = true;

            listViewPrestamos4.View = System.Windows.Forms.View.Details;
            listViewPrestamos4.GridLines = true;
            listViewPrestamos4.FullRowSelect = true;

            listViewPrestamos4.Columns.Clear();
            listViewPrestamos4.Items.Clear();

            listViewPrestamos4.Columns.Add("Fecha del Prestamo", 106);
            listViewPrestamos4.Columns.Add("Usuario", 107);
            listViewPrestamos4.Columns.Add("DNI", 100);
            listViewPrestamos4.Columns.Add("Codigo Patrimonial", 100);
            listViewPrestamos4.Columns.Add("Titulo del Ejemplar", 100);
            listViewPrestamos4.Columns.Add("Fecha de Devolucion", 100);

            //listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            foreach (Prestamo pres in this.prestamos)
            {
                ListViewItem listViewItem = new ListViewItem(pres.FechaActual.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(pres.UsuarioQueLoTiene);
                listViewItem.SubItems.Add(pres.DniDeUsuario.ToString());
                listViewItem.SubItems.Add(pres.CodigoPatrimonialDelEjemplar.ToString("0000"));
                listViewItem.SubItems.Add(pres.TituloDeEjemplar);
                listViewItem.SubItems.Add(pres.FechaDevolucion.ToString("dd/MM/yyyy"));
                listViewEjemplares3.Items.Add(listViewItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Biblioteca.Inicializar();
            //Hacer foreach en la clase biblioteca para guardar autoComplete y volver asignarselo
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Biblioteca.Finalizar(biblio);
        }
    }
}