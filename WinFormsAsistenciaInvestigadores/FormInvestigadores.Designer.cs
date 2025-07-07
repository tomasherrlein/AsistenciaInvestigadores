namespace WinFormsAsistenciaInvestigadores
{
    partial class FormInvestigadores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            btnFiltroMecanica = new Button();
            btnFiltroElectrica = new Button();
            btnFiltroCivil = new Button();
            btnFiltroAutomotriz = new Button();
            btnFiltroLimpiar = new Button();
            btnAgregar = new Button();
            panelFiltro = new Panel();
            lblFiltros = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFiltro.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MediumTurquoise;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 155);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(550, 212);
            dataGridView1.TabIndex = 0;
            // 
            // btnFiltroMecanica
            // 
            btnFiltroMecanica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnFiltroMecanica.BackColor = Color.Salmon;
            btnFiltroMecanica.FlatAppearance.BorderColor = Color.Crimson;
            btnFiltroMecanica.FlatStyle = FlatStyle.Flat;
            btnFiltroMecanica.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltroMecanica.Location = new Point(31, 45);
            btnFiltroMecanica.MaximumSize = new Size(86, 48);
            btnFiltroMecanica.MinimumSize = new Size(86, 48);
            btnFiltroMecanica.Name = "btnFiltroMecanica";
            btnFiltroMecanica.Size = new Size(86, 48);
            btnFiltroMecanica.TabIndex = 1;
            btnFiltroMecanica.Text = "Mecánica";
            btnFiltroMecanica.UseVisualStyleBackColor = false;
            btnFiltroMecanica.Click += btnFiltroMecanica_Click;
            // 
            // btnFiltroElectrica
            // 
            btnFiltroElectrica.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnFiltroElectrica.BackColor = Color.Teal;
            btnFiltroElectrica.FlatAppearance.BorderColor = Color.PaleTurquoise;
            btnFiltroElectrica.FlatStyle = FlatStyle.Flat;
            btnFiltroElectrica.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltroElectrica.Location = new Point(171, 45);
            btnFiltroElectrica.MaximumSize = new Size(86, 48);
            btnFiltroElectrica.MinimumSize = new Size(86, 48);
            btnFiltroElectrica.Name = "btnFiltroElectrica";
            btnFiltroElectrica.Size = new Size(86, 48);
            btnFiltroElectrica.TabIndex = 2;
            btnFiltroElectrica.Text = "Eléctrica";
            btnFiltroElectrica.UseVisualStyleBackColor = false;
            btnFiltroElectrica.Click += btnFiltroElectrica_Click;
            // 
            // btnFiltroCivil
            // 
            btnFiltroCivil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnFiltroCivil.BackColor = Color.YellowGreen;
            btnFiltroCivil.FlatAppearance.BorderColor = Color.OliveDrab;
            btnFiltroCivil.FlatStyle = FlatStyle.Flat;
            btnFiltroCivil.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltroCivil.Location = new Point(313, 45);
            btnFiltroCivil.MaximumSize = new Size(86, 48);
            btnFiltroCivil.MinimumSize = new Size(86, 48);
            btnFiltroCivil.Name = "btnFiltroCivil";
            btnFiltroCivil.Size = new Size(86, 48);
            btnFiltroCivil.TabIndex = 3;
            btnFiltroCivil.Text = "Civil";
            btnFiltroCivil.UseVisualStyleBackColor = false;
            btnFiltroCivil.Click += btnFiltroCivil_Click;
            // 
            // btnFiltroAutomotriz
            // 
            btnFiltroAutomotriz.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnFiltroAutomotriz.BackColor = Color.Gold;
            btnFiltroAutomotriz.FlatAppearance.BorderColor = Color.Orange;
            btnFiltroAutomotriz.FlatStyle = FlatStyle.Flat;
            btnFiltroAutomotriz.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltroAutomotriz.ForeColor = SystemColors.ControlText;
            btnFiltroAutomotriz.Location = new Point(455, 45);
            btnFiltroAutomotriz.MaximumSize = new Size(86, 48);
            btnFiltroAutomotriz.MinimumSize = new Size(86, 48);
            btnFiltroAutomotriz.Name = "btnFiltroAutomotriz";
            btnFiltroAutomotriz.Size = new Size(86, 48);
            btnFiltroAutomotriz.TabIndex = 4;
            btnFiltroAutomotriz.Text = "Automotriz";
            btnFiltroAutomotriz.UseVisualStyleBackColor = false;
            btnFiltroAutomotriz.Click += btnFiltroAutomotriz_Click;
            // 
            // btnFiltroLimpiar
            // 
            btnFiltroLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFiltroLimpiar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltroLimpiar.Location = new Point(62, 390);
            btnFiltroLimpiar.MaximumSize = new Size(86, 48);
            btnFiltroLimpiar.MinimumSize = new Size(86, 48);
            btnFiltroLimpiar.Name = "btnFiltroLimpiar";
            btnFiltroLimpiar.Size = new Size(86, 48);
            btnFiltroLimpiar.TabIndex = 5;
            btnFiltroLimpiar.Text = "Limpiar filtro";
            btnFiltroLimpiar.UseVisualStyleBackColor = true;
            btnFiltroLimpiar.Click += btnFiltroLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(184, 390);
            btnAgregar.MaximumSize = new Size(86, 48);
            btnAgregar.MinimumSize = new Size(86, 48);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 48);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panelFiltro
            // 
            panelFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelFiltro.BackColor = SystemColors.GradientInactiveCaption;
            panelFiltro.Controls.Add(btnFiltroAutomotriz);
            panelFiltro.Controls.Add(btnFiltroCivil);
            panelFiltro.Controls.Add(btnFiltroElectrica);
            panelFiltro.Controls.Add(btnFiltroMecanica);
            panelFiltro.Location = new Point(44, 56);
            panelFiltro.Name = "panelFiltro";
            panelFiltro.Size = new Size(580, 389);
            panelFiltro.TabIndex = 7;
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.BackColor = SystemColors.GradientInactiveCaption;
            lblFiltros.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltros.Location = new Point(62, 79);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(158, 15);
            lblFiltros.TabIndex = 8;
            lblFiltros.Text = "Filtros por departamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 7);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 9;
            label1.Text = "Investigadores";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(44, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 32);
            panel1.TabIndex = 10;
            // 
            // FormInvestigadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lblFiltros);
            Controls.Add(btnAgregar);
            Controls.Add(btnFiltroLimpiar);
            Controls.Add(dataGridView1);
            Controls.Add(panelFiltro);
            Name = "FormInvestigadores";
            Text = "Investigadores ABML";
            Load += FormMain_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFiltro.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnFiltroMecanica;
        private Button btnFiltroElectrica;
        private Button btnFiltroCivil;
        private Button btnFiltroAutomotriz;
        private Button btnFiltroLimpiar;
        private Button btnAgregar;
        private Panel panelFiltro;
        private Label lblFiltros;
        private Label label1;
        private Panel panel1;
    }
}