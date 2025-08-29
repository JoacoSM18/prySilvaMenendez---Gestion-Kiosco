namespace prySilvaMenendez_EjercicioSemana2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            btnModificar = new RadioButton();
            lblCodigo = new Label();
            lblProducto = new Label();
            btnAgregar = new RadioButton();
            btnEliminar = new RadioButton();
            lbBienvenida = new Label();
            lblAccion = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(251, 269);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(251, 211);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = true;
            btnModificar.Location = new Point(49, 106);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(146, 19);
            btnModificar.TabIndex = 2;
            btnModificar.TabStop = true;
            btnModificar.Text = "Modificar Un Producto";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(49, 214);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(170, 15);
            lblCodigo.TabIndex = 3;
            lblCodigo.Text = "Ingrese el Codigo del Producto";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(49, 272);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(175, 15);
            lblProducto.TabIndex = 4;
            lblProducto.Text = "Ingrese el Nombre del Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = true;
            btnAgregar.Location = new Point(290, 106);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 19);
            btnAgregar.TabIndex = 5;
            btnAgregar.TabStop = true;
            btnAgregar.Text = "Agregar Un Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.Location = new Point(168, 140);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 19);
            btnEliminar.TabIndex = 6;
            btnEliminar.TabStop = true;
            btnEliminar.Text = "Eliminar Un Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lbBienvenida
            // 
            lbBienvenida.AutoSize = true;
            lbBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lbBienvenida.Location = new Point(72, 9);
            lbBienvenida.Name = "lbBienvenida";
            lbBienvenida.Size = new Size(341, 37);
            lbBienvenida.TabIndex = 7;
            lbBienvenida.Text = "BIENVENIDO AL SISTEMA";
            lbBienvenida.Click += this.label1_Click;
            // 
            // lblAccion
            // 
            lblAccion.AutoSize = true;
            lblAccion.Location = new Point(127, 59);
            lblAccion.Name = "lblAccion";
            lblAccion.Size = new Size(208, 15);
            lblAccion.TabIndex = 8;
            lblAccion.Text = "Seleccione la Accion Que Desea Hacer";
            lblAccion.Click += this.label2_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(309, 360);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(73, 38);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 424);
            Controls.Add(btnAceptar);
            Controls.Add(lblAccion);
            Controls.Add(lbBienvenida);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblProducto);
            Controls.Add(lblCodigo);
            Controls.Add(btnModificar);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCodigo;
        private RadioButton btnModificar;
        private Label lblCodigo;
        private Label lblProducto;
        private RadioButton btnAgregar;
        private RadioButton btnEliminar;
        private Label lbBienvenida;
        private Label lblAccion;
        private Button btnAceptar;
    }
}
