using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto08
{
    public class Fachada
    {
        private RepositorioEnMemoria rep = new RepositorioEnMemoria();
        public void AgregarUsuario(string pcod, string pnom, string pcorreo)
        {
            Usuario usuario = new Usuario(pcod, pnom, pcorreo);
            rep.Agregar(usuario);
        }

        public void ActualizarUsuario(string pcod, string pnom, string pcorreo)
        {
            Usuario usuario = new Usuario(pcod, pnom, pcorreo);
            rep.Actualizar(usuario);
        }
        public string MostrarNombre(string pcod)
        {
            Usuario usuario = new Usuario(pcod, "", "");
            if (rep.lista.Contains(usuario))
            {
                usuario = rep.ObtenerPorCodigo(pcod);
                return usuario.NombreCompleto;
            }
            else
            {
                return "";
            }

        }
        public string MostrarCorreo(string pcod)
        {
            Usuario usuario = new Usuario(pcod, "", "");
            if (rep.lista.Contains(usuario))
            {
                usuario = rep.ObtenerPorCodigo(pcod);
                return usuario.CorreoElectronico;
            }
            else
            {
                return "";
            }
        }


        public void EliminarUsuario(string pcod)
        {
            rep.Eliminar(pcod);
        }

        public List<string> ObtenerTodos()
        {
            List<Usuario> usuarios = rep.ObtenerTodos();
            List<string> listaUsuarios = new List<string>();
            string cad = "";
            foreach (Usuario us in usuarios)
            {
                cad += us.Codigo + "   " + us.NombreCompleto + "   " + us.CorreoElectronico;
                listaUsuarios.Add(cad);
                cad = "";
            }
            return listaUsuarios;
        }

        public string[] ObtenerPorCodigo(string pcod)
        {
            Usuario usuario = rep.ObtenerPorCodigo(pcod);
            string[] us = new string[2];            
            us[0] = usuario.NombreCompleto;
            us[1] = usuario.CorreoElectronico;
            return us;
        }


        public List<string[]> ObtenerOrdenadosPor(string pcomparador)
        {
            IComparer<Usuario> comp = null;
            switch (pcomparador)
            {
                case "Nombre":
                    comp = new ComparadorNombre();
                    break;
                case "NombreyCodigo":
                    comp = new ComparadorNombreyCodigo();
                    break;
                case "CorreoElectronico":
                    comp = new ComparadorCorreoElectronico();
                    break;
            }
            List<Usuario> usuarios= rep.ObtenerOrdenadosPor(comp);
            List<string[]> listaUsuarios = new List<string[]>();
            int i = 0;
            foreach (Usuario us in usuarios)
            {
                string[] cad = new string[3];
                cad[0] = us.Codigo;
                cad[1] = us.NombreCompleto;
                cad[2] = us.CorreoElectronico;
                listaUsuarios.Add(cad);
            }
            return listaUsuarios;
        }
    }
}

