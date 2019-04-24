namespace GuiaIIProgra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertidorDeTemperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio01ToolStripMenuItem,
            this.ejercToolStripMenuItem,
            this.convertidorDeTemperaturaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios";
            // 
            // ejercicio01ToolStripMenuItem
            // 
            this.ejercicio01ToolStripMenuItem.Name = "ejercicio01ToolStripMenuItem";
            this.ejercicio01ToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ejercicio01ToolStripMenuItem.Text = "MessageBox";
            this.ejercicio01ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio01ToolStripMenuItem_Click);
            // 
            // ejercToolStripMenuItem
            // 
            this.ejercToolStripMenuItem.Name = "ejercToolStripMenuItem";
            this.ejercToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ejercToolStripMenuItem.Text = "Visor de Imagenes";
            this.ejercToolStripMenuItem.Click += new System.EventHandler(this.ejercToolStripMenuItem_Click);
            // 
            // convertidorDeTemperaturaToolStripMenuItem
            // 
            this.convertidorDeTemperaturaToolStripMenuItem.Name = "convertidorDeTemperaturaToolStripMenuItem";
            this.convertidorDeTemperaturaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.convertidorDeTemperaturaToolStripMenuItem.Text = "Convertidor de Temperatura";
            this.convertidorDeTemperaturaToolStripMenuItem.Click += new System.EventHandler(this.convertidorDeTemperaturaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 474);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ejercicios PrograII";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertidorDeTemperaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

