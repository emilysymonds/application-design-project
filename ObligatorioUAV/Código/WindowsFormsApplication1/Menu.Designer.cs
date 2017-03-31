namespace WindowsFormsApplication1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.piezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.droneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearDiseñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearDroneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSimulaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.droneToolStripMenuItem,
            this.simulaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.piezaToolStripMenuItem,
            this.componenteToolStripMenuItem});
            this.crearToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(163, 23);
            this.crearToolStripMenuItem.Text = "Componentes de vuelo";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // piezaToolStripMenuItem
            // 
            this.piezaToolStripMenuItem.Name = "piezaToolStripMenuItem";
            this.piezaToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.piezaToolStripMenuItem.Text = "Administrar Piezas";
            this.piezaToolStripMenuItem.Click += new System.EventHandler(this.piezaToolStripMenuItem_Click);
            // 
            // componenteToolStripMenuItem
            // 
            this.componenteToolStripMenuItem.Name = "componenteToolStripMenuItem";
            this.componenteToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.componenteToolStripMenuItem.Text = "Administrar Componentes Reusables";
            this.componenteToolStripMenuItem.Click += new System.EventHandler(this.componenteToolStripMenuItem_Click);
            // 
            // droneToolStripMenuItem
            // 
            this.droneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearDiseñoToolStripMenuItem,
            this.crearDroneToolStripMenuItem});
            this.droneToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.droneToolStripMenuItem.Name = "droneToolStripMenuItem";
            this.droneToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.droneToolStripMenuItem.Text = "Drone";
            // 
            // crearDiseñoToolStripMenuItem
            // 
            this.crearDiseñoToolStripMenuItem.Name = "crearDiseñoToolStripMenuItem";
            this.crearDiseñoToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.crearDiseñoToolStripMenuItem.Text = "Administrar Diseños";
            this.crearDiseñoToolStripMenuItem.Click += new System.EventHandler(this.crearDiseñoToolStripMenuItem_Click);
            // 
            // crearDroneToolStripMenuItem
            // 
            this.crearDroneToolStripMenuItem.Name = "crearDroneToolStripMenuItem";
            this.crearDroneToolStripMenuItem.Size = new System.Drawing.Size(201, 24);
            this.crearDroneToolStripMenuItem.Text = "Administrar Drones";
            this.crearDroneToolStripMenuItem.Click += new System.EventHandler(this.crearDroneToolStripMenuItem_Click);
            // 
            // simulaciónToolStripMenuItem
            // 
            this.simulaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSimulaciónToolStripMenuItem});
            this.simulaciónToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.simulaciónToolStripMenuItem.Name = "simulaciónToolStripMenuItem";
            this.simulaciónToolStripMenuItem.Size = new System.Drawing.Size(86, 23);
            this.simulaciónToolStripMenuItem.Text = "Simulación";
            // 
            // iniciarSimulaciónToolStripMenuItem
            // 
            this.iniciarSimulaciónToolStripMenuItem.Name = "iniciarSimulaciónToolStripMenuItem";
            this.iniciarSimulaciónToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.iniciarSimulaciónToolStripMenuItem.Text = "Iniciar Simulación";
            this.iniciarSimulaciónToolStripMenuItem.Click += new System.EventHandler(this.iniciarSimulaciónToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.drone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(632, 360);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "UAV";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem piezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem droneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearDiseñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearDroneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSimulaciónToolStripMenuItem;
    }
}

