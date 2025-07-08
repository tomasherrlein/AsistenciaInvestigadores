namespace WinFormsAsistenciaInvestigadores
{
    partial class FormAgregarEditarInvestigador
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
            lblNombreCompleto = new Label();
            txtbNombre = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panel2 = new Panel();
            lblDepartamentos = new Label();
            ckbMecanica = new CheckBox();
            ckbElectrica = new CheckBox();
            ckbCivil = new CheckBox();
            ckbAutomotriz = new CheckBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreCompleto.Location = new Point(11, 12);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(109, 15);
            lblNombreCompleto.TabIndex = 0;
            lblNombreCompleto.Text = "Nombre completo";
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(133, 9);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(245, 23);
            txtbNombre.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(310, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(126, 39);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(143, 216);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(126, 39);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(txtbNombre);
            panel2.Controls.Add(lblNombreCompleto);
            panel2.Location = new Point(87, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 49);
            panel2.TabIndex = 10;
            // 
            // lblDepartamentos
            // 
            lblDepartamentos.AutoSize = true;
            lblDepartamentos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepartamentos.Location = new Point(11, 5);
            lblDepartamentos.Name = "lblDepartamentos";
            lblDepartamentos.Size = new Size(99, 15);
            lblDepartamentos.TabIndex = 2;
            lblDepartamentos.Text = "Departamento/s";
            // 
            // ckbMecanica
            // 
            ckbMecanica.AutoSize = true;
            ckbMecanica.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbMecanica.Location = new Point(133, 5);
            ckbMecanica.Name = "ckbMecanica";
            ckbMecanica.Size = new Size(78, 19);
            ckbMecanica.TabIndex = 3;
            ckbMecanica.Text = "Mecánica";
            ckbMecanica.UseVisualStyleBackColor = true;
            // 
            // ckbElectrica
            // 
            ckbElectrica.AutoSize = true;
            ckbElectrica.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbElectrica.Location = new Point(222, 5);
            ckbElectrica.Name = "ckbElectrica";
            ckbElectrica.Size = new Size(73, 19);
            ckbElectrica.TabIndex = 4;
            ckbElectrica.Text = "Eléctrica";
            ckbElectrica.UseVisualStyleBackColor = true;
            // 
            // ckbCivil
            // 
            ckbCivil.AutoSize = true;
            ckbCivil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbCivil.Location = new Point(133, 30);
            ckbCivil.Name = "ckbCivil";
            ckbCivil.Size = new Size(49, 19);
            ckbCivil.TabIndex = 5;
            ckbCivil.Text = "Civil";
            ckbCivil.UseVisualStyleBackColor = true;
            // 
            // ckbAutomotriz
            // 
            ckbAutomotriz.AutoSize = true;
            ckbAutomotriz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ckbAutomotriz.Location = new Point(222, 30);
            ckbAutomotriz.Name = "ckbAutomotriz";
            ckbAutomotriz.Size = new Size(90, 19);
            ckbAutomotriz.TabIndex = 6;
            ckbAutomotriz.Text = "Automotriz";
            ckbAutomotriz.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(ckbAutomotriz);
            panel1.Controls.Add(ckbCivil);
            panel1.Controls.Add(ckbElectrica);
            panel1.Controls.Add(ckbMecanica);
            panel1.Controls.Add(lblDepartamentos);
            panel1.Location = new Point(87, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 62);
            panel1.TabIndex = 9;
            // 
            // FormAgregarEditarInvestigador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(573, 270);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAgregarEditarInvestigador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombreCompleto;
        private TextBox txtbNombre;
        private Button btnCancelar;
        private Button btnGuardar;
        private Panel panel2;
        private Label lblDepartamentos;
        private CheckBox ckbMecanica;
        private CheckBox ckbElectrica;
        private CheckBox ckbCivil;
        private CheckBox ckbAutomotriz;
        private Panel panel1;
    }
}