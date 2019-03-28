using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace CopiaDeBiblio
{
    [Serializable]
    class Biblioteca
    {
        private ArrayList listaDeUsuarios;
        private ArrayList listaDeEjemplares;
        private ArrayList listaDeLibros;
        private ArrayList listaDePrestamos;

        public Biblioteca()
        {
            listaDeUsuarios = new ArrayList();
            listaDeEjemplares = new ArrayList();
            listaDeLibros = new ArrayList();
            listaDePrestamos = new ArrayList();
        }

        public static void Finalizar(Biblioteca biblioteca)
        {
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream("biblioteca.dat", FileMode.OpenOrCreate, FileAccess.Write);
                IFormatter formatter = new BinaryFormatter();

                formatter.Serialize(fileStream, biblioteca);
            }
            catch (SerializationException e) 
            {
                MessageBox.Show("Error!" + " " + e.Message);   
            }
            finally
            {
                fileStream.Close();
                fileStream.Dispose();
            }
        }

        public static Biblioteca Inicializar()
        {
            FileStream fileStream = null;
            Biblioteca biblioteca = null;

            try
            {
                fileStream = new FileStream("biblioteca.dat", FileMode.OpenOrCreate, FileAccess.Read);
                IFormatter formatter = new BinaryFormatter();

                biblioteca = (Biblioteca)formatter.Deserialize(fileStream);

            }
            catch (SerializationException e) { }
            finally
            {
                fileStream.Close();
                fileStream.Dispose();
            }

            if (biblioteca != null) biblioteca = new Biblioteca();
            return biblioteca;
        }

        public void AgregarUsuario(Usuario miUsuario)
        {
            //unUsuario = new Usuarios(nomAp, mail, dni);
            listaDeUsuarios.Add(miUsuario);
        }

        public Usuario EditarUsuario(int dni)
        {
            int indice = 0, i = 0;
            Usuario ret = null;
            //listaDeUsuarios.Sort();

            foreach (Usuario usu in listaDeUsuarios)
            {
                if (usu.Dni() == dni)
                {
                    ret = (Usuario)listaDeUsuarios[indice];
                    i = indice;
                    break;
                }
                indice++;
            }
            listaDeUsuarios.RemoveAt(i);
            /*indice = listaDeUsuarios.BinarySearch(dni);

            if (indice != -1)
            {
                ret = (Usuario)listaDeUsuarios[indice];
                listaDeUsuarios.RemoveAt(indice);
            }*/
            return ret;
        }

        public string MostrarUsuarios()
        {
            string ret = null;
            foreach (Usuario usu in listaDeUsuarios)
            {
                ret = "\n" + " " + usu.ToString();
            }
            return ret;
        }

        public void EliminarUsuario(int dni)
        {
            int indice = 0, i = 1;
            //listaDeUsuarios.Sort();
            //indice = listaDeUsuarios.BinarySearch(dni);

            foreach (Usuario usu in listaDeUsuarios)
            {
                if (usu.Dni() == dni)
                {
                    i = indice;
                    break;
                }
                indice++;
            }
            listaDeUsuarios.RemoveAt(i);
        }

        public Usuario BuscarUsuario(int dni)
        {
            int indice = 0, i = 0;
            Usuario ret = null;
            //listaDeUsuarios.Sort();

            foreach (Usuario usu in listaDeUsuarios)
            {
                if (usu.Dni() == dni)
                {
                    ret = (Usuario)listaDeUsuarios[indice];
                    i = indice;
                }
                indice++;
            }
            return ret;
        }

        public ArrayList RetornarListaDeUsuarios()
        {
            ArrayList ret = new ArrayList();
            ret = listaDeUsuarios;
            return ret;
        }

        public void AgregarLibro(Libro unLibro)
        {
            listaDeLibros.Add(unLibro);
        }

        public Libro EditarLibro(string codISBN)
        {
            int indice = 0, i = 0;
            Libro ret = null;
            //listaDeUsuarios.Sort();

            foreach (Libro lib in listaDeLibros)
            {
                if (lib.CodISBN == codISBN)
                {
                    ret = (Libro)listaDeLibros[indice];
                    i = indice;
                    break;
                }
                indice++;
            }
            listaDeLibros.RemoveAt(i);
            /*indice = listaDeLibros.BinarySearch(codISBN);

            if (indice != -1)
            {
                ret = (Libro)listaDeLibros[indice];
                listaDeLibros.RemoveAt(indice);
            }*/
            return ret;
        }

        public string MostrarLibros()
        {
            string ret = null;
            foreach (Libro lib in listaDeLibros)
            {
                ret = "\n" + " " + lib.ToString();
            }
            return ret;
        }

        public void EliminarLibro(string codISBN)
        {
            int indice = 0, i = 0;
            //listaDeUsuarios.Sort();
            //indice = listaDeLibros.BinarySearch(codISBN);

            foreach (Libro lib in listaDeLibros)
            {
                if (codISBN == lib.CodISBN)
                {
                    i = indice;
                    break;
                }
                indice++;
            }
            listaDeLibros.RemoveAt(i);
        }

        public Libro BuscarLibro(string isbn)
        {
            int indice = 0, i = 0;
            Libro ret = null;
            //listaDeUsuarios.Sort();

            foreach (Libro lib in listaDeLibros)
            {
                if (lib.CodISBN == isbn)
                {
                    ret = (Libro)listaDeLibros[indice];
                    i = indice;
                }
                indice++;
            }
            return ret;
        }

        public ArrayList RetornarListaDeLibros()
        {
            ArrayList ret = new ArrayList();
            ret = listaDeLibros;
            return ret;
        }

        public void AgregarEjemplar(Ejemplar unEjemplar)
        {
            listaDeEjemplares.Add(unEjemplar);
        }

        public Ejemplar EditarEjemplar(int codPat)
        {
            int indice = 0, i = 0;
            Ejemplar ret = null;
            //listaDeUsuarios.Sort();

            foreach (Ejemplar ej in listaDeEjemplares)
            {
                if (ej.NumPatrimonial == codPat)
                {
                    ret = (Ejemplar)listaDeEjemplares[indice];
                    i = indice;
                }
                indice++;
            }
            listaDeEjemplares.RemoveAt(i);
            /*indice = listaDeLibros.BinarySearch(codISBN);

            if (indice != -1)
            {
                ret = (Libro)listaDeLibros[indice];
                listaDeLibros.RemoveAt(indice);
            }*/
            return ret;
        }

        public string MostrarEjemplar()
        {
            string ret = null;
            foreach (Ejemplar ej in listaDeEjemplares)
            {
                ret = "\n" + " " + ej.ToString();
            }
            return ret;
        }

        public void EliminarEjemplar(int codPat)
        {
            int indice = 0, i = 0;
            Ejemplar ret = null;
            //listaDeUsuarios.Sort();

            foreach (Ejemplar ej in listaDeEjemplares)
            {
                if (ej.NumPatrimonial == codPat)
                {
                    ret = (Ejemplar)listaDeEjemplares[indice];
                    i = indice;
                }
                indice++;
            }
            listaDeEjemplares.RemoveAt(i);
        }

        public Ejemplar BuscarEjemplar(int codPat)
        {
            int indice = 0, i = 0;
            Ejemplar ret = null;
            //listaDeUsuarios.Sort();

            foreach (Ejemplar ej in listaDeEjemplares)
            {
                if (ej.NumPatrimonial == codPat)
                {
                    ret = (Ejemplar)listaDeEjemplares[indice];
                    i = indice;
                }
                indice++;
            }
            return ret;
        }

        public ArrayList RetornarListaDeEjemplar()
        {
            ArrayList ret = new ArrayList();
            ret = listaDeEjemplares;
            return ret;
        }

        public void AgregarPrestamo(Prestamo unPrestamo)
        {
            listaDePrestamos.Add(unPrestamo);
        }

        public Prestamo EditarPrestamo(int dni, int codPat)
        {
            int indice = 0, i = 0;
            Prestamo ret = null;
            //listaDeUsuarios.Sort();

            foreach (Prestamo pres in listaDePrestamos)
            {
                if ((pres.DniDeUsuario == dni) && (pres.CodigoPatrimonialDelEjemplar == codPat))
                {
                    ret = (Prestamo)listaDePrestamos[indice];
                    i = indice;
                }
                indice++;
            }
            listaDePrestamos.RemoveAt(i);
            return ret;
        }

        public string MostrarPrestamo()
        {
            string ret = null;
            foreach (Prestamo pres in listaDePrestamos)
            {
                ret = "\n" + " " + pres.ToString();
            }
            return ret;
        }

        public void EliminarPrestamo(int dni, int codPat)
        {
            int indice = 0, i = 0;
            Prestamo ret = null;
            //listaDeUsuarios.Sort();

            foreach (Prestamo pres in listaDePrestamos)
            {
                if ((pres.DniDeUsuario == dni) && (pres.CodigoPatrimonialDelEjemplar == codPat))
                {
                    ret = (Prestamo)listaDePrestamos[indice];
                    i = indice;
                }
                indice++;
            }
            listaDePrestamos.RemoveAt(i);
        }

        public Prestamo BuscarPrestamo(int dni, int codPat)
        {
            int i, indice = 0;
            Prestamo ret = null;

            foreach (Prestamo pres in listaDePrestamos)
            {
                if (dni == pres.DniDeUsuario && codPat == pres.CodigoPatrimonialDelEjemplar)
                {
                    ret = (Prestamo)listaDePrestamos[indice];
                    i = indice;
                }
                indice++;
            }
            return ret;
        }

        public ArrayList RetornarListaDePrestamo()
        {
            ArrayList ret = new ArrayList();
            ret = listaDePrestamos;
            return ret;
        }
    }
}