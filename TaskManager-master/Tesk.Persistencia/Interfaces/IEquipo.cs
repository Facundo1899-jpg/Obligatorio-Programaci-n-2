using System;
using System.Collections.Generic;
using System.Text;
using Task.Entities;

namespace Tesk.Persistencia.Interfaces
{
    public interface IEquipo
    {
        int CrearEquipo(Equipo equipo);
        List<Equipo> LeerEquipos();
        bool GuardarEquipo(List<Equipo> equipos);
    }
}
