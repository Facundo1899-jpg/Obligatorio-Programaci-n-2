using System.Text.Json;
using Task.Entities;
using Tesk.Persistencia.Interfaces;
using System.Linq;

namespace Tesk.Persistencia.DalArchivos
{
    public class TareaArchivo : ITarea
    {
        private readonly string filePath = Path
            .Combine(Constantes.RUTA_ARCHIVOS, $"{Constantes.ARCHIVO_TAREAS}.json");

        private IFileProvider _fileProvider = new FileProviders.JsonFileProvider();

        public List<Tarea> BuscarTareas(Guid idCuenta)
        {
            List<Tarea> tareas = LeerTareas();
            return tareas.Where(t=>t.IdCuenta == idCuenta).ToList();
        }

        public int CrearTarea(Tarea tarea)
        {
            List<Tarea> tareas = LeerTareas();
            tareas.Add(tarea);
            _fileProvider.GuardarRegistros(filePath, tareas);
            return tarea.Id;
        }

        public List<Tarea> LeerTareas()
        {
            return _fileProvider.LeerRegistros<Tarea>(filePath);
        }

        public bool GuardarTareas(List<Tarea> tareas)
        {
            _fileProvider.GuardarRegistros(filePath, tareas);
            return true;
        }

    }
}
