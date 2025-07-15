namespace WinFormsAsistenciaInvestigadores
{
    partial class FormAsistenciasInvestigador
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            lblNombreMes = new Label();
            lblNombreInvestigador = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblFiltros = new Label();
            btnFiltroLimpiar = new Button();
            dataGridView1 = new DataGridView();
            panelFiltro = new Panel();
            numericUpDownAnio = new NumericUpDown();
            label3 = new Label();
            btnCargarAsistencias = new Button();
            label4 = new Label();
            cboMeses = new ComboBox();
            btnMostrarEliminados = new Button();
            btnFiltroAutomotriz = new Button();
            btnFiltroCivil = new Button();
            btnFiltroElectrica = new Button();
            btnFiltroMecanica = new Button();
            lblAnioSeleccionado = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnio).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.Location = new Point(10, 99);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(687, 402);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(127, 30);
            label1.TabIndex = 1;
            label1.Text = "Asistencias";
            // 
            // lblNombreMes
            // 
            lblNombreMes.AutoSize = true;
            lblNombreMes.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreMes.Location = new Point(69, 6);
            lblNombreMes.Name = "lblNombreMes";
            lblNombreMes.Size = new Size(0, 30);
            lblNombreMes.TabIndex = 2;
            // 
            // lblNombreInvestigador
            // 
            lblNombreInvestigador.AutoSize = true;
            lblNombreInvestigador.BackColor = SystemColors.ActiveCaption;
            lblNombreInvestigador.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreInvestigador.Location = new Point(178, 10);
            lblNombreInvestigador.Name = "lblNombreInvestigador";
            lblNombreInvestigador.Size = new Size(0, 30);
            lblNombreInvestigador.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(770, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 32);
            panel1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, 7);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 9;
            label2.Text = "Investigadores";
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.BackColor = SystemColors.GradientInactiveCaption;
            lblFiltros.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltros.Location = new Point(788, 74);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(158, 15);
            lblFiltros.TabIndex = 15;
            lblFiltros.Text = "Filtros por departamento";
            // 
            // btnFiltroLimpiar
            // 
            btnFiltroLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFiltroLimpiar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltroLimpiar.Location = new Point(477, 334);
            btnFiltroLimpiar.MaximumSize = new Size(86, 48);
            btnFiltroLimpiar.MinimumSize = new Size(86, 48);
            btnFiltroLimpiar.Name = "btnFiltroLimpiar";
            btnFiltroLimpiar.Size = new Size(86, 48);
            btnFiltroLimpiar.TabIndex = 12;
            btnFiltroLimpiar.Text = "Limpiar filtro";
            btnFiltroLimpiar.UseVisualStyleBackColor = true;
            btnFiltroLimpiar.Click += btnFiltroLimpiar_Click;
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
            dataGridView1.Location = new Point(783, 150);
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
            dataGridView1.TabIndex = 11;
            dataGridView1.SelectionChanged += btnCargarAsistencias_Click;
            // 
            // panelFiltro
            // 
            panelFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelFiltro.BackColor = SystemColors.GradientInactiveCaption;
            panelFiltro.Controls.Add(numericUpDownAnio);
            panelFiltro.Controls.Add(label3);
            panelFiltro.Controls.Add(btnCargarAsistencias);
            panelFiltro.Controls.Add(label4);
            panelFiltro.Controls.Add(cboMeses);
            panelFiltro.Controls.Add(btnMostrarEliminados);
            panelFiltro.Controls.Add(btnFiltroLimpiar);
            panelFiltro.Controls.Add(btnFiltroAutomotriz);
            panelFiltro.Controls.Add(btnFiltroCivil);
            panelFiltro.Controls.Add(btnFiltroElectrica);
            panelFiltro.Controls.Add(btnFiltroMecanica);
            panelFiltro.Location = new Point(770, 51);
            panelFiltro.Name = "panelFiltro";
            panelFiltro.Size = new Size(580, 389);
            panelFiltro.TabIndex = 14;
            // 
            // numericUpDownAnio
            // 
            numericUpDownAnio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numericUpDownAnio.Location = new Point(338, 357);
            numericUpDownAnio.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDownAnio.Name = "numericUpDownAnio";
            numericUpDownAnio.Size = new Size(120, 23);
            numericUpDownAnio.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(338, 339);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 18;
            label3.Text = "Año ";
            // 
            // btnCargarAsistencias
            // 
            btnCargarAsistencias.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCargarAsistencias.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarAsistencias.Location = new Point(18, 334);
            btnCargarAsistencias.MaximumSize = new Size(86, 48);
            btnCargarAsistencias.MinimumSize = new Size(86, 48);
            btnCargarAsistencias.Name = "btnCargarAsistencias";
            btnCargarAsistencias.Size = new Size(86, 48);
            btnCargarAsistencias.TabIndex = 17;
            btnCargarAsistencias.Text = "Ver asistencias";
            btnCargarAsistencias.UseVisualStyleBackColor = true;
            btnCargarAsistencias.Click += btnCargarAsistencias_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(122, 339);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 17;
            label4.Text = "Mes ";
            // 
            // cboMeses
            // 
            cboMeses.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMeses.FormattingEnabled = true;
            cboMeses.Location = new Point(122, 359);
            cboMeses.Name = "cboMeses";
            cboMeses.Size = new Size(196, 23);
            cboMeses.TabIndex = 12;
            // 
            // btnMostrarEliminados
            // 
            btnMostrarEliminados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMostrarEliminados.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarEliminados.Location = new Point(263, 623);
            btnMostrarEliminados.MaximumSize = new Size(86, 48);
            btnMostrarEliminados.MinimumSize = new Size(86, 48);
            btnMostrarEliminados.Name = "btnMostrarEliminados";
            btnMostrarEliminados.Size = new Size(86, 48);
            btnMostrarEliminados.TabIndex = 11;
            btnMostrarEliminados.Text = "Mostrar eliminados";
            btnMostrarEliminados.UseVisualStyleBackColor = true;
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
            // lblAnioSeleccionado
            // 
            lblAnioSeleccionado.AutoSize = true;
            lblAnioSeleccionado.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnioSeleccionado.Location = new Point(293, 6);
            lblAnioSeleccionado.Name = "lblAnioSeleccionado";
            lblAnioSeleccionado.Size = new Size(0, 30);
            lblAnioSeleccionado.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 6);
            label5.Name = "label5";
            label5.Size = new Size(63, 30);
            label5.TabIndex = 18;
            label5.Text = "Mes:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(225, 6);
            label6.Name = "label6";
            label6.Size = new Size(62, 30);
            label6.TabIndex = 19;
            label6.Text = "Año:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblNombreInvestigador);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(2, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(709, 614);
            panel2.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(611, 76);
            label13.Name = "label13";
            label13.Size = new Size(74, 20);
            label13.TabIndex = 28;
            label13.Text = "Domingo";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(519, 76);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 27;
            label12.Text = "Sábado";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(422, 76);
            label11.Name = "label11";
            label11.Size = new Size(61, 20);
            label11.TabIndex = 26;
            label11.Text = "Viernes";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(326, 76);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 25;
            label10.Text = "Jueves";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(218, 76);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 24;
            label9.Text = "Miércoles";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(128, 76);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 23;
            label8.Text = "Martes";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 76);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 22;
            label7.Text = "Lunes";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(lblAnioSeleccionado);
            panel3.Controls.Add(lblNombreMes);
            panel3.Location = new Point(11, 544);
            panel3.Name = "panel3";
            panel3.Size = new Size(436, 44);
            panel3.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(711, 47);
            panel4.TabIndex = 21;
            // 
            // FormAsistenciasInvestigador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1370, 738);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblFiltros);
            Controls.Add(dataGridView1);
            Controls.Add(panelFiltro);
            Name = "FormAsistenciasInvestigador";
            Text = "Formulario Asistencias";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFiltro.ResumeLayout(false);
            panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnio).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label lblNombreMes;
        private Label lblNombreInvestigador;
        private Panel panel1;
        private Label label2;
        private Label lblFiltros;
        private Button btnFiltroLimpiar;
        private DataGridView dataGridView1;
        private Panel panelFiltro;
        private Button btnMostrarEliminados;
        private Button btnFiltroAutomotriz;
        private Button btnFiltroCivil;
        private Button btnFiltroElectrica;
        private Button btnFiltroMecanica;
        private Label label4;
        private ComboBox cboMeses;
        private Button btnCargarAsistencias;
        private Label label3;
        private Label lblAnioSeleccionado;
        private Label label5;
        private Label label6;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown numericUpDownAnio;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
    }
}
