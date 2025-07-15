namespace WinFormsAsistenciaInvestigadores
{
    partial class FormAgregarEditarAsistencia
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
            dtpHoraEntrada = new DateTimePicker();
            dtpHoraSalida = new DateTimePicker();
            lblHoraEntrada = new Label();
            lblHoraSalida = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // dtpHoraEntrada
            // 
            dtpHoraEntrada.CustomFormat = "HH:mm";
            dtpHoraEntrada.Format = DateTimePickerFormat.Custom;
            dtpHoraEntrada.Location = new Point(261, 50);
            dtpHoraEntrada.Name = "dtpHoraEntrada";
            dtpHoraEntrada.ShowUpDown = true;
            dtpHoraEntrada.Size = new Size(72, 23);
            dtpHoraEntrada.TabIndex = 0;
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.CustomFormat = "HH:mm";
            dtpHoraSalida.Format = DateTimePickerFormat.Custom;
            dtpHoraSalida.Location = new Point(261, 100);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.ShowUpDown = true;
            dtpHoraSalida.Size = new Size(72, 23);
            dtpHoraSalida.TabIndex = 1;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Location = new Point(161, 55);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(79, 15);
            lblHoraEntrada.TabIndex = 2;
            lblHoraEntrada.Text = "Hora Entrada:";
            // 
            // lblHoraSalida
            // 
            lblHoraSalida.AutoSize = true;
            lblHoraSalida.Location = new Point(161, 105);
            lblHoraSalida.Name = "lblHoraSalida";
            lblHoraSalida.Size = new Size(70, 15);
            lblHoraSalida.TabIndex = 3;
            lblHoraSalida.Text = "Hora Salida:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(118, 152);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(261, 152);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormAgregarEditarAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 211);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(lblHoraSalida);
            Controls.Add(lblHoraEntrada);
            Controls.Add(dtpHoraSalida);
            Controls.Add(dtpHoraEntrada);
            Name = "FormAgregarEditarAsistencia";
            Text = "Formulario Asistencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Button btnGuardar;
        private Button btnEliminar;
    }
}