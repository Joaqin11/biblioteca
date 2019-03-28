using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopiaDeBiblio
{
    class Libro
    {
        private string codISBN;
        private string titulo;
        private string autor;
        private bool codInvalido;
        private bool comprobado;
        private string auxISBN;
        private bool cantDigitos;


        public Libro(string codISBN, string titulo, string autor)
        {
            this.codISBN = codISBN;
            this.VerificacionDelISBN();

            if (comprobado)
            {
                if (!this.codInvalido)
                {
                    this.titulo = titulo;
                    this.autor = autor;
                }
            }
            else
            {
                codInvalido = true;
            }
        }

        public void VerificacionDelISBN()
        {
            string digito;
            int num, total = 0, cont = 0, verificacion;

            this.auxISBN = this.codISBN;

            this.auxISBN = auxISBN.Replace("-", "");

            if (this.auxISBN.Length == 10)
            {
                cantDigitos = true;
                for (int i = 0; i < 10; i++)
                {
                    digito = this.auxISBN.Substring(i, 1);
                    if (digito != null)
                    {
                        if ((i == 0) || (i == 1) || (i == 2) || (i == 3) || (i == 4) || (i == 5) || (i == 6) || (i == 7) || (i == 8) || (i == 9))
                        {
                            num = Convert.ToInt32(digito.ToString());
                            total += num * cont;
                        }
                    }
                    cont++;
                }
                if (!comprobado)
                {
                    verificacion = total % 11;
                    if (verificacion == 0)
                    {
                        this.codInvalido = false;
                        comprobado = true;
                    }
                    else
                    {
                        this.codInvalido = true;
                        comprobado = true;
                    }
                }
            }
            else if (this.auxISBN.Length == 13)
            {
                cantDigitos = true;
                for (int i = 0; i < 13; i++)
                {
                    digito = this.auxISBN.Substring(i, 1);
                    if (digito != null)
                    {
                        if ((i == 0) || (i == 2) || (i == 4) || (i == 6) || (i == 8) || (i == 10) || (i == 12))
                        {
                            num = Convert.ToInt32(digito.ToString());
                            total += num * 1;
                        }
                        else if ((i == 1) || (i == 3) || (i == 5) || (i == 7) || (i == 9) || (i == 11))
                        {
                            num = Convert.ToInt32(digito.ToString());
                            total += num * 3;
                        }
                        else
                        {
                            num = Convert.ToInt32(digito.ToString());
                            total += num;
                        }
                    }
                }
                if (!comprobado)
                {
                    verificacion = total % 10;
                    if (verificacion == 0)
                    {
                        this.codInvalido = false;
                        comprobado = true;
                    }
                    else
                    {
                        this.codInvalido = true;
                        comprobado = true;
                    }
                }
            }
            else
            {
                cantDigitos = false;
                comprobado = false;
            }
        }

        public string CodISBN
        {
            get
            {
                return this.codISBN;
            }
        }

        public string Titulo
        {
            get
            {
                return this.titulo;
            }
        }

        public string Autor
        {
            get
            {
                return this.autor;
            }
        }

        public bool Estado
        {
            get
            {
                return this.codInvalido;
            }
        }

        public virtual int CompareTo(object oo)
        {
            return this.codISBN.CompareTo(((Libro)oo).CodISBN);
            /*Si no anda el CompareTo es porque 
             * CodISBN es una propiedad y necesita 
             * Ser un metodo
            */
        }
    }
}
