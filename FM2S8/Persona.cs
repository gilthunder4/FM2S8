using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM2S8
{
    public class Persona
    {
        private int idPersona;
        private string nombre;
        private string apellido;

        public Persona()
        {
            this.IdPersona = 0;
            this.Nombre = "";
            this.Apellido = "";
        }
        public Persona(int id, string nom, string ape)
        {
            this.idPersona = id;
            this.Nombre = nom;
            this.Apellido = ape;
        }

        public int IdPersona { get => idPersona; set => idPersona = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}
