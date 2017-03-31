namespace WindowsFormsApplication1
{
    partial class AdministrarDron
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarDron));
            this.titulolabel1 = new System.Windows.Forms.Label();
            this.listDrones = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.elimiarbutton = new System.Windows.Forms.Button();
            this.editarbutton = new System.Windows.Forms.Button();
            this.agregarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulolabel1
            // 
            this.titulolabel1.AutoSize = true;
            this.titulolabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.titulolabel1.Location = new System.Drawing.Point(12, 9);
            this.titulolabel1.Name = "titulolabel1";
            this.titulolabel1.Size = new System.Drawing.Size(121, 17);
            this.titulolabel1.TabIndex = 11;
            this.titulolabel1.Text = "Lista de drones";
            // 
            // listDrones
            // 
            this.listDrones.FormattingEnabled = true;
            this.listDrones.Location = new System.Drawing.Point(15, 39);
            this.listDrones.Name = "listDrones";
            this.listDrones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listDrones.ScrollAlwaysVisible = true;
            this.listDrones.Size = new System.Drawing.Size(332, 160);
            this.listDrones.TabIndex = 12;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(15, 205);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(88, 26);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // refreshbutton
            // 
            this.refreshbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411981930_Synchronize;
            this.refreshbutton.Location = new System.Drawing.Point(353, 160);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(43, 34);
            this.refreshbutton.TabIndex = 26;
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // elimiarbutton
            // 
            this.elimiarbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411979194_Delete;
            this.elimiarbutton.Location = new System.Drawing.Point(353, 120);
            this.elimiarbutton.Name = "elimiarbutton";
            this.elimiarbutton.Size = new System.Drawing.Size(43, 34);
            this.elimiarbutton.TabIndex = 25;
            this.elimiarbutton.UseVisualStyleBackColor = true;
            this.elimiarbutton.Click += new System.EventHandler(this.elimiarbutton_Click);
            // 
            // editarbutton
            // 
            this.editarbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411979916_Pencil_24;
            this.editarbutton.Location = new System.Drawing.Point(353, 80);
            this.editarbutton.Name = "editarbutton";
            this.editarbutton.Size = new System.Drawing.Size(43, 34);
            this.editarbutton.TabIndex = 24;
            this.editarbutton.UseVisualStyleBackColor = true;
            this.editarbutton.Click += new System.EventHandler(this.editarbutton_Click);
            // 
            // agregarbutton
            // 
            this.agregarbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411978217_Add;
            this.agregarbutton.Location = new System.Drawing.Point(353, 40);
            this.agregarbutton.Name = "agregarbutton";
            this.agregarbutton.Size = new System.Drawing.Size(43, 34);
            this.agregarbutton.TabIndex = 23;
            this.agregarbutton.UseVisualStyleBackColor = true;
            this.agregarbutton.Click += new System.EventHandler(this.agregarbutton_Click);
            // 
            // AdministrarDron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 242);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.elimiarbutton);
            this.Controls.Add(this.editarbutton);
            this.Controls.Add(this.agregarbutton);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.listDrones);
            this.Controls.Add(this.titulolabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarDron";
            this.Text = "Administrar Drones";
            this.Load += new System.EventHandler(this.AdministrarDron_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulolabel1;
        private System.Windows.Forms.ListBox listDrones;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.Button elimiarbutton;
        private System.Windows.Forms.Button editarbutton;
        private System.Windows.Forms.Button agregarbutton;
    }
}