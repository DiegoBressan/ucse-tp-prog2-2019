using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contratos;

namespace Logica
{
    public enum Roles2
    {
        Padre = 1,
        Directora = 2,
        Docente = 3
    }
    public class Clave
    {
        public int Id { get; set; }
        public string ClaveIngreso { get; set; }
        public string Email { get; set; }
        public Roles2[] Roles { get; set; }


        public Clave()
        {
            for (int i = 1; i < 7; i++)
            {
                ClaveIngreso = ClaveIngreso + (new Random().Next(0, 9).ToString());
            }
        }
    }
}
