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
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 48);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 48);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(181, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(149, 31);
            txtNombre.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(351, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(364, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(181, 148);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(243, 31);
            txtPass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 120);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // picFoto
            // 
            picFoto.Location = new Point(22, 27);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(141, 153);
            picFoto.TabIndex = 6;
            picFoto.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(23, 199);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(142, 44);
            btnExaminar.TabIndex = 7;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(267, 199);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(97, 44);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(370, 199);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 44);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(472, 199);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(95, 44);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(622, 199);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(142, 44);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeight = 34;
            dgvEmpleados.Location = new Point(24, 258);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 62;
            dgvEmpleados.Size = new Size(964, 175);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellMouseClick += Seleccionar;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(181, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(0, 25);
            txtId.TabIndex = 12;
            // 
            // frmEmpleados
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 450);
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
            Name = "frmEmpleados";
            Text = "frmEmpleados";
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
    }
}