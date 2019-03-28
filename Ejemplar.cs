using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopiaDeBiblio
{
    class Ejemplar
    {
        private bool disponible;
        private int numPatrimonial;
        private string ubicacion;
        private static int num = 0;
        private bool eliminar = false;
        private Libro unLibro;

        public Ejemplar(string ubicacion, Libro unLibro)
        {
            this.numPatrimonial = num++;
            this.ubicacion = ubicacion;
            if (unLibro != null)
            {
                this.unLibro = unLibro;
            }
        }

        public Ejemplar(string ubicacion, int numPatrimonial, Libro unLibro)
        {
            this.numPatrimonial = numPatrimonial;
            this.ubicacion = ubicacion;
            if (unLibro != null)
            {
                this.unLibro = unLibro;
            }
        }

        public void Disponible()
        {
            this.disponible = true;
        }

        public void NoDisponible()
        {
            this.disponible = false;
        }

        public bool Estado
        {
            get
            {
                return this.disponible;
            }
        }

        public string Ubicacion
        {
            get
            {
                return this.ubicacion;
            }
        }

        public int NumPatrimonial
        {
            get
            {
                return this.numPatrimonial;
            }
        }

        public static int Total
        {
            get
            {
                return num;
            }
        }

        public bool DarDeBaja
        {
            set
            {
                this.eliminar = value;
            }
            get
            {
                return this.eliminar;
            }
        }

        public string NomEj
        {
            get
            {
                return unLibro.Titulo;
            }
        }

        public string AutEj
        {
            get
            {
                return unLibro.Autor;
            }
        }

        public string ISBNEj
        {
            get
            {
                return unLibro.CodISBN;
            }
        }

        /*public bool Editar
        {
            set
            {
                this.editar = value;
            }
            get
            {
                return this.editar;
            }
        }*/
    }
}