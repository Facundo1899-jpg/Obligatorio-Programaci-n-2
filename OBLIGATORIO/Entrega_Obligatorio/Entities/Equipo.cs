namespace Entities;

public class Equipo
{
    public int Id { get; set; }
    public int IdDeposito { get; set; }
    public string Nombre { get; set; } = "";
    public string Tipo { get; set; } = "";
    public string Estado { get; set; } = "Disponible";
    public int DepositoId { get; set; }
    public string Observaciones { get; set; } = "";
}
