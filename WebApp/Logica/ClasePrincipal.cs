using Contratos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Logica
{
    public class ClasePrincipal
    {
        List<Docente> ListaDocentes = new List<Docente>();
        List<Directora> ListaDirectores = new List<Directora>();
        List<Usuario> ListaUsuarios = new List<Usuario>();
        List<Padre> ListaPadres = new List<Padre>();
        List<Hijo> ListaHijos = new List<Hijo>();
        List<Nota> ListaNotas = new List<Nota>();

        /*
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
            if (File.Exists(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Directores.txt"))
            {
                File.Create(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Directores.txt").Close();
            }
            if (File.Exists(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Notas.txt"))
            {
                File.Create(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Notas.txt").Close();
            }
            return NuevaRespuesta;
        }
        */
        

        //----------------------------------USUARIOS-----------------------------------------------------------------
        public void GuardarUsuarios()
        {
            using (StreamWriter escritura = new StreamWriter(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Usuarios.txt", false))
            {
                escritura.Write(JsonConvert.SerializeObject(ListaUsuarios));
            }
        }
        public List<Usuario> LeerUsuarios()
        {
            using(StreamReader lectura = new StreamReader(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Usuarios.txt"))
            {
                string contenido = lectura.ReadToEnd();
                ListaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
                if (ListaUsuarios == null)
                {
                    ListaUsuarios = new List<Usuario>();
                }
            }
            return ListaUsuarios;
        }
        //----------------------------------DOCENTES------------------------------------------------------------------
        public void GuardarDocentes()
        {
            using (StreamWriter escritura = new StreamWriter(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Docentes.txt", false))
            {
                escritura.Write(JsonConvert.SerializeObject(ListaDocentes));
            }
        }
        public List<Docente> LeerDocentes()
        {
            using (StreamReader lectura = new StreamReader(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Docentes.txt"))
            {
                string contenido = lectura.ReadToEnd();
                ListaDocentes = JsonConvert.DeserializeObject<List<Docente>>(contenido);
                if (ListaDocentes == null)
                {
                    ListaDocentes = new List<Docente>();
                }
            }
            return ListaDocentes;
        }
        //----------------------------------PADRES----------------------------------------------------------------------
        public void GuardarPadres()
        {
            using (StreamWriter escritura = new StreamWriter(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Padres.txt", false))
            {
                escritura.Write(JsonConvert.SerializeObject(ListaPadres));
            }
        }
        public List<Padre> LeerPadres()
        {
            using (StreamReader lectura = new StreamReader(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Padres.txt"))
            {
                string contenido = lectura.ReadToEnd();
                ListaPadres = JsonConvert.DeserializeObject<List<Padre>>(contenido);
                if (ListaPadres == null)
                {
                    ListaPadres = new List<Padre>();
                }
            }
            return ListaPadres;
        }
        //----------------------------------HIJOS-----------------------------------------------------------------------
        public void GuardarHijos()
        {
            using (StreamWriter escritura = new StreamWriter(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Hijos.txt", false))
            {
                escritura.Write(JsonConvert.SerializeObject(ListaHijos));
            }
        }
        public List<Hijo> LeerHijos()
        {
            using (StreamReader lectura = new StreamReader(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Hijos.txt"))
            {
                string contenido = lectura.ReadToEnd();
                ListaHijos = JsonConvert.DeserializeObject<List<Hijo>>(contenido);
                if (ListaHijos == null)
                {
                    ListaHijos = new List<Hijo>();
                }
            }
            return ListaHijos;
        }
        //----------------------------------DIRECTORES------------------------------------------------------------------
        public void GuardarDirectores()
        {
            using (StreamWriter escritura = new StreamWriter(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Directores.txt", false))
            {
                escritura.Write(JsonConvert.SerializeObject(ListaDirectores));
            }
        }
        public List<Directora> LeerDirectores()
        {
            using (StreamReader lectura = new StreamReader(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Directores.txt"))
            {
                string contenido = lectura.ReadToEnd();
                ListaDirectores = JsonConvert.DeserializeObject<List<Directora>>(contenido);
                if (ListaDirectores == null)
                {
                    ListaDirectores = new List<Directora>();
                }
            }
            return ListaDirectores;
        }
        //----------------------------------NOTAS-----------------------------------------------------------------------
        public void GuardarNotas()
        {
            using (StreamWriter escritura = new StreamWriter(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Notas.txt", false))
            {
                escritura.Write(JsonConvert.SerializeObject(ListaNotas));
            }
        }
        public List<Nota> LeerNotas()
        {
            using (StreamReader lectura = new StreamReader(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Notas.txt"))
            {
                string contenido = lectura.ReadToEnd();
                ListaNotas = JsonConvert.DeserializeObject<List<Nota>>(contenido);
                if (ListaNotas == null)
                {
                    ListaNotas = new List<Nota>();
                }
            }
            return ListaNotas;
        }



    }
}