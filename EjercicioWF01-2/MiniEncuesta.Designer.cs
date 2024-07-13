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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniEncuesta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.rbLinux = new System.Windows.Forms.RadioButton();
            this.rbMac = new System.Windows.Forms.RadioButton();
            this.chkbProgramacion = new System.Windows.Forms.CheckBox();
            this.chkbGrafico = new System.Windows.Forms.CheckBox();
            this.chkbAdministracion = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudHoras = new System.Windows.Forms.NumericUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige tu sistema operativo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elige tu especialidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas que dedicas al ordenador:";
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Location = new System.Drawing.Point(34, 62);
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
            this.rbLinux.Location = new System.Drawing.Point(34, 101);
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
            this.rbMac.Location = new System.Drawing.Point(34, 136);
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
            this.chkbProgramacion.Location = new System.Drawing.Point(36, 222);
            this.chkbProgramacion.Name = "chkbProgramacion";
            this.chkbProgramacion.Size = new System.Drawing.Size(114, 20);
            this.chkbProgramacion.TabIndex = 6;
            this.chkbProgramacion.Text = "Programación";
            this.chkbProgramacion.UseVisualStyleBackColor = true;
            this.chkbProgramacion.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkbGrafico
            // 
            this.chkbGrafico.AutoSize = true;
            this.chkbGrafico.Location = new System.Drawing.Point(36, 265);
            this.chkbGrafico.Name = "chkbGrafico";
            this.chkbGrafico.Size = new System.Drawing.Size(118, 20);
            this.chkbGrafico.TabIndex = 7;
            this.chkbGrafico.Text = "Diseño Gráfico";
            this.chkbGrafico.UseVisualStyleBackColor = true;
            // 
            // chkbAdministracion
            // 
            this.chkbAdministracion.AutoSize = true;
            this.chkbAdministracion.Location = new System.Drawing.Point(36, 307);
            this.chkbAdministracion.Name = "chkbAdministracion";
            this.chkbAdministracion.Size = new System.Drawing.Size(117, 20);
            this.chkbAdministracion.TabIndex = 8;
            this.chkbAdministracion.Text = "Administración";
            this.chkbAdministracion.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 495);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nudHoras
            // 
            this.nudHoras.Location = new System.Drawing.Point(34, 374);
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
            this.btnGenerar.Location = new System.Drawing.Point(20, 430);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(134, 29);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.Text = "Generar Informe";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // MiniEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.nudHoras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkbAdministracion);
            this.Controls.Add(this.chkbGrafico);
            this.Controls.Add(this.chkbProgramacion);
            this.Controls.Add(this.rbMac);
            this.Controls.Add(this.rbLinux);
            this.Controls.Add(this.rbWindows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "MiniEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Encuesta";
            this.Load += new System.EventHandler(this.MiniEncuesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbWindows;
        private System.Windows.Forms.RadioButton rbLinux;
        private System.Windows.Forms.RadioButton rbMac;
        private System.Windows.Forms.CheckBox chkbProgramacion;
        private System.Windows.Forms.CheckBox chkbGrafico;
        private System.Windows.Forms.CheckBox chkbAdministracion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudHoras;
        private System.Windows.Forms.Button btnGenerar;
    }
}

