using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Respuesta
    {
        public bool Resp { get; set; }
        public string Mensaje { get; set; }

        public Respuesta()
        {
            this.Resp = true;
        }

        public Respuesta(bool respuesta, string mensaje)
        {
            this.Resp = respuesta;
            this.Mensaje = mensaje;
        }
    }
}
