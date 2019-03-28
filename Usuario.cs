using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopiaDeBiblio
{
    [Serializable]
    class Usuario
    {
        private bool inhabilitado;
        private string nAp;
        private int contDePrestamos;
        private string mail;
        private int dni;

        public Usuario(string nAp, string mail, int dni)
        {
            this.nAp = nAp;
            this.mail = mail;
            this.dni = dni;
            this.inhabilitado = false;
            this.contDePrestamos = 0;

        }

        public bool Estado
        {
            get
            {
                return this.inhabilitado;
            }
        }

        public void Habilitado()
        {
            this.inhabilitado = false;
        }

        public void Inhabilitado()
        {
            this.inhabilitado = true;
        }

        public int ContDePrestamos
        {
            get
            {
                return this.contDePrestamos;
            }
        }

        public int Dni()
        {
            return dni;
        }

        public string NAp
        {
            get
            {
                return nAp;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }
        }

        public void ContarPrestamos()
        {
            this.contDePrestamos++;
        }

        public void RestarPrestamos()
        {
            this.contDePrestamos--;
        }

        public int CompareTo(object oo)
        {
            return this.dni.CompareTo(((Usuario)oo).Dni());
        }

        public override string ToString()
        {
            return this.NAp + " " + this.Mail + " " + this.Dni().ToString();
        }
    }
}
