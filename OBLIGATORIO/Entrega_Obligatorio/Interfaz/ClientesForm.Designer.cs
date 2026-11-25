namespace Interfaz;

partial class ClientesForm
{
    private System.ComponentModel.IContainer? components = null;
    private System.Windows.Forms.TextBox txtDocumento = null!;
    private System.Windows.Forms.TextBox txtNombre = null!;
    private System.Windows.Forms.TextBox txtTelefono = null!;
    private System.Windows.Forms.TextBox txtEmail = null!;
    private System.Windows.Forms.TextBox txtDireccion = null!;
    private System.Windows.Forms.TextBox txtEmpresa = null!;
    private System.Windows.Forms.ComboBox cmbTipo = null!;
    private System.Windows.Forms.Button btnGuardar = null!;
    private System.Windows.Forms.Button btnModificar = null!;
    private System.Windows.Forms.Button btnEliminar = null!;
    private System.Windows.Forms.Button btnLimpiar = null!;
    private System.Windows.Forms.Button btnActualizar = null!;
    private System.Windows.Forms.DataGridView grilla = null!;
    private System.Windows.Forms.Label lblTitulo = null!;
    private System.Windows.Forms.Label lbl_cmbTipo = null!;
    private System.Windows.Forms.Label lbl_txtEmpresa = null!;
    private System.Windows.Forms.Label lbl_txtDireccion = null!;
    private System.Windows.Forms.Label lbl_txtEmail = null!;
    private System.Windows.Forms.Label lbl_txtTelefono = null!;
    private System.Windows.Forms.Label lbl_txtNombre = null!;
    private System.Windows.Forms.Label lbl_txtDocumento = null!;
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
        this.txtDocumento = new System.Windows.Forms.TextBox();
        this.txtNombre = new System.Windows.Forms.TextBox();
        this.txtTelefono = new System.Windows.Forms.TextBox();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.txtDireccion = new System.Windows.Forms.TextBox();
        this.txtEmpresa = new System.Windows.Forms.TextBox();
        this.cmbTipo = new System.Windows.Forms.ComboBox();
        this.btnGuardar = new System.Windows.Forms.Button();
        this.btnModificar = new System.Windows.Forms.Button();
        this.btnEliminar = new System.Windows.Forms.Button();
        this.btnLimpiar = new System.Windows.Forms.Button();
        this.btnActualizar = new System.Windows.Forms.Button();
        this.grilla = new System.Windows.Forms.DataGridView();
        this.lblTitulo = new System.Windows.Forms.Label();
        this.lbl_cmbTipo = new System.Windows.Forms.Label();
        this.lbl_txtEmpresa = new System.Windows.Forms.Label();
        this.lbl_txtDireccion = new System.Windows.Forms.Label();
        this.lbl_txtEmail = new System.Windows.Forms.Label();
        this.lbl_txtTelefono = new System.Windows.Forms.Label();
        this.lbl_txtNombre = new System.Windows.Forms.Label();
        this.lbl_txtDocumento = new System.Windows.Forms.Label();
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
        this.Text = "Gestión de clientes";
        // Título
        this.lblTitulo.AutoSize = false;
        this.lblTitulo.Location = new System.Drawing.Point(20, 15);
        this.lblTitulo.Size = new System.Drawing.Size(1050, 42);
        this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(35, 65, 95);
        this.lblTitulo.Text = "GESTIÓN DE CLIENTES";
        this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.Controls.Add(this.lblTitulo);
        // Campos
        this.panelCampos.Location = new System.Drawing.Point(20, 65);
        this.panelCampos.Size = new System.Drawing.Size(1050, 205);
        this.panelCampos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
        this.panelCampos.BackColor = System.Drawing.Color.White;
        this.panelCampos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.Controls.Add(this.panelCampos);
        // Documento
        this.txtDocumento.Location = new System.Drawing.Point(20, 22);
        this.txtDocumento.Size = new System.Drawing.Size(220, 28);
        this.panelCampos.Controls.Add(this.txtDocumento);
        this.lbl_txtDocumento.Name = "lbl_txtDocumento";
        this.lbl_txtDocumento.Text = "Documento";
        this.lbl_txtDocumento.Location = new System.Drawing.Point(20, 0);
        this.lbl_txtDocumento.AutoSize = true;
        this.panelCampos.Controls.Add(this.lbl_txtDocumento);
        // Nombre / Razón social
        this.txtNombre.Location = new System.Drawing.Point(280, 22);
        this.txtNombre.Size = new System.Drawing.Size(220, 28);
        this.panelCampos.Controls.Add(this.txtNombre);
        this.lbl_txtNombre.Name = "lbl_txtNombre";
        this.lbl_txtNombre.Text = "Nombre / Razón social";
        this.lbl_txtNombre.Location = new System.Drawing.Point(280, 0);
        this.lbl_txtNombre.AutoSize = true;
        this.panelCampos.Controls.Add(this.lbl_txtNombre);
        // Teléfono
        this.txtTelefono.Location = new System.Drawing.Point(540, 22);
        this.txtTelefono.Size = new System.Drawing.Size(220, 28);
        this.panelCampos.Controls.Add(this.txtTelefono);
        this.lbl_txtTelefono.Name = "lbl_txtTelefono";
        this.lbl_txtTelefono.Text = "Teléfono";
        this.lbl_txtTelefono.Location = new System.Drawing.Point(540, 0);
        this.lbl_txtTelefono.AutoSize = true;
        this.panelCampos.Controls.Add(this.lbl_txtTelefono);
        // Correo electrónico
        this.txtEmail.Location = new System.Drawing.Point(20, 92);
        this.txtEmail.Size = new System.Drawing.Size(220, 28);
        this.panelCampos.Controls.Add(this.txtEmail);
        this.lbl_txtEmail.Name = "lbl_txtEmail";
        this.lbl_txtEmail.Text = "Correo electrónico";
        this.lbl_txtEmail.Location = new System.Drawing.Point(20, 70);
        this.lbl_txtEmail.AutoSize = true;
        this.panelCampos.Controls.Add(this.lbl_txtEmail);
        // Dirección
        this.txtDireccion.Location = new System.Drawing.Point(280, 92);
        this.txtDireccion.Size = new System.Drawing.Size(220, 28);
        this.panelCampos.Controls.Add(this.txtDireccion);
        this.lbl_txtDireccion.Name = "lbl_txtDireccion";
        this.lbl_txtDireccion.Text = "Dirección";
        this.lbl_txtDireccion.Location = new System.Drawing.Point(280, 70);
        this.lbl_txtDireccion.AutoSize = true;
        this.panelCampos.Controls.Add(this.lbl_txtDireccion);
        // Empresa (si corresponde)
        this.txtEmpresa.Location = new System.Drawing.Point(540, 92);
        this.txtEmpresa.Size = new System.Drawing.Size(220, 28);
        this.panelCampos.Controls.Add(this.txtEmpresa);
        this.lbl_txtEmpresa.Name = "lbl_txtEmpresa";
        this.lbl_txtEmpresa.Text = "Empresa (si corresponde)";
        this.lbl_txtEmpresa.Location = new System.Drawing.Point(540, 70);
        this.lbl_txtEmpresa.AutoSize = true;
        this.panelCampos.Controls.Add(this.lbl_txtEmpresa);
        // Tipo de cliente
        this.cmbTipo.Location = new System.Drawing.Point(800, 22);
        this.cmbTipo.Size = new System.Drawing.Size(210, 28);
        this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.panelCampos.Controls.Add(this.cmbTipo);
        this.lbl_cmbTipo.Name = "lbl_cmbTipo";
        this.lbl_cmbTipo.Text = "Tipo de cliente";
        this.lbl_cmbTipo.Location = new System.Drawing.Point(800, 0);
        this.lbl_cmbTipo.AutoSize = true;
        this.panelCampos.Controls.Add(this.lbl_cmbTipo);
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
        
    }
}
