namespace WindowsFormsApplication1
{

    partial class AdministrarDiseño
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarDiseño));
            this.titulolabel1 = new System.Windows.Forms.Label();
            this.listDiseños = new System.Windows.Forms.ListBox();
            this.volverbutton1 = new System.Windows.Forms.Button();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.editarbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.eliminarbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulolabel1
            // 
            this.titulolabel1.AutoSize = true;
            this.titulolabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.titulolabel1.Location = new System.Drawing.Point(20, 12);
            this.titulolabel1.Name = "titulolabel1";
            this.titulolabel1.Size = new System.Drawing.Size(127, 17);
            this.titulolabel1.TabIndex = 10;
            this.titulolabel1.Text = "Lista de diseños";
            // 
            // listDiseños
            // 
            this.listDiseños.FormattingEnabled = true;
            this.listDiseños.HorizontalScrollbar = true;
            this.listDiseños.Location = new System.Drawing.Point(23, 38);
            this.listDiseños.Name = "listDiseños";
            this.listDiseños.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listDiseños.ScrollAlwaysVisible = true;
            this.listDiseños.Size = new System.Drawing.Size(332, 160);
            this.listDiseños.TabIndex = 8;
            // 
            // volverbutton1
            // 
            this.volverbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volverbutton1.Location = new System.Drawing.Point(23, 206);
            this.volverbutton1.Name = "volverbutton1";
            this.volverbutton1.Size = new System.Drawing.Size(88, 25);
            this.volverbutton1.TabIndex = 12;
            this.volverbutton1.Text = "Volver";
            this.volverbutton1.UseVisualStyleBackColor = true;
            this.volverbutton1.Click += new System.EventHandler(this.volverbutton1_Click_1);
            // 
            // refreshbutton
            // 
            this.refreshbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411981930_Synchronize;
            this.refreshbutton.Location = new System.Drawing.Point(361, 118);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(43, 34);
            this.refreshbutton.TabIndex = 26;
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // editarbutton
            // 
            this.editarbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411979916_Pencil_24;
            this.editarbutton.Location = new System.Drawing.Point(361, 78);
            this.editarbutton.Name = "editarbutton";
            this.editarbutton.Size = new System.Drawing.Size(43, 34);
            this.editarbutton.TabIndex = 24;
            this.editarbutton.UseVisualStyleBackColor = true;
            this.editarbutton.Click += new System.EventHandler(this.editarbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Image = global::WindowsFormsApplication1.Properties.Resources._1411978217_Add;
            this.addbutton.Location = new System.Drawing.Point(361, 38);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(43, 34);
            this.addbutton.TabIndex = 23;
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // eliminarbutton1
            // 
            this.eliminarbutton1.Location = new System.Drawing.Point(361, 89);
            this.eliminarbutton1.Name = "eliminarbutton1";
            this.eliminarbutton1.Size = new System.Drawing.Size(28, 23);
            this.eliminarbutton1.TabIndex = 22;
            this.eliminarbutton1.Text = "x";
            this.eliminarbutton1.UseVisualStyleBackColor = true;
            // 
            // AdministrarDiseño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 239);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.editarbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.eliminarbutton1);
            this.Controls.Add(this.volverbutton1);
            this.Controls.Add(this.titulolabel1);
            this.Controls.Add(this.listDiseños);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministrarDiseño";
            this.Text = "Administrar diseños";
            this.Load += new System.EventHandler(this.AdministrarDiseño_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label titulolabel1;

        private System.Windows.Forms.ListBox listDiseños;

        private System.Windows.Forms.Button volverbutton1;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.Button editarbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button eliminarbutton1;

    }

}