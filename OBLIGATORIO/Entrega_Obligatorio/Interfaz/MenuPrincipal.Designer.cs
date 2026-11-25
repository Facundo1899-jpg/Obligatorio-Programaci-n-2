namespace Interfaz;

partial class MenuPrincipal
{
    private System.ComponentModel.IContainer? components = null;
    private Label lblTitulo = null!;
    private Label lblSubtitulo = null!;
    private FlowLayoutPanel panelMenu = null!;
    private Button btnClientes = null!;
    private Button btnDepositos = null!;
    private Button btnEquipamiento = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblSubtitulo = new Label();
        panelMenu = new FlowLayoutPanel();
        btnClientes = new Button();
        btnDepositos = new Button();
        btnEquipamiento = new Button();
        panelMenu.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.Anchor = AnchorStyles.None;
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.FromArgb(35, 65, 95);
        lblTitulo.Location = new Point(290, 64);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(344, 41);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "GESTIÓN DEL SISTEMA";
        // 
        // lblSubtitulo
        // 
        lblSubtitulo.AutoSize = true;
        lblSubtitulo.ForeColor = Color.DimGray;
        lblSubtitulo.Location = new Point(40, 90);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(0, 15);
        lblSubtitulo.TabIndex = 1;
        // 
        // panelMenu
        // 
        panelMenu.Anchor = AnchorStyles.None;
        panelMenu.Controls.Add(btnClientes);
        panelMenu.Controls.Add(btnDepositos);
        panelMenu.Controls.Add(btnEquipamiento);
        panelMenu.Location = new Point(101, 209);
        panelMenu.Name = "panelMenu";
        panelMenu.Size = new Size(672, 107);
        panelMenu.TabIndex = 2;
        // 
        // btnClientes
        // 
        btnClientes.BackColor = Color.FromArgb(35, 95, 145);
        btnClientes.FlatStyle = FlatStyle.Flat;
        btnClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnClientes.ForeColor = Color.White;
        btnClientes.Location = new Point(0, 0);
        btnClientes.Margin = new Padding(0, 0, 20, 0);
        btnClientes.Name = "btnClientes";
        btnClientes.Size = new Size(210, 75);
        btnClientes.TabIndex = 0;
        btnClientes.Text = "Clientes";
        btnClientes.UseVisualStyleBackColor = false;
        btnClientes.Click += btnClientes_Click;
        // 
        // btnDepositos
        // 
        btnDepositos.BackColor = Color.FromArgb(35, 95, 145);
        btnDepositos.FlatStyle = FlatStyle.Flat;
        btnDepositos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnDepositos.ForeColor = Color.White;
        btnDepositos.Location = new Point(230, 0);
        btnDepositos.Margin = new Padding(0, 0, 20, 0);
        btnDepositos.Name = "btnDepositos";
        btnDepositos.Size = new Size(210, 75);
        btnDepositos.TabIndex = 1;
        btnDepositos.Text = "Depósitos";
        btnDepositos.UseVisualStyleBackColor = false;
        btnDepositos.Click += btnDepositos_Click;
        // 
        // btnEquipamiento
        // 
        btnEquipamiento.BackColor = Color.FromArgb(35, 95, 145);
        btnEquipamiento.FlatStyle = FlatStyle.Flat;
        btnEquipamiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnEquipamiento.ForeColor = Color.White;
        btnEquipamiento.Location = new Point(460, 0);
        btnEquipamiento.Margin = new Padding(0);
        btnEquipamiento.Name = "btnEquipamiento";
        btnEquipamiento.Size = new Size(210, 75);
        btnEquipamiento.TabIndex = 2;
        btnEquipamiento.Text = "Equipamiento";
        btnEquipamiento.UseVisualStyleBackColor = false;
        btnEquipamiento.Click += btnEquipamiento_Click;
        // 
        // MenuPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(900, 600);
        Controls.Add(lblTitulo);
        Controls.Add(lblSubtitulo);
        Controls.Add(panelMenu);
        Name = "MenuPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sistema de gestión - Menú principal";
        panelMenu.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }
}
