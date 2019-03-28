using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CopiaDeBiblio
{
    class Prestamo
    {
        private DateTime fechaAct;
        private DateTime fechaDev;
        public const int maxPrestamos = 5;
        private Usuario unUsuario;
        private Ejemplar unEj;
        
        public Prestamo(Usuario unUsuario, Ejemplar unEj)
        {
            this.fechaAct = DateTime.Now;
            this.fechaDev = DateTime.Now.AddDays(14);
            this.unUsuario = unUsuario;
            this.unEj = unEj;
        }

        public Prestamo(DateTime fechaDev, Usuario unUsuario, Ejemplar unEj)
        {
            this.fechaAct = DateTime.Now;
            this.fechaDev = fechaDev;
            this.unUsuario = unUsuario;
            this.unEj = unEj;
        }

        public void InhabilitarUsuario()
        {
            this.unUsuario.Inhabilitado();
        }

        public void HabilitarUsuario()
        {
            this.unUsuario.Habilitado();
        }

        public string UsuarioQueLoTiene
        {
            get
            {
                return this.unUsuario.NAp;
            }
        }

        public int DniDeUsuario
        {
            get
            {
                return this.unUsuario.Dni();
            }
        }

        public string TituloDeEjemplar
        {
            get
            {
                return unEj.NomEj;
            }
        }

        public string AutorDeEjemplar
        {
            get
            {
                return unEj.AutEj;
            }
        }

        public int CodigoPatrimonialDelEjemplar
        {
            get
            {
                return unEj.NumPatrimonial;
            }
        }
            /*int posU = -1, indiceE = -1;

            retUsuario = miBiblio.RetornarListaDeUsuarios();
            retEjemplar = miBiblio.RetornarListaDeEjemplar();

            posU = retUsuario.BinarySearch(dni);
            indiceE = retEjemplar.BinarySearch(codPat);

            if (posU > -1 && indiceE > -1)
            {
                if (!((Usuario)retUsuario[posU]).Estado && !((Ejemplar)retEjemplar[indiceE]).Estado)
                {
                    if (((Usuario)retUsuario[posU]).ContDePrestamos >= maxPrestamos)
                    {
                        this.fechaAct = DateTime.Now;
                        miUsuario = (Usuario)retUsuario[indiceE];
                        miEjemplar = (Ejemplar)retEjemplar[posU];
                        this.fechaDev = DateTime.Now.AddDays(14);

                        miUsuario.ContarPrestamos();
                        miEjemplar.NoDisponible();
                    }
                }
            }
        }
        public Prestamo(int dni, int codPat, DateTime fechaDev)
        {
            int posU = -1, indiceE = -1;

            retUsuario = miBiblio.RetornarListaDeUsuarios();
            retEjemplar = miBiblio.RetornarListaDeEjemplar();

            posU = retUsuario.BinarySearch(dni);
            indiceE = retEjemplar.BinarySearch(codPat);

            if (posU > -1 && indiceE > -1)
            {
                if (!((Usuario)retUsuario[posU]).Estado && !((Ejemplar)retEjemplar[indiceE]).Estado)
                {
                    if (((Usuario)retUsuario[posU]).ContDePrestamos >= maxPrestamos)
                    {
                        this.fechaAct = DateTime.Now;
                        miUsuario = (Usuario)retUsuario[indiceE];
                        miEjemplar = (Ejemplar)retEjemplar[posU];
                        this.fechaDev = fechaDev;

                        miUsuario.ContarPrestamos();
                        miEjemplar.NoDisponible();
                    }
                }
            }
        }
        public void DevolverPrestamo(int dni, int codPat)
        {
            int posU = 0, posEj = 0;
            retUsuario = miBiblio.RetornarListaDeUsuarios();
            retEjemplar = miBiblio.RetornarListaDeEjemplar();

            posU = retUsuario.BinarySearch(dni);
            posEj = retEjemplar.BinarySearch(codPat);

            miUsuario = (Usuario)retUsuario[posU];
            miEjemplar = (Ejemplar)retEjemplar[posEj];

            miUsuario.RestarPrestamos();
            miEjemplar.Disponible();

            if (DateTime.Now <= this.fechaDev)
            {
                this.cadena = "El Ejemplar fue devuelto en tiempo y forma.";
            }
            else
            {
                this.cadena = "El Ejemplar fue devuelto fuera de termino.";
            }
        }*/

        public DateTime FechaActual
        {
            get
            {
                return this.fechaAct;
            }
        }

        public DateTime FechaDevolucion
        {
            get
            {
                return this.fechaDev;
            }
        }
    }
}