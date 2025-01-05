using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;

namespace CelixSoftware.Logica
{
    internal class Autenticacion
    {
        private string usuario;
        private string password;

        public Autenticacion(string usuario, string passwrord)
        {
            this.usuario = usuario;
            this.password = password;
            Comparacion();
        } 
    }

    private Comparacion()
        {
            
        }
}