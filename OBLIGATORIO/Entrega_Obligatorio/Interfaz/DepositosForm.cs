using Entities;
using Persistencia;

namespace Interfaz;

public partial class DepositosForm : Form
{
    private readonly RepositorioJson<Deposito> repositorio = new("depositos.json");
    private readonly RepositorioJson<Equipo> repositorioEquipos = new("equipos.json");


    private int idSeleccionado = 0;

    public DepositosForm()
    {
        InitializeComponent();
        btnGuardar.Click += (s, e) => Guardar();
        btnModificar.Click += (s, e) => Modificar();
        btnEliminar.Click += (s, e) => Eliminar();
        btnLimpiar.Click += (s, e) => Limpiar();
        btnActualizar.Click += (s, e) => CargarGrilla();
        grilla.SelectionChanged += (s, e) => SeleccionarDeposito();
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
        if (txtNombre.Text.Trim() == "" || txtUbicacion.Text.Trim() == "")
        {
            MessageBox.Show("El nombre y la ubicación son obligatorios.");
            return;
        }

        List<Deposito> depositos = repositorio.ObtenerTodos();

        int nuevoId = 1;
        if (depositos.Count > 0)
            nuevoId = depositos.Max(d => d.Id) + 1;

        Deposito deposito = new Deposito();
        deposito.Id = nuevoId;
        deposito.Nombre = txtNombre.Text.Trim();
        deposito.Ubicacion = txtUbicacion.Text.Trim();
        deposito.Observaciones = txtObservaciones.Text.Trim();

        depositos.Add(deposito);
        repositorio.Guardar(depositos);

        CargarGrilla();
        Limpiar();
        MessageBox.Show("Depósito guardado correctamente.");
    }

    private void Modificar()
    {
        List<Deposito> depositos = repositorio.ObtenerTodos();
        Deposito deposito = depositos.FirstOrDefault(d => d.Id == idSeleccionado);

        if (deposito == null)
        {
            MessageBox.Show("Seleccione un depósito de la lista.");
            return;
        }

        if (txtNombre.Text.Trim() == "" || txtUbicacion.Text.Trim() == "")
        {
            MessageBox.Show("El nombre y la ubicación son obligatorios.");
            return;
        }

        deposito.Nombre = txtNombre.Text.Trim();
        deposito.Ubicacion = txtUbicacion.Text.Trim();
        deposito.Observaciones = txtObservaciones.Text.Trim();

        repositorio.Guardar(depositos);
        CargarGrilla();
        Limpiar();
        MessageBox.Show("Depósito modificado correctamente.");
    }

    private void Eliminar()
    {
        if (idSeleccionado == 0)
        {
            MessageBox.Show("Seleccione un depósito de la lista.");
            return;
        }

        List<Equipo> equipos = repositorioEquipos.ObtenerTodos();
        bool tieneEquipos = equipos.Any(e => e.DepositoId == idSeleccionado);

        if (tieneEquipos)
        {
            MessageBox.Show("No se puede eliminar: hay equipos asociados a este depósito.");
            return;
        }

        DialogResult respuesta = MessageBox.Show(
            "¿Está seguro de eliminar el depósito seleccionado?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (respuesta == DialogResult.Yes)
        {
            List<Deposito> depositos = repositorio.ObtenerTodos();
            depositos.RemoveAll(d => d.Id == idSeleccionado);
            repositorio.Guardar(depositos);
            CargarGrilla();
            Limpiar();
        }
    }

    private void SeleccionarDeposito()
    {
        if (grilla.CurrentRow == null)
            return;

        if (grilla.CurrentRow.DataBoundItem is Deposito deposito)
        {
            idSeleccionado = deposito.Id;
            txtNombre.Text = deposito.Nombre;
            txtUbicacion.Text = deposito.Ubicacion;
            txtObservaciones.Text = deposito.Observaciones;
        }
    }

    private void Limpiar()
    {
        idSeleccionado = 0;
        txtNombre.Clear();
        txtUbicacion.Clear();
        txtObservaciones.Clear();
        grilla.ClearSelection();
    }
}
