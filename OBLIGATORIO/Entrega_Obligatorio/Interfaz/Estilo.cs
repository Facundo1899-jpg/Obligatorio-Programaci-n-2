using System.Drawing;

namespace Interfaz;

public static class Estilo
{
    public static void Preparar(Form formulario)
    {
        formulario.Font = new Font("Segoe UI", 10);
        formulario.BackColor = Color.FromArgb(245, 247, 250);
        formulario.StartPosition = FormStartPosition.CenterScreen;
        formulario.MinimumSize = new Size(900, 620);
    }

    public static Label Etiqueta(string texto)
    {
        return new Label
        {
            Text = texto,
            AutoSize = true,
            Margin = new Padding(5, 8, 5, 3)
        };
    }

    public static TextBox Caja()
    {
        return new TextBox
        {
            Width = 205,
            Margin = new Padding(5)
        };
    }

    public static Button Boton(string texto)
    {
        return new Button
        {
            Text = texto,
            Width = 125,
            Height = 38,
            FlatStyle = FlatStyle.Flat,
            BackColor = Color.FromArgb(35, 93, 150),
            ForeColor = Color.White,
            Margin = new Padding(6)
        };
    }

    public static DataGridView Grilla()
    {
        return new DataGridView
        {
            Dock = DockStyle.Fill,
            ReadOnly = true,
            AllowUserToAddRows = false,
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
            SelectionMode = DataGridViewSelectionMode.FullRowSelect,
            MultiSelect = false,
            BackgroundColor = Color.White,
            RowHeadersVisible = false,
            AutoGenerateColumns = true
        };
    }

    public static FlowLayoutPanel PanelCampos()
    {
        return new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(12),
            AutoScroll = true,
            WrapContents = true
        };
    }

    public static void AgregarCampo(FlowLayoutPanel panel, string nombre, Control control)
    {
        FlowLayoutPanel grupo = new FlowLayoutPanel
        {
            FlowDirection = FlowDirection.TopDown,
            Width = 225,
            Height = 65,
            WrapContents = false,
            Margin = new Padding(8)
        };

        grupo.Controls.Add(Etiqueta(nombre));
        grupo.Controls.Add(control);
        panel.Controls.Add(grupo);
    }

    public static FlowLayoutPanel PanelBotones()
    {
        return new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            Padding = new Padding(8),
            FlowDirection = FlowDirection.LeftToRight
        };
    }

    public static TableLayoutPanel PanelPrincipal(Control campos, Control botones, Control grilla, string titulo)
    {
        TableLayoutPanel principal = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 4,
            Padding = new Padding(15)
        };

        principal.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
        principal.RowStyles.Add(new RowStyle(SizeType.Absolute, 145));
        principal.RowStyles.Add(new RowStyle(SizeType.Absolute, 55));
        principal.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

        Label encabezado = new Label
        {
            Text = titulo,
            Font = new Font("Segoe UI", 17, FontStyle.Bold),
            ForeColor = Color.FromArgb(35, 65, 95),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft
        };

        principal.Controls.Add(encabezado, 0, 0);
        principal.Controls.Add(campos, 0, 1);
        principal.Controls.Add(botones, 0, 2);
        principal.Controls.Add(grilla, 0, 3);

        return principal;
    }
}
