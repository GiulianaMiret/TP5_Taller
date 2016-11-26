using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto08
{
    public class Usuario : IComparable<Usuario>
    {
        private string iCodigo;
        private string iNombreCompleto;
        private string iCorreoElectronico;

        public Usuario(string pCodigo, string pNombre, string pCorreo)
        {
            this.iCodigo = pCodigo;
            this.iNombreCompleto = pNombre;
            this.iCorreoElectronico = pCorreo;
        }

        public string Codigo
        {
            get { return this.iCodigo; }
        }

        public string NombreCompleto
        {
            get { return this.iNombreCompleto; }
        }

        public string CorreoElectronico
        {
            get { return this.iCorreoElectronico; }
        }

        public int CompareTo(Usuario other)
        {
            return this.Codigo.CompareTo(other.Codigo);
        }

        public override bool Equals(object obj)
        {
            //Verifica si el parametro es nulo y si el objeto es de igual tipo
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Usuario aux = obj as Usuario;
            return aux.Codigo == this.Codigo;

        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(this.Codigo);
            //this.GetHashCode();
        }
    }
}
