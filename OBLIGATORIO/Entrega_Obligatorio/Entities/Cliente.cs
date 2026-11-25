namespace Entities;

public class Cliente
{
    public int Id { get; set; }
    public string Tipo { get; set; } = "Particular";
    public string Documento { get; set; } = "";
    public string Nombre { get; set; } = "";
    public string Telefono { get; set; } = "";
    public string Email { get; set; } = "";
    public string Direccion { get; set; } = "";
    public string Empresa { get; set; } = "";
}
