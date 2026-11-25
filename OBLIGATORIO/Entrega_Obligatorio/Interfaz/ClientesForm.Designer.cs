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
        txtDocumento = new TextBox();
        txtNombre = new TextBox();
        txtTelefono = new TextBox();
        txtEmail = new TextBox();
        txtDireccion = new TextBox();
        txtEmpresa = new TextBox();
        cmbTipo = new ComboBox();
        btnGuardar = new Button();
        btnModificar = new Button();
        btnEliminar = new Button();
        btnLimpiar = new Button();
        btnActualizar = new Button();
        grilla = new DataGridView();
        lblTitulo = new Label();
        lbl_cmbTipo = new Label();
        lbl_txtEmpresa = new Label();
        lbl_txtDireccion = new Label();
        lbl_txtEmail = new Label();
        lbl_txtTelefono = new Label();
        lbl_txtNombre = new Label();
        lbl_txtDocumento = new Label();
        panelCampos = new Panel();
        panelBotones = new FlowLayoutPanel();
        dgvClientes = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
        panelCampos.SuspendLayout();
        panelBotones.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
        SuspendLayout();
        // 
        // txtDocumento
        // 
        txtDocumento.Location = new Point(20, 22);
        txtDocumento.Name = "txtDocumento";
        txtDocumento.Size = new Size(220, 24);
        txtDocumento.TabIndex = 0;
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(280, 22);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(220, 24);
        txtNombre.TabIndex = 2;
        // 
        // txtTelefono
        // 
        txtTelefono.Location = new Point(540, 22);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new Size(220, 24);
        txtTelefono.TabIndex = 4;
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(20, 92);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(220, 24);
        txtEmail.TabIndex = 6;
        // 
        // txtDireccion
        // 
        txtDireccion.Location = new Point(280, 92);
        txtDireccion.Name = "txtDireccion";
        txtDireccion.Size = new Size(220, 24);
        txtDireccion.TabIndex = 8;
        // 
        // txtEmpresa
        // 
        txtEmpresa.Location = new Point(540, 92);
        txtEmpresa.Name = "txtEmpresa";
        txtEmpresa.Size = new Size(220, 24);
        txtEmpresa.TabIndex = 10;
        // 
        // cmbTipo
        // 
        cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipo.Location = new Point(800, 22);
        cmbTipo.Name = "cmbTipo";
        cmbTipo.Size = new Size(210, 25);
        cmbTipo.TabIndex = 12;
        // 
        // btnGuardar
        // 
        btnGuardar.BackColor = Color.FromArgb(35, 93, 150);
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.ForeColor = Color.White;
        btnGuardar.Location = new Point(13, 8);
        btnGuardar.Margin = new Padding(8, 3, 8, 3);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(135, 38);
        btnGuardar.TabIndex = 0;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += btnGuardar_Click;
        // 
        // btnModificar
        // 
        btnModificar.BackColor = Color.FromArgb(35, 93, 150);
        btnModificar.FlatStyle = FlatStyle.Flat;
        btnModificar.ForeColor = Color.White;
        btnModificar.Location = new Point(164, 8);
        btnModificar.Margin = new Padding(8, 3, 8, 3);
        btnModificar.Name = "btnModificar";
        btnModificar.Size = new Size(135, 38);
        btnModificar.TabIndex = 1;
        btnModificar.Text = "Modificar";
        btnModificar.UseVisualStyleBackColor = false;
        // 
        // btnEliminar
        // 
        btnEliminar.BackColor = Color.FromArgb(35, 93, 150);
        btnEliminar.FlatStyle = FlatStyle.Flat;
        btnEliminar.ForeColor = Color.White;
        btnEliminar.Location = new Point(315, 8);
        btnEliminar.Margin = new Padding(8, 3, 8, 3);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(135, 38);
        btnEliminar.TabIndex = 2;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = false;
        // 
        // btnLimpiar
        // 
        btnLimpiar.BackColor = Color.FromArgb(35, 93, 150);
        btnLimpiar.FlatStyle = FlatStyle.Flat;
        btnLimpiar.ForeColor = Color.White;
        btnLimpiar.Location = new Point(466, 8);
        btnLimpiar.Margin = new Padding(8, 3, 8, 3);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(135, 38);
        btnLimpiar.TabIndex = 3;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = false;
        // 
        // btnActualizar
        // 
        btnActualizar.BackColor = Color.FromArgb(35, 93, 150);
        btnActualizar.FlatStyle = FlatStyle.Flat;
        btnActualizar.ForeColor = Color.White;
        btnActualizar.Location = new Point(617, 8);
        btnActualizar.Margin = new Padding(8, 3, 8, 3);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new Size(135, 38);
        btnActualizar.TabIndex = 4;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = false;
        // 
        // grilla
        // 
        grilla.Location = new Point(0, 0);
        grilla.Name = "grilla";
        grilla.Size = new Size(240, 150);
        grilla.TabIndex = 0;
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(35, 65, 95);
        lblTitulo.Location = new Point(20, 15);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1050, 42);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "GESTIÓN DE CLIENTES";
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lbl_cmbTipo
        // 
        lbl_cmbTipo.AutoSize = true;
        lbl_cmbTipo.Location = new Point(800, 0);
        lbl_cmbTipo.Name = "lbl_cmbTipo";
        lbl_cmbTipo.Size = new Size(94, 17);
        lbl_cmbTipo.TabIndex = 13;
        lbl_cmbTipo.Text = "Tipo de cliente";
        // 
        // lbl_txtEmpresa
        // 
        lbl_txtEmpresa.AutoSize = true;
        lbl_txtEmpresa.Location = new Point(540, 70);
        lbl_txtEmpresa.Name = "lbl_txtEmpresa";
        lbl_txtEmpresa.Size = new Size(159, 17);
        lbl_txtEmpresa.TabIndex = 11;
        lbl_txtEmpresa.Text = "Empresa (si corresponde)";
        // 
        // lbl_txtDireccion
        // 
        lbl_txtDireccion.AutoSize = true;
        lbl_txtDireccion.Location = new Point(280, 70);
        lbl_txtDireccion.Name = "lbl_txtDireccion";
        lbl_txtDireccion.Size = new Size(62, 17);
        lbl_txtDireccion.TabIndex = 9;
        lbl_txtDireccion.Text = "Dirección";
        // 
        // lbl_txtEmail
        // 
        lbl_txtEmail.AutoSize = true;
        lbl_txtEmail.Location = new Point(20, 70);
        lbl_txtEmail.Name = "lbl_txtEmail";
        lbl_txtEmail.Size = new Size(117, 17);
        lbl_txtEmail.TabIndex = 7;
        lbl_txtEmail.Text = "Correo electrónico";
        // 
        // lbl_txtTelefono
        // 
        lbl_txtTelefono.AutoSize = true;
        lbl_txtTelefono.Location = new Point(540, 0);
        lbl_txtTelefono.Name = "lbl_txtTelefono";
        lbl_txtTelefono.Size = new Size(58, 17);
        lbl_txtTelefono.TabIndex = 5;
        lbl_txtTelefono.Text = "Teléfono";
        // 
        // lbl_txtNombre
        // 
        lbl_txtNombre.AutoSize = true;
        lbl_txtNombre.Location = new Point(280, 0);
        lbl_txtNombre.Name = "lbl_txtNombre";
        lbl_txtNombre.Size = new Size(143, 17);
        lbl_txtNombre.TabIndex = 3;
        lbl_txtNombre.Text = "Nombre / Razón social";
        // 
        // lbl_txtDocumento
        // 
        lbl_txtDocumento.AutoSize = true;
        lbl_txtDocumento.Location = new Point(20, 0);
        lbl_txtDocumento.Name = "lbl_txtDocumento";
        lbl_txtDocumento.Size = new Size(75, 17);
        lbl_txtDocumento.TabIndex = 1;
        lbl_txtDocumento.Text = "Documento";
        // 
        // panelCampos
        // 
        panelCampos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelCampos.BackColor = Color.White;
        panelCampos.BorderStyle = BorderStyle.FixedSingle;
        panelCampos.Controls.Add(txtDocumento);
        panelCampos.Controls.Add(lbl_txtDocumento);
        panelCampos.Controls.Add(txtNombre);
        panelCampos.Controls.Add(lbl_txtNombre);
        panelCampos.Controls.Add(txtTelefono);
        panelCampos.Controls.Add(lbl_txtTelefono);
        panelCampos.Controls.Add(txtEmail);
        panelCampos.Controls.Add(lbl_txtEmail);
        panelCampos.Controls.Add(txtDireccion);
        panelCampos.Controls.Add(lbl_txtDireccion);
        panelCampos.Controls.Add(txtEmpresa);
        panelCampos.Controls.Add(lbl_txtEmpresa);
        panelCampos.Controls.Add(cmbTipo);
        panelCampos.Controls.Add(lbl_cmbTipo);
        panelCampos.Location = new Point(20, 65);
        panelCampos.Name = "panelCampos";
        panelCampos.Size = new Size(1050, 205);
        panelCampos.TabIndex = 1;
        // 
        // panelBotones
        // 
        panelBotones.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelBotones.Controls.Add(btnGuardar);
        panelBotones.Controls.Add(btnModificar);
        panelBotones.Controls.Add(btnEliminar);
        panelBotones.Controls.Add(btnLimpiar);
        panelBotones.Controls.Add(btnActualizar);
        panelBotones.Location = new Point(20, 285);
        panelBotones.Name = "panelBotones";
        panelBotones.Padding = new Padding(5);
        panelBotones.Size = new Size(1050, 55);
        panelBotones.TabIndex = 2;
        panelBotones.WrapContents = false;
        // 
        // dgvClientes
        // 
        dgvClientes.BackgroundColor = SystemColors.ButtonHighlight;
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvClientes.Location = new Point(20, 346);
        dgvClientes.Name = "dgvClientes";
        dgvClientes.Size = new Size(1050, 362);
        dgvClientes.TabIndex = 3;
        // 
        // ClientesForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(1100, 720);
        Controls.Add(dgvClientes);
        Controls.Add(lblTitulo);
        Controls.Add(panelCampos);
        Controls.Add(panelBotones);
        Font = new Font("Segoe UI", 9.5F);
        MinimumSize = new Size(950, 650);
        Name = "ClientesForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de clientes";
        Load += ClientesForm_Load;
        ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
        panelCampos.ResumeLayout(false);
        panelCampos.PerformLayout();
        panelBotones.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
        ResumeLayout(false);

    }

    private DataGridView dgvClientes;
}
