namespace Interfaz;

partial class DepositosForm
{
    private System.ComponentModel.IContainer? components = null;
    private System.Windows.Forms.TextBox txtNombre = null!;
    private System.Windows.Forms.TextBox txtUbicacion = null!;
    private System.Windows.Forms.TextBox txtObservaciones = null!;
    private System.Windows.Forms.Button btnGuardar = null!;
    private System.Windows.Forms.Button btnModificar = null!;
    private System.Windows.Forms.Button btnEliminar = null!;
    private System.Windows.Forms.Button btnLimpiar = null!;
    private System.Windows.Forms.Button btnActualizar = null!;
    private System.Windows.Forms.DataGridView grilla = null!;
    private System.Windows.Forms.Label lblTitulo = null!;
    private System.Windows.Forms.Label lbl_txtObservaciones = null!;
    private System.Windows.Forms.Label lbl_txtUbicacion = null!;
    private System.Windows.Forms.Label lbl_txtNombre = null!;
    private System.Windows.Forms.Panel panelCampos = null!;
    private System.Windows.Forms.FlowLayoutPanel panelBotones = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.txtNombre = new System.Windows.Forms.TextBox();
        this.txtUbicacion = new System.Windows.Forms.TextBox();
        this.txtObservaciones = new System.Windows.Forms.TextBox();
        this.btnGuardar = new System.Windows.Forms.Button();
        this.btnModificar = new System.Windows.Forms.Button();
        this.btnEliminar = new System.Windows.Forms.Button();
        this.btnLimpiar = new System.Windows.Forms.Button();
        this.btnActualizar = new System.Windows.Forms.Button();
        this.grilla = new System.Windows.Forms.DataGridView();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.lbl_txtObservaciones = new System.Windows.Forms.Label();
        this.lbl_txtUbicacion = new System.Windows.Forms.Label();
        this.lbl_txtNombre = new System.Windows.Forms.Label();
        this.panelCampos = new System.Windows.Forms.Panel();
        this.panelBotones = new System.Windows.Forms.FlowLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
        this.SuspendLayout();
        // Formulario
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
        this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
        this.ClientSize = new System.Drawing.Size(1100, 720);
        this.MinimumSize = new System.Drawing.Size(950, 650);
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Gestión de depósitos";
        // Título
        this.lblTitulo.AutoSize = false;
        this.lblTitulo.Location = new System.Drawing.Point(20, 15);
        this.lblTitulo.Size = new System.Drawing.Size(1050, 42);
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(35, 65, 95);
        this.lblTitulo.Text = "GESTIÓN DE DEPÓSITOS";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.Controls.Add(this.lblTitulo);
        // Campos
        this.panelCampos.Location = new System.Drawing.Point(20, 65);
        this.panelCampos.Size = new System.Drawing.Size(1050, 205);
        this.panelCampos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.panelCampos.BackColor = System.Drawing.Color.White;
        this.panelCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.Controls.Add(this.panelCampos);
        // Nombre
        this.txtNombre.Location = new System.Drawing.Point(20, 22);
        this.txtNombre.Size = new System.Drawing.Size(220, 28);
        this.panelCampos.Controls.Add(this.txtNombre);
        this.lbl_txtNombre.Name = "lbl_txtNombre";
        this.lbl_txtNombre.Text = "Nombre";
        this.lbl_txtNombre.Location = new System.Drawing.Point(20, 0);
        this.lbl_txtNombre.AutoSize = true;
        this.panelCampos.Controls.Add(this.lbl_txtNombre);
        // Ubicación
        this.txtUbicacion.Location = new System.Drawing.Point(280, 22);
        this.txtUbicacion.Size = new System.Drawing.Size(220, 28);
        this.panelCampos.Controls.Add(this.txtUbicacion);
        this.lbl_txtUbicacion.Name = "lbl_txtUbicacion";
        this.lbl_txtUbicacion.Text = "Ubicación";
        this.lbl_txtUbicacion.Location = new System.Drawing.Point(280, 0);
        this.lbl_txtUbicacion.AutoSize = true;
        this.panelCampos.Controls.Add(this.lbl_txtUbicacion);
        // Observaciones
        this.txtObservaciones.Location = new System.Drawing.Point(540, 22);
        this.txtObservaciones.Size = new System.Drawing.Size(220, 28);
        this.panelCampos.Controls.Add(this.txtObservaciones);
        this.lbl_txtObservaciones.Name = "lbl_txtObservaciones";
        this.lbl_txtObservaciones.Text = "Observaciones";
        this.lbl_txtObservaciones.Location = new System.Drawing.Point(540, 0);
        this.lbl_txtObservaciones.AutoSize = true;
        this.panelCampos.Controls.Add(this.lbl_txtObservaciones);
        // Botones
        this.panelBotones.Location = new System.Drawing.Point(20, 285);
        this.panelBotones.Size = new System.Drawing.Size(1050, 55);
        this.panelBotones.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.panelBotones.WrapContents = false;
        this.panelBotones.Padding = new System.Windows.Forms.Padding(5);
        this.Controls.Add(this.panelBotones);
        this.btnGuardar.Name = "btnGuardar";
        this.btnGuardar.Text = "Guardar";
        this.btnGuardar.Size = new System.Drawing.Size(135, 38);
        this.btnGuardar.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
        this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(35, 93, 150);
        this.btnGuardar.ForeColor = System.Drawing.Color.White;
        this.panelBotones.Controls.Add(this.btnGuardar);
        this.btnModificar.Name = "btnModificar";
        this.btnModificar.Text = "Modificar";
        this.btnModificar.Size = new System.Drawing.Size(135, 38);
        this.btnModificar.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
        this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnModificar.BackColor = System.Drawing.Color.FromArgb(35, 93, 150);
        this.btnModificar.ForeColor = System.Drawing.Color.White;
        this.panelBotones.Controls.Add(this.btnModificar);
        this.btnEliminar.Name = "btnEliminar";
        this.btnEliminar.Text = "Eliminar";
        this.btnEliminar.Size = new System.Drawing.Size(135, 38);
        this.btnEliminar.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
        this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(35, 93, 150);
        this.btnEliminar.ForeColor = System.Drawing.Color.White;
        this.panelBotones.Controls.Add(this.btnEliminar);
        this.btnLimpiar.Name = "btnLimpiar";
        this.btnLimpiar.Text = "Limpiar";
        this.btnLimpiar.Size = new System.Drawing.Size(135, 38);
        this.btnLimpiar.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
        this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(35, 93, 150);
        this.btnLimpiar.ForeColor = System.Drawing.Color.White;
        this.panelBotones.Controls.Add(this.btnLimpiar);
        this.btnActualizar.Name = "btnActualizar";
        this.btnActualizar.Text = "Actualizar";
        this.btnActualizar.Size = new System.Drawing.Size(135, 38);
        this.btnActualizar.Margin = new System.Windows.Forms.Padding(8, 3, 8, 3);
        this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(35, 93, 150);
        this.btnActualizar.ForeColor = System.Drawing.Color.White;
        this.panelBotones.Controls.Add(this.btnActualizar);
        // Tabla de registros
        this.grilla.Location = new System.Drawing.Point(20, 355);
        this.grilla.Size = new System.Drawing.Size(1050, 340);
        this.grilla.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.grilla.ReadOnly = true;
        this.grilla.AllowUserToAddRows = false;
        this.grilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.grilla.MultiSelect = false;
        this.grilla.BackgroundColor = System.Drawing.Color.White;
        this.grilla.RowHeadersVisible = false;
        this.grilla.AutoGenerateColumns = true;
        this.Controls.Add(this.grilla);
        ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
        this.ResumeLayout(false);
    }
}
