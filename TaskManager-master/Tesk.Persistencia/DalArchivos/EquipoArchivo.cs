using System;
using System.Collections.Generic;
using System.Text;
using Task.Entities;
using Tesk.Persistencia.Interfaces;

namespace Tesk.Persistencia.DalArchivos
{
    public class EquipoArchivo : IEquipo
    {
        private readonly string filePath = Path.Combine(Constantes.RUTA_ARCHIVOS, $"{Constantes.ARCHIVO_EQUIPOS}.json");
        private IFileProvider _fileProvider = new FileProviders.JsonFileProvider();
        public int CrearEquipo(Equipo equipo)
        {
            
            List<Equipo> equipos = LeerEquipos();
            equipos.Add(equipo);
            _fileProvider.GuardarRegistros(filePath, equipos);
            return equipo.Id;

        }

        public bool GuardarEquipo(List<Equipo> equipos)
        {
            throw new NotImplementedException();
        }

        public List<Equipo> LeerEquipos()
        {
            throw new NotImplementedException();
        }
    }
}
