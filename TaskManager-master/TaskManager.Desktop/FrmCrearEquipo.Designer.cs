namespace TaskManager.Desktop
{
    partial class FrmCrearEquipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCrearEquipo = new Label();
            label1 = new Label();
            txtNomb = new TextBox();
            txtDesc = new TextBox();
            txtMax = new TextBox();
            lblDescripcion = new Label();
            lblMax = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblCrearEquipo
            // 
            lblCrearEquipo.AutoSize = true;
            lblCrearEquipo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearEquipo.Location = new Point(259, 9);
            lblCrearEquipo.Name = "lblCrearEquipo";
            lblCrearEquipo.Size = new Size(248, 47);
            lblCrearEquipo.TabIndex = 0;
            lblCrearEquipo.Text = "Crear equipos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 120);
            label1.Name = "label1";
            label1.Size = new Size(116, 16);
            label1.TabIndex = 1;
            label1.Text = "Nombre del equipo";
            // 
            // txtNomb
            // 
            txtNomb.Location = new Point(197, 139);
            txtNomb.Name = "txtNomb";
            txtNomb.Size = new Size(100, 23);
            txtNomb.TabIndex = 2;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(197, 197);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(100, 23);
            txtDesc.TabIndex = 3;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(197, 258);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 23);
            txtMax.TabIndex = 4;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(121, 178);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(75, 16);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMax.Location = new Point(88, 240);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(119, 16);
            lblMax.TabIndex = 6;
            lblMax.Text = "Maximo integrantes";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(336, 322);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar equipo";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmCrearEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(lblMax);
            Controls.Add(lblDescripcion);
            Controls.Add(txtMax);
            Controls.Add(txtDesc);
            Controls.Add(txtNomb);
            Controls.Add(label1);
            Controls.Add(lblCrearEquipo);
            Name = "FrmCrearEquipo";
            Text = "FrmCrearEquipo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCrearEquipo;
        private Label label1;
        private TextBox txtNomb;
        private TextBox txtDesc;
        private TextBox txtMax;
        private Label lblDescripcion;
        private Label lblMax;
        private Button btnGuardar;
    }
}