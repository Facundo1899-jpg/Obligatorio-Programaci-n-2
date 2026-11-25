namespace Task.Entities
{
    public class Equipo
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int MaxIntegrantes { get; set; }
        public List<Usuario> Integrantes { get; set; } = new List<Usuario>();
        public List<Tarea> Tareas { get; set; } = new List<Tarea>();
    }
}
