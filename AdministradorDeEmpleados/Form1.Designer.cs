namespace AdministradorDeEmpleados
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
            btnIniciarSesion = new Button();
            label1 = new Label();
            btnRegistrarse = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPas = new TextBox();
            lnklOlvide = new LinkLabel();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(287, 203);
            btnIniciarSesion.Margin = new Padding(2);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(190, 55);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 9);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 1;
            label1.Text = "BIENVENIDO";
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(83, 204);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(190, 53);
            btnRegistrarse.TabIndex = 1;
            btnRegistrarse.Text = "Registrarse";
            btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 74);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 129);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 5;
            label4.Text = "Contraseña:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 38);
            label5.Name = "label5";
            label5.Size = new Size(181, 15);
            label5.TabIndex = 6;
            label5.Text = "A continuación ingrese sus datos";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(162, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(211, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPas
            // 
            txtPas.Location = new Point(162, 147);
            txtPas.Name = "txtPas";
            txtPas.Size = new Size(211, 23);
            txtPas.TabIndex = 3;
            // 
            // lnklOlvide
            // 
            lnklOlvide.AutoSize = true;
            lnklOlvide.Location = new Point(254, 173);
            lnklOlvide.Name = "lnklOlvide";
            lnklOlvide.Size = new Size(119, 15);
            lnklOlvide.TabIndex = 4;
            lnklOlvide.TabStop = true;
            lnklOlvide.Text = "Olvide mi contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(lnklOlvide);
            Controls.Add(txtPas);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnRegistrarse);
            Controls.Add(label1);
            Controls.Add(btnIniciarSesion);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Inicio de sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private Label label1;
        private Button btnRegistrarse;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtPas;
        private LinkLabel lnklOlvide;
    }
}