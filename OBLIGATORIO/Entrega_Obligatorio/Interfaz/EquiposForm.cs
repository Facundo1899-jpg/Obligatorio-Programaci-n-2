using Entities;
using Persistencia;

namespace Interfaz;

public partial class EquiposForm : Form
{
    private readonly RepositorioJson<Equipo> repositorio = new("equipos.json");
    private readonly RepositorioJson<Deposito> repositorioDepositos = new("depositos.json");




    private int idSeleccionado = 0;

    public EquiposForm()
    {
        InitializeComponent();
        cmbEstado.Items.AddRange(new object[] { "Disponible", "Alquilado", "En mantenimiento" });
        cmbEstado.SelectedIndex = 0;
        btnGuardar.Click += (s, e) => Guardar();
        btnModificar.Click += (s, e) => Modificar();
        btnEliminar.Click += (s, e) => Eliminar();
        btnLimpiar.Click += (s, e) => Limpiar();
        btnActualizar.Click += (s, e) => ActualizarDatos();
        grilla.SelectionChanged += (s, e) => SeleccionarEquipo();
        CargarDepositos();
        CargarGrilla();
    }

    private void CargarDepositos()
    {
        List<Deposito> depositos = repositorioDepositos.ObtenerTodos();

        cmbDeposito.DataSource = null;
        cmbDeposito.DataSource = depositos;
        cmbDeposito.DisplayMember = "Nombre";
        cmbDeposito.ValueMember = "Id";
    }

    private void CargarGrilla()
    {
        List<Deposito> depositos = repositorioDepositos.ObtenerTodos();
        List<Equipo> equipos = repositorio.ObtenerTodos();

        var lista = from equipo in equipos
                    join deposito in depositos
                    on equipo.DepositoId equals deposito.Id
                    select new
                    {
                        equipo.Id,
                        equipo.Nombre,
                        equipo.Tipo,
                        equipo.Estado,
                        Deposito = deposito.Nombre,
                        equipo.Observaciones
                    };

        grilla.DataSource = null;
        grilla.DataSource = lista.ToList();
        grilla.ClearSelection();
    }

    private void ActualizarDatos()
    {
        CargarDepositos();
        CargarGrilla();
    }

    private void Guardar()
    {
        if (txtNombre.Text.Trim() == "" || txtTipo.Text.Trim() == "")
        {
            MessageBox.Show("El nombre y el tipo son obligatorios.");
            return;
        }

        if (cmbDeposito.SelectedValue == null)
        {
            MessageBox.Show("Primero debe registrar un depósito.");
            return;
        }

        List<Equipo> equipos = repositorio.ObtenerTodos();

        int nuevoId = 1;
        if (equipos.Count > 0)
            nuevoId = equipos.Max(e => e.Id) + 1;

        Equipo equipo = new Equipo();
        equipo.Id = nuevoId;
        equipo.Nombre = txtNombre.Text.Trim();
        equipo.Tipo = txtTipo.Text.Trim();
        equipo.Estado = cmbEstado.Text;
        equipo.DepositoId = Convert.ToInt32(cmbDeposito.SelectedValue);
        equipo.Observaciones = txtObservaciones.Text.Trim();

        equipos.Add(equipo);
        repositorio.Guardar(equipos);

        CargarGrilla();
        Limpiar();
        MessageBox.Show("Equipo guardado correctamente.");
    }

    private void Modificar()
    {
        List<Equipo> equipos = repositorio.ObtenerTodos();
        Equipo equipo = equipos.FirstOrDefault(e => e.Id == idSeleccionado);

        if (equipo == null)
        {
            MessageBox.Show("Seleccione un equipo de la lista.");
            return;
        }

        if (txtNombre.Text.Trim() == "" || txtTipo.Text.Trim() == "")
        {
            MessageBox.Show("El nombre y el tipo son obligatorios.");
            return;
        }

        if (cmbDeposito.SelectedValue == null)
        {
            MessageBox.Show("Seleccione un depósito.");
            return;
        }

        equipo.Nombre = txtNombre.Text.Trim();
        equipo.Tipo = txtTipo.Text.Trim();
        equipo.Estado = cmbEstado.Text;
        equipo.DepositoId = Convert.ToInt32(cmbDeposito.SelectedValue);
        equipo.Observaciones = txtObservaciones.Text.Trim();

        repositorio.Guardar(equipos);
        CargarGrilla();
        Limpiar();
        MessageBox.Show("Equipo modificado correctamente.");
    }

    private void Eliminar()
    {
        if (idSeleccionado == 0)
        {
            MessageBox.Show("Seleccione un equipo de la lista.");
            return;
        }

        DialogResult respuesta = MessageBox.Show(
            "¿Está seguro de eliminar el equipo seleccionado?",
            "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (respuesta == DialogResult.Yes)
        {
            List<Equipo> equipos = repositorio.ObtenerTodos();
            equipos.RemoveAll(e => e.Id == idSeleccionado);
            repositorio.Guardar(equipos);
            CargarGrilla();
            Limpiar();
        }
    }

    private void SeleccionarEquipo()
    {
        if (grilla.CurrentRow == null)
            return;

        object valorId = grilla.CurrentRow.Cells["Id"].Value;
        if (valorId == null)
            return;

        idSeleccionado = Convert.ToInt32(valorId);

        Equipo equipo = repositorio.ObtenerTodos()
            .FirstOrDefault(e => e.Id == idSeleccionado);

        if (equipo == null)
            return;

        txtNombre.Text = equipo.Nombre;
        txtTipo.Text = equipo.Tipo;
        cmbEstado.Text = equipo.Estado;

        if (cmbDeposito.Items.Count > 0)
            cmbDeposito.SelectedValue = equipo.DepositoId;

        txtObservaciones.Text = equipo.Observaciones;
    }

    private void Limpiar()
    {
        idSeleccionado = 0;
        txtNombre.Clear();
        txtTipo.Clear();
        txtObservaciones.Clear();

        if (cmbEstado.Items.Count > 0)
            cmbEstado.SelectedIndex = 0;

        if (cmbDeposito.Items.Count > 0)
            cmbDeposito.SelectedIndex = 0;

        grilla.ClearSelection();
    }
}
