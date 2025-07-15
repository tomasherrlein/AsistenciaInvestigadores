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
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(150, 50);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.ShowUpDown = true;
            this.dtpHoraEntrada.Size = new System.Drawing.Size(200, 23);
            this.dtpHoraEntrada.TabIndex = 0;
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(150, 100);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.ShowUpDown = true;
            this.dtpHoraSalida.Size = new System.Drawing.Size(200, 23);
            this.dtpHoraSalida.TabIndex = 1;
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(50, 55);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(82, 15);
            this.lblHoraEntrada.TabIndex = 2;
            this.lblHoraEntrada.Text = "Hora Entrada:";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(50, 105);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(73, 15);
            this.lblHoraSalida.TabIndex = 3;
            this.lblHoraSalida.Text = "Hora Salida:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(200, 150);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormAgregarEditarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Name = "FormAgregarEditarAsistencia";
            this.Text = "Formulario Asistencia";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.Button btnGuardar;
    }
}