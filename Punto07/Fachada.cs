﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto07  
{
    public class Fachada
    {
        private EncriptadorRSA eRSA;
        public Fachada()
        {
            eRSA = new EncriptadorRSA();
        }
        public string EncriptarAES(string palabra)
        {
            EncriptadorAES encriptador = new EncriptadorAES();
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarAES(string palabra)
        {
            EncriptadorAES encriptador = new EncriptadorAES();
            return (encriptador.Desencriptar(palabra));
        }

        public string EncriptarCesar(string palabra, int desplazamiento)
        {
            EncriptadorCesar encriptador = new EncriptadorCesar(desplazamiento);
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarCesar(string palabra, int desplazamiento)
        {
            EncriptadorCesar encriptador = new EncriptadorCesar(desplazamiento);
            return (encriptador.Desencriptar(palabra));
        }

        public string EncriptarNulo(string palabra)
        {
            EncriptadorNulo encriptador = new EncriptadorNulo();
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarNulo(string palabra)
        {
            EncriptadorNulo encriptador = new EncriptadorNulo();
            return (encriptador.Desencriptar(palabra));
        }

        public string EncriptarTranspuesto(string palabra)
        {
            EncriptadorTransposicion encriptador = new EncriptadorTransposicion();
            return (encriptador.Encriptar(palabra));
        }

        public string DesencriptarTranspuesto(string palabra)
        {
            EncriptadorTransposicion encriptador = new EncriptadorTransposicion();
            return (encriptador.Desencriptar(palabra));
        }

        public string EncriptarRSA(string palabra)
        {
            return (eRSA.Encriptar(palabra));
        }

        public string DesencriptarRSA(string palabra)
        {
            return (eRSA.Desencriptar(palabra));
        }


        public List<string> TodosLosEncriptadores()
        {
            List<string> keyList = new List<string>();
            keyList.Add("AES");
            keyList.Add("Cesar");
            keyList.Add("Nulo");
            keyList.Add("RSA");
            keyList.Add("Transposicion");
            return keyList;
        } 
    }
}
