﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto08
{
    public class ComparadorNombre : IComparer<Usuario>
    {
        //Compara los usuarios segun su nombre

        public int Compare(Usuario usuario1, Usuario usuario2)
        {
            return usuario1.NombreCompleto.CompareTo(usuario2.NombreCompleto);
        }
    }
}
