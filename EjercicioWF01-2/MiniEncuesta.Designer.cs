namespace EjercicioWF01_2
{
    partial class MiniEncuesta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.rbLinux = new System.Windows.Forms.RadioButton();
            this.rbMac = new System.Windows.Forms.RadioButton();
            this.chkbProgramacion = new System.Windows.Forms.CheckBox();
            this.chkbGrafico = new System.Windows.Forms.CheckBox();
            this.chkbAdministracion = new System.Windows.Forms.CheckBox();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.GbSistema = new System.Windows.Forms.GroupBox();
            this.GbEspecialidad = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.GbSistema.SuspendLayout();
            this.GbEspecialidad.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas que dedicas al ordenador:";
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Location = new System.Drawing.Point(6, 21);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(83, 20);
            this.rbWindows.TabIndex = 3;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "Windows";
            this.rbWindows.UseVisualStyleBackColor = true;
            // 
            // rbLinux
            // 
            this.rbLinux.AutoSize = true;
            this.rbLinux.Location = new System.Drawing.Point(6, 47);
            this.rbLinux.Name = "rbLinux";
            this.rbLinux.Size = new System.Drawing.Size(58, 20);
            this.rbLinux.TabIndex = 4;
            this.rbLinux.TabStop = true;
            this.rbLinux.Text = "Linux";
            this.rbLinux.UseVisualStyleBackColor = true;
            // 
            // rbMac
            // 
            this.rbMac.AutoSize = true;
            this.rbMac.Location = new System.Drawing.Point(6, 73);
            this.rbMac.Name = "rbMac";
            this.rbMac.Size = new System.Drawing.Size(54, 20);
            this.rbMac.TabIndex = 5;
            this.rbMac.TabStop = true;
            this.rbMac.Text = "Mac";
            this.rbMac.UseVisualStyleBackColor = true;
            // 
            // chkbProgramacion
            // 
            this.chkbProgramacion.AutoSize = true;
            this.chkbProgramacion.Location = new System.Drawing.Point(6, 21);
            this.chkbProgramacion.Name = "chkbProgramacion";
            this.chkbProgramacion.Size = new System.Drawing.Size(114, 20);
            this.chkbProgramacion.TabIndex = 6;
            this.chkbProgramacion.Text = "Programación";
            this.chkbProgramacion.UseVisualStyleBackColor = true;
           
            // 
            // chkbGrafico
            // 
            this.chkbGrafico.AutoSize = true;
            this.chkbGrafico.Location = new System.Drawing.Point(6, 47);
            this.chkbGrafico.Name = "chkbGrafico";
            this.chkbGrafico.Size = new System.Drawing.Size(118, 20);
            this.chkbGrafico.TabIndex = 7;
            this.chkbGrafico.Text = "Diseño Gráfico";
            this.chkbGrafico.UseVisualStyleBackColor = true;
            // 
            // chkbAdministracion
            // 
            this.chkbAdministracion.AutoSize = true;
            this.chkbAdministracion.Location = new System.Drawing.Point(6, 74);
            this.chkbAdministracion.Name = "chkbAdministracion";
            this.chkbAdministracion.Size = new System.Drawing.Size(117, 20);
            this.chkbAdministracion.TabIndex = 8;
            this.chkbAdministracion.Text = "Administración";
            this.chkbAdministracion.UseVisualStyleBackColor = true;
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(16, 35);
            this.nudHoras.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHoras.Name = "nudHoras";
            this.nudHoras.Size = new System.Drawing.Size(156, 22);
            this.nudHoras.TabIndex = 10;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(16, 63);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(156, 42);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar Informe";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // GbSistema
            // 
            this.GbSistema.Controls.Add(this.rbWindows);
            this.GbSistema.Controls.Add(this.rbLinux);
            this.GbSistema.Controls.Add(this.rbMac);
            this.GbSistema.Location = new System.Drawing.Point(16, 115);
            this.GbSistema.Name = "GbSistema";
            this.GbSistema.Size = new System.Drawing.Size(297, 120);
            this.GbSistema.TabIndex = 12;
            this.GbSistema.TabStop = false;
            this.GbSistema.Text = "Elige Sistema Operativo";
            // 
            // GbEspecialidad
            // 
            this.GbEspecialidad.Controls.Add(this.chkbProgramacion);
            this.GbEspecialidad.Controls.Add(this.chkbGrafico);
            this.GbEspecialidad.Controls.Add(this.chkbAdministracion);
            this.GbEspecialidad.Location = new System.Drawing.Point(16, 261);
            this.GbEspecialidad.Name = "GbEspecialidad";
            this.GbEspecialidad.Size = new System.Drawing.Size(297, 99);
            this.GbEspecialidad.TabIndex = 13;
            this.GbEspecialidad.TabStop = false;
            this.GbEspecialidad.Text = "Elige Especialidad";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudHoras);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 163);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 86);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MINI ENCUESTA INFORMÁTICA";
            // 
            // MiniEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GbEspecialidad);
            this.Controls.Add(this.GbSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "MiniEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Encuesta";
          
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.GbSistema.ResumeLayout(false);
            this.GbSistema.PerformLayout();
            this.GbEspecialidad.ResumeLayout(false);
            this.GbEspecialidad.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbWindows;
        private System.Windows.Forms.RadioButton rbLinux;
        private System.Windows.Forms.RadioButton rbMac;
        private System.Windows.Forms.CheckBox chkbProgramacion;
        private System.Windows.Forms.CheckBox chkbGrafico;
        private System.Windows.Forms.CheckBox chkbAdministracion;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox GbSistema;
        private System.Windows.Forms.GroupBox GbEspecialidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

