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
    public class ClasePrincipal : IServicioWeb
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
        public void CargarUsuarios(Usuario NuevoUsuario)
        {
            Usuario usuario = new Usuario();
            usuario = NuevoUsuario;
            ListaUsuarios.Add(usuario);
            GuardarUsuarios();
        }//metodo que se usa en las altas para cargar

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
        } //metodo para devolver lista de archivo

        //----------------------------------DOCENTES------------------------------------------------------------------
        public void CargarDocentes(Docente NuevoDocente)  
        {
            NuevoDocente.Id = ListaDocentes.Count() + 1;
            Docente docente = new Docente();
            docente = NuevoDocente;
            ListaDocentes.Add(docente);
            GuardarDocentes();
        } 

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
        public void CargarPadres(Padre NuevoPadre)
        {
            NuevoPadre.Id = ListaPadres.Count() + 1;
            Padre padre = new Padre();
            padre = NuevoPadre;
            ListaPadres.Add(padre);
            GuardarPadres();
        }

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
        public void CargarHijos(Hijo NuevoHijo)
        {
            NuevoHijo.Id = ListaHijos.Count() + 1;
            Hijo hijo = new Hijo();
            hijo = NuevoHijo;
            ListaHijos.Add(hijo);
            GuardarHijos();
        }

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
        public void CargarDirectores(Directora NuevoDirector)
        {
            NuevoDirector.Id = ListaDirectores.Count() + 1;
            Directora director = new Directora();
            director = NuevoDirector;
            ListaDirectores.Add(director);
            GuardarDirectores();
        }

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
        public void CargarNotas(Nota NuevaNota)
        {
            NuevaNota.Id = ListaNotas.Count() + 1;
            Nota nota = new Nota();
            nota = NuevaNota;
            ListaNotas.Add(nota);
            GuardarNotas();
        }

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

        //---------------------------ABM Directores---------------------------------------------
        public Resultado AltaDirectora(Directora directora, UsuarioLogueado usuarioLogueado)
        {
            Usuario nuevousuario = null;
            List<string> mensaje = new List<string>();
            //Pregunto si existen usuarios para obtener el ID
            if (LeerUsuarios() == null)
            {
                directora.Id = 1;
            }
            else
            {
                directora.Id = LeerUsuarios().Count + 1;
            }

            //Pregunto si tiene el Roll de Director
            if (usuarioLogueado.RolSeleccionado == Roles.Directora)
            {
                if (LeerUsuarios() != null) //Busco si existe el director
                {
                    nuevousuario = LeerUsuarios().Where(x => x.Email == directora.Email).FirstOrDefault();
                }

                if (nuevousuario != null)
                {

                }
            }
            else
            {
                mensaje.Add("No tiene autorización requerida");
            }

            return new Resultado() { Errores = mensaje };
        }

        public Resultado EditarDirectora(int id, Directora directora, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Resultado EliminarDirectora(int id, Directora directora, UsuarioLogueado usuarioLogueado)
        {
            LeerDirectores().RemoveAll(x => x.Id == directora.Id);
            LeerUsuarios().RemoveAll(x => x.Id == directora.Id);
            
            List<string> mensaje = new List<string>();
            mensaje.Add("Se elimino correctamente");
            return new Resultado() { Errores = mensaje };
        }

        //---------------------------ABM Docentes---------------------------------------------

        public Resultado AltaDocente(Docente docente, UsuarioLogueado usuarioLogueado)
        {
            Usuario nuevousuario = null;
            List<string> mensaje = new List<string>();
            //Pregunto si existen usuarios para obtener el ID
            if (LeerUsuarios() == null)
            {
                docente.Id = 1;
            }
            else
            {
                docente.Id = LeerUsuarios().Count + 1;
            }

            //Pregunto si tiene el Roll de Docente
            if (usuarioLogueado.RolSeleccionado == Roles.Directora)
            {
                if (LeerUsuarios() != null) //Busco si existe el docente
                {
                    nuevousuario = LeerUsuarios().Where(x => x.Email == docente.Email).FirstOrDefault();
                }

                if (nuevousuario != null)
                {

                }
            }
            else
            {
                mensaje.Add("No tiene autorización requerida");
            }

            return new Resultado() { Errores = mensaje };
        }

        public Resultado EditarDocente(int id, Docente docente, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Resultado EliminarDocente(int id, Docente docente, UsuarioLogueado usuarioLogueado)
        {
            LeerDirectores().RemoveAll(x => x.Id == docente.Id);
            LeerUsuarios().RemoveAll(x => x.Id == docente.Id);

            List<string> mensaje = new List<string>();
            mensaje.Add("Se elimino correctamente");
            return new Resultado() { Errores = mensaje };
        }

        //---------------------------ABM Padres---------------------------------------------

        public Resultado AltaPadreMadre(Padre padre, UsuarioLogueado usuarioLogueado)
        {
            Usuario nuevousuario = null;
            List<string> mensaje = new List<string>();
            //Pregunto si existen usuarios para obtener el ID
            if (LeerUsuarios() == null)
            {
                padre.Id = 1;
            }
            else
            {
                padre.Id = LeerUsuarios().Count + 1;
            }

            //Pregunto si tiene el Roll de Padre
            if (usuarioLogueado.RolSeleccionado == Roles.Directora)
            {
                if (LeerUsuarios() != null) //Busco si existe el padre
                {
                    nuevousuario = LeerUsuarios().Where(x => x.Email == padre.Email).FirstOrDefault();
                }

                if (nuevousuario != null)
                {

                }
            }
            else
            {
                mensaje.Add("No tiene autorización requerida");
            }

            return new Resultado() { Errores = mensaje };
        }

        public Resultado EditarPadreMadre(int id, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Resultado EliminarPadreMadre(int id, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            LeerDirectores().RemoveAll(x => x.Id == padre.Id);
            LeerUsuarios().RemoveAll(x => x.Id == padre.Id);

            List<string> mensaje = new List<string>();
            mensaje.Add("Se elimino correctamente");
            return new Resultado() { Errores = mensaje };
        }

        //---------------------------ABM Hijos---------------------------------------------

        public Resultado AltaAlumno(Hijo hijo, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Resultado EditarAlumno(int id, Hijo hijo, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Resultado EliminarAlumno(int id, Hijo hijo, UsuarioLogueado usuarioLogueado)
        {
            LeerDirectores().RemoveAll(x => x.Id == hijo.Id);
            LeerUsuarios().RemoveAll(x => x.Id == hijo.Id);

            List<string> mensaje = new List<string>();
            mensaje.Add("Se elimino correctamente");
            return new Resultado() { Errores = mensaje };
        }

        //---------------------------Asignar/Desasignar---------------------------------------------

        public Resultado AsignarDocenteSala(Docente docente, Sala sala, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Resultado DesasignarDocenteSala(Docente docente, Sala sala, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Resultado AsignarHijoPadre(Hijo hijo, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Resultado DesasignarHijoPadre(Hijo hijo, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        //---------------------------Obtener---------------------------------------------
        
        public string ObtenerNombreGrupo()
        {
            throw new NotImplementedException();
        }

        public UsuarioLogueado ObtenerUsuario(string email, string clave)
        {
            throw new NotImplementedException();
        }

        public Institucion[] ObtenerInstituciones()
        {
            throw new NotImplementedException();
        }
        
        public Sala[] ObtenerSalasPorInstitucion(UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }
        
        public Hijo[] ObtenerPersonas(UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Nota[] ObtenerCuadernoComunicaciones(int idPersona, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Grilla<Directora> ObtenerDirectoras(UsuarioLogueado usuarioLogueado, int paginaActual, int totalPorPagina, string busquedaGlobal)
        {
            throw new NotImplementedException();
        }

        public Grilla<Docente> ObtenerDocentes(UsuarioLogueado usuarioLogueado, int paginaActual, int totalPorPagina, string busquedaGlobal)
        {
            throw new NotImplementedException();
        }

        public Grilla<Padre> ObtenerPadres(UsuarioLogueado usuarioLogueado, int paginaActual, int totalPorPagina, string busquedaGlobal)
        {
            throw new NotImplementedException();
        }

        public Grilla<Hijo> ObtenerAlumnos(UsuarioLogueado usuarioLogueado, int paginaActual, int totalPorPagina, string busquedaGlobal)
        {
            throw new NotImplementedException();
        }

        public Directora ObtenerDirectoraPorId(UsuarioLogueado usuarioLogueado, int id)
        {
            return LeerDirectores().Where(x => x.Id == id).FirstOrDefault();
        }

        public Docente ObtenerDocentePorId(UsuarioLogueado usuarioLogueado, int id)
        {
            return LeerDocentes().Where(x => x.Id == id).FirstOrDefault();
        }

        public Padre ObtenerPadrePorId(UsuarioLogueado usuarioLogueado, int id)
        {
            return LeerPadres().Where(x => x.Id == id).FirstOrDefault();
        }

        public Hijo ObtenerAlumnoPorId(UsuarioLogueado usuarioLogueado, int id)
        {
            return LeerHijos().Where(x => x.Id == id).FirstOrDefault();
        }

        //---------------------------Notas---------------------------------------------

        public Resultado AltaNota(Nota nota, Sala[] salas, Hijo[] hijos, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Resultado ResponderNota(Nota nota, Comentario nuevoComentario, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Resultado MarcarNotaComoLeida(Nota nota, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }
        
    }
}