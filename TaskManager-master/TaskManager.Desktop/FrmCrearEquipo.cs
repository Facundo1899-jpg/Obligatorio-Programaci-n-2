using Task.Entities;
using Task.LogicaNegocio;

namespace TaskManager.Desktop

{
    public partial class FrmCrearEquipo : Form
    {

        public FrmCrearEquipo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo
            {
                Nombre = txtNomb.Text
            };
            equipo.Descripcion = txtDesc.Text;

            equipo.MaxIntegrantes = Convert.ToInt32(txtMax.Text);
            ManagerEquipos manager = new ManagerEquipos();
            try
            {
                manager.CrearEquipo(equipo);
                MessageBox.Show("Equipo creado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }    
}