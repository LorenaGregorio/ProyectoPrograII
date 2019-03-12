namespace ProyectoPrograII
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aerolineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aerolineasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pistasDeAterrizajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aerolineasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aerolineasToolStripMenuItem
            // 
            this.aerolineasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aerolineasToolStripMenuItem1,
            this.avionesToolStripMenuItem,
            this.pistasDeAterrizajeToolStripMenuItem});
            this.aerolineasToolStripMenuItem.Name = "aerolineasToolStripMenuItem";
            this.aerolineasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aerolineasToolStripMenuItem.Text = "Menú";
            this.aerolineasToolStripMenuItem.Click += new System.EventHandler(this.aerolineasToolStripMenuItem_Click);
            // 
            // aerolineasToolStripMenuItem1
            // 
            this.aerolineasToolStripMenuItem1.Name = "aerolineasToolStripMenuItem1";
            this.aerolineasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aerolineasToolStripMenuItem1.Text = "Aerolineas";
            this.aerolineasToolStripMenuItem1.Click += new System.EventHandler(this.aerolineasToolStripMenuItem1_Click);
            // 
            // avionesToolStripMenuItem
            // 
            this.avionesToolStripMenuItem.Name = "avionesToolStripMenuItem";
            this.avionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avionesToolStripMenuItem.Text = "Aviones";
            this.avionesToolStripMenuItem.Click += new System.EventHandler(this.avionesToolStripMenuItem_Click);
            // 
            // pistasDeAterrizajeToolStripMenuItem
            // 
            this.pistasDeAterrizajeToolStripMenuItem.Name = "pistasDeAterrizajeToolStripMenuItem";
            this.pistasDeAterrizajeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pistasDeAterrizajeToolStripMenuItem.Text = "Plan de Vuelo";
            this.pistasDeAterrizajeToolStripMenuItem.Click += new System.EventHandler(this.pistasDeAterrizajeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aerolineasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aerolineasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem avionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pistasDeAterrizajeToolStripMenuItem;
    }
}

