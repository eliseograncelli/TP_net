namespace Formulario
{
    partial class ABMUs
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
            Alta = new Button();
            Baja = new Button();
            Modificacion = new Button();
            Regresar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Alta
            // 
            Alta.Location = new Point(74, 116);
            Alta.Name = "Alta";
            Alta.Size = new Size(97, 37);
            Alta.TabIndex = 2;
            Alta.Text = "Alta";
            Alta.UseVisualStyleBackColor = true;
            Alta.Click += Alta_Click;
            Alta.MouseClick += Alta_MouseClick;
            // 
            // Baja
            // 
            Baja.Location = new Point(219, 116);
            Baja.Name = "Baja";
            Baja.Size = new Size(97, 37);
            Baja.TabIndex = 3;
            Baja.Text = "Baja";
            Baja.UseVisualStyleBackColor = true;
            // 
            // Modificacion
            // 
            Modificacion.Location = new Point(355, 116);
            Modificacion.Name = "Modificacion";
            Modificacion.Size = new Size(97, 37);
            Modificacion.TabIndex = 4;
            Modificacion.Text = "Modificación";
            Modificacion.UseVisualStyleBackColor = true;
            // 
            // Regresar
            // 
            Regresar.Location = new Point(377, 182);
            Regresar.Name = "Regresar";
            Regresar.Size = new Size(75, 23);
            Regresar.TabIndex = 5;
            Regresar.Text = "Regresar";
            Regresar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 9);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 6;
            label1.Text = "ABM de Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 44);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 7;
            label2.Text = "¿Que desea realizar?";
            // 
            // ABMUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 258);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Regresar);
            Controls.Add(Modificacion);
            Controls.Add(Baja);
            Controls.Add(Alta);
            Name = "ABMUs";
            Text = "Menu Usuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Alta;
        private Button Baja;
        private Button Modificacion;
        private Button Regresar;
        private Label label1;
        private Label label2;
    }
}