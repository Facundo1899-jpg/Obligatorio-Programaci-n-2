namespace Persistencia;

// Almacenamiento temporal en memoria: no utiliza base de datos ni crea archivos.
public class RepositorioJson<T> where T : class
{
    private static readonly Dictionary<string, List<T>> Datos = new();
    private readonly string _clave;

    public RepositorioJson(string nombreArchivo)
    {
        _clave = nombreArchivo;
        if (!Datos.ContainsKey(_clave))
            Datos[_clave] = new List<T>();
    }

    public List<T> ObtenerTodos()
    {
        return new List<T>(Datos[_clave]);
    }

    public void Guardar(List<T> elementos)
    {
        Datos[_clave] = new List<T>(elementos);
    }
}
