using Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;

namespace LogicaImplementar
{
    public class Implementacion : IServicioWeb
    {
        public ClasePrincipal ClasePrincipal { get; set; }

        public Implementacion()
        {
            ClasePrincipal = new ClasePrincipal();
            ClasePrincipal.CrearArchivos();           
        }

        public Resultado AltaAlumno(Hijo hijo, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.AltaAlumno(hijo, usuarioLogueado);
        }

        public Resultado AltaDirectora(Directora directora, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.AltaDirectora(directora, usuarioLogueado);
        }

        public Resultado AltaDocente(Docente docente, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.AltaDocente(docente, usuarioLogueado);
        }

        public Resultado AltaNota(Nota nota, Sala[] salas, Hijo[] hijos, UsuarioLogueado usuarioLogueado)
        {
            throw new NotImplementedException();
        }

        public Resultado AltaPadreMadre(Padre padre, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.AltaPadreMadre(padre, usuarioLogueado);
        }

        public Resultado AsignarDocenteSala(Docente docente, Sala sala, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.AsignarDocenteSala(docente, sala, usuarioLogueado);
        }

        public Resultado AsignarHijoPadre(Hijo hijo, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.AsignarHijoPadre(hijo, padre, usuarioLogueado);
        }

        public Resultado DesasignarDocenteSala(Docente docente, Sala sala, UsuarioLogueado usuarioLogueado)
        {
            return DesasignarDocenteSala(docente, sala, usuarioLogueado);
        }

        public Resultado DesasignarHijoPadre(Hijo hijo, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            return DesasignarHijoPadre(hijo, padre, usuarioLogueado);
        }

        public Resultado EditarAlumno(int id, Hijo hijo, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.EditarAlumno(id, hijo, usuarioLogueado);
        }

        public Resultado EditarDirectora(int id, Directora directora, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.EditarDirectora(id, directora, usuarioLogueado);
        }

        public Resultado EditarDocente(int id, Docente docente, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.EditarDocente(id, docente, usuarioLogueado);
        }

        public Resultado EditarPadreMadre(int id, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.EditarPadreMadre(id, padre, usuarioLogueado);
        }

        public Resultado EliminarAlumno(int id, Hijo hijo, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.EliminarAlumno(id, hijo, usuarioLogueado);
        }

        public Resultado EliminarDirectora(int id, Directora directora, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.EliminarDirectora(id, directora, usuarioLogueado);
        }

        public Resultado EliminarDocente(int id, Docente docente, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.EliminarDocente(id, docente, usuarioLogueado);
        }

        public Resultado EliminarPadreMadre(int id, Padre padre, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.EliminarPadreMadre(id, padre, usuarioLogueado);
        }

        public Resultado MarcarNotaComoLeida(Nota nota, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.MarcarNotaComoLeida(nota, usuarioLogueado);
        }

        public Hijo ObtenerAlumnoPorId(UsuarioLogueado usuarioLogueado, int id)
        {
            return ClasePrincipal.ObtenerAlumnoPorId(usuarioLogueado, id);
        }

        public Grilla<Hijo> ObtenerAlumnos(UsuarioLogueado usuarioLogueado, int paginaActual, int totalPorPagina, string busquedaGlobal)
        {
            return ClasePrincipal.ObtenerAlumnos(usuarioLogueado, paginaActual, totalPorPagina, busquedaGlobal);
        }

        public Nota[] ObtenerCuadernoComunicaciones(int idPersona, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.ObtenerCuadernoComunicaciones(idPersona, usuarioLogueado);
        }

        public Directora ObtenerDirectoraPorId(UsuarioLogueado usuarioLogueado, int id)
        {
            return ClasePrincipal.ObtenerDirectoraPorId(usuarioLogueado, id);
        }

        public Grilla<Directora> ObtenerDirectoras(UsuarioLogueado usuarioLogueado, int paginaActual, int totalPorPagina, string busquedaGlobal)
        {
            return ClasePrincipal.ObtenerDirectoras(usuarioLogueado, paginaActual, totalPorPagina, busquedaGlobal);
        }

        public Docente ObtenerDocentePorId(UsuarioLogueado usuarioLogueado, int id)
        {
            return ClasePrincipal.ObtenerDocentePorId(usuarioLogueado, id);
        }

        public Grilla<Docente> ObtenerDocentes(UsuarioLogueado usuarioLogueado, int paginaActual, int totalPorPagina, string busquedaGlobal)
        {
            return ClasePrincipal.ObtenerDocentes(usuarioLogueado, paginaActual, totalPorPagina, busquedaGlobal);
        }

        public Institucion[] ObtenerInstituciones()
        {
            throw new NotImplementedException();
        }

        public string ObtenerNombreGrupo()
        {
            return ClasePrincipal.ObtenerNombreGrupo();
        }

        public Padre ObtenerPadrePorId(UsuarioLogueado usuarioLogueado, int id)
        {
            return ClasePrincipal.ObtenerPadrePorId(usuarioLogueado, id);
        }

        public Grilla<Padre> ObtenerPadres(UsuarioLogueado usuarioLogueado, int paginaActual, int totalPorPagina, string busquedaGlobal)
        {
            return ClasePrincipal.ObtenerPadres(usuarioLogueado, paginaActual, totalPorPagina, busquedaGlobal);
        }

        public Hijo[] ObtenerPersonas(UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.ObtenerPersonas(usuarioLogueado);
        }

        public Sala[] ObtenerSalasPorInstitucion(UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.ObtenerSalasPorInstitucion(usuarioLogueado);
        }

        public UsuarioLogueado ObtenerUsuario(string email, string clave)
        {
            return ClasePrincipal.ObtenerUsuario(email, clave);
        }

        public Resultado ResponderNota(Nota nota, Comentario nuevoComentario, UsuarioLogueado usuarioLogueado)
        {
            return ClasePrincipal.ResponderNota(nota, nuevoComentario, usuarioLogueado);
        }
    }
}