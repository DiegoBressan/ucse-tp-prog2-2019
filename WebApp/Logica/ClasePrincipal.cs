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
        List<Clave> ListaClaves = new List<Clave>();
        List<Sala> ListaSalas = new List<Sala>();

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
            if (File.Exists(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Claves.txt"))
            {
                File.Create(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Claves.txt").Close();
            }
            if (File.Exists(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Salas.txt"))
            {
                File.Create(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Salas.txt").Close();
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
        }

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

        public void CargarDocentes(Docente NuevoDocente)  
        {
            ListaDocentes.Add(NuevoDocente);
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
            ListaPadres.Add(NuevoPadre);
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
            ListaHijos.Add(NuevoHijo);
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
            ListaDirectores.Add(NuevoDirector);
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
            ListaNotas.Add(NuevaNota);
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

        //----------------------------------CLAVES-----------------------------------------------------------------------

        public void CargarClave(Clave NuevaClave)
        {
            ListaClaves.Add(NuevaClave);
            GuardarClaves();
        }

        public void GuardarClaves()
        {
            using (StreamWriter escritura = new StreamWriter(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Claves.txt", false))
            {
                escritura.Write(JsonConvert.SerializeObject(ListaClaves));
            }
        }

        public List<Clave> LeerClaves()
        {
            using (StreamReader lectura = new StreamReader(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Claves.txt"))
            {
                string contenido = lectura.ReadToEnd();
                ListaClaves = JsonConvert.DeserializeObject<List<Clave>>(contenido);
                if (ListaClaves == null)
                {
                    ListaClaves = new List<Clave>();
                }
            }
            return ListaClaves;
        }
       
        //---------------------------SALAS------------------------------------------------------

        public void CargarSala(Sala NuevaSala)
        {
            ListaSalas.Add(NuevaSala);
            GuardarSalas();
        }

        public void GuardarSalas()
        {
            using (StreamWriter escritura = new StreamWriter(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Salas.txt", false))
            {
                escritura.Write(JsonConvert.SerializeObject(ListaSalas));
            }
        }

        public List<Sala> LeerSalas()
        {
            using (StreamReader lectura = new StreamReader(@"C:\Users\David\Desktop\David-TP Prog\Archivos\Salas.txt"))
            {
                string contenido = lectura.ReadToEnd();
                ListaSalas = JsonConvert.DeserializeObject<List<Sala>>(contenido);
                if (ListaSalas == null)
                {
                    ListaSalas = new List<Sala>();
                }
            }
            return ListaSalas;
        }

        //---------------------------ABM Directores---------------------------------------------

        public Resultado AltaDirectora(Directora directora, UsuarioLogueado usuarioLogueado)
        {
            Resultado NuevoResultado = new Resultado();
            Usuario nuevousuario = null;
            directora.Id = LeerUsuarios().Count + 1;

            //Pregunto si tiene el Roll de Directora
            if (usuarioLogueado.RolSeleccionado == Roles.Directora)
            {
                if (LeerUsuarios() != null) //Busco si existe el director
                {
                    nuevousuario = LeerUsuarios().Where(x => x.Email == directora.Email).FirstOrDefault();
                }

                if (nuevousuario == null) //No existe, cargo uno nuevo
                {                  
                    Clave NuevaClave = new Clave();
                    NuevaClave.Id = directora.Id;
                    NuevaClave.Email = directora.Email;
                    NuevaClave.Roles = new Roles2[] { Roles2.Directora };

                    CargarClave(NuevaClave); //Cargo la nueva clave generada
                    CargarUsuarios(directora); //Cargo un nuevo usuario
                    CargarDirectores(directora); //Cargo un nuevo director                    
                }
                else
                {
                    NuevoResultado.Errores.Add("El usuario ya existe");
                }
            }
            else
            {
                NuevoResultado.Errores.Add("No tiene permiso");
            }

            return NuevoResultado;
        }

        public Resultado EditarDirectora(int id, Directora directora, UsuarioLogueado usuarioLogueado)
        {
            Directora NuevaDirectora = ObtenerDirectoraPorId(usuarioLogueado, id);
            NuevaDirectora = directora;

            Clave NuevaClave = LeerClaves().Where(x => x.Id == id).FirstOrDefault();
            NuevaClave.Email = directora.Email;
           
            Usuario nuevoUsuario = new Usuario()
            {
                Id = id,
                Nombre = directora.Nombre,
                Apellido = directora.Apellido,
                Email= directora.Email
            };
            
            // Busca el director y lo borra de los archivos
            LeerDirectores().RemoveAll(x => x.Id == directora.Id);
            LeerUsuarios().RemoveAll(x => x.Id == directora.Id);
            LeerClaves().RemoveAll(x => x.Id == directora.Id);

            // Busca el director y lo guarda en los archivos
            CargarDirectores(NuevaDirectora);
            CargarUsuarios(nuevoUsuario);
            CargarClave(NuevaClave);

            return new Resultado();
        }

        public Resultado EliminarDirectora(int id, Directora directora, UsuarioLogueado usuarioLogueado)
        {
            // Busca el director y lo borra de los archivos
            LeerDirectores().RemoveAll(x => x.Id == directora.Id);
            LeerUsuarios().RemoveAll(x => x.Id == directora.Id);

            GuardarUsuarios();
            GuardarDirectores();
            
            return new Resultado();
        }

        //---------------------------ABM Docentes---------------------------------------------

        public Resultado AltaDocente(Docente docente, UsuarioLogueado usuarioLogueado)
        {
            Resultado NuevoResultado = new Resultado();
            Usuario nuevousuario = null;
            docente.Id = LeerUsuarios().Count + 1;

            //Pregunto si tiene el Roll de Directora
            if (usuarioLogueado.RolSeleccionado == Roles.Directora)
            {
                if (LeerUsuarios() != null) //Busco si existe el docente
                {
                    nuevousuario = LeerUsuarios().Where(x => x.Email == docente.Email).FirstOrDefault();
                }

                if (nuevousuario == null) //No existe, cargo uno nuevo
                {
                    Clave NuevaClave = new Clave();
                    NuevaClave.Id = docente.Id;
                    NuevaClave.Email = docente.Email;
                    NuevaClave.Roles = new Roles2[] { Roles2.Docente };

                    CargarClave(NuevaClave); //Cargo la nueva clave generada
                    CargarUsuarios(docente); //Cargo un nuevo usuario
                    CargarDocentes(docente); //Cargo un nuevo docente      
                }
                else
                {
                    NuevoResultado.Errores.Add("El usuario ya existe");
                }
            }
            else
            {
                NuevoResultado.Errores.Add("No tiene permiso");
            }

            return NuevoResultado;
        }

        public Resultado EditarDocente(int id, Docente docente, UsuarioLogueado usuarioLogueado)
        {
            Docente NuevoDocente = ObtenerDocentePorId(usuarioLogueado, id);
            NuevoDocente = docente;

            Clave NuevaClave = LeerClaves().Where(x => x.Id == id).FirstOrDefault();
            NuevaClave.Email = docente.Email;

            Usuario nuevoUsuario = new Usuario()
            {
                Id = id,
                Nombre = docente.Nombre,
                Apellido = docente.Apellido,
                Email = docente.Email
            };

            // Busca el docente y lo borra de los archivos
            LeerDocentes().RemoveAll(x => x.Id == docente.Id);
            LeerUsuarios().RemoveAll(x => x.Id == docente.Id);
            LeerClaves().RemoveAll(x => x.Id == docente.Id);

            // Busca el docente y lo guarda en los archivos
            CargarDocentes(NuevoDocente);
            CargarUsuarios(nuevoUsuario);
            CargarClave(NuevaClave);

            return new Resultado();
        }

        public Resultado EliminarDocente(int id, Docente docente, UsuarioLogueado usuarioLogueado)
        {
            // Busca al docente y lo borra de los archivos
            LeerDocentes().RemoveAll(x => x.Id == docente.Id);
            LeerUsuarios().RemoveAll(x => x.Id == docente.Id);

            GuardarDocentes();
            GuardarUsuarios();

            return new Resultado();
        }

        //---------------------------ABM Padres---------------------------------------------

        public Resultado AltaPadreMadre(Padre padre, UsuarioLogueado usuarioLogueado)
        {
            Resultado NuevoResultado = new Resultado();
            Usuario nuevousuario = null;
            padre.Id = LeerUsuarios().Count + 1;

            //Pregunto si tiene el Roll de Directora
            if (usuarioLogueado.RolSeleccionado == Roles.Directora)
            {
                if (LeerUsuarios() != null) //Busco si existe el Padre
                {
                    nuevousuario = LeerUsuarios().Where(x => x.Email == padre.Email).FirstOrDefault();
                }

                if (nuevousuario == null)//No existe, cargo uno nuevo
                {
                    Clave NuevaClave = new Clave();
                    NuevaClave.Id = padre.Id;
                    NuevaClave.Email = padre.Email;
                    NuevaClave.Roles = new Roles2[] { Roles2.Padre };

                    CargarClave(NuevaClave); //Cargo la nueva clave generada
                    CargarUsuarios(padre); //Cargo un nuevo usuario
                    CargarPadres(padre); //Cargo un nuevo padre     
                }
                else
                {
                    NuevoResultado.Errores.Add("El usuario ya existe");
                }
            }
            else
            {
                NuevoResultado.Errores.Add("No tiene permiso");
            }

            return NuevoResultado;
        }

        public Resultado EditarPadreMadre(int id, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            Padre NuevoPadre = ObtenerPadrePorId(usuarioLogueado, id);
            NuevoPadre = padre;

            Clave NuevaClave = LeerClaves().Where(x => x.Id == id).FirstOrDefault();
            NuevaClave.Email = padre.Email;

            Usuario nuevoUsuario = new Usuario()
            {
                Id = id,
                Nombre = padre.Nombre,
                Apellido = padre.Apellido,
                Email = padre.Email
            };

            // Busca el padre y lo borra de los archivos
            LeerPadres().RemoveAll(x => x.Id == padre.Id);
            LeerUsuarios().RemoveAll(x => x.Id == padre.Id);
            LeerClaves().RemoveAll(x => x.Id == padre.Id);

            // Busca el padre y lo guarda en los archivos
            CargarPadres(NuevoPadre);
            CargarUsuarios(nuevoUsuario);
            CargarClave(NuevaClave);

            return new Resultado();
        }

        public Resultado EliminarPadreMadre(int id, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            // Busca el padre y lo borra de los archivos
            LeerPadres().RemoveAll(x => x.Id == padre.Id);
            LeerUsuarios().RemoveAll(x => x.Id == padre.Id);

            GuardarUsuarios();
            GuardarPadres();

            return new Resultado();
        }

        //---------------------------ABM Hijos---------------------------------------------

        public Resultado AltaAlumno(Hijo hijo, UsuarioLogueado usuarioLogueado)
        {
            Resultado NuevoResultado = new Resultado();
            Usuario nuevousuario = null;
            hijo.Id = LeerUsuarios().Count + 1;

            //Pregunto si tiene el Roll de Directora
            if (usuarioLogueado.RolSeleccionado == Roles.Directora)
            {
                if (LeerUsuarios() != null) //Busco si existe el Hijo
                {
                    nuevousuario = LeerUsuarios().Where(x => x.Email == hijo.Email).FirstOrDefault();
                }

                if (nuevousuario == null)//No existe, cargo uno nuevo
                {                    
                    CargarUsuarios(hijo); //Cargo un nuevo usuario
                    CargarHijos(hijo); //Cargo un nuevo hijo 
                }
                else
                {
                    NuevoResultado.Errores.Add("El usuario ya existe");
                }
            }
            else
            {
                NuevoResultado.Errores.Add("No tiene permiso");
            }
            return NuevoResultado;
        }

        public Resultado EditarAlumno(int id, Hijo hijo, UsuarioLogueado usuarioLogueado)
        {
            Hijo NuevoHijo = ObtenerAlumnoPorId(usuarioLogueado, id);
            NuevoHijo = hijo;

            Usuario nuevoUsuario = new Usuario()
            {
                Id = id,
                Nombre = hijo.Nombre,
                Apellido = hijo.Apellido,
                Email = hijo.Email
            };

            // Busca el hijo y lo borra de los archivos
            LeerHijos().RemoveAll(x => x.Id == hijo.Id);
            LeerUsuarios().RemoveAll(x => x.Id == hijo.Id);

            // Busca el hijo y lo guarda en los archivos
            CargarHijos(NuevoHijo);
            CargarUsuarios(nuevoUsuario);

            return new Resultado();
        }

        public Resultado EliminarAlumno(int id, Hijo hijo, UsuarioLogueado usuarioLogueado)
        { 
            // Busca el alumno y lo borra de los archivos
            LeerHijos().RemoveAll(x => x.Id == hijo.Id);
            LeerUsuarios().RemoveAll(x => x.Id == hijo.Id);

            GuardarHijos();
            GuardarUsuarios();

            return new Resultado();
        }

        //---------------------------Asignar/Desasignar---------------------------------------------

        public Resultado AsignarDocenteSala(Docente docente, Sala sala, UsuarioLogueado usuarioLogueado)
        {
            Resultado NuevoResultado = new Resultado();

            if (usuarioLogueado.RolSeleccionado == Roles.Directora)
            {
                var salasDocente = docente.Salas != null ? docente.Salas.ToList() : new List<Sala>();

                if (salasDocente.Any(x => x.Id == sala.Id) == false)
                {
                    salasDocente.Add(sala);
                    //agrega una sala al archivo de sala, si es que no existe dicha sala
                    var Listasalaencontrada = LeerSalas();
                    if (Listasalaencontrada == null)
                    {
                        CargarSala(sala);
                    }
                    else
                    {
                        var salaencontrada = Listasalaencontrada.Where(x => x.Id == sala.Id).FirstOrDefault();
                        if (salaencontrada == null)
                        {
                            CargarSala(sala);
                        }
                    }
                }
                else
                {
                    NuevoResultado.Errores.Add("No se encontro la sala");
                }
                docente.Salas = salasDocente.ToArray();

                var docenteencontrado = ObtenerDocentePorId(usuarioLogueado, docente.Id);//obtiene el docente a asignar
                docenteencontrado.Salas = docente.Salas;//le asigna las salas
                GuardarDocentes();//guarda los cambios
            }
            else
            {
                NuevoResultado.Errores.Add("No tiene permiso para asignar");
            }
            return NuevoResultado;
        }

        public Resultado DesasignarDocenteSala(Docente docente, Sala sala, UsuarioLogueado usuarioLogueado)
        {
            Resultado NuevoResultado = new Resultado();

            if (usuarioLogueado.RolSeleccionado == Roles.Directora)
            {
                var salasDocente = docente.Salas != null ? docente.Salas.ToList() : new List<Sala>();

                if (salasDocente.Any(x => x.Id == sala.Id) == true)
                {
                    salasDocente.Remove(sala);
                }
                else
                {
                    NuevoResultado.Errores.Add("No se encontro la sala");
                }   

                docente.Salas = salasDocente.ToArray();

                var docenteencontrado = ObtenerDocentePorId(usuarioLogueado, docente.Id);
                docenteencontrado.Salas = docente.Salas;
                GuardarDocentes();
            }
            else
            {
                NuevoResultado.Errores.Add("No tiene permiso para desasignar");
            }
            return NuevoResultado;
        }

        public Resultado AsignarHijoPadre(Hijo hijo, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            Resultado NuevoResultado = new Resultado();

            if (usuarioLogueado.RolSeleccionado == Roles.Directora)
            {
                var hijosPadre = padre.Hijos != null ? padre.Hijos.ToList() : new List<Hijo>();

                if (hijosPadre.Any(x => x.Id == hijo.Id) == false)
                {
                    hijosPadre.Add(hijo);
                }
                else
                {
                    NuevoResultado.Errores.Add("No se encontro el hijo");
                }   

                padre.Hijos = hijosPadre.ToArray();

                var padreencontrado = ObtenerPadrePorId(usuarioLogueado, padre.Id);
                padreencontrado.Hijos = padre.Hijos;
                GuardarPadres();
            }
            else
            {
                NuevoResultado.Errores.Add("No tiene permiso para asignar");
            }
            return NuevoResultado;
        }

        public Resultado DesasignarHijoPadre(Hijo hijo, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            Resultado NuevoResultado = new Resultado();

            if (usuarioLogueado.RolSeleccionado == Roles.Directora)
            {
                var hijosPadre = padre.Hijos != null ? padre.Hijos.ToList() : new List<Hijo>();

                if (hijosPadre.Any(x => x.Id == hijo.Id) == true)
                {
                    hijosPadre.Remove(hijo);
                }
                else
                {
                    NuevoResultado.Errores.Add("No se encontro el hijo");
                }    

                padre.Hijos = hijosPadre.ToArray();

                var padreencontrado = ObtenerPadrePorId(usuarioLogueado, padre.Id);
                padreencontrado.Hijos = padre.Hijos;
                GuardarPadres();
            }
            else
            {
                NuevoResultado.Errores.Add("No tiene permiso para desasignar");
            }
            return NuevoResultado;
        }

        //---------------------------Obtener---------------------------------------------
        
        public string ObtenerNombreGrupo()
        {
            return "Giovannini-Bressan";
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

        //--------------------------ObtenerPorID---------------------------------------

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