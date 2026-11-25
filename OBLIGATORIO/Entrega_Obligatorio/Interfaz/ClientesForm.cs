using Entities;
using Persistencia;
using Datos;
namespace Interfaz;
using System.Data;
using Microsoft.Data.SqlClient;

public partial class ClientesForm : Form
{
    private readonly RepositorioJson<Cliente> repositorio = new("clientes.json");



    private int idSeleccionado = 0;

    public ClientesForm()
    {
        InitializeComponent();
        cmbTipo.Items.AddRange(new object[] { "Particular", "Empresa" });
        cmbTipo.SelectedIndex = 0;
        btnGuardar.Click += (s, e) => Guardar();
        btnModificar.Click += (s, e) => Modificar();
        btnEliminar.Click += (s, e) => Eliminar();
        btnLimpiar.Click += (s, e) => Limpiar();
        btnActualizar.Click += (s, e) => CargarGrilla();
        grilla.SelectionChanged += (s, e) => SeleccionarCliente();
        CargarGrilla();
    }

    private void CargarGrilla()
    {
        grilla.DataSource = null;
        grilla.DataSource = repositorio.ObtenerTodos();
        grilla.ClearSelection();
    }

    private void Guardar()
    {
        if (txtDocumento.Text.Trim() == "" || txtNombre.Text.Trim() == "")
        {
            MessageBox.Show("El documento y el nombre son obligatorios.");
            return;
        }

        List<Cliente> clientes = repositorio.ObtenerTodos();

        bool existe = clientes.Any(c => c.Documento == txtDocumento.Text.Trim());

        if (existe)
        {
            MessageBox.Show("Ya existe un cliente con ese documento.");
            return;
        }

        int nuevoId = 1;

        if (clientes.Count > 0)
            nuevoId = clientes.Max(c => c.Id) + 1;

        Cliente cliente = new Cliente();
        cliente.Id = nuevoId;
        cliente.Tipo = cmbTipo.Text;
        cliente.Documento = txtDocumento.Text.Trim();
        cliente.Nombre = txtNombre.Text.Trim();
        cliente.Telefono = txtTelefono.Text.Trim();
        cliente.Email = txtEmail.Text.Trim();
        cliente.Direccion = txtDireccion.Text.Trim();
        cliente.Empresa = txtEmpresa.Text.Trim();

        clientes.Add(cliente);
        repositorio.Guardar(clientes);

        CargarGrilla();
        Limpiar();
        MessageBox.Show("Cliente guardado correctamente.");
    }

    private void Modificar()
    {
        List<Cliente> clientes = repositorio.ObtenerTodos();
        Cliente cliente = clientes.FirstOrDefault(c => c.Id == idSeleccionado);

        if (cliente == null)
        {
            MessageBox.Show("Seleccione un cliente de la lista.");
            return;
        }

        if (txtDocumento.Text.Trim() == "" || txtNombre.Text.Trim() == "")
        {
            MessageBox.Show("El documento y el nombre son obligatorios.");
            return;
        }

        bool documentoRepetido = clientes.Any(c =>
            c.Id != idSeleccionado && c.Documento == txtDocumento.Text.Trim());

        if (documentoRepetido)
        {
            MessageBox.Show("Ese documento ya pertenece a otro cliente.");
            return;
        }

        cliente.Tipo = cmbTipo.Text;
        cliente.Documento = txtDocumento.Text.Trim();
        cliente.Nombre = txtNombre.Text.Trim();
        cliente.Telefono = txtTelefono.Text.Trim();
        cliente.Email = txtEmail.Text.Trim();
        cliente.Direccion = txtDireccion.Text.Trim();
        cliente.Empresa = txtEmpresa.Text.Trim();

        repositorio.Guardar(clientes);
        CargarGrilla();
        Limpiar();
        MessageBox.Show("Cliente modificado correctamente.");
    }

    private void Eliminar()
    {
        if (idSeleccionado == 0)
        {
            MessageBox.Show("Seleccione un cliente de la lista.");
            return;
        }

        DialogResult respuesta = MessageBox.Show(
            "¿Está seguro de eliminar el cliente seleccionado?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (respuesta == DialogResult.Yes)
        {
            List<Cliente> clientes = repositorio.ObtenerTodos();
            clientes.RemoveAll(c => c.Id == idSeleccionado);
            repositorio.Guardar(clientes);
            CargarGrilla();
            Limpiar();
        }
    }

    private void SeleccionarCliente()
    {
        if (grilla.CurrentRow == null)
            return;

        if (grilla.CurrentRow.DataBoundItem is Cliente cliente)
        {
            idSeleccionado = cliente.Id;
            cmbTipo.Text = cliente.Tipo;
            txtDocumento.Text = cliente.Documento;
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtEmail.Text = cliente.Email;
            txtDireccion.Text = cliente.Direccion;
            txtEmpresa.Text = cliente.Empresa;
        }
    }

    private void Limpiar()
    {
        idSeleccionado = 0;
        cmbTipo.SelectedIndex = 0;
        txtDocumento.Clear();
        txtNombre.Clear();
        txtTelefono.Clear();
        txtEmail.Clear();
        txtDireccion.Clear();
        txtEmpresa.Clear();
        grilla.ClearSelection();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        Cliente cliente = new Cliente();
        cliente.Tipo = cmbTipo.Text;
        cliente.Documento = txtDocumento.Text;
        cliente.Nombre = txtNombre.Text;
        cliente.Telefono = txtTelefono.Text;
        cliente.Email = txtEmail.Text;
        cliente.Direccion = txtDireccion.Text;
        cliente.Empresa = txtEmpresa.Text;

        DatosGestion datos = new DatosGestion();
        datos.GuardarCliente(cliente);
        dgvClientes.DataSource = datos.ListarClientes();

        MessageBox.Show("El cliente fue guardado con exito");
    }

    private void ClientesForm_Load(object sender, EventArgs e)
    {
        DatosGestion datos = new DatosGestion();
        dgvClientes.DataSource = datos.ListarClientes();
    }
}
