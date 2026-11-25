namespace Interfaz;

public partial class MenuPrincipal : Form
{
    public MenuPrincipal()
    {
        InitializeComponent();
        btnClientes.Click += (s, e) => new ClientesForm().ShowDialog(this);
        btnDepositos.Click += (s, e) => new DepositosForm().ShowDialog(this);
        btnEquipamiento.Click += (s, e) => new EquiposForm().ShowDialog(this);
    }

    private void btnClientes_Click(object sender, EventArgs e)
    {
        ClientesForm formulario = new ClientesForm();
        formulario.ShowDialog(this);
    }

    private void btnDepositos_Click(object sender, EventArgs e)
    {
        DepositosForm formulario = new DepositosForm();
        formulario.ShowDialog(this);
    }

    private void btnEquipamiento_Click(object sender, EventArgs e)
    {
        EquiposForm formulario = new EquiposForm();
        formulario.ShowDialog(this);
    }
}
