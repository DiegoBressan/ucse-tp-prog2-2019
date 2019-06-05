using Contratos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClasePrincipal
    {
        List<Docente> ListaDocentes = new List<Docente>();
        List<UsuarioLogueado> ListaUsuarios = new List<UsuarioLogueado>();
        List<Padre> ListaPadres = new List<Padre>();
        List<Hijo> ListaHijos = new List<Hijo>();

        public Respuesta CrearArchivos()
        {
            Respuesta NuevaRespuesta = new Respuesta(true, "");

            if (File.Exists(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Docentes.txt"))
            {
                File.Create(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Docentes.txt").Close();
            }
            if (File.Exists(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Padres.txt"))
            {
                File.Create(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Padres.txt").Close();
            }
            if (File.Exists(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Hijos.txt"))
            {
                File.Create(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Hijos.txt").Close();
            }
            if (File.Exists(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Usuarios.txt"))
            {
                File.Create(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Usuarios.txt").Close();
            }
            return NuevaRespuesta;
        }
    }
}