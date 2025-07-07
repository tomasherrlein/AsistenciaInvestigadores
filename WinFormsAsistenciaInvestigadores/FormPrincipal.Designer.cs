namespace WinFormsAsistenciaInvestigadores
{
    partial class FormPrincipal
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
            btnFormInvestigadores = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnFormInvestigadores
            // 
            btnFormInvestigadores.BackColor = SystemColors.GradientActiveCaption;
            btnFormInvestigadores.FlatAppearance.BorderColor = Color.Teal;
            btnFormInvestigadores.FlatStyle = FlatStyle.Flat;
            btnFormInvestigadores.Location = new Point(275, 33);
            btnFormInvestigadores.Name = "btnFormInvestigadores";
            btnFormInvestigadores.Size = new Size(137, 73);
            btnFormInvestigadores.TabIndex = 0;
            btnFormInvestigadores.Text = "Investigadores";
            btnFormInvestigadores.UseVisualStyleBackColor = false;
            btnFormInvestigadores.Click += btnFormInvestigadores_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.FlatAppearance.BorderColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(41, 33);
            button1.Name = "button1";
            button1.Size = new Size(137, 73);
            button1.TabIndex = 1;
            button1.Text = "Asistencias";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnFormInvestigadores);
            panel1.Location = new Point(212, 199);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 142);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(349, 137);
            label1.Name = "label1";
            label1.Size = new Size(183, 30);
            label1.TabIndex = 3;
            label1.Text = "SCyT Asistencias";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Location = new Point(212, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 88);
            panel2.TabIndex = 3;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(914, 450);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormPrincipal";
            Text = "Asistencias";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFormInvestigadores;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
    }
}