using System;
using System.Collections.Generic;
using System.Text;
using Task.Entities;
using Tesk.Persistencia.DalArchivos;
using Tesk.Persistencia.Interfaces;

namespace Task.LogicaNegocio
{
    public class ManagerEquipos
    {
        IEquipo _dalEquipo;
        public ManagerEquipos()
        {
            _dalEquipo = new EquipoArchivo();
        }
        public int CrearEquipo(Equipo equipo)
        {
            if (_dalEquipo is null)
                throw new Exception("No se pudo crear el equipo");
            var equipos = LeerEquipos();
            int idEquipo = equipos.Any() ? equipos.Max(e => e.Id) + 1 : 1;
            return _dalEquipo.CrearEquipo(equipo);
        }
        public List<Equipo> CargarEquipos()
        {
            if (_dalEquipo is null)
                throw new Exception("No se pudo cargar los equipos");
            return LeerEquipos();
        }
        private List<Equipo> LeerEquipos()
        {
            if (_dalEquipo is null)
                throw new Exception("No se pudieron leer los equipoios");
            var equipos = _dalEquipo.LeerEquipos();
            if (equipos is null)
                return new List<Equipo>();
            return equipos;

        }
    }
}

    

