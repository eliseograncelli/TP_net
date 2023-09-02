namespace AdministradorDeEmpleados.PL
{
    partial class frmEmpleados
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
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            label3 = new Label();
            picFoto = new PictureBox();
            btnExaminar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnCancelar = new Button();
            dgvEmpleados = new DataGridView();
            txtId = new Label();
            txtDNI = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 26);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 43);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(289, 43);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(289, 85);
            txtPass.Margin = new Padding(2);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(256, 23);
            txtPass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 68);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // picFoto
            // 
            picFoto.Location = new Point(15, 16);
            picFoto.Margin = new Padding(2);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(99, 92);
            picFoto.TabIndex = 6;
            picFoto.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(16, 119);
            btnExaminar.Margin = new Padding(2);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(99, 26);
            btnExaminar.TabIndex = 7;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(187, 119);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(68, 26);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(259, 119);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(67, 26);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(330, 119);
            btnBorrar.Margin = new Padding(2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(66, 26);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(435, 119);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 26);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeight = 34;
            dgvEmpleados.Location = new Point(17, 155);
            dgvEmpleados.Margin = new Padding(2);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 62;
            dgvEmpleados.Size = new Size(675, 164);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellMouseClick += Seleccionar;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(127, 7);
            txtId.Margin = new Padding(2, 0, 2, 0);
            txtId.Name = "txtId";
            txtId.Size = new Size(0, 15);
            txtId.TabIndex = 12;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(127, 85);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(158, 23);
            txtDNI.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 71);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 14;
            label4.Text = "DNI:";
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 330);
            Controls.Add(label4);
            Controls.Add(txtDNI);
            Controls.Add(txtId);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnCancelar);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(btnExaminar);
            Controls.Add(picFoto);
            Controls.Add(label3);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "frmEmpleados";
            Text = "frmClientes";
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Label label3;
        private PictureBox picFoto;
        private Button btnExaminar;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnBorrar;
        private Button btnCancelar;
        private DataGridView dgvEmpleados;
        private Label txtId;
        private TextBox txtDNI;
        private Label label4;
    }
}