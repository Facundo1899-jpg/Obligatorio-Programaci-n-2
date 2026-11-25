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
        txtNombre = new TextBox();
        txtUbicacion = new TextBox();
        txtObservaciones = new TextBox();
        btnGuardar = new Button();
        btnModificar = new Button();
        btnEliminar = new Button();
        btnLimpiar = new Button();
        btnActualizar = new Button();
        grilla = new DataGridView();
        lblTitulo = new Label();
        lbl_txtObservaciones = new Label();
        lbl_txtUbicacion = new Label();
        lbl_txtNombre = new Label();
        panelCampos = new Panel();
        panelBotones = new FlowLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
        panelCampos.SuspendLayout();
        panelBotones.SuspendLayout();
        SuspendLayout();
        // 
        // txtNombre
        // 
        txtNombre.Location = new Point(20, 22);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new Size(220, 24);
        txtNombre.TabIndex = 0;
        // 
        // txtUbicacion
        // 
        txtUbicacion.Location = new Point(280, 22);
        txtUbicacion.Name = "txtUbicacion";
        txtUbicacion.Size = new Size(220, 24);
        txtUbicacion.TabIndex = 2;
        // 
        // txtObservaciones
        // 
        txtObservaciones.Location = new Point(540, 22);
        txtObservaciones.Name = "txtObservaciones";
        txtObservaciones.Size = new Size(220, 24);
        txtObservaciones.TabIndex = 4;
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
        grilla.AllowUserToAddRows = false;
        grilla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        grilla.BackgroundColor = Color.White;
        grilla.Location = new Point(20, 355);
        grilla.MultiSelect = false;
        grilla.Name = "grilla";
        grilla.ReadOnly = true;
        grilla.RowHeadersVisible = false;
        grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        grilla.Size = new Size(1050, 340);
        grilla.TabIndex = 3;
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(35, 65, 95);
        lblTitulo.Location = new Point(20, 15);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(1050, 42);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "GESTIÓN DE DEPÓSITOS";
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lbl_txtObservaciones
        // 
        lbl_txtObservaciones.AutoSize = true;
        lbl_txtObservaciones.Location = new Point(540, 0);
        lbl_txtObservaciones.Name = "lbl_txtObservaciones";
        lbl_txtObservaciones.Size = new Size(94, 17);
        lbl_txtObservaciones.TabIndex = 5;
        lbl_txtObservaciones.Text = "Observaciones";
        // 
        // lbl_txtUbicacion
        // 
        lbl_txtUbicacion.AutoSize = true;
        lbl_txtUbicacion.Location = new Point(280, 0);
        lbl_txtUbicacion.Name = "lbl_txtUbicacion";
        lbl_txtUbicacion.Size = new Size(65, 17);
        lbl_txtUbicacion.TabIndex = 3;
        lbl_txtUbicacion.Text = "Ubicación";
        // 
        // lbl_txtNombre
        // 
        lbl_txtNombre.AutoSize = true;
        lbl_txtNombre.Location = new Point(20, 0);
        lbl_txtNombre.Name = "lbl_txtNombre";
        lbl_txtNombre.Size = new Size(57, 17);
        lbl_txtNombre.TabIndex = 1;
        lbl_txtNombre.Text = "Nombre";
        // 
        // panelCampos
        // 
        panelCampos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        panelCampos.BackColor = Color.White;
        panelCampos.BorderStyle = BorderStyle.FixedSingle;
        panelCampos.Controls.Add(txtNombre);
        panelCampos.Controls.Add(lbl_txtNombre);
        panelCampos.Controls.Add(txtUbicacion);
        panelCampos.Controls.Add(lbl_txtUbicacion);
        panelCampos.Controls.Add(txtObservaciones);
        panelCampos.Controls.Add(lbl_txtObservaciones);
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
        // DepositosForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(1100, 720);
        Controls.Add(lblTitulo);
        Controls.Add(panelCampos);
        Controls.Add(panelBotones);
        Controls.Add(grilla);
        Font = new Font("Segoe UI", 9.5F);
        MinimumSize = new Size(950, 650);
        Name = "DepositosForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gestión de depósitos";
        ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
        panelCampos.ResumeLayout(false);
        panelCampos.PerformLayout();
        panelBotones.ResumeLayout(false);
        ResumeLayout(false);
    }
}
